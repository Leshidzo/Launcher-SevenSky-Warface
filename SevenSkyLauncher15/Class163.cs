using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001B1 RID: 433
internal class Class163 : Class156
{
	// Token: 0x06000EFE RID: 3838 RVA: 0x0000CD62 File Offset: 0x0000AF62
	[CompilerGenerated]
	public Class167 method_0()
	{
		return this.class167_0;
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x0000CD6A File Offset: 0x0000AF6A
	[CompilerGenerated]
	public void method_1(Class167 class167_1)
	{
		this.class167_0 = class167_1;
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x0000CD73 File Offset: 0x0000AF73
	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0)
	{
		Class163.<ExecuteFilter>d__4 <ExecuteFilter>d__ = new Class163.<ExecuteFilter>d__4(-2);
		<ExecuteFilter>d__.<>4__this = this;
		<ExecuteFilter>d__.<>3__root = jtoken_0;
		<ExecuteFilter>d__.<>3__current = ienumerable_0;
		return <ExecuteFilter>d__;
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x0000C885 File Offset: 0x0000AA85
	public Class163()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x0400074D RID: 1869
	[CompilerGenerated]
	private Class167 class167_0;
}
