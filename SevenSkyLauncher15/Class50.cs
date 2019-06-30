using System;
using System.Dynamic;

// Token: 0x020000C9 RID: 201
internal class Class50 : SetMemberBinder
{
	// Token: 0x0600067F RID: 1663 RVA: 0x000072A3 File Offset: 0x000054A3
	public Class50(SetMemberBinder setMemberBinder_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(setMemberBinder_0.Name, setMemberBinder_0.IgnoreCase);
		this.object_0 = setMemberBinder_0;
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x0002B464 File Offset: 0x00029664
	public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
	{
		DynamicMetaObject dynamicMetaObject = this.object_0.Bind(target, new DynamicMetaObject[]
		{
			value
		});
		return new DynamicMetaObject(new Class51().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
	}

	// Token: 0x0400041F RID: 1055
	private readonly object object_0;
}
