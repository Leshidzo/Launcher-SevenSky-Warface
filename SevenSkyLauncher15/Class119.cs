using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

// Token: 0x0200013C RID: 316
internal class Class119 : Class117
{
	// Token: 0x06000987 RID: 2439 RVA: 0x00009065 File Offset: 0x00007265
	public Class119(JsonSerializer jsonSerializer_1)
	{
		Class202.ofdixO4zTbIfy();
		this.list_0 = new List<object>();
		base..ctor(jsonSerializer_1);
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00036AEC File Offset: 0x00034CEC
	public void method_5(JsonWriter jsonWriter_0, object object_0, Type type_1)
	{
		if (jsonWriter_0 == null)
		{
			throw new ArgumentNullException("jsonWriter");
		}
		this.type_0 = type_1;
		this.int_0 = this.list_0.Count + 1;
		JsonContract jsonContract_ = this.method_7(object_0);
		try
		{
			if (this.method_11(object_0, null, jsonContract_, null, null))
			{
				this.method_14(jsonWriter_0, object_0);
			}
			else
			{
				this.method_9(jsonWriter_0, object_0, jsonContract_, null, null, null);
			}
		}
		catch (Exception exception_)
		{
			if (!base.method_4(null, jsonContract_, null, null, jsonWriter_0.Path, exception_))
			{
				base.method_3();
				throw;
			}
			this.method_39(jsonWriter_0, 0);
		}
		finally
		{
			this.type_0 = null;
		}
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x0000907E File Offset: 0x0000727E
	private Class9 method_6()
	{
		if (this.class9_0 == null)
		{
			this.class9_0 = new Class9(this);
		}
		return this.class9_0;
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x0000909A File Offset: 0x0000729A
	private JsonContract method_7(object object_0)
	{
		if (object_0 == null)
		{
			return null;
		}
		return this.jsonSerializer_0.icontractResolver_0.ResolveContract(object_0.GetType());
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00036B98 File Offset: 0x00034D98
	private void method_8(JsonWriter jsonWriter_0, object object_0, JsonPrimitiveContract jsonPrimitiveContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		if (jsonPrimitiveContract_0.method_5() == (Enum3)40 && this.method_36(TypeNameHandling.Objects, jsonPrimitiveContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1))
		{
			jsonWriter_0.WriteStartObject();
			this.method_24(jsonWriter_0, jsonPrimitiveContract_0.CreatedType);
			jsonWriter_0.WritePropertyName("$value", false);
			JsonWriter.smethod_2(jsonWriter_0, jsonPrimitiveContract_0.method_5(), object_0);
			jsonWriter_0.WriteEndObject();
			return;
		}
		JsonWriter.smethod_2(jsonWriter_0, jsonPrimitiveContract_0.method_5(), object_0);
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00036C00 File Offset: 0x00034E00
	private void method_9(JsonWriter jsonWriter_0, object object_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		if (object_0 == null)
		{
			jsonWriter_0.WriteNull();
			return;
		}
		JsonConverter jsonConverter;
		if (jsonProperty_0 != null)
		{
			if ((jsonConverter = jsonProperty_0.Converter) != null)
			{
				goto IL_65;
			}
		}
		if (jsonProperty_1 != null)
		{
			if ((jsonConverter = jsonProperty_1.ItemConverter) != null)
			{
				goto IL_65;
			}
		}
		if (jsonContainerContract_0 != null)
		{
			if ((jsonConverter = jsonContainerContract_0.ItemConverter) != null)
			{
				goto IL_65;
			}
		}
		if ((jsonConverter = jsonContract_0.Converter) == null)
		{
			jsonConverter = (this.jsonSerializer_0.method_5(jsonContract_0.UnderlyingType) ?? jsonContract_0.InternalConverter);
		}
		IL_65:
		JsonConverter jsonConverter2 = jsonConverter;
		if (jsonConverter2 != null && jsonConverter2.CanWrite)
		{
			this.method_28(jsonWriter_0, jsonConverter2, object_0, jsonContract_0, jsonContainerContract_0, jsonProperty_1);
			return;
		}
		switch (jsonContract_0.enum8_0)
		{
		case (Enum8)1:
			this.method_19(jsonWriter_0, object_0, (JsonObjectContract)jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
			return;
		case (Enum8)2:
		{
			JsonArrayContract jsonArrayContract = (JsonArrayContract)jsonContract_0;
			if (!jsonArrayContract.IsMultidimensionalArray)
			{
				this.method_29(jsonWriter_0, (IEnumerable)object_0, jsonArrayContract, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
				return;
			}
			this.method_30(jsonWriter_0, (Array)object_0, jsonArrayContract, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
			return;
		}
		case (Enum8)3:
			this.method_8(jsonWriter_0, object_0, (JsonPrimitiveContract)jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
			return;
		case (Enum8)4:
			this.method_16(jsonWriter_0, object_0, (JsonStringContract)jsonContract_0);
			return;
		case (Enum8)5:
		{
			JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract_0;
			IDictionary dictionary;
			IDictionary idictionary_;
			if ((dictionary = (object_0 as IDictionary)) == null)
			{
				IDictionary dictionary2 = jsonDictionaryContract.method_12(object_0);
				idictionary_ = dictionary2;
			}
			else
			{
				idictionary_ = dictionary;
			}
			this.method_37(jsonWriter_0, idictionary_, jsonDictionaryContract, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
			return;
		}
		case (Enum8)6:
			this.method_34(jsonWriter_0, (IDynamicMetaObjectProvider)object_0, (JsonDynamicContract)jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
			return;
		case (Enum8)7:
			this.method_33(jsonWriter_0, (ISerializable)object_0, (JsonISerializableContract)jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
			return;
		case (Enum8)8:
			((JToken)object_0).WriteTo(jsonWriter_0, this.jsonSerializer_0.Converters.ToArray<JsonConverter>());
			return;
		default:
			return;
		}
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00036DB0 File Offset: 0x00034FB0
	private bool? method_10(JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		bool? result = null;
		if (jsonProperty_0 != null)
		{
			result = jsonProperty_0.IsReference;
		}
		if (result == null && jsonProperty_1 != null)
		{
			result = jsonProperty_1.ItemIsReference;
		}
		if (result == null && jsonContainerContract_0 != null)
		{
			result = jsonContainerContract_0.ItemIsReference;
		}
		if (result == null)
		{
			result = jsonContract_0.IsReference;
		}
		return result;
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00036E08 File Offset: 0x00035008
	private bool method_11(object object_0, JsonProperty jsonProperty_0, JsonContract jsonContract_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		if (object_0 == null)
		{
			return false;
		}
		if (jsonContract_0.enum8_0 != (Enum8)3)
		{
			if (jsonContract_0.enum8_0 != (Enum8)4)
			{
				bool? flag = this.method_10(jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
				if (flag == null)
				{
					if (jsonContract_0.enum8_0 == (Enum8)2)
					{
						flag = new bool?(this.method_26(this.jsonSerializer_0.preserveReferencesHandling_0, PreserveReferencesHandling.Arrays));
					}
					else
					{
						flag = new bool?(this.method_26(this.jsonSerializer_0.preserveReferencesHandling_0, PreserveReferencesHandling.Objects));
					}
				}
				return flag.GetValueOrDefault() && this.jsonSerializer_0.method_4().IsReferenced(this, object_0);
			}
		}
		return false;
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00036EA0 File Offset: 0x000350A0
	private bool method_12(object object_0, JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0)
	{
		return (object_0 != null || base.method_1(jsonObjectContract_0, jsonProperty_0) != NullValueHandling.Ignore) && (!this.method_25(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(this.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Ignore) || !Class80.smethod_0(object_0, jsonProperty_0.method_2()));
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00036EF0 File Offset: 0x000350F0
	private bool method_13(JsonWriter jsonWriter_0, object object_0, JsonProperty jsonProperty_0, JsonContract jsonContract_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		if (object_0 != null && jsonContract_0.enum8_0 != (Enum8)3)
		{
			if (jsonContract_0.enum8_0 != (Enum8)4)
			{
				ReferenceLoopHandling? referenceLoopHandling = null;
				if (jsonProperty_0 != null)
				{
					referenceLoopHandling = jsonProperty_0.ReferenceLoopHandling;
				}
				if (referenceLoopHandling == null && jsonProperty_1 != null)
				{
					referenceLoopHandling = jsonProperty_1.ItemReferenceLoopHandling;
				}
				if (referenceLoopHandling == null && jsonContainerContract_0 != null)
				{
					referenceLoopHandling = jsonContainerContract_0.ItemReferenceLoopHandling;
				}
				if ((this.jsonSerializer_0.iequalityComparer_0 != null) ? this.list_0.smethod_10(object_0, this.jsonSerializer_0.iequalityComparer_0) : this.list_0.Contains(object_0))
				{
					string text = "Self referencing loop detected";
					if (jsonProperty_0 != null)
					{
						text += " for property '{0}'".smethod_0(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName);
					}
					text += " with type '{0}'.".smethod_0(CultureInfo.InvariantCulture, object_0.GetType());
					switch (referenceLoopHandling.GetValueOrDefault(this.jsonSerializer_0.referenceLoopHandling_0))
					{
					case ReferenceLoopHandling.Error:
						throw JsonSerializationException.Create(null, jsonWriter_0.xEuXaafal7(), text, null);
					case ReferenceLoopHandling.Ignore:
						if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
						{
							this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(null, jsonWriter_0.Path, text + ". Skipping serializing self referenced value."), null);
						}
						return false;
					case ReferenceLoopHandling.Serialize:
						if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
						{
							this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(null, jsonWriter_0.Path, text + ". Serializing self referenced value."), null);
						}
						return true;
					}
				}
				return true;
			}
		}
		return true;
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00037088 File Offset: 0x00035288
	private void method_14(JsonWriter jsonWriter_0, object object_0)
	{
		string text = this.method_15(jsonWriter_0, object_0);
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(null, jsonWriter_0.Path, "Writing object reference to Id '{0}' for {1}.".smethod_1(CultureInfo.InvariantCulture, text, object_0.GetType())), null);
		}
		jsonWriter_0.WriteStartObject();
		jsonWriter_0.WritePropertyName("$ref", false);
		jsonWriter_0.WriteValue(text);
		jsonWriter_0.WriteEndObject();
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00037104 File Offset: 0x00035304
	private string method_15(JsonWriter jsonWriter_0, object object_0)
	{
		string reference;
		try
		{
			reference = this.jsonSerializer_0.method_4().GetReference(this, object_0);
		}
		catch (Exception ex)
		{
			throw JsonSerializationException.Create(null, jsonWriter_0.xEuXaafal7(), "Error writing object reference for '{0}'.".smethod_0(CultureInfo.InvariantCulture, object_0.GetType()), ex);
		}
		return reference;
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x0003715C File Offset: 0x0003535C
	internal static bool smethod_0(object object_0, Type type_1, out string string_0)
	{
		TypeConverter typeConverter;
		if (Class124.smethod_1(type_1, out typeConverter))
		{
			string_0 = typeConverter.ConvertToInvariantString(object_0);
			return true;
		}
		type_1 = (object_0 as Type);
		if (type_1 != null)
		{
			string_0 = type_1.AssemblyQualifiedName;
			return true;
		}
		string_0 = null;
		return false;
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x000371A0 File Offset: 0x000353A0
	private void method_16(JsonWriter jsonWriter_0, object object_0, JsonStringContract jsonStringContract_0)
	{
		this.method_17(jsonWriter_0, jsonStringContract_0, object_0);
		string value;
		Class119.smethod_0(object_0, jsonStringContract_0.UnderlyingType, out value);
		jsonWriter_0.WriteValue(value);
		this.method_18(jsonWriter_0, jsonStringContract_0, object_0);
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x000371D8 File Offset: 0x000353D8
	private void method_17(JsonWriter jsonWriter_0, JsonContract jsonContract_0, object object_0)
	{
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(null, jsonWriter_0.Path, "Started serializing {0}".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
		}
		jsonContract_0.method_0(object_0, this.jsonSerializer_0.streamingContext_0);
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x0003723C File Offset: 0x0003543C
	private void method_18(JsonWriter jsonWriter_0, JsonContract jsonContract_0, object object_0)
	{
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(null, jsonWriter_0.Path, "Finished serializing {0}".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
		}
		jsonContract_0.method_1(object_0, this.jsonSerializer_0.streamingContext_0);
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x000372A0 File Offset: 0x000354A0
	private void method_19(JsonWriter jsonWriter_0, object object_0, JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		this.method_17(jsonWriter_0, jsonObjectContract_0, object_0);
		this.list_0.Add(object_0);
		this.method_21(jsonWriter_0, object_0, jsonObjectContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
		int top = jsonWriter_0.Top;
		for (int i = 0; i < jsonObjectContract_0.Properties.Count; i++)
		{
			JsonProperty jsonProperty = jsonObjectContract_0.Properties[i];
			try
			{
				JsonContract jsonContract_;
				object object_;
				if (this.method_20(jsonWriter_0, object_0, jsonObjectContract_0, jsonProperty_0, jsonProperty, out jsonContract_, out object_))
				{
					jsonProperty.method_3(jsonWriter_0);
					this.method_9(jsonWriter_0, object_, jsonContract_, jsonProperty, jsonObjectContract_0, jsonProperty_0);
				}
			}
			catch (Exception exception_)
			{
				if (!base.method_4(object_0, jsonObjectContract_0, jsonProperty.PropertyName, null, jsonWriter_0.xEuXaafal7(), exception_))
				{
					throw;
				}
				this.method_39(jsonWriter_0, top);
			}
		}
		ExtensionDataGetter extensionDataGetter = jsonObjectContract_0.ExtensionDataGetter;
		IEnumerable<KeyValuePair<object, object>> enumerable = (extensionDataGetter != null) ? extensionDataGetter(object_0) : null;
		if (enumerable != null)
		{
			foreach (KeyValuePair<object, object> keyValuePair in enumerable)
			{
				JsonContract jsonContract_2 = this.method_7(keyValuePair.Key);
				JsonContract jsonContract_3 = this.method_7(keyValuePair.Value);
				bool flag;
				string text = this.method_38(jsonWriter_0, keyValuePair.Key, jsonContract_2, out flag);
				text = ((jsonObjectContract_0.ExtensionDataNameResolver != null) ? jsonObjectContract_0.ExtensionDataNameResolver(text) : text);
				if (this.method_11(keyValuePair.Value, null, jsonContract_3, jsonObjectContract_0, jsonProperty_0))
				{
					jsonWriter_0.WritePropertyName(text);
					this.method_14(jsonWriter_0, keyValuePair.Value);
				}
				else if (this.method_13(jsonWriter_0, keyValuePair.Value, null, jsonContract_3, jsonObjectContract_0, jsonProperty_0))
				{
					jsonWriter_0.WritePropertyName(text);
					this.method_9(jsonWriter_0, keyValuePair.Value, jsonContract_3, null, jsonObjectContract_0, jsonProperty_0);
				}
			}
		}
		jsonWriter_0.WriteEndObject();
		this.list_0.RemoveAt(this.list_0.Count - 1);
		this.method_18(jsonWriter_0, jsonObjectContract_0, object_0);
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0003748C File Offset: 0x0003568C
	private bool method_20(JsonWriter jsonWriter_0, object object_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_0, JsonProperty jsonProperty_1, out JsonContract jsonContract_0, out object object_1)
	{
		if (!jsonProperty_1.Ignored && jsonProperty_1.Readable && this.ShouldSerialize(jsonWriter_0, jsonProperty_1, object_0) && this.method_40(jsonWriter_0, jsonProperty_1, object_0))
		{
			if (jsonProperty_1.method_0() == null)
			{
				jsonProperty_1.method_1(this.jsonSerializer_0.icontractResolver_0.ResolveContract(jsonProperty_1.PropertyType));
			}
			object_1 = jsonProperty_1.ValueProvider.GetValue(object_0);
			jsonContract_0 = (jsonProperty_1.method_0().bool_4 ? jsonProperty_1.method_0() : this.method_7(object_1));
			if (this.method_12(object_1, jsonContainerContract_0 as JsonObjectContract, jsonProperty_1))
			{
				if (this.method_11(object_1, jsonProperty_1, jsonContract_0, jsonContainerContract_0, jsonProperty_0))
				{
					jsonProperty_1.method_3(jsonWriter_0);
					this.method_14(jsonWriter_0, object_1);
					return false;
				}
				if (!this.method_13(jsonWriter_0, object_1, jsonProperty_1, jsonContract_0, jsonContainerContract_0, jsonProperty_0))
				{
					return false;
				}
				if (object_1 == null)
				{
					JsonObjectContract jsonObjectContract = jsonContainerContract_0 as JsonObjectContract;
					Required required = jsonProperty_1.nullable_0 ?? (((jsonObjectContract != null) ? jsonObjectContract.ItemRequired : null) ?? Required.Default);
					if (required == Required.Always)
					{
						throw JsonSerializationException.Create(null, jsonWriter_0.xEuXaafal7(), "Cannot write a null value for property '{0}'. Property requires a value.".smethod_0(CultureInfo.InvariantCulture, jsonProperty_1.PropertyName), null);
					}
					if (required == Required.DisallowNull)
					{
						throw JsonSerializationException.Create(null, jsonWriter_0.xEuXaafal7(), "Cannot write a null value for property '{0}'. Property requires a non-null value.".smethod_0(CultureInfo.InvariantCulture, jsonProperty_1.PropertyName), null);
					}
				}
				return true;
			}
		}
		jsonContract_0 = null;
		object_1 = null;
		return false;
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00037628 File Offset: 0x00035828
	private void method_21(JsonWriter jsonWriter_0, object object_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		jsonWriter_0.WriteStartObject();
		if ((this.method_10(jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1) ?? this.method_26(this.jsonSerializer_0.preserveReferencesHandling_0, PreserveReferencesHandling.Objects)) && (jsonProperty_0 == null || jsonProperty_0.Writable || this.method_22(jsonContainerContract_0, jsonProperty_0)))
		{
			this.method_23(jsonWriter_0, jsonContract_0.UnderlyingType, object_0);
		}
		if (this.method_36(TypeNameHandling.Objects, jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1))
		{
			this.method_24(jsonWriter_0, jsonContract_0.UnderlyingType);
		}
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x000376B4 File Offset: 0x000358B4
	private bool method_22(JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_0)
	{
		JsonObjectContract jsonObjectContract;
		return (jsonObjectContract = (jsonContainerContract_0 as JsonObjectContract)) != null && jsonObjectContract.CreatorParameters.Contains(jsonProperty_0.PropertyName);
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x000376E0 File Offset: 0x000358E0
	private void method_23(JsonWriter jsonWriter_0, Type type_1, object object_0)
	{
		string text = this.method_15(jsonWriter_0, object_0);
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
		{
			this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(null, jsonWriter_0.Path, "Writing object reference Id '{0}' for {1}.".smethod_1(CultureInfo.InvariantCulture, text, type_1)), null);
		}
		jsonWriter_0.WritePropertyName("$id", false);
		jsonWriter_0.WriteValue(text);
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x0003774C File Offset: 0x0003594C
	private void method_24(JsonWriter jsonWriter_0, Type type_1)
	{
		string text = Class90.smethod_4(type_1, this.jsonSerializer_0.typeNameAssemblyFormatHandling_0, this.jsonSerializer_0.ginterface2_0);
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
		{
			this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(null, jsonWriter_0.Path, "Writing type name '{0}' for {1}.".smethod_1(CultureInfo.InvariantCulture, text, type_1)), null);
		}
		jsonWriter_0.WritePropertyName("$type", false);
		jsonWriter_0.WriteValue(text);
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00009015 File Offset: 0x00007215
	private bool method_25(DefaultValueHandling defaultValueHandling_0, DefaultValueHandling defaultValueHandling_1)
	{
		return (defaultValueHandling_0 & defaultValueHandling_1) == defaultValueHandling_1;
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00009015 File Offset: 0x00007215
	private bool method_26(PreserveReferencesHandling preserveReferencesHandling_0, PreserveReferencesHandling preserveReferencesHandling_1)
	{
		return (preserveReferencesHandling_0 & preserveReferencesHandling_1) == preserveReferencesHandling_1;
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00009015 File Offset: 0x00007215
	private bool method_27(TypeNameHandling typeNameHandling_0, TypeNameHandling typeNameHandling_1)
	{
		return (typeNameHandling_0 & typeNameHandling_1) == typeNameHandling_1;
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x000377CC File Offset: 0x000359CC
	private void method_28(JsonWriter jsonWriter_0, JsonConverter jsonConverter_0, object object_0, JsonContract jsonContract_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_0)
	{
		if (this.method_11(object_0, null, jsonContract_0, jsonContainerContract_0, jsonProperty_0))
		{
			this.method_14(jsonWriter_0, object_0);
			return;
		}
		if (!this.method_13(jsonWriter_0, object_0, null, jsonContract_0, jsonContainerContract_0, jsonProperty_0))
		{
			return;
		}
		this.list_0.Add(object_0);
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(null, jsonWriter_0.Path, "Started serializing {0} with converter {1}.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType(), jsonConverter_0.GetType())), null);
		}
		jsonConverter_0.WriteJson(jsonWriter_0, object_0, this.method_6());
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(null, jsonWriter_0.Path, "Finished serializing {0} with converter {1}.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType(), jsonConverter_0.GetType())), null);
		}
		this.list_0.RemoveAt(this.list_0.Count - 1);
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x000378CC File Offset: 0x00035ACC
	private void method_29(JsonWriter jsonWriter_0, IEnumerable ienumerable_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		Interface0 @interface;
		object obj = ((@interface = (ienumerable_0 as Interface0)) != null) ? @interface.UnderlyingCollection : ienumerable_0;
		this.method_17(jsonWriter_0, jsonArrayContract_0, obj);
		this.list_0.Add(obj);
		bool flag = this.method_32(jsonWriter_0, obj, jsonArrayContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
		jsonWriter_0.WriteStartArray();
		int top = jsonWriter_0.Top;
		int num = 0;
		foreach (object object_ in ienumerable_0)
		{
			try
			{
				JsonContract jsonContract_ = jsonArrayContract_0.method_6() ?? this.method_7(object_);
				if (this.method_11(object_, null, jsonContract_, jsonArrayContract_0, jsonProperty_0))
				{
					this.method_14(jsonWriter_0, object_);
				}
				else if (this.method_13(jsonWriter_0, object_, null, jsonContract_, jsonArrayContract_0, jsonProperty_0))
				{
					this.method_9(jsonWriter_0, object_, jsonContract_, null, jsonArrayContract_0, jsonProperty_0);
				}
			}
			catch (Exception exception_)
			{
				if (!base.method_4(obj, jsonArrayContract_0, num, null, jsonWriter_0.xEuXaafal7(), exception_))
				{
					throw;
				}
				this.method_39(jsonWriter_0, top);
			}
			finally
			{
				num++;
			}
		}
		jsonWriter_0.WriteEndArray();
		if (flag)
		{
			jsonWriter_0.WriteEndObject();
		}
		this.list_0.RemoveAt(this.list_0.Count - 1);
		this.method_18(jsonWriter_0, jsonArrayContract_0, obj);
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00037A30 File Offset: 0x00035C30
	private void method_30(JsonWriter jsonWriter_0, Array array_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		this.method_17(jsonWriter_0, jsonArrayContract_0, array_0);
		this.list_0.Add(array_0);
		bool flag = this.method_32(jsonWriter_0, array_0, jsonArrayContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
		this.method_31(jsonWriter_0, array_0, jsonArrayContract_0, jsonProperty_0, jsonWriter_0.Top, Class20.smethod_17<int>());
		if (flag)
		{
			jsonWriter_0.WriteEndObject();
		}
		this.list_0.RemoveAt(this.list_0.Count - 1);
		this.method_18(jsonWriter_0, jsonArrayContract_0, array_0);
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00037AA0 File Offset: 0x00035CA0
	private void method_31(JsonWriter jsonWriter_0, Array array_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, int int_1, int[] int_2)
	{
		int num = int_2.Length;
		int[] array = new int[num + 1];
		for (int i = 0; i < num; i++)
		{
			array[i] = int_2[i];
		}
		jsonWriter_0.WriteStartArray();
		int j = array_0.GetLowerBound(num);
		while (j <= array_0.GetUpperBound(num))
		{
			array[num] = j;
			if (array.Length == array_0.Rank)
			{
				object value = array_0.GetValue(array);
				try
				{
					JsonContract jsonContract_ = jsonArrayContract_0.method_6() ?? this.method_7(value);
					if (this.method_11(value, null, jsonContract_, jsonArrayContract_0, jsonProperty_0))
					{
						this.method_14(jsonWriter_0, value);
					}
					else if (this.method_13(jsonWriter_0, value, null, jsonContract_, jsonArrayContract_0, jsonProperty_0))
					{
						this.method_9(jsonWriter_0, value, jsonContract_, null, jsonArrayContract_0, jsonProperty_0);
					}
					goto IL_E4;
				}
				catch (Exception exception_)
				{
					if (!base.method_4(array_0, jsonArrayContract_0, j, null, jsonWriter_0.xEuXaafal7(), exception_))
					{
						throw;
					}
					this.method_39(jsonWriter_0, int_1 + 1);
					goto IL_E4;
				}
				goto IL_D4;
			}
			goto IL_D4;
			IL_E4:
			j++;
			continue;
			IL_D4:
			this.method_31(jsonWriter_0, array_0, jsonArrayContract_0, jsonProperty_0, int_1 + 1, array);
			goto IL_E4;
		}
		jsonWriter_0.WriteEndArray();
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00037BB0 File Offset: 0x00035DB0
	private bool method_32(JsonWriter jsonWriter_0, object object_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		bool flag = (this.method_10(jsonArrayContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1) ?? this.method_26(this.jsonSerializer_0.preserveReferencesHandling_0, PreserveReferencesHandling.Arrays)) && (jsonProperty_0 == null || jsonProperty_0.Writable || this.method_22(jsonContainerContract_0, jsonProperty_0));
		bool flag2 = this.method_36(TypeNameHandling.Arrays, jsonArrayContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
		bool flag3 = flag || flag2;
		if (flag3)
		{
			jsonWriter_0.WriteStartObject();
			if (flag)
			{
				this.method_23(jsonWriter_0, jsonArrayContract_0.UnderlyingType, object_0);
			}
			if (flag2)
			{
				this.method_24(jsonWriter_0, object_0.GetType());
			}
			jsonWriter_0.WritePropertyName("$values", false);
		}
		if (jsonArrayContract_0.EwhtYgWttB() == null)
		{
			jsonArrayContract_0.method_5(this.jsonSerializer_0.icontractResolver_0.ResolveContract(jsonArrayContract_0.CollectionItemType ?? typeof(object)));
		}
		return flag3;
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00037C8C File Offset: 0x00035E8C
	[SecuritySafeCritical]
	private void method_33(JsonWriter jsonWriter_0, ISerializable iserializable_0, JsonISerializableContract jsonISerializableContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		if (!Class124.smethod_18())
		{
			string text = "Type '{0}' implements ISerializable but cannot be serialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
			text = text.smethod_0(CultureInfo.InvariantCulture, iserializable_0.GetType());
			throw JsonSerializationException.Create(null, jsonWriter_0.xEuXaafal7(), text, null);
		}
		this.method_17(jsonWriter_0, jsonISerializableContract_0, iserializable_0);
		this.list_0.Add(iserializable_0);
		this.method_21(jsonWriter_0, iserializable_0, jsonISerializableContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
		SerializationInfo serializationInfo = new SerializationInfo(jsonISerializableContract_0.UnderlyingType, new FormatterConverter());
		iserializable_0.GetObjectData(serializationInfo, this.jsonSerializer_0.streamingContext_0);
		foreach (SerializationEntry serializationEntry in serializationInfo)
		{
			JsonContract jsonContract_ = this.method_7(serializationEntry.Value);
			if (this.method_11(serializationEntry.Value, null, jsonContract_, jsonISerializableContract_0, jsonProperty_0))
			{
				jsonWriter_0.WritePropertyName(serializationEntry.Name);
				this.method_14(jsonWriter_0, serializationEntry.Value);
			}
			else if (this.method_13(jsonWriter_0, serializationEntry.Value, null, jsonContract_, jsonISerializableContract_0, jsonProperty_0))
			{
				jsonWriter_0.WritePropertyName(serializationEntry.Name);
				this.method_9(jsonWriter_0, serializationEntry.Value, jsonContract_, null, jsonISerializableContract_0, jsonProperty_0);
			}
		}
		jsonWriter_0.WriteEndObject();
		this.list_0.RemoveAt(this.list_0.Count - 1);
		this.method_18(jsonWriter_0, jsonISerializableContract_0, iserializable_0);
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00037DDC File Offset: 0x00035FDC
	private void method_34(JsonWriter jsonWriter_0, IDynamicMetaObjectProvider idynamicMetaObjectProvider_0, JsonDynamicContract jsonDynamicContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		this.method_17(jsonWriter_0, jsonDynamicContract_0, idynamicMetaObjectProvider_0);
		this.list_0.Add(idynamicMetaObjectProvider_0);
		this.method_21(jsonWriter_0, idynamicMetaObjectProvider_0, jsonDynamicContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
		int top = jsonWriter_0.Top;
		for (int i = 0; i < jsonDynamicContract_0.Properties.Count; i++)
		{
			JsonProperty jsonProperty = jsonDynamicContract_0.Properties[i];
			if (jsonProperty.HasMemberAttribute)
			{
				try
				{
					JsonContract jsonContract_;
					object object_;
					if (this.method_20(jsonWriter_0, idynamicMetaObjectProvider_0, jsonDynamicContract_0, jsonProperty_0, jsonProperty, out jsonContract_, out object_))
					{
						jsonProperty.method_3(jsonWriter_0);
						this.method_9(jsonWriter_0, object_, jsonContract_, jsonProperty, jsonDynamicContract_0, jsonProperty_0);
					}
				}
				catch (Exception exception_)
				{
					if (!base.method_4(idynamicMetaObjectProvider_0, jsonDynamicContract_0, jsonProperty.PropertyName, null, jsonWriter_0.xEuXaafal7(), exception_))
					{
						throw;
					}
					this.method_39(jsonWriter_0, top);
				}
			}
		}
		foreach (string text in idynamicMetaObjectProvider_0.smethod_0())
		{
			object object_2;
			if (jsonDynamicContract_0.TryGetMember(idynamicMetaObjectProvider_0, text, out object_2))
			{
				try
				{
					JsonContract jsonContract_2 = this.method_7(object_2);
					if (this.method_35(object_2))
					{
						if (this.method_13(jsonWriter_0, object_2, null, jsonContract_2, jsonDynamicContract_0, jsonProperty_0))
						{
							string name = (jsonDynamicContract_0.PropertyNameResolver != null) ? jsonDynamicContract_0.PropertyNameResolver(text) : text;
							jsonWriter_0.WritePropertyName(name);
							this.method_9(jsonWriter_0, object_2, jsonContract_2, null, jsonDynamicContract_0, jsonProperty_0);
						}
					}
				}
				catch (Exception exception_2)
				{
					if (!base.method_4(idynamicMetaObjectProvider_0, jsonDynamicContract_0, text, null, jsonWriter_0.xEuXaafal7(), exception_2))
					{
						throw;
					}
					this.method_39(jsonWriter_0, top);
				}
			}
		}
		jsonWriter_0.WriteEndObject();
		this.list_0.RemoveAt(this.list_0.Count - 1);
		this.method_18(jsonWriter_0, jsonDynamicContract_0, idynamicMetaObjectProvider_0);
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00037FA0 File Offset: 0x000361A0
	private bool method_35(object object_0)
	{
		return (this.jsonSerializer_0.nullValueHandling_0 != NullValueHandling.Ignore || object_0 != null) && (!this.method_25(this.jsonSerializer_0.defaultValueHandling_0, DefaultValueHandling.Ignore) || (object_0 != null && !Class80.smethod_0(object_0, Class90.smethod_43(object_0.GetType()))));
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00037FF0 File Offset: 0x000361F0
	private bool method_36(TypeNameHandling typeNameHandling_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		TypeNameHandling typeNameHandling_ = ((jsonProperty_0 != null) ? jsonProperty_0.TypeNameHandling : null) ?? (((jsonProperty_1 != null) ? jsonProperty_1.ItemTypeNameHandling : null) ?? (((jsonContainerContract_0 != null) ? jsonContainerContract_0.ItemTypeNameHandling : null) ?? this.jsonSerializer_0.typeNameHandling_0));
		if (this.method_27(typeNameHandling_, typeNameHandling_0))
		{
			return true;
		}
		if (this.method_27(typeNameHandling_, TypeNameHandling.Auto))
		{
			if (jsonProperty_0 != null)
			{
				if (jsonContract_0.type_0 != jsonProperty_0.method_0().CreatedType)
				{
					return true;
				}
			}
			else if (jsonContainerContract_0 != null)
			{
				if (jsonContainerContract_0.EwhtYgWttB() == null || jsonContract_0.type_0 != jsonContainerContract_0.EwhtYgWttB().CreatedType)
				{
					return true;
				}
			}
			else if (this.type_0 != null && this.list_0.Count == this.int_0)
			{
				JsonContract jsonContract = this.jsonSerializer_0.icontractResolver_0.ResolveContract(this.type_0);
				if (jsonContract_0.type_0 != jsonContract.CreatedType)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00038134 File Offset: 0x00036334
	private void method_37(JsonWriter jsonWriter_0, IDictionary idictionary_0, JsonDictionaryContract jsonDictionaryContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1)
	{
		Interface1 @interface;
		object obj = ((@interface = (idictionary_0 as Interface1)) != null) ? @interface.UnderlyingDictionary : idictionary_0;
		this.method_17(jsonWriter_0, jsonDictionaryContract_0, obj);
		this.list_0.Add(obj);
		this.method_21(jsonWriter_0, obj, jsonDictionaryContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1);
		if (jsonDictionaryContract_0.EwhtYgWttB() == null)
		{
			jsonDictionaryContract_0.method_5(this.jsonSerializer_0.icontractResolver_0.ResolveContract(jsonDictionaryContract_0.DictionaryValueType ?? typeof(object)));
		}
		if (jsonDictionaryContract_0.method_7() == null)
		{
			jsonDictionaryContract_0.method_8(this.jsonSerializer_0.icontractResolver_0.ResolveContract(jsonDictionaryContract_0.DictionaryKeyType ?? typeof(object)));
		}
		int top = jsonWriter_0.Top;
		using (IDictionaryEnumerator enumerator = idictionary_0.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				DictionaryEntry entry = enumerator.Entry;
				bool escape;
				string text = this.method_38(jsonWriter_0, entry.Key, jsonDictionaryContract_0.method_7(), out escape);
				text = ((jsonDictionaryContract_0.DictionaryKeyResolver != null) ? jsonDictionaryContract_0.DictionaryKeyResolver(text) : text);
				try
				{
					object value = entry.Value;
					JsonContract jsonContract_ = jsonDictionaryContract_0.method_6() ?? this.method_7(value);
					if (this.method_11(value, null, jsonContract_, jsonDictionaryContract_0, jsonProperty_0))
					{
						jsonWriter_0.WritePropertyName(text, escape);
						this.method_14(jsonWriter_0, value);
					}
					else if (this.method_13(jsonWriter_0, value, null, jsonContract_, jsonDictionaryContract_0, jsonProperty_0))
					{
						jsonWriter_0.WritePropertyName(text, escape);
						this.method_9(jsonWriter_0, value, jsonContract_, null, jsonDictionaryContract_0, jsonProperty_0);
					}
				}
				catch (Exception exception_)
				{
					if (!base.method_4(obj, jsonDictionaryContract_0, text, null, jsonWriter_0.xEuXaafal7(), exception_))
					{
						throw;
					}
					this.method_39(jsonWriter_0, top);
				}
			}
		}
		jsonWriter_0.WriteEndObject();
		this.list_0.RemoveAt(this.list_0.Count - 1);
		this.method_18(jsonWriter_0, jsonDictionaryContract_0, obj);
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00038324 File Offset: 0x00036524
	private string method_38(JsonWriter jsonWriter_0, object object_0, JsonContract jsonContract_0, out bool bool_0)
	{
		if (jsonContract_0.enum8_0 == (Enum8)3)
		{
			JsonPrimitiveContract jsonPrimitiveContract = (JsonPrimitiveContract)jsonContract_0;
			switch (jsonPrimitiveContract.method_5())
			{
			case (Enum3)22:
			case (Enum3)23:
			{
				float num = (float)object_0;
				bool_0 = false;
				return num.ToString("R", CultureInfo.InvariantCulture);
			}
			case (Enum3)24:
			case (Enum3)25:
			{
				double num2 = (double)object_0;
				bool_0 = false;
				return num2.ToString("R", CultureInfo.InvariantCulture);
			}
			case (Enum3)26:
			case (Enum3)27:
			{
				DateTime dateTime_ = Class25.smethod_2((DateTime)object_0, jsonWriter_0.DateTimeZoneHandling);
				bool_0 = false;
				StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
				Class25.smethod_24(stringWriter, dateTime_, jsonWriter_0.DateFormatHandling, jsonWriter_0.DateFormatString, jsonWriter_0.Culture);
				return stringWriter.ToString();
			}
			case (Enum3)28:
			case (Enum3)29:
			{
				bool_0 = false;
				StringWriter stringWriter2 = new StringWriter(CultureInfo.InvariantCulture);
				Class25.IxisRjgvuh(stringWriter2, (DateTimeOffset)object_0, jsonWriter_0.DateFormatHandling, jsonWriter_0.DateFormatString, jsonWriter_0.Culture);
				return stringWriter2.ToString();
			}
			default:
			{
				bool_0 = true;
				string result;
				if (jsonPrimitiveContract.bool_2 && Class53.smethod_3(jsonPrimitiveContract.type_0, object_0, null, out result))
				{
					return result;
				}
				return Convert.ToString(object_0, CultureInfo.InvariantCulture);
			}
			}
		}
		else
		{
			string result2;
			if (Class119.smethod_0(object_0, object_0.GetType(), out result2))
			{
				bool_0 = true;
				return result2;
			}
			bool_0 = true;
			return object_0.ToString();
		}
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x000090B7 File Offset: 0x000072B7
	private void method_39(JsonWriter jsonWriter_0, int int_1)
	{
		base.method_3();
		if (jsonWriter_0.WriteState == WriteState.Property)
		{
			jsonWriter_0.WriteNull();
		}
		while (jsonWriter_0.Top > int_1)
		{
			jsonWriter_0.WriteEnd();
		}
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00038470 File Offset: 0x00036670
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
	{
		if (property.ShouldSerialize == null)
		{
			return true;
		}
		bool flag = property.ShouldSerialize(target);
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
		{
			this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(null, writer.Path, "ShouldSerialize result for property '{0}' on {1}: {2}".smethod_2(CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType, flag)), null);
		}
		return flag;
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x000384E8 File Offset: 0x000366E8
	private bool method_40(JsonWriter jsonWriter_0, JsonProperty jsonProperty_0, object object_0)
	{
		if (jsonProperty_0.GetIsSpecified == null)
		{
			return true;
		}
		bool flag = jsonProperty_0.GetIsSpecified(object_0);
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
		{
			this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(null, jsonWriter_0.Path, "IsSpecified result for property '{0}' on {1}: {2}".smethod_2(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType, flag)), null);
		}
		return flag;
	}

	// Token: 0x0400055C RID: 1372
	private Type type_0;

	// Token: 0x0400055D RID: 1373
	private int int_0;

	// Token: 0x0400055E RID: 1374
	private readonly List<object> list_0;
}
