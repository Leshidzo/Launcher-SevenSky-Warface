using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x02000103 RID: 259
internal static class Class100
{
	// Token: 0x060007B8 RID: 1976 RVA: 0x00007F71 File Offset: 0x00006171
	public static MethodInfo smethod_0(this Delegate delegate_0)
	{
		return delegate_0.Method;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00007F79 File Offset: 0x00006179
	public static MemberTypes smethod_1(this MemberInfo memberInfo_0)
	{
		return memberInfo_0.MemberType;
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00007F81 File Offset: 0x00006181
	public static bool smethod_2(this Type type_0)
	{
		return type_0.ContainsGenericParameters;
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00007F89 File Offset: 0x00006189
	public static bool smethod_3(this Type type_0)
	{
		return type_0.IsInterface;
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00007F91 File Offset: 0x00006191
	public static bool smethod_4(this Type type_0)
	{
		return type_0.IsGenericType;
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00007F99 File Offset: 0x00006199
	public static bool smethod_5(this Type type_0)
	{
		return type_0.IsGenericTypeDefinition;
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00007FA1 File Offset: 0x000061A1
	public static Type smethod_6(this Type type_0)
	{
		return type_0.BaseType;
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00007FA9 File Offset: 0x000061A9
	public static Assembly smethod_7(this Type type_0)
	{
		return type_0.Assembly;
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00007FB1 File Offset: 0x000061B1
	public static bool smethod_8(this Type type_0)
	{
		return type_0.IsEnum;
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00007FB9 File Offset: 0x000061B9
	public static bool smethod_9(this Type type_0)
	{
		return type_0.IsClass;
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00007FC1 File Offset: 0x000061C1
	public static bool smethod_10(this Type type_0)
	{
		return type_0.IsSealed;
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00007FC9 File Offset: 0x000061C9
	public static bool smethod_11(this Type type_0)
	{
		return type_0.IsAbstract;
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00007FD1 File Offset: 0x000061D1
	public static bool smethod_12(this Type type_0)
	{
		return type_0.IsVisible;
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00007FD9 File Offset: 0x000061D9
	public static bool smethod_13(this Type type_0)
	{
		return type_0.IsValueType;
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x00007FE1 File Offset: 0x000061E1
	public static bool smethod_14(this Type type_0)
	{
		return type_0.IsPrimitive;
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x0002F870 File Offset: 0x0002DA70
	public static bool smethod_15(this Type type_0, string string_0, bool bool_0, out Type type_1)
	{
		Type type = type_0;
		while (type != null)
		{
			if (string.Equals(type.FullName, string_0, StringComparison.Ordinal))
			{
				type_1 = type;
				return true;
			}
			type = type.BaseType;
		}
		if (bool_0)
		{
			Type[] interfaces = type_0.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				if (string.Equals(interfaces[i].Name, string_0, StringComparison.Ordinal))
				{
					type_1 = type_0;
					return true;
				}
			}
		}
		type_1 = null;
		return false;
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
	public static bool smethod_16(this Type type_0, string string_0, bool bool_0)
	{
		Type type;
		return type_0.smethod_15(string_0, bool_0, out type);
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x0002F8F8 File Offset: 0x0002DAF8
	public static bool smethod_17(this Type type_0, Type type_1)
	{
		Type type = type_0;
		while (type != null)
		{
			foreach (Type type2 in ((IEnumerable<Type>)type.GetInterfaces()))
			{
				if (type2 == type_1 || (type2 != null && type2.smethod_17(type_1)))
				{
					return true;
				}
			}
			type = type.BaseType;
		}
		return false;
	}
}
