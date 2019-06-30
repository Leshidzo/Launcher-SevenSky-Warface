using System;
using System.Xml;

// Token: 0x020001CF RID: 463
internal class Class178 : Class174, Interface4, Interface6
{
	// Token: 0x06000FAF RID: 4015 RVA: 0x0000D53E File Offset: 0x0000B73E
	public Class178(XmlDocumentType xmlDocumentType_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xmlDocumentType_0);
		this.object_0 = xmlDocumentType_0;
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0000D553 File Offset: 0x0000B753
	public string Name
	{
		get
		{
			return this.object_0.Name;
		}
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x0000D560 File Offset: 0x0000B760
	public string imethod_7()
	{
		return this.object_0.SystemId;
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x0000D56D File Offset: 0x0000B76D
	public string imethod_8()
	{
		return this.object_0.PublicId;
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0000D57A File Offset: 0x0000B77A
	public string imethod_9()
	{
		return this.object_0.InternalSubset;
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x0000D587 File Offset: 0x0000B787
	public override string imethod_1()
	{
		return "DOCTYPE";
	}

	// Token: 0x04000787 RID: 1927
	private readonly object object_0;
}
