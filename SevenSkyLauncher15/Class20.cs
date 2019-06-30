using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x020000A3 RID: 163
internal static class Class20
{
	// Token: 0x0600057C RID: 1404 RVA: 0x0000664F File Offset: 0x0000484F
	public static bool smethod_0<G7HpdQWxOMl81rx4e9>(ICollection<G7HpdQWxOMl81rx4e9> icollection_0)
	{
		return icollection_0 == null || icollection_0.Count == 0;
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00026E34 File Offset: 0x00025034
	public static void smethod_1<WH3slp9xWukB26tkP1>(this IList<WH3slp9xWukB26tkP1> ilist_0, IEnumerable<WH3slp9xWukB26tkP1> ienumerable_0)
	{
		if (ilist_0 == null)
		{
			throw new ArgumentNullException("initial");
		}
		if (ienumerable_0 == null)
		{
			return;
		}
		foreach (WH3slp9xWukB26tkP1 item in ienumerable_0)
		{
			ilist_0.Add(item);
		}
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00026E90 File Offset: 0x00025090
	public static bool smethod_2(Type type_0)
	{
		Class101.smethod_0(type_0, "type");
		return typeof(IDictionary).IsAssignableFrom(type_0) || Class90.smethod_15(type_0, typeof(IDictionary<, >)) || Class90.smethod_15(type_0, typeof(IReadOnlyDictionary<, >));
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00026EE8 File Offset: 0x000250E8
	public static ConstructorInfo smethod_3(Type type_0, Type type_1)
	{
		Type type_2 = typeof(IList<>).MakeGenericType(new Type[]
		{
			type_1
		});
		return Class20.smethod_4(type_0, type_1, type_2);
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00026F18 File Offset: 0x00025118
	public static ConstructorInfo smethod_4(Type type_0, Type type_1, Type type_2)
	{
		Type left = typeof(IEnumerable<>).MakeGenericType(new Type[]
		{
			type_1
		});
		ConstructorInfo constructorInfo = null;
		foreach (ConstructorInfo constructorInfo2 in type_0.GetConstructors(BindingFlags.Instance | BindingFlags.Public))
		{
			IList<ParameterInfo> parameters = constructorInfo2.GetParameters();
			if (parameters.Count == 1)
			{
				Type parameterType = parameters[0].ParameterType;
				if (left == parameterType)
				{
					constructorInfo = constructorInfo2;
					return constructorInfo;
				}
				if (constructorInfo == null && parameterType.IsAssignableFrom(type_2))
				{
					constructorInfo = constructorInfo2;
				}
			}
		}
		return constructorInfo;
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0000665F File Offset: 0x0000485F
	public static bool smethod_5<g1YG1ukZy8j8TrOaKv>(this IList<g1YG1ukZy8j8TrOaKv> ilist_0, g1YG1ukZy8j8TrOaKv WluoX5ijjjmWQCsuNB)
	{
		return ilist_0.smethod_6(WluoX5ijjjmWQCsuNB, EqualityComparer<g1YG1ukZy8j8TrOaKv>.Default);
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x0000666D File Offset: 0x0000486D
	public static bool smethod_6<hXi44OtFGi6Nrs8gCm>(this IList<hXi44OtFGi6Nrs8gCm> ilist_0, hXi44OtFGi6Nrs8gCm P8OHHfbQjVgdoKILMQ, IEqualityComparer<hXi44OtFGi6Nrs8gCm> iequalityComparer_0)
	{
		if (ilist_0.smethod_7(P8OHHfbQjVgdoKILMQ, iequalityComparer_0))
		{
			return false;
		}
		ilist_0.Add(P8OHHfbQjVgdoKILMQ);
		return true;
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x00026FAC File Offset: 0x000251AC
	public static bool smethod_7<qAOf5CBe0lGLMfc3M5>(this IEnumerable<qAOf5CBe0lGLMfc3M5> ienumerable_0, qAOf5CBe0lGLMfc3M5 HOhOL2qkbs4rICJAFV, IEqualityComparer<qAOf5CBe0lGLMfc3M5> iequalityComparer_0)
	{
		if (iequalityComparer_0 == null)
		{
			iequalityComparer_0 = EqualityComparer<qAOf5CBe0lGLMfc3M5>.Default;
		}
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("source");
		}
		foreach (qAOf5CBe0lGLMfc3M5 x in ienumerable_0)
		{
			if (iequalityComparer_0.Equals(x, HOhOL2qkbs4rICJAFV))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x00027018 File Offset: 0x00025218
	public static bool smethod_8<fZm0Wu4BQkIGjT89Xa>(this IList<fZm0Wu4BQkIGjT89Xa> ilist_0, IEnumerable<fZm0Wu4BQkIGjT89Xa> ienumerable_0, IEqualityComparer<fZm0Wu4BQkIGjT89Xa> iequalityComparer_0)
	{
		bool result = true;
		foreach (fZm0Wu4BQkIGjT89Xa p8OHHfbQjVgdoKILMQ in ienumerable_0)
		{
			if (!ilist_0.smethod_6(p8OHHfbQjVgdoKILMQ, iequalityComparer_0))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0002706C File Offset: 0x0002526C
	public static int smethod_9<utZ5K4ZMl62D3qviaR>(this IEnumerable<utZ5K4ZMl62D3qviaR> ienumerable_0, Func<utZ5K4ZMl62D3qviaR, bool> func_0)
	{
		int num = 0;
		foreach (utZ5K4ZMl62D3qviaR arg in ienumerable_0)
		{
			if (func_0(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x000270C4 File Offset: 0x000252C4
	public static bool smethod_10<VWEXQDFdJ2et6r97Jk>(this List<VWEXQDFdJ2et6r97Jk> list_0, VWEXQDFdJ2et6r97Jk DeH36unBHqQepa8SKy, IEqualityComparer iequalityComparer_0)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			if (iequalityComparer_0.Equals(DeH36unBHqQepa8SKy, list_0[i]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x00027100 File Offset: 0x00025300
	public static int smethod_11<IAcmAkgaJQtYZtNwVB>(this List<IAcmAkgaJQtYZtNwVB> list_0, IAcmAkgaJQtYZtNwVB eDqIdYNIVo4hapaas9)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			if (eDqIdYNIVo4hapaas9 == list_0[i])
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x00027138 File Offset: 0x00025338
	public static void smethod_12<SZMQ9YPnQ9orSF7Bm8>(this List<SZMQ9YPnQ9orSF7Bm8> list_0)
	{
		int i = 0;
		int num = list_0.Count - 1;
		while (i < num)
		{
			SZMQ9YPnQ9orSF7Bm8 value = list_0[i];
			list_0[i] = list_0[num];
			list_0[num] = value;
			i++;
			num--;
		}
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x0002717C File Offset: 0x0002537C
	private static IList<int> smethod_13(IList ilist_0, int int_0)
	{
		IList<int> list = new List<int>();
		IList list2 = ilist_0;
		for (;;)
		{
			list.Add(list2.Count);
			IList list3;
			if (list.Count == int_0 || list2.Count == 0 || (list3 = (list2[0] as IList)) == null)
			{
				break;
			}
			list2 = list3;
		}
		return list;
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x000271C8 File Offset: 0x000253C8
	private static void smethod_14(IList ilist_0, Array array_0, int[] int_0)
	{
		int num = int_0.Length;
		if (num == array_0.Rank)
		{
			array_0.SetValue(Class20.smethod_15(ilist_0, int_0), int_0);
			return;
		}
		int length = array_0.GetLength(num);
		if (((IList)Class20.smethod_15(ilist_0, int_0)).Count != length)
		{
			throw new Exception("Cannot deserialize non-cubical array as multidimensional array.");
		}
		int[] array = new int[num + 1];
		for (int i = 0; i < num; i++)
		{
			array[i] = int_0[i];
		}
		for (int j = 0; j < array_0.GetLength(num); j++)
		{
			array[num] = j;
			Class20.smethod_14(ilist_0, array_0, array);
		}
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x00027254 File Offset: 0x00025454
	private static object smethod_15(IList ilist_0, object object_0)
	{
		IList list = ilist_0;
		for (int i = 0; i < object_0.Length; i++)
		{
			int index = object_0[i];
			if (i == object_0.Length - 1)
			{
				return list[index];
			}
			list = (IList)list[index];
		}
		return list;
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00027298 File Offset: 0x00025498
	public static Array smethod_16(IList ilist_0, Type type_0, int int_0)
	{
		IList<int> list = Class20.smethod_13(ilist_0, int_0);
		while (list.Count < int_0)
		{
			list.Add(0);
		}
		Array array = Array.CreateInstance(type_0, list.ToArray<int>());
		Class20.smethod_14(ilist_0, array, Class20.smethod_17<int>());
		return array;
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00006683 File Offset: 0x00004883
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static KgXuHQ6YyrvvX99EeK[] smethod_17<KgXuHQ6YyrvvX99EeK>()
	{
		return (Enumerable.Empty<KgXuHQ6YyrvvX99EeK>() as KgXuHQ6YyrvvX99EeK[]) ?? new KgXuHQ6YyrvvX99EeK[0];
	}
}
