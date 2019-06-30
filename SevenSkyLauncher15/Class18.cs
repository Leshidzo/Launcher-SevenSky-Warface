using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x020000A0 RID: 160
internal class Class18
{
	// Token: 0x0600056A RID: 1386 RVA: 0x00006571 File Offset: 0x00004771
	public Class18(TextWriter textWriter_1)
	{
		Class202.ofdixO4zTbIfy();
		this.char_0 = new char[76];
		base..ctor();
		Class101.smethod_0(textWriter_1, "writer");
		this.textWriter_0 = textWriter_1;
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x000268A0 File Offset: 0x00024AA0
	private void method_0(byte[] byte_1, int int_1, int int_2)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (int_2 > byte_1.Length - int_1)
		{
			throw new ArgumentOutOfRangeException("count");
		}
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x000268EC File Offset: 0x00024AEC
	public void method_1(byte[] byte_1, int int_1, int int_2)
	{
		this.method_0(byte_1, int_1, int_2);
		if (this.int_0 > 0)
		{
			if (this.method_3(byte_1, int_1, ref int_2))
			{
				return;
			}
			int int_3 = Convert.ToBase64CharArray(this.byte_0, 0, 3, this.char_0, 0);
			this.method_5(this.char_0, 0, int_3);
		}
		this.method_2(byte_1, int_1, ref int_2);
		int num = int_1 + int_2;
		int num2 = 57;
		while (int_1 < num)
		{
			if (int_1 + num2 > num)
			{
				num2 = num - int_1;
			}
			int int_4 = Convert.ToBase64CharArray(byte_1, int_1, num2, this.char_0, 0);
			this.method_5(this.char_0, 0, int_4);
			int_1 += num2;
		}
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x00026980 File Offset: 0x00024B80
	private void method_2(byte[] byte_1, int int_1, ref int int_2)
	{
		int num = int_2 % 3;
		if (num > 0)
		{
			int_2 -= num;
			if (this.byte_0 == null)
			{
				this.byte_0 = new byte[3];
			}
			for (int i = 0; i < num; i++)
			{
				this.byte_0[i] = byte_1[int_1 + int_2 + i];
			}
		}
		this.int_0 = num;
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x000269D4 File Offset: 0x00024BD4
	private bool method_3(byte[] byte_1, int int_1, ref int int_2)
	{
		int num = this.int_0;
		while (num < 3 && int_2 > 0)
		{
			this.byte_0[num++] = byte_1[int_1++];
			int_2--;
		}
		if (int_2 == 0 && num < 3)
		{
			this.int_0 = num;
			return true;
		}
		return false;
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00026A20 File Offset: 0x00024C20
	public void method_4()
	{
		if (this.int_0 > 0)
		{
			int int_ = Convert.ToBase64CharArray(this.byte_0, 0, this.int_0, this.char_0, 0);
			this.method_5(this.char_0, 0, int_);
			this.int_0 = 0;
		}
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0000659D File Offset: 0x0000479D
	private void method_5(char[] char_1, int int_1, int int_2)
	{
		this.textWriter_0.Write(char_1, int_1, int_2);
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x00026A68 File Offset: 0x00024C68
	public async Task method_6(byte[] byte_1, int int_1, int int_2, CancellationToken cancellationToken_0)
	{
		this.method_0(byte_1, int_1, int_2);
		ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter2;
		if (this.int_0 > 0)
		{
			if (this.method_3(byte_1, int_1, ref int_2))
			{
				return;
			}
			int int_3 = Convert.ToBase64CharArray(this.byte_0, 0, 3, this.char_0, 0);
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter = this.method_7(this.char_0, 0, int_3, cancellationToken_0).ConfigureAwait(false).GetAwaiter();
			if (!configuredTaskAwaiter.IsCompleted)
			{
				await configuredTaskAwaiter;
				configuredTaskAwaiter = configuredTaskAwaiter2;
				configuredTaskAwaiter2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
			}
			configuredTaskAwaiter.GetResult();
		}
		this.method_2(byte_1, int_1, ref int_2);
		int num4 = int_1 + int_2;
		int length = 57;
		while (int_1 < num4)
		{
			if (int_1 + length > num4)
			{
				length = num4 - int_1;
			}
			int int_4 = Convert.ToBase64CharArray(byte_1, int_1, length, this.char_0, 0);
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter = this.method_7(this.char_0, 0, int_4, cancellationToken_0).ConfigureAwait(false).GetAwaiter();
			if (!configuredTaskAwaiter.IsCompleted)
			{
				await configuredTaskAwaiter;
				configuredTaskAwaiter = configuredTaskAwaiter2;
				configuredTaskAwaiter2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
			}
			configuredTaskAwaiter.GetResult();
			int_1 += length;
		}
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x000065AD File Offset: 0x000047AD
	private Task method_7(char[] char_1, int int_1, int int_2, CancellationToken cancellationToken_0)
	{
		return this.textWriter_0.smethod_6(char_1, int_1, int_2, cancellationToken_0);
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00026AD0 File Offset: 0x00024CD0
	public Task method_8(CancellationToken cancellationToken_0)
	{
		if (cancellationToken_0.IsCancellationRequested)
		{
			return cancellationToken_0.smethod_2();
		}
		if (this.int_0 > 0)
		{
			int int_ = Convert.ToBase64CharArray(this.byte_0, 0, this.int_0, this.char_0, 0);
			this.int_0 = 0;
			return this.method_7(this.char_0, 0, int_, cancellationToken_0);
		}
		return Class15.task_2;
	}

	// Token: 0x040003B0 RID: 944
	private readonly char[] char_0;

	// Token: 0x040003B1 RID: 945
	private readonly TextWriter textWriter_0;

	// Token: 0x040003B2 RID: 946
	private byte[] byte_0;

	// Token: 0x040003B3 RID: 947
	private int int_0;
}
