using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

// Token: 0x020000B4 RID: 180
internal sealed class Class31<O3JSdjQuD5uSVMwF47d> : DynamicMetaObject
{
	// Token: 0x06000629 RID: 1577 RVA: 0x00006F94 File Offset: 0x00005194
	internal Class31(Expression expression_0, O3JSdjQuD5uSVMwF47d JrYiIEQpPP50mOR5aAh, Class28<O3JSdjQuD5uSVMwF47d> class28_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(expression_0, BindingRestrictions.Empty, JrYiIEQpPP50mOR5aAh);
		this.class28_0 = class28_1;
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00006FB4 File Offset: 0x000051B4
	private bool NsEsKrivoE(string string_0)
	{
		return Class90.smethod_42(this.class28_0.GetType(), typeof(Class28<O3JSdjQuD5uSVMwF47d>), string_0);
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x0002A064 File Offset: 0x00028264
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class33 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class33();
		@class.getMemberBinder_0 = binder;
		@class.class31_0 = this;
		if (!this.NsEsKrivoE("TryGetMember"))
		{
			return base.BindGetMember(@class.getMemberBinder_0);
		}
		return this.method_0("TryGetMember", @class.getMemberBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_0(), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0), null);
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x0002A0C4 File Offset: 0x000282C4
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class34 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class34();
		@class.setMemberBinder_0 = binder;
		@class.class31_0 = this;
		@class.dynamicMetaObject_0 = value;
		if (!this.NsEsKrivoE("TrySetMember"))
		{
			return base.BindSetMember(@class.setMemberBinder_0, @class.dynamicMetaObject_0);
		}
		return this.method_2("TrySetMember", @class.setMemberBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_1(new DynamicMetaObject[]
		{
			@class.dynamicMetaObject_0
		}), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0));
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x0002A140 File Offset: 0x00028340
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class35 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class35();
		@class.deleteMemberBinder_0 = binder;
		@class.class31_0 = this;
		if (!this.NsEsKrivoE("TryDeleteMember"))
		{
			return base.BindDeleteMember(@class.deleteMemberBinder_0);
		}
		return this.method_3("TryDeleteMember", @class.deleteMemberBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_0(), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0));
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x0002A1A0 File Offset: 0x000283A0
	public override DynamicMetaObject BindConvert(ConvertBinder binder)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class36 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class36();
		@class.convertBinder_0 = binder;
		@class.class31_0 = this;
		if (!this.NsEsKrivoE("TryConvert"))
		{
			return base.BindConvert(@class.convertBinder_0);
		}
		return this.method_0("TryConvert", @class.convertBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_0(), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0), null);
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x0002A200 File Offset: 0x00028400
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class37 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class37();
		@class.invokeMemberBinder_0 = binder;
		@class.class31_0 = this;
		@class.dynamicMetaObject_0 = args;
		if (!this.NsEsKrivoE("TryInvokeMember"))
		{
			return base.BindInvokeMember(@class.invokeMemberBinder_0, @class.dynamicMetaObject_0);
		}
		Class31<O3JSdjQuD5uSVMwF47d>.Delegate0 @delegate = new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0);
		return this.method_1("TryInvokeMember", @class.invokeMemberBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_2(@class.dynamicMetaObject_0), this.method_1("TryGetMember", new Class31<O3JSdjQuD5uSVMwF47d>.Class32(@class.invokeMemberBinder_0), Class31<O3JSdjQuD5uSVMwF47d>.smethod_0(), @delegate(null), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_1)), null);
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0002A2A0 File Offset: 0x000284A0
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class38 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class38();
		@class.createInstanceBinder_0 = binder;
		@class.class31_0 = this;
		@class.dynamicMetaObject_0 = args;
		if (!this.NsEsKrivoE("TryCreateInstance"))
		{
			return base.BindCreateInstance(@class.createInstanceBinder_0, @class.dynamicMetaObject_0);
		}
		return this.method_0("TryCreateInstance", @class.createInstanceBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_2(@class.dynamicMetaObject_0), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0), null);
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0002A314 File Offset: 0x00028514
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class39 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class39();
		@class.invokeBinder_0 = binder;
		@class.class31_0 = this;
		@class.dynamicMetaObject_0 = args;
		if (!this.NsEsKrivoE("TryInvoke"))
		{
			return base.BindInvoke(@class.invokeBinder_0, @class.dynamicMetaObject_0);
		}
		return this.method_0("TryInvoke", @class.invokeBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_2(@class.dynamicMetaObject_0), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0), null);
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x0002A388 File Offset: 0x00028588
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class40 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class40();
		@class.binaryOperationBinder_0 = binder;
		@class.class31_0 = this;
		@class.dynamicMetaObject_0 = arg;
		if (!this.NsEsKrivoE("TryBinaryOperation"))
		{
			return base.BindBinaryOperation(@class.binaryOperationBinder_0, @class.dynamicMetaObject_0);
		}
		return this.method_0("TryBinaryOperation", @class.binaryOperationBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_1(new DynamicMetaObject[]
		{
			@class.dynamicMetaObject_0
		}), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0), null);
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x0002A404 File Offset: 0x00028604
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class41 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class41();
		@class.unaryOperationBinder_0 = binder;
		@class.class31_0 = this;
		if (!this.NsEsKrivoE("TryUnaryOperation"))
		{
			return base.BindUnaryOperation(@class.unaryOperationBinder_0);
		}
		return this.method_0("TryUnaryOperation", @class.unaryOperationBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_0(), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0), null);
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0002A464 File Offset: 0x00028664
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class42 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class42();
		@class.getIndexBinder_0 = binder;
		@class.class31_0 = this;
		@class.dynamicMetaObject_0 = indexes;
		if (!this.NsEsKrivoE("TryGetIndex"))
		{
			return base.BindGetIndex(@class.getIndexBinder_0, @class.dynamicMetaObject_0);
		}
		return this.method_0("TryGetIndex", @class.getIndexBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_2(@class.dynamicMetaObject_0), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0), null);
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x0002A4D8 File Offset: 0x000286D8
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class43 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class43();
		@class.setIndexBinder_0 = binder;
		@class.class31_0 = this;
		@class.dynamicMetaObject_0 = indexes;
		@class.dynamicMetaObject_1 = value;
		if (!this.NsEsKrivoE("TrySetIndex"))
		{
			return base.BindSetIndex(@class.setIndexBinder_0, @class.dynamicMetaObject_0, @class.dynamicMetaObject_1);
		}
		return this.method_2("TrySetIndex", @class.setIndexBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_3(@class.dynamicMetaObject_0, @class.dynamicMetaObject_1), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0));
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0002A55C File Offset: 0x0002875C
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
	{
		Class31<O3JSdjQuD5uSVMwF47d>.Class44 @class = new Class31<O3JSdjQuD5uSVMwF47d>.Class44();
		@class.deleteIndexBinder_0 = binder;
		@class.class31_0 = this;
		@class.dynamicMetaObject_0 = indexes;
		if (!this.NsEsKrivoE("TryDeleteIndex"))
		{
			return base.BindDeleteIndex(@class.deleteIndexBinder_0, @class.dynamicMetaObject_0);
		}
		return this.method_3("TryDeleteIndex", @class.deleteIndexBinder_0, Class31<O3JSdjQuD5uSVMwF47d>.smethod_2(@class.dynamicMetaObject_0), new Class31<O3JSdjQuD5uSVMwF47d>.Delegate0(@class.method_0));
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00006FD1 File Offset: 0x000051D1
	private static Expression[] smethod_0()
	{
		return Class20.smethod_17<Expression>();
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00006FD8 File Offset: 0x000051D8
	private static IEnumerable<Expression> smethod_1(params DynamicMetaObject[] args)
	{
		return args.Select(new Func<DynamicMetaObject, Expression>(Class31<O3JSdjQuD5uSVMwF47d>.Class45.class45_0.method_0));
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x0002A5CC File Offset: 0x000287CC
	private static Expression[] smethod_2(DynamicMetaObject[] dynamicMetaObject_0)
	{
		return new NewArrayExpression[]
		{
			Expression.NewArrayInit(typeof(object), Class31<O3JSdjQuD5uSVMwF47d>.smethod_1(dynamicMetaObject_0))
		};
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x0002A5FC File Offset: 0x000287FC
	private static Expression[] smethod_3(DynamicMetaObject[] dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1)
	{
		Expression expression = dynamicMetaObject_1.Expression;
		return new Expression[]
		{
			Expression.NewArrayInit(typeof(object), Class31<O3JSdjQuD5uSVMwF47d>.smethod_1(dynamicMetaObject_0)),
			expression.Type.smethod_13() ? Expression.Convert(expression, typeof(object)) : expression
		};
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x0002A654 File Offset: 0x00028854
	private static ConstantExpression smethod_4(DynamicMetaObjectBinder dynamicMetaObjectBinder_0)
	{
		Type type = dynamicMetaObjectBinder_0.GetType();
		while (!type.smethod_12())
		{
			type = type.smethod_6();
		}
		return Expression.Constant(dynamicMetaObjectBinder_0, type);
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x0002A680 File Offset: 0x00028880
	private DynamicMetaObject method_0(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, Class31<O3JSdjQuD5uSVMwF47d>.Delegate0 delegate0_0, Class31<O3JSdjQuD5uSVMwF47d>.Delegate0 delegate0_1 = null)
	{
		DynamicMetaObject dynamicMetaObject_ = delegate0_0(null);
		return this.method_1(string_0, dynamicMetaObjectBinder_0, ienumerable_0, dynamicMetaObject_, delegate0_1);
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x0002A6A4 File Offset: 0x000288A4
	private DynamicMetaObject method_1(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, DynamicMetaObject dynamicMetaObject_0, Class31<O3JSdjQuD5uSVMwF47d>.Delegate0 delegate0_0)
	{
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
		IList<Expression> list = new List<Expression>();
		list.Add(Expression.Convert(base.Expression, typeof(O3JSdjQuD5uSVMwF47d)));
		list.Add(Class31<O3JSdjQuD5uSVMwF47d>.smethod_4(dynamicMetaObjectBinder_0));
		list.smethod_1(ienumerable_0);
		list.Add(parameterExpression);
		DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
		if (dynamicMetaObjectBinder_0.ReturnType != typeof(object))
		{
			dynamicMetaObject = new DynamicMetaObject(Expression.Convert(dynamicMetaObject.Expression, dynamicMetaObjectBinder_0.ReturnType), dynamicMetaObject.Restrictions);
		}
		if (delegate0_0 != null)
		{
			dynamicMetaObject = delegate0_0(dynamicMetaObject);
		}
		return new DynamicMetaObject(Expression.Block(new ParameterExpression[]
		{
			parameterExpression
		}, new Expression[]
		{
			Expression.Condition(Expression.Call(Expression.Constant(this.class28_0), typeof(Class28<O3JSdjQuD5uSVMwF47d>).GetMethod(string_0), list), dynamicMetaObject.Expression, dynamicMetaObject_0.Expression, dynamicMetaObjectBinder_0.ReturnType)
		}), this.method_4().Merge(dynamicMetaObject.Restrictions).Merge(dynamicMetaObject_0.Restrictions));
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0002A7C0 File Offset: 0x000289C0
	private DynamicMetaObject method_2(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, Class31<O3JSdjQuD5uSVMwF47d>.Delegate0 delegate0_0)
	{
		DynamicMetaObject dynamicMetaObject = delegate0_0(null);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
		IList<Expression> list = new List<Expression>();
		list.Add(Expression.Convert(base.Expression, typeof(O3JSdjQuD5uSVMwF47d)));
		list.Add(Class31<O3JSdjQuD5uSVMwF47d>.smethod_4(dynamicMetaObjectBinder_0));
		list.smethod_1(ienumerable_0);
		list[list.Count - 1] = Expression.Assign(parameterExpression, list[list.Count - 1]);
		return new DynamicMetaObject(Expression.Block(new ParameterExpression[]
		{
			parameterExpression
		}, new Expression[]
		{
			Expression.Condition(Expression.Call(Expression.Constant(this.class28_0), typeof(Class28<O3JSdjQuD5uSVMwF47d>).GetMethod(string_0), list), parameterExpression, dynamicMetaObject.Expression, typeof(object))
		}), this.method_4().Merge(dynamicMetaObject.Restrictions));
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x0002A8A4 File Offset: 0x00028AA4
	private DynamicMetaObject method_3(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, Expression[] expression_0, Class31<O3JSdjQuD5uSVMwF47d>.Delegate0 delegate0_0)
	{
		DynamicMetaObject dynamicMetaObject = delegate0_0(null);
		IList<Expression> list = new List<Expression>();
		list.Add(Expression.Convert(base.Expression, typeof(O3JSdjQuD5uSVMwF47d)));
		list.Add(Class31<O3JSdjQuD5uSVMwF47d>.smethod_4(dynamicMetaObjectBinder_0));
		list.smethod_1(expression_0);
		return new DynamicMetaObject(Expression.Condition(Expression.Call(Expression.Constant(this.class28_0), typeof(Class28<O3JSdjQuD5uSVMwF47d>).GetMethod(string_0), list), Expression.Empty(), dynamicMetaObject.Expression, typeof(void)), this.method_4().Merge(dynamicMetaObject.Restrictions));
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00006FFF File Offset: 0x000051FF
	private BindingRestrictions method_4()
	{
		if (base.Value == null && base.HasValue)
		{
			return BindingRestrictions.GetInstanceRestriction(base.Expression, null);
		}
		return BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType);
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x0000702F File Offset: 0x0000522F
	public override IEnumerable<string> GetDynamicMemberNames()
	{
		return this.class28_0.GetDynamicMemberNames((O3JSdjQuD5uSVMwF47d)((object)base.Value));
	}

	// Token: 0x040003F3 RID: 1011
	private readonly Class28<O3JSdjQuD5uSVMwF47d> class28_0;

	// Token: 0x020000B5 RID: 181
	// (Invoke) Token: 0x06000643 RID: 1603
	private delegate DynamicMetaObject Delegate0(DynamicMetaObject errorSuggestion);

	// Token: 0x020000B6 RID: 182
	private sealed class Class32 : GetMemberBinder
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x00007047 File Offset: 0x00005247
		internal Class32(InvokeMemberBinder invokeMemberBinder_0)
		{
			Class202.ofdixO4zTbIfy();
			base..ctor(invokeMemberBinder_0.Name, invokeMemberBinder_0.IgnoreCase);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00007060 File Offset: 0x00005260
		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x020000B7 RID: 183
	[CompilerGenerated]
	private sealed class Class33
	{
		// Token: 0x06000648 RID: 1608 RVA: 0x00002621 File Offset: 0x00000821
		public Class33()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00007067 File Offset: 0x00005267
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
		{
			return this.getMemberBinder_0.FallbackGetMember(this.class31_0, dynamicMetaObject_0);
		}

		// Token: 0x040003F4 RID: 1012
		public GetMemberBinder getMemberBinder_0;

		// Token: 0x040003F5 RID: 1013
		public Class31<q7fGB6sV8VdNaY250CI> class31_0;
	}

	// Token: 0x020000B8 RID: 184
	[CompilerGenerated]
	private sealed class Class34
	{
		// Token: 0x0600064A RID: 1610 RVA: 0x00002621 File Offset: 0x00000821
		public Class34()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000707B File Offset: 0x0000527B
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
		{
			return this.setMemberBinder_0.FallbackSetMember(this.class31_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
		}

		// Token: 0x040003F6 RID: 1014
		public SetMemberBinder setMemberBinder_0;

		// Token: 0x040003F7 RID: 1015
		public Class31<VkGwxUsEjBQiybbEfoB> class31_0;

		// Token: 0x040003F8 RID: 1016
		public DynamicMetaObject dynamicMetaObject_0;
	}

	// Token: 0x020000B9 RID: 185
	[CompilerGenerated]
	private sealed class Class35
	{
		// Token: 0x0600064C RID: 1612 RVA: 0x00002621 File Offset: 0x00000821
		public Class35()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00007095 File Offset: 0x00005295
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
		{
			return this.deleteMemberBinder_0.FallbackDeleteMember(this.class31_0, dynamicMetaObject_0);
		}

		// Token: 0x040003F9 RID: 1017
		public DeleteMemberBinder deleteMemberBinder_0;

		// Token: 0x040003FA RID: 1018
		public Class31<S8ssmQs0pVwJgNOXFUh> class31_0;
	}

	// Token: 0x020000BA RID: 186
	[CompilerGenerated]
	private sealed class Class36
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x00002621 File Offset: 0x00000821
		public Class36()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000070A9 File Offset: 0x000052A9
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
		{
			return this.convertBinder_0.FallbackConvert(this.class31_0, dynamicMetaObject_0);
		}

		// Token: 0x040003FB RID: 1019
		public ConvertBinder convertBinder_0;

		// Token: 0x040003FC RID: 1020
		public Class31<skMqG3ss5I1qaifAMwT> class31_0;
	}

	// Token: 0x020000BB RID: 187
	[CompilerGenerated]
	private sealed class Class37
	{
		// Token: 0x06000650 RID: 1616 RVA: 0x00002621 File Offset: 0x00000821
		public Class37()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000070BD File Offset: 0x000052BD
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
		{
			return this.invokeMemberBinder_0.FallbackInvokeMember(this.class31_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000070D7 File Offset: 0x000052D7
		internal DynamicMetaObject method_1(DynamicMetaObject dynamicMetaObject_1)
		{
			return this.invokeMemberBinder_0.FallbackInvoke(dynamicMetaObject_1, this.dynamicMetaObject_0, null);
		}

		// Token: 0x040003FD RID: 1021
		public InvokeMemberBinder invokeMemberBinder_0;

		// Token: 0x040003FE RID: 1022
		public Class31<qvYxtZs5AwsHHY9up5b> class31_0;

		// Token: 0x040003FF RID: 1023
		public DynamicMetaObject[] dynamicMetaObject_0;
	}

	// Token: 0x020000BC RID: 188
	[CompilerGenerated]
	private sealed class Class38
	{
		// Token: 0x06000653 RID: 1619 RVA: 0x00002621 File Offset: 0x00000821
		public Class38()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000070EC File Offset: 0x000052EC
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
		{
			return this.createInstanceBinder_0.FallbackCreateInstance(this.class31_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
		}

		// Token: 0x04000400 RID: 1024
		public CreateInstanceBinder createInstanceBinder_0;

		// Token: 0x04000401 RID: 1025
		public Class31<rhafjVsvRoiOCU8sOT1> class31_0;

		// Token: 0x04000402 RID: 1026
		public DynamicMetaObject[] dynamicMetaObject_0;
	}

	// Token: 0x020000BD RID: 189
	[CompilerGenerated]
	private sealed class Class39
	{
		// Token: 0x06000655 RID: 1621 RVA: 0x00002621 File Offset: 0x00000821
		public Class39()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00007106 File Offset: 0x00005306
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
		{
			return this.invokeBinder_0.FallbackInvoke(this.class31_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
		}

		// Token: 0x04000403 RID: 1027
		public InvokeBinder invokeBinder_0;

		// Token: 0x04000404 RID: 1028
		public Class31<WxRhJNsAWPRWb2eKERC> class31_0;

		// Token: 0x04000405 RID: 1029
		public DynamicMetaObject[] dynamicMetaObject_0;
	}

	// Token: 0x020000BE RID: 190
	[CompilerGenerated]
	private sealed class Class40
	{
		// Token: 0x06000657 RID: 1623 RVA: 0x00002621 File Offset: 0x00000821
		public Class40()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00007120 File Offset: 0x00005320
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
		{
			return this.binaryOperationBinder_0.FallbackBinaryOperation(this.class31_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
		}

		// Token: 0x04000406 RID: 1030
		public BinaryOperationBinder binaryOperationBinder_0;

		// Token: 0x04000407 RID: 1031
		public Class31<NGoYkAsryWnM15yeS1g> class31_0;

		// Token: 0x04000408 RID: 1032
		public DynamicMetaObject dynamicMetaObject_0;
	}

	// Token: 0x020000BF RID: 191
	[CompilerGenerated]
	private sealed class Class41
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x00002621 File Offset: 0x00000821
		public Class41()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0000713A File Offset: 0x0000533A
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_0)
		{
			return this.unaryOperationBinder_0.FallbackUnaryOperation(this.class31_0, dynamicMetaObject_0);
		}

		// Token: 0x04000409 RID: 1033
		public UnaryOperationBinder unaryOperationBinder_0;

		// Token: 0x0400040A RID: 1034
		public Class31<R0SnVls8APx2VDS2Tff> class31_0;
	}

	// Token: 0x020000C0 RID: 192
	[CompilerGenerated]
	private sealed class Class42
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00002621 File Offset: 0x00000821
		public Class42()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000714E File Offset: 0x0000534E
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
		{
			return this.getIndexBinder_0.FallbackGetIndex(this.class31_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
		}

		// Token: 0x0400040B RID: 1035
		public GetIndexBinder getIndexBinder_0;

		// Token: 0x0400040C RID: 1036
		public Class31<MHNOYJsSg1hMDq6A0fX> class31_0;

		// Token: 0x0400040D RID: 1037
		public DynamicMetaObject[] dynamicMetaObject_0;
	}

	// Token: 0x020000C1 RID: 193
	[CompilerGenerated]
	private sealed class Class43
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x00002621 File Offset: 0x00000821
		public Class43()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00007168 File Offset: 0x00005368
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_2)
		{
			return this.setIndexBinder_0.FallbackSetIndex(this.class31_0, this.dynamicMetaObject_0, this.dynamicMetaObject_1, dynamicMetaObject_2);
		}

		// Token: 0x0400040E RID: 1038
		public SetIndexBinder setIndexBinder_0;

		// Token: 0x0400040F RID: 1039
		public Class31<TaWjoSsYB4pehgx3MME> class31_0;

		// Token: 0x04000410 RID: 1040
		public DynamicMetaObject[] dynamicMetaObject_0;

		// Token: 0x04000411 RID: 1041
		public DynamicMetaObject dynamicMetaObject_1;
	}

	// Token: 0x020000C2 RID: 194
	[CompilerGenerated]
	private sealed class Class44
	{
		// Token: 0x0600065F RID: 1631 RVA: 0x00002621 File Offset: 0x00000821
		public Class44()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00007188 File Offset: 0x00005388
		internal DynamicMetaObject method_0(DynamicMetaObject dynamicMetaObject_1)
		{
			return this.deleteIndexBinder_0.FallbackDeleteIndex(this.class31_0, this.dynamicMetaObject_0, dynamicMetaObject_1);
		}

		// Token: 0x04000412 RID: 1042
		public DeleteIndexBinder deleteIndexBinder_0;

		// Token: 0x04000413 RID: 1043
		public Class31<V8nesMsuRwlqSdsbbtq> class31_0;

		// Token: 0x04000414 RID: 1044
		public DynamicMetaObject[] dynamicMetaObject_0;
	}

	// Token: 0x020000C3 RID: 195
	[CompilerGenerated]
	[Serializable]
	private sealed class Class45
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x000071A2 File Offset: 0x000053A2
		// Note: this type is marked as 'beforefieldinit'.
		static Class45()
		{
			Class202.ofdixO4zTbIfy();
			Class31<NL4hVNsMgLWBuwt0Tor>.Class45.class45_0 = new Class31<NL4hVNsMgLWBuwt0Tor>.Class45();
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002621 File Offset: 0x00000821
		public Class45()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0002A940 File Offset: 0x00028B40
		internal Expression method_0(DynamicMetaObject dynamicMetaObject_0)
		{
			Expression expression = dynamicMetaObject_0.Expression;
			if (!expression.Type.smethod_13())
			{
				return expression;
			}
			return Expression.Convert(expression, typeof(object));
		}

		// Token: 0x04000415 RID: 1045
		public static readonly Class31<NL4hVNsMgLWBuwt0Tor>.Class45 class45_0;

		// Token: 0x04000416 RID: 1046
		public static Func<DynamicMetaObject, Expression> func_0;
	}
}
