using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

// Token: 0x02000115 RID: 277
internal class Class113 : GInterface1
{
	// Token: 0x06000838 RID: 2104 RVA: 0x000319C0 File Offset: 0x0002FBC0
	private Class19<string, object> method_0(object object_0)
	{
		Class117 @class;
		if ((@class = (object_0 as Class117)) == null)
		{
			Class9 class2;
			if ((class2 = (object_0 as Class9)) == null)
			{
				throw new JsonException("The DefaultReferenceResolver can only be used internally.");
			}
			@class = class2.method_7();
		}
		return @class.method_0();
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x000319FC File Offset: 0x0002FBFC
	public object ResolveReference(object context, string reference)
	{
		object result;
		this.method_0(context).cvuFbgqpr0(reference, out result);
		return result;
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00031A1C File Offset: 0x0002FC1C
	public string GetReference(object context, object value)
	{
		Class19<string, object> @class = this.method_0(context);
		string text;
		if (!@class.method_0(value, out text))
		{
			this.int_0++;
			text = this.int_0.ToString(CultureInfo.InvariantCulture);
			@class.Set(text, value);
		}
		return text;
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x000083B1 File Offset: 0x000065B1
	public void AddReference(object context, string reference, object value)
	{
		this.method_0(context).Set(reference, value);
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x00031A64 File Offset: 0x0002FC64
	public bool IsReferenced(object context, object value)
	{
		string text;
		return this.method_0(context).method_0(value, out text);
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x00002621 File Offset: 0x00000821
	public Class113()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x040004C6 RID: 1222
	private int int_0;
}
