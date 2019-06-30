using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json.Serialization;

// Token: 0x020000CC RID: 204
internal static class Class53
{
	// Token: 0x06000685 RID: 1669 RVA: 0x0002B4A4 File Offset: 0x000296A4
	private static Class52 smethod_0(Struct9<Type, NamingStrategy> struct9_0)
	{
		Type gparam_ = struct9_0.gparam_0;
		string[] names = Enum.GetNames(gparam_);
		string[] array = new string[names.Length];
		ulong[] array2 = new ulong[names.Length];
		for (int i = 0; i < names.Length; i++)
		{
			string name = names[i];
			FieldInfo field = gparam_.GetField(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			array2[i] = Class53.smethod_6(field.GetValue(null));
			string text = field.GetCustomAttributes(typeof(EnumMemberAttribute), true).Cast<EnumMemberAttribute>().Select(new Func<EnumMemberAttribute, string>(Class53.Class54.class54_0.method_0)).SingleOrDefault<string>() ?? field.Name;
			if (Array.IndexOf<string>(array, text, 0, i) != -1)
			{
				throw new InvalidOperationException("Enum name '{0}' already exists on enum '{1}'.".smethod_1(CultureInfo.InvariantCulture, text, gparam_.Name));
			}
			array[i] = ((struct9_0.gparam_1 != null) ? struct9_0.gparam_1.GetPropertyName(text, false) : text);
		}
		return new Class52(gparam_.IsDefined(typeof(FlagsAttribute), false), array2, names, array);
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x0002B5C8 File Offset: 0x000297C8
	public static IList<FLhW6tQJXRaEOkM5DWI> smethod_1<FLhW6tQJXRaEOkM5DWI>(FLhW6tQJXRaEOkM5DWI i9yu2fQKFA1w1fr3s7w) where FLhW6tQJXRaEOkM5DWI : struct
	{
		Type typeFromHandle = typeof(FLhW6tQJXRaEOkM5DWI);
		if (!typeFromHandle.IsDefined(typeof(FlagsAttribute), false))
		{
			throw new ArgumentException("Enum type {0} is not a set of flags.".smethod_0(CultureInfo.InvariantCulture, typeFromHandle));
		}
		Type underlyingType = Enum.GetUnderlyingType(i9yu2fQKFA1w1fr3s7w.GetType());
		ulong num = Class53.smethod_6(i9yu2fQKFA1w1fr3s7w);
		Class52 @class = Class53.smethod_5(typeFromHandle);
		IList<FLhW6tQJXRaEOkM5DWI> list = new List<FLhW6tQJXRaEOkM5DWI>();
		for (int i = 0; i < @class.ulong_0.Length; i++)
		{
			ulong num2 = @class.ulong_0[i];
			if ((num & num2) == num2 && num2 != 0UL)
			{
				list.Add((FLhW6tQJXRaEOkM5DWI)((object)Convert.ChangeType(num2, underlyingType, CultureInfo.CurrentCulture)));
			}
		}
		if (list.Count == 0)
		{
			if (@class.ulong_0.Any(new Func<ulong, bool>(Class53.Class55<FLhW6tQJXRaEOkM5DWI>.class55_0.method_0)))
			{
				list.Add(default(FLhW6tQJXRaEOkM5DWI));
			}
		}
		return list;
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x0000733F File Offset: 0x0000553F
	public static bool smethod_2(Type type_0, object object_0, bool bool_0, out string string_0)
	{
		return Class53.smethod_3(type_0, object_0, bool_0 ? Class53.camelCaseNamingStrategy_0 : null, out string_0);
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x0002B6CC File Offset: 0x000298CC
	public static bool smethod_3(Type type_0, object object_0, object object_1, out string string_0)
	{
		Class52 @class = Class53.class99_0.Get(new Struct9<Type, NamingStrategy>(type_0, object_1));
		ulong num = Class53.smethod_6(object_0);
		if (@class.bool_0)
		{
			string_0 = Class53.smethod_4(@class, num);
			return string_0 != null;
		}
		int num2 = Array.BinarySearch<ulong>(@class.ulong_0, num);
		if (num2 >= 0)
		{
			string_0 = @class.string_1[num2];
			return true;
		}
		string_0 = null;
		return false;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x0002B730 File Offset: 0x00029930
	private static string smethod_4(object object_0, ulong ulong_0)
	{
		string[] string_ = object_0.string_1;
		ulong[] ulong_ = object_0.ulong_0;
		int num = ulong_.Length - 1;
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		ulong num2 = ulong_0;
		while (num >= 0 && (num != 0 || ulong_[num] != 0UL))
		{
			if ((ulong_0 & ulong_[num]) == ulong_[num])
			{
				ulong_0 -= ulong_[num];
				if (!flag)
				{
					stringBuilder.Insert(0, ", ");
				}
				string value = string_[num];
				stringBuilder.Insert(0, value);
				flag = false;
			}
			num--;
		}
		string result;
		if (ulong_0 != 0UL)
		{
			result = null;
		}
		else if (num2 == 0UL)
		{
			if (ulong_.Length != 0 && ulong_[0] == 0UL)
			{
				result = string_[0];
			}
			else
			{
				result = null;
			}
		}
		else
		{
			result = stringBuilder.ToString();
		}
		return result;
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00007354 File Offset: 0x00005554
	public static Class52 smethod_5(Type type_0)
	{
		return Class53.class99_0.Get(new Struct9<Type, NamingStrategy>(type_0, null));
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x0002B7D8 File Offset: 0x000299D8
	private static ulong smethod_6(object object_0)
	{
		bool flag;
		switch (Class23.smethod_1(object_0.GetType(), out flag))
		{
		case (Enum3)2:
			return (ulong)((char)object_0);
		case (Enum3)4:
			return (ulong)Convert.ToByte((bool)object_0);
		case (Enum3)6:
			return (ulong)((long)((sbyte)object_0));
		case (Enum3)8:
			return (ulong)((long)((short)object_0));
		case (Enum3)10:
			return (ulong)((ushort)object_0);
		case (Enum3)12:
			return (ulong)((long)((int)object_0));
		case (Enum3)14:
			return (ulong)((byte)object_0);
		case (Enum3)16:
			return (ulong)((uint)object_0);
		case (Enum3)18:
			return (ulong)((long)object_0);
		case (Enum3)20:
			return (ulong)object_0;
		}
		throw new InvalidOperationException("Unknown enum type.");
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x0002B8A8 File Offset: 0x00029AA8
	public static object smethod_7(Type type_0, object object_0, string string_0, bool bool_0)
	{
		Class101.smethod_0(type_0, "enumType");
		Class101.smethod_0(string_0, "value");
		if (!type_0.smethod_8())
		{
			throw new ArgumentException("Type provided must be an Enum.", "enumType");
		}
		Class52 @class = Class53.class99_0.Get(new Struct9<Type, NamingStrategy>(type_0, object_0));
		string[] string_ = @class.string_0;
		string[] string_2 = @class.string_1;
		ulong[] ulong_ = @class.ulong_0;
		int? num = Class53.smethod_9(string_2, string_0, 0, string_0.Length, StringComparison.Ordinal);
		if (num != null)
		{
			return Enum.ToObject(type_0, ulong_[num.Value]);
		}
		int num2 = -1;
		int i = 0;
		while (i < string_0.Length)
		{
			if (char.IsWhiteSpace(string_0[i]))
			{
				i++;
			}
			else
			{
				num2 = i;
				IL_A9:
				if (num2 == -1)
				{
					throw new ArgumentException("Must specify valid information for parsing in the string.");
				}
				char c = string_0[num2];
				if (char.IsDigit(c) || c == '-' || c == '+')
				{
					Type underlyingType = Enum.GetUnderlyingType(type_0);
					string_0 = string_0.Trim();
					object obj = null;
					try
					{
						obj = Convert.ChangeType(string_0, underlyingType, CultureInfo.InvariantCulture);
					}
					catch (FormatException)
					{
					}
					if (obj != null)
					{
						if (bool_0)
						{
							throw new FormatException("Integer string '{0}' is not allowed.".smethod_0(CultureInfo.InvariantCulture, string_0));
						}
						return Enum.ToObject(type_0, obj);
					}
				}
				ulong num3 = 0UL;
				int j = num2;
				while (j <= string_0.Length)
				{
					int num4 = string_0.IndexOf(',', j);
					if (num4 == -1)
					{
						num4 = string_0.Length;
					}
					int num5 = num4;
					while (j < num4 && char.IsWhiteSpace(string_0[j]))
					{
						j++;
					}
					while (num5 > j && char.IsWhiteSpace(string_0[num5 - 1]))
					{
						num5--;
					}
					int int_ = num5 - j;
					num = Class53.smethod_8(string_0, string_, string_2, j, int_, StringComparison.Ordinal);
					if (num == null)
					{
						num = Class53.smethod_8(string_0, string_, string_2, j, int_, StringComparison.OrdinalIgnoreCase);
					}
					if (num != null)
					{
						num3 |= ulong_[num.Value];
						j = num4 + 1;
					}
					else
					{
						num = Class53.smethod_9(string_2, string_0, 0, string_0.Length, StringComparison.OrdinalIgnoreCase);
						if (num == null)
						{
							throw new ArgumentException("Requested value '{0}' was not found.".smethod_0(CultureInfo.InvariantCulture, string_0));
						}
						return Enum.ToObject(type_0, ulong_[num.Value]);
					}
				}
				return Enum.ToObject(type_0, num3);
			}
		}
		goto IL_A9;
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x0002BAE8 File Offset: 0x00029CE8
	private static int? smethod_8(string string_0, object object_0, object object_1, int int_0, int int_1, StringComparison stringComparison_0)
	{
		int? result = Class53.smethod_9(object_1, string_0, int_0, int_1, stringComparison_0);
		if (result == null)
		{
			result = Class53.smethod_9(object_0, string_0, int_0, int_1, stringComparison_0);
		}
		return result;
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x0002BB1C File Offset: 0x00029D1C
	private static int? smethod_9(object object_0, string string_0, int int_0, int int_1, StringComparison stringComparison_0)
	{
		for (int i = 0; i < object_0.Length; i++)
		{
			if (object_0[i].Length == int_1 && string.Compare(object_0[i], 0, string_0, int_0, int_1, stringComparison_0) == 0)
			{
				return new int?(i);
			}
		}
		return null;
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00007367 File Offset: 0x00005567
	// Note: this type is marked as 'beforefieldinit'.
	static Class53()
	{
		Class202.ofdixO4zTbIfy();
		Class53.class99_0 = new Class99<Struct9<Type, NamingStrategy>, Class52>(new Func<Struct9<Type, NamingStrategy>, Class52>(Class53.smethod_0));
		Class53.camelCaseNamingStrategy_0 = new CamelCaseNamingStrategy();
	}

	// Token: 0x04000425 RID: 1061
	private static readonly Class99<Struct9<Type, NamingStrategy>, Class52> class99_0;

	// Token: 0x04000426 RID: 1062
	private static CamelCaseNamingStrategy camelCaseNamingStrategy_0;

	// Token: 0x020000CD RID: 205
	[CompilerGenerated]
	[Serializable]
	private sealed class Class54
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x0000738E File Offset: 0x0000558E
		// Note: this type is marked as 'beforefieldinit'.
		static Class54()
		{
			Class202.ofdixO4zTbIfy();
			Class53.Class54.class54_0 = new Class53.Class54();
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00002621 File Offset: 0x00000821
		public Class54()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000739F File Offset: 0x0000559F
		internal string method_0(EnumMemberAttribute enumMemberAttribute_0)
		{
			return enumMemberAttribute_0.Value;
		}

		// Token: 0x04000427 RID: 1063
		public static readonly Class53.Class54 class54_0;

		// Token: 0x04000428 RID: 1064
		public static Func<EnumMemberAttribute, string> func_0;
	}

	// Token: 0x020000CE RID: 206
	[CompilerGenerated]
	[Serializable]
	private sealed class Class55<t5CWRastOkghLMPWhSl> where t5CWRastOkghLMPWhSl : struct
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x000073A7 File Offset: 0x000055A7
		// Note: this type is marked as 'beforefieldinit'.
		static Class55()
		{
			Class202.ofdixO4zTbIfy();
			Class53.Class55<t5CWRastOkghLMPWhSl>.class55_0 = new Class53.Class55<t5CWRastOkghLMPWhSl>();
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002621 File Offset: 0x00000821
		public Class55()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000073B8 File Offset: 0x000055B8
		internal bool method_0(ulong ulong_0)
		{
			return ulong_0 == 0UL;
		}

		// Token: 0x04000429 RID: 1065
		public static readonly Class53.Class55<t5CWRastOkghLMPWhSl> class55_0;

		// Token: 0x0400042A RID: 1066
		public static Func<ulong, bool> func_0;
	}
}
