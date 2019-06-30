using System;
using System.Reflection.Emit;

// Token: 0x020000D7 RID: 215
internal static class Class63
{
	// Token: 0x060006CA RID: 1738 RVA: 0x0000753C File Offset: 0x0000573C
	public static void smethod_0(this ILGenerator ilgenerator_0, Type type_0)
	{
		ilgenerator_0.Emit(OpCodes.Ldarg_0);
		if (type_0.smethod_13())
		{
			ilgenerator_0.Emit(OpCodes.Unbox, type_0);
			return;
		}
		ilgenerator_0.Emit(OpCodes.Castclass, type_0);
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x0000756A File Offset: 0x0000576A
	public static void smethod_1(this ILGenerator ilgenerator_0, int int_0, int int_1)
	{
		ilgenerator_0.Emit(OpCodes.Ldarg, int_0);
		ilgenerator_0.Emit(OpCodes.Ldc_I4, int_1);
		ilgenerator_0.Emit(OpCodes.Ldelem_Ref);
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x0000758F File Offset: 0x0000578F
	public static void smethod_2(this ILGenerator ilgenerator_0, Type type_0)
	{
		if (type_0.smethod_13())
		{
			ilgenerator_0.Emit(OpCodes.Box, type_0);
			return;
		}
		ilgenerator_0.Emit(OpCodes.Castclass, type_0);
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x000075B2 File Offset: 0x000057B2
	public static void smethod_3(this ILGenerator ilgenerator_0, Type type_0)
	{
		if (type_0.smethod_13())
		{
			ilgenerator_0.Emit(OpCodes.Unbox_Any, type_0);
			return;
		}
		ilgenerator_0.Emit(OpCodes.Castclass, type_0);
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x000075D5 File Offset: 0x000057D5
	public static void smethod_4(this ILGenerator ilgenerator_0, object object_0)
	{
		if (!object_0.IsFinal && object_0.IsVirtual)
		{
			ilgenerator_0.Emit(OpCodes.Callvirt, object_0);
			return;
		}
		ilgenerator_0.Emit(OpCodes.Call, object_0);
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00007600 File Offset: 0x00005800
	public static void smethod_5(this ILGenerator ilgenerator_0)
	{
		ilgenerator_0.Emit(OpCodes.Ret);
	}
}
