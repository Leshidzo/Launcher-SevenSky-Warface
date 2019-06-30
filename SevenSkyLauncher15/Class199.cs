using System;
using System.Runtime.CompilerServices;

// Token: 0x020001EF RID: 495
internal class Class199 : Class191
{
	// Token: 0x1700021A RID: 538
	// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0000DF28 File Offset: 0x0000C128
	// (set) Token: 0x060010B4 RID: 4276 RVA: 0x0000DF30 File Offset: 0x0000C130
	public Class197 Pattern { get; set; }

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0000DF39 File Offset: 0x0000C139
	// (set) Token: 0x060010B6 RID: 4278 RVA: 0x0000DF41 File Offset: 0x0000C141
	public Class197 Options { get; set; }

	// Token: 0x060010B7 RID: 4279 RVA: 0x0000DF4A File Offset: 0x0000C14A
	public Class199(string string_0, string string_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.Pattern = new Class197(string_0, false);
		this.Options = new Class197(string_1, false);
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0000DF71 File Offset: 0x0000C171
	public override Enum13 Type
	{
		get
		{
			return (Enum13)11;
		}
	}

	// Token: 0x040007BD RID: 1981
	[CompilerGenerated]
	private Class197 class197_0;

	// Token: 0x040007BE RID: 1982
	[CompilerGenerated]
	private Class197 class197_1;
}
