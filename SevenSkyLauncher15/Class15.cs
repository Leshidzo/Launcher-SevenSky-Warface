using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x0200009D RID: 157
internal static class Class15
{
	// Token: 0x06000559 RID: 1369 RVA: 0x0000642E File Offset: 0x0000462E
	internal static Task<bool> smethod_0(this bool bool_0)
	{
		if (!bool_0)
		{
			return Class15.task_0;
		}
		return Class15.task_1;
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0000643E File Offset: 0x0000463E
	public static Task XwtFhhOhvo(this CancellationToken cancellationToken_0)
	{
		if (!cancellationToken_0.IsCancellationRequested)
		{
			return null;
		}
		return cancellationToken_0.smethod_2();
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00006451 File Offset: 0x00004651
	public static Task<dikSD6fxLYm5uqLTcX> smethod_1<dikSD6fxLYm5uqLTcX>(this CancellationToken cancellationToken_0)
	{
		if (!cancellationToken_0.IsCancellationRequested)
		{
			return null;
		}
		return cancellationToken_0.smethod_3<dikSD6fxLYm5uqLTcX>();
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00006464 File Offset: 0x00004664
	public static Task smethod_2(this CancellationToken cancellationToken_0)
	{
		return new Task(new Action(Class15.Class16.class16_0.method_0), cancellationToken_0);
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0000648B File Offset: 0x0000468B
	public static Task<fIgol28JODnYQIm4RY> smethod_3<fIgol28JODnYQIm4RY>(this CancellationToken cancellationToken_0)
	{
		return new Task<fIgol28JODnYQIm4RY>(new Func<fIgol28JODnYQIm4RY>(Class15.Class17<fIgol28JODnYQIm4RY>.class17_0.method_0), cancellationToken_0);
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x000064B2 File Offset: 0x000046B2
	public static Task smethod_4(this TextWriter textWriter_0, char char_0, CancellationToken cancellationToken_0)
	{
		if (!cancellationToken_0.IsCancellationRequested)
		{
			return textWriter_0.WriteAsync(char_0);
		}
		return cancellationToken_0.smethod_2();
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x000064CB File Offset: 0x000046CB
	public static Task smethod_5(this TextWriter textWriter_0, string string_0, CancellationToken cancellationToken_0)
	{
		if (!cancellationToken_0.IsCancellationRequested)
		{
			return textWriter_0.WriteAsync(string_0);
		}
		return cancellationToken_0.smethod_2();
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x000064E4 File Offset: 0x000046E4
	public static Task smethod_6(this TextWriter textWriter_0, char[] char_0, int int_0, int int_1, CancellationToken cancellationToken_0)
	{
		if (!cancellationToken_0.IsCancellationRequested)
		{
			return textWriter_0.WriteAsync(char_0, int_0, int_1);
		}
		return cancellationToken_0.smethod_2();
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00006500 File Offset: 0x00004700
	public static Task<int> smethod_7(this TextReader textReader_0, char[] char_0, int int_0, int int_1, CancellationToken cancellationToken_0)
	{
		if (!cancellationToken_0.IsCancellationRequested)
		{
			return textReader_0.ReadAsync(char_0, int_0, int_1);
		}
		return cancellationToken_0.smethod_3<int>();
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x0000651C File Offset: 0x0000471C
	public static bool smethod_8(this Task task_3)
	{
		return task_3.Status == TaskStatus.RanToCompletion;
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00006527 File Offset: 0x00004727
	// Note: this type is marked as 'beforefieldinit'.
	static Class15()
	{
		Class202.ofdixO4zTbIfy();
		Class15.task_0 = Task.FromResult<bool>(false);
		Class15.task_1 = Task.FromResult<bool>(true);
		Class15.task_2 = Task.Delay(0);
	}

	// Token: 0x040003A9 RID: 937
	public static readonly Task<bool> task_0;

	// Token: 0x040003AA RID: 938
	public static readonly Task<bool> task_1;

	// Token: 0x040003AB RID: 939
	internal static readonly Task task_2;

	// Token: 0x0200009E RID: 158
	[CompilerGenerated]
	[Serializable]
	private sealed class Class16
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x0000654F File Offset: 0x0000474F
		// Note: this type is marked as 'beforefieldinit'.
		static Class16()
		{
			Class202.ofdixO4zTbIfy();
			Class15.Class16.class16_0 = new Class15.Class16();
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002621 File Offset: 0x00000821
		public Class16()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000052D6 File Offset: 0x000034D6
		internal void method_0()
		{
		}

		// Token: 0x040003AC RID: 940
		public static readonly Class15.Class16 class16_0;

		// Token: 0x040003AD RID: 941
		public static Action action_0;
	}

	// Token: 0x0200009F RID: 159
	[CompilerGenerated]
	[Serializable]
	private sealed class Class17<b7nwMLyJDoUePX7jS6J>
	{
		// Token: 0x06000567 RID: 1383 RVA: 0x00006560 File Offset: 0x00004760
		// Note: this type is marked as 'beforefieldinit'.
		static Class17()
		{
			Class202.ofdixO4zTbIfy();
			Class15.Class17<b7nwMLyJDoUePX7jS6J>.class17_0 = new Class15.Class17<b7nwMLyJDoUePX7jS6J>();
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002621 File Offset: 0x00000821
		public Class17()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00026888 File Offset: 0x00024A88
		internal b7nwMLyJDoUePX7jS6J method_0()
		{
			return default(b7nwMLyJDoUePX7jS6J);
		}

		// Token: 0x040003AE RID: 942
		public static readonly Class15.Class17<b7nwMLyJDoUePX7jS6J> class17_0;

		// Token: 0x040003AF RID: 943
		public static Func<b7nwMLyJDoUePX7jS6J> func_0;
	}
}
