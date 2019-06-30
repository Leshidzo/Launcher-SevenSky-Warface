using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json.Converters;

// Token: 0x020001DC RID: 476
internal class Class185 : Class179
{
	// Token: 0x06001015 RID: 4117 RVA: 0x0000D87C File Offset: 0x0000BA7C
	private XContainer method_0()
	{
		return (XContainer)base.imjghrpgVE();
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
	public Class185(XContainer xcontainer_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xcontainer_0);
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00048AC4 File Offset: 0x00046CC4
	public override List<Interface6> imethod_2()
	{
		if (this.list_0 == null)
		{
			if (!this.vmethod_0())
			{
				this.list_0 = XmlNodeConverter.list_0;
			}
			else
			{
				this.list_0 = new List<Interface6>();
				foreach (XNode xobject_ in this.method_0().Nodes())
				{
					this.list_0.Add(Class185.smethod_0(xobject_));
				}
			}
		}
		return this.list_0;
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x0000D889 File Offset: 0x0000BA89
	protected virtual bool vmethod_0()
	{
		return this.method_0().LastNode != null;
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x0000D899 File Offset: 0x0000BA99
	public override Interface6 imethod_4()
	{
		if (this.method_0().Parent == null)
		{
			return null;
		}
		return Class185.smethod_0(this.method_0().Parent);
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00048B50 File Offset: 0x00046D50
	internal static Interface6 smethod_0(XObject xobject_1)
	{
		XDocument xdocument_;
		if ((xdocument_ = (xobject_1 as XDocument)) != null)
		{
			return new Class186(xdocument_);
		}
		XElement xelement_;
		if ((xelement_ = (xobject_1 as XElement)) != null)
		{
			return new Class187(xelement_);
		}
		XContainer xcontainer_;
		if ((xcontainer_ = (xobject_1 as XContainer)) != null)
		{
			return new Class185(xcontainer_);
		}
		XProcessingInstruction xprocessingInstruction_;
		if ((xprocessingInstruction_ = (xobject_1 as XProcessingInstruction)) != null)
		{
			return new Class184(xprocessingInstruction_);
		}
		XText xtext_;
		if ((xtext_ = (xobject_1 as XText)) != null)
		{
			return new Class182(xtext_);
		}
		XComment xcomment_;
		if ((xcomment_ = (xobject_1 as XComment)) != null)
		{
			return new Class183(xcomment_);
		}
		XAttribute xattribute_;
		if ((xattribute_ = (xobject_1 as XAttribute)) != null)
		{
			return new Class188(xattribute_);
		}
		XDocumentType xdocumentType_;
		if ((xdocumentType_ = (xobject_1 as XDocumentType)) != null)
		{
			return new Class181(xdocumentType_);
		}
		return new Class179(xobject_1);
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x0000D8BA File Offset: 0x0000BABA
	public override Interface6 imethod_5(Interface6 interface6_0)
	{
		this.method_0().Add(interface6_0.imjghrpgVE());
		this.list_0 = null;
		return interface6_0;
	}

	// Token: 0x0400078D RID: 1933
	private List<Interface6> list_0;
}
