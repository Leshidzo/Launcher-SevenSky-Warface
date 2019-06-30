using System;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Serialization;

// Token: 0x020000EF RID: 239
internal abstract class Class81
{
	// Token: 0x0600072D RID: 1837 RVA: 0x0002E070 File Offset: 0x0002C270
	public Func<wL9mT7EkCobpvsCpj9D, object> method_0<wL9mT7EkCobpvsCpj9D>(MemberInfo memberInfo_0)
	{
		PropertyInfo propertyInfo;
		if ((propertyInfo = (memberInfo_0 as PropertyInfo)) != null)
		{
			if (propertyInfo.PropertyType.IsByRef)
			{
				throw new InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".smethod_0(CultureInfo.InvariantCulture, propertyInfo));
			}
			return this.vmethod_3<wL9mT7EkCobpvsCpj9D>(propertyInfo);
		}
		else
		{
			FieldInfo fieldInfo_;
			if ((fieldInfo_ = (memberInfo_0 as FieldInfo)) == null)
			{
				throw new Exception("Could not create getter for {0}.".smethod_0(CultureInfo.InvariantCulture, memberInfo_0));
			}
			return this.vmethod_4<wL9mT7EkCobpvsCpj9D>(fieldInfo_);
		}
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x0002E0DC File Offset: 0x0002C2DC
	public Action<OgnYGHEifMOFLLaaCFK, object> method_1<OgnYGHEifMOFLLaaCFK>(MemberInfo memberInfo_0)
	{
		PropertyInfo propertyInfo_;
		if ((propertyInfo_ = (memberInfo_0 as PropertyInfo)) != null)
		{
			return this.vmethod_6<OgnYGHEifMOFLLaaCFK>(propertyInfo_);
		}
		FieldInfo fieldInfo_;
		if ((fieldInfo_ = (memberInfo_0 as FieldInfo)) == null)
		{
			throw new Exception("Could not create setter for {0}.".smethod_0(CultureInfo.InvariantCulture, memberInfo_0));
		}
		return this.vmethod_5<OgnYGHEifMOFLLaaCFK>(fieldInfo_);
	}

	// Token: 0x0600072F RID: 1839
	public abstract Delegate1<E7nlEZEtI27M4s7sUVU, object> vmethod_0<E7nlEZEtI27M4s7sUVU>(MethodBase methodBase_0);

	// Token: 0x06000730 RID: 1840
	public abstract ObjectConstructor<object> vmethod_1(MethodBase methodBase_0);

	// Token: 0x06000731 RID: 1841
	public abstract Func<DPyWhBEbYw8fWDFG8P2> vmethod_2<DPyWhBEbYw8fWDFG8P2>(Type type_0);

	// Token: 0x06000732 RID: 1842
	public abstract Func<YbukkDEBYUjlDbL902j, object> vmethod_3<YbukkDEBYUjlDbL902j>(PropertyInfo propertyInfo_0);

	// Token: 0x06000733 RID: 1843
	public abstract Func<PD2oWOEqMZjM1a6SQDU, object> vmethod_4<PD2oWOEqMZjM1a6SQDU>(FieldInfo fieldInfo_0);

	// Token: 0x06000734 RID: 1844
	public abstract Action<ac31ykE4mtsJymehSli, object> vmethod_5<ac31ykE4mtsJymehSli>(FieldInfo fieldInfo_0);

	// Token: 0x06000735 RID: 1845
	public abstract Action<FE5ZoKEZto5ipTmfZZK, object> vmethod_6<FE5ZoKEZto5ipTmfZZK>(PropertyInfo propertyInfo_0);

	// Token: 0x06000736 RID: 1846 RVA: 0x00002621 File Offset: 0x00000821
	protected Class81()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}
}
