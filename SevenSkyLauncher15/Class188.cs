using System;
using System.Xml.Linq;

// Token: 0x020001DE RID: 478
internal class Class188 : Class179
{
	// Token: 0x06001027 RID: 4135 RVA: 0x0000D90C File Offset: 0x0000BB0C
	private XAttribute method_0()
	{
		return (XAttribute)base.imjghrpgVE();
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
	public Class188(XAttribute xattribute_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xattribute_0);
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x06001029 RID: 4137 RVA: 0x0000D919 File Offset: 0x0000BB19
	// (set) Token: 0x0600102A RID: 4138 RVA: 0x0000D926 File Offset: 0x0000BB26
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

	// Token: 0x0600102B RID: 4139 RVA: 0x0000D934 File Offset: 0x0000BB34
	public override string imethod_1()
	{
		return this.method_0().Name.LocalName;
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x0000D946 File Offset: 0x0000BB46
	public override string imethod_6()
	{
		return this.method_0().Name.NamespaceName;
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x0000D958 File Offset: 0x0000BB58
	public override Interface6 imethod_4()
	{
		if (this.method_0().Parent == null)
		{
			return null;
		}
		return Class185.smethod_0(this.method_0().Parent);
	}
}
