using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

// Token: 0x0200013F RID: 319
internal static class Class124
{
	// Token: 0x060009F2 RID: 2546 RVA: 0x0000950A File Offset: 0x0000770A
	public static LbemhZdkgQyvmOHEhvD smethod_0<LbemhZdkgQyvmOHEhvD>(object object_0) where LbemhZdkgQyvmOHEhvD : Attribute
	{
		return Class102<LbemhZdkgQyvmOHEhvD>.smethod_0(object_0);
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00038560 File Offset: 0x00036760
	public static bool smethod_1(Type type_0, out TypeConverter typeConverter_0)
	{
		typeConverter_0 = TypeDescriptor.GetConverter(type_0);
		if (typeConverter_0 != null)
		{
			Type type = typeConverter_0.GetType();
			if (!string.Equals(type.FullName, "System.ComponentModel.ComponentConverter", StringComparison.Ordinal) && !string.Equals(type.FullName, "System.ComponentModel.ReferenceConverter", StringComparison.Ordinal) && !string.Equals(type.FullName, "System.Windows.Forms.Design.DataSourceConverter", StringComparison.Ordinal) && type != typeof(TypeConverter))
			{
				return typeConverter_0.CanConvertTo(typeof(string));
			}
		}
		return false;
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x000385E4 File Offset: 0x000367E4
	public static DataContractAttribute smethod_2(Type type_0)
	{
		Type type = type_0;
		while (type != null)
		{
			DataContractAttribute dataContractAttribute = Class102<DataContractAttribute>.smethod_0(type);
			if (dataContractAttribute != null)
			{
				return dataContractAttribute;
			}
			type = type.smethod_6();
		}
		return null;
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00038614 File Offset: 0x00036814
	public static DataMemberAttribute smethod_3(object object_0)
	{
		if (object_0.smethod_1() == MemberTypes.Field)
		{
			return Class102<DataMemberAttribute>.smethod_0(object_0);
		}
		PropertyInfo propertyInfo = (PropertyInfo)object_0;
		DataMemberAttribute dataMemberAttribute = Class102<DataMemberAttribute>.smethod_0(propertyInfo);
		if (dataMemberAttribute == null && propertyInfo.smethod_0())
		{
			Type type = propertyInfo.DeclaringType;
			while (dataMemberAttribute == null && type != null)
			{
				PropertyInfo propertyInfo2 = (PropertyInfo)Class90.smethod_37(type, propertyInfo);
				if (propertyInfo2 != null && propertyInfo2.smethod_0())
				{
					dataMemberAttribute = Class102<DataMemberAttribute>.smethod_0(propertyInfo2);
				}
				type = type.smethod_6();
			}
		}
		return dataMemberAttribute;
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x0003868C File Offset: 0x0003688C
	public static MemberSerialization smethod_4(Type type_0, bool bool_0)
	{
		JsonObjectAttribute jsonObjectAttribute = Class124.smethod_0<JsonObjectAttribute>(type_0);
		if (jsonObjectAttribute != null)
		{
			return jsonObjectAttribute.MemberSerialization;
		}
		if (Class124.smethod_2(type_0) != null)
		{
			return MemberSerialization.OptIn;
		}
		if (!bool_0 && Class124.smethod_15(type_0))
		{
			return MemberSerialization.Fields;
		}
		return MemberSerialization.OptOut;
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x000386C4 File Offset: 0x000368C4
	public static JsonConverter smethod_5(object object_0)
	{
		JsonConverterAttribute jsonConverterAttribute = Class124.smethod_0<JsonConverterAttribute>(object_0);
		if (jsonConverterAttribute != null)
		{
			Func<object[], object> func = Class124.iOhAeZguXU.Get(jsonConverterAttribute.ConverterType);
			if (func != null)
			{
				return (JsonConverter)func(jsonConverterAttribute.ConverterParameters);
			}
		}
		return null;
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00009512 File Offset: 0x00007712
	public static JsonConverter smethod_6(Type type_0, object object_0)
	{
		return (JsonConverter)Class124.iOhAeZguXU.Get(type_0)(object_0);
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x0000952A File Offset: 0x0000772A
	public static NamingStrategy smethod_7(Type type_0, object object_0)
	{
		return (NamingStrategy)Class124.iOhAeZguXU.Get(type_0)(object_0);
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00009542 File Offset: 0x00007742
	public static NamingStrategy smethod_8(JsonContainerAttribute jsonContainerAttribute_0)
	{
		if (jsonContainerAttribute_0.method_0() == null)
		{
			if (jsonContainerAttribute_0.NamingStrategyType == null)
			{
				return null;
			}
			jsonContainerAttribute_0.method_1(Class124.smethod_7(jsonContainerAttribute_0.NamingStrategyType, jsonContainerAttribute_0.NamingStrategyParameters));
		}
		return jsonContainerAttribute_0.method_0();
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00038704 File Offset: 0x00036904
	private static Func<object[], object> smethod_9(Type type_0)
	{
		Class124.Class125 @class = new Class124.Class125();
		@class.type_0 = type_0;
		@class.func_0 = (Class90.smethod_7(@class.type_0, false) ? Class124.smethod_19().vmethod_2<object>(@class.type_0) : null);
		return new Func<object[], object>(@class.method_0);
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00009579 File Offset: 0x00007779
	private static Type smethod_10(Type type_0)
	{
		return Class124.class99_0.Get(type_0);
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x00038754 File Offset: 0x00036954
	private static Type smethod_11(Type type_0)
	{
		foreach (Attribute attribute in Class90.smethod_34(type_0, null, true))
		{
			Type type = attribute.GetType();
			if (string.Equals(type.FullName, "System.ComponentModel.DataAnnotations.MetadataTypeAttribute", StringComparison.Ordinal))
			{
				if (Class124.class86_0 == null)
				{
					Class124.class86_0 = Class86.Create(type, new string[]
					{
						"MetadataClassType"
					});
				}
				return (Type)Class124.class86_0.method_2(attribute, "MetadataClassType");
			}
		}
		return null;
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x000387D4 File Offset: 0x000369D4
	private static OshAAEdiySOMFe7YuI8 smethod_12<OshAAEdiySOMFe7YuI8>(Type type_0) where OshAAEdiySOMFe7YuI8 : Attribute
	{
		Type type = Class124.smethod_10(type_0);
		OshAAEdiySOMFe7YuI8 oshAAEdiySOMFe7YuI;
		if (type != null)
		{
			oshAAEdiySOMFe7YuI = Class90.smethod_32<OshAAEdiySOMFe7YuI8>(type, true);
			if (oshAAEdiySOMFe7YuI != null)
			{
				return oshAAEdiySOMFe7YuI;
			}
		}
		oshAAEdiySOMFe7YuI = Class90.smethod_32<OshAAEdiySOMFe7YuI8>(type_0, true);
		if (oshAAEdiySOMFe7YuI != null)
		{
			return oshAAEdiySOMFe7YuI;
		}
		Type[] interfaces = type_0.GetInterfaces();
		for (int i = 0; i < interfaces.Length; i++)
		{
			oshAAEdiySOMFe7YuI = Class90.smethod_32<OshAAEdiySOMFe7YuI8>(interfaces[i], true);
			if (oshAAEdiySOMFe7YuI != null)
			{
				return oshAAEdiySOMFe7YuI;
			}
		}
		return default(OshAAEdiySOMFe7YuI8);
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x0003884C File Offset: 0x00036A4C
	private static D9OIlddtdXBXEWa8CH9 smethod_13<D9OIlddtdXBXEWa8CH9>(MemberInfo memberInfo_0) where D9OIlddtdXBXEWa8CH9 : Attribute
	{
		Type type = Class124.smethod_10(memberInfo_0.DeclaringType);
		D9OIlddtdXBXEWa8CH9 d9OIlddtdXBXEWa8CH;
		if (type != null)
		{
			MemberInfo memberInfo = Class90.smethod_37(type, memberInfo_0);
			if (memberInfo != null)
			{
				d9OIlddtdXBXEWa8CH = Class90.smethod_32<D9OIlddtdXBXEWa8CH9>(memberInfo, true);
				if (d9OIlddtdXBXEWa8CH != null)
				{
					return d9OIlddtdXBXEWa8CH;
				}
			}
		}
		d9OIlddtdXBXEWa8CH = Class90.smethod_32<D9OIlddtdXBXEWa8CH9>(memberInfo_0, true);
		if (d9OIlddtdXBXEWa8CH != null)
		{
			return d9OIlddtdXBXEWa8CH;
		}
		if (memberInfo_0.DeclaringType != null)
		{
			Type[] interfaces = memberInfo_0.DeclaringType.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				MemberInfo memberInfo2 = Class90.smethod_37(interfaces[i], memberInfo_0);
				if (memberInfo2 != null)
				{
					d9OIlddtdXBXEWa8CH = Class90.smethod_32<D9OIlddtdXBXEWa8CH9>(memberInfo2, true);
					if (d9OIlddtdXBXEWa8CH != null)
					{
						return d9OIlddtdXBXEWa8CH;
					}
				}
			}
		}
		return default(D9OIlddtdXBXEWa8CH9);
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00009586 File Offset: 0x00007786
	public static bool smethod_14(ICustomAttributeProvider icustomAttributeProvider_0)
	{
		return Class90.smethod_32<NonSerializedAttribute>(icustomAttributeProvider_0, false) != null;
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00009592 File Offset: 0x00007792
	public static bool smethod_15(ICustomAttributeProvider icustomAttributeProvider_0)
	{
		return Class90.smethod_32<SerializableAttribute>(icustomAttributeProvider_0, false) != null;
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00038908 File Offset: 0x00036B08
	public static crA8Gidbto0MysfJeyj smethod_16<crA8Gidbto0MysfJeyj>(ICustomAttributeProvider icustomAttributeProvider_0) where crA8Gidbto0MysfJeyj : Attribute
	{
		Type type_;
		if ((type_ = (icustomAttributeProvider_0 as Type)) != null)
		{
			return Class124.smethod_12<crA8Gidbto0MysfJeyj>(type_);
		}
		MemberInfo memberInfo_;
		if ((memberInfo_ = (icustomAttributeProvider_0 as MemberInfo)) != null)
		{
			return Class124.smethod_13<crA8Gidbto0MysfJeyj>(memberInfo_);
		}
		return Class90.smethod_32<crA8Gidbto0MysfJeyj>(icustomAttributeProvider_0, true);
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00038940 File Offset: 0x00036B40
	[SecuritySafeCritical]
	public static bool smethod_17()
	{
		if (Class124.nullable_0 == null)
		{
			try
			{
				new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
				new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
				new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
				new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
				new SecurityPermission(PermissionState.Unrestricted).Demand();
				Class124.nullable_0 = new bool?(true);
			}
			catch (Exception)
			{
				Class124.nullable_0 = new bool?(false);
			}
		}
		return Class124.nullable_0.GetValueOrDefault();
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x000389C8 File Offset: 0x00036BC8
	public static bool smethod_18()
	{
		if (Class124.nullable_1 == null)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Class124.nullable_1 = new bool?(currentDomain.IsHomogenous && currentDomain.IsFullyTrusted);
		}
		return Class124.nullable_1.GetValueOrDefault();
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x0000959E File Offset: 0x0000779E
	public static Class81 smethod_19()
	{
		if (Class124.smethod_17())
		{
			return Class82.smethod_0();
		}
		return Class84.smethod_0();
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x000095B2 File Offset: 0x000077B2
	// Note: this type is marked as 'beforefieldinit'.
	static Class124()
	{
		Class202.ofdixO4zTbIfy();
		Class124.iOhAeZguXU = new Class99<Type, Func<object[], object>>(new Func<Type, Func<object[], object>>(Class124.smethod_9));
		Class124.class99_0 = new Class99<Type, Type>(new Func<Type, Type>(Class124.smethod_11));
	}

	// Token: 0x04000562 RID: 1378
	private static bool? nullable_0;

	// Token: 0x04000563 RID: 1379
	private static bool? nullable_1;

	// Token: 0x04000564 RID: 1380
	private static readonly Class99<Type, Func<object[], object>> iOhAeZguXU;

	// Token: 0x04000565 RID: 1381
	private static readonly Class99<Type, Type> class99_0;

	// Token: 0x04000566 RID: 1382
	private static Class86 class86_0;

	// Token: 0x02000140 RID: 320
	[CompilerGenerated]
	private sealed class Class125
	{
		// Token: 0x06000A07 RID: 2567 RVA: 0x00002621 File Offset: 0x00000821
		public Class125()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00038A0C File Offset: 0x00036C0C
		internal object method_0(object[] object_0)
		{
			object result;
			try
			{
				if (object_0 != null)
				{
					Type[] types = object_0.Select(new Func<object, Type>(Class124.Class126.class126_0.method_0)).ToArray<Type>();
					ConstructorInfo constructor = this.type_0.GetConstructor(types);
					if (!(constructor != null))
					{
						throw new JsonException("No matching parameterized constructor found for '{0}'.".smethod_0(CultureInfo.InvariantCulture, this.type_0));
					}
					result = Class124.smethod_19().vmethod_1(constructor)(object_0);
				}
				else
				{
					if (this.func_0 == null)
					{
						throw new JsonException("No parameterless constructor defined for '{0}'.".smethod_0(CultureInfo.InvariantCulture, this.type_0));
					}
					result = this.func_0();
				}
			}
			catch (Exception innerException)
			{
				throw new JsonException("Error creating '{0}'.".smethod_0(CultureInfo.InvariantCulture, this.type_0), innerException);
			}
			return result;
		}

		// Token: 0x04000567 RID: 1383
		public Type type_0;

		// Token: 0x04000568 RID: 1384
		public Func<object> func_0;
	}

	// Token: 0x02000141 RID: 321
	[CompilerGenerated]
	[Serializable]
	private sealed class Class126
	{
		// Token: 0x06000A09 RID: 2569 RVA: 0x000095E5 File Offset: 0x000077E5
		// Note: this type is marked as 'beforefieldinit'.
		static Class126()
		{
			Class202.ofdixO4zTbIfy();
			Class124.Class126.class126_0 = new Class124.Class126();
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00002621 File Offset: 0x00000821
		public Class126()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x000095F6 File Offset: 0x000077F6
		internal Type method_0(object object_0)
		{
			if (object_0 == null)
			{
				throw new InvalidOperationException("Cannot pass a null parameter to the constructor.");
			}
			return object_0.GetType();
		}

		// Token: 0x04000569 RID: 1385
		public static readonly Class124.Class126 class126_0;

		// Token: 0x0400056A RID: 1386
		public static Func<object, Type> func_0;
	}
}
