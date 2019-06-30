using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

// Token: 0x020001A6 RID: 422
internal class Class161 : Class156
{
	// Token: 0x06000EB1 RID: 3761 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
	[CompilerGenerated]
	public List<string> method_0()
	{
		return this.list_0;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
	[CompilerGenerated]
	public void method_1(List<string> list_1)
	{
		this.list_0 = list_1;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x0000CAE1 File Offset: 0x0000ACE1
	public override IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0)
	{
		Class161.<ExecuteFilter>d__4 <ExecuteFilter>d__ = new Class161.<ExecuteFilter>d__4(-2);
		<ExecuteFilter>d__.<>4__this = this;
		<ExecuteFilter>d__.<>3__current = ienumerable_0;
		<ExecuteFilter>d__.<>3__errorWhenNoMatch = bool_0;
		return <ExecuteFilter>d__;
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x0000C885 File Offset: 0x0000AA85
	public Class161()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x0400072A RID: 1834
	[CompilerGenerated]
	private List<string> list_0;

	// Token: 0x020001A7 RID: 423
	[CompilerGenerated]
	[Serializable]
	private sealed class Class154
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x0000CAFF File Offset: 0x0000ACFF
		// Note: this type is marked as 'beforefieldinit'.
		static Class154()
		{
			Class202.ofdixO4zTbIfy();
			Class161.Class154.class154_0 = new Class161.Class154();
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00002621 File Offset: 0x00000821
		public Class154()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0000CB10 File Offset: 0x0000AD10
		internal string method_0(string string_0)
		{
			return "'" + string_0 + "'";
		}

		// Token: 0x0400072B RID: 1835
		public static readonly Class161.Class154 class154_0;

		// Token: 0x0400072C RID: 1836
		public static Func<string, string> func_0;
	}
}
