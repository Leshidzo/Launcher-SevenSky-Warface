using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001A0 RID: 416
internal class Class158 : Class156
{
	// Token: 0x06000E83 RID: 3715 RVA: 0x0000C8FA File Offset: 0x0000AAFA
	[CompilerGenerated]
	public List<int> method_0()
	{
		return this.list_0;
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x0000C902 File Offset: 0x0000AB02
	[CompilerGenerated]
	public void method_1(List<int> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x0000C90B File Offset: 0x0000AB0B
	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0)
	{
		Class158.<ExecuteFilter>d__4 <ExecuteFilter>d__ = new Class158.<ExecuteFilter>d__4(-2);
		<ExecuteFilter>d__.<>4__this = this;
		<ExecuteFilter>d__.<>3__current = ienumerable_0;
		<ExecuteFilter>d__.<>3__errorWhenNoMatch = bool_0;
		return <ExecuteFilter>d__;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x0000C885 File Offset: 0x0000AA85
	public Class158()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x04000702 RID: 1794
	[CompilerGenerated]
	private List<int> list_0;
}
