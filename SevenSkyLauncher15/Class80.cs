using System;
using System.Globalization;
using System.Text.RegularExpressions;

// Token: 0x020000EE RID: 238
internal static class Class80
{
	// Token: 0x06000725 RID: 1829 RVA: 0x0002DE30 File Offset: 0x0002C030
	public static bool smethod_0(object object_0, object object_1)
	{
		if (object_0 == object_1)
		{
			return true;
		}
		if (object_0 == null || object_1 == null)
		{
			return false;
		}
		if (!(object_0.GetType() != object_1.GetType()))
		{
			return object_0.Equals(object_1);
		}
		if (Class23.smethod_13(object_0) && Class23.smethod_13(object_1))
		{
			return Convert.ToDecimal(object_0, CultureInfo.CurrentCulture).Equals(Convert.ToDecimal(object_1, CultureInfo.CurrentCulture));
		}
		return (object_0 is double || object_0 is float || object_0 is decimal) && (object_1 is double || object_1 is float || object_1 is decimal) && Class79.smethod_5(Convert.ToDouble(object_0, CultureInfo.CurrentCulture), Convert.ToDouble(object_1, CultureInfo.CurrentCulture));
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
	public static ArgumentOutOfRangeException smethod_1(string string_0, object object_0, string string_1)
	{
		string message = string_1 + Environment.NewLine + "Actual value was {0}.".smethod_0(CultureInfo.InvariantCulture, object_0);
		return new ArgumentOutOfRangeException(string_0, message);
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x0002DF18 File Offset: 0x0002C118
	public static string smethod_2(object object_0)
	{
		if (object_0 == null)
		{
			return "{null}";
		}
		string str;
		if ((str = (object_0 as string)) == null)
		{
			return object_0.ToString();
		}
		return "\"" + str + "\"";
	}

	// Token: 0x06000728 RID: 1832 RVA: 0x0002DF50 File Offset: 0x0002C150
	public static int smethod_3(object object_0, object object_1)
	{
		int num = object_0.Length.CompareTo(object_1.Length);
		if (num != 0)
		{
			return num;
		}
		for (int i = 0; i < object_0.Length; i++)
		{
			int num2 = object_0[i].CompareTo(object_1[i]);
			if (num2 != 0)
			{
				return num2;
			}
		}
		return 0;
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x0002DF98 File Offset: 0x0002C198
	public static string smethod_4(string string_0)
	{
		string result;
		string text;
		Class80.smethod_6(string_0, out result, out text);
		return result;
	}

	// Token: 0x0600072A RID: 1834 RVA: 0x0002DFB0 File Offset: 0x0002C1B0
	public static string smethod_5(string string_0)
	{
		string text;
		string result;
		Class80.smethod_6(string_0, out text, out result);
		return result;
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x0002DFC8 File Offset: 0x0002C1C8
	public static void smethod_6(string string_0, out string string_1, out string string_2)
	{
		int num = string_0.IndexOf(':');
		if (num != -1 && num != 0)
		{
			if (string_0.Length - 1 != num)
			{
				string_1 = string_0.Substring(0, num);
				string_2 = string_0.Substring(num + 1);
				return;
			}
		}
		string_1 = null;
		string_2 = string_0;
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x0002E010 File Offset: 0x0002C210
	internal static RegexOptions smethod_7(string string_0)
	{
		RegexOptions regexOptions = RegexOptions.None;
		foreach (char c in string_0)
		{
			if (c <= 'm')
			{
				if (c != 'i')
				{
					if (c == 'm')
					{
						regexOptions |= RegexOptions.Multiline;
					}
				}
				else
				{
					regexOptions |= RegexOptions.IgnoreCase;
				}
			}
			else if (c != 's')
			{
				if (c == 'x')
				{
					regexOptions |= RegexOptions.ExplicitCapture;
				}
			}
			else
			{
				regexOptions |= RegexOptions.Singleline;
			}
		}
		return regexOptions;
	}
}
