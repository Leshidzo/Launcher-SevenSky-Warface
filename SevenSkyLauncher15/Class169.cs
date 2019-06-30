using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x020001AE RID: 430
internal class Class169 : Class167
{
	// Token: 0x06000EE5 RID: 3813 RVA: 0x0000CC9C File Offset: 0x0000AE9C
	[CompilerGenerated]
	public object method_2()
	{
		return this.object_0;
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
	[CompilerGenerated]
	public void method_3(object object_2)
	{
		this.object_0 = object_2;
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x0000CCAD File Offset: 0x0000AEAD
	[CompilerGenerated]
	public object method_4()
	{
		return this.object_1;
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x0000CCB5 File Offset: 0x0000AEB5
	[CompilerGenerated]
	public void method_5(object object_2)
	{
		this.object_1 = object_2;
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00045E68 File Offset: 0x00044068
	private IEnumerable<JToken> method_6(JToken jtoken_0, JToken jtoken_1, object object_2)
	{
		JToken jtoken;
		if ((jtoken = (object_2 as JToken)) != null)
		{
			return new JToken[]
			{
				jtoken
			};
		}
		List<Class156> list_;
		if ((list_ = (object_2 as List<Class156>)) != null)
		{
			return Class155.smethod_1(list_, jtoken_0, jtoken_1, false);
		}
		return Class20.smethod_17<JToken>();
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00045EA4 File Offset: 0x000440A4
	public override bool vmethod_0(JToken jtoken_0, JToken jtoken_1)
	{
		if (base.method_0() == (Enum10)3)
		{
			return this.method_6(jtoken_0, jtoken_1, this.method_2()).Any<JToken>();
		}
		using (IEnumerator<JToken> enumerator = this.method_6(jtoken_0, jtoken_1, this.method_2()).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				IEnumerable<JToken> enumerable = this.method_6(jtoken_0, jtoken_1, this.method_4());
				ICollection<JToken> collection = (enumerable as ICollection<JToken>) ?? enumerable.ToList<JToken>();
				do
				{
					JToken jtoken_2 = enumerator.Current;
					foreach (JToken jtoken_3 in collection)
					{
						if (this.method_7(jtoken_2, jtoken_3))
						{
							return true;
						}
					}
				}
				while (enumerator.MoveNext());
			}
		}
		return false;
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00045F84 File Offset: 0x00044184
	private bool method_7(JToken jtoken_0, JToken jtoken_1)
	{
		JValue jvalue;
		JValue jvalue2;
		if ((jvalue = (jtoken_0 as JValue)) != null && (jvalue2 = (jtoken_1 as JValue)) != null)
		{
			switch (base.method_0())
			{
			case (Enum10)1:
				if (Class169.smethod_1(jvalue, jvalue2))
				{
					return true;
				}
				break;
			case (Enum10)2:
				if (!Class169.smethod_1(jvalue, jvalue2))
				{
					return true;
				}
				break;
			case (Enum10)3:
				return true;
			case (Enum10)4:
				if (jvalue.CompareTo(jvalue2) < 0)
				{
					return true;
				}
				break;
			case (Enum10)5:
				if (jvalue.CompareTo(jvalue2) <= 0)
				{
					return true;
				}
				break;
			case (Enum10)6:
				if (jvalue.CompareTo(jvalue2) > 0)
				{
					return true;
				}
				break;
			case (Enum10)7:
				if (jvalue.CompareTo(jvalue2) >= 0)
				{
					return true;
				}
				break;
			case (Enum10)10:
				if (Class169.smethod_0(jvalue, jvalue2))
				{
					return true;
				}
				break;
			case (Enum10)11:
				if (Class169.smethod_2(jvalue, jvalue2))
				{
					return true;
				}
				break;
			case (Enum10)12:
				if (!Class169.smethod_2(jvalue, jvalue2))
				{
					return true;
				}
				break;
			}
		}
		else
		{
			Enum10 @enum = base.method_0();
			if (@enum - (Enum10)2 <= 1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00046068 File Offset: 0x00044268
	private static bool smethod_0(object object_2, object object_3)
	{
		if (object_2.Type == JTokenType.String)
		{
			if (object_3.Type == JTokenType.String)
			{
				string text = (string)object_3.Value;
				int num = text.LastIndexOf('/');
				string pattern = text.Substring(1, num - 1);
				string string_ = text.Substring(num + 1);
				return Regex.IsMatch((string)object_2.Value, pattern, Class80.smethod_7(string_));
			}
		}
		return false;
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x000460CC File Offset: 0x000442CC
	internal static bool smethod_1(object object_2, object object_3)
	{
		if (object_2.Equals(object_3))
		{
			return true;
		}
		if ((object_2.Type == JTokenType.Integer && object_3.Type == JTokenType.Float) || (object_2.Type == JTokenType.Float && object_3.Type == JTokenType.Integer))
		{
			return JValue.smethod_7(object_2.Type, object_2.Value, object_3.Value) == 0;
		}
		if (object_3.Type != JTokenType.String)
		{
			return false;
		}
		string b = (string)object_3.Value;
		string a;
		switch (object_2.Type)
		{
		case JTokenType.Date:
			using (StringWriter stringWriter = Class97.smethod_6(64))
			{
				object value;
				if ((value = object_2.Value) is DateTimeOffset)
				{
					DateTimeOffset dateTimeOffset_ = (DateTimeOffset)value;
					Class25.IxisRjgvuh(stringWriter, dateTimeOffset_, DateFormatHandling.IsoDateFormat, null, CultureInfo.InvariantCulture);
				}
				else
				{
					Class25.smethod_24(stringWriter, (DateTime)object_2.Value, DateFormatHandling.IsoDateFormat, null, CultureInfo.InvariantCulture);
				}
				a = stringWriter.ToString();
				goto IL_11C;
			}
			break;
		case JTokenType.Bytes:
			a = Convert.ToBase64String((byte[])object_2.Value);
			goto IL_11C;
		case JTokenType.Guid:
		case JTokenType.TimeSpan:
			a = object_2.Value.ToString();
			goto IL_11C;
		case JTokenType.Uri:
			a = ((Uri)object_2.Value).OriginalString;
			goto IL_11C;
		}
		return false;
		IL_11C:
		return string.Equals(a, b, StringComparison.Ordinal);
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00046210 File Offset: 0x00044410
	internal static bool smethod_2(object object_2, object object_3)
	{
		if ((object_2.Type == JTokenType.Integer && object_3.Type == JTokenType.Float) || (object_2.Type == JTokenType.Float && object_3.Type == JTokenType.Integer))
		{
			return JValue.smethod_7(object_2.Type, object_2.Value, object_3.Value) == 0;
		}
		return object_2.Type == object_3.Type && object_2.Equals(object_3);
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x0000CCBE File Offset: 0x0000AEBE
	public Class169()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x04000740 RID: 1856
	[CompilerGenerated]
	private object object_0;

	// Token: 0x04000741 RID: 1857
	[CompilerGenerated]
	private object object_1;
}
