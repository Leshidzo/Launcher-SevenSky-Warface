using System;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;

// Token: 0x0200014A RID: 330
internal class Class8 : JsonReader, IJsonLineInfo
{
	// Token: 0x06000A32 RID: 2610 RVA: 0x00038DDC File Offset: 0x00036FDC
	public Class8(JsonReader jsonReader_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.jsonReader_0 = jsonReader_1;
		this.stringWriter_0 = new StringWriter(CultureInfo.InvariantCulture);
		this.stringWriter_0.Write("Deserialized JSON: " + Environment.NewLine);
		this.jsonTextWriter_0 = new JsonTextWriter(this.stringWriter_0);
		this.jsonTextWriter_0.Formatting = Formatting.Indented;
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00009779 File Offset: 0x00007979
	public string method_31()
	{
		return this.stringWriter_0.ToString();
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00009786 File Offset: 0x00007986
	public override bool Read()
	{
		bool result = this.jsonReader_0.Read();
		this.method_32();
		return result;
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00009799 File Offset: 0x00007999
	public override int? vmethod_0()
	{
		int? result = this.jsonReader_0.vmethod_0();
		this.method_32();
		return result;
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x000097AC File Offset: 0x000079AC
	public override string ReadAsString()
	{
		string result = this.jsonReader_0.ReadAsString();
		this.method_32();
		return result;
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x000097BF File Offset: 0x000079BF
	public override byte[] ReadAsBytes()
	{
		byte[] result = this.jsonReader_0.ReadAsBytes();
		this.method_32();
		return result;
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x000097D2 File Offset: 0x000079D2
	public override decimal? ReadAsDecimal()
	{
		decimal? result = this.jsonReader_0.ReadAsDecimal();
		this.method_32();
		return result;
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x000097E5 File Offset: 0x000079E5
	public override double? ReadAsDouble()
	{
		double? result = this.jsonReader_0.ReadAsDouble();
		this.method_32();
		return result;
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x000097F8 File Offset: 0x000079F8
	public override bool? ReadAsBoolean()
	{
		bool? result = this.jsonReader_0.ReadAsBoolean();
		this.method_32();
		return result;
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x0000980B File Offset: 0x00007A0B
	public override DateTime? ReadAsDateTime()
	{
		DateTime? result = this.jsonReader_0.ReadAsDateTime();
		this.method_32();
		return result;
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x0000981E File Offset: 0x00007A1E
	public override DateTimeOffset? ReadAsDateTimeOffset()
	{
		DateTimeOffset? result = this.jsonReader_0.ReadAsDateTimeOffset();
		this.method_32();
		return result;
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00009831 File Offset: 0x00007A31
	public void method_32()
	{
		this.jsonTextWriter_0.vmethod_2(this.jsonReader_0, false, false, true);
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00009847 File Offset: 0x00007A47
	public override int Depth
	{
		get
		{
			return this.jsonReader_0.Depth;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00009854 File Offset: 0x00007A54
	public override string Path
	{
		get
		{
			return this.jsonReader_0.Path;
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00009861 File Offset: 0x00007A61
	// (set) Token: 0x06000A41 RID: 2625 RVA: 0x0000986E File Offset: 0x00007A6E
	public override char QuoteChar
	{
		get
		{
			return this.jsonReader_0.QuoteChar;
		}
		protected internal set
		{
			this.jsonReader_0.QuoteChar = value;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0000987C File Offset: 0x00007A7C
	public override JsonToken TokenType
	{
		get
		{
			return this.jsonReader_0.TokenType;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00009889 File Offset: 0x00007A89
	public override object Value
	{
		get
		{
			return this.jsonReader_0.Value;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00009896 File Offset: 0x00007A96
	public override Type ValueType
	{
		get
		{
			return this.jsonReader_0.ValueType;
		}
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x000098A3 File Offset: 0x00007AA3
	public override void Close()
	{
		this.jsonReader_0.Close();
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00038E44 File Offset: 0x00037044
	bool IJsonLineInfo.HasLineInfo()
	{
		IJsonLineInfo jsonLineInfo;
		return (jsonLineInfo = (this.jsonReader_0 as IJsonLineInfo)) != null && jsonLineInfo.HasLineInfo();
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00038E68 File Offset: 0x00037068
	int IJsonLineInfo.LineNumber
	{
		get
		{
			IJsonLineInfo jsonLineInfo;
			if ((jsonLineInfo = (this.jsonReader_0 as IJsonLineInfo)) == null)
			{
				return 0;
			}
			return jsonLineInfo.LineNumber;
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00038E8C File Offset: 0x0003708C
	int IJsonLineInfo.LinePosition
	{
		get
		{
			IJsonLineInfo jsonLineInfo;
			if ((jsonLineInfo = (this.jsonReader_0 as IJsonLineInfo)) == null)
			{
				return 0;
			}
			return jsonLineInfo.LinePosition;
		}
	}

	// Token: 0x04000574 RID: 1396
	private readonly JsonReader jsonReader_0;

	// Token: 0x04000575 RID: 1397
	private readonly JsonTextWriter jsonTextWriter_0;

	// Token: 0x04000576 RID: 1398
	private readonly StringWriter stringWriter_0;
}
