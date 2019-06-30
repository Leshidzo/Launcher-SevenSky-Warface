using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x020001E9 RID: 489
internal class Class193 : Class191, IEnumerable<Class191>, IEnumerable
{
	// Token: 0x0600109F RID: 4255 RVA: 0x0000DDF5 File Offset: 0x0000BFF5
	public void method_4(Class191 class191_1)
	{
		this.list_0.Add(class191_1);
		class191_1.method_1(this);
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0000B86C File Offset: 0x00009A6C
	public override Enum13 Type
	{
		get
		{
			return (Enum13)4;
		}
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x0000DE0A File Offset: 0x0000C00A
	public IEnumerator<Class191> GetEnumerator()
	{
		return this.list_0.GetEnumerator();
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x0000DE1C File Offset: 0x0000C01C
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x0000DE24 File Offset: 0x0000C024
	public Class193()
	{
		Class202.ofdixO4zTbIfy();
		this.list_0 = new List<Class191>();
		base..ctor();
	}

	// Token: 0x040007B2 RID: 1970
	private readonly List<Class191> list_0;
}
