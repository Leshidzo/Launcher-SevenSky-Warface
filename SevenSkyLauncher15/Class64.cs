using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

// Token: 0x020000D8 RID: 216
internal static class Class64
{
	// Token: 0x060006D0 RID: 1744 RVA: 0x0002C5BC File Offset: 0x0002A7BC
	internal static bool smethod_0(Type type_0, Type type_1, out Type type_2, out ObjectConstructor<object> objectConstructor_0)
	{
		if (type_0.smethod_4())
		{
			Class64.Class66 @class = new Class64.Class66();
			Type genericTypeDefinition = type_0.GetGenericTypeDefinition();
			@class.string_0 = genericTypeDefinition.FullName;
			Class64.Class65 class2 = Class64.ilist_0.FirstOrDefault(new Func<Class64.Class65, bool>(@class.method_0));
			if (class2 != null)
			{
				Type type = genericTypeDefinition.smethod_7().GetType(class2.method_2());
				Type type2 = genericTypeDefinition.smethod_7().GetType(class2.method_4());
				if (type != null && type2 != null)
				{
					MethodInfo methodInfo = type2.GetMethods().FirstOrDefault(new Func<MethodInfo, bool>(Class64.Class67.class67_0.method_0));
					if (methodInfo != null)
					{
						type_2 = type.MakeGenericType(new Type[]
						{
							type_1
						});
						MethodInfo methodBase_ = methodInfo.MakeGenericMethod(new Type[]
						{
							type_1
						});
						objectConstructor_0 = Class124.smethod_19().vmethod_1(methodBase_);
						return true;
					}
				}
			}
		}
		type_2 = null;
		objectConstructor_0 = null;
		return false;
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x0002C6B8 File Offset: 0x0002A8B8
	internal static bool smethod_1(Type type_0, Type type_1, Type type_2, out Type type_3, out ObjectConstructor<object> objectConstructor_0)
	{
		if (type_0.smethod_4())
		{
			Class64.Class68 @class = new Class64.Class68();
			Type genericTypeDefinition = type_0.GetGenericTypeDefinition();
			@class.string_0 = genericTypeDefinition.FullName;
			Class64.Class65 class2 = Class64.ilist_1.FirstOrDefault(new Func<Class64.Class65, bool>(@class.method_0));
			if (class2 != null)
			{
				Type type = genericTypeDefinition.smethod_7().GetType(class2.method_2());
				Type type2 = genericTypeDefinition.smethod_7().GetType(class2.method_4());
				if (type != null && type2 != null)
				{
					MethodInfo methodInfo = type2.GetMethods().FirstOrDefault(new Func<MethodInfo, bool>(Class64.Class67.class67_0.method_1));
					if (methodInfo != null)
					{
						type_3 = type.MakeGenericType(new Type[]
						{
							type_1,
							type_2
						});
						MethodInfo methodBase_ = methodInfo.MakeGenericMethod(new Type[]
						{
							type_1,
							type_2
						});
						objectConstructor_0 = Class124.smethod_19().vmethod_1(methodBase_);
						return true;
					}
				}
			}
		}
		type_3 = null;
		objectConstructor_0 = null;
		return false;
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x0002C7BC File Offset: 0x0002A9BC
	// Note: this type is marked as 'beforefieldinit'.
	static Class64()
	{
		Class202.ofdixO4zTbIfy();
		Class64.ilist_0 = new List<Class64.Class65>
		{
			new Class64.Class65("System.Collections.Immutable.IImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
			new Class64.Class65("System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
			new Class64.Class65("System.Collections.Immutable.IImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
			new Class64.Class65("System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
			new Class64.Class65("System.Collections.Immutable.IImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
			new Class64.Class65("System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
			new Class64.Class65("System.Collections.Immutable.IImmutableSet`1", "System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet"),
			new Class64.Class65("System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet"),
			new Class64.Class65("System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet"),
			new Class64.Class65("System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray")
		};
		Class64.ilist_1 = new List<Class64.Class65>
		{
			new Class64.Class65("System.Collections.Immutable.IImmutableDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary"),
			new Class64.Class65("System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary"),
			new Class64.Class65("System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary")
		};
	}

	// Token: 0x04000445 RID: 1093
	private static readonly IList<Class64.Class65> ilist_0;

	// Token: 0x04000446 RID: 1094
	private static readonly IList<Class64.Class65> ilist_1;

	// Token: 0x020000D9 RID: 217
	internal class Class65
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x0000760D File Offset: 0x0000580D
		public Class65(string string_3, string string_4, string string_5)
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
			this.method_1(string_3);
			this.method_3(string_4);
			this.method_5(string_5);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000762F File Offset: 0x0000582F
		[CompilerGenerated]
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00007637 File Offset: 0x00005837
		[CompilerGenerated]
		public void method_1(string string_3)
		{
			this.string_0 = string_3;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00007640 File Offset: 0x00005840
		[CompilerGenerated]
		public string method_2()
		{
			return this.string_1;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00007648 File Offset: 0x00005848
		[CompilerGenerated]
		public void method_3(string string_3)
		{
			this.string_1 = string_3;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00007651 File Offset: 0x00005851
		[CompilerGenerated]
		public string method_4()
		{
			return this.string_2;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00007659 File Offset: 0x00005859
		[CompilerGenerated]
		public void method_5(string string_3)
		{
			this.string_2 = string_3;
		}

		// Token: 0x04000447 RID: 1095
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000448 RID: 1096
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000449 RID: 1097
		[CompilerGenerated]
		private string string_2;
	}

	// Token: 0x020000DA RID: 218
	[CompilerGenerated]
	private sealed class Class66
	{
		// Token: 0x060006DA RID: 1754 RVA: 0x00002621 File Offset: 0x00000821
		public Class66()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00007662 File Offset: 0x00005862
		internal bool method_0(Class64.Class65 class65_0)
		{
			return class65_0.method_0() == this.string_0;
		}

		// Token: 0x0400044A RID: 1098
		public string string_0;
	}

	// Token: 0x020000DB RID: 219
	[CompilerGenerated]
	[Serializable]
	private sealed class Class67
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x00007675 File Offset: 0x00005875
		// Note: this type is marked as 'beforefieldinit'.
		static Class67()
		{
			Class202.ofdixO4zTbIfy();
			Class64.Class67.class67_0 = new Class64.Class67();
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00002621 File Offset: 0x00000821
		public Class67()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00007686 File Offset: 0x00005886
		internal bool method_0(MethodInfo methodInfo_0)
		{
			return methodInfo_0.Name == "CreateRange" && methodInfo_0.GetParameters().Length == 1;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0002C934 File Offset: 0x0002AB34
		internal bool method_1(MethodInfo methodInfo_0)
		{
			ParameterInfo[] parameters = methodInfo_0.GetParameters();
			return methodInfo_0.Name == "CreateRange" && parameters.Length == 1 && parameters[0].ParameterType.smethod_4() && parameters[0].ParameterType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
		}

		// Token: 0x0400044B RID: 1099
		public static readonly Class64.Class67 class67_0;

		// Token: 0x0400044C RID: 1100
		public static Func<MethodInfo, bool> func_0;

		// Token: 0x0400044D RID: 1101
		public static Func<MethodInfo, bool> funfsJnfcf;
	}

	// Token: 0x020000DC RID: 220
	[CompilerGenerated]
	private sealed class Class68
	{
		// Token: 0x060006E0 RID: 1760 RVA: 0x00002621 File Offset: 0x00000821
		public Class68()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000076A7 File Offset: 0x000058A7
		internal bool method_0(Class64.Class65 class65_0)
		{
			return class65_0.method_0() == this.string_0;
		}

		// Token: 0x0400044E RID: 1102
		public string string_0;
	}
}
