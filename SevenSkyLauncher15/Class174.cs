using System;
using System.Collections.Generic;
using System.Xml;
using Newtonsoft.Json.Converters;

// Token: 0x020001D0 RID: 464
internal class Class174 : Interface6
{
	// Token: 0x06000FB5 RID: 4021 RVA: 0x0000D58E File Offset: 0x0000B78E
	public Class174(XmlNode xmlNode_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.xmlNode_0 = xmlNode_1;
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x0000D5A2 File Offset: 0x0000B7A2
	public object imjghrpgVE()
	{
		return this.xmlNode_0;
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x0000D5AA File Offset: 0x0000B7AA
	public XmlNodeType imethod_0()
	{
		return this.xmlNode_0.NodeType;
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x0000D5B7 File Offset: 0x0000B7B7
	public virtual string imethod_1()
	{
		return this.xmlNode_0.LocalName;
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x000487E8 File Offset: 0x000469E8
	public List<Interface6> imethod_2()
	{
		if (this.list_0 == null)
		{
			if (!this.xmlNode_0.HasChildNodes)
			{
				this.list_0 = XmlNodeConverter.list_0;
			}
			else
			{
				this.list_0 = new List<Interface6>(this.xmlNode_0.ChildNodes.Count);
				foreach (object obj in this.xmlNode_0.ChildNodes)
				{
					XmlNode object_ = (XmlNode)obj;
					this.list_0.Add(Class174.smethod_0(object_));
				}
			}
		}
		return this.list_0;
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x0000D5C4 File Offset: 0x0000B7C4
	protected virtual bool vmethod_0()
	{
		return this.xmlNode_0.HasChildNodes;
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00048898 File Offset: 0x00046A98
	internal static Interface6 smethod_0(object object_0)
	{
		XmlNodeType nodeType = object_0.NodeType;
		if (nodeType == XmlNodeType.Element)
		{
			return new Class176((XmlElement)object_0);
		}
		if (nodeType == XmlNodeType.DocumentType)
		{
			return new Class178((XmlDocumentType)object_0);
		}
		if (nodeType != XmlNodeType.XmlDeclaration)
		{
			return new Class174(object_0);
		}
		return new Class177((XmlDeclaration)object_0);
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x000488E4 File Offset: 0x00046AE4
	public List<Interface6> imethod_3()
	{
		if (this.list_1 == null)
		{
			if (!this.method_0())
			{
				this.list_1 = XmlNodeConverter.list_0;
			}
			else
			{
				this.list_1 = new List<Interface6>(this.xmlNode_0.Attributes.Count);
				foreach (object obj in this.xmlNode_0.Attributes)
				{
					XmlAttribute object_ = (XmlAttribute)obj;
					this.list_1.Add(Class174.smethod_0(object_));
				}
			}
		}
		return this.list_1;
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x0004898C File Offset: 0x00046B8C
	private bool method_0()
	{
		XmlElement xmlElement;
		if ((xmlElement = (this.xmlNode_0 as XmlElement)) != null)
		{
			return xmlElement.HasAttributes;
		}
		XmlAttributeCollection attributes = this.xmlNode_0.Attributes;
		return attributes != null && attributes.Count > 0;
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x000489C8 File Offset: 0x00046BC8
	public Interface6 imethod_4()
	{
		XmlAttribute xmlAttribute;
		XmlNode xmlNode = ((xmlAttribute = (this.xmlNode_0 as XmlAttribute)) != null) ? xmlAttribute.OwnerElement : this.xmlNode_0.ParentNode;
		if (xmlNode == null)
		{
			return null;
		}
		return Class174.smethod_0(xmlNode);
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0000D5D1 File Offset: 0x0000B7D1
	// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x0000D5DE File Offset: 0x0000B7DE
	public string Value
	{
		get
		{
			return this.xmlNode_0.Value;
		}
		set
		{
			this.xmlNode_0.Value = value;
		}
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x00048A04 File Offset: 0x00046C04
	public Interface6 imethod_5(Interface6 interface6_0)
	{
		Class174 @class = (Class174)interface6_0;
		this.xmlNode_0.AppendChild(@class.xmlNode_0);
		this.list_0 = null;
		this.list_1 = null;
		return interface6_0;
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x0000D5EC File Offset: 0x0000B7EC
	public string imethod_6()
	{
		return this.xmlNode_0.NamespaceURI;
	}

	// Token: 0x04000788 RID: 1928
	private readonly XmlNode xmlNode_0;

	// Token: 0x04000789 RID: 1929
	private List<Interface6> list_0;

	// Token: 0x0400078A RID: 1930
	private List<Interface6> list_1;
}
