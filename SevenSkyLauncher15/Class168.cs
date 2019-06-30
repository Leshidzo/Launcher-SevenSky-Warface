using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001AD RID: 429
internal class Class168 : Class167
{
	// Token: 0x06000EE1 RID: 3809 RVA: 0x0000CC73 File Offset: 0x0000AE73
	[CompilerGenerated]
	public List<Class167> method_2()
	{
		return this.list_0;
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x0000CC7B File Offset: 0x0000AE7B
	[CompilerGenerated]
	public void method_3(List<Class167> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x0000CC84 File Offset: 0x0000AE84
	public Class168()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.method_3(new List<Class167>());
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00045DAC File Offset: 0x00043FAC
	public override bool vmethod_0(JToken jtoken_0, JToken jtoken_1)
	{
		Enum10 @enum = base.method_0();
		if (@enum == (Enum10)8)
		{
			using (List<Class167>.Enumerator enumerator = this.method_2().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.vmethod_0(jtoken_0, jtoken_1))
					{
						return false;
					}
				}
			}
			return true;
		}
		if (@enum != (Enum10)9)
		{
			throw new ArgumentOutOfRangeException();
		}
		using (List<Class167>.Enumerator enumerator = this.method_2().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.vmethod_0(jtoken_0, jtoken_1))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0400073F RID: 1855
	[CompilerGenerated]
	private List<Class167> list_0;
}
