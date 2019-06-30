using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;

// Token: 0x02000188 RID: 392
internal class Class152 : Collection<JToken>
{
	// Token: 0x06000D07 RID: 3335 RVA: 0x0000B9FB File Offset: 0x00009BFB
	public Class152()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(new List<JToken>());
	}

	// Token: 0x06000D08 RID: 3336 RVA: 0x0000BA0D File Offset: 0x00009C0D
	private void method_0(string string_0, JToken jtoken_0)
	{
		this.method_4();
		this.dictionary_0[string_0] = jtoken_0;
	}

	// Token: 0x06000D09 RID: 3337 RVA: 0x0003F720 File Offset: 0x0003D920
	protected void method_1(JToken jtoken_0, string string_0)
	{
		if (!this.method_3(jtoken_0))
		{
			throw new ArgumentException("The specified item does not exist in this KeyedCollection.");
		}
		string text = this.method_5(jtoken_0);
		if (!Class152.iequalityComparer_0.Equals(text, string_0))
		{
			if (string_0 != null)
			{
				this.method_0(string_0, jtoken_0);
			}
			if (text != null)
			{
				this.method_7(text);
			}
		}
	}

	// Token: 0x06000D0A RID: 3338 RVA: 0x0000BA22 File Offset: 0x00009C22
	protected override void ClearItems()
	{
		base.ClearItems();
		Dictionary<string, JToken> dictionary = this.dictionary_0;
		if (dictionary == null)
		{
			return;
		}
		dictionary.Clear();
	}

	// Token: 0x06000D0B RID: 3339 RVA: 0x0000BA3A File Offset: 0x00009C3A
	public bool method_2(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("key");
		}
		return this.dictionary_0 != null && this.dictionary_0.ContainsKey(string_0);
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x0003F76C File Offset: 0x0003D96C
	private bool method_3(JToken jtoken_0)
	{
		if (this.dictionary_0 == null)
		{
			return false;
		}
		string key = this.method_5(jtoken_0);
		JToken jtoken;
		return this.dictionary_0.TryGetValue(key, out jtoken);
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x0000BA60 File Offset: 0x00009C60
	private void method_4()
	{
		if (this.dictionary_0 == null)
		{
			this.dictionary_0 = new Dictionary<string, JToken>(Class152.iequalityComparer_0);
		}
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x0000BA7A File Offset: 0x00009C7A
	private string method_5(JToken jtoken_0)
	{
		return ((JProperty)jtoken_0).Name;
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x0000BA87 File Offset: 0x00009C87
	protected override void InsertItem(int index, JToken item)
	{
		this.method_0(this.method_5(item), item);
		base.InsertItem(index, item);
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x0003F79C File Offset: 0x0003D99C
	public bool method_6(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("key");
		}
		JToken item;
		return this.dictionary_0 != null && this.dictionary_0.TryGetValue(string_0, out item) && base.Remove(item);
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x0003F7DC File Offset: 0x0003D9DC
	protected override void RemoveItem(int index)
	{
		string string_ = this.method_5(base.Items[index]);
		this.method_7(string_);
		base.RemoveItem(index);
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x0000BA9F File Offset: 0x00009C9F
	private void method_7(string string_0)
	{
		Dictionary<string, JToken> dictionary = this.dictionary_0;
		if (dictionary == null)
		{
			return;
		}
		dictionary.Remove(string_0);
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x0003F80C File Offset: 0x0003DA0C
	protected override void SetItem(int index, JToken item)
	{
		string text = this.method_5(item);
		string text2 = this.method_5(base.Items[index]);
		if (Class152.iequalityComparer_0.Equals(text2, text))
		{
			if (this.dictionary_0 != null)
			{
				this.dictionary_0[text] = item;
			}
		}
		else
		{
			this.method_0(text, item);
			if (text2 != null)
			{
				this.method_7(text2);
			}
		}
		base.SetItem(index, item);
	}

	// Token: 0x170001BD RID: 445
	public JToken this[string string_0]
	{
		get
		{
			if (string_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			if (this.dictionary_0 == null)
			{
				throw new KeyNotFoundException();
			}
			return this.dictionary_0[string_0];
		}
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x0000BADD File Offset: 0x00009CDD
	public bool method_8(string string_0, out JToken jtoken_0)
	{
		if (this.dictionary_0 == null)
		{
			jtoken_0 = null;
			return false;
		}
		return this.dictionary_0.TryGetValue(string_0, out jtoken_0);
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x0000BAF9 File Offset: 0x00009CF9
	public ICollection<string> method_9()
	{
		this.method_4();
		return this.dictionary_0.Keys;
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x0000BB0C File Offset: 0x00009D0C
	public ICollection<JToken> method_10()
	{
		this.method_4();
		return this.dictionary_0.Values;
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x0000BB1F File Offset: 0x00009D1F
	public int method_11(JToken jtoken_0)
	{
		return ((List<JToken>)base.Items).smethod_11(jtoken_0);
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x0003F874 File Offset: 0x0003DA74
	public bool method_12(Class152 class152_0)
	{
		if (this == class152_0)
		{
			return true;
		}
		Dictionary<string, JToken> dictionary = this.dictionary_0;
		Dictionary<string, JToken> dictionary2 = class152_0.dictionary_0;
		if (dictionary == null && dictionary2 == null)
		{
			return true;
		}
		if (dictionary == null)
		{
			return dictionary2.Count == 0;
		}
		if (dictionary2 == null)
		{
			return dictionary.Count == 0;
		}
		if (dictionary.Count != dictionary2.Count)
		{
			return false;
		}
		foreach (KeyValuePair<string, JToken> keyValuePair in dictionary)
		{
			JToken jtoken;
			if (!dictionary2.TryGetValue(keyValuePair.Key, out jtoken))
			{
				return false;
			}
			JProperty jproperty = (JProperty)keyValuePair.Value;
			JProperty jproperty2 = (JProperty)jtoken;
			if (jproperty.Value == null)
			{
				return jproperty2.Value == null;
			}
			if (!jproperty.Value.DeepEquals(jproperty2.Value))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x0000BB32 File Offset: 0x00009D32
	// Note: this type is marked as 'beforefieldinit'.
	static Class152()
	{
		Class202.ofdixO4zTbIfy();
		Class152.iequalityComparer_0 = StringComparer.Ordinal;
	}

	// Token: 0x04000686 RID: 1670
	private static readonly IEqualityComparer<string> iequalityComparer_0;

	// Token: 0x04000687 RID: 1671
	private Dictionary<string, JToken> dictionary_0;
}
