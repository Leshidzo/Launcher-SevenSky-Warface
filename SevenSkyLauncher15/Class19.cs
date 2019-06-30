using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x020000A2 RID: 162
internal class Class19<uSg9WcYFULnBZnRbr4, JMnG3WwHv05tlOU9Eu>
{
	// Token: 0x06000576 RID: 1398 RVA: 0x000065CD File Offset: 0x000047CD
	public Class19()
	{
		Class202.ofdixO4zTbIfy();
		this..ctor(EqualityComparer<uSg9WcYFULnBZnRbr4>.Default, EqualityComparer<JMnG3WwHv05tlOU9Eu>.Default);
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x000065E4 File Offset: 0x000047E4
	public Class19(IEqualityComparer<uSg9WcYFULnBZnRbr4> iequalityComparer_0, IEqualityComparer<JMnG3WwHv05tlOU9Eu> iequalityComparer_1)
	{
		Class202.ofdixO4zTbIfy();
		this..ctor(iequalityComparer_0, iequalityComparer_1, "Duplicate item already exists for '{0}'.", "Duplicate item already exists for '{0}'.");
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x000065FD File Offset: 0x000047FD
	public Class19(IEqualityComparer<uSg9WcYFULnBZnRbr4> iequalityComparer_0, IEqualityComparer<JMnG3WwHv05tlOU9Eu> iequalityComparer_1, string string_2, string string_3)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.idictionary_0 = new Dictionary<uSg9WcYFULnBZnRbr4, JMnG3WwHv05tlOU9Eu>(iequalityComparer_0);
		this.idictionary_1 = new Dictionary<JMnG3WwHv05tlOU9Eu, uSg9WcYFULnBZnRbr4>(iequalityComparer_1);
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00026D88 File Offset: 0x00024F88
	public void Set(uSg9WcYFULnBZnRbr4 first, JMnG3WwHv05tlOU9Eu second)
	{
		JMnG3WwHv05tlOU9Eu jmnG3WwHv05tlOU9Eu;
		if (this.idictionary_0.TryGetValue(first, out jmnG3WwHv05tlOU9Eu) && !jmnG3WwHv05tlOU9Eu.Equals(second))
		{
			throw new ArgumentException(this.string_0.smethod_0(CultureInfo.InvariantCulture, first));
		}
		uSg9WcYFULnBZnRbr4 uSg9WcYFULnBZnRbr;
		if (this.idictionary_1.TryGetValue(second, out uSg9WcYFULnBZnRbr) && !uSg9WcYFULnBZnRbr.Equals(first))
		{
			throw new ArgumentException(this.string_1.smethod_0(CultureInfo.InvariantCulture, second));
		}
		this.idictionary_0.Add(first, second);
		this.idictionary_1.Add(second, first);
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00006631 File Offset: 0x00004831
	public bool cvuFbgqpr0(uSg9WcYFULnBZnRbr4 JZ61RHmQXFw1AIdCvd, out JMnG3WwHv05tlOU9Eu gparam_0)
	{
		return this.idictionary_0.TryGetValue(JZ61RHmQXFw1AIdCvd, out gparam_0);
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00006640 File Offset: 0x00004840
	public bool method_0(JMnG3WwHv05tlOU9Eu yFN5fPMkevdu2kEBG8, out uSg9WcYFULnBZnRbr4 gparam_0)
	{
		return this.idictionary_1.TryGetValue(yFN5fPMkevdu2kEBG8, out gparam_0);
	}

	// Token: 0x040003BE RID: 958
	private readonly IDictionary<uSg9WcYFULnBZnRbr4, JMnG3WwHv05tlOU9Eu> idictionary_0;

	// Token: 0x040003BF RID: 959
	private readonly IDictionary<JMnG3WwHv05tlOU9Eu, uSg9WcYFULnBZnRbr4> idictionary_1;

	// Token: 0x040003C0 RID: 960
	private readonly string string_0;

	// Token: 0x040003C1 RID: 961
	private readonly string string_1;
}
