using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001B6 RID: 438
internal class Class166 : Class156
{
	// Token: 0x06000F1C RID: 3868 RVA: 0x0000CE89 File Offset: 0x0000B089
	[CompilerGenerated]
	public List<string> method_0()
	{
		return this.list_0;
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x0000CE91 File Offset: 0x0000B091
	[CompilerGenerated]
	public void method_1(List<string> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0000CE9A File Offset: 0x0000B09A
	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0)
	{
		Class166.<ExecuteFilter>d__4 <ExecuteFilter>d__ = new Class166.<ExecuteFilter>d__4(-2);
		<ExecuteFilter>d__.<>4__this = this;
		<ExecuteFilter>d__.<>3__current = ienumerable_0;
		return <ExecuteFilter>d__;
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x0000C885 File Offset: 0x0000AA85
	public Class166()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x04000763 RID: 1891
	[CompilerGenerated]
	private List<string> list_0;
}
