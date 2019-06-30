using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020000B0 RID: 176
internal class Class26<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a> : IDictionary<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>, ICollection<KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>>, IEnumerable<KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>>, ICollection, IEnumerable, IDictionary, Interface1
{
	// Token: 0x060005F0 RID: 1520 RVA: 0x00006B7E File Offset: 0x00004D7E
	public Class26(IDictionary idictionary_2)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		Class101.smethod_0(idictionary_2, "dictionary");
		this.idictionary_0 = idictionary_2;
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00006B9D File Offset: 0x00004D9D
	public Class26(IDictionary<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a> idictionary_2)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		Class101.smethod_0(idictionary_2, "dictionary");
		this.idictionary_1 = idictionary_2;
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00006BBC File Offset: 0x00004DBC
	public Class26(IReadOnlyDictionary<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a> ireadOnlyDictionary_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		Class101.smethod_0(ireadOnlyDictionary_1, "dictionary");
		this.ireadOnlyDictionary_0 = ireadOnlyDictionary_1;
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x00006BDB File Offset: 0x00004DDB
	public void Add(R5AdwmQsdjSNLWUOxm7 YW6o1EQI2ZqpwKTGxDa, l1iOgsQXOhtH2kAa19a UciYdUQvQig6t0aWRJq)
	{
		if (this.idictionary_0 != null)
		{
			this.idictionary_0.Add(YW6o1EQI2ZqpwKTGxDa, UciYdUQvQig6t0aWRJq);
			return;
		}
		if (this.idictionary_1 == null)
		{
			throw new NotSupportedException();
		}
		this.idictionary_1.Add(YW6o1EQI2ZqpwKTGxDa, UciYdUQvQig6t0aWRJq);
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x00006C18 File Offset: 0x00004E18
	public bool ContainsKey(R5AdwmQsdjSNLWUOxm7 IVQ944QcaCIynDH00mE)
	{
		if (this.idictionary_0 != null)
		{
			return this.idictionary_0.Contains(IVQ944QcaCIynDH00mE);
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			return this.ireadOnlyDictionary_0.ContainsKey(IVQ944QcaCIynDH00mE);
		}
		return this.idictionary_1.ContainsKey(IVQ944QcaCIynDH00mE);
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00029B00 File Offset: 0x00027D00
	public ICollection<R5AdwmQsdjSNLWUOxm7> Keys
	{
		get
		{
			if (this.idictionary_0 != null)
			{
				return this.idictionary_0.Keys.Cast<R5AdwmQsdjSNLWUOxm7>().ToList<R5AdwmQsdjSNLWUOxm7>();
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				return this.ireadOnlyDictionary_0.Keys.ToList<R5AdwmQsdjSNLWUOxm7>();
			}
			return this.idictionary_1.Keys;
		}
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x00029B50 File Offset: 0x00027D50
	public bool Remove(R5AdwmQsdjSNLWUOxm7 E0o5QdQAkWyXAVp4381)
	{
		if (this.idictionary_0 != null)
		{
			if (this.idictionary_0.Contains(E0o5QdQAkWyXAVp4381))
			{
				this.idictionary_0.Remove(E0o5QdQAkWyXAVp4381);
				return true;
			}
			return false;
		}
		else
		{
			if (this.ireadOnlyDictionary_0 != null)
			{
				throw new NotSupportedException();
			}
			return this.idictionary_1.Remove(E0o5QdQAkWyXAVp4381);
		}
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x00029BA8 File Offset: 0x00027DA8
	public bool TryGetValue(R5AdwmQsdjSNLWUOxm7 axcmldQ7Nly2JFeKuJK, out l1iOgsQXOhtH2kAa19a value)
	{
		if (this.idictionary_0 != null)
		{
			if (!this.idictionary_0.Contains(axcmldQ7Nly2JFeKuJK))
			{
				value = default(l1iOgsQXOhtH2kAa19a);
				return false;
			}
			value = (l1iOgsQXOhtH2kAa19a)((object)this.idictionary_0[axcmldQ7Nly2JFeKuJK]);
			return true;
		}
		else
		{
			if (this.ireadOnlyDictionary_0 != null)
			{
				throw new NotSupportedException();
			}
			return this.idictionary_1.TryGetValue(axcmldQ7Nly2JFeKuJK, out value);
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00029C14 File Offset: 0x00027E14
	public ICollection<l1iOgsQXOhtH2kAa19a> Values
	{
		get
		{
			if (this.idictionary_0 != null)
			{
				return this.idictionary_0.Values.Cast<l1iOgsQXOhtH2kAa19a>().ToList<l1iOgsQXOhtH2kAa19a>();
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				return this.ireadOnlyDictionary_0.Values.ToList<l1iOgsQXOhtH2kAa19a>();
			}
			return this.idictionary_1.Values;
		}
	}

	// Token: 0x170000BE RID: 190
	public l1iOgsQXOhtH2kAa19a this[R5AdwmQsdjSNLWUOxm7 YXoK3BQrxMHkO4qwSRB]
	{
		get
		{
			if (this.idictionary_0 != null)
			{
				return (l1iOgsQXOhtH2kAa19a)((object)this.idictionary_0[YXoK3BQrxMHkO4qwSRB]);
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				return this.ireadOnlyDictionary_0[YXoK3BQrxMHkO4qwSRB];
			}
			return this.idictionary_1[YXoK3BQrxMHkO4qwSRB];
		}
		set
		{
			if (this.idictionary_0 != null)
			{
				this.idictionary_0[WFT5hPQfvAfv1Jlu3Re] = value;
				return;
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				throw new NotSupportedException();
			}
			this.idictionary_1[WFT5hPQfvAfv1Jlu3Re] = value;
		}
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00029CB4 File Offset: 0x00027EB4
	public void Add(KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a> item)
	{
		if (this.idictionary_0 != null)
		{
			((IList)this.idictionary_0).Add(item);
			return;
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			throw new NotSupportedException();
		}
		IDictionary<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a> dictionary = this.idictionary_1;
		if (dictionary == null)
		{
			return;
		}
		dictionary.Add(item);
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00006C92 File Offset: 0x00004E92
	public void Clear()
	{
		if (this.idictionary_0 != null)
		{
			this.idictionary_0.Clear();
			return;
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			throw new NotSupportedException();
		}
		this.idictionary_1.Clear();
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00029D00 File Offset: 0x00027F00
	public bool Contains(KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a> item)
	{
		if (this.idictionary_0 != null)
		{
			return ((IList)this.idictionary_0).Contains(item);
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			return this.ireadOnlyDictionary_0.Contains(item);
		}
		return this.idictionary_1.Contains(item);
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00029D50 File Offset: 0x00027F50
	public void CopyTo(KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>[] array, int arrayIndex)
	{
		if (this.idictionary_0 != null)
		{
			using (IDictionaryEnumerator enumerator = this.idictionary_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DictionaryEntry entry = enumerator.Entry;
					array[arrayIndex++] = new KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>((R5AdwmQsdjSNLWUOxm7)((object)entry.Key), (l1iOgsQXOhtH2kAa19a)((object)entry.Value));
				}
				return;
			}
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			throw new NotSupportedException();
		}
		this.idictionary_1.CopyTo(array, arrayIndex);
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060005FF RID: 1535 RVA: 0x00006CC1 File Offset: 0x00004EC1
	public int Count
	{
		get
		{
			if (this.idictionary_0 != null)
			{
				return this.idictionary_0.Count;
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				return this.ireadOnlyDictionary_0.Count;
			}
			return this.idictionary_1.Count;
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000600 RID: 1536 RVA: 0x00006CF6 File Offset: 0x00004EF6
	public bool IsReadOnly
	{
		get
		{
			if (this.idictionary_0 != null)
			{
				return this.idictionary_0.IsReadOnly;
			}
			return this.ireadOnlyDictionary_0 != null || this.idictionary_1.IsReadOnly;
		}
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00029DEC File Offset: 0x00027FEC
	public bool Remove(KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a> item)
	{
		if (this.idictionary_0 != null)
		{
			if (!this.idictionary_0.Contains(item.Key))
			{
				return true;
			}
			if (object.Equals(this.idictionary_0[item.Key], item.Value))
			{
				this.idictionary_0.Remove(item.Key);
				return true;
			}
			return false;
		}
		else
		{
			if (this.ireadOnlyDictionary_0 != null)
			{
				throw new NotSupportedException();
			}
			return this.idictionary_1.Remove(item);
		}
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00029E7C File Offset: 0x0002807C
	public IEnumerator<KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>> GetEnumerator()
	{
		if (this.idictionary_0 != null)
		{
			return this.idictionary_0.Cast<DictionaryEntry>().Select(new Func<DictionaryEntry, KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>>(Class26<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>.Class27.class27_0.method_0)).GetEnumerator();
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			return this.ireadOnlyDictionary_0.GetEnumerator();
		}
		return this.idictionary_1.GetEnumerator();
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00006D21 File Offset: 0x00004F21
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00006D29 File Offset: 0x00004F29
	void IDictionary.Add(object key, object value)
	{
		if (this.idictionary_0 != null)
		{
			this.idictionary_0.Add(key, value);
			return;
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			throw new NotSupportedException();
		}
		this.idictionary_1.Add((R5AdwmQsdjSNLWUOxm7)((object)key), (l1iOgsQXOhtH2kAa19a)((object)value));
	}

	// Token: 0x170000C1 RID: 193
	object IDictionary.this[object key]
	{
		get
		{
			if (this.idictionary_0 != null)
			{
				return this.idictionary_0[key];
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				return this.ireadOnlyDictionary_0[(R5AdwmQsdjSNLWUOxm7)((object)key)];
			}
			return this.idictionary_1[(R5AdwmQsdjSNLWUOxm7)((object)key)];
		}
		set
		{
			if (this.idictionary_0 != null)
			{
				this.idictionary_0[key] = value;
				return;
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				throw new NotSupportedException();
			}
			this.idictionary_1[(R5AdwmQsdjSNLWUOxm7)((object)key)] = (l1iOgsQXOhtH2kAa19a)((object)value);
		}
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00029F40 File Offset: 0x00028140
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		if (this.idictionary_0 != null)
		{
			return this.idictionary_0.GetEnumerator();
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			return new Class26<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>.Struct6<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>(this.ireadOnlyDictionary_0.GetEnumerator());
		}
		return new Class26<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>.Struct6<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>(this.idictionary_1.GetEnumerator());
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00029F94 File Offset: 0x00028194
	bool IDictionary.Contains(object key)
	{
		if (this.idictionary_1 != null)
		{
			return this.idictionary_1.ContainsKey((R5AdwmQsdjSNLWUOxm7)((object)key));
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			return this.ireadOnlyDictionary_0.ContainsKey((R5AdwmQsdjSNLWUOxm7)((object)key));
		}
		return this.idictionary_0.Contains(key);
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000609 RID: 1545 RVA: 0x00006DA3 File Offset: 0x00004FA3
	bool IDictionary.IsFixedSize
	{
		get
		{
			return this.idictionary_1 == null && (this.ireadOnlyDictionary_0 != null || this.idictionary_0.IsFixedSize);
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x0600060A RID: 1546 RVA: 0x00006DC4 File Offset: 0x00004FC4
	ICollection IDictionary.Keys
	{
		get
		{
			if (this.idictionary_1 != null)
			{
				return this.idictionary_1.Keys.ToList<R5AdwmQsdjSNLWUOxm7>();
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				return this.ireadOnlyDictionary_0.Keys.ToList<R5AdwmQsdjSNLWUOxm7>();
			}
			return this.idictionary_0.Keys;
		}
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00006E03 File Offset: 0x00005003
	public void Remove(object key)
	{
		if (this.idictionary_0 != null)
		{
			this.idictionary_0.Remove(key);
			return;
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			throw new NotSupportedException();
		}
		this.idictionary_1.Remove((R5AdwmQsdjSNLWUOxm7)((object)key));
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x0600060C RID: 1548 RVA: 0x00006E3A File Offset: 0x0000503A
	ICollection IDictionary.Values
	{
		get
		{
			if (this.idictionary_1 != null)
			{
				return this.idictionary_1.Values.ToList<l1iOgsQXOhtH2kAa19a>();
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				return this.ireadOnlyDictionary_0.Values.ToList<l1iOgsQXOhtH2kAa19a>();
			}
			return this.idictionary_0.Values;
		}
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00006E79 File Offset: 0x00005079
	void ICollection.CopyTo(Array array, int index)
	{
		if (this.idictionary_0 != null)
		{
			this.idictionary_0.CopyTo(array, index);
			return;
		}
		if (this.ireadOnlyDictionary_0 != null)
		{
			throw new NotSupportedException();
		}
		this.idictionary_1.CopyTo((KeyValuePair<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a>[])array, index);
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x0600060E RID: 1550 RVA: 0x00006EB1 File Offset: 0x000050B1
	bool ICollection.IsSynchronized
	{
		get
		{
			return this.idictionary_0 != null && this.idictionary_0.IsSynchronized;
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x0600060F RID: 1551 RVA: 0x00006EC8 File Offset: 0x000050C8
	object ICollection.SyncRoot
	{
		get
		{
			if (this.object_0 == null)
			{
				Interlocked.CompareExchange(ref this.object_0, new object(), null);
			}
			return this.object_0;
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06000610 RID: 1552 RVA: 0x00006EEA File Offset: 0x000050EA
	public object UnderlyingDictionary
	{
		get
		{
			if (this.idictionary_0 != null)
			{
				return this.idictionary_0;
			}
			if (this.ireadOnlyDictionary_0 != null)
			{
				return this.ireadOnlyDictionary_0;
			}
			return this.idictionary_1;
		}
	}

	// Token: 0x040003EC RID: 1004
	private readonly IDictionary idictionary_0;

	// Token: 0x040003ED RID: 1005
	private readonly IDictionary<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a> idictionary_1;

	// Token: 0x040003EE RID: 1006
	private readonly IReadOnlyDictionary<R5AdwmQsdjSNLWUOxm7, l1iOgsQXOhtH2kAa19a> ireadOnlyDictionary_0;

	// Token: 0x040003EF RID: 1007
	private object object_0;

	// Token: 0x020000B1 RID: 177
	private readonly struct Struct6<RktPpgy3Mc0rFHRvDLG, HylOyyyGSxJoI5PLGDs> : IEnumerator, IDictionaryEnumerator
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x00006F10 File Offset: 0x00005110
		public Struct6(IEnumerator<KeyValuePair<RktPpgy3Mc0rFHRvDLG, HylOyyyGSxJoI5PLGDs>> ienumerator_1)
		{
			Class202.ofdixO4zTbIfy();
			Class101.smethod_0(ienumerator_1, "e");
			this.ienumerator_0 = ienumerator_1;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00006F29 File Offset: 0x00005129
		public DictionaryEntry Entry
		{
			get
			{
				return (DictionaryEntry)this.Current;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00029FE4 File Offset: 0x000281E4
		public object Key
		{
			get
			{
				return this.Entry.Key;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0002A000 File Offset: 0x00028200
		public object Value
		{
			get
			{
				return this.Entry.Value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0002A01C File Offset: 0x0002821C
		public object Current
		{
			get
			{
				KeyValuePair<RktPpgy3Mc0rFHRvDLG, HylOyyyGSxJoI5PLGDs> keyValuePair = this.ienumerator_0.Current;
				object key = keyValuePair.Key;
				keyValuePair = this.ienumerator_0.Current;
				return new DictionaryEntry(key, keyValuePair.Value);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00006F36 File Offset: 0x00005136
		public bool MoveNext()
		{
			return this.ienumerator_0.MoveNext();
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00006F43 File Offset: 0x00005143
		public void Reset()
		{
			this.ienumerator_0.Reset();
		}

		// Token: 0x040003F0 RID: 1008
		private readonly IEnumerator<KeyValuePair<RktPpgy3Mc0rFHRvDLG, HylOyyyGSxJoI5PLGDs>> ienumerator_0;
	}

	// Token: 0x020000B2 RID: 178
	[CompilerGenerated]
	[Serializable]
	private sealed class Class27
	{
		// Token: 0x06000618 RID: 1560 RVA: 0x00006F50 File Offset: 0x00005150
		// Note: this type is marked as 'beforefieldinit'.
		static Class27()
		{
			Class202.ofdixO4zTbIfy();
			Class26<fmZKx8yjAxhooYjMv4w, VWdx4syaBtrb10GdD4T>.Class27.class27_0 = new Class26<fmZKx8yjAxhooYjMv4w, VWdx4syaBtrb10GdD4T>.Class27();
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002621 File Offset: 0x00000821
		public Class27()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00006F61 File Offset: 0x00005161
		internal KeyValuePair<fmZKx8yjAxhooYjMv4w, VWdx4syaBtrb10GdD4T> method_0(DictionaryEntry dictionaryEntry_0)
		{
			return new KeyValuePair<fmZKx8yjAxhooYjMv4w, VWdx4syaBtrb10GdD4T>((fmZKx8yjAxhooYjMv4w)((object)dictionaryEntry_0.Key), (VWdx4syaBtrb10GdD4T)((object)dictionaryEntry_0.Value));
		}

		// Token: 0x040003F1 RID: 1009
		public static readonly Class26<fmZKx8yjAxhooYjMv4w, VWdx4syaBtrb10GdD4T>.Class27 class27_0;

		// Token: 0x040003F2 RID: 1010
		public static Func<DictionaryEntry, KeyValuePair<fmZKx8yjAxhooYjMv4w, VWdx4syaBtrb10GdD4T>> func_0;
	}
}
