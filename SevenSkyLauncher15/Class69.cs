using System;
using Newtonsoft.Json;

// Token: 0x020000DD RID: 221
internal static class Class69
{
	// Token: 0x060006E2 RID: 1762 RVA: 0x000076BA File Offset: 0x000058BA
	public static char[] smethod_0(IArrayPool<char> iarrayPool_0, int int_0)
	{
		if (iarrayPool_0 == null)
		{
			return new char[int_0];
		}
		return iarrayPool_0.Rent(int_0);
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x000076CD File Offset: 0x000058CD
	public static void smethod_1(IArrayPool<char> iarrayPool_0, object object_0)
	{
		if (iarrayPool_0 != null)
		{
			iarrayPool_0.Return(object_0);
		}
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x000076D9 File Offset: 0x000058D9
	public static char[] smethod_2(IArrayPool<char> iarrayPool_0, int int_0, object object_0)
	{
		if (iarrayPool_0 == null)
		{
			return new char[int_0];
		}
		if (object_0 != null)
		{
			iarrayPool_0.Return(object_0);
		}
		return iarrayPool_0.Rent(int_0);
	}
}
