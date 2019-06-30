using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

// Token: 0x020001D8 RID: 472
internal class Class186 : Class185, Interface2, Interface6
{
	// Token: 0x06000FF4 RID: 4084 RVA: 0x0000D6A6 File Offset: 0x0000B8A6
	private XDocument method_1()
	{
		return (XDocument)base.imjghrpgVE();
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x0000D6B3 File Offset: 0x0000B8B3
	public Class186(XDocument xdocument_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xdocument_0);
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x00048A3C File Offset: 0x00046C3C
	public override List<Interface6> imethod_2()
	{
		List<Interface6> list = base.imethod_2();
		if (this.method_1().Declaration != null && (list.Count == 0 || list[0].imethod_0() != XmlNodeType.XmlDeclaration))
		{
			list.Insert(0, new Class180(this.method_1().Declaration));
		}
		return list;
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x0000D6C1 File Offset: 0x0000B8C1
	protected override bool vmethod_0()
	{
		return base.vmethod_0() || this.method_1().Declaration != null;
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x0000D6DB File Offset: 0x0000B8DB
	public Interface6 imethod_7(string string_0)
	{
		return new Class179(new XComment(string_0));
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
	public Interface6 imethod_8(string string_0)
	{
		return new Class179(new XText(string_0));
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x0000D6F5 File Offset: 0x0000B8F5
	public Interface6 pymgRtErci(string string_0)
	{
		return new Class179(new XCData(string_0));
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
	public Interface6 imethod_9(string string_0)
	{
		return new Class179(new XText(string_0));
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
	public Interface6 imethod_10(string string_0)
	{
		return new Class179(new XText(string_0));
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x0000D702 File Offset: 0x0000B902
	public Interface6 imethod_11(string string_0, string string_1, string string_2)
	{
		return new Class180(new XDeclaration(string_0, string_1, string_2));
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x0000D711 File Offset: 0x0000B911
	public Interface6 imethod_12(string string_0, string string_1, string string_2, string string_3)
	{
		return new Class181(new XDocumentType(string_0, string_1, string_2, string_3));
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x0000D722 File Offset: 0x0000B922
	public Interface6 imethod_13(string string_0, string string_1)
	{
		return new Class184(new XProcessingInstruction(string_0, string_1));
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x0000D730 File Offset: 0x0000B930
	public Interface5 imethod_14(string string_0)
	{
		return new Class187(new XElement(string_0));
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x0000D742 File Offset: 0x0000B942
	public Interface5 imethod_15(string string_0, string string_1)
	{
		return new Class187(new XElement(XName.Get(Class80.smethod_5(string_0), string_1)));
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x0000D75A File Offset: 0x0000B95A
	public Interface6 imethod_16(string string_0, string string_1)
	{
		return new Class188(new XAttribute(string_0, string_1));
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x0000D76D File Offset: 0x0000B96D
	public Interface6 imethod_17(string string_0, string string_1, string string_2)
	{
		return new Class188(new XAttribute(XName.Get(Class80.smethod_5(string_0), string_1), string_2));
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x0000D786 File Offset: 0x0000B986
	public Interface5 imethod_18()
	{
		if (this.method_1().Root == null)
		{
			return null;
		}
		return new Class187(this.method_1().Root);
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00048A90 File Offset: 0x00046C90
	public override Interface6 imethod_5(Interface6 interface6_0)
	{
		Class180 @class;
		if ((@class = (interface6_0 as Class180)) != null)
		{
			this.method_1().Declaration = @class.uuuqhEdyag();
			return @class;
		}
		return base.imethod_5(interface6_0);
	}
}
