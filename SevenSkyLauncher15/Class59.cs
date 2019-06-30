using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json.Serialization;

// Token: 0x020000D3 RID: 211
internal static class Class59
{
	// Token: 0x060006A8 RID: 1704 RVA: 0x0000741F File Offset: 0x0000561F
	[CompilerGenerated]
	public static Assembly smethod_0()
	{
		return Class59.assembly_0;
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00007426 File Offset: 0x00005626
	[CompilerGenerated]
	private static void smethod_1(Assembly assembly_1)
	{
		Class59.assembly_0 = assembly_1;
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060006AA RID: 1706 RVA: 0x0000742E File Offset: 0x0000562E
	// (set) Token: 0x060006AB RID: 1707 RVA: 0x00007435 File Offset: 0x00005635
	public static Delegate1<object, object> IsUnion { get; private set; }

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x060006AC RID: 1708 RVA: 0x0000743D File Offset: 0x0000563D
	// (set) Token: 0x060006AD RID: 1709 RVA: 0x00007444 File Offset: 0x00005644
	public static Delegate1<object, object> GetUnionCases { get; private set; }

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060006AE RID: 1710 RVA: 0x0000744C File Offset: 0x0000564C
	// (set) Token: 0x060006AF RID: 1711 RVA: 0x00007453 File Offset: 0x00005653
	public static Delegate1<object, object> PreComputeUnionTagReader { get; private set; }

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0000745B File Offset: 0x0000565B
	// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00007462 File Offset: 0x00005662
	public static Delegate1<object, object> PreComputeUnionReader { get; private set; }

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0000746A File Offset: 0x0000566A
	// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00007471 File Offset: 0x00005671
	public static Delegate1<object, object> PreComputeUnionConstructor { get; private set; }

	// Token: 0x060006B4 RID: 1716 RVA: 0x00007479 File Offset: 0x00005679
	[CompilerGenerated]
	public static Func<object, object> smethod_2()
	{
		return Class59.LfqxpisDeF;
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00007480 File Offset: 0x00005680
	[CompilerGenerated]
	private static void smethod_3(Func<object, object> func_2)
	{
		Class59.LfqxpisDeF = func_2;
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00007488 File Offset: 0x00005688
	[CompilerGenerated]
	public static Func<object, object> smethod_4()
	{
		return Class59.func_0;
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x0000748F File Offset: 0x0000568F
	[CompilerGenerated]
	private static void smethod_5(Func<object, object> func_2)
	{
		Class59.func_0 = func_2;
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00007497 File Offset: 0x00005697
	[CompilerGenerated]
	public static Func<object, object> smethod_6()
	{
		return Class59.func_1;
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x0000749E File Offset: 0x0000569E
	[CompilerGenerated]
	private static void smethod_7(Func<object, object> func_2)
	{
		Class59.func_1 = func_2;
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x000074A6 File Offset: 0x000056A6
	[CompilerGenerated]
	public static Delegate1<object, object> aYkxWbndk9()
	{
		return Class59.delegate1_5;
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x000074AD File Offset: 0x000056AD
	[CompilerGenerated]
	private static void smethod_8(Delegate1<object, object> delegate1_6)
	{
		Class59.delegate1_5 = delegate1_6;
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x0002C2A8 File Offset: 0x0002A4A8
	public static void smethod_9(Assembly assembly_1)
	{
		if (!Class59.bool_0)
		{
			object obj = Class59.object_0;
			lock (obj)
			{
				if (!Class59.bool_0)
				{
					Class59.smethod_1(assembly_1);
					Type type = assembly_1.GetType("Microsoft.FSharp.Reflection.FSharpType");
					MethodInfo methodBase_ = Class59.smethod_10(type, "IsUnion", BindingFlags.Static | BindingFlags.Public);
					Class59.IsUnion = Class124.smethod_19().vmethod_0<object>(methodBase_);
					MethodInfo methodBase_2 = Class59.smethod_10(type, "GetUnionCases", BindingFlags.Static | BindingFlags.Public);
					Class59.GetUnionCases = Class124.smethod_19().vmethod_0<object>(methodBase_2);
					Type type2 = assembly_1.GetType("Microsoft.FSharp.Reflection.FSharpValue");
					Class59.PreComputeUnionTagReader = Class59.smethod_11(type2, "PreComputeUnionTagReader");
					Class59.PreComputeUnionReader = Class59.smethod_11(type2, "PreComputeUnionReader");
					Class59.PreComputeUnionConstructor = Class59.smethod_11(type2, "PreComputeUnionConstructor");
					Type type3 = assembly_1.GetType("Microsoft.FSharp.Reflection.UnionCaseInfo");
					Class59.smethod_5(Class124.smethod_19().vmethod_3<object>(type3.GetProperty("Name")));
					Class59.smethod_7(Class124.smethod_19().vmethod_3<object>(type3.GetProperty("Tag")));
					Class59.smethod_3(Class124.smethod_19().vmethod_3<object>(type3.GetProperty("DeclaringType")));
					Class59.smethod_8(Class124.smethod_19().vmethod_0<object>(type3.GetMethod("GetFields")));
					Class59.methodInfo_0 = assembly_1.GetType("Microsoft.FSharp.Collections.ListModule").GetMethod("OfSeq");
					Class59.kXkxeOrhTr = assembly_1.GetType("Microsoft.FSharp.Collections.FSharpMap`2");
					Thread.MemoryBarrier();
					Class59.bool_0 = true;
				}
			}
		}
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x0002C438 File Offset: 0x0002A638
	private static MethodInfo smethod_10(Type type_0, string string_0, BindingFlags bindingFlags_0)
	{
		MethodInfo method = type_0.GetMethod(string_0, bindingFlags_0);
		if (method == null && (bindingFlags_0 & BindingFlags.NonPublic) != BindingFlags.NonPublic)
		{
			method = type_0.GetMethod(string_0, bindingFlags_0 | BindingFlags.NonPublic);
		}
		return method;
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x0002C46C File Offset: 0x0002A66C
	private static Delegate1<object, object> smethod_11(Type type_0, string string_0)
	{
		Class59.Class60 @class = new Class59.Class60();
		MethodInfo methodInfo = Class59.smethod_10(type_0, string_0, BindingFlags.Static | BindingFlags.Public);
		MethodInfo method = methodInfo.ReturnType.GetMethod("Invoke", BindingFlags.Instance | BindingFlags.Public);
		@class.delegate1_0 = Class124.smethod_19().vmethod_0<object>(methodInfo);
		@class.delegate1_1 = Class124.smethod_19().vmethod_0<object>(method);
		return new Delegate1<object, object>(@class.method_0);
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x0002C4C8 File Offset: 0x0002A6C8
	public static ObjectConstructor<object> smethod_12(Type type_0)
	{
		MethodInfo methodBase_ = Class59.methodInfo_0.MakeGenericMethod(new Type[]
		{
			type_0
		});
		return Class124.smethod_19().vmethod_1(methodBase_);
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x000074B5 File Offset: 0x000056B5
	public static ObjectConstructor<object> smethod_13(Type type_0, Type type_1)
	{
		return (ObjectConstructor<object>)typeof(Class59).GetMethod("BuildMapCreator").MakeGenericMethod(new Type[]
		{
			type_0,
			type_1
		}).Invoke(null, null);
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
	public static ObjectConstructor<object> BuildMapCreator<TKey, TValue>()
	{
		Class59.Class61<TKey, TValue> @class = new Class59.Class61<TKey, TValue>();
		ConstructorInfo constructor = Class59.kXkxeOrhTr.MakeGenericType(new Type[]
		{
			typeof(TKey),
			typeof(TValue)
		}).GetConstructor(new Type[]
		{
			typeof(IEnumerable<Tuple<TKey, TValue>>)
		});
		@class.objectConstructor_0 = Class124.smethod_19().vmethod_1(constructor);
		return new ObjectConstructor<object>(@class.method_0);
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x000074EB File Offset: 0x000056EB
	// Note: this type is marked as 'beforefieldinit'.
	static Class59()
	{
		Class202.ofdixO4zTbIfy();
		Class59.object_0 = new object();
	}

	// Token: 0x04000432 RID: 1074
	private static readonly object object_0;

	// Token: 0x04000433 RID: 1075
	private static bool bool_0;

	// Token: 0x04000434 RID: 1076
	private static MethodInfo methodInfo_0;

	// Token: 0x04000435 RID: 1077
	private static Type kXkxeOrhTr;

	// Token: 0x04000436 RID: 1078
	[CompilerGenerated]
	private static Assembly assembly_0;

	// Token: 0x04000437 RID: 1079
	[CompilerGenerated]
	private static Delegate1<object, object> delegate1_0;

	// Token: 0x04000438 RID: 1080
	[CompilerGenerated]
	private static Delegate1<object, object> delegate1_1;

	// Token: 0x04000439 RID: 1081
	[CompilerGenerated]
	private static Delegate1<object, object> delegate1_2;

	// Token: 0x0400043A RID: 1082
	[CompilerGenerated]
	private static Delegate1<object, object> delegate1_3;

	// Token: 0x0400043B RID: 1083
	[CompilerGenerated]
	private static Delegate1<object, object> delegate1_4;

	// Token: 0x0400043C RID: 1084
	[CompilerGenerated]
	private static Func<object, object> LfqxpisDeF;

	// Token: 0x0400043D RID: 1085
	[CompilerGenerated]
	private static Func<object, object> func_0;

	// Token: 0x0400043E RID: 1086
	[CompilerGenerated]
	private static Func<object, object> func_1;

	// Token: 0x0400043F RID: 1087
	[CompilerGenerated]
	private static Delegate1<object, object> delegate1_5;

	// Token: 0x020000D4 RID: 212
	[CompilerGenerated]
	private sealed class Class60
	{
		// Token: 0x060006C3 RID: 1731 RVA: 0x00002621 File Offset: 0x00000821
		public Class60()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000074FC File Offset: 0x000056FC
		internal object method_0(object object_0, object[] object_1)
		{
			return new Class58(this.delegate1_0(object_0, object_1), this.delegate1_1);
		}

		// Token: 0x04000440 RID: 1088
		public Delegate1<object, object> delegate1_0;

		// Token: 0x04000441 RID: 1089
		public Delegate1<object, object> delegate1_1;
	}

	// Token: 0x020000D5 RID: 213
	[CompilerGenerated]
	private sealed class Class61<l9T1VSsFm6U8CmLvX0X, sLTPs0snkwoappkZnFn>
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x00002621 File Offset: 0x00000821
		public Class61()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0002C56C File Offset: 0x0002A76C
		internal object method_0(object[] object_0)
		{
			IEnumerable<Tuple<l9T1VSsFm6U8CmLvX0X, sLTPs0snkwoappkZnFn>> enumerable = ((IEnumerable<KeyValuePair<l9T1VSsFm6U8CmLvX0X, sLTPs0snkwoappkZnFn>>)object_0[0]).Select(new Func<KeyValuePair<l9T1VSsFm6U8CmLvX0X, sLTPs0snkwoappkZnFn>, Tuple<l9T1VSsFm6U8CmLvX0X, sLTPs0snkwoappkZnFn>>(Class59.Class62<l9T1VSsFm6U8CmLvX0X, sLTPs0snkwoappkZnFn>.class62_0.hVkYeqybBa));
			return this.objectConstructor_0(new object[]
			{
				enumerable
			});
		}

		// Token: 0x04000442 RID: 1090
		public ObjectConstructor<object> objectConstructor_0;
	}

	// Token: 0x020000D6 RID: 214
	[CompilerGenerated]
	[Serializable]
	private sealed class Class62<KQgci2sN7jcJ2GXL3Sv, BKYKHqsPai9Cnyqybhq>
	{
		// Token: 0x060006C7 RID: 1735 RVA: 0x00007516 File Offset: 0x00005716
		// Note: this type is marked as 'beforefieldinit'.
		static Class62()
		{
			Class202.ofdixO4zTbIfy();
			Class59.Class62<KQgci2sN7jcJ2GXL3Sv, BKYKHqsPai9Cnyqybhq>.class62_0 = new Class59.Class62<KQgci2sN7jcJ2GXL3Sv, BKYKHqsPai9Cnyqybhq>();
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00002621 File Offset: 0x00000821
		public Class62()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00007527 File Offset: 0x00005727
		internal Tuple<KQgci2sN7jcJ2GXL3Sv, BKYKHqsPai9Cnyqybhq> hVkYeqybBa(KeyValuePair<KQgci2sN7jcJ2GXL3Sv, BKYKHqsPai9Cnyqybhq> keyValuePair_0)
		{
			return new Tuple<KQgci2sN7jcJ2GXL3Sv, BKYKHqsPai9Cnyqybhq>(keyValuePair_0.Key, keyValuePair_0.Value);
		}

		// Token: 0x04000443 RID: 1091
		public static readonly Class59.Class62<KQgci2sN7jcJ2GXL3Sv, BKYKHqsPai9Cnyqybhq> class62_0;

		// Token: 0x04000444 RID: 1092
		public static Func<KeyValuePair<KQgci2sN7jcJ2GXL3Sv, BKYKHqsPai9Cnyqybhq>, Tuple<KQgci2sN7jcJ2GXL3Sv, BKYKHqsPai9Cnyqybhq>> func_0;
	}
}
