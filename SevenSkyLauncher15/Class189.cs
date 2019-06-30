using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020001E2 RID: 482
internal class Class189
{
	// Token: 0x06001062 RID: 4194 RVA: 0x0000DAD9 File Offset: 0x0000BCD9
	[CompilerGenerated]
	public DateTimeKind method_0()
	{
		return this.dateTimeKind_0;
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x0000DAE1 File Offset: 0x0000BCE1
	[CompilerGenerated]
	public void method_1(DateTimeKind dateTimeKind_1)
	{
		this.dateTimeKind_0 = dateTimeKind_1;
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x0000DAEA File Offset: 0x0000BCEA
	public Class189(BinaryWriter binaryWriter_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.method_1(DateTimeKind.Utc);
		this.binaryWriter_0 = binaryWriter_1;
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x0000DB05 File Offset: 0x0000BD05
	public void method_2()
	{
		this.binaryWriter_0.Flush();
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x0000DB12 File Offset: 0x0000BD12
	public void method_3()
	{
		this.binaryWriter_0.Close();
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x0000DB1F File Offset: 0x0000BD1F
	public void method_4(Class191 class191_0)
	{
		this.method_10(class191_0);
		this.method_5(class191_0);
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x0004A810 File Offset: 0x00048A10
	private void method_5(Class191 class191_0)
	{
		switch (class191_0.Type)
		{
		case (Enum13)1:
		{
			Class195 @class = (Class195)class191_0;
			this.binaryWriter_0.Write(Convert.ToDouble(@class.Value, CultureInfo.InvariantCulture));
			return;
		}
		case (Enum13)2:
		{
			Class197 class2 = (Class197)class191_0;
			this.method_6((string)class2.Value, class2.method_4(), new int?(class2.method_2() - 4));
			return;
		}
		case (Enum13)3:
		{
			Class192 class3 = (Class192)class191_0;
			this.binaryWriter_0.Write(class3.method_2());
			foreach (Class200 class4 in class3)
			{
				this.binaryWriter_0.Write((sbyte)class4.Value.Type);
				this.method_6((string)class4.Name.Value, class4.Name.method_4(), null);
				this.method_5(class4.Value);
			}
			this.binaryWriter_0.Write(0);
			return;
		}
		case (Enum13)4:
		{
			Class193 class5 = (Class193)class191_0;
			this.binaryWriter_0.Write(class5.method_2());
			ulong num = 0UL;
			foreach (Class191 class6 in class5)
			{
				this.binaryWriter_0.Write((sbyte)class6.Type);
				this.method_6(num.ToString(CultureInfo.InvariantCulture), Class79.smethod_0(num), null);
				this.method_5(class6);
				num += 1UL;
			}
			this.binaryWriter_0.Write(0);
			return;
		}
		case (Enum13)5:
		{
			Class198 class7 = (Class198)class191_0;
			byte[] array = (byte[])class7.Value;
			this.binaryWriter_0.Write(array.Length);
			this.binaryWriter_0.Write((byte)class7.method_4());
			this.binaryWriter_0.Write(array);
			return;
		}
		case (Enum13)6:
		case (Enum13)10:
			return;
		case (Enum13)7:
		{
			byte[] buffer = (byte[])((Class195)class191_0).Value;
			this.binaryWriter_0.Write(buffer);
			return;
		}
		case (Enum13)8:
			this.binaryWriter_0.Write(class191_0 == Class196.class196_1);
			return;
		case (Enum13)9:
		{
			Class195 class8 = (Class195)class191_0;
			object value;
			long value2;
			if ((value = class8.Value) is DateTime)
			{
				DateTime dateTime_ = (DateTime)value;
				if (this.method_0() == DateTimeKind.Utc)
				{
					dateTime_ = dateTime_.ToUniversalTime();
				}
				else if (this.method_0() == DateTimeKind.Local)
				{
					dateTime_ = dateTime_.ToLocalTime();
				}
				value2 = Class25.smethod_9(dateTime_, false);
			}
			else
			{
				DateTimeOffset dateTimeOffset = (DateTimeOffset)class8.Value;
				value2 = Class25.smethod_7(dateTimeOffset.UtcDateTime, dateTimeOffset.Offset);
			}
			this.binaryWriter_0.Write(value2);
			return;
		}
		case (Enum13)11:
		{
			Class199 class9 = (Class199)class191_0;
			this.method_6((string)class9.Pattern.Value, class9.Pattern.method_4(), null);
			this.method_6((string)class9.Options.Value, class9.Options.method_4(), null);
			return;
		}
		case (Enum13)16:
		{
			Class195 class10 = (Class195)class191_0;
			this.binaryWriter_0.Write(Convert.ToInt32(class10.Value, CultureInfo.InvariantCulture));
			return;
		}
		case (Enum13)18:
		{
			Class195 class11 = (Class195)class191_0;
			this.binaryWriter_0.Write(Convert.ToInt64(class11.Value, CultureInfo.InvariantCulture));
			return;
		}
		}
		throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".smethod_0(CultureInfo.InvariantCulture, class191_0.Type));
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x0000DB30 File Offset: 0x0000BD30
	private void method_6(string string_0, int int_0, int? nullable_0)
	{
		if (nullable_0 != null)
		{
			this.binaryWriter_0.Write(nullable_0.GetValueOrDefault());
		}
		this.method_7(string_0, int_0);
		this.binaryWriter_0.Write(0);
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x0004AC08 File Offset: 0x00048E08
	public void method_7(string string_0, int int_0)
	{
		if (string_0 != null)
		{
			if (int_0 <= 256)
			{
				if (this.byte_0 == null)
				{
					this.byte_0 = new byte[256];
				}
				Class189.utf8Encoding_0.GetBytes(string_0, 0, string_0.Length, this.byte_0, 0);
				this.binaryWriter_0.Write(this.byte_0, 0, int_0);
				return;
			}
			byte[] bytes = Class189.utf8Encoding_0.GetBytes(string_0);
			this.binaryWriter_0.Write(bytes);
		}
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x0000DB61 File Offset: 0x0000BD61
	private int method_8(int int_0)
	{
		return int_0 + 1;
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x0000DB66 File Offset: 0x0000BD66
	private int method_9(int int_0, bool bool_0)
	{
		return (bool_0 ? 5 : 1) + int_0;
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x0004AC80 File Offset: 0x00048E80
	private int method_10(Class191 class191_0)
	{
		switch (class191_0.Type)
		{
		case (Enum13)1:
			return 8;
		case (Enum13)2:
		{
			Class197 @class = (Class197)class191_0;
			string text = (string)@class.Value;
			@class.method_5((text != null) ? Class189.utf8Encoding_0.GetByteCount(text) : 0);
			@class.method_3(this.method_9(@class.method_4(), @class.method_6()));
			return @class.method_2();
		}
		case (Enum13)3:
		{
			Class192 class2 = (Class192)class191_0;
			int num = 4;
			foreach (Class200 class3 in class2)
			{
				int num2 = 1 + this.method_10(class3.Name);
				num2 += this.method_10(class3.Value);
				num += num2;
			}
			num++;
			class2.method_3(num);
			return num;
		}
		case (Enum13)4:
		{
			Class193 class4 = (Class193)class191_0;
			int num3 = 4;
			ulong num4 = 0UL;
			foreach (Class191 class191_ in class4)
			{
				num3++;
				num3 += this.method_8(Class79.smethod_0(num4));
				num3 += this.method_10(class191_);
				num4 += 1UL;
			}
			num3++;
			class4.method_3(num3);
			return class4.method_2();
		}
		case (Enum13)5:
		{
			Class198 class5 = (Class198)class191_0;
			byte[] array = (byte[])class5.Value;
			class5.method_3(5 + array.Length);
			return class5.method_2();
		}
		case (Enum13)6:
		case (Enum13)10:
			return 0;
		case (Enum13)7:
			return 12;
		case (Enum13)8:
			return 1;
		case (Enum13)9:
			return 8;
		case (Enum13)11:
		{
			Class199 class6 = (Class199)class191_0;
			int num5 = 0 + this.method_10(class6.Pattern);
			num5 += this.method_10(class6.Options);
			class6.method_3(num5);
			return class6.method_2();
		}
		case (Enum13)16:
			return 4;
		case (Enum13)18:
			return 8;
		}
		throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".smethod_0(CultureInfo.InvariantCulture, class191_0.Type));
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x0000DB71 File Offset: 0x0000BD71
	// Note: this type is marked as 'beforefieldinit'.
	static Class189()
	{
		Class202.ofdixO4zTbIfy();
		Class189.utf8Encoding_0 = new UTF8Encoding(false);
	}

	// Token: 0x04000798 RID: 1944
	private static readonly UTF8Encoding utf8Encoding_0;

	// Token: 0x04000799 RID: 1945
	private readonly BinaryWriter binaryWriter_0;

	// Token: 0x0400079A RID: 1946
	private byte[] byte_0;

	// Token: 0x0400079B RID: 1947
	[CompilerGenerated]
	private DateTimeKind dateTimeKind_0;
}
