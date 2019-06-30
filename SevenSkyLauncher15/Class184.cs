using System;
using System.Xml.Linq;

// Token: 0x020001DB RID: 475
internal class Class184 : Class179
{
	// Token: 0x06001010 RID: 4112 RVA: 0x0000D847 File Offset: 0x0000BA47
	private XProcessingInstruction method_0()
	{
		return (XProcessingInstruction)base.imjghrpgVE();
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
	public Class184(XProcessingInstruction xprocessingInstruction_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xprocessingInstruction_0);
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x0000D854 File Offset: 0x0000BA54
	public override string imethod_1()
	{
		return this.method_0().Target;
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06001013 RID: 4115 RVA: 0x0000D861 File Offset: 0x0000BA61
	// (set) Token: 0x06001014 RID: 4116 RVA: 0x0000D86E File Offset: 0x0000BA6E
	public override string Value
	{
		get
		{
			return this.method_0().Data;
		}
		set
		{
			this.method_0().Data = value;
		}
	}
}
