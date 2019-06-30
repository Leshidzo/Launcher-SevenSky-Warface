using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

// Token: 0x020001D6 RID: 470
internal class Class180 : Class179, Interface3, Interface6
{
	// Token: 0x06000FE6 RID: 4070 RVA: 0x0000D5F9 File Offset: 0x0000B7F9
	[CompilerGenerated]
	internal XDeclaration uuuqhEdyag()
	{
		return this.xdeclaration_0;
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x0000D601 File Offset: 0x0000B801
	public Class180(XDeclaration xdeclaration_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(null);
		this.xdeclaration_0 = xdeclaration_1;
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x0000D616 File Offset: 0x0000B816
	public override XmlNodeType imethod_0()
	{
		return XmlNodeType.XmlDeclaration;
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x0000D61A File Offset: 0x0000B81A
	public string imethod_7()
	{
		return this.uuuqhEdyag().Version;
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x0000D627 File Offset: 0x0000B827
	public string imethod_8()
	{
		return this.uuuqhEdyag().Encoding;
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x0000D634 File Offset: 0x0000B834
	public void imethod_9(string string_0)
	{
		this.uuuqhEdyag().Encoding = string_0;
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x0000D642 File Offset: 0x0000B842
	public string imethod_10()
	{
		return this.uuuqhEdyag().Standalone;
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x0000D64F File Offset: 0x0000B84F
	public void imethod_11(string string_0)
	{
		this.uuuqhEdyag().Standalone = string_0;
	}

	// Token: 0x0400078B RID: 1931
	[CompilerGenerated]
	private readonly XDeclaration xdeclaration_0;
}
