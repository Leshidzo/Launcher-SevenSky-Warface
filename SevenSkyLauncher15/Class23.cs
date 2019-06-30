using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x020000A9 RID: 169
internal static class Class23
{
	// Token: 0x060005AE RID: 1454 RVA: 0x00027368 File Offset: 0x00025568
	public static Enum3 smethod_0(Type type_0)
	{
		bool flag;
		return Class23.smethod_1(type_0, out flag);
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00027380 File Offset: 0x00025580
	public static Enum3 smethod_1(Type type_0, out bool bool_0)
	{
		Enum3 result;
		if (Class23.dictionary_0.TryGetValue(type_0, out result))
		{
			bool_0 = false;
			return result;
		}
		if (type_0.smethod_8())
		{
			bool_0 = true;
			return Class23.smethod_0(Enum.GetUnderlyingType(type_0));
		}
		if (Class90.smethod_11(type_0))
		{
			Type underlyingType = Nullable.GetUnderlyingType(type_0);
			if (underlyingType.smethod_8())
			{
				Type type_ = typeof(Nullable<>).MakeGenericType(new Type[]
				{
					Enum.GetUnderlyingType(underlyingType)
				});
				bool_0 = true;
				return Class23.smethod_0(type_);
			}
		}
		bool_0 = false;
		return (Enum3)1;
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x000069DA File Offset: 0x00004BDA
	public static Class22 smethod_2(IConvertible iconvertible_0)
	{
		return Class23.class22_0[(int)iconvertible_0.GetTypeCode()];
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x000069EC File Offset: 0x00004BEC
	public static bool smethod_3(Type type_0)
	{
		return typeof(IConvertible).IsAssignableFrom(type_0);
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x000069FF File Offset: 0x00004BFF
	public static TimeSpan smethod_4(string string_0)
	{
		return TimeSpan.Parse(string_0, CultureInfo.InvariantCulture);
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x000273FC File Offset: 0x000255FC
	private static Func<object, object> smethod_5(Struct9<Type, Type> struct9_0)
	{
		Class23.Class24 @class = new Class23.Class24();
		Type gparam_ = struct9_0.gparam_0;
		Type gparam_2 = struct9_0.gparam_1;
		MethodInfo method;
		if ((method = gparam_2.GetMethod("op_Implicit", new Type[]
		{
			gparam_
		})) == null)
		{
			method = gparam_2.GetMethod("op_Explicit", new Type[]
			{
				gparam_
			});
		}
		MethodInfo methodInfo = method;
		if (methodInfo == null)
		{
			return null;
		}
		@class.delegate1_0 = Class124.smethod_19().vmethod_0<object>(methodInfo);
		return new Func<object, object>(@class.method_0);
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x00027474 File Offset: 0x00025674
	internal static BigInteger smethod_6(object object_0)
	{
		if (object_0 is BigInteger)
		{
			return (BigInteger)object_0;
		}
		string value;
		if ((value = (object_0 as string)) != null)
		{
			return BigInteger.Parse(value, CultureInfo.InvariantCulture);
		}
		if (object_0 is float)
		{
			float value2 = (float)object_0;
			return new BigInteger(value2);
		}
		if (object_0 is double)
		{
			double value3 = (double)object_0;
			return new BigInteger(value3);
		}
		if (object_0 is decimal)
		{
			decimal value4 = (decimal)object_0;
			return new BigInteger(value4);
		}
		if (object_0 is int)
		{
			int value5 = (int)object_0;
			return new BigInteger(value5);
		}
		if (object_0 is long)
		{
			long value6 = (long)object_0;
			return new BigInteger(value6);
		}
		if (object_0 is uint)
		{
			uint value7 = (uint)object_0;
			return new BigInteger(value7);
		}
		if (object_0 is ulong)
		{
			ulong value8 = (ulong)object_0;
			return new BigInteger(value8);
		}
		byte[] value9;
		if ((value9 = (object_0 as byte[])) == null)
		{
			throw new InvalidCastException("Cannot convert {0} to BigInteger.".smethod_0(CultureInfo.InvariantCulture, object_0.GetType()));
		}
		return new BigInteger(value9);
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0002758C File Offset: 0x0002578C
	public static object smethod_7(BigInteger bigInteger_0, Type type_0)
	{
		if (type_0 == typeof(decimal))
		{
			return (decimal)bigInteger_0;
		}
		if (type_0 == typeof(double))
		{
			return (double)bigInteger_0;
		}
		if (type_0 == typeof(float))
		{
			return (float)bigInteger_0;
		}
		if (type_0 == typeof(ulong))
		{
			return (ulong)bigInteger_0;
		}
		if (type_0 == typeof(bool))
		{
			return bigInteger_0 != 0L;
		}
		object result;
		try
		{
			result = Convert.ChangeType((long)bigInteger_0, type_0, CultureInfo.InvariantCulture);
		}
		catch (Exception innerException)
		{
			throw new InvalidOperationException("Can not convert from BigInteger to {0}.".smethod_0(CultureInfo.InvariantCulture, type_0), innerException);
		}
		return result;
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x00027684 File Offset: 0x00025884
	public static object smethod_8(object object_0, object object_1, Type type_0)
	{
		object result;
		switch (Class23.smethod_9(object_0, object_1, type_0, out result))
		{
		case (Class23.Enum5)0:
			return result;
		case (Class23.Enum5)1:
			throw new Exception("Can not convert null {0} into non-nullable {1}.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType(), type_0));
		case (Class23.Enum5)2:
			throw new ArgumentException("Target type {0} is not a value type or a non-abstract class.".smethod_0(CultureInfo.InvariantCulture, type_0), "targetType");
		case (Class23.Enum5)3:
			throw new InvalidOperationException("Can not convert from {0} to {1}.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType(), type_0));
		default:
			throw new InvalidOperationException("Unexpected conversion result.");
		}
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x00027714 File Offset: 0x00025914
	private static bool TryConvert(object initialValue, object culture, Type targetType, out object value)
	{
		bool result;
		try
		{
			if (Class23.smethod_9(initialValue, culture, targetType, out value) == (Class23.Enum5)0)
			{
				result = true;
			}
			else
			{
				value = null;
				result = false;
			}
		}
		catch
		{
			value = null;
			result = false;
		}
		return result;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00027754 File Offset: 0x00025954
	private static Class23.Enum5 smethod_9(object object_0, object object_1, Type type_0, out object object_2)
	{
		if (object_0 == null)
		{
			throw new ArgumentNullException("initialValue");
		}
		if (Class90.smethod_11(type_0))
		{
			type_0 = Nullable.GetUnderlyingType(type_0);
		}
		Type type = object_0.GetType();
		if (type_0 == type)
		{
			object_2 = object_0;
			return (Class23.Enum5)0;
		}
		if (Class23.smethod_3(object_0.GetType()) && Class23.smethod_3(type_0))
		{
			if (type_0.smethod_8())
			{
				if (object_0 is string)
				{
					object_2 = Enum.Parse(type_0, object_0.ToString(), true);
					return (Class23.Enum5)0;
				}
				if (Class23.smethod_13(object_0))
				{
					object_2 = Enum.ToObject(type_0, object_0);
					return (Class23.Enum5)0;
				}
			}
			object_2 = Convert.ChangeType(object_0, type_0, object_1);
			return (Class23.Enum5)0;
		}
		if (object_0 is DateTime)
		{
			DateTime dateTime = (DateTime)object_0;
			if (type_0 == typeof(DateTimeOffset))
			{
				object_2 = new DateTimeOffset(dateTime);
				return (Class23.Enum5)0;
			}
		}
		byte[] b;
		if ((b = (object_0 as byte[])) != null && type_0 == typeof(Guid))
		{
			object_2 = new Guid(b);
			return (Class23.Enum5)0;
		}
		if (object_0 is Guid)
		{
			Guid guid = (Guid)object_0;
			if (type_0 == typeof(byte[]))
			{
				object_2 = guid.ToByteArray();
				return (Class23.Enum5)0;
			}
		}
		string text;
		if ((text = (object_0 as string)) != null)
		{
			if (type_0 == typeof(Guid))
			{
				object_2 = new Guid(text);
				return (Class23.Enum5)0;
			}
			if (type_0 == typeof(Uri))
			{
				object_2 = new Uri(text, UriKind.RelativeOrAbsolute);
				return (Class23.Enum5)0;
			}
			if (type_0 == typeof(TimeSpan))
			{
				object_2 = Class23.smethod_4(text);
				return (Class23.Enum5)0;
			}
			if (type_0 == typeof(byte[]))
			{
				object_2 = Convert.FromBase64String(text);
				return (Class23.Enum5)0;
			}
			if (type_0 == typeof(Version))
			{
				Version version;
				if (Version.TryParse(text, out version))
				{
					object_2 = version;
					return (Class23.Enum5)0;
				}
				object_2 = null;
				return (Class23.Enum5)3;
			}
			else if (typeof(Type).IsAssignableFrom(type_0))
			{
				object_2 = Type.GetType(text, true);
				return (Class23.Enum5)0;
			}
		}
		if (type_0 == typeof(BigInteger))
		{
			object_2 = Class23.smethod_6(object_0);
			return (Class23.Enum5)0;
		}
		if (object_0 is BigInteger)
		{
			BigInteger bigInteger_ = (BigInteger)object_0;
			object_2 = Class23.smethod_7(bigInteger_, type_0);
			return (Class23.Enum5)0;
		}
		TypeConverter converter = TypeDescriptor.GetConverter(type);
		if (converter != null && converter.CanConvertTo(type_0))
		{
			object_2 = converter.ConvertTo(null, object_1, object_0, type_0);
			return (Class23.Enum5)0;
		}
		TypeConverter converter2 = TypeDescriptor.GetConverter(type_0);
		if (converter2 != null && converter2.CanConvertFrom(type))
		{
			object_2 = converter2.ConvertFrom(null, object_1, object_0);
			return (Class23.Enum5)0;
		}
		if (object_0 == DBNull.Value)
		{
			if (Class90.smethod_10(type_0))
			{
				object_2 = Class23.smethod_11(null, type, type_0);
				return (Class23.Enum5)0;
			}
			object_2 = null;
			return (Class23.Enum5)1;
		}
		else
		{
			if (!type_0.smethod_3() && !type_0.smethod_5() && !type_0.smethod_11())
			{
				object_2 = null;
				return (Class23.Enum5)3;
			}
			object_2 = null;
			return (Class23.Enum5)2;
		}
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00027A1C File Offset: 0x00025C1C
	public static object smethod_10(object object_0, object object_1, Type type_0)
	{
		if (type_0 == typeof(object))
		{
			return object_0;
		}
		if (object_0 == null && Class90.smethod_10(type_0))
		{
			return null;
		}
		object result;
		if (Class23.TryConvert(object_0, object_1, type_0, out result))
		{
			return result;
		}
		return Class23.smethod_11(object_0, Class90.smethod_3(object_0), type_0);
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00027A68 File Offset: 0x00025C68
	private static object smethod_11(object object_0, Type type_0, Type type_1)
	{
		Type type = (object_0 != null) ? object_0.GetType() : null;
		if (object_0 != null)
		{
			if (type_1.IsAssignableFrom(type))
			{
				return object_0;
			}
			Func<object, object> func = Class23.class99_0.Get(new Struct9<Type, Type>(type, type_1));
			if (func != null)
			{
				return func(object_0);
			}
		}
		else if (Class90.smethod_10(type_1))
		{
			return null;
		}
		string string_ = "Could not cast or convert from {0} to {1}.";
		IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
		string object_;
		if (type_0 != null)
		{
			if ((object_ = type_0.ToString()) != null)
			{
				goto IL_5F;
			}
		}
		object_ = "{null}";
		IL_5F:
		throw new ArgumentException(string_.smethod_1(invariantCulture, object_, type_1));
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00006A0C File Offset: 0x00004C0C
	public static bool smethod_12(string string_0, out Version version_0)
	{
		return Version.TryParse(string_0, out version_0);
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00027AE4 File Offset: 0x00025CE4
	public static bool smethod_13(object object_0)
	{
		switch (Class23.smethod_0(object_0.GetType()))
		{
		case (Enum3)6:
		case (Enum3)8:
		case (Enum3)10:
		case (Enum3)12:
		case (Enum3)14:
		case (Enum3)16:
		case (Enum3)18:
		case (Enum3)20:
			return true;
		default:
			return false;
		}
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00027B44 File Offset: 0x00025D44
	public static Enum4 smethod_14(object object_0, int int_0, int int_1, out int int_2)
	{
		int_2 = 0;
		if (int_1 == 0)
		{
			return (Enum4)3;
		}
		bool flag;
		if (flag = (object_0[int_0] == 45))
		{
			if (int_1 == 1)
			{
				return (Enum4)3;
			}
			int_0++;
			int_1--;
		}
		int num = int_0 + int_1;
		if (int_1 <= 10 && (int_1 != 10 || object_0[int_0] - 48 <= 2))
		{
			for (int i = int_0; i < num; i++)
			{
				int num2 = object_0[i] - 48;
				if (num2 < 0 || num2 > 9)
				{
					return (Enum4)3;
				}
				int num3 = 10 * int_2 - num2;
				if (num3 > int_2)
				{
					for (i++; i < num; i++)
					{
						num2 = object_0[i] - 48;
						if (num2 < 0 || num2 > 9)
						{
							return (Enum4)3;
						}
					}
					return (Enum4)2;
				}
				int_2 = num3;
			}
			if (!flag)
			{
				if (int_2 == -2147483648)
				{
					return (Enum4)2;
				}
				int_2 = -int_2;
			}
			return (Enum4)1;
		}
		for (int j = int_0; j < num; j++)
		{
			int num4 = object_0[j] - 48;
			if (num4 < 0 || num4 > 9)
			{
				return (Enum4)3;
			}
		}
		return (Enum4)2;
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x00027C1C File Offset: 0x00025E1C
	public static Enum4 smethod_15(object object_0, int int_0, int int_1, out long long_0)
	{
		long_0 = 0L;
		if (int_1 == 0)
		{
			return (Enum4)3;
		}
		bool flag;
		if (flag = (object_0[int_0] == 45))
		{
			if (int_1 == 1)
			{
				return (Enum4)3;
			}
			int_0++;
			int_1--;
		}
		int num = int_0 + int_1;
		if (int_1 > 19)
		{
			for (int i = int_0; i < num; i++)
			{
				int num2 = object_0[i] - 48;
				if (num2 < 0 || num2 > 9)
				{
					return (Enum4)3;
				}
			}
			return (Enum4)2;
		}
		for (int j = int_0; j < num; j++)
		{
			int num3 = object_0[j] - 48;
			if (num3 < 0 || num3 > 9)
			{
				return (Enum4)3;
			}
			long num4 = 10L * long_0 - (long)num3;
			if (num4 > long_0)
			{
				for (j++; j < num; j++)
				{
					num3 = object_0[j] - 48;
					if (num3 < 0 || num3 > 9)
					{
						return (Enum4)3;
					}
				}
				return (Enum4)2;
			}
			long_0 = num4;
		}
		if (!flag)
		{
			if (long_0 == -9223372036854775808L)
			{
				return (Enum4)2;
			}
			long_0 = -long_0;
		}
		return (Enum4)1;
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00027CF8 File Offset: 0x00025EF8
	public static Enum4 smethod_16(object object_0, int int_0, int int_1, out decimal decimal_0)
	{
		decimal_0 = 0m;
		if (int_1 == 0)
		{
			return (Enum4)3;
		}
		bool flag;
		if (flag = (object_0[int_0] == 45))
		{
			if (int_1 == 1)
			{
				return (Enum4)3;
			}
			int_0++;
			int_1--;
		}
		int i = int_0;
		int num = int_0 + int_1;
		int num2 = num;
		int num3 = num;
		int num4 = 0;
		ulong num5 = 0UL;
		ulong num6 = 0UL;
		int num7 = 0;
		int num8 = 0;
		char? c = null;
		bool? flag2 = null;
		while (i < num)
		{
			char c2 = object_0[i];
			if (c2 == '.')
			{
				goto IL_21F;
			}
			if (c2 != 'E' && c2 != 'e')
			{
				if (c2 >= '0' && c2 <= '9')
				{
					if (i == int_0 && c2 == '0')
					{
						i++;
						if (i != num)
						{
							c2 = object_0[i];
							if (c2 == '.')
							{
								goto IL_21F;
							}
							if (c2 != 'e' && c2 != 'E')
							{
								return (Enum4)3;
							}
							goto IL_19B;
						}
					}
					if (num7 < 29)
					{
						if (num7 == 28)
						{
							bool? flag3 = flag2;
							bool valueOrDefault;
							if (flag3 == null)
							{
								flag2 = new bool?(num5 > 7922816251426433759UL || (num5 == 7922816251426433759UL && (num6 > 354395033UL || (num6 == 354395033UL && c2 > '5'))));
								bool? flag4 = flag2;
								valueOrDefault = flag4.GetValueOrDefault();
							}
							else
							{
								valueOrDefault = flag3.GetValueOrDefault();
							}
							if (valueOrDefault)
							{
								goto IL_17F;
							}
						}
						if (num7 < 19)
						{
							num5 = num5 * 10UL + (ulong)((long)(c2 - '0'));
						}
						else
						{
							num6 = num6 * 10UL + (ulong)((long)(c2 - '0'));
						}
						num7++;
						goto IL_242;
					}
					IL_17F:
					if (c == null)
					{
						c = new char?(c2);
					}
					num8++;
					goto IL_242;
				}
				return (Enum4)3;
			}
			IL_19B:
			if (i == int_0)
			{
				return (Enum4)3;
			}
			if (i == num2)
			{
				return (Enum4)3;
			}
			i++;
			if (i == num)
			{
				return (Enum4)3;
			}
			if (num2 < num)
			{
				num3 = i - 1;
			}
			c2 = object_0[i];
			bool flag5 = false;
			if (c2 != '+')
			{
				if (c2 == '-')
				{
					flag5 = true;
					i++;
				}
			}
			else
			{
				i++;
			}
			while (i < num)
			{
				c2 = object_0[i];
				if (c2 < '0' || c2 > '9')
				{
					return (Enum4)3;
				}
				int num9 = 10 * num4 + (int)(c2 - '0');
				if (num4 < num9)
				{
					num4 = num9;
				}
				i++;
			}
			if (flag5)
			{
				num4 = -num4;
			}
			IL_242:
			i++;
			continue;
			IL_21F:
			if (i == int_0)
			{
				return (Enum4)3;
			}
			if (i + 1 == num)
			{
				return (Enum4)3;
			}
			if (num2 != num)
			{
				return (Enum4)3;
			}
			num2 = i + 1;
			goto IL_242;
		}
		num4 += num8;
		num4 -= num3 - num2;
		if (num7 <= 19)
		{
			decimal_0 = num5;
		}
		else
		{
			decimal_0 = num5 / new decimal(1, 0, 0, false, (byte)(num7 - 19)) + num6;
		}
		if (num4 > 0)
		{
			num7 += num4;
			if (num7 > 29)
			{
				return (Enum4)2;
			}
			if (num7 == 29)
			{
				if (num4 > 1)
				{
					decimal_0 /= new decimal(1, 0, 0, false, (byte)(num4 - 1));
					if (decimal_0 > 7922816251426433759354395033m)
					{
						return (Enum4)2;
					}
				}
				else if (decimal_0 == 7922816251426433759354395033m)
				{
					char? c3 = c;
					int? num10 = (c3 != null) ? new int?((int)c3.GetValueOrDefault()) : null;
					if (num10.GetValueOrDefault() > 53 & num10 != null)
					{
						return (Enum4)2;
					}
				}
				decimal_0 *= 10m;
			}
			else
			{
				decimal_0 /= new decimal(1, 0, 0, false, (byte)num4);
			}
		}
		else
		{
			char? c3 = c;
			int? num10 = (c3 != null) ? new int?((int)c3.GetValueOrDefault()) : null;
			if ((num10.GetValueOrDefault() >= 53 & num10 != null) && num4 >= -28)
			{
				decimal_0 = ++decimal_0;
			}
			if (num4 < 0)
			{
				if (num7 + num4 + 28 <= 0)
				{
					decimal_0 = (flag ? 0m : 0m);
					return (Enum4)1;
				}
				if (num4 >= -28)
				{
					decimal_0 *= new decimal(1, 0, 0, false, (byte)(-(byte)num4));
				}
				else
				{
					decimal_0 /= 10000000000000000000000000000m;
					decimal_0 *= new decimal(1, 0, 0, false, (byte)(-num4 - 28));
				}
			}
		}
		if (flag)
		{
			decimal_0 = -decimal_0;
		}
		return (Enum4)1;
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00006A15 File Offset: 0x00004C15
	public static bool smethod_17(string string_0, out Guid guid_0)
	{
		return Guid.TryParseExact(string_0, "D", out guid_0);
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x000281C8 File Offset: 0x000263C8
	public static bool smethod_18(object object_0, int int_0, int int_1, out int int_2)
	{
		int_2 = 0;
		for (int i = int_0; i < int_1; i++)
		{
			char c = object_0[i];
			int num;
			if (c <= '9' && c >= '0')
			{
				num = (int)(c - '0');
			}
			else if (c <= 'F' && c >= 'A')
			{
				num = (int)(c - '7');
			}
			else
			{
				if (c > 'f' || c < 'a')
				{
					int_2 = 0;
					return false;
				}
				num = (int)(c - 'W');
			}
			int_2 += num << (int_1 - 1 - i) * 4;
		}
		return true;
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x00028230 File Offset: 0x00026430
	// Note: this type is marked as 'beforefieldinit'.
	static Class23()
	{
		Class202.ofdixO4zTbIfy();
		Class23.dictionary_0 = new Dictionary<Type, Enum3>
		{
			{
				typeof(char),
				(Enum3)2
			},
			{
				typeof(char?),
				(Enum3)3
			},
			{
				typeof(bool),
				(Enum3)4
			},
			{
				typeof(bool?),
				(Enum3)5
			},
			{
				typeof(sbyte),
				(Enum3)6
			},
			{
				typeof(sbyte?),
				(Enum3)7
			},
			{
				typeof(short),
				(Enum3)8
			},
			{
				typeof(short?),
				(Enum3)9
			},
			{
				typeof(ushort),
				(Enum3)10
			},
			{
				typeof(ushort?),
				(Enum3)11
			},
			{
				typeof(int),
				(Enum3)12
			},
			{
				typeof(int?),
				(Enum3)13
			},
			{
				typeof(byte),
				(Enum3)14
			},
			{
				typeof(byte?),
				(Enum3)15
			},
			{
				typeof(uint),
				(Enum3)16
			},
			{
				typeof(uint?),
				(Enum3)17
			},
			{
				typeof(long),
				(Enum3)18
			},
			{
				typeof(long?),
				(Enum3)19
			},
			{
				typeof(ulong),
				(Enum3)20
			},
			{
				typeof(ulong?),
				(Enum3)21
			},
			{
				typeof(float),
				(Enum3)22
			},
			{
				typeof(float?),
				(Enum3)23
			},
			{
				typeof(double),
				(Enum3)24
			},
			{
				typeof(double?),
				(Enum3)25
			},
			{
				typeof(DateTime),
				(Enum3)26
			},
			{
				typeof(DateTime?),
				(Enum3)27
			},
			{
				typeof(DateTimeOffset),
				(Enum3)28
			},
			{
				typeof(DateTimeOffset?),
				(Enum3)29
			},
			{
				typeof(decimal),
				(Enum3)30
			},
			{
				typeof(decimal?),
				(Enum3)31
			},
			{
				typeof(Guid),
				(Enum3)32
			},
			{
				typeof(Guid?),
				(Enum3)33
			},
			{
				typeof(TimeSpan),
				(Enum3)34
			},
			{
				typeof(TimeSpan?),
				(Enum3)35
			},
			{
				typeof(BigInteger),
				(Enum3)36
			},
			{
				typeof(BigInteger?),
				(Enum3)37
			},
			{
				typeof(Uri),
				(Enum3)38
			},
			{
				typeof(string),
				(Enum3)39
			},
			{
				typeof(byte[]),
				(Enum3)40
			},
			{
				typeof(DBNull),
				(Enum3)41
			}
		};
		Class22[] array = new Class22[19];
		int num = 0;
		Class22 @class = new Class22();
		@class.Type = typeof(object);
		@class.method_1((Enum3)0);
		array[num] = @class;
		int num2 = 1;
		Class22 class2 = new Class22();
		class2.Type = typeof(object);
		class2.method_1((Enum3)1);
		array[num2] = class2;
		int num3 = 2;
		Class22 class3 = new Class22();
		class3.Type = typeof(object);
		class3.method_1((Enum3)41);
		array[num3] = class3;
		int num4 = 3;
		Class22 class4 = new Class22();
		class4.Type = typeof(bool);
		class4.method_1((Enum3)4);
		array[num4] = class4;
		int num5 = 4;
		Class22 class5 = new Class22();
		class5.Type = typeof(char);
		class5.method_1((Enum3)2);
		array[num5] = class5;
		int num6 = 5;
		Class22 class6 = new Class22();
		class6.Type = typeof(sbyte);
		class6.method_1((Enum3)6);
		array[num6] = class6;
		int num7 = 6;
		Class22 class7 = new Class22();
		class7.Type = typeof(byte);
		class7.method_1((Enum3)14);
		array[num7] = class7;
		int num8 = 7;
		Class22 class8 = new Class22();
		class8.Type = typeof(short);
		class8.method_1((Enum3)8);
		array[num8] = class8;
		int num9 = 8;
		Class22 class9 = new Class22();
		class9.Type = typeof(ushort);
		class9.method_1((Enum3)10);
		array[num9] = class9;
		int num10 = 9;
		Class22 class10 = new Class22();
		class10.Type = typeof(int);
		class10.method_1((Enum3)12);
		array[num10] = class10;
		int num11 = 10;
		Class22 class11 = new Class22();
		class11.Type = typeof(uint);
		class11.method_1((Enum3)16);
		array[num11] = class11;
		int num12 = 11;
		Class22 class12 = new Class22();
		class12.Type = typeof(long);
		class12.method_1((Enum3)18);
		array[num12] = class12;
		int num13 = 12;
		Class22 class13 = new Class22();
		class13.Type = typeof(ulong);
		class13.method_1((Enum3)20);
		array[num13] = class13;
		int num14 = 13;
		Class22 class14 = new Class22();
		class14.Type = typeof(float);
		class14.method_1((Enum3)22);
		array[num14] = class14;
		int num15 = 14;
		Class22 class15 = new Class22();
		class15.Type = typeof(double);
		class15.method_1((Enum3)24);
		array[num15] = class15;
		int num16 = 15;
		Class22 class16 = new Class22();
		class16.Type = typeof(decimal);
		class16.method_1((Enum3)30);
		array[num16] = class16;
		int num17 = 16;
		Class22 class17 = new Class22();
		class17.Type = typeof(DateTime);
		class17.method_1((Enum3)26);
		array[num17] = class17;
		int num18 = 17;
		Class22 class18 = new Class22();
		class18.Type = typeof(object);
		class18.method_1((Enum3)0);
		array[num18] = class18;
		int num19 = 18;
		Class22 class19 = new Class22();
		class19.Type = typeof(string);
		class19.method_1((Enum3)39);
		array[num19] = class19;
		Class23.class22_0 = array;
		Class23.class99_0 = new Class99<Struct9<Type, Type>, Func<object, object>>(new Func<Struct9<Type, Type>, Func<object, object>>(Class23.smethod_5));
	}

	// Token: 0x040003C9 RID: 969
	private static readonly Dictionary<Type, Enum3> dictionary_0;

	// Token: 0x040003CA RID: 970
	private static readonly Class22[] class22_0;

	// Token: 0x040003CB RID: 971
	private static readonly Class99<Struct9<Type, Type>, Func<object, object>> class99_0;

	// Token: 0x020000AA RID: 170
	internal enum Enum5
	{

	}

	// Token: 0x020000AB RID: 171
	[CompilerGenerated]
	private sealed class Class24
	{
		// Token: 0x060005C3 RID: 1475 RVA: 0x00002621 File Offset: 0x00000821
		public Class24()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00006A23 File Offset: 0x00004C23
		internal object method_0(object object_0)
		{
			return this.delegate1_0(null, new object[]
			{
				object_0
			});
		}

		// Token: 0x040003CD RID: 973
		public Delegate1<object, object> delegate1_0;
	}
}
