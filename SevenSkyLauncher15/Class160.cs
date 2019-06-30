using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001A4 RID: 420
internal class Class160 : Class156
{
	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0000CA39 File Offset: 0x0000AC39
	// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x0000CA41 File Offset: 0x0000AC41
	public string Name { get; set; }

	// Token: 0x06000EA5 RID: 3749 RVA: 0x0000CA4A File Offset: 0x0000AC4A
	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0)
	{
		Class160.<ExecuteFilter>d__4 <ExecuteFilter>d__ = new Class160.<ExecuteFilter>d__4(-2);
		<ExecuteFilter>d__.<>4__this = this;
		<ExecuteFilter>d__.<>3__current = ienumerable_0;
		<ExecuteFilter>d__.<>3__errorWhenNoMatch = bool_0;
		return <ExecuteFilter>d__;
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x0000C885 File Offset: 0x0000AA85
	public Class160()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x0400071F RID: 1823
	[CompilerGenerated]
	private string string_0;
}
