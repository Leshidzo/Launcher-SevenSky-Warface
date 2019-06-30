using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Converters;

// Token: 0x020001DD RID: 477
internal class Class179 : Interface6
{
	// Token: 0x0600101C RID: 4124 RVA: 0x0000D8D5 File Offset: 0x0000BAD5
	public Class179(XObject xobject_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.xobject_0 = xobject_1;
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x0000D8E9 File Offset: 0x0000BAE9
	public object imjghrpgVE()
	{
		return this.xobject_0;
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x0000D8F1 File Offset: 0x0000BAF1
	public virtual XmlNodeType imethod_0()
	{
		return this.xobject_0.NodeType;
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x0000B325 File Offset: 0x00009525
	public virtual string imethod_1()
	{
		return null;
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x0000D8FE File Offset: 0x0000BAFE
	public virtual List<Interface6> imethod_2()
	{
		return XmlNodeConverter.list_0;
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x0000D8FE File Offset: 0x0000BAFE
	public virtual List<Interface6> imethod_3()
	{
		return XmlNodeConverter.list_0;
	}

	// Token: 0x06001022 RID: 4130 RVA: 0x0000B325 File Offset: 0x00009525
	public virtual Interface6 imethod_4()
	{
		return null;
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x06001023 RID: 4131 RVA: 0x0000B325 File Offset: 0x00009525
	// (set) Token: 0x06001024 RID: 4132 RVA: 0x0000D905 File Offset: 0x0000BB05
	public virtual string Value
	{
		get
		{
			return null;
		}
		set
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x0000D905 File Offset: 0x0000BB05
	public virtual Interface6 imethod_5(Interface6 interface6_0)
	{
		throw new InvalidOperationException();
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x0000B325 File Offset: 0x00009525
	public virtual string imethod_6()
	{
		return null;
	}

	// Token: 0x0400078E RID: 1934
	private readonly XObject xobject_0;
}
