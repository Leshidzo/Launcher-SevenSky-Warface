using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json.Converters;

// Token: 0x020001DF RID: 479
internal class Class187 : Class185, Interface5, Interface6
{
	// Token: 0x0600102E RID: 4142 RVA: 0x0000D979 File Offset: 0x0000BB79
	private XElement method_1()
	{
		return (XElement)base.imjghrpgVE();
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x0000D6B3 File Offset: 0x0000B8B3
	public Class187(XElement xelement_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(xelement_0);
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x00048BF4 File Offset: 0x00046DF4
	public void imethod_7(Interface6 interface6_0)
	{
		Class179 @class = (Class179)interface6_0;
		this.method_1().Add(@class.imjghrpgVE());
		this.list_1 = null;
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00048C20 File Offset: 0x00046E20
	public override List<Interface6> imethod_3()
	{
		if (this.list_1 == null)
		{
			if (!this.method_1().HasAttributes && !this.method_2(this.imethod_6()))
			{
				this.list_1 = XmlNodeConverter.list_0;
			}
			else
			{
				this.list_1 = new List<Interface6>();
				foreach (XAttribute xattribute_ in this.method_1().Attributes())
				{
					this.list_1.Add(new Class188(xattribute_));
				}
				string text = this.imethod_6();
				if (this.method_2(text))
				{
					this.list_1.Insert(0, new Class188(new XAttribute("xmlns", text)));
				}
			}
		}
		return this.list_1;
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00048CF4 File Offset: 0x00046EF4
	private bool method_2(string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			Interface6 @interface = this.imethod_4();
			if (string_0 != ((@interface != null) ? @interface.imethod_6() : null) && string.IsNullOrEmpty(this.dnXgedsFyK(string_0)))
			{
				bool flag = false;
				if (this.method_1().HasAttributes)
				{
					foreach (XAttribute xattribute in this.method_1().Attributes())
					{
						if (xattribute.Name.LocalName == "xmlns" && string.IsNullOrEmpty(xattribute.Name.NamespaceName) && xattribute.Value == string_0)
						{
							flag = true;
						}
					}
				}
				if (!flag)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x0000D986 File Offset: 0x0000BB86
	public override Interface6 imethod_5(Interface6 interface6_0)
	{
		Interface6 result = base.imethod_5(interface6_0);
		this.list_1 = null;
		return result;
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06001034 RID: 4148 RVA: 0x0000D996 File Offset: 0x0000BB96
	// (set) Token: 0x06001035 RID: 4149 RVA: 0x0000D9A3 File Offset: 0x0000BBA3
	public override string Value
	{
		get
		{
			return this.method_1().Value;
		}
		set
		{
			this.method_1().Value = value;
		}
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x0000D9B1 File Offset: 0x0000BBB1
	public override string imethod_1()
	{
		return this.method_1().Name.LocalName;
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x0000D9C3 File Offset: 0x0000BBC3
	public override string imethod_6()
	{
		return this.method_1().Name.NamespaceName;
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x0000D9D5 File Offset: 0x0000BBD5
	public string dnXgedsFyK(string string_0)
	{
		return this.method_1().GetPrefixOfNamespace(string_0);
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
	public bool imethod_8()
	{
		return this.method_1().IsEmpty;
	}

	// Token: 0x0400078F RID: 1935
	private List<Interface6> list_1;
}
