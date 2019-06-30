using System;
using System.Xml.Linq;

// Token: 0x020001D9 RID: 473
internal class Class182 : Class179
{
	// Token: 0x06001006 RID: 4102 RVA: 0x0000D7A7 File Offset: 0x0000B9A7
	private XText method_0()
	{
		return (XText)base.imjghrpgVE();
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
	public Class182(XText xtext_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xtext_0);
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06001008 RID: 4104 RVA: 0x0000D7C2 File Offset: 0x0000B9C2
	// (set) Token: 0x06001009 RID: 4105 RVA: 0x0000D7CF File Offset: 0x0000B9CF
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

	// Token: 0x0600100A RID: 4106 RVA: 0x0000D7DD File Offset: 0x0000B9DD
	public override Interface6 imethod_4()
	{
		if (this.method_0().Parent == null)
		{
			return null;
		}
		return Class185.smethod_0(this.method_0().Parent);
	}
}
