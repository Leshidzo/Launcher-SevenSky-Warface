using System;
using System.Globalization;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

// Token: 0x020000AE RID: 174
internal static class Class25
{
	// Token: 0x060005CE RID: 1486 RVA: 0x00028CB0 File Offset: 0x00026EB0
	static Class25()
	{
		Class202.ofdixO4zTbIfy();
		Class25.long_0 = 621355968000000000L;
		Class25.int_0 = new int[]
		{
			0,
			31,
			59,
			90,
			120,
			151,
			181,
			212,
			243,
			273,
			304,
			334,
			365
		};
		Class25.int_1 = new int[]
		{
			0,
			31,
			60,
			91,
			121,
			152,
			182,
			213,
			244,
			274,
			305,
			335,
			366
		};
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00006AA6 File Offset: 0x00004CA6
	public static TimeSpan smethod_0(this DateTime dateTime_0)
	{
		return TimeZoneInfo.Local.GetUtcOffset(dateTime_0);
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00006AB3 File Offset: 0x00004CB3
	public static XmlDateTimeSerializationMode smethod_1(DateTimeKind dateTimeKind_0)
	{
		switch (dateTimeKind_0)
		{
		case DateTimeKind.Unspecified:
			return XmlDateTimeSerializationMode.Unspecified;
		case DateTimeKind.Utc:
			return XmlDateTimeSerializationMode.Utc;
		case DateTimeKind.Local:
			return XmlDateTimeSerializationMode.Local;
		default:
			throw Class80.smethod_1("kind", dateTimeKind_0, "Unexpected DateTimeKind value.");
		}
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x00028D00 File Offset: 0x00026F00
	internal static DateTime smethod_2(DateTime dateTime_0, DateTimeZoneHandling dateTimeZoneHandling_0)
	{
		switch (dateTimeZoneHandling_0)
		{
		case DateTimeZoneHandling.Local:
			dateTime_0 = Class25.smethod_3(dateTime_0);
			break;
		case DateTimeZoneHandling.Utc:
			dateTime_0 = Class25.smethod_4(dateTime_0);
			break;
		case DateTimeZoneHandling.Unspecified:
			dateTime_0 = new DateTime(dateTime_0.Ticks, DateTimeKind.Unspecified);
			break;
		case DateTimeZoneHandling.RoundtripKind:
			break;
		default:
			throw new ArgumentException("Invalid date time handling value.");
		}
		return dateTime_0;
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00028D54 File Offset: 0x00026F54
	private static DateTime smethod_3(DateTime dateTime_0)
	{
		switch (dateTime_0.Kind)
		{
		case DateTimeKind.Unspecified:
			return new DateTime(dateTime_0.Ticks, DateTimeKind.Local);
		case DateTimeKind.Utc:
			return dateTime_0.ToLocalTime();
		case DateTimeKind.Local:
			return dateTime_0;
		default:
			return dateTime_0;
		}
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00028D94 File Offset: 0x00026F94
	private static DateTime smethod_4(DateTime dateTime_0)
	{
		switch (dateTime_0.Kind)
		{
		case DateTimeKind.Unspecified:
			return new DateTime(dateTime_0.Ticks, DateTimeKind.Utc);
		case DateTimeKind.Utc:
			return dateTime_0;
		case DateTimeKind.Local:
			return dateTime_0.ToUniversalTime();
		default:
			return dateTime_0;
		}
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00006AE2 File Offset: 0x00004CE2
	private static long smethod_5(DateTime dateTime_0)
	{
		if (dateTime_0.Kind == DateTimeKind.Utc)
		{
			return dateTime_0.Ticks;
		}
		return Class25.smethod_6(dateTime_0, dateTime_0.smethod_0());
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x00028DD4 File Offset: 0x00026FD4
	private static long smethod_6(DateTime dateTime_0, TimeSpan timeSpan_0)
	{
		if (dateTime_0.Kind == DateTimeKind.Utc || dateTime_0 == DateTime.MaxValue || dateTime_0 == DateTime.MinValue)
		{
			return dateTime_0.Ticks;
		}
		long num = dateTime_0.Ticks - timeSpan_0.Ticks;
		if (num > 3155378975999999999L)
		{
			return 3155378975999999999L;
		}
		if (num < 0L)
		{
			return 0L;
		}
		return num;
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00006B02 File Offset: 0x00004D02
	internal static long smethod_7(DateTime dateTime_0, TimeSpan timeSpan_0)
	{
		return Class25.smethod_10(Class25.smethod_6(dateTime_0, timeSpan_0));
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00006B10 File Offset: 0x00004D10
	internal static long smethod_8(DateTime dateTime_0)
	{
		return Class25.smethod_9(dateTime_0, true);
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00006B19 File Offset: 0x00004D19
	internal static long smethod_9(DateTime dateTime_0, bool bool_0)
	{
		return Class25.smethod_10(bool_0 ? Class25.smethod_5(dateTime_0) : dateTime_0.Ticks);
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00006B32 File Offset: 0x00004D32
	private static long smethod_10(long long_1)
	{
		return (long_1 - Class25.long_0) / 10000L;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00006B45 File Offset: 0x00004D45
	internal static DateTime smethod_11(long long_1)
	{
		return new DateTime(long_1 * 10000L + Class25.long_0, DateTimeKind.Utc);
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00028E4C File Offset: 0x0002704C
	internal static bool smethod_12(Struct8 struct8_0, DateTimeZoneHandling dateTimeZoneHandling_0, out DateTime dateTime_0)
	{
		Struct5 @struct = default(Struct5);
		if (!@struct.method_0(struct8_0.method_0(), struct8_0.method_1(), struct8_0.method_2()))
		{
			dateTime_0 = default(DateTime);
			return false;
		}
		DateTime dateTime_ = Class25.smethod_14(@struct);
		switch (@struct.enum6_0)
		{
		case (Enum6)1:
			dateTime_ = new DateTime(dateTime_.Ticks, DateTimeKind.Utc);
			break;
		case (Enum6)2:
		{
			TimeSpan timeSpan = new TimeSpan(@struct.int_7, @struct.int_8, 0);
			long num = dateTime_.Ticks + timeSpan.Ticks;
			if (num <= DateTime.MaxValue.Ticks)
			{
				dateTime_ = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
			}
			else
			{
				num += dateTime_.smethod_0().Ticks;
				if (num > DateTime.MaxValue.Ticks)
				{
					num = DateTime.MaxValue.Ticks;
				}
				dateTime_ = new DateTime(num, DateTimeKind.Local);
			}
			break;
		}
		case (Enum6)3:
		{
			TimeSpan timeSpan2 = new TimeSpan(@struct.int_7, @struct.int_8, 0);
			long num = dateTime_.Ticks - timeSpan2.Ticks;
			if (num >= DateTime.MinValue.Ticks)
			{
				dateTime_ = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
			}
			else
			{
				num += dateTime_.smethod_0().Ticks;
				if (num < DateTime.MinValue.Ticks)
				{
					num = DateTime.MinValue.Ticks;
				}
				dateTime_ = new DateTime(num, DateTimeKind.Local);
			}
			break;
		}
		}
		dateTime_0 = Class25.smethod_2(dateTime_, dateTimeZoneHandling_0);
		return true;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00028FE0 File Offset: 0x000271E0
	internal static bool smethod_13(Struct8 struct8_0, out DateTimeOffset dateTimeOffset_0)
	{
		Struct5 @struct = default(Struct5);
		if (!@struct.method_0(struct8_0.method_0(), struct8_0.method_1(), struct8_0.method_2()))
		{
			dateTimeOffset_0 = default(DateTimeOffset);
			return false;
		}
		DateTime dateTime = Class25.smethod_14(@struct);
		TimeSpan utcOffset;
		switch (@struct.enum6_0)
		{
		case (Enum6)1:
			utcOffset = new TimeSpan(0L);
			break;
		case (Enum6)2:
			utcOffset = new TimeSpan(-@struct.int_7, -@struct.int_8, 0);
			break;
		case (Enum6)3:
			utcOffset = new TimeSpan(@struct.int_7, @struct.int_8, 0);
			break;
		default:
			utcOffset = TimeZoneInfo.Local.GetUtcOffset(dateTime);
			break;
		}
		long num = dateTime.Ticks - utcOffset.Ticks;
		if (num >= 0L && num <= 3155378975999999999L)
		{
			dateTimeOffset_0 = new DateTimeOffset(dateTime, utcOffset);
			return true;
		}
		dateTimeOffset_0 = default(DateTimeOffset);
		return false;
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x000290CC File Offset: 0x000272CC
	private static DateTime smethod_14(Struct5 struct5_0)
	{
		bool flag;
		if (struct5_0.int_3 == 24)
		{
			flag = true;
			struct5_0.int_3 = 0;
		}
		else
		{
			flag = false;
		}
		DateTime result = new DateTime(struct5_0.int_0, struct5_0.int_1, struct5_0.int_2, struct5_0.int_3, struct5_0.int_4, struct5_0.int_5);
		result = result.AddTicks((long)struct5_0.int_6);
		if (flag)
		{
			result = result.AddDays(1.0);
		}
		return result;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00029140 File Offset: 0x00027340
	internal static bool smethod_15(Struct8 struct8_0, DateTimeZoneHandling dateTimeZoneHandling_0, string string_0, IFormatProvider iformatProvider_0, out DateTime dateTime_0)
	{
		if (struct8_0.method_2() > 0)
		{
			int num = struct8_0.method_1();
			if (struct8_0[num] == '/')
			{
				if (struct8_0.method_2() >= 9 && struct8_0.smethod_1("/Date(") && struct8_0.smethod_2(")/") && Class25.xkTsxUkKek(struct8_0, dateTimeZoneHandling_0, out dateTime_0))
				{
					return true;
				}
			}
			else if (struct8_0.method_2() >= 19 && struct8_0.method_2() <= 40 && char.IsDigit(struct8_0[num]) && struct8_0[num + 10] == 'T' && Class25.smethod_12(struct8_0, dateTimeZoneHandling_0, out dateTime_0))
			{
				return true;
			}
			if (!string.IsNullOrEmpty(string_0) && Class25.smethod_20(struct8_0.ToString(), dateTimeZoneHandling_0, string_0, iformatProvider_0, out dateTime_0))
			{
				return true;
			}
		}
		dateTime_0 = default(DateTime);
		return false;
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00029210 File Offset: 0x00027410
	internal static bool smethod_16(string string_0, DateTimeZoneHandling dateTimeZoneHandling_0, string string_1, IFormatProvider iformatProvider_0, out DateTime dateTime_0)
	{
		if (string_0.Length > 0)
		{
			if (string_0[0] == '/')
			{
				if (string_0.Length >= 9 && string_0.StartsWith("/Date(", StringComparison.Ordinal) && string_0.EndsWith(")/", StringComparison.Ordinal) && Class25.xkTsxUkKek(new Struct8(string_0.ToCharArray(), 0, string_0.Length), dateTimeZoneHandling_0, out dateTime_0))
				{
					return true;
				}
			}
			else if (string_0.Length >= 19 && string_0.Length <= 40 && char.IsDigit(string_0[0]) && string_0[10] == 'T' && DateTime.TryParseExact(string_0, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out dateTime_0))
			{
				dateTime_0 = Class25.smethod_2(dateTime_0, dateTimeZoneHandling_0);
				return true;
			}
			if (!string.IsNullOrEmpty(string_1) && Class25.smethod_20(string_0, dateTimeZoneHandling_0, string_1, iformatProvider_0, out dateTime_0))
			{
				return true;
			}
		}
		dateTime_0 = default(DateTime);
		return false;
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x000292FC File Offset: 0x000274FC
	internal static bool smethod_17(Struct8 struct8_0, string string_0, IFormatProvider iformatProvider_0, out DateTimeOffset dateTimeOffset_0)
	{
		if (struct8_0.method_2() > 0)
		{
			int num = struct8_0.method_1();
			if (struct8_0[num] == '/')
			{
				if (struct8_0.method_2() >= 9 && struct8_0.smethod_1("/Date(") && struct8_0.smethod_2(")/") && Class25.smethod_21(struct8_0, out dateTimeOffset_0))
				{
					return true;
				}
			}
			else if (struct8_0.method_2() >= 19 && struct8_0.method_2() <= 40 && char.IsDigit(struct8_0[num]) && struct8_0[num + 10] == 'T' && Class25.smethod_13(struct8_0, out dateTimeOffset_0))
			{
				return true;
			}
			if (!string.IsNullOrEmpty(string_0) && Class25.smethod_22(struct8_0.ToString(), string_0, iformatProvider_0, out dateTimeOffset_0))
			{
				return true;
			}
		}
		dateTimeOffset_0 = default(DateTimeOffset);
		return false;
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x000293C4 File Offset: 0x000275C4
	internal static bool smethod_18(string string_0, string string_1, IFormatProvider iformatProvider_0, out DateTimeOffset dateTimeOffset_0)
	{
		if (string_0.Length > 0)
		{
			if (string_0[0] == '/')
			{
				if (string_0.Length >= 9 && string_0.StartsWith("/Date(", StringComparison.Ordinal) && string_0.EndsWith(")/", StringComparison.Ordinal) && Class25.smethod_21(new Struct8(string_0.ToCharArray(), 0, string_0.Length), out dateTimeOffset_0))
				{
					return true;
				}
			}
			else if (string_0.Length >= 19 && string_0.Length <= 40 && char.IsDigit(string_0[0]) && string_0[10] == 'T' && DateTimeOffset.TryParseExact(string_0, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out dateTimeOffset_0) && Class25.smethod_13(new Struct8(string_0.ToCharArray(), 0, string_0.Length), out dateTimeOffset_0))
			{
				return true;
			}
			if (!string.IsNullOrEmpty(string_1) && Class25.smethod_22(string_0, string_1, iformatProvider_0, out dateTimeOffset_0))
			{
				return true;
			}
		}
		dateTimeOffset_0 = default(DateTimeOffset);
		return false;
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x000294B0 File Offset: 0x000276B0
	private static bool smethod_19(Struct8 struct8_0, out long long_1, out TimeSpan timeSpan_0, out DateTimeKind dateTimeKind_0)
	{
		dateTimeKind_0 = DateTimeKind.Utc;
		int num = struct8_0.smethod_0('+', 7, struct8_0.method_2() - 8);
		if (num == -1)
		{
			num = struct8_0.smethod_0('-', 7, struct8_0.method_2() - 8);
		}
		if (num != -1)
		{
			dateTimeKind_0 = DateTimeKind.Local;
			if (!Class25.smethod_23(struct8_0, num + struct8_0.method_1(), out timeSpan_0))
			{
				long_1 = 0L;
				return false;
			}
		}
		else
		{
			timeSpan_0 = TimeSpan.Zero;
			num = struct8_0.method_2() - 2;
		}
		return Class23.smethod_15(struct8_0.method_0(), 6 + struct8_0.method_1(), num - 6, out long_1) == (Enum4)1;
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00029544 File Offset: 0x00027744
	private static bool xkTsxUkKek(Struct8 struct8_0, DateTimeZoneHandling dateTimeZoneHandling_0, out DateTime dateTime_0)
	{
		long long_;
		TimeSpan timeSpan;
		DateTimeKind dateTimeKind;
		if (!Class25.smethod_19(struct8_0, out long_, out timeSpan, out dateTimeKind))
		{
			dateTime_0 = default(DateTime);
			return false;
		}
		DateTime dateTime = Class25.smethod_11(long_);
		if (dateTimeKind != DateTimeKind.Unspecified)
		{
			if (dateTimeKind != DateTimeKind.Local)
			{
				dateTime_0 = dateTime;
			}
			else
			{
				dateTime_0 = dateTime.ToLocalTime();
			}
		}
		else
		{
			dateTime_0 = DateTime.SpecifyKind(dateTime.ToLocalTime(), DateTimeKind.Unspecified);
		}
		dateTime_0 = Class25.smethod_2(dateTime_0, dateTimeZoneHandling_0);
		return true;
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x000295B4 File Offset: 0x000277B4
	private static bool smethod_20(string string_0, DateTimeZoneHandling dateTimeZoneHandling_0, string string_1, IFormatProvider iformatProvider_0, out DateTime dateTime_0)
	{
		DateTime dateTime;
		if (DateTime.TryParseExact(string_0, string_1, iformatProvider_0, DateTimeStyles.RoundtripKind, out dateTime))
		{
			dateTime = Class25.smethod_2(dateTime, dateTimeZoneHandling_0);
			dateTime_0 = dateTime;
			return true;
		}
		dateTime_0 = default(DateTime);
		return false;
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x000295F0 File Offset: 0x000277F0
	private static bool smethod_21(Struct8 struct8_0, out DateTimeOffset dateTimeOffset_0)
	{
		long long_;
		TimeSpan timeSpan;
		DateTimeKind dateTimeKind;
		if (!Class25.smethod_19(struct8_0, out long_, out timeSpan, out dateTimeKind))
		{
			dateTimeOffset_0 = default(DateTime);
			return false;
		}
		dateTimeOffset_0 = new DateTimeOffset(Class25.smethod_11(long_).Add(timeSpan).Ticks, timeSpan);
		return true;
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00029648 File Offset: 0x00027848
	private static bool smethod_22(string string_0, string string_1, IFormatProvider iformatProvider_0, out DateTimeOffset dateTimeOffset_0)
	{
		DateTimeOffset dateTimeOffset;
		if (DateTimeOffset.TryParseExact(string_0, string_1, iformatProvider_0, DateTimeStyles.RoundtripKind, out dateTimeOffset))
		{
			dateTimeOffset_0 = dateTimeOffset;
			return true;
		}
		dateTimeOffset_0 = default(DateTimeOffset);
		return false;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00029678 File Offset: 0x00027878
	private static bool smethod_23(Struct8 struct8_0, int int_2, out TimeSpan timeSpan_0)
	{
		bool flag = struct8_0[int_2] == '-';
		int num;
		if (Class23.smethod_14(struct8_0.method_0(), int_2 + 1, 2, out num) != (Enum4)1)
		{
			timeSpan_0 = default(TimeSpan);
			return false;
		}
		int num2 = 0;
		if (struct8_0.method_2() - int_2 > 5 && Class23.smethod_14(struct8_0.method_0(), int_2 + 3, 2, out num2) != (Enum4)1)
		{
			timeSpan_0 = default(TimeSpan);
			return false;
		}
		timeSpan_0 = TimeSpan.FromHours((double)num) + TimeSpan.FromMinutes((double)num2);
		if (flag)
		{
			timeSpan_0 = timeSpan_0.Negate();
		}
		return true;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00029708 File Offset: 0x00027908
	internal static void smethod_24(TextWriter textWriter_0, DateTime dateTime_0, DateFormatHandling dateFormatHandling_0, string string_0, IFormatProvider iformatProvider_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			char[] array = new char[64];
			int count = Class25.smethod_25(array, 0, dateTime_0, null, dateTime_0.Kind, dateFormatHandling_0);
			textWriter_0.Write(array, 0, count);
			return;
		}
		textWriter_0.Write(dateTime_0.ToString(string_0, iformatProvider_0));
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0002975C File Offset: 0x0002795C
	internal static int smethod_25(char[] char_0, int int_2, DateTime dateTime_0, TimeSpan? nullable_0, DateTimeKind dateTimeKind_0, DateFormatHandling dateFormatHandling_0)
	{
		int num2;
		if (dateFormatHandling_0 == DateFormatHandling.MicrosoftDateFormat)
		{
			TimeSpan timeSpan_ = nullable_0 ?? dateTime_0.smethod_0();
			long num = Class25.smethod_7(dateTime_0, timeSpan_);
			"\\/Date(".CopyTo(0, char_0, int_2, 7);
			num2 = int_2 + 7;
			string text = num.ToString(CultureInfo.InvariantCulture);
			text.CopyTo(0, char_0, num2, text.Length);
			num2 += text.Length;
			if (dateTimeKind_0 != DateTimeKind.Unspecified)
			{
				if (dateTimeKind_0 == DateTimeKind.Local)
				{
					num2 = Class25.smethod_28(char_0, num2, timeSpan_, dateFormatHandling_0);
				}
			}
			else if (dateTime_0 != DateTime.MaxValue && dateTime_0 != DateTime.MinValue)
			{
				num2 = Class25.smethod_28(char_0, num2, timeSpan_, dateFormatHandling_0);
			}
			")\\/".CopyTo(0, char_0, num2, 3);
			num2 += 3;
		}
		else
		{
			num2 = Class25.smethod_26(char_0, int_2, dateTime_0);
			if (dateTimeKind_0 != DateTimeKind.Utc)
			{
				if (dateTimeKind_0 == DateTimeKind.Local)
				{
					num2 = Class25.smethod_28(char_0, num2, nullable_0 ?? dateTime_0.smethod_0(), dateFormatHandling_0);
				}
			}
			else
			{
				char_0[num2++] = 'Z';
			}
		}
		return num2;
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00029868 File Offset: 0x00027A68
	internal static int smethod_26(object object_0, int int_2, DateTime dateTime_0)
	{
		int num = 19;
		int int_3;
		int int_4;
		int int_5;
		Class25.smethod_29(dateTime_0, out int_3, out int_4, out int_5);
		Class25.smethod_27(object_0, int_2, int_3, 4);
		object_0[int_2 + 4] = 45;
		Class25.smethod_27(object_0, int_2 + 5, int_4, 2);
		object_0[int_2 + 7] = 45;
		Class25.smethod_27(object_0, int_2 + 8, int_5, 2);
		object_0[int_2 + 10] = 84;
		Class25.smethod_27(object_0, int_2 + 11, dateTime_0.Hour, 2);
		object_0[int_2 + 13] = 58;
		Class25.smethod_27(object_0, int_2 + 14, dateTime_0.Minute, 2);
		object_0[int_2 + 16] = 58;
		Class25.smethod_27(object_0, int_2 + 17, dateTime_0.Second, 2);
		int num2 = (int)(dateTime_0.Ticks % 10000000L);
		if (num2 != 0)
		{
			int num3 = 7;
			while (num2 % 10 == 0)
			{
				num3--;
				num2 /= 10;
			}
			object_0[int_2 + 19] = 46;
			Class25.smethod_27(object_0, int_2 + 20, num2, num3);
			num += num3 + 1;
		}
		return int_2 + num;
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00006B5E File Offset: 0x00004D5E
	private static void smethod_27(object object_0, int int_2, int int_3, int int_4)
	{
		while (int_4-- != 0)
		{
			object_0[int_2 + int_4] = (ushort)(int_3 % 10 + 48);
			int_3 /= 10;
		}
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00029950 File Offset: 0x00027B50
	internal static int smethod_28(object object_0, int int_2, TimeSpan timeSpan_0, DateFormatHandling dateFormatHandling_0)
	{
		object_0[int_2++] = ((timeSpan_0.Ticks >= 0L) ? 43 : 45);
		int int_3 = Math.Abs(timeSpan_0.Hours);
		Class25.smethod_27(object_0, int_2, int_3, 2);
		int_2 += 2;
		if (dateFormatHandling_0 == DateFormatHandling.IsoDateFormat)
		{
			object_0[int_2++] = 58;
		}
		int int_4 = Math.Abs(timeSpan_0.Minutes);
		Class25.smethod_27(object_0, int_2, int_4, 2);
		int_2 += 2;
		return int_2;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x000299C4 File Offset: 0x00027BC4
	internal static void IxisRjgvuh(TextWriter textWriter_0, DateTimeOffset dateTimeOffset_0, DateFormatHandling dateFormatHandling_0, string string_0, IFormatProvider iformatProvider_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			char[] array = new char[64];
			int count = Class25.smethod_25(array, 0, (dateFormatHandling_0 == DateFormatHandling.IsoDateFormat) ? dateTimeOffset_0.DateTime : dateTimeOffset_0.UtcDateTime, new TimeSpan?(dateTimeOffset_0.Offset), DateTimeKind.Local, dateFormatHandling_0);
			textWriter_0.Write(array, 0, count);
			return;
		}
		textWriter_0.Write(dateTimeOffset_0.ToString(string_0, iformatProvider_0));
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00029A24 File Offset: 0x00027C24
	private static void smethod_29(DateTime dateTime_0, out int int_2, out int int_3, out int int_4)
	{
		int i = (int)(dateTime_0.Ticks / 864000000000L);
		int num = i / 146097;
		i -= num * 146097;
		int num2 = i / 36524;
		if (num2 == 4)
		{
			num2 = 3;
		}
		i -= num2 * 36524;
		int num3 = i / 1461;
		i -= num3 * 1461;
		int num4 = i / 365;
		if (num4 == 4)
		{
			num4 = 3;
		}
		int_2 = num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
		i -= num4 * 365;
		int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? Class25.int_1 : Class25.int_0;
		int num5 = i >> 6;
		while (i >= array[num5])
		{
			num5++;
		}
		int_3 = num5;
		int_4 = i - array[num5 - 1] + 1;
	}

	// Token: 0x040003E9 RID: 1001
	internal static readonly long long_0;

	// Token: 0x040003EA RID: 1002
	private static readonly int[] int_0;

	// Token: 0x040003EB RID: 1003
	private static readonly int[] int_1;
}
