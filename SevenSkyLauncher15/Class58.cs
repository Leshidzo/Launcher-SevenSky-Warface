using System;

// Token: 0x020000D2 RID: 210
internal class Class58
{
	// Token: 0x060006A6 RID: 1702 RVA: 0x000073F0 File Offset: 0x000055F0
	public Class58(object object_1, Delegate1<object, object> delegate1_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.object_0 = object_1;
		this.delegate1_0 = delegate1_1;
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x0000740B File Offset: 0x0000560B
	public object Invoke(params object[] args)
	{
		return this.delegate1_0(this.object_0, args);
	}

	// Token: 0x04000430 RID: 1072
	private readonly object object_0;

	// Token: 0x04000431 RID: 1073
	private readonly Delegate1<object, object> delegate1_0;
}
