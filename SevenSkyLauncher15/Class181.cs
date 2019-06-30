using System;
using System.Xml.Linq;

// Token: 0x020001D7 RID: 471
internal class Class181 : Class179, Interface4, Interface6
{
	// Token: 0x06000FEE RID: 4078 RVA: 0x0000D65D File Offset: 0x0000B85D
	public Class181(XDocumentType xdocumentType_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xdocumentType_1);
		this.xdocumentType_0 = xdocumentType_1;
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0000D672 File Offset: 0x0000B872
	public string Name
	{
		get
		{
			return this.xdocumentType_0.Name;
		}
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x0000D67F File Offset: 0x0000B87F
	public string imethod_7()
	{
		return this.xdocumentType_0.SystemId;
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x0000D68C File Offset: 0x0000B88C
	public string imethod_8()
	{
		return this.xdocumentType_0.PublicId;
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x0000D699 File Offset: 0x0000B899
	public string imethod_9()
	{
		return this.xdocumentType_0.InternalSubset;
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x0000D587 File Offset: 0x0000B787
	public override string imethod_1()
	{
		return "DOCTYPE";
	}

	// Token: 0x0400078C RID: 1932
	private readonly XDocumentType xdocumentType_0;
}
