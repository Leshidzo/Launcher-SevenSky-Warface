using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001AF RID: 431
internal class Class162 : Class156
{
	// Token: 0x06000EF0 RID: 3824 RVA: 0x0000CCCB File Offset: 0x0000AECB
	[CompilerGenerated]
	public Class167 method_0()
	{
		return this.class167_0;
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x0000CCD3 File Offset: 0x0000AED3
	[CompilerGenerated]
	public void method_1(Class167 class167_1)
	{
		this.class167_0 = class167_1;
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x0000CCDC File Offset: 0x0000AEDC
	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0)
	{
		Class162.<ExecuteFilter>d__4 <ExecuteFilter>d__ = new Class162.<ExecuteFilter>d__4(-2);
		<ExecuteFilter>d__.<>4__this = this;
		<ExecuteFilter>d__.<>3__root = jtoken_0;
		<ExecuteFilter>d__.<>3__current = ienumerable_0;
		return <ExecuteFilter>d__;
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x0000C885 File Offset: 0x0000AA85
	public Class162()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x04000742 RID: 1858
	[CompilerGenerated]
	private Class167 class167_0;
}
