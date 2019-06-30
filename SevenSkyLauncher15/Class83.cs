using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

// Token: 0x020000CF RID: 207
internal class Class83 : Class81
{
	// Token: 0x06000696 RID: 1686 RVA: 0x000073C6 File Offset: 0x000055C6
	internal static Class81 smethod_0()
	{
		return Class83.class83_0;
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x0002BB6C File Offset: 0x00029D6C
	public override ObjectConstructor<object> vmethod_1(MethodBase methodBase_0)
	{
		Class101.smethod_0(methodBase_0, "method");
		Type typeFromHandle = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), "args");
		Expression body = this.method_2(methodBase_0, typeFromHandle, null, parameterExpression);
		return (ObjectConstructor<object>)Expression.Lambda(typeof(ObjectConstructor<object>), body, new ParameterExpression[]
		{
			parameterExpression
		}).Compile();
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x0002BBD4 File Offset: 0x00029DD4
	public override Delegate1<Dr1fGAQHIyohx0c0SC7, object> vmethod_0<Dr1fGAQHIyohx0c0SC7>(MethodBase methodBase_0)
	{
		Class101.smethod_0(methodBase_0, "method");
		Type typeFromHandle = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "target");
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object[]), "args");
		Expression body = this.method_2(methodBase_0, typeFromHandle, parameterExpression, parameterExpression2);
		return (Delegate1<Dr1fGAQHIyohx0c0SC7, object>)Expression.Lambda(typeof(Delegate1<Dr1fGAQHIyohx0c0SC7, object>), body, new ParameterExpression[]
		{
			parameterExpression,
			parameterExpression2
		}).Compile();
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x0002BC4C File Offset: 0x00029E4C
	private Expression method_2(MethodBase methodBase_0, Type type_0, ParameterExpression parameterExpression_0, ParameterExpression parameterExpression_1)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Expression[] array;
		IList<Class83.Class56> list;
		if (parameters.Length == 0)
		{
			array = Class20.smethod_17<Expression>();
			list = Class20.smethod_17<Class83.Class56>();
		}
		else
		{
			array = new Expression[parameters.Length];
			list = new List<Class83.Class56>();
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				Type type = parameterInfo.ParameterType;
				bool flag = false;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					flag = true;
				}
				Expression index = Expression.Constant(i);
				Expression expression_ = Expression.ArrayIndex(parameterExpression_1, index);
				Expression expression = this.method_3(expression_, type, !flag);
				if (flag)
				{
					ParameterExpression parameterExpression = Expression.Variable(type);
					list.Add(new Class83.Class56
					{
						expression_0 = expression,
						object_0 = parameterExpression,
						bool_0 = parameterInfo.IsOut
					});
					expression = parameterExpression;
				}
				array[i] = expression;
			}
		}
		Expression expression2;
		if (methodBase_0.IsConstructor)
		{
			expression2 = Expression.New((ConstructorInfo)methodBase_0, array);
		}
		else if (methodBase_0.IsStatic)
		{
			expression2 = Expression.Call((MethodInfo)methodBase_0, array);
		}
		else
		{
			expression2 = Expression.Call(this.method_3(parameterExpression_0, methodBase_0.DeclaringType, false), (MethodInfo)methodBase_0, array);
		}
		MethodInfo methodInfo;
		if ((methodInfo = (methodBase_0 as MethodInfo)) != null)
		{
			if (methodInfo.ReturnType != typeof(void))
			{
				expression2 = this.method_3(expression2, type_0, false);
			}
			else
			{
				expression2 = Expression.Block(expression2, Expression.Constant(null));
			}
		}
		else
		{
			expression2 = this.method_3(expression2, type_0, false);
		}
		if (list.Count > 0)
		{
			IList<ParameterExpression> list2 = new List<ParameterExpression>();
			IList<Expression> list3 = new List<Expression>();
			foreach (Class83.Class56 @class in list)
			{
				if (!@class.bool_0)
				{
					list3.Add(Expression.Assign(@class.object_0, @class.expression_0));
				}
				list2.Add(@class.object_0);
			}
			list3.Add(expression2);
			expression2 = Expression.Block(list2, list3);
		}
		return expression2;
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x0002BE68 File Offset: 0x0002A068
	public override Func<bNXcIvQxwUgGK6JVNu1> vmethod_2<bNXcIvQxwUgGK6JVNu1>(Type type_0)
	{
		Class83.Class57<bNXcIvQxwUgGK6JVNu1> @class = new Class83.Class57<bNXcIvQxwUgGK6JVNu1>();
		@class.type_0 = type_0;
		Class101.smethod_0(@class.type_0, "type");
		if (@class.type_0.smethod_11())
		{
			return new Func<bNXcIvQxwUgGK6JVNu1>(@class.method_0);
		}
		Func<bNXcIvQxwUgGK6JVNu1> result;
		try
		{
			Type typeFromHandle = typeof(bNXcIvQxwUgGK6JVNu1);
			Expression expression = Expression.New(@class.type_0);
			expression = this.method_3(expression, typeFromHandle, false);
			result = (Func<bNXcIvQxwUgGK6JVNu1>)Expression.Lambda(typeof(Func<bNXcIvQxwUgGK6JVNu1>), expression, new ParameterExpression[0]).Compile();
		}
		catch
		{
			result = new Func<bNXcIvQxwUgGK6JVNu1>(@class.method_1);
		}
		return result;
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x0002BF14 File Offset: 0x0002A114
	public override Func<KNs0TCQ3n8KcDhc3tEX, object> vmethod_3<KNs0TCQ3n8KcDhc3tEX>(PropertyInfo propertyInfo_0)
	{
		Class101.smethod_0(propertyInfo_0, "propertyInfo");
		Type typeFromHandle = typeof(KNs0TCQ3n8KcDhc3tEX);
		Type typeFromHandle2 = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "instance");
		Expression expression;
		if (propertyInfo_0.GetGetMethod(true).IsStatic)
		{
			expression = Expression.MakeMemberAccess(null, propertyInfo_0);
		}
		else
		{
			expression = Expression.MakeMemberAccess(this.method_3(parameterExpression, propertyInfo_0.DeclaringType, false), propertyInfo_0);
		}
		expression = this.method_3(expression, typeFromHandle2, false);
		return (Func<KNs0TCQ3n8KcDhc3tEX, object>)Expression.Lambda(typeof(Func<KNs0TCQ3n8KcDhc3tEX, object>), expression, new ParameterExpression[]
		{
			parameterExpression
		}).Compile();
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x0002BFA8 File Offset: 0x0002A1A8
	public override Func<rScHZOQGjQpnp4mHkUX, object> vmethod_4<rScHZOQGjQpnp4mHkUX>(FieldInfo fieldInfo_0)
	{
		Class101.smethod_0(fieldInfo_0, "fieldInfo");
		ParameterExpression parameterExpression = Expression.Parameter(typeof(rScHZOQGjQpnp4mHkUX), "source");
		Expression expression;
		if (fieldInfo_0.IsStatic)
		{
			expression = Expression.Field(null, fieldInfo_0);
		}
		else
		{
			expression = Expression.Field(this.method_3(parameterExpression, fieldInfo_0.DeclaringType, false), fieldInfo_0);
		}
		expression = this.method_3(expression, typeof(object), false);
		return Expression.Lambda<Func<rScHZOQGjQpnp4mHkUX, object>>(expression, new ParameterExpression[]
		{
			parameterExpression
		}).Compile();
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x0002C028 File Offset: 0x0002A228
	public override Action<aO5jiiQTN2H7SNbj5Xi, object> vmethod_5<aO5jiiQTN2H7SNbj5Xi>(FieldInfo fieldInfo_0)
	{
		Class101.smethod_0(fieldInfo_0, "fieldInfo");
		if (!fieldInfo_0.DeclaringType.smethod_13() && !fieldInfo_0.IsInitOnly)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(aO5jiiQTN2H7SNbj5Xi), "source");
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), "value");
			Expression expression;
			if (fieldInfo_0.IsStatic)
			{
				expression = Expression.Field(null, fieldInfo_0);
			}
			else
			{
				expression = Expression.Field(this.method_3(parameterExpression, fieldInfo_0.DeclaringType, false), fieldInfo_0);
			}
			Expression right = this.method_3(parameterExpression2, expression.Type, false);
			BinaryExpression body = Expression.Assign(expression, right);
			return (Action<aO5jiiQTN2H7SNbj5Xi, object>)Expression.Lambda(typeof(Action<aO5jiiQTN2H7SNbj5Xi, object>), body, new ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
		}
		return Class84.smethod_0().vmethod_5<aO5jiiQTN2H7SNbj5Xi>(fieldInfo_0);
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x0002C0FC File Offset: 0x0002A2FC
	public override Action<Fu5NDKQjdwdau68ILj6, object> vmethod_6<Fu5NDKQjdwdau68ILj6>(PropertyInfo propertyInfo_0)
	{
		Class101.smethod_0(propertyInfo_0, "propertyInfo");
		if (propertyInfo_0.DeclaringType.smethod_13())
		{
			return Class84.smethod_0().vmethod_6<Fu5NDKQjdwdau68ILj6>(propertyInfo_0);
		}
		Type typeFromHandle = typeof(Fu5NDKQjdwdau68ILj6);
		Type typeFromHandle2 = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "instance");
		ParameterExpression parameterExpression2 = Expression.Parameter(typeFromHandle2, "value");
		Expression expression = this.method_3(parameterExpression2, propertyInfo_0.PropertyType, false);
		MethodInfo setMethod = propertyInfo_0.GetSetMethod(true);
		Expression body;
		if (setMethod.IsStatic)
		{
			body = Expression.Call(setMethod, expression);
		}
		else
		{
			body = Expression.Call(this.method_3(parameterExpression, propertyInfo_0.DeclaringType, false), setMethod, new Expression[]
			{
				expression
			});
		}
		return (Action<Fu5NDKQjdwdau68ILj6, object>)Expression.Lambda(typeof(Action<Fu5NDKQjdwdau68ILj6, object>), body, new ParameterExpression[]
		{
			parameterExpression,
			parameterExpression2
		}).Compile();
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x0002C1D4 File Offset: 0x0002A3D4
	private Expression method_3(Expression expression_0, Type type_0, bool bool_0 = false)
	{
		Type type = expression_0.Type;
		if (type == type_0 || (!type.smethod_13() && type_0.IsAssignableFrom(type)))
		{
			return expression_0;
		}
		if (type_0.smethod_13())
		{
			Expression expression = Expression.Unbox(expression_0, type_0);
			if (bool_0 && type_0.smethod_14())
			{
				MethodInfo method = typeof(Convert).GetMethod("To" + type_0.Name, new Type[]
				{
					typeof(object)
				});
				if (method != null)
				{
					expression = Expression.Condition(Expression.TypeIs(expression_0, type_0), expression, Expression.Call(method, expression_0));
				}
			}
			return Expression.Condition(Expression.Equal(expression_0, Expression.Constant(null, typeof(object))), Expression.Default(type_0), expression);
		}
		return Expression.Convert(expression_0, type_0);
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x000071DE File Offset: 0x000053DE
	public Class83()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x000073CD File Offset: 0x000055CD
	// Note: this type is marked as 'beforefieldinit'.
	static Class83()
	{
		Class202.ofdixO4zTbIfy();
		Class83.class83_0 = new Class83();
	}

	// Token: 0x0400042B RID: 1067
	private static readonly Class83 class83_0;

	// Token: 0x020000D0 RID: 208
	private class Class56
	{
		// Token: 0x060006A2 RID: 1698 RVA: 0x00002621 File Offset: 0x00000821
		public Class56()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x0400042C RID: 1068
		public Expression expression_0;

		// Token: 0x0400042D RID: 1069
		public object object_0;

		// Token: 0x0400042E RID: 1070
		public bool bool_0;
	}

	// Token: 0x020000D1 RID: 209
	[CompilerGenerated]
	private sealed class Class57<wCBLY5sqMan7Doco8Ix>
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x00002621 File Offset: 0x00000821
		public Class57()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000073DE File Offset: 0x000055DE
		internal wCBLY5sqMan7Doco8Ix method_0()
		{
			return (wCBLY5sqMan7Doco8Ix)((object)Activator.CreateInstance(this.type_0));
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000073DE File Offset: 0x000055DE
		internal wCBLY5sqMan7Doco8Ix method_1()
		{
			return (wCBLY5sqMan7Doco8Ix)((object)Activator.CreateInstance(this.type_0));
		}

		// Token: 0x0400042F RID: 1071
		public Type type_0;
	}
}
