using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x020000C6 RID: 198
internal static class Class47
{
	// Token: 0x06000677 RID: 1655 RVA: 0x00007204 File Offset: 0x00005404
	public static IEnumerable<string> smethod_0(this IDynamicMetaObjectProvider idynamicMetaObjectProvider_0)
	{
		return idynamicMetaObjectProvider_0.GetMetaObject(Expression.Constant(idynamicMetaObjectProvider_0)).GetDynamicMemberNames();
	}

	// Token: 0x020000C7 RID: 199
	internal static class Class48
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x0002B25C File Offset: 0x0002945C
		private static void smethod_0()
		{
			if (!Class47.Class48.bool_0)
			{
				if (Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", false) == null)
				{
					throw new InvalidOperationException("Could not resolve type '{0}'. You may need to add a reference to Microsoft.CSharp.dll to work with dynamic types.".smethod_0(CultureInfo.InvariantCulture, "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
				}
				Class47.Class48.object_0 = Class47.Class48.smethod_1(new int[1]);
				Class47.Class48.object_1 = Class47.Class48.smethod_1(new int[]
				{
					0,
					3
				});
				Class47.Class48.smethod_2();
				Class47.Class48.bool_0 = true;
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0002B2CC File Offset: 0x000294CC
		private static object smethod_1(params int[] values)
		{
			Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
			Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
			Array array = Array.CreateInstance(type, values.Length);
			for (int i = 0; i < values.Length; i++)
			{
				MethodBase method = type.GetMethod("Create", new Type[]
				{
					type2,
					typeof(string)
				});
				object obj = null;
				object[] array2 = new object[2];
				array2[0] = 0;
				object value = method.Invoke(obj, array2);
				array.SetValue(value, i);
			}
			return array;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0002B34C File Offset: 0x0002954C
		private static void smethod_2()
		{
			Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
			Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
			Type type3 = Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
			Type type4 = typeof(IEnumerable<>).MakeGenericType(new Type[]
			{
				type
			});
			MethodInfo method = type3.GetMethod("GetMember", new Type[]
			{
				type2,
				typeof(string),
				typeof(Type),
				type4
			});
			Class47.Class48.delegate1_0 = Class124.smethod_19().vmethod_0<object>(method);
			MethodInfo method2 = type3.GetMethod("SetMember", new Type[]
			{
				type2,
				typeof(string),
				typeof(Type),
				type4
			});
			Class47.Class48.delegate1_1 = Class124.smethod_19().vmethod_0<object>(method2);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00007217 File Offset: 0x00005417
		public static CallSiteBinder GetMember(object name, Type context)
		{
			Class47.Class48.smethod_0();
			return (CallSiteBinder)Class47.Class48.delegate1_0(null, new object[]
			{
				0,
				name,
				context,
				Class47.Class48.object_0
			});
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0000724D File Offset: 0x0000544D
		public static CallSiteBinder SetMember(object name, Type context)
		{
			Class47.Class48.smethod_0();
			return (CallSiteBinder)Class47.Class48.delegate1_1(null, new object[]
			{
				0,
				name,
				context,
				Class47.Class48.object_1
			});
		}

		// Token: 0x04000419 RID: 1049
		private static object object_0;

		// Token: 0x0400041A RID: 1050
		private static object object_1;

		// Token: 0x0400041B RID: 1051
		private static Delegate1<object, object> delegate1_0;

		// Token: 0x0400041C RID: 1052
		private static Delegate1<object, object> delegate1_1;

		// Token: 0x0400041D RID: 1053
		private static bool bool_0;
	}
}
