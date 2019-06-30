using System;
using System.Xml.Linq;

// Token: 0x020001DA RID: 474
internal class Class183 : Class179
{
	// Token: 0x0600100B RID: 4107 RVA: 0x0000D7FE File Offset: 0x0000B9FE
	private XComment method_0()
	{
		return (XComment)base.imjghrpgVE();
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
	public Class183(XComment xcomment_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xcomment_0);
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x0600100D RID: 4109 RVA: 0x0000D80B File Offset: 0x0000BA0B
	// (set) Token: 0x0600100E RID: 4110 RVA: 0x0000D818 File Offset: 0x0000BA18
	public override string Value
	{
		get
		{
			return this.method_0().Value;
		}
		set
		{
			this.method_0().Value = value;
		}
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x0000D826 File Offset: 0x0000BA26
	public override Interface6 imethod_4()
	{
		if (this.method_0().Parent == null)
		{
			return null;
		}
		return Class185.smethod_0(this.method_0().Parent);
	}
}
