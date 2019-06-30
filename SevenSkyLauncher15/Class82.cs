using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

// Token: 0x020000C4 RID: 196
internal class Class82 : Class81
{
	// Token: 0x06000664 RID: 1636 RVA: 0x000071B3 File Offset: 0x000053B3
	[CompilerGenerated]
	internal static Class82 smethod_0()
	{
		return Class82.class82_0;
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x000071BA File Offset: 0x000053BA
	private static DynamicMethod smethod_1(string string_0, Type type_0, Type[] type_1, Type type_2)
	{
		if (type_2.smethod_3())
		{
			return new DynamicMethod(string_0, type_0, type_1, type_2.Module, true);
		}
		return new DynamicMethod(string_0, type_0, type_1, type_2, true);
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x0002A974 File Offset: 0x00028B74
	public override ObjectConstructor<object> vmethod_1(MethodBase methodBase_0)
	{
		DynamicMethod dynamicMethod = Class82.smethod_1(methodBase_0.ToString(), typeof(object), new Type[]
		{
			typeof(object[])
		}, methodBase_0.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.method_2(methodBase_0, ilgenerator, 0);
		return (ObjectConstructor<object>)dynamicMethod.CreateDelegate(typeof(ObjectConstructor<object>));
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x0002A9D4 File Offset: 0x00028BD4
	public override Delegate1<v0GGNXQ9bdsVHG9DrNM, object> vmethod_0<v0GGNXQ9bdsVHG9DrNM>(MethodBase methodBase_0)
	{
		DynamicMethod dynamicMethod = Class82.smethod_1(methodBase_0.ToString(), typeof(object), new Type[]
		{
			typeof(object),
			typeof(object[])
		}, methodBase_0.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.method_2(methodBase_0, ilgenerator, 1);
		return (Delegate1<v0GGNXQ9bdsVHG9DrNM, object>)dynamicMethod.CreateDelegate(typeof(Delegate1<v0GGNXQ9bdsVHG9DrNM, object>));
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x0002AA44 File Offset: 0x00028C44
	private void method_2(MethodBase methodBase_0, ILGenerator ilgenerator_0, int int_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Label label = ilgenerator_0.DefineLabel();
		ilgenerator_0.Emit(OpCodes.Ldarg, int_0);
		ilgenerator_0.Emit(OpCodes.Ldlen);
		ilgenerator_0.Emit(OpCodes.Ldc_I4, parameters.Length);
		ilgenerator_0.Emit(OpCodes.Beq, label);
		ilgenerator_0.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(Class90.type_0));
		ilgenerator_0.Emit(OpCodes.Throw);
		ilgenerator_0.MarkLabel(label);
		if (!methodBase_0.IsConstructor && !methodBase_0.IsStatic)
		{
			ilgenerator_0.smethod_0(methodBase_0.DeclaringType);
		}
		LocalBuilder local = ilgenerator_0.DeclareLocal(typeof(IConvertible));
		LocalBuilder local2 = ilgenerator_0.DeclareLocal(typeof(object));
		for (int i = 0; i < parameters.Length; i++)
		{
			ParameterInfo parameterInfo = parameters[i];
			Type type = parameterInfo.ParameterType;
			if (type.IsByRef)
			{
				type = type.GetElementType();
				LocalBuilder local3 = ilgenerator_0.DeclareLocal(type);
				if (!parameterInfo.IsOut)
				{
					ilgenerator_0.smethod_1(int_0, i);
					if (type.smethod_13())
					{
						Label label2 = ilgenerator_0.DefineLabel();
						Label label3 = ilgenerator_0.DefineLabel();
						ilgenerator_0.Emit(OpCodes.Brtrue_S, label2);
						ilgenerator_0.Emit(OpCodes.Ldloca_S, local3);
						ilgenerator_0.Emit(OpCodes.Initobj, type);
						ilgenerator_0.Emit(OpCodes.Br_S, label3);
						ilgenerator_0.MarkLabel(label2);
						ilgenerator_0.smethod_1(int_0, i);
						ilgenerator_0.smethod_3(type);
						ilgenerator_0.Emit(OpCodes.Stloc_S, local3);
						ilgenerator_0.MarkLabel(label3);
					}
					else
					{
						ilgenerator_0.smethod_3(type);
						ilgenerator_0.Emit(OpCodes.Stloc_S, local3);
					}
				}
				ilgenerator_0.Emit(OpCodes.Ldloca_S, local3);
			}
			else if (type.smethod_13())
			{
				ilgenerator_0.smethod_1(int_0, i);
				ilgenerator_0.Emit(OpCodes.Stloc_S, local2);
				Label label4 = ilgenerator_0.DefineLabel();
				Label label5 = ilgenerator_0.DefineLabel();
				ilgenerator_0.Emit(OpCodes.Ldloc_S, local2);
				ilgenerator_0.Emit(OpCodes.Brtrue_S, label4);
				LocalBuilder local4 = ilgenerator_0.DeclareLocal(type);
				ilgenerator_0.Emit(OpCodes.Ldloca_S, local4);
				ilgenerator_0.Emit(OpCodes.Initobj, type);
				ilgenerator_0.Emit(OpCodes.Ldloc_S, local4);
				ilgenerator_0.Emit(OpCodes.Br_S, label5);
				ilgenerator_0.MarkLabel(label4);
				if (type.smethod_14())
				{
					MethodInfo method = typeof(IConvertible).GetMethod("To" + type.Name, new Type[]
					{
						typeof(IFormatProvider)
					});
					if (method != null)
					{
						Label label6 = ilgenerator_0.DefineLabel();
						ilgenerator_0.Emit(OpCodes.Ldloc_S, local2);
						ilgenerator_0.Emit(OpCodes.Isinst, type);
						ilgenerator_0.Emit(OpCodes.Brtrue_S, label6);
						ilgenerator_0.Emit(OpCodes.Ldloc_S, local2);
						ilgenerator_0.Emit(OpCodes.Isinst, typeof(IConvertible));
						ilgenerator_0.Emit(OpCodes.Stloc_S, local);
						ilgenerator_0.Emit(OpCodes.Ldloc_S, local);
						ilgenerator_0.Emit(OpCodes.Brfalse_S, label6);
						ilgenerator_0.Emit(OpCodes.Ldloc_S, local);
						ilgenerator_0.Emit(OpCodes.Ldnull);
						ilgenerator_0.Emit(OpCodes.Callvirt, method);
						ilgenerator_0.Emit(OpCodes.Br_S, label5);
						ilgenerator_0.MarkLabel(label6);
					}
				}
				ilgenerator_0.Emit(OpCodes.Ldloc_S, local2);
				ilgenerator_0.smethod_3(type);
				ilgenerator_0.MarkLabel(label5);
			}
			else
			{
				ilgenerator_0.smethod_1(int_0, i);
				ilgenerator_0.smethod_3(type);
			}
		}
		if (methodBase_0.IsConstructor)
		{
			ilgenerator_0.Emit(OpCodes.Newobj, (ConstructorInfo)methodBase_0);
		}
		else
		{
			ilgenerator_0.smethod_4((MethodInfo)methodBase_0);
		}
		Type type2 = methodBase_0.IsConstructor ? methodBase_0.DeclaringType : ((MethodInfo)methodBase_0).ReturnType;
		if (type2 != typeof(void))
		{
			ilgenerator_0.smethod_2(type2);
		}
		else
		{
			ilgenerator_0.Emit(OpCodes.Ldnull);
		}
		ilgenerator_0.smethod_5();
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x0002AE38 File Offset: 0x00029038
	public override Func<vFU5QoQkQXC5cjyhYZF> vmethod_2<vFU5QoQkQXC5cjyhYZF>(Type type_0)
	{
		DynamicMethod dynamicMethod = Class82.smethod_1("Create" + type_0.FullName, typeof(vFU5QoQkQXC5cjyhYZF), Class90.type_0, type_0);
		dynamicMethod.InitLocals = true;
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.method_3(type_0, ilgenerator, typeof(vFU5QoQkQXC5cjyhYZF));
		return (Func<vFU5QoQkQXC5cjyhYZF>)dynamicMethod.CreateDelegate(typeof(Func<vFU5QoQkQXC5cjyhYZF>));
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x0002AEA0 File Offset: 0x000290A0
	private void method_3(Type type_0, ILGenerator ilgenerator_0, Type type_1)
	{
		if (type_0.smethod_13())
		{
			ilgenerator_0.DeclareLocal(type_0);
			ilgenerator_0.Emit(OpCodes.Ldloc_0);
			if (type_0 != type_1)
			{
				ilgenerator_0.Emit(OpCodes.Box, type_0);
			}
		}
		else
		{
			ConstructorInfo constructor = type_0.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Class90.type_0, null);
			if (constructor == null)
			{
				throw new ArgumentException("Could not get constructor for {0}.".smethod_0(CultureInfo.InvariantCulture, type_0));
			}
			ilgenerator_0.Emit(OpCodes.Newobj, constructor);
		}
		ilgenerator_0.smethod_5();
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x0002AF20 File Offset: 0x00029120
	public override Func<VQN19eQi9FaqZx6J1fn, object> vmethod_3<VQN19eQi9FaqZx6J1fn>(PropertyInfo propertyInfo_0)
	{
		DynamicMethod dynamicMethod = Class82.smethod_1("Get" + propertyInfo_0.Name, typeof(object), new Type[]
		{
			typeof(VQN19eQi9FaqZx6J1fn)
		}, propertyInfo_0.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.EoBslvuHmq(propertyInfo_0, ilgenerator);
		return (Func<VQN19eQi9FaqZx6J1fn, object>)dynamicMethod.CreateDelegate(typeof(Func<VQN19eQi9FaqZx6J1fn, object>));
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x0002AF8C File Offset: 0x0002918C
	private void EoBslvuHmq(PropertyInfo propertyInfo_0, ILGenerator ilgenerator_0)
	{
		MethodInfo getMethod = propertyInfo_0.GetGetMethod(true);
		if (getMethod == null)
		{
			throw new ArgumentException("Property '{0}' does not have a getter.".smethod_0(CultureInfo.InvariantCulture, propertyInfo_0.Name));
		}
		if (!getMethod.IsStatic)
		{
			ilgenerator_0.smethod_0(propertyInfo_0.DeclaringType);
		}
		ilgenerator_0.smethod_4(getMethod);
		ilgenerator_0.smethod_2(propertyInfo_0.PropertyType);
		ilgenerator_0.smethod_5();
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x0002AFF4 File Offset: 0x000291F4
	public override Func<cltM5VQtR7fpOWjPFm7, object> vmethod_4<cltM5VQtR7fpOWjPFm7>(FieldInfo fieldInfo_0)
	{
		if (fieldInfo_0.IsLiteral)
		{
			Class82.Class46<cltM5VQtR7fpOWjPFm7> @class = new Class82.Class46<cltM5VQtR7fpOWjPFm7>();
			@class.object_0 = fieldInfo_0.GetValue(null);
			return new Func<cltM5VQtR7fpOWjPFm7, object>(@class.method_0);
		}
		DynamicMethod dynamicMethod = Class82.smethod_1("Get" + fieldInfo_0.Name, typeof(cltM5VQtR7fpOWjPFm7), new Type[]
		{
			typeof(object)
		}, fieldInfo_0.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		this.method_4(fieldInfo_0, ilgenerator);
		return (Func<cltM5VQtR7fpOWjPFm7, object>)dynamicMethod.CreateDelegate(typeof(Func<cltM5VQtR7fpOWjPFm7, object>));
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x0002B084 File Offset: 0x00029284
	private void method_4(FieldInfo fieldInfo_0, ILGenerator ilgenerator_0)
	{
		if (!fieldInfo_0.IsStatic)
		{
			ilgenerator_0.smethod_0(fieldInfo_0.DeclaringType);
			ilgenerator_0.Emit(OpCodes.Ldfld, fieldInfo_0);
		}
		else
		{
			ilgenerator_0.Emit(OpCodes.Ldsfld, fieldInfo_0);
		}
		ilgenerator_0.smethod_2(fieldInfo_0.FieldType);
		ilgenerator_0.smethod_5();
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x0002B0D4 File Offset: 0x000292D4
	public override Action<MJYpMfQbLbrsA3DIU9e, object> vmethod_5<MJYpMfQbLbrsA3DIU9e>(FieldInfo fieldInfo_0)
	{
		DynamicMethod dynamicMethod = Class82.smethod_1("Set" + fieldInfo_0.Name, null, new Type[]
		{
			typeof(MJYpMfQbLbrsA3DIU9e),
			typeof(object)
		}, fieldInfo_0.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		Class82.smethod_2(fieldInfo_0, ilgenerator);
		return (Action<MJYpMfQbLbrsA3DIU9e, object>)dynamicMethod.CreateDelegate(typeof(Action<MJYpMfQbLbrsA3DIU9e, object>));
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x0002B140 File Offset: 0x00029340
	internal static void smethod_2(object object_0, ILGenerator ilgenerator_0)
	{
		if (!object_0.IsStatic)
		{
			ilgenerator_0.smethod_0(object_0.DeclaringType);
		}
		ilgenerator_0.Emit(OpCodes.Ldarg_1);
		ilgenerator_0.smethod_3(object_0.FieldType);
		if (!object_0.IsStatic)
		{
			ilgenerator_0.Emit(OpCodes.Stfld, object_0);
		}
		else
		{
			ilgenerator_0.Emit(OpCodes.Stsfld, object_0);
		}
		ilgenerator_0.smethod_5();
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x0002B1A0 File Offset: 0x000293A0
	public override Action<uLWSQuQBepGjQiTP8lF, object> vmethod_6<uLWSQuQBepGjQiTP8lF>(PropertyInfo propertyInfo_0)
	{
		DynamicMethod dynamicMethod = Class82.smethod_1("Set" + propertyInfo_0.Name, null, new Type[]
		{
			typeof(uLWSQuQBepGjQiTP8lF),
			typeof(object)
		}, propertyInfo_0.DeclaringType);
		ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
		Class82.smethod_3(propertyInfo_0, ilgenerator);
		return (Action<uLWSQuQBepGjQiTP8lF, object>)dynamicMethod.CreateDelegate(typeof(Action<uLWSQuQBepGjQiTP8lF, object>));
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x0002B20C File Offset: 0x0002940C
	internal static void smethod_3(object object_0, ILGenerator ilgenerator_0)
	{
		MethodInfo setMethod = object_0.GetSetMethod(true);
		if (!setMethod.IsStatic)
		{
			ilgenerator_0.smethod_0(object_0.DeclaringType);
		}
		ilgenerator_0.Emit(OpCodes.Ldarg_1);
		ilgenerator_0.smethod_3(object_0.PropertyType);
		ilgenerator_0.smethod_4(setMethod);
		ilgenerator_0.smethod_5();
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x000071DE File Offset: 0x000053DE
	public Class82()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x000071EB File Offset: 0x000053EB
	// Note: this type is marked as 'beforefieldinit'.
	static Class82()
	{
		Class202.ofdixO4zTbIfy();
		Class82.class82_0 = new Class82();
	}

	// Token: 0x04000417 RID: 1047
	[CompilerGenerated]
	private static readonly Class82 class82_0;

	// Token: 0x020000C5 RID: 197
	[CompilerGenerated]
	private sealed class Class46<nGJfP7sLj3IKOVY4ZfN>
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x00002621 File Offset: 0x00000821
		public Class46()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000071FC File Offset: 0x000053FC
		internal object method_0(nGJfP7sLj3IKOVY4ZfN d1QJaisWEw9g1D7oqqY)
		{
			return this.object_0;
		}

		// Token: 0x04000418 RID: 1048
		public object object_0;
	}
}
