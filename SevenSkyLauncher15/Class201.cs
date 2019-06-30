using System;
using System.Reflection;

// Token: 0x020001FF RID: 511
internal class Class201
{
	// Token: 0x060010EA RID: 4330 RVA: 0x0004BA9C File Offset: 0x00049C9C
	internal static void S2tixO44nFTA3(int typemdt)
	{
		Type type = Class201.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class201.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00002621 File Offset: 0x00000821
	public Class201()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x0000E38C File Offset: 0x0000C58C
	// Note: this type is marked as 'beforefieldinit'.
	static Class201()
	{
		Class202.ofdixO4zTbIfy();
		Class201.module_0 = typeof(Class201).Assembly.ManifestModule;
	}

	// Token: 0x040007DC RID: 2012
	internal static Module module_0;

	// Token: 0x02000200 RID: 512
	// (Invoke) Token: 0x060010EE RID: 4334
	internal delegate void Delegate3(object o);
}
