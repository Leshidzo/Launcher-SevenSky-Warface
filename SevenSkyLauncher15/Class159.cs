using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001A2 RID: 418
internal class Class159 : Class156
{
	// Token: 0x06000E91 RID: 3729 RVA: 0x0000C98F File Offset: 0x0000AB8F
	[CompilerGenerated]
	public int? method_0()
	{
		return this.nullable_0;
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x0000C997 File Offset: 0x0000AB97
	[CompilerGenerated]
	public void method_1(int? nullable_3)
	{
		this.nullable_0 = nullable_3;
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x0000C9A0 File Offset: 0x0000ABA0
	[CompilerGenerated]
	public int? method_2()
	{
		return this.nullable_1;
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
	[CompilerGenerated]
	public void method_3(int? nullable_3)
	{
		this.nullable_1 = nullable_3;
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x0000C9B1 File Offset: 0x0000ABB1
	[CompilerGenerated]
	public int? method_4()
	{
		return this.nullable_2;
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0000C9B9 File Offset: 0x0000ABB9
	[CompilerGenerated]
	public void method_5(int? nullable_3)
	{
		this.nullable_2 = nullable_3;
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x0000C9C2 File Offset: 0x0000ABC2
	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0)
	{
		Class159.<ExecuteFilter>d__12 <ExecuteFilter>d__ = new Class159.<ExecuteFilter>d__12(-2);
		<ExecuteFilter>d__.<>4__this = this;
		<ExecuteFilter>d__.<>3__current = ienumerable_0;
		<ExecuteFilter>d__.<>3__errorWhenNoMatch = bool_0;
		return <ExecuteFilter>d__;
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
	private bool method_6(int int_0, int int_1, bool bool_0)
	{
		if (bool_0)
		{
			return int_0 < int_1;
		}
		return int_0 > int_1;
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x0000C885 File Offset: 0x0000AA85
	public Class159()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x0400070E RID: 1806
	[CompilerGenerated]
	private int? nullable_0;

	// Token: 0x0400070F RID: 1807
	[CompilerGenerated]
	private int? nullable_1;

	// Token: 0x04000710 RID: 1808
	[CompilerGenerated]
	private int? nullable_2;
}
