using System;
using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

// Token: 0x0200012E RID: 302
internal class Class116 : IFormatterConverter
{
	// Token: 0x060008CB RID: 2251 RVA: 0x0000893E File Offset: 0x00006B3E
	public Class116(Class118 class118_1, JsonISerializableContract jsonISerializableContract_1, JsonProperty jsonProperty_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		Class101.smethod_0(class118_1, "reader");
		Class101.smethod_0(jsonISerializableContract_1, "contract");
		this.class118_0 = class118_1;
		this.jsonISerializableContract_0 = jsonISerializableContract_1;
		this.jsonProperty_0 = jsonProperty_1;
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00008976 File Offset: 0x00006B76
	private doVNeRdShnooWkjmvwL method_0<doVNeRdShnooWkjmvwL>(object object_0)
	{
		Class101.smethod_0(object_0, "value");
		return (doVNeRdShnooWkjmvwL)((object)System.Convert.ChangeType(((JValue)object_0).Value, typeof(doVNeRdShnooWkjmvwL), CultureInfo.InvariantCulture));
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00032C20 File Offset: 0x00030E20
	public object Convert(object value, Type type)
	{
		Class101.smethod_0(value, "value");
		JToken jtoken_;
		if ((jtoken_ = (value as JToken)) == null)
		{
			throw new ArgumentException("Value is not a JToken.", "value");
		}
		return this.class118_0.method_36(jtoken_, type, this.jsonISerializableContract_0, this.jsonProperty_0);
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00032C6C File Offset: 0x00030E6C
	public object Convert(object value, TypeCode typeCode)
	{
		Class101.smethod_0(value, "value");
		JValue jvalue;
		if ((jvalue = (value as JValue)) != null)
		{
			value = jvalue.Value;
		}
		return System.Convert.ChangeType(value, typeCode, CultureInfo.InvariantCulture);
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x000089A7 File Offset: 0x00006BA7
	public bool ToBoolean(object value)
	{
		return this.method_0<bool>(value);
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x000089B0 File Offset: 0x00006BB0
	public byte ToByte(object value)
	{
		return this.method_0<byte>(value);
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x000089B9 File Offset: 0x00006BB9
	public char ToChar(object value)
	{
		return this.method_0<char>(value);
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x000089C2 File Offset: 0x00006BC2
	public DateTime ToDateTime(object value)
	{
		return this.method_0<DateTime>(value);
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x000089CB File Offset: 0x00006BCB
	public decimal ToDecimal(object value)
	{
		return this.method_0<decimal>(value);
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x000089D4 File Offset: 0x00006BD4
	public double ToDouble(object value)
	{
		return this.method_0<double>(value);
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x000089DD File Offset: 0x00006BDD
	public short ToInt16(object value)
	{
		return this.method_0<short>(value);
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x000089E6 File Offset: 0x00006BE6
	public int ToInt32(object value)
	{
		return this.method_0<int>(value);
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x000089EF File Offset: 0x00006BEF
	public long ToInt64(object value)
	{
		return this.method_0<long>(value);
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x000089F8 File Offset: 0x00006BF8
	public sbyte ToSByte(object value)
	{
		return this.method_0<sbyte>(value);
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00008A01 File Offset: 0x00006C01
	public float ToSingle(object value)
	{
		return this.method_0<float>(value);
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00008A0A File Offset: 0x00006C0A
	public string ToString(object value)
	{
		return this.method_0<string>(value);
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x00008A13 File Offset: 0x00006C13
	public ushort ToUInt16(object value)
	{
		return this.method_0<ushort>(value);
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x00008A1C File Offset: 0x00006C1C
	public uint ToUInt32(object value)
	{
		return this.method_0<uint>(value);
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00008A25 File Offset: 0x00006C25
	public ulong ToUInt64(object value)
	{
		return this.method_0<ulong>(value);
	}

	// Token: 0x04000514 RID: 1300
	private readonly Class118 class118_0;

	// Token: 0x04000515 RID: 1301
	private readonly JsonISerializableContract jsonISerializableContract_0;

	// Token: 0x04000516 RID: 1302
	private readonly JsonProperty jsonProperty_0;
}
