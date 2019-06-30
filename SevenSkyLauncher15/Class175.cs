using System;
using System.Xml;

// Token: 0x020001CC RID: 460
internal class Class175 : Class174, Interface2, Interface6
{
	// Token: 0x06000F97 RID: 3991 RVA: 0x0000D386 File Offset: 0x0000B586
	public Class175(XmlDocument xmlDocument_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xmlDocument_1);
		this.xmlDocument_0 = xmlDocument_1;
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0000D39B File Offset: 0x0000B59B
	public Interface6 imethod_7(string string_0)
	{
		return new Class174(this.xmlDocument_0.CreateComment(string_0));
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x0000D3AE File Offset: 0x0000B5AE
	public Interface6 imethod_8(string string_0)
	{
		return new Class174(this.xmlDocument_0.CreateTextNode(string_0));
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x0000D3C1 File Offset: 0x0000B5C1
	public Interface6 pymgRtErci(string string_0)
	{
		return new Class174(this.xmlDocument_0.CreateCDataSection(string_0));
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
	public Interface6 imethod_9(string string_0)
	{
		return new Class174(this.xmlDocument_0.CreateWhitespace(string_0));
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x0000D3E7 File Offset: 0x0000B5E7
	public Interface6 imethod_10(string string_0)
	{
		return new Class174(this.xmlDocument_0.CreateSignificantWhitespace(string_0));
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0000D3FA File Offset: 0x0000B5FA
	public Interface6 imethod_11(string string_0, string string_1, string string_2)
	{
		return new Class177(this.xmlDocument_0.CreateXmlDeclaration(string_0, string_1, string_2));
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x0000D40F File Offset: 0x0000B60F
	public Interface6 imethod_12(string string_0, string string_1, string string_2, string string_3)
	{
		return new Class178(this.xmlDocument_0.CreateDocumentType(string_0, string_1, string_2, null));
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x0000D425 File Offset: 0x0000B625
	public Interface6 imethod_13(string string_0, string string_1)
	{
		return new Class174(this.xmlDocument_0.CreateProcessingInstruction(string_0, string_1));
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0000D439 File Offset: 0x0000B639
	public Interface5 imethod_14(string string_0)
	{
		return new Class176(this.xmlDocument_0.CreateElement(string_0));
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x0000D44C File Offset: 0x0000B64C
	public Interface5 imethod_15(string string_0, string string_1)
	{
		return new Class176(this.xmlDocument_0.CreateElement(string_0, string_1));
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x0000D460 File Offset: 0x0000B660
	public Interface6 imethod_16(string string_0, string string_1)
	{
		return new Class174(this.xmlDocument_0.CreateAttribute(string_0))
		{
			Value = string_1
		};
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x0000D47A File Offset: 0x0000B67A
	public Interface6 imethod_17(string string_0, string string_1, string string_2)
	{
		return new Class174(this.xmlDocument_0.CreateAttribute(string_0, string_1))
		{
			Value = string_2
		};
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0000D495 File Offset: 0x0000B695
	public Interface5 imethod_18()
	{
		if (this.xmlDocument_0.DocumentElement == null)
		{
			return null;
		}
		return new Class176(this.xmlDocument_0.DocumentElement);
	}

	// Token: 0x04000784 RID: 1924
	private readonly XmlDocument xmlDocument_0;
}
