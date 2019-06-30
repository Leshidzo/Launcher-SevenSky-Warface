using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Schema;

// Token: 0x02000159 RID: 345
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class Class137
{
	// Token: 0x06000B4C RID: 2892 RVA: 0x0000A8EC File Offset: 0x00008AEC
	[CompilerGenerated]
	public string method_0()
	{
		return this.string_0;
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x0000A8F4 File Offset: 0x00008AF4
	[CompilerGenerated]
	public ReadOnlyCollection<JsonSchema> method_1()
	{
		return this.readOnlyCollection_0;
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x0000A8FC File Offset: 0x00008AFC
	[CompilerGenerated]
	public Dictionary<string, Class137> method_2()
	{
		return this.dictionary_0;
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x0000A904 File Offset: 0x00008B04
	[CompilerGenerated]
	public Dictionary<string, Class137> method_3()
	{
		return this.dictionary_1;
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x0000A90C File Offset: 0x00008B0C
	[CompilerGenerated]
	public List<Class137> method_4()
	{
		return this.list_0;
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x0000A914 File Offset: 0x00008B14
	[CompilerGenerated]
	public Class137 method_5()
	{
		return this.class137_0;
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x0000A91C File Offset: 0x00008B1C
	[CompilerGenerated]
	public void method_6(Class137 class137_2)
	{
		this.class137_0 = class137_2;
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x0000A925 File Offset: 0x00008B25
	[CompilerGenerated]
	public Class137 method_7()
	{
		return this.class137_1;
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x0000A92D File Offset: 0x00008B2D
	[CompilerGenerated]
	public void method_8(Class137 class137_2)
	{
		this.class137_1 = class137_2;
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x0003AFF8 File Offset: 0x000391F8
	public Class137(JsonSchema jsonSchema_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.readOnlyCollection_0 = new ReadOnlyCollection<JsonSchema>(new JsonSchema[]
		{
			jsonSchema_0
		});
		this.dictionary_0 = new Dictionary<string, Class137>();
		this.dictionary_1 = new Dictionary<string, Class137>();
		this.list_0 = new List<Class137>();
		this.string_0 = Class137.smethod_0(this.method_1());
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x0003B058 File Offset: 0x00039258
	private Class137(Class137 class137_2, JsonSchema jsonSchema_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.readOnlyCollection_0 = new ReadOnlyCollection<JsonSchema>(class137_2.method_1().Union(new JsonSchema[]
		{
			jsonSchema_0
		}).ToList<JsonSchema>());
		this.dictionary_0 = new Dictionary<string, Class137>(class137_2.method_2());
		this.dictionary_1 = new Dictionary<string, Class137>(class137_2.method_3());
		this.list_0 = new List<Class137>(class137_2.method_4());
		this.method_6(class137_2.method_5());
		this.method_8(class137_2.method_7());
		this.string_0 = Class137.smethod_0(this.method_1());
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x0000A936 File Offset: 0x00008B36
	public Class137 method_9(JsonSchema jsonSchema_0)
	{
		return new Class137(this, jsonSchema_0);
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x0003B0F4 File Offset: 0x000392F4
	public static string smethod_0(IEnumerable<JsonSchema> ienumerable_0)
	{
		return string.Join("-", ienumerable_0.Select(new Func<JsonSchema, string>(Class137.Class138.class138_0.method_0)).OrderBy(new Func<string, string>(Class137.Class138.class138_0.method_1), StringComparer.Ordinal));
	}

	// Token: 0x040005CD RID: 1485
	[CompilerGenerated]
	private readonly string string_0;

	// Token: 0x040005CE RID: 1486
	[CompilerGenerated]
	private readonly ReadOnlyCollection<JsonSchema> readOnlyCollection_0;

	// Token: 0x040005CF RID: 1487
	[CompilerGenerated]
	private readonly Dictionary<string, Class137> dictionary_0;

	// Token: 0x040005D0 RID: 1488
	[CompilerGenerated]
	private readonly Dictionary<string, Class137> dictionary_1;

	// Token: 0x040005D1 RID: 1489
	[CompilerGenerated]
	private readonly List<Class137> list_0;

	// Token: 0x040005D2 RID: 1490
	[CompilerGenerated]
	private Class137 class137_0;

	// Token: 0x040005D3 RID: 1491
	[CompilerGenerated]
	private Class137 class137_1;

	// Token: 0x0200015A RID: 346
	[CompilerGenerated]
	[Serializable]
	private sealed class Class138
	{
		// Token: 0x06000B59 RID: 2905 RVA: 0x0000A93F File Offset: 0x00008B3F
		// Note: this type is marked as 'beforefieldinit'.
		static Class138()
		{
			Class202.ofdixO4zTbIfy();
			Class137.Class138.class138_0 = new Class137.Class138();
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00002621 File Offset: 0x00000821
		public Class138()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0000A950 File Offset: 0x00008B50
		internal string method_0(JsonSchema jsonSchema_0)
		{
			return jsonSchema_0.method_0();
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x000055AD File Offset: 0x000037AD
		internal string method_1(string string_0)
		{
			return string_0;
		}

		// Token: 0x040005D4 RID: 1492
		public static readonly Class137.Class138 class138_0;

		// Token: 0x040005D5 RID: 1493
		public static Func<JsonSchema, string> ifcVcjdub7;

		// Token: 0x040005D6 RID: 1494
		public static Func<string, string> func_0;
	}
}
