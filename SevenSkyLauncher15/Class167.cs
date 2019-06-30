using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001AC RID: 428
internal abstract class Class167
{
	// Token: 0x06000EDD RID: 3805 RVA: 0x0000CC62 File Offset: 0x0000AE62
	[CompilerGenerated]
	public Enum10 method_0()
	{
		return this.enum10_0;
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x0000CC6A File Offset: 0x0000AE6A
	[CompilerGenerated]
	public void method_1(Enum10 enum10_1)
	{
		this.enum10_0 = enum10_1;
	}

	// Token: 0x06000EDF RID: 3807
	public abstract bool vmethod_0(JToken jtoken_0, JToken jtoken_1);

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00002621 File Offset: 0x00000821
	protected Class167()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x0400073E RID: 1854
	[CompilerGenerated]
	private Enum10 enum10_0;
}
