using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

// Token: 0x020000E3 RID: 227
internal class Class84 : Class81
{
	// Token: 0x060006FC RID: 1788 RVA: 0x00007765 File Offset: 0x00005965
	internal static Class81 smethod_0()
	{
		return Class84.class84_0;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x0002DBA8 File Offset: 0x0002BDA8
	public override ObjectConstructor<object> vmethod_1(MethodBase methodBase_0)
	{
		Class84.Class72 @class = new Class84.Class72();
		@class.methodBase_0 = methodBase_0;
		Class101.smethod_0(@class.methodBase_0, "method");
		if ((@class.constructorInfo_0 = (@class.methodBase_0 as ConstructorInfo)) != null)
		{
			return new ObjectConstructor<object>(@class.method_0);
		}
		return new ObjectConstructor<object>(@class.method_1);
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x0002DC04 File Offset: 0x0002BE04
	public override Delegate1<aal5FsEvY51e5Z8hFDG, object> vmethod_0<aal5FsEvY51e5Z8hFDG>(MethodBase methodBase_0)
	{
		Class84.Class73<aal5FsEvY51e5Z8hFDG> @class = new Class84.Class73<aal5FsEvY51e5Z8hFDG>();
		@class.methodBase_0 = methodBase_0;
		Class101.smethod_0(@class.methodBase_0, "method");
		if ((@class.constructorInfo_0 = (@class.methodBase_0 as ConstructorInfo)) != null)
		{
			return new Delegate1<aal5FsEvY51e5Z8hFDG, object>(@class.method_0);
		}
		return new Delegate1<aal5FsEvY51e5Z8hFDG, object>(@class.method_1);
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x0002DC60 File Offset: 0x0002BE60
	public override Func<cjfSSDEck1ocJ1eOpeB> vmethod_2<cjfSSDEck1ocJ1eOpeB>(Type type_0)
	{
		Class84.Class74<cjfSSDEck1ocJ1eOpeB> @class = new Class84.Class74<cjfSSDEck1ocJ1eOpeB>();
		@class.type_0 = type_0;
		Class101.smethod_0(@class.type_0, "type");
		if (@class.type_0.smethod_13())
		{
			return new Func<cjfSSDEck1ocJ1eOpeB>(@class.method_0);
		}
		@class.constructorInfo_0 = Class90.smethod_9(@class.type_0, true);
		return new Func<cjfSSDEck1ocJ1eOpeB>(@class.method_1);
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x0000776C File Offset: 0x0000596C
	public override Func<sepkp5EAYgFiZnf4lXa, object> vmethod_3<sepkp5EAYgFiZnf4lXa>(PropertyInfo propertyInfo_0)
	{
		Class84.Class75<sepkp5EAYgFiZnf4lXa> @class = new Class84.Class75<sepkp5EAYgFiZnf4lXa>();
		@class.propertyInfo_0 = propertyInfo_0;
		Class101.smethod_0(@class.propertyInfo_0, "propertyInfo");
		return new Func<sepkp5EAYgFiZnf4lXa, object>(@class.method_0);
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00007795 File Offset: 0x00005995
	public override Func<Ph3KSaE7MknVxoi2All, object> vmethod_4<Ph3KSaE7MknVxoi2All>(FieldInfo fieldInfo_0)
	{
		Class84.Class76<Ph3KSaE7MknVxoi2All> @class = new Class84.Class76<Ph3KSaE7MknVxoi2All>();
		@class.fieldInfo_0 = fieldInfo_0;
		Class101.smethod_0(@class.fieldInfo_0, "fieldInfo");
		return new Func<Ph3KSaE7MknVxoi2All, object>(@class.method_0);
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000077BE File Offset: 0x000059BE
	public override Action<DuVmkMErTD7nV2AYDlJ, object> vmethod_5<DuVmkMErTD7nV2AYDlJ>(FieldInfo fieldInfo_0)
	{
		Class84.Class77<DuVmkMErTD7nV2AYDlJ> @class = new Class84.Class77<DuVmkMErTD7nV2AYDlJ>();
		@class.fieldInfo_0 = fieldInfo_0;
		Class101.smethod_0(@class.fieldInfo_0, "fieldInfo");
		return new Action<DuVmkMErTD7nV2AYDlJ, object>(@class.method_0);
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x000077E7 File Offset: 0x000059E7
	public override Action<LKkAU4Ef5VxoWvkmU3e, object> vmethod_6<LKkAU4Ef5VxoWvkmU3e>(PropertyInfo propertyInfo_0)
	{
		Class84.Class78<LKkAU4Ef5VxoWvkmU3e> @class = new Class84.Class78<LKkAU4Ef5VxoWvkmU3e>();
		@class.propertyInfo_0 = propertyInfo_0;
		Class101.smethod_0(@class.propertyInfo_0, "propertyInfo");
		return new Action<LKkAU4Ef5VxoWvkmU3e, object>(@class.method_0);
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x000071DE File Offset: 0x000053DE
	public Class84()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00007810 File Offset: 0x00005A10
	// Note: this type is marked as 'beforefieldinit'.
	static Class84()
	{
		Class202.ofdixO4zTbIfy();
		Class84.class84_0 = new Class84();
	}

	// Token: 0x04000473 RID: 1139
	private static readonly Class84 class84_0;

	// Token: 0x020000E4 RID: 228
	[CompilerGenerated]
	private sealed class Class72
	{
		// Token: 0x06000706 RID: 1798 RVA: 0x00002621 File Offset: 0x00000821
		public Class72()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00007821 File Offset: 0x00005A21
		internal object method_0(object[] object_0)
		{
			return this.constructorInfo_0.Invoke(object_0);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0000782F File Offset: 0x00005A2F
		internal object method_1(object[] object_0)
		{
			return this.methodBase_0.Invoke(null, object_0);
		}

		// Token: 0x04000474 RID: 1140
		public ConstructorInfo constructorInfo_0;

		// Token: 0x04000475 RID: 1141
		public MethodBase methodBase_0;
	}

	// Token: 0x020000E5 RID: 229
	[CompilerGenerated]
	private sealed class Class73<r9PuobsOJUGkyrY9pql>
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x00002621 File Offset: 0x00000821
		public Class73()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0000783E File Offset: 0x00005A3E
		internal object method_0(r9PuobsOJUGkyrY9pql qBkGwJsouZN4FEaC19G, object[] object_0)
		{
			return this.constructorInfo_0.Invoke(object_0);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0000784C File Offset: 0x00005A4C
		internal object method_1(r9PuobsOJUGkyrY9pql k5IEgesHWSmrOZ6Hut2, object[] object_0)
		{
			return this.methodBase_0.Invoke(k5IEgesHWSmrOZ6Hut2, object_0);
		}

		// Token: 0x04000476 RID: 1142
		public ConstructorInfo constructorInfo_0;

		// Token: 0x04000477 RID: 1143
		public MethodBase methodBase_0;
	}

	// Token: 0x020000E6 RID: 230
	[CompilerGenerated]
	private sealed class Class74<XSCOG3s3heq0lgvU6IF>
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x00002621 File Offset: 0x00000821
		public Class74()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00007860 File Offset: 0x00005A60
		internal XSCOG3s3heq0lgvU6IF method_0()
		{
			return (XSCOG3s3heq0lgvU6IF)((object)Activator.CreateInstance(this.type_0));
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00007872 File Offset: 0x00005A72
		internal XSCOG3s3heq0lgvU6IF method_1()
		{
			return (XSCOG3s3heq0lgvU6IF)((object)this.constructorInfo_0.Invoke(null));
		}

		// Token: 0x04000478 RID: 1144
		public Type type_0;

		// Token: 0x04000479 RID: 1145
		public ConstructorInfo constructorInfo_0;
	}

	// Token: 0x020000E7 RID: 231
	[CompilerGenerated]
	private sealed class Class75<PXKcwOsTCYk4Fq64y8p>
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x00002621 File Offset: 0x00000821
		public Class75()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00007885 File Offset: 0x00005A85
		internal object method_0(PXKcwOsTCYk4Fq64y8p Ikq343sjWotNI1hKO18)
		{
			return this.propertyInfo_0.GetValue(Ikq343sjWotNI1hKO18, null);
		}

		// Token: 0x0400047A RID: 1146
		public PropertyInfo propertyInfo_0;
	}

	// Token: 0x020000E8 RID: 232
	[CompilerGenerated]
	private sealed class Class76<u19Gwps2Iu3PfRxrOd1>
	{
		// Token: 0x06000711 RID: 1809 RVA: 0x00002621 File Offset: 0x00000821
		public Class76()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00007899 File Offset: 0x00005A99
		internal object method_0(u19Gwps2Iu3PfRxrOd1 CIJD0cslPdhytWYXqSC)
		{
			return this.fieldInfo_0.GetValue(CIJD0cslPdhytWYXqSC);
		}

		// Token: 0x0400047B RID: 1147
		public FieldInfo fieldInfo_0;
	}

	// Token: 0x020000E9 RID: 233
	[CompilerGenerated]
	private sealed class Class77<Onox32sD1F4m7tXLuEr>
	{
		// Token: 0x06000713 RID: 1811 RVA: 0x00002621 File Offset: 0x00000821
		public Class77()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000078AC File Offset: 0x00005AAC
		internal void method_0(Onox32sD1F4m7tXLuEr qj6QbwszXyedMcifHyH, object object_0)
		{
			this.fieldInfo_0.SetValue(qj6QbwszXyedMcifHyH, object_0);
		}

		// Token: 0x0400047C RID: 1148
		public FieldInfo fieldInfo_0;
	}

	// Token: 0x020000EA RID: 234
	[CompilerGenerated]
	private sealed class Class78<dmUCmEXQqFNBtiMoPXZ>
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x00002621 File Offset: 0x00000821
		public Class78()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000078C0 File Offset: 0x00005AC0
		internal void method_0(dmUCmEXQqFNBtiMoPXZ kL1ZWtXE08VEf1wZPUZ, object object_0)
		{
			this.propertyInfo_0.SetValue(kL1ZWtXE08VEf1wZPUZ, object_0, null);
		}

		// Token: 0x0400047D RID: 1149
		public PropertyInfo propertyInfo_0;
	}
}
