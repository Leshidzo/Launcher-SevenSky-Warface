using System;

// Token: 0x020000EB RID: 235
internal static class Class79
{
	// Token: 0x06000717 RID: 1815 RVA: 0x0002DCC4 File Offset: 0x0002BEC4
	public static int smethod_0(ulong ulong_0)
	{
		if (ulong_0 < 10000000000UL)
		{
			if (ulong_0 < 10UL)
			{
				return 1;
			}
			if (ulong_0 < 100UL)
			{
				return 2;
			}
			if (ulong_0 < 1000UL)
			{
				return 3;
			}
			if (ulong_0 < 10000UL)
			{
				return 4;
			}
			if (ulong_0 < 100000UL)
			{
				return 5;
			}
			if (ulong_0 < 1000000UL)
			{
				return 6;
			}
			if (ulong_0 < 10000000UL)
			{
				return 7;
			}
			if (ulong_0 < 100000000UL)
			{
				return 8;
			}
			if (ulong_0 < 1000000000UL)
			{
				return 9;
			}
			return 10;
		}
		else
		{
			if (ulong_0 < 100000000000UL)
			{
				return 11;
			}
			if (ulong_0 < 1000000000000UL)
			{
				return 12;
			}
			if (ulong_0 < 10000000000000UL)
			{
				return 13;
			}
			if (ulong_0 < 100000000000000UL)
			{
				return 14;
			}
			if (ulong_0 < 1000000000000000UL)
			{
				return 15;
			}
			if (ulong_0 < 10000000000000000UL)
			{
				return 16;
			}
			if (ulong_0 < 100000000000000000UL)
			{
				return 17;
			}
			if (ulong_0 < 1000000000000000000UL)
			{
				return 18;
			}
			if (ulong_0 < 10000000000000000000UL)
			{
				return 19;
			}
			return 20;
		}
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x000078D5 File Offset: 0x00005AD5
	public static char smethod_1(int int_0)
	{
		if (int_0 <= 9)
		{
			return (char)(int_0 + 48);
		}
		return (char)(int_0 - 10 + 97);
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x000078EA File Offset: 0x00005AEA
	public static int? smethod_2(int? nullable_0, int? nullable_1)
	{
		if (nullable_0 == null)
		{
			return nullable_1;
		}
		if (nullable_1 == null)
		{
			return nullable_0;
		}
		return new int?(Math.Min(nullable_0.GetValueOrDefault(), nullable_1.GetValueOrDefault()));
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x0000791A File Offset: 0x00005B1A
	public static int? smethod_3(int? nullable_0, int? nullable_1)
	{
		if (nullable_0 == null)
		{
			return nullable_1;
		}
		if (nullable_1 == null)
		{
			return nullable_0;
		}
		return new int?(Math.Max(nullable_0.GetValueOrDefault(), nullable_1.GetValueOrDefault()));
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x0000794A File Offset: 0x00005B4A
	public static double? smethod_4(double? nullable_0, double? nullable_1)
	{
		if (nullable_0 == null)
		{
			return nullable_1;
		}
		if (nullable_1 == null)
		{
			return nullable_0;
		}
		return new double?(Math.Max(nullable_0.GetValueOrDefault(), nullable_1.GetValueOrDefault()));
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x0002DDEC File Offset: 0x0002BFEC
	public static bool smethod_5(double double_0, double double_1)
	{
		if (double_0 == double_1)
		{
			return true;
		}
		double num = (Math.Abs(double_0) + Math.Abs(double_1) + 10.0) * 2.2204460492503131E-16;
		double num2 = double_0 - double_1;
		return -num < num2 && num > num2;
	}
}
