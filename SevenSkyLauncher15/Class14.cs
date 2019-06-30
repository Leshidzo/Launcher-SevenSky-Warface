using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using Newtonsoft.Json;

// Token: 0x0200014B RID: 331
internal class Class14 : JsonWriter
{
	// Token: 0x06000A49 RID: 2633 RVA: 0x00038EB0 File Offset: 0x000370B0
	public Class14(JsonWriter jsonWriter_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.jsonWriter_0 = jsonWriter_1;
		this.stringWriter_0 = new StringWriter(CultureInfo.InvariantCulture);
		this.stringWriter_0.Write("Serialized JSON: " + Environment.NewLine);
		this.jsonTextWriter_0 = new JsonTextWriter(this.stringWriter_0);
		this.jsonTextWriter_0.Formatting = Formatting.Indented;
		this.jsonTextWriter_0.Culture = jsonWriter_1.Culture;
		this.jsonTextWriter_0.DateFormatHandling = jsonWriter_1.DateFormatHandling;
		this.jsonTextWriter_0.DateFormatString = jsonWriter_1.DateFormatString;
		this.jsonTextWriter_0.DateTimeZoneHandling = jsonWriter_1.DateTimeZoneHandling;
		this.jsonTextWriter_0.FloatFormatHandling = jsonWriter_1.FloatFormatHandling;
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x000098B0 File Offset: 0x00007AB0
	public string method_35()
	{
		return this.stringWriter_0.ToString();
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x000098BD File Offset: 0x00007ABD
	public override void WriteValue(decimal value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x000098DE File Offset: 0x00007ADE
	public override void WriteValue(decimal? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00009915 File Offset: 0x00007B15
	public override void WriteValue(bool value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00009936 File Offset: 0x00007B36
	public override void WriteValue(bool? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x0000996D File Offset: 0x00007B6D
	public override void WriteValue(byte value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0000998E File Offset: 0x00007B8E
	public override void WriteValue(byte? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x000099C5 File Offset: 0x00007BC5
	public override void WriteValue(char value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x000099E6 File Offset: 0x00007BE6
	public override void WriteValue(char? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x00009A1D File Offset: 0x00007C1D
	public override void WriteValue(byte[] value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value == null)
		{
			base.WriteUndefined();
			return;
		}
		base.WriteValue(value);
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x00009A48 File Offset: 0x00007C48
	public override void WriteValue(DateTime value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x00009A69 File Offset: 0x00007C69
	public override void WriteValue(DateTime? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x00009AA0 File Offset: 0x00007CA0
	public override void WriteValue(DateTimeOffset value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x00009AC1 File Offset: 0x00007CC1
	public override void WriteValue(DateTimeOffset? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x00009AF8 File Offset: 0x00007CF8
	public override void WriteValue(double value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00009B19 File Offset: 0x00007D19
	public override void WriteValue(double? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00009B50 File Offset: 0x00007D50
	public override void WriteUndefined()
	{
		this.jsonTextWriter_0.WriteUndefined();
		this.jsonWriter_0.WriteUndefined();
		base.WriteUndefined();
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00009B6E File Offset: 0x00007D6E
	public override void WriteNull()
	{
		this.jsonTextWriter_0.WriteNull();
		this.jsonWriter_0.WriteNull();
		base.WriteUndefined();
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x00009B8C File Offset: 0x00007D8C
	public override void WriteValue(float value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00009BAD File Offset: 0x00007DAD
	public override void WriteValue(float? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00009BE4 File Offset: 0x00007DE4
	public override void WriteValue(Guid value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00009C05 File Offset: 0x00007E05
	public override void WriteValue(Guid? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00009C3C File Offset: 0x00007E3C
	public override void WriteValue(int value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00009C5D File Offset: 0x00007E5D
	public override void WriteValue(int? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00009C94 File Offset: 0x00007E94
	public override void WriteValue(long value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00009CB5 File Offset: 0x00007EB5
	public override void WriteValue(long? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x00038F6C File Offset: 0x0003716C
	public override void WriteValue(object value)
	{
		if (value is BigInteger)
		{
			this.jsonTextWriter_0.WriteValue(value);
			this.jsonWriter_0.WriteValue(value);
			base.method_28(JsonToken.Integer);
			return;
		}
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value == null)
		{
			base.WriteUndefined();
			return;
		}
		base.method_28(JsonToken.String);
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00009CEC File Offset: 0x00007EEC
	public override void WriteValue(sbyte value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00009D0D File Offset: 0x00007F0D
	public override void WriteValue(sbyte? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00009D44 File Offset: 0x00007F44
	public override void WriteValue(short value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00009D65 File Offset: 0x00007F65
	public override void WriteValue(short? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00009D9C File Offset: 0x00007F9C
	public override void WriteValue(string value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00009DBD File Offset: 0x00007FBD
	public override void WriteValue(TimeSpan value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00009DDE File Offset: 0x00007FDE
	public override void WriteValue(TimeSpan? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00009E15 File Offset: 0x00008015
	public override void WriteValue(uint value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00009E36 File Offset: 0x00008036
	public override void WriteValue(uint? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x00009E6D File Offset: 0x0000806D
	public override void WriteValue(ulong value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00009E8E File Offset: 0x0000808E
	public override void WriteValue(ulong? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x00009EC5 File Offset: 0x000080C5
	public override void WriteValue(Uri value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value == null)
		{
			base.WriteUndefined();
			return;
		}
		base.WriteValue(value);
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00009EF6 File Offset: 0x000080F6
	public override void WriteValue(ushort value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		base.WriteValue(value);
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x00009F17 File Offset: 0x00008117
	public override void WriteValue(ushort? value)
	{
		this.jsonTextWriter_0.WriteValue(value);
		this.jsonWriter_0.WriteValue(value);
		if (value != null)
		{
			base.WriteValue(value.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x00009F4E File Offset: 0x0000814E
	public override void WriteWhitespace(string ws)
	{
		this.jsonTextWriter_0.WriteWhitespace(ws);
		this.jsonWriter_0.WriteWhitespace(ws);
		base.WriteWhitespace(ws);
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x00009F6F File Offset: 0x0000816F
	public override void WriteComment(string text)
	{
		this.jsonTextWriter_0.WriteComment(text);
		this.jsonWriter_0.WriteComment(text);
		base.WriteComment(text);
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x00009F90 File Offset: 0x00008190
	public override void WriteStartArray()
	{
		this.jsonTextWriter_0.WriteStartArray();
		this.jsonWriter_0.WriteStartArray();
		base.WriteStartArray();
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x00009FAE File Offset: 0x000081AE
	public override void WriteEndArray()
	{
		this.jsonTextWriter_0.WriteEndArray();
		this.jsonWriter_0.WriteEndArray();
		base.WriteEndArray();
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00009FCC File Offset: 0x000081CC
	public override void WriteStartConstructor(string name)
	{
		this.jsonTextWriter_0.WriteStartConstructor(name);
		this.jsonWriter_0.WriteStartConstructor(name);
		base.WriteStartConstructor(name);
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x00009FED File Offset: 0x000081ED
	public override void WriteEndConstructor()
	{
		this.jsonTextWriter_0.WriteEndConstructor();
		this.jsonWriter_0.WriteEndConstructor();
		base.WriteEndConstructor();
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x0000A00B File Offset: 0x0000820B
	public override void WritePropertyName(string name)
	{
		this.jsonTextWriter_0.WritePropertyName(name);
		this.jsonWriter_0.WritePropertyName(name);
		base.WritePropertyName(name);
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x0000A02C File Offset: 0x0000822C
	public override void WritePropertyName(string name, bool escape)
	{
		this.jsonTextWriter_0.WritePropertyName(name, escape);
		this.jsonWriter_0.WritePropertyName(name, escape);
		base.WritePropertyName(name);
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x0000A04F File Offset: 0x0000824F
	public override void WriteStartObject()
	{
		this.jsonTextWriter_0.WriteStartObject();
		this.jsonWriter_0.WriteStartObject();
		base.WriteStartObject();
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x0000A06D File Offset: 0x0000826D
	public override void WriteEndObject()
	{
		this.jsonTextWriter_0.WriteEndObject();
		this.jsonWriter_0.WriteEndObject();
		base.WriteEndObject();
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x0000A08B File Offset: 0x0000828B
	public override void WriteRawValue(string json)
	{
		this.jsonTextWriter_0.WriteRawValue(json);
		this.jsonWriter_0.WriteRawValue(json);
		base.method_28(JsonToken.Undefined);
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x0000A0AD File Offset: 0x000082AD
	public override void WriteRaw(string json)
	{
		this.jsonTextWriter_0.WriteRaw(json);
		this.jsonWriter_0.WriteRaw(json);
		base.WriteRaw(json);
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x0000A0CE File Offset: 0x000082CE
	public override void Close()
	{
		this.jsonTextWriter_0.Close();
		this.jsonWriter_0.Close();
		base.Close();
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x0000A0EC File Offset: 0x000082EC
	public override void Flush()
	{
		this.jsonTextWriter_0.Flush();
		this.jsonWriter_0.Flush();
	}

	// Token: 0x04000577 RID: 1399
	private readonly JsonWriter jsonWriter_0;

	// Token: 0x04000578 RID: 1400
	private readonly JsonTextWriter jsonTextWriter_0;

	// Token: 0x04000579 RID: 1401
	private readonly StringWriter stringWriter_0;
}
