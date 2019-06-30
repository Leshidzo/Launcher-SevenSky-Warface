using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x020001A9 RID: 425
internal class Class155
{
	// Token: 0x06000EC2 RID: 3778 RVA: 0x0000CB88 File Offset: 0x0000AD88
	[CompilerGenerated]
	public List<Class156> method_0()
	{
		return this.list_0;
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x0000CB90 File Offset: 0x0000AD90
	public Class155(string string_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		Class101.smethod_0(string_1, "expression");
		this.string_0 = string_1;
		this.list_0 = new List<Class156>();
		this.method_1();
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00044B8C File Offset: 0x00042D8C
	private void method_1()
	{
		int int_ = this.int_0;
		this.method_5();
		if (this.string_0.Length == this.int_0)
		{
			return;
		}
		if (this.string_0[this.int_0] == '$')
		{
			if (this.string_0.Length == 1)
			{
				return;
			}
			char c = this.string_0[this.int_0 + 1];
			if (c == '.' || c == '[')
			{
				this.int_0++;
				int_ = this.int_0;
			}
		}
		if (!this.method_2(this.method_0(), int_, false))
		{
			int index = this.int_0;
			this.method_5();
			if (this.int_0 < this.string_0.Length)
			{
				throw new JsonException("Unexpected character while parsing path: " + this.string_0[index].ToString());
			}
		}
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00044C68 File Offset: 0x00042E68
	private bool method_2(List<Class156> list_1, int int_1, bool bool_0)
	{
		bool bool_ = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		while (this.int_0 < this.string_0.Length && !flag3)
		{
			char c = this.string_0[this.int_0];
			if (c <= ')')
			{
				if (c != ' ')
				{
					if (c == '(')
					{
						goto IL_C3;
					}
					if (c == ')')
					{
						goto IL_BC;
					}
				}
				else
				{
					if (this.int_0 < this.string_0.Length)
					{
						flag3 = true;
						continue;
					}
					continue;
				}
			}
			else
			{
				if (c == '.')
				{
					if (this.int_0 > int_1)
					{
						string text = this.string_0.Substring(int_1, this.int_0 - int_1);
						if (text == "*")
						{
							text = null;
						}
						list_1.Add(Class155.smethod_0(text, bool_));
						bool_ = false;
					}
					if (this.int_0 + 1 < this.string_0.Length && this.string_0[this.int_0 + 1] == '.')
					{
						bool_ = true;
						this.int_0++;
					}
					this.int_0++;
					int_1 = this.int_0;
					flag = false;
					flag2 = true;
					continue;
				}
				if (c == '[')
				{
					goto IL_C3;
				}
				if (c == ']')
				{
					goto IL_BC;
				}
			}
			if (bool_0 && (c == '=' || c == '<' || c == '!' || c == '>' || c == '|' || c == '&'))
			{
				flag3 = true;
				continue;
			}
			if (!flag)
			{
				this.int_0++;
				continue;
			}
			throw new JsonException("Unexpected character following indexer: " + c.ToString());
			IL_BC:
			flag3 = true;
			continue;
			IL_C3:
			if (this.int_0 > int_1)
			{
				string text2 = this.string_0.Substring(int_1, this.int_0 - int_1);
				if (text2 == "*")
				{
					text2 = null;
				}
				list_1.Add(Class155.smethod_0(text2, bool_));
				bool_ = false;
			}
			list_1.Add(this.method_3(c, bool_));
			this.int_0++;
			int_1 = this.int_0;
			flag = true;
			flag2 = false;
		}
		bool flag4 = this.int_0 == this.string_0.Length;
		if (this.int_0 > int_1)
		{
			string text3 = this.string_0.Substring(int_1, this.int_0 - int_1).TrimEnd(new char[0]);
			if (text3 == "*")
			{
				text3 = null;
			}
			list_1.Add(Class155.smethod_0(text3, bool_));
		}
		else if (flag2 && (flag4 || bool_0))
		{
			throw new JsonException("Unexpected end while parsing path.");
		}
		return flag4;
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
	private static Class156 smethod_0(string string_1, bool bool_0)
	{
		if (!bool_0)
		{
			return new Class160
			{
				Name = string_1
			};
		}
		return new Class165
		{
			Name = string_1
		};
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00044EE4 File Offset: 0x000430E4
	private Class156 method_3(char char_1, bool bool_0)
	{
		this.int_0++;
		char char_2 = (char_1 == '[') ? ']' : ')';
		this.method_17("Path ended with open indexer.");
		this.method_5();
		if (this.string_0[this.int_0] == '\'')
		{
			return this.method_16(char_2, bool_0);
		}
		if (this.string_0[this.int_0] == '?')
		{
			return this.method_6(char_2, bool_0);
		}
		return this.method_4(char_2);
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00044F60 File Offset: 0x00043160
	private Class156 method_4(char char_1)
	{
		int num = this.int_0;
		int? num2 = null;
		List<int> list = null;
		int num3 = 0;
		int? nullable_ = null;
		int? nullable_2 = null;
		int? nullable_3 = null;
		while (this.int_0 < this.string_0.Length)
		{
			char c = this.string_0[this.int_0];
			if (c == ' ')
			{
				num2 = new int?(this.int_0);
				this.method_5();
			}
			else if (c == char_1)
			{
				int num4 = (num2 ?? this.int_0) - num;
				if (list != null)
				{
					if (num4 == 0)
					{
						throw new JsonException("Array index expected.");
					}
					int item = Convert.ToInt32(this.string_0.Substring(num, num4), CultureInfo.InvariantCulture);
					list.Add(item);
					Class158 @class = new Class158();
					@class.method_1(list);
					return @class;
				}
				else
				{
					if (num3 > 0)
					{
						if (num4 > 0)
						{
							int value = Convert.ToInt32(this.string_0.Substring(num, num4), CultureInfo.InvariantCulture);
							if (num3 == 1)
							{
								nullable_2 = new int?(value);
							}
							else
							{
								nullable_3 = new int?(value);
							}
						}
						Class159 class2 = new Class159();
						class2.method_1(nullable_);
						class2.method_3(nullable_2);
						class2.method_5(nullable_3);
						return class2;
					}
					if (num4 == 0)
					{
						throw new JsonException("Array index expected.");
					}
					int value2 = Convert.ToInt32(this.string_0.Substring(num, num4), CultureInfo.InvariantCulture);
					Class157 class3 = new Class157();
					class3.method_1(new int?(value2));
					return class3;
				}
			}
			else if (c == ',')
			{
				int num5 = (num2 ?? this.int_0) - num;
				if (num5 == 0)
				{
					throw new JsonException("Array index expected.");
				}
				if (list == null)
				{
					list = new List<int>();
				}
				string value3 = this.string_0.Substring(num, num5);
				list.Add(Convert.ToInt32(value3, CultureInfo.InvariantCulture));
				this.int_0++;
				this.method_5();
				num = this.int_0;
				num2 = null;
			}
			else if (c == '*')
			{
				this.int_0++;
				this.method_17("Path ended with open indexer.");
				this.method_5();
				if (this.string_0[this.int_0] != char_1)
				{
					throw new JsonException("Unexpected character while parsing path indexer: " + c.ToString());
				}
				return new Class157();
			}
			else if (c == ':')
			{
				int num6 = (num2 ?? this.int_0) - num;
				if (num6 > 0)
				{
					int value4 = Convert.ToInt32(this.string_0.Substring(num, num6), CultureInfo.InvariantCulture);
					if (num3 == 0)
					{
						nullable_ = new int?(value4);
					}
					else if (num3 == 1)
					{
						nullable_2 = new int?(value4);
					}
					else
					{
						nullable_3 = new int?(value4);
					}
				}
				num3++;
				this.int_0++;
				this.method_5();
				num = this.int_0;
				num2 = null;
			}
			else
			{
				if (!char.IsDigit(c) && c != '-')
				{
					throw new JsonException("Unexpected character while parsing path indexer: " + c.ToString());
				}
				if (num2 != null)
				{
					throw new JsonException("Unexpected character while parsing path indexer: " + c.ToString());
				}
				this.int_0++;
			}
		}
		throw new JsonException("Path ended with open indexer.");
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x0000CBDE File Offset: 0x0000ADDE
	private void method_5()
	{
		while (this.int_0 < this.string_0.Length && this.string_0[this.int_0] == ' ')
		{
			this.int_0++;
		}
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x000452C4 File Offset: 0x000434C4
	private Class156 method_6(char char_1, bool bool_0)
	{
		this.int_0++;
		this.method_17("Path ended with open indexer.");
		if (this.string_0[this.int_0] != '(')
		{
			throw new JsonException("Unexpected character while parsing path indexer: " + this.string_0[this.int_0].ToString());
		}
		this.int_0++;
		Class167 class167_ = this.method_10();
		this.int_0++;
		this.method_17("Path ended with open indexer.");
		this.method_5();
		if (this.string_0[this.int_0] != char_1)
		{
			throw new JsonException("Unexpected character while parsing path indexer: " + this.string_0[this.int_0].ToString());
		}
		if (!bool_0)
		{
			Class162 @class = new Class162();
			@class.method_1(class167_);
			return @class;
		}
		Class163 class2 = new Class163();
		class2.method_1(class167_);
		return class2;
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x000453B8 File Offset: 0x000435B8
	private bool method_7(out List<Class156> list_1)
	{
		if (this.string_0[this.int_0] == '$')
		{
			list_1 = new List<Class156>();
			list_1.Add(Class164.class164_0);
		}
		else
		{
			if (this.string_0[this.int_0] != '@')
			{
				list_1 = null;
				return false;
			}
			list_1 = new List<Class156>();
		}
		this.int_0++;
		if (this.method_2(list_1, this.int_0, true))
		{
			throw new JsonException("Path ended with open query.");
		}
		return true;
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x0004543C File Offset: 0x0004363C
	private JsonException method_8()
	{
		return new JsonException("Unexpected character while parsing path query: " + this.string_0[this.int_0].ToString());
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00045474 File Offset: 0x00043674
	private object method_9()
	{
		this.method_5();
		List<Class156> result;
		if (this.method_7(out result))
		{
			this.method_5();
			this.method_17("Path ended with open query.");
			return result;
		}
		object value;
		if (!this.method_11(out value))
		{
			throw this.method_8();
		}
		this.method_5();
		this.method_17("Path ended with open query.");
		return new JValue(value);
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x000454CC File Offset: 0x000436CC
	private Class167 method_10()
	{
		Class167 @class = null;
		Class168 class2 = null;
		while (this.int_0 < this.string_0.Length)
		{
			object object_ = this.method_9();
			object object_2 = null;
			if (this.string_0[this.int_0] == ')' || this.string_0[this.int_0] == '|')
			{
				goto IL_67;
			}
			if (this.string_0[this.int_0] == '&')
			{
				goto IL_67;
			}
			Enum10 enum10_ = this.method_15();
			object_2 = this.method_9();
			IL_6A:
			Class169 class3 = new Class169();
			class3.method_3(object_);
			class3.method_1(enum10_);
			class3.method_5(object_2);
			Class169 class4 = class3;
			if (this.string_0[this.int_0] == ')')
			{
				if (class2 != null)
				{
					class2.method_2().Add(class4);
					return @class;
				}
				return class4;
			}
			else
			{
				if (this.string_0[this.int_0] == '&')
				{
					if (!this.method_14("&&"))
					{
						throw this.method_8();
					}
					if (class2 == null || class2.method_0() != (Enum10)8)
					{
						Class168 class5 = new Class168();
						class5.method_1((Enum10)8);
						Class168 class6 = class5;
						if (class2 != null)
						{
							class2.method_2().Add(class6);
						}
						class2 = class6;
						if (@class == null)
						{
							@class = class2;
						}
					}
					class2.method_2().Add(class4);
				}
				if (this.string_0[this.int_0] != '|')
				{
					continue;
				}
				if (this.method_14("||"))
				{
					if (class2 == null || class2.method_0() != (Enum10)9)
					{
						Class168 class7 = new Class168();
						class7.method_1((Enum10)9);
						Class168 class8 = class7;
						if (class2 != null)
						{
							class2.method_2().Add(class8);
						}
						class2 = class8;
						if (@class == null)
						{
							@class = class2;
						}
					}
					class2.method_2().Add(class4);
					continue;
				}
				throw this.method_8();
			}
			IL_67:
			enum10_ = (Enum10)3;
			goto IL_6A;
		}
		throw new JsonException("Path ended with open query.");
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00045680 File Offset: 0x00043880
	private bool method_11(out object object_0)
	{
		char c = this.string_0[this.int_0];
		if (c == '\'')
		{
			object_0 = this.method_12();
			return true;
		}
		if (!char.IsDigit(c))
		{
			if (c != '-')
			{
				if (c == 't')
				{
					if (this.method_14("true"))
					{
						object_0 = true;
						return true;
					}
					goto IL_F9;
				}
				else if (c == 'f')
				{
					if (this.method_14("false"))
					{
						object_0 = false;
						return true;
					}
					goto IL_F9;
				}
				else if (c == 'n')
				{
					if (this.method_14("null"))
					{
						object_0 = null;
						return true;
					}
					goto IL_F9;
				}
				else
				{
					if (c == '/')
					{
						object_0 = this.method_13();
						return true;
					}
					goto IL_F9;
				}
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(c);
		this.int_0++;
		while (this.int_0 < this.string_0.Length)
		{
			c = this.string_0[this.int_0];
			if (c != ' ')
			{
				if (c != ')')
				{
					stringBuilder.Append(c);
					this.int_0++;
					continue;
				}
			}
			string text = stringBuilder.ToString();
			if (text.IndexOfAny(Class155.char_0) != -1)
			{
				double num;
				bool result = double.TryParse(text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num);
				object_0 = num;
				return result;
			}
			long num2;
			bool result2 = long.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out num2);
			object_0 = num2;
			return result2;
		}
		IL_F9:
		object_0 = null;
		return false;
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x000457D4 File Offset: 0x000439D4
	private string method_12()
	{
		StringBuilder stringBuilder = new StringBuilder();
		this.int_0++;
		while (this.int_0 < this.string_0.Length)
		{
			char c = this.string_0[this.int_0];
			if (c == '\\' && this.int_0 + 1 < this.string_0.Length)
			{
				this.int_0++;
				c = this.string_0[this.int_0];
				char value;
				if (c <= '\\')
				{
					if (c <= '\'')
					{
						if (c != '"' && c != '\'')
						{
							goto IL_125;
						}
					}
					else if (c != '/' && c != '\\')
					{
						goto IL_125;
					}
					value = c;
				}
				else if (c <= 'f')
				{
					if (c != 'b')
					{
						if (c != 'f')
						{
							goto IL_125;
						}
						value = '\f';
					}
					else
					{
						value = '\b';
					}
				}
				else if (c != 'n')
				{
					if (c != 'r')
					{
						if (c != 't')
						{
							goto IL_125;
						}
						value = '\t';
					}
					else
					{
						value = '\r';
					}
				}
				else
				{
					value = '\n';
				}
				stringBuilder.Append(value);
				this.int_0++;
				continue;
				IL_125:
				throw new JsonException("Unknown escape character: \\" + c.ToString());
			}
			if (c == '\'')
			{
				this.int_0++;
				return stringBuilder.ToString();
			}
			this.int_0++;
			stringBuilder.Append(c);
		}
		throw new JsonException("Path ended with an open string.");
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00045934 File Offset: 0x00043B34
	private string method_13()
	{
		int num = this.int_0;
		this.int_0++;
		while (this.int_0 < this.string_0.Length)
		{
			char c = this.string_0[this.int_0];
			if (c == '\\' && this.int_0 + 1 < this.string_0.Length)
			{
				this.int_0 += 2;
			}
			else
			{
				if (c == '/')
				{
					this.int_0++;
					while (this.int_0 < this.string_0.Length)
					{
						c = this.string_0[this.int_0];
						if (!char.IsLetter(c))
						{
							break;
						}
						this.int_0++;
					}
					return this.string_0.Substring(num, this.int_0 - num);
				}
				this.int_0++;
			}
		}
		throw new JsonException("Path ended with an open regex.");
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x00045A28 File Offset: 0x00043C28
	private bool method_14(string string_1)
	{
		int num = this.int_0;
		foreach (char c in string_1)
		{
			if (num >= this.string_0.Length || this.string_0[num] != c)
			{
				return false;
			}
			num++;
		}
		this.int_0 = num;
		return true;
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x00045A84 File Offset: 0x00043C84
	private Enum10 method_15()
	{
		if (this.int_0 + 1 >= this.string_0.Length)
		{
			throw new JsonException("Path ended with open query.");
		}
		if (this.method_14("==="))
		{
			return (Enum10)11;
		}
		if (this.method_14("=="))
		{
			return (Enum10)1;
		}
		if (this.method_14("=~"))
		{
			return (Enum10)10;
		}
		if (this.method_14("!=="))
		{
			return (Enum10)12;
		}
		if (this.method_14("!=") || this.method_14("<>"))
		{
			return (Enum10)2;
		}
		if (this.method_14("<="))
		{
			return (Enum10)5;
		}
		if (this.method_14("<"))
		{
			return (Enum10)4;
		}
		if (this.method_14(">="))
		{
			return (Enum10)7;
		}
		if (this.method_14(">"))
		{
			return (Enum10)6;
		}
		throw new JsonException("Could not read query operator.");
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00045B54 File Offset: 0x00043D54
	private Class156 method_16(char char_1, bool bool_0)
	{
		List<string> list = null;
		while (this.int_0 < this.string_0.Length)
		{
			string text = this.method_12();
			this.method_5();
			this.method_17("Path ended with open indexer.");
			if (this.string_0[this.int_0] == char_1)
			{
				if (list == null)
				{
					return Class155.smethod_0(text, bool_0);
				}
				list.Add(text);
				if (!bool_0)
				{
					Class161 @class = new Class161();
					@class.method_1(list);
					return @class;
				}
				Class166 class2 = new Class166();
				class2.method_1(list);
				return class2;
			}
			else
			{
				if (this.string_0[this.int_0] != ',')
				{
					throw new JsonException("Unexpected character while parsing path indexer: " + this.string_0[this.int_0].ToString());
				}
				this.int_0++;
				this.method_5();
				if (list == null)
				{
					list = new List<string>();
				}
				list.Add(text);
			}
		}
		throw new JsonException("Path ended with open indexer.");
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x0000CC19 File Offset: 0x0000AE19
	private void method_17(string string_1)
	{
		if (this.int_0 >= this.string_0.Length)
		{
			throw new JsonException(string_1);
		}
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x0000CC35 File Offset: 0x0000AE35
	internal IEnumerable<JToken> method_18(JToken jtoken_0, JToken jtoken_1, bool bool_0)
	{
		return Class155.smethod_1(this.method_0(), jtoken_0, jtoken_1, bool_0);
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00045C44 File Offset: 0x00043E44
	internal static IEnumerable<JToken> smethod_1(List<Class156> list_1, JToken jtoken_0, object object_0, bool bool_0)
	{
		IEnumerable<JToken> enumerable = new JToken[]
		{
			object_0
		};
		foreach (Class156 @class in list_1)
		{
			enumerable = @class.vmethod_0(jtoken_0, enumerable, bool_0);
		}
		return enumerable;
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x0000CC45 File Offset: 0x0000AE45
	// Note: this type is marked as 'beforefieldinit'.
	static Class155()
	{
		Class202.ofdixO4zTbIfy();
		Class155.char_0 = new char[]
		{
			'.',
			'E',
			'e'
		};
	}

	// Token: 0x04000739 RID: 1849
	private static readonly char[] char_0;

	// Token: 0x0400073A RID: 1850
	private readonly string string_0;

	// Token: 0x0400073B RID: 1851
	[CompilerGenerated]
	private readonly List<Class156> list_0;

	// Token: 0x0400073C RID: 1852
	private int int_0;
}
