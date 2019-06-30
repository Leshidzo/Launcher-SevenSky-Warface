using System;
using System.Xml;

// Token: 0x020001CE RID: 462
internal class Class177 : Class174, Interface3, Interface6
{
	// Token: 0x06000FA9 RID: 4009 RVA: 0x0000D4E6 File Offset: 0x0000B6E6
	public Class177(XmlDeclaration xmlDeclaration_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xmlDeclaration_1);
		this.xmlDeclaration_0 = xmlDeclaration_1;
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x0000D4FB File Offset: 0x0000B6FB
	public string imethod_7()
	{
		return this.xmlDeclaration_0.Version;
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x0000D508 File Offset: 0x0000B708
	public string imethod_8()
	{
		return this.xmlDeclaration_0.Encoding;
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x0000D515 File Offset: 0x0000B715
	public void imethod_9(string string_0)
	{
		this.xmlDeclaration_0.Encoding = string_0;
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x0000D523 File Offset: 0x0000B723
	public string imethod_10()
	{
		return this.xmlDeclaration_0.Standalone;
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x0000D530 File Offset: 0x0000B730
	public void imethod_11(string string_0)
	{
		this.xmlDeclaration_0.Standalone = string_0;
	}

	// Token: 0x04000786 RID: 1926
	private readonly XmlDeclaration xmlDeclaration_0;
}
