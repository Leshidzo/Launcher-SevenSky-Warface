using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001B4 RID: 436
internal class Class165 : Class156
{
	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06000F0F RID: 3855 RVA: 0x0000CE16 File Offset: 0x0000B016
	// (set) Token: 0x06000F10 RID: 3856 RVA: 0x0000CE1E File Offset: 0x0000B01E
	public string Name { get; set; }

	// Token: 0x06000F11 RID: 3857 RVA: 0x0000CE27 File Offset: 0x0000B027
	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0)
	{
		Class165.<ExecuteFilter>d__4 <ExecuteFilter>d__ = new Class165.<ExecuteFilter>d__4(-2);
		<ExecuteFilter>d__.<>4__this = this;
		<ExecuteFilter>d__.<>3__current = ienumerable_0;
		return <ExecuteFilter>d__;
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x0000C885 File Offset: 0x0000AA85
	public Class165()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x04000759 RID: 1881
	[CompilerGenerated]
	private string string_0;
}
