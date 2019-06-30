using System;
using System.Dynamic;

// Token: 0x020000C8 RID: 200
internal class Class49 : GetMemberBinder
{
	// Token: 0x0600067D RID: 1661 RVA: 0x00007283 File Offset: 0x00005483
	public Class49(GetMemberBinder getMemberBinder_0)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(getMemberBinder_0.Name, getMemberBinder_0.IgnoreCase);
		this.object_0 = getMemberBinder_0;
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x0002B428 File Offset: 0x00029628
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
	{
		DynamicMetaObject dynamicMetaObject = this.object_0.Bind(target, Class20.smethod_17<DynamicMetaObject>());
		return new DynamicMetaObject(new Class51().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
	}

	// Token: 0x0400041E RID: 1054
	private readonly object object_0;
}
