using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x020001AA RID: 426
internal abstract class Class156
{
	// Token: 0x06000ED9 RID: 3801
	public abstract IEnumerable<JToken> vmethod_0(JToken jtoken_0, IEnumerable<JToken> ienumerable_0, bool bool_0);

	// Token: 0x06000EDA RID: 3802 RVA: 0x00045CA0 File Offset: 0x00043EA0
	protected static JToken smethod_0(object object_0, bool bool_0, int int_0)
	{
		JArray jarray;
		JConstructor jconstructor;
		if ((jarray = (object_0 as JArray)) != null)
		{
			if (jarray.Count > int_0)
			{
				return jarray[int_0];
			}
			if (bool_0)
			{
				throw new JsonException("Index {0} outside the bounds of JArray.".smethod_0(CultureInfo.InvariantCulture, int_0));
			}
			return null;
		}
		else if ((jconstructor = (object_0 as JConstructor)) != null)
		{
			if (jconstructor.Count > int_0)
			{
				return jconstructor[int_0];
			}
			if (bool_0)
			{
				throw new JsonException("Index {0} outside the bounds of JConstructor.".smethod_0(CultureInfo.InvariantCulture, int_0));
			}
			return null;
		}
		else
		{
			if (bool_0)
			{
				throw new JsonException("Index {0} not valid on {1}.".smethod_1(CultureInfo.InvariantCulture, int_0, object_0.GetType().Name));
			}
			return null;
		}
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x00045D54 File Offset: 0x00043F54
	protected static JToken smethod_1(object object_0, JToken jtoken_0, JToken jtoken_1)
	{
		if (jtoken_0 == null || !jtoken_0.HasValues)
		{
			while (jtoken_1 != null && jtoken_1 != object_0)
			{
				if (jtoken_1 != jtoken_1.Parent.Last)
				{
					break;
				}
				jtoken_1 = jtoken_1.Parent;
			}
			if (jtoken_1 != null)
			{
				if (jtoken_1 != object_0)
				{
					return jtoken_1.Next;
				}
			}
			return null;
		}
		jtoken_1 = jtoken_0.First;
		return jtoken_1;
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00002621 File Offset: 0x00000821
	protected Class156()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}
}
