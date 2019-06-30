using System;

// Token: 0x020001EB RID: 491
internal class Class195 : Class191
{
	// Token: 0x060010A7 RID: 4263 RVA: 0x0000DE76 File Offset: 0x0000C076
	public Class195(object object_1, Enum13 enum13_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.object_0 = object_1;
		this.enum13_0 = enum13_1;
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0000DE91 File Offset: 0x0000C091
	public object Value
	{
		get
		{
			return this.object_0;
		}
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0000DE99 File Offset: 0x0000C099
	public override Enum13 Type
	{
		get
		{
			return this.enum13_0;
		}
	}

	// Token: 0x040007B6 RID: 1974
	private readonly object object_0;

	// Token: 0x040007B7 RID: 1975
	private readonly Enum13 enum13_0;
}
