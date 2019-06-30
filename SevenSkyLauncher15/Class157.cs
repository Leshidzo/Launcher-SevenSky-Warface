using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x0200019E RID: 414
internal class Class157 : Class156
{
	// Token: 0x06000E75 RID: 3701 RVA: 0x0000C856 File Offset: 0x0000AA56
	[CompilerGenerated]
	public int? method_0()
	{
		return this.nullable_0;
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x0000C85E File Offset: 0x0000AA5E
	[CompilerGenerated]
	public void method_1(int? nullable_1)
	{
		this.nullable_0 = nullable_1;
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x0000C867 File Offset: 0x0000AA67
	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0)
	{
		Class157.<ExecuteFilter>d__4 <ExecuteFilter>d__ = new Class157.<ExecuteFilter>d__4(-2);
		<ExecuteFilter>d__.<>4__this = this;
		<ExecuteFilter>d__.<>3__current = ienumerable_0;
		<ExecuteFilter>d__.<>3__errorWhenNoMatch = bool_0;
		return <ExecuteFilter>d__;
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x0000C885 File Offset: 0x0000AA85
	public Class157()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x040006F7 RID: 1783
	[CompilerGenerated]
	private int? nullable_0;
}
