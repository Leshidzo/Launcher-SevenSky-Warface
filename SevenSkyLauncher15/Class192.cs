using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x020001E8 RID: 488
internal class Class192 : Class191, IEnumerable<Class200>, IEnumerable
{
	// Token: 0x0600109A RID: 4250 RVA: 0x0000DD96 File Offset: 0x0000BF96
	public void method_4(string string_0, Class191 class191_1)
	{
		this.list_0.Add(new Class200
		{
			Name = new Class197(string_0, false),
			Value = class191_1
		});
		class191_1.method_1(this);
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x0600109B RID: 4251 RVA: 0x0000AF80 File Offset: 0x00009180
	public override Enum13 Type
	{
		get
		{
			return (Enum13)3;
		}
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x0000DDC3 File Offset: 0x0000BFC3
	public IEnumerator<Class200> GetEnumerator()
	{
		return this.list_0.GetEnumerator();
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x0000DDD5 File Offset: 0x0000BFD5
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x0000DDDD File Offset: 0x0000BFDD
	public Class192()
	{
		Class202.ofdixO4zTbIfy();
		this.list_0 = new List<Class200>();
		base..ctor();
	}

	// Token: 0x040007B1 RID: 1969
	private readonly List<Class200> list_0;
}
