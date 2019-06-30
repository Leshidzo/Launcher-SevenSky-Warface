using System;
using System.Xml;

// Token: 0x020001CD RID: 461
internal class Class176 : Class174, Interface5, Interface6
{
	// Token: 0x06000FA5 RID: 4005 RVA: 0x0000D4B6 File Offset: 0x0000B6B6
	public Class176(XmlElement xmlElement_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xmlElement_0);
		this.object_0 = xmlElement_0;
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x000487BC File Offset: 0x000469BC
	public void imethod_7(Interface6 interface6_0)
	{
		Class174 @class = (Class174)interface6_0;
		this.object_0.SetAttributeNode((XmlAttribute)@class.imjghrpgVE());
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x0000D4CB File Offset: 0x0000B6CB
	public string dnXgedsFyK(string string_0)
	{
		return this.object_0.GetPrefixOfNamespace(string_0);
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x0000D4D9 File Offset: 0x0000B6D9
	public bool imethod_8()
	{
		return this.object_0.IsEmpty;
	}

	// Token: 0x04000785 RID: 1925
	private readonly object object_0;
}
