using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

// Token: 0x020000A5 RID: 165
internal class Class21<nhRd76JVPX5GP69E2c> : ICollection<nhRd76JVPX5GP69E2c>, IEnumerable<nhRd76JVPX5GP69E2c>, IList, ICollection, IEnumerable, Interface0
{
	// Token: 0x0600058F RID: 1423 RVA: 0x000272DC File Offset: 0x000254DC
	public Class21(IList ilist_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		Class101.smethod_0(ilist_1, "list");
		ICollection<nhRd76JVPX5GP69E2c> collection;
		if ((collection = (ilist_1 as ICollection<nhRd76JVPX5GP69E2c>)) != null)
		{
			this.icollection_0 = collection;
			return;
		}
		this.ilist_0 = ilist_1;
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00006699 File Offset: 0x00004899
	public Class21(ICollection<nhRd76JVPX5GP69E2c> icollection_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		Class101.smethod_0(icollection_1, "list");
		this.icollection_0 = icollection_1;
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x000066B8 File Offset: 0x000048B8
	public virtual void Add(nhRd76JVPX5GP69E2c tQW7pbOdZiGaIkvmbK)
	{
		if (this.icollection_0 != null)
		{
			this.icollection_0.Add(tQW7pbOdZiGaIkvmbK);
			return;
		}
		this.ilist_0.Add(tQW7pbOdZiGaIkvmbK);
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x000066E1 File Offset: 0x000048E1
	public virtual void Clear()
	{
		if (this.icollection_0 != null)
		{
			this.icollection_0.Clear();
			return;
		}
		this.ilist_0.Clear();
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00006702 File Offset: 0x00004902
	public virtual bool Contains(nhRd76JVPX5GP69E2c eh18DcoviVRc4fjMiT)
	{
		if (this.icollection_0 != null)
		{
			return this.icollection_0.Contains(eh18DcoviVRc4fjMiT);
		}
		return this.ilist_0.Contains(eh18DcoviVRc4fjMiT);
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0000672A File Offset: 0x0000492A
	public virtual void CopyTo(nhRd76JVPX5GP69E2c[] array, int arrayIndex)
	{
		if (this.icollection_0 != null)
		{
			this.icollection_0.CopyTo(array, arrayIndex);
			return;
		}
		this.ilist_0.CopyTo(array, arrayIndex);
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000595 RID: 1429 RVA: 0x0000674F File Offset: 0x0000494F
	public virtual int Count
	{
		get
		{
			if (this.icollection_0 != null)
			{
				return this.icollection_0.Count;
			}
			return this.ilist_0.Count;
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000596 RID: 1430 RVA: 0x00006770 File Offset: 0x00004970
	public virtual bool IsReadOnly
	{
		get
		{
			if (this.icollection_0 != null)
			{
				return this.icollection_0.IsReadOnly;
			}
			return this.ilist_0.IsReadOnly;
		}
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00006791 File Offset: 0x00004991
	public virtual bool Remove(nhRd76JVPX5GP69E2c HgP0fQH4IWRkS50fyl)
	{
		if (this.icollection_0 != null)
		{
			return this.icollection_0.Remove(HgP0fQH4IWRkS50fyl);
		}
		bool flag = this.ilist_0.Contains(HgP0fQH4IWRkS50fyl);
		if (flag)
		{
			this.ilist_0.Remove(HgP0fQH4IWRkS50fyl);
		}
		return flag;
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x00027318 File Offset: 0x00025518
	public virtual IEnumerator<nhRd76JVPX5GP69E2c> GetEnumerator()
	{
		IEnumerable<nhRd76JVPX5GP69E2c> enumerable = this.icollection_0;
		return (enumerable ?? this.ilist_0.Cast<nhRd76JVPX5GP69E2c>()).GetEnumerator();
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00027344 File Offset: 0x00025544
	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerable enumerable = this.icollection_0;
		return (enumerable ?? this.ilist_0).GetEnumerator();
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x000067CD File Offset: 0x000049CD
	int IList.Add(object value)
	{
		Class21<nhRd76JVPX5GP69E2c>.smethod_0(value);
		this.Add((nhRd76JVPX5GP69E2c)((object)value));
		return this.Count - 1;
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x000067E9 File Offset: 0x000049E9
	bool IList.Contains(object value)
	{
		return Class21<nhRd76JVPX5GP69E2c>.smethod_1(value) && this.Contains((nhRd76JVPX5GP69E2c)((object)value));
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00006801 File Offset: 0x00004A01
	int IList.IndexOf(object value)
	{
		if (this.icollection_0 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support IndexOf.");
		}
		if (Class21<nhRd76JVPX5GP69E2c>.smethod_1(value))
		{
			return this.ilist_0.IndexOf((nhRd76JVPX5GP69E2c)((object)value));
		}
		return -1;
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00006836 File Offset: 0x00004A36
	void IList.RemoveAt(int index)
	{
		if (this.icollection_0 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support RemoveAt.");
		}
		this.ilist_0.RemoveAt(index);
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00006857 File Offset: 0x00004A57
	void IList.Insert(int index, object value)
	{
		if (this.icollection_0 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support Insert.");
		}
		Class21<nhRd76JVPX5GP69E2c>.smethod_0(value);
		this.ilist_0.Insert(index, (nhRd76JVPX5GP69E2c)((object)value));
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600059F RID: 1439 RVA: 0x00006889 File Offset: 0x00004A89
	bool IList.IsFixedSize
	{
		get
		{
			if (this.icollection_0 != null)
			{
				return this.icollection_0.IsReadOnly;
			}
			return this.ilist_0.IsFixedSize;
		}
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x000068AA File Offset: 0x00004AAA
	void IList.Remove(object value)
	{
		if (Class21<nhRd76JVPX5GP69E2c>.smethod_1(value))
		{
			this.Remove((nhRd76JVPX5GP69E2c)((object)value));
		}
	}

	// Token: 0x170000B6 RID: 182
	object IList.this[int index]
	{
		get
		{
			if (this.icollection_0 != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
			}
			return this.ilist_0[index];
		}
		set
		{
			if (this.icollection_0 != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
			}
			Class21<nhRd76JVPX5GP69E2c>.smethod_0(value);
			this.ilist_0[index] = (nhRd76JVPX5GP69E2c)((object)value);
		}
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00006914 File Offset: 0x00004B14
	void ICollection.CopyTo(Array array, int index)
	{
		this.CopyTo((nhRd76JVPX5GP69E2c[])array, index);
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060005A4 RID: 1444 RVA: 0x000055B0 File Offset: 0x000037B0
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00006923 File Offset: 0x00004B23
	object ICollection.SyncRoot
	{
		get
		{
			if (this.sxdFeruxjT == null)
			{
				Interlocked.CompareExchange(ref this.sxdFeruxjT, new object(), null);
			}
			return this.sxdFeruxjT;
		}
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00006945 File Offset: 0x00004B45
	private static void smethod_0(object object_0)
	{
		if (!Class21<nhRd76JVPX5GP69E2c>.smethod_1(object_0))
		{
			throw new ArgumentException("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.".smethod_1(CultureInfo.InvariantCulture, object_0, typeof(nhRd76JVPX5GP69E2c)), "value");
		}
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00006974 File Offset: 0x00004B74
	private static bool smethod_1(object object_0)
	{
		return object_0 is nhRd76JVPX5GP69E2c || (object_0 == null && (!typeof(nhRd76JVPX5GP69E2c).smethod_13() || Class90.smethod_11(typeof(nhRd76JVPX5GP69E2c))));
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000069A6 File Offset: 0x00004BA6
	public object UnderlyingCollection
	{
		get
		{
			return this.icollection_0 ?? this.ilist_0;
		}
	}

	// Token: 0x040003C2 RID: 962
	private readonly IList ilist_0;

	// Token: 0x040003C3 RID: 963
	private readonly ICollection<nhRd76JVPX5GP69E2c> icollection_0;

	// Token: 0x040003C4 RID: 964
	private object sxdFeruxjT;
}
