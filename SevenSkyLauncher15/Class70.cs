using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Token: 0x020000DE RID: 222
internal static class Class70
{
	// Token: 0x060006E5 RID: 1765 RVA: 0x0002C998 File Offset: 0x0002AB98
	static Class70()
	{
		Class202.ofdixO4zTbIfy();
		Class70.bool_0 = new bool[128];
		Class70.bool_1 = new bool[128];
		Class70.bool_2 = new bool[128];
		IList<char> list = new List<char>
		{
			'\n',
			'\r',
			'\t',
			'\\',
			'\f',
			'\b'
		};
		for (int i = 0; i < 32; i++)
		{
			list.Add((char)i);
		}
		foreach (char c in list.Union(new char[]
		{
			'\''
		}))
		{
			Class70.bool_0[(int)c] = true;
		}
		foreach (char c2 in list.Union(new char[]
		{
			'"'
		}))
		{
			Class70.bool_1[(int)c2] = true;
		}
		foreach (char c3 in list.Union(new char[]
		{
			'"',
			'\'',
			'<',
			'>',
			'&'
		}))
		{
			Class70.bool_2[(int)c3] = true;
		}
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x000076F6 File Offset: 0x000058F6
	public static bool[] smethod_0(StringEscapeHandling stringEscapeHandling_0, char char_0)
	{
		if (stringEscapeHandling_0 == StringEscapeHandling.EscapeHtml)
		{
			return Class70.bool_2;
		}
		if (char_0 == '"')
		{
			return Class70.bool_1;
		}
		return Class70.bool_0;
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x0002CB0C File Offset: 0x0002AD0C
	public static bool smethod_1(string string_0, object object_0)
	{
		if (string_0 == null)
		{
			return false;
		}
		foreach (char c in string_0)
		{
			if ((int)c >= object_0.Length || object_0[(int)c])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x0002CB48 File Offset: 0x0002AD48
	public static void smethod_2(TextWriter textWriter_0, string string_0, char char_0, bool bool_3, object object_0, StringEscapeHandling stringEscapeHandling_0, IArrayPool<char> iarrayPool_0, ref char[] char_1)
	{
		if (bool_3)
		{
			textWriter_0.Write(char_0);
		}
		if (!string.IsNullOrEmpty(string_0))
		{
			int num = Class70.smethod_4(string_0, object_0, stringEscapeHandling_0);
			if (num == -1)
			{
				textWriter_0.Write(string_0);
			}
			else
			{
				if (num != 0)
				{
					if (char_1 == null || char_1.Length < num)
					{
						char_1 = Class69.smethod_2(iarrayPool_0, num, char_1);
					}
					string_0.CopyTo(0, char_1, 0, num);
					textWriter_0.Write(char_1, 0, num);
				}
				int num2;
				for (int i = num; i < string_0.Length; i++)
				{
					char c = string_0[i];
					if ((int)c >= object_0.Length || object_0[(int)c])
					{
						string text;
						if (c <= '\\')
						{
							switch (c)
							{
							case '\b':
								text = "\\b";
								break;
							case '\t':
								text = "\\t";
								break;
							case '\n':
								text = "\\n";
								break;
							case '\v':
								goto IL_10D;
							case '\f':
								text = "\\f";
								break;
							case '\r':
								text = "\\r";
								break;
							default:
								if (c != '\\')
								{
									goto IL_10D;
								}
								text = "\\\\";
								break;
							}
						}
						else if (c != '\u0085')
						{
							if (c != '\u2028')
							{
								if (c != '\u2029')
								{
									goto IL_10D;
								}
								text = "\\u2029";
							}
							else
							{
								text = "\\u2028";
							}
						}
						else
						{
							text = "\\u0085";
						}
						IL_185:
						if (text == null)
						{
							goto IL_229;
						}
						bool flag = string.Equals(text, "!", StringComparison.Ordinal);
						if (i > num)
						{
							num2 = i - num + (flag ? 6 : 0);
							int num3 = flag ? 6 : 0;
							if (char_1 == null || char_1.Length < num2)
							{
								char[] array = Class69.smethod_0(iarrayPool_0, num2);
								if (flag)
								{
									Array.Copy(char_1, array, 6);
								}
								Class69.smethod_1(iarrayPool_0, char_1);
								char_1 = array;
							}
							string_0.CopyTo(num, char_1, num3, num2 - num3);
							textWriter_0.Write(char_1, num3, num2 - num3);
						}
						num = i + 1;
						if (!flag)
						{
							textWriter_0.Write(text);
							goto IL_229;
						}
						textWriter_0.Write(char_1, 0, 6);
						goto IL_229;
						IL_10D:
						if ((int)c >= object_0.Length)
						{
							if (stringEscapeHandling_0 != StringEscapeHandling.EscapeNonAscii)
							{
								text = null;
								goto IL_185;
							}
						}
						if (c == '\'' && stringEscapeHandling_0 != StringEscapeHandling.EscapeHtml)
						{
							text = "\\'";
							goto IL_185;
						}
						if (c == '"' && stringEscapeHandling_0 != StringEscapeHandling.EscapeHtml)
						{
							text = "\\\"";
							goto IL_185;
						}
						if (char_1 == null || char_1.Length < 6)
						{
							char_1 = Class69.smethod_2(iarrayPool_0, 6, char_1);
						}
						Class97.smethod_7(c, char_1);
						text = "!";
						goto IL_185;
					}
					IL_229:;
				}
				num2 = string_0.Length - num;
				if (num2 > 0)
				{
					if (char_1 == null || char_1.Length < num2)
					{
						char_1 = Class69.smethod_2(iarrayPool_0, num2, char_1);
					}
					string_0.CopyTo(num, char_1, 0, num2);
					textWriter_0.Write(char_1, 0, num2);
				}
			}
		}
		if (bool_3)
		{
			textWriter_0.Write(char_0);
		}
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x0002CDE0 File Offset: 0x0002AFE0
	public static string smethod_3(string string_0, char char_0, bool bool_3, StringEscapeHandling stringEscapeHandling_0)
	{
		bool[] object_ = Class70.smethod_0(stringEscapeHandling_0, char_0);
		string result;
		using (StringWriter stringWriter = Class97.smethod_6((string_0 != null) ? string_0.Length : 16))
		{
			char[] array = null;
			Class70.smethod_2(stringWriter, string_0, char_0, bool_3, object_, stringEscapeHandling_0, null, ref array);
			result = stringWriter.ToString();
		}
		return result;
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x0002CE3C File Offset: 0x0002B03C
	private static int smethod_4(string string_0, object object_0, StringEscapeHandling stringEscapeHandling_0)
	{
		for (int num = 0; num != string_0.Length; num++)
		{
			char c = string_0[num];
			if ((int)c < object_0.Length)
			{
				if (object_0[(int)c])
				{
					return num;
				}
			}
			else
			{
				if (stringEscapeHandling_0 == StringEscapeHandling.EscapeNonAscii)
				{
					return num;
				}
				if (c != '\u0085' && c != '\u2028')
				{
					if (c != '\u2029')
					{
						goto IL_39;
					}
				}
				return num;
			}
			IL_39:;
		}
		return -1;
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x0002CE98 File Offset: 0x0002B098
	public static Task smethod_5(TextWriter textWriter_0, string string_0, char char_0, bool bool_3, bool[] bool_4, StringEscapeHandling stringEscapeHandling_0, JsonTextWriter jsonTextWriter_0, char[] char_1, CancellationToken cancellationToken_0 = default(CancellationToken))
	{
		if (cancellationToken_0.IsCancellationRequested)
		{
			return cancellationToken_0.smethod_2();
		}
		if (bool_3)
		{
			return Class70.smethod_6(textWriter_0, string_0, char_0, bool_4, stringEscapeHandling_0, jsonTextWriter_0, char_1, cancellationToken_0);
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return cancellationToken_0.XwtFhhOhvo() ?? Class15.task_2;
		}
		return Class70.smethod_9(textWriter_0, string_0, bool_4, stringEscapeHandling_0, jsonTextWriter_0, char_1, cancellationToken_0);
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
	private static Task smethod_6(TextWriter textWriter_0, string string_0, char char_0, bool[] bool_3, StringEscapeHandling stringEscapeHandling_0, JsonTextWriter jsonTextWriter_0, char[] char_1, CancellationToken cancellationToken_0)
	{
		Task task = textWriter_0.smethod_4(char_0, cancellationToken_0);
		if (!task.smethod_8())
		{
			return Class70.smethod_7(task, textWriter_0, string_0, char_0, bool_3, stringEscapeHandling_0, jsonTextWriter_0, char_1, cancellationToken_0);
		}
		if (!string.IsNullOrEmpty(string_0))
		{
			task = Class70.smethod_9(textWriter_0, string_0, bool_3, stringEscapeHandling_0, jsonTextWriter_0, char_1, cancellationToken_0);
			if (task.smethod_8())
			{
				return textWriter_0.smethod_4(char_0, cancellationToken_0);
			}
		}
		return Class70.smethod_8(task, textWriter_0, char_0, cancellationToken_0);
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x0002CF60 File Offset: 0x0002B160
	private static async Task smethod_7(Task task_0, TextWriter textWriter_0, string string_0, char char_0, bool[] bool_3, StringEscapeHandling stringEscapeHandling_0, JsonTextWriter jsonTextWriter_0, char[] char_1, CancellationToken cancellationToken_0)
	{
		await task_0.ConfigureAwait(false);
		if (!string.IsNullOrEmpty(string_0))
		{
			await Class70.smethod_9(textWriter_0, string_0, bool_3, stringEscapeHandling_0, jsonTextWriter_0, char_1, cancellationToken_0).ConfigureAwait(false);
		}
		await textWriter_0.WriteAsync(char_0).ConfigureAwait(false);
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x0002CFEC File Offset: 0x0002B1EC
	public static async Task smethod_8(Task task_0, TextWriter textWriter_0, char char_0, CancellationToken cancellationToken_0)
	{
		ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter = task_0.ConfigureAwait(false).GetAwaiter();
		ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter2;
		if (!configuredTaskAwaiter.IsCompleted)
		{
			await configuredTaskAwaiter;
			configuredTaskAwaiter = configuredTaskAwaiter2;
			configuredTaskAwaiter2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
		}
		configuredTaskAwaiter.GetResult();
		configuredTaskAwaiter = textWriter_0.smethod_4(char_0, cancellationToken_0).ConfigureAwait(false).GetAwaiter();
		if (!configuredTaskAwaiter.IsCompleted)
		{
			await configuredTaskAwaiter;
			configuredTaskAwaiter = configuredTaskAwaiter2;
			configuredTaskAwaiter2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
		}
		configuredTaskAwaiter.GetResult();
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x0002D04C File Offset: 0x0002B24C
	private static Task smethod_9(TextWriter textWriter_0, string string_0, bool[] bool_3, StringEscapeHandling stringEscapeHandling_0, JsonTextWriter jsonTextWriter_0, char[] char_0, CancellationToken cancellationToken_0)
	{
		int num = Class70.smethod_4(string_0, bool_3, stringEscapeHandling_0);
		if (num != -1)
		{
			return Class70.smethod_10(textWriter_0, string_0, num, bool_3, stringEscapeHandling_0, jsonTextWriter_0, char_0, cancellationToken_0);
		}
		return textWriter_0.smethod_5(string_0, cancellationToken_0);
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x0002D080 File Offset: 0x0002B280
	private static async Task smethod_10(TextWriter textWriter_0, string string_0, int int_0, bool[] bool_3, StringEscapeHandling stringEscapeHandling_0, JsonTextWriter jsonTextWriter_0, char[] char_0, CancellationToken cancellationToken_0)
	{
		if (char_0 == null || char_0.Length < int_0)
		{
			char_0 = jsonTextWriter_0.method_95(int_0, 6);
		}
		if (int_0 != 0)
		{
			string_0.CopyTo(0, char_0, 0, int_0);
			await textWriter_0.smethod_6(char_0, 0, int_0, cancellationToken_0).ConfigureAwait(false);
		}
		bool isEscapedUnicodeText = false;
		string escapedValue = null;
		int num;
		ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter2;
		for (int i = int_0; i < string_0.Length; i++)
		{
			char c = string_0[i];
			if ((int)c >= bool_3.Length || bool_3[(int)c])
			{
				if (c <= '\\')
				{
					switch (c)
					{
					case '\b':
						escapedValue = "\\b";
						goto IL_308;
					case '\t':
						escapedValue = "\\t";
						goto IL_308;
					case '\n':
						escapedValue = "\\n";
						goto IL_308;
					case '\v':
						break;
					case '\f':
						escapedValue = "\\f";
						goto IL_308;
					case '\r':
						escapedValue = "\\r";
						goto IL_308;
					default:
						if (c == '\\')
						{
							escapedValue = "\\\\";
							goto IL_308;
						}
						break;
					}
				}
				else
				{
					if (c == '\u0085')
					{
						escapedValue = "\\u0085";
						goto IL_308;
					}
					if (c == '\u2028')
					{
						escapedValue = "\\u2028";
						goto IL_308;
					}
					if (c == '\u2029')
					{
						escapedValue = "\\u2029";
						goto IL_308;
					}
				}
				if ((int)c >= bool_3.Length && stringEscapeHandling_0 != StringEscapeHandling.EscapeNonAscii)
				{
					goto IL_410;
				}
				if (c == '\'' && stringEscapeHandling_0 != StringEscapeHandling.EscapeHtml)
				{
					escapedValue = "\\'";
				}
				else if (c == '"' && stringEscapeHandling_0 != StringEscapeHandling.EscapeHtml)
				{
					escapedValue = "\\\"";
				}
				else
				{
					if (char_0.Length < 6)
					{
						char_0 = jsonTextWriter_0.method_95(6, 0);
					}
					Class97.smethod_7(c, char_0);
					isEscapedUnicodeText = true;
				}
				IL_308:
				if (i > int_0)
				{
					num = i - int_0 + (isEscapedUnicodeText ? 6 : 0);
					int num2 = isEscapedUnicodeText ? 6 : 0;
					if (char_0.Length < num)
					{
						char_0 = jsonTextWriter_0.method_95(num, 6);
					}
					string_0.CopyTo(int_0, char_0, num2, num - num2);
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter = textWriter_0.smethod_6(char_0, num2, num - num2, cancellationToken_0).ConfigureAwait(false).GetAwaiter();
					if (!configuredTaskAwaiter.IsCompleted)
					{
						await configuredTaskAwaiter;
						configuredTaskAwaiter = configuredTaskAwaiter2;
						configuredTaskAwaiter2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					}
					configuredTaskAwaiter.GetResult();
				}
				int_0 = i + 1;
				if (!isEscapedUnicodeText)
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter = textWriter_0.smethod_5(escapedValue, cancellationToken_0).ConfigureAwait(false).GetAwaiter();
					if (!configuredTaskAwaiter.IsCompleted)
					{
						await configuredTaskAwaiter;
						configuredTaskAwaiter = configuredTaskAwaiter2;
						configuredTaskAwaiter2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					}
					configuredTaskAwaiter.GetResult();
				}
				else
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter = textWriter_0.smethod_6(char_0, 0, 6, cancellationToken_0).ConfigureAwait(false).GetAwaiter();
					if (!configuredTaskAwaiter.IsCompleted)
					{
						await configuredTaskAwaiter;
						configuredTaskAwaiter = configuredTaskAwaiter2;
						configuredTaskAwaiter2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					}
					configuredTaskAwaiter.GetResult();
					isEscapedUnicodeText = false;
				}
			}
			IL_410:;
		}
		num = string_0.Length - int_0;
		if (num != 0)
		{
			if (char_0.Length < num)
			{
				char_0 = jsonTextWriter_0.method_95(num, 0);
			}
			string_0.CopyTo(int_0, char_0, 0, num);
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter configuredTaskAwaiter = textWriter_0.smethod_6(char_0, 0, num, cancellationToken_0).ConfigureAwait(false).GetAwaiter();
			if (!configuredTaskAwaiter.IsCompleted)
			{
				await configuredTaskAwaiter;
				configuredTaskAwaiter = configuredTaskAwaiter2;
				configuredTaskAwaiter2 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
			}
			configuredTaskAwaiter.GetResult();
		}
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x0002D104 File Offset: 0x0002B304
	public static bool smethod_11(JsonReader jsonReader_0, out DateTime dateTime_0, out string string_0)
	{
		dateTime_0 = default(DateTime);
		string_0 = null;
		long? num;
		if (!Class70.smethod_12(jsonReader_0, out num, out string_0) || num == null)
		{
			string_0 = (string_0 ?? "Date constructor has no arguments.");
			return false;
		}
		long? num2;
		if (!Class70.smethod_12(jsonReader_0, out num2, out string_0))
		{
			return false;
		}
		if (num2 != null)
		{
			List<long> list = new List<long>
			{
				num.Value,
				num2.Value
			};
			long? num3;
			while (Class70.smethod_12(jsonReader_0, out num3, out string_0))
			{
				if (num3 != null)
				{
					list.Add(num3.Value);
				}
				else
				{
					if (list.Count > 7)
					{
						string_0 = "Unexpected number of arguments when reading date constructor.";
						return false;
					}
					while (list.Count < 7)
					{
						list.Add(0L);
					}
					dateTime_0 = new DateTime((int)list[0], (int)list[1] + 1, (list[2] == 0L) ? 1 : ((int)list[2]), (int)list[3], (int)list[4], (int)list[5], (int)list[6]);
					return true;
				}
			}
			return false;
		}
		dateTime_0 = Class25.smethod_11(num.Value);
		return true;
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x0002D234 File Offset: 0x0002B434
	private static bool smethod_12(JsonReader jsonReader_0, out long? nullable_0, out string string_0)
	{
		nullable_0 = null;
		string_0 = null;
		if (!jsonReader_0.Read())
		{
			string_0 = "Unexpected end when reading date constructor.";
			return false;
		}
		if (jsonReader_0.TokenType == JsonToken.EndConstructor)
		{
			return true;
		}
		if (jsonReader_0.TokenType != JsonToken.Integer)
		{
			string_0 = "Unexpected token when reading date constructor. Expected Integer, got " + jsonReader_0.TokenType;
			return false;
		}
		nullable_0 = new long?((long)jsonReader_0.Value);
		return true;
	}

	// Token: 0x0400044F RID: 1103
	internal static readonly bool[] bool_0;

	// Token: 0x04000450 RID: 1104
	internal static readonly bool[] bool_1;

	// Token: 0x04000451 RID: 1105
	internal static readonly bool[] bool_2;
}
