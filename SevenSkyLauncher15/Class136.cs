using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Schema;

// Token: 0x02000158 RID: 344
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class Class136
{
	// Token: 0x06000B43 RID: 2883 RVA: 0x0000A86D File Offset: 0x00008A6D
	public Class135 method_0(JsonSchema jsonSchema_0)
	{
		this.class139_0 = new Class139();
		this.class137_0 = this.method_1(null, jsonSchema_0);
		this.dictionary_0 = new Dictionary<Class137, Class135>();
		return this.method_7(this.class137_0);
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0003AC0C File Offset: 0x00038E0C
	public Class137 method_1(Class137 class137_1, JsonSchema jsonSchema_0)
	{
		string key;
		if (class137_1 != null)
		{
			if (class137_1.method_1().Contains(jsonSchema_0))
			{
				return class137_1;
			}
			key = Class137.smethod_0(class137_1.method_1().Union(new JsonSchema[]
			{
				jsonSchema_0
			}));
		}
		else
		{
			key = Class137.smethod_0(new JsonSchema[]
			{
				jsonSchema_0
			});
		}
		if (this.class139_0.Contains(key))
		{
			return this.class139_0[key];
		}
		Class137 @class = (class137_1 != null) ? class137_1.method_9(jsonSchema_0) : new Class137(jsonSchema_0);
		this.class139_0.Add(@class);
		this.method_2(jsonSchema_0.Properties, @class.method_2());
		this.method_2(jsonSchema_0.PatternProperties, @class.method_3());
		if (jsonSchema_0.Items != null)
		{
			for (int i = 0; i < jsonSchema_0.Items.Count; i++)
			{
				this.method_4(@class, i, jsonSchema_0.Items[i]);
			}
		}
		if (jsonSchema_0.AdditionalItems != null)
		{
			this.method_6(@class, jsonSchema_0.AdditionalItems);
		}
		if (jsonSchema_0.AdditionalProperties != null)
		{
			this.method_5(@class, jsonSchema_0.AdditionalProperties);
		}
		if (jsonSchema_0.Extends != null)
		{
			foreach (JsonSchema jsonSchema_ in jsonSchema_0.Extends)
			{
				@class = this.method_1(@class, jsonSchema_);
			}
		}
		return @class;
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x0003AD64 File Offset: 0x00038F64
	public void method_2(IDictionary<string, JsonSchema> idictionary_0, IDictionary<string, Class137> idictionary_1)
	{
		if (idictionary_0 != null)
		{
			foreach (KeyValuePair<string, JsonSchema> keyValuePair in idictionary_0)
			{
				this.method_3(idictionary_1, keyValuePair.Key, keyValuePair.Value);
			}
		}
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x0003ADC0 File Offset: 0x00038FC0
	public void method_3(IDictionary<string, Class137> idictionary_0, string string_0, JsonSchema jsonSchema_0)
	{
		Class137 class137_;
		idictionary_0.TryGetValue(string_0, out class137_);
		idictionary_0[string_0] = this.method_1(class137_, jsonSchema_0);
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x0003ADE8 File Offset: 0x00038FE8
	public void method_4(Class137 class137_1, int int_0, JsonSchema jsonSchema_0)
	{
		Class137 class137_2 = (class137_1.method_4().Count > int_0) ? class137_1.method_4()[int_0] : null;
		Class137 @class = this.method_1(class137_2, jsonSchema_0);
		if (class137_1.method_4().Count <= int_0)
		{
			class137_1.method_4().Add(@class);
			return;
		}
		class137_1.method_4()[int_0] = @class;
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x0000A89F File Offset: 0x00008A9F
	public void method_5(Class137 class137_1, JsonSchema jsonSchema_0)
	{
		class137_1.method_6(this.method_1(class137_1.method_5(), jsonSchema_0));
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x0000A8B4 File Offset: 0x00008AB4
	public void method_6(Class137 class137_1, JsonSchema jsonSchema_0)
	{
		class137_1.method_8(this.method_1(class137_1.method_7(), jsonSchema_0));
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0003AE44 File Offset: 0x00039044
	private Class135 method_7(Class137 class137_1)
	{
		Class135 @class;
		if (this.dictionary_0.TryGetValue(class137_1, out @class))
		{
			return @class;
		}
		@class = Class135.Create(class137_1.method_1());
		this.dictionary_0[class137_1] = @class;
		foreach (KeyValuePair<string, Class137> keyValuePair in class137_1.method_2())
		{
			if (@class.method_24() == null)
			{
				@class.method_25(new Dictionary<string, Class135>());
			}
			@class.method_24()[keyValuePair.Key] = this.method_7(keyValuePair.Value);
		}
		foreach (KeyValuePair<string, Class137> keyValuePair2 in class137_1.method_3())
		{
			if (@class.method_26() == null)
			{
				@class.method_27(new Dictionary<string, Class135>());
			}
			@class.method_26()[keyValuePair2.Key] = this.method_7(keyValuePair2.Value);
		}
		foreach (Class137 class137_2 in class137_1.method_4())
		{
			if (@class.method_22() == null)
			{
				@class.method_23(new List<Class135>());
			}
			@class.method_22().Add(this.method_7(class137_2));
		}
		if (class137_1.method_5() != null)
		{
			@class.method_29(this.method_7(class137_1.method_5()));
		}
		if (class137_1.method_7() != null)
		{
			@class.method_31(this.method_7(class137_1.method_7()));
		}
		return @class;
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x0000A8C9 File Offset: 0x00008AC9
	public Class136()
	{
		Class202.ofdixO4zTbIfy();
		this.class139_0 = new Class139();
		this.dictionary_0 = new Dictionary<Class137, Class135>();
		base..ctor();
	}

	// Token: 0x040005CA RID: 1482
	private Class139 class139_0;

	// Token: 0x040005CB RID: 1483
	private Dictionary<Class137, Class135> dictionary_0;

	// Token: 0x040005CC RID: 1484
	private Class137 class137_0;
}
