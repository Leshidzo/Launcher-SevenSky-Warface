using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

// Token: 0x02000137 RID: 311
internal class Class118 : Class117
{
	// Token: 0x0600094F RID: 2383 RVA: 0x00008F8F File Offset: 0x0000718F
	public Class118(JsonSerializer jsonSerializer_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor(jsonSerializer_1);
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00033214 File Offset: 0x00031414
	public void method_5(JsonReader jsonReader_0, object object_0)
	{
		Class101.smethod_0(object_0, "target");
		Type type = object_0.GetType();
		JsonContract jsonContract = this.jsonSerializer_0.icontractResolver_0.ResolveContract(type);
		if (!jsonReader_0.method_29())
		{
			throw JsonSerializationException.Create(jsonReader_0, "No JSON content found.");
		}
		if (jsonReader_0.TokenType == JsonToken.StartArray)
		{
			if (jsonContract.enum8_0 == (Enum8)2)
			{
				JsonArrayContract jsonArrayContract = (JsonArrayContract)jsonContract;
				IList ilist_;
				if (!jsonArrayContract.method_7())
				{
					ilist_ = (IList)object_0;
				}
				else
				{
					IList list = jsonArrayContract.mRrtQkaEd1(object_0);
					ilist_ = list;
				}
				this.method_34(ilist_, jsonReader_0, jsonArrayContract, null, null);
				return;
			}
			throw JsonSerializationException.Create(jsonReader_0, "Cannot populate JSON array onto type '{0}'.".smethod_0(CultureInfo.InvariantCulture, type));
		}
		else
		{
			if (jsonReader_0.TokenType != JsonToken.StartObject)
			{
				throw JsonSerializationException.Create(jsonReader_0, "Unexpected initial token '{0}' when populating object. Expected JSON object or array.".smethod_0(CultureInfo.InvariantCulture, jsonReader_0.TokenType));
			}
			jsonReader_0.method_25();
			string string_ = null;
			if (this.jsonSerializer_0.MetadataPropertyHandling != MetadataPropertyHandling.Ignore && jsonReader_0.TokenType == JsonToken.PropertyName && string.Equals(jsonReader_0.Value.ToString(), "$id", StringComparison.Ordinal))
			{
				jsonReader_0.method_25();
				object value = jsonReader_0.Value;
				string_ = ((value != null) ? value.ToString() : null);
				jsonReader_0.method_25();
			}
			if (jsonContract.enum8_0 == (Enum8)5)
			{
				JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract;
				IDictionary idictionary_;
				if (!jsonDictionaryContract.method_9())
				{
					idictionary_ = (IDictionary)object_0;
				}
				else
				{
					IDictionary dictionary = jsonDictionaryContract.method_12(object_0);
					idictionary_ = dictionary;
				}
				this.method_31(idictionary_, jsonReader_0, jsonDictionaryContract, null, string_);
				return;
			}
			if (jsonContract.enum8_0 == (Enum8)1)
			{
				this.method_42(object_0, jsonReader_0, (JsonObjectContract)jsonContract, null, string_);
				return;
			}
			throw JsonSerializationException.Create(jsonReader_0, "Cannot populate JSON object onto type '{0}'.".smethod_0(CultureInfo.InvariantCulture, type));
		}
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00008F9D File Offset: 0x0000719D
	private JsonContract method_6(Type type_0)
	{
		if (type_0 == null)
		{
			return null;
		}
		return this.jsonSerializer_0.icontractResolver_0.ResolveContract(type_0);
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x000333A4 File Offset: 0x000315A4
	public object method_7(JsonReader jsonReader_0, Type type_0, bool bool_0)
	{
		if (jsonReader_0 == null)
		{
			throw new ArgumentNullException("reader");
		}
		JsonContract jsonContract = this.method_6(type_0);
		object result;
		try
		{
			JsonConverter jsonConverter = this.method_13(jsonContract, null, null, null);
			if (jsonReader_0.TokenType == JsonToken.None && !jsonReader_0.method_27(jsonContract, jsonConverter != null))
			{
				if (jsonContract != null && !jsonContract.bool_0)
				{
					throw JsonSerializationException.Create(jsonReader_0, "No JSON content found and type '{0}' is not nullable.".smethod_0(CultureInfo.InvariantCulture, jsonContract.UnderlyingType));
				}
				result = null;
			}
			else
			{
				object obj;
				if (jsonConverter != null && jsonConverter.CanRead)
				{
					obj = this.method_39(jsonConverter, jsonReader_0, type_0, null);
				}
				else
				{
					obj = this.method_11(jsonReader_0, type_0, jsonContract, null, null, null, null);
				}
				if (bool_0)
				{
					while (jsonReader_0.Read())
					{
						if (jsonReader_0.TokenType != JsonToken.Comment)
						{
							throw JsonSerializationException.Create(jsonReader_0, "Additional text found in JSON string after finishing deserializing object.");
						}
					}
				}
				result = obj;
			}
		}
		catch (Exception exception_)
		{
			if (!base.method_4(null, jsonContract, null, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, exception_))
			{
				base.method_3();
				throw;
			}
			this.method_48(jsonReader_0, false, 0);
			result = null;
		}
		return result;
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00008FBB File Offset: 0x000071BB
	private Class9 method_8()
	{
		if (this.class9_0 == null)
		{
			this.class9_0 = new Class9(this);
		}
		return this.class9_0;
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x000334A8 File Offset: 0x000316A8
	private JToken method_9(JsonReader jsonReader_0, JsonContract jsonContract_0)
	{
		Class101.smethod_0(jsonReader_0, "reader");
		if (jsonContract_0 != null)
		{
			if (jsonContract_0.UnderlyingType == typeof(JRaw))
			{
				return JRaw.Create(jsonReader_0);
			}
			if (jsonReader_0.TokenType == JsonToken.Null && !(jsonContract_0.UnderlyingType == typeof(JValue)) && !(jsonContract_0.UnderlyingType == typeof(JToken)))
			{
				return null;
			}
		}
		JToken token;
		using (JTokenWriter jtokenWriter = new JTokenWriter())
		{
			jtokenWriter.WriteToken(jsonReader_0);
			token = jtokenWriter.Token;
		}
		return token;
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00033550 File Offset: 0x00031750
	private JToken method_10(JsonReader jsonReader_0)
	{
		Class101.smethod_0(jsonReader_0, "reader");
		using (JTokenWriter jtokenWriter = new JTokenWriter())
		{
			jtokenWriter.WriteStartObject();
			for (;;)
			{
				if (jsonReader_0.TokenType == JsonToken.PropertyName)
				{
					string text = (string)jsonReader_0.Value;
					if (!jsonReader_0.method_28())
					{
						goto IL_6A;
					}
					if (!this.method_44(jsonReader_0, text))
					{
						jtokenWriter.WritePropertyName(text);
						jtokenWriter.vmethod_2(jsonReader_0, true, true, false);
					}
				}
				else if (jsonReader_0.TokenType != JsonToken.Comment)
				{
					break;
				}
				if (!jsonReader_0.Read())
				{
					goto Block_4;
				}
			}
			jtokenWriter.WriteEndObject();
			return jtokenWriter.Token;
			Block_4:
			IL_6A:
			throw JsonSerializationException.Create(jsonReader_0, "Unexpected end when deserializing object.");
		}
		JToken result;
		return result;
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x00033600 File Offset: 0x00031800
	private object method_11(JsonReader jsonReader_0, Type type_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0)
	{
		if (jsonContract_0 != null && jsonContract_0.enum8_0 == (Enum8)8)
		{
			return this.method_9(jsonReader_0, jsonContract_0);
		}
		for (;;)
		{
			switch (jsonReader_0.TokenType)
			{
			case JsonToken.StartObject:
				goto IL_78;
			case JsonToken.StartArray:
				goto IL_8A;
			case JsonToken.StartConstructor:
				goto IL_99;
			case JsonToken.Comment:
				if (jsonReader_0.Read())
				{
					continue;
				}
				goto IL_B5;
			case JsonToken.Raw:
				goto IL_C1;
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.Boolean:
			case JsonToken.Date:
			case JsonToken.Bytes:
				goto IL_15D;
			case JsonToken.String:
				goto IL_D2;
			case JsonToken.Null:
			case JsonToken.Undefined:
				goto IL_113;
			}
			break;
		}
		goto IL_141;
		IL_78:
		return this.method_14(jsonReader_0, type_0, jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, object_0);
		IL_8A:
		return this.method_19(jsonReader_0, type_0, jsonContract_0, jsonProperty_0, object_0, null);
		IL_99:
		string object_ = jsonReader_0.Value.ToString();
		return this.method_21(jsonReader_0, object_, CultureInfo.InvariantCulture, jsonContract_0, type_0);
		IL_B5:
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected end when deserializing object.");
		IL_C1:
		return new JRaw((string)jsonReader_0.Value);
		IL_D2:
		string text = (string)jsonReader_0.Value;
		if (type_0 == typeof(byte[]))
		{
			return Convert.FromBase64String(text);
		}
		if (Class118.smethod_0(type_0, jsonContract_0, text))
		{
			return null;
		}
		return this.method_21(jsonReader_0, text, CultureInfo.InvariantCulture, jsonContract_0, type_0);
		IL_113:
		if (type_0 == typeof(DBNull))
		{
			return DBNull.Value;
		}
		return this.method_21(jsonReader_0, jsonReader_0.Value, CultureInfo.InvariantCulture, jsonContract_0, type_0);
		IL_141:
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected token while deserializing object: " + jsonReader_0.TokenType);
		IL_15D:
		return this.method_21(jsonReader_0, jsonReader_0.Value, CultureInfo.InvariantCulture, jsonContract_0, type_0);
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00033780 File Offset: 0x00031980
	private static bool smethod_0(Type type_0, object object_0, string string_0)
	{
		return string.IsNullOrEmpty(string_0) && type_0 != null && type_0 != typeof(string) && type_0 != typeof(object) && object_0 != null && object_0.bool_0;
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x000337D0 File Offset: 0x000319D0
	internal string method_12(JsonContract jsonContract_0)
	{
		switch (jsonContract_0.enum8_0)
		{
		case (Enum8)1:
		case (Enum8)5:
		case (Enum8)6:
		case (Enum8)7:
			return "JSON object (e.g. {\"name\":\"value\"})";
		case (Enum8)2:
			return "JSON array (e.g. [1,2,3])";
		case (Enum8)3:
			return "JSON primitive value (e.g. string, number, boolean, null)";
		case (Enum8)4:
			return "JSON string value";
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00033828 File Offset: 0x00031A28
	private JsonConverter method_13(JsonContract jsonContract_0, JsonConverter jsonConverter_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_0)
	{
		JsonConverter result = null;
		if (jsonConverter_0 != null)
		{
			result = jsonConverter_0;
		}
		else if (((jsonProperty_0 != null) ? jsonProperty_0.ItemConverter : null) != null)
		{
			result = jsonProperty_0.ItemConverter;
		}
		else if (((jsonContainerContract_0 != null) ? jsonContainerContract_0.ItemConverter : null) != null)
		{
			result = jsonContainerContract_0.ItemConverter;
		}
		else if (jsonContract_0 != null)
		{
			JsonConverter jsonConverter;
			if (jsonContract_0.Converter != null)
			{
				result = jsonContract_0.Converter;
			}
			else if ((jsonConverter = this.jsonSerializer_0.method_5(jsonContract_0.UnderlyingType)) != null)
			{
				result = jsonConverter;
			}
			else if (jsonContract_0.InternalConverter != null)
			{
				result = jsonContract_0.InternalConverter;
			}
		}
		return result;
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x000338AC File Offset: 0x00031AAC
	private object method_14(JsonReader jsonReader_0, Type type_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0)
	{
		Type type = type_0;
		string text;
		if (this.jsonSerializer_0.MetadataPropertyHandling == MetadataPropertyHandling.Ignore)
		{
			jsonReader_0.method_25();
			text = null;
		}
		else if (this.jsonSerializer_0.MetadataPropertyHandling == MetadataPropertyHandling.ReadAhead)
		{
			JTokenReader jtokenReader;
			if ((jtokenReader = (jsonReader_0 as JTokenReader)) == null)
			{
				jtokenReader = (JTokenReader)JToken.ReadFrom(jsonReader_0).CreateReader();
				jtokenReader.Culture = jsonReader_0.Culture;
				jtokenReader.DateFormatString = jsonReader_0.DateFormatString;
				jtokenReader.DateParseHandling = jsonReader_0.DateParseHandling;
				jtokenReader.DateTimeZoneHandling = jsonReader_0.DateTimeZoneHandling;
				jtokenReader.FloatParseHandling = jsonReader_0.FloatParseHandling;
				jtokenReader.SupportMultipleContent = jsonReader_0.SupportMultipleContent;
				jtokenReader.method_25();
				jsonReader_0 = jtokenReader;
			}
			object result;
			if (this.method_15(jtokenReader, ref type, ref jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, object_0, out result, out text))
			{
				return result;
			}
		}
		else
		{
			jsonReader_0.method_25();
			object result2;
			if (this.method_16(jsonReader_0, ref type, ref jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, object_0, out result2, out text))
			{
				return result2;
			}
		}
		if (this.method_20(jsonContract_0))
		{
			return this.method_10(jsonReader_0);
		}
		switch (jsonContract_0.enum8_0)
		{
		case (Enum8)1:
		{
			bool flag = false;
			JsonObjectContract jsonObjectContract_ = (JsonObjectContract)jsonContract_0;
			object obj;
			if (object_0 != null && (type == type_0 || type.IsAssignableFrom(object_0.GetType())))
			{
				obj = object_0;
			}
			else
			{
				obj = this.method_41(jsonReader_0, jsonObjectContract_, jsonProperty_0, jsonProperty_1, text, out flag);
			}
			if (flag)
			{
				return obj;
			}
			return this.method_42(obj, jsonReader_0, jsonObjectContract_, jsonProperty_0, text);
		}
		case (Enum8)3:
		{
			JsonPrimitiveContract jsonContract_ = (JsonPrimitiveContract)jsonContract_0;
			if (this.jsonSerializer_0.MetadataPropertyHandling != MetadataPropertyHandling.Ignore && jsonReader_0.TokenType == JsonToken.PropertyName && string.Equals(jsonReader_0.Value.ToString(), "$value", StringComparison.Ordinal))
			{
				jsonReader_0.method_25();
				if (jsonReader_0.TokenType == JsonToken.StartObject)
				{
					throw JsonSerializationException.Create(jsonReader_0, "Unexpected token when deserializing primitive value: " + jsonReader_0.TokenType);
				}
				object result3 = this.method_11(jsonReader_0, type, jsonContract_, jsonProperty_0, null, null, object_0);
				jsonReader_0.method_25();
				return result3;
			}
			break;
		}
		case (Enum8)5:
		{
			JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract_0;
			object result4;
			if (object_0 == null)
			{
				bool flag2;
				IDictionary dictionary = this.method_28(jsonReader_0, jsonDictionaryContract, out flag2);
				if (flag2)
				{
					if (text != null)
					{
						throw JsonSerializationException.Create(jsonReader_0, "Cannot preserve reference to readonly dictionary, or dictionary created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
					}
					if (jsonContract_0.OnSerializingCallbacks.Count > 0)
					{
						throw JsonSerializationException.Create(jsonReader_0, "Cannot call OnSerializing on readonly dictionary, or dictionary created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
					}
					if (jsonContract_0.OnErrorCallbacks.Count > 0)
					{
						throw JsonSerializationException.Create(jsonReader_0, "Cannot call OnError on readonly list, or dictionary created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
					}
					if (!jsonDictionaryContract.method_11())
					{
						throw JsonSerializationException.Create(jsonReader_0, "Cannot deserialize readonly or fixed size dictionary: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
					}
				}
				this.method_31(dictionary, jsonReader_0, jsonDictionaryContract, jsonProperty_0, text);
				if (flag2)
				{
					return (jsonDictionaryContract.OverrideCreator ?? jsonDictionaryContract.method_10())(new object[]
					{
						dictionary
					});
				}
				Interface1 @interface;
				if ((@interface = (dictionary as Interface1)) != null)
				{
					return @interface.UnderlyingDictionary;
				}
				result4 = dictionary;
			}
			else
			{
				IDictionary idictionary_;
				if (!jsonDictionaryContract.method_9() && object_0 is IDictionary)
				{
					idictionary_ = (IDictionary)object_0;
				}
				else
				{
					IDictionary dictionary2 = jsonDictionaryContract.method_12(object_0);
					idictionary_ = dictionary2;
				}
				result4 = this.method_31(idictionary_, jsonReader_0, jsonDictionaryContract, jsonProperty_0, text);
			}
			return result4;
		}
		case (Enum8)6:
		{
			JsonDynamicContract jsonDynamicContract_ = (JsonDynamicContract)jsonContract_0;
			return this.method_37(jsonReader_0, jsonDynamicContract_, jsonProperty_0, text);
		}
		case (Enum8)7:
		{
			JsonISerializableContract jsonISerializableContract_ = (JsonISerializableContract)jsonContract_0;
			return this.method_35(jsonReader_0, jsonISerializableContract_, jsonProperty_0, text);
		}
		}
		string text2 = "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object." + Environment.NewLine;
		text2 = text2.smethod_1(CultureInfo.InvariantCulture, type, this.method_12(jsonContract_0));
		throw JsonSerializationException.Create(jsonReader_0, text2);
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00033C50 File Offset: 0x00031E50
	private bool method_15(JTokenReader jtokenReader_0, ref Type type_0, ref JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0, out object object_1, out string string_0)
	{
		string_0 = null;
		object_1 = null;
		if (jtokenReader_0.TokenType == JsonToken.StartObject)
		{
			JObject jobject = (JObject)jtokenReader_0.CurrentToken;
			JToken jtoken = jobject["$ref"];
			if (jtoken != null)
			{
				if (jtoken.Type != JTokenType.String && jtoken.Type != JTokenType.Null)
				{
					throw JsonSerializationException.Create(jtoken, jtoken.Path, "JSON reference {0} property must have a string or null value.".smethod_0(CultureInfo.InvariantCulture, "$ref"), null);
				}
				JToken parent = jtoken.Parent;
				JToken jtoken2 = null;
				if (parent.Next != null)
				{
					jtoken2 = parent.Next;
				}
				else if (parent.Previous != null)
				{
					jtoken2 = parent.Previous;
				}
				string text = (string)jtoken;
				if (text != null)
				{
					if (jtoken2 != null)
					{
						throw JsonSerializationException.Create(jtoken2, jtoken2.Path, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".smethod_0(CultureInfo.InvariantCulture, "$ref"), null);
					}
					object_1 = this.jsonSerializer_0.method_4().ResolveReference(this, text);
					if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
					{
						this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(jtokenReader_0, jtokenReader_0.Path, "Resolved object reference '{0}' to {1}.".smethod_1(CultureInfo.InvariantCulture, text, object_1.GetType())), null);
					}
					jtokenReader_0.Skip();
					return true;
				}
			}
			JToken jtoken3 = jobject["$type"];
			if (jtoken3 != null)
			{
				string string_ = (string)jtoken3;
				JsonReader jsonReader = jtoken3.CreateReader();
				jsonReader.method_25();
				this.method_17(jsonReader, ref type_0, ref jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, string_);
				if (jobject["$value"] != null)
				{
					for (;;)
					{
						jtokenReader_0.method_25();
						if (jtokenReader_0.TokenType == JsonToken.PropertyName && (string)jtokenReader_0.Value == "$value")
						{
							break;
						}
						jtokenReader_0.method_25();
						jtokenReader_0.Skip();
					}
					return false;
				}
			}
			JToken jtoken4 = jobject["$id"];
			if (jtoken4 != null)
			{
				string_0 = (string)jtoken4;
			}
			JToken jtoken5 = jobject["$values"];
			if (jtoken5 != null)
			{
				JsonReader jsonReader2 = jtoken5.CreateReader();
				jsonReader2.method_25();
				object_1 = this.method_19(jsonReader2, type_0, jsonContract_0, jsonProperty_0, object_0, string_0);
				jtokenReader_0.Skip();
				return true;
			}
		}
		jtokenReader_0.method_25();
		return false;
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00033E70 File Offset: 0x00032070
	private bool method_16(JsonReader jsonReader_0, ref Type type_0, ref JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, object object_0, out object object_1, out string string_0)
	{
		string_0 = null;
		object_1 = null;
		if (jsonReader_0.TokenType == JsonToken.PropertyName)
		{
			string text = jsonReader_0.Value.ToString();
			if (text.Length > 0 && text[0] == '$')
			{
				string text2;
				do
				{
					text = jsonReader_0.Value.ToString();
					bool flag;
					if (string.Equals(text, "$ref", StringComparison.Ordinal))
					{
						jsonReader_0.method_25();
						if (jsonReader_0.TokenType != JsonToken.String && jsonReader_0.TokenType != JsonToken.Null)
						{
							goto Block_11;
						}
						object value = jsonReader_0.Value;
						text2 = ((value != null) ? value.ToString() : null);
						jsonReader_0.method_25();
						if (text2 != null)
						{
							goto IL_14E;
						}
						flag = true;
					}
					else if (string.Equals(text, "$type", StringComparison.Ordinal))
					{
						jsonReader_0.method_25();
						string string_ = jsonReader_0.Value.ToString();
						this.method_17(jsonReader_0, ref type_0, ref jsonContract_0, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, string_);
						jsonReader_0.method_25();
						flag = true;
					}
					else if (string.Equals(text, "$id", StringComparison.Ordinal))
					{
						jsonReader_0.method_25();
						object value2 = jsonReader_0.Value;
						string_0 = ((value2 != null) ? value2.ToString() : null);
						jsonReader_0.method_25();
						flag = true;
					}
					else
					{
						if (string.Equals(text, "$values", StringComparison.Ordinal))
						{
							goto IL_1D5;
						}
						flag = false;
					}
					if (!flag)
					{
						break;
					}
				}
				while (jsonReader_0.TokenType == JsonToken.PropertyName);
				return false;
				Block_11:
				throw JsonSerializationException.Create(jsonReader_0, "JSON reference {0} property must have a string or null value.".smethod_0(CultureInfo.InvariantCulture, "$ref"));
				IL_14E:
				if (jsonReader_0.TokenType == JsonToken.PropertyName)
				{
					throw JsonSerializationException.Create(jsonReader_0, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".smethod_0(CultureInfo.InvariantCulture, "$ref"));
				}
				object_1 = this.jsonSerializer_0.method_4().ResolveReference(this, text2);
				if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
				{
					this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Resolved object reference '{0}' to {1}.".smethod_1(CultureInfo.InvariantCulture, text2, object_1.GetType())), null);
				}
				return true;
				IL_1D5:
				jsonReader_0.method_25();
				object obj = this.method_19(jsonReader_0, type_0, jsonContract_0, jsonProperty_0, object_0, string_0);
				jsonReader_0.method_25();
				object_1 = obj;
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00034078 File Offset: 0x00032278
	private void method_17(JsonReader jsonReader_0, ref Type type_0, ref JsonContract jsonContract_0, JsonProperty jsonProperty_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, string string_0)
	{
		if ((((jsonProperty_0 != null) ? jsonProperty_0.TypeNameHandling : null) ?? (((jsonContainerContract_0 != null) ? jsonContainerContract_0.ItemTypeNameHandling : null) ?? (((jsonProperty_1 != null) ? jsonProperty_1.ItemTypeNameHandling : null) ?? this.jsonSerializer_0.typeNameHandling_0))) != TypeNameHandling.None)
		{
			Struct9<string, string> @struct = Class90.smethod_35(string_0);
			Type type;
			try
			{
				type = this.jsonSerializer_0.ginterface2_0.BindToType(@struct.gparam_0, @struct.gparam_1);
			}
			catch (Exception ex)
			{
				throw JsonSerializationException.Create(jsonReader_0, "Error resolving type specified in JSON '{0}'.".smethod_0(CultureInfo.InvariantCulture, string_0), ex);
			}
			if (type == null)
			{
				throw JsonSerializationException.Create(jsonReader_0, "Type specified in JSON '{0}' was not resolved.".smethod_0(CultureInfo.InvariantCulture, string_0));
			}
			if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
			{
				this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Resolved type '{0}' to {1}.".smethod_1(CultureInfo.InvariantCulture, string_0, type)), null);
			}
			if (type_0 != null && type_0 != typeof(IDynamicMetaObjectProvider) && !type_0.IsAssignableFrom(type))
			{
				throw JsonSerializationException.Create(jsonReader_0, "Type specified in JSON '{0}' is not compatible with '{1}'.".smethod_1(CultureInfo.InvariantCulture, type.AssemblyQualifiedName, type_0.AssemblyQualifiedName));
			}
			type_0 = type;
			jsonContract_0 = this.method_6(type);
		}
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x0003422C File Offset: 0x0003242C
	private JsonArrayContract method_18(JsonReader jsonReader_0, Type type_0, JsonContract jsonContract_0)
	{
		if (jsonContract_0 == null)
		{
			throw JsonSerializationException.Create(jsonReader_0, "Could not resolve type '{0}' to a JsonContract.".smethod_0(CultureInfo.InvariantCulture, type_0));
		}
		JsonArrayContract jsonArrayContract = jsonContract_0 as JsonArrayContract;
		if (jsonArrayContract == null)
		{
			string text = "Cannot deserialize the current JSON array (e.g. [1,2,3]) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array." + Environment.NewLine;
			text = text.smethod_1(CultureInfo.InvariantCulture, type_0, this.method_12(jsonContract_0));
			throw JsonSerializationException.Create(jsonReader_0, text);
		}
		return jsonArrayContract;
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00034294 File Offset: 0x00032494
	private object method_19(JsonReader jsonReader_0, Type type_0, JsonContract jsonContract_0, JsonProperty jsonProperty_0, object object_0, string string_0)
	{
		if (this.method_20(jsonContract_0))
		{
			return this.method_9(jsonReader_0, jsonContract_0);
		}
		JsonArrayContract jsonArrayContract = this.method_18(jsonReader_0, type_0, jsonContract_0);
		object result;
		if (object_0 == null)
		{
			bool flag;
			IList list = this.method_27(jsonReader_0, jsonArrayContract, out flag);
			if (flag)
			{
				if (string_0 != null)
				{
					throw JsonSerializationException.Create(jsonReader_0, "Cannot preserve reference to array or readonly list, or list created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
				}
				if (jsonContract_0.OnSerializingCallbacks.Count > 0)
				{
					throw JsonSerializationException.Create(jsonReader_0, "Cannot call OnSerializing on an array or readonly list, or list created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
				}
				if (jsonContract_0.OnErrorCallbacks.Count > 0)
				{
					throw JsonSerializationException.Create(jsonReader_0, "Cannot call OnError on an array or readonly list, or list created from a non-default constructor: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
				}
				if (!jsonArrayContract.method_11() && !jsonArrayContract.lCxtTgyZib())
				{
					throw JsonSerializationException.Create(jsonReader_0, "Cannot deserialize readonly or fixed size list: {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType));
				}
			}
			if (!jsonArrayContract.IsMultidimensionalArray)
			{
				this.method_34(list, jsonReader_0, jsonArrayContract, jsonProperty_0, string_0);
			}
			else
			{
				this.method_32(list, jsonReader_0, jsonArrayContract, jsonProperty_0, string_0);
			}
			Interface0 @interface;
			if (flag)
			{
				if (jsonArrayContract.IsMultidimensionalArray)
				{
					list = Class20.smethod_16(list, jsonArrayContract.CollectionItemType, jsonContract_0.CreatedType.GetArrayRank());
				}
				else
				{
					if (!jsonArrayContract.lCxtTgyZib())
					{
						return (jsonArrayContract.OverrideCreator ?? jsonArrayContract.method_10())(new object[]
						{
							list
						});
					}
					Array array = Array.CreateInstance(jsonArrayContract.CollectionItemType, list.Count);
					list.CopyTo(array, 0);
					list = array;
				}
			}
			else if ((@interface = (list as Interface0)) != null)
			{
				return @interface.UnderlyingCollection;
			}
			result = list;
		}
		else
		{
			if (!jsonArrayContract.method_8())
			{
				throw JsonSerializationException.Create(jsonReader_0, "Cannot populate list type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.CreatedType));
			}
			IList list2;
			IList ilist_;
			if (!jsonArrayContract.method_7() && (list2 = (object_0 as IList)) != null)
			{
				ilist_ = list2;
			}
			else
			{
				IList list3 = jsonArrayContract.mRrtQkaEd1(object_0);
				ilist_ = list3;
			}
			result = this.method_34(ilist_, jsonReader_0, jsonArrayContract, jsonProperty_0, string_0);
		}
		return result;
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00008FD7 File Offset: 0x000071D7
	private bool method_20(JsonContract jsonContract_0)
	{
		return jsonContract_0 == null || jsonContract_0.UnderlyingType == typeof(object) || jsonContract_0.enum8_0 == (Enum8)8 || jsonContract_0.UnderlyingType == typeof(IDynamicMetaObjectProvider);
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00034478 File Offset: 0x00032678
	private object method_21(JsonReader jsonReader_0, object object_0, CultureInfo cultureInfo_0, JsonContract jsonContract_0, Type type_0)
	{
		if (type_0 == null)
		{
			return object_0;
		}
		if (!(Class90.smethod_3(object_0) != type_0))
		{
			return object_0;
		}
		if (object_0 == null && jsonContract_0.bool_0)
		{
			return null;
		}
		object result;
		try
		{
			if (jsonContract_0.bool_1)
			{
				JsonPrimitiveContract jsonPrimitiveContract = (JsonPrimitiveContract)jsonContract_0;
				string string_2;
				DateTime dateTime_;
				if (jsonContract_0.bool_2)
				{
					string string_;
					if ((string_ = (object_0 as string)) != null)
					{
						return Class53.smethod_7(jsonContract_0.type_0, null, string_, false);
					}
					if (Class23.smethod_13(jsonPrimitiveContract.method_5()))
					{
						return Enum.ToObject(jsonContract_0.type_0, object_0);
					}
				}
				else if (jsonContract_0.type_0 == typeof(DateTime) && (string_2 = (object_0 as string)) != null && Class25.smethod_16(string_2, jsonReader_0.DateTimeZoneHandling, jsonReader_0.DateFormatString, jsonReader_0.Culture, out dateTime_))
				{
					return Class25.smethod_2(dateTime_, jsonReader_0.DateTimeZoneHandling);
				}
				if (object_0 is BigInteger)
				{
					BigInteger bigInteger_ = (BigInteger)object_0;
					result = Class23.smethod_7(bigInteger_, jsonContract_0.type_0);
				}
				else
				{
					result = Convert.ChangeType(object_0, jsonContract_0.type_0, cultureInfo_0);
				}
			}
			else
			{
				result = Class23.smethod_10(object_0, cultureInfo_0, jsonContract_0.type_0);
			}
		}
		catch (Exception ex)
		{
			throw JsonSerializationException.Create(jsonReader_0, "Error converting value {0} to type '{1}'.".smethod_1(CultureInfo.InvariantCulture, Class80.smethod_2(object_0), type_0), ex);
		}
		return result;
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x000345E4 File Offset: 0x000327E4
	private bool method_22(JsonProperty jsonProperty_0, JsonConverter jsonConverter_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, JsonReader jsonReader_0, object object_0)
	{
		bool flag;
		object value;
		JsonContract jsonContract_;
		bool flag2;
		bool result;
		if (this.method_23(jsonProperty_0, ref jsonConverter_0, jsonContainerContract_0, jsonProperty_1, jsonReader_0, object_0, out flag, out value, out jsonContract_, out flag2, out result))
		{
			return result;
		}
		object obj;
		if (jsonConverter_0 != null && jsonConverter_0.CanRead)
		{
			if (!flag2 && object_0 != null && jsonProperty_0.Readable)
			{
				value = jsonProperty_0.ValueProvider.GetValue(object_0);
			}
			obj = this.method_39(jsonConverter_0, jsonReader_0, jsonProperty_0.PropertyType, value);
		}
		else
		{
			obj = this.method_11(jsonReader_0, jsonProperty_0.PropertyType, jsonContract_, jsonProperty_0, jsonContainerContract_0, jsonProperty_1, flag ? value : null);
		}
		if ((!flag || obj != value) && this.method_26(jsonProperty_0, jsonContainerContract_0 as JsonObjectContract, obj))
		{
			jsonProperty_0.ValueProvider.SetValue(object_0, obj);
			if (jsonProperty_0.SetIsSpecified != null)
			{
				if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
				{
					this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "IsSpecified for property '{0}' on {1} set to true.".smethod_1(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType)), null);
				}
				jsonProperty_0.SetIsSpecified(object_0, true);
			}
			return true;
		}
		return flag;
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00034708 File Offset: 0x00032908
	private bool method_23(JsonProperty jsonProperty_0, ref JsonConverter jsonConverter_0, JsonContainerContract jsonContainerContract_0, JsonProperty jsonProperty_1, JsonReader jsonReader_0, object object_0, out bool bool_0, out object object_1, out JsonContract jsonContract_0, out bool bool_1, out bool bool_2)
	{
		object_1 = null;
		bool_0 = false;
		jsonContract_0 = null;
		bool_1 = false;
		bool_2 = false;
		if (jsonProperty_0.Ignored)
		{
			return true;
		}
		JsonToken tokenType = jsonReader_0.TokenType;
		if (jsonProperty_0.method_0() == null)
		{
			jsonProperty_0.method_1(this.method_6(jsonProperty_0.PropertyType));
		}
		if (jsonProperty_0.ObjectCreationHandling.GetValueOrDefault(this.jsonSerializer_0.objectCreationHandling_0) != ObjectCreationHandling.Replace && (tokenType == JsonToken.StartArray || tokenType == JsonToken.StartObject || jsonConverter_0 != null) && jsonProperty_0.Readable)
		{
			object_1 = jsonProperty_0.ValueProvider.GetValue(object_0);
			bool_1 = true;
			if (object_1 != null)
			{
				jsonContract_0 = this.method_6(object_1.GetType());
				bool_0 = (!jsonContract_0.bool_3 && !jsonContract_0.UnderlyingType.smethod_13());
			}
		}
		if (!jsonProperty_0.Writable && !bool_0)
		{
			if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
			{
				this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Unable to deserialize value to non-writable property '{0}' on {1}.".smethod_1(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType)), null);
			}
			return true;
		}
		if (tokenType == JsonToken.Null && base.method_1(jsonContainerContract_0 as JsonObjectContract, jsonProperty_0) == NullValueHandling.Ignore)
		{
			bool_2 = true;
			return true;
		}
		if (this.method_25(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(this.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Ignore) && !this.method_25(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(this.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Populate) && Class71.smethod_2(tokenType) && Class80.smethod_0(jsonReader_0.Value, jsonProperty_0.method_2()))
		{
			bool_2 = true;
			return true;
		}
		if (object_1 == null)
		{
			jsonContract_0 = jsonProperty_0.method_0();
		}
		else
		{
			jsonContract_0 = this.method_6(object_1.GetType());
			if (jsonContract_0 != jsonProperty_0.method_0())
			{
				jsonConverter_0 = this.method_13(jsonContract_0, jsonProperty_0.Converter, jsonContainerContract_0, jsonProperty_1);
			}
		}
		return false;
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x000348F4 File Offset: 0x00032AF4
	private void method_24(JsonReader jsonReader_0, string string_0, object object_0)
	{
		try
		{
			if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
			{
				this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Read object reference Id '{0}' for {1}.".smethod_1(CultureInfo.InvariantCulture, string_0, object_0.GetType())), null);
			}
			this.jsonSerializer_0.method_4().AddReference(this, string_0, object_0);
		}
		catch (Exception ex)
		{
			throw JsonSerializationException.Create(jsonReader_0, "Error reading object reference '{0}'.".smethod_0(CultureInfo.InvariantCulture, string_0), ex);
		}
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00009015 File Offset: 0x00007215
	private bool method_25(DefaultValueHandling defaultValueHandling_0, DefaultValueHandling defaultValueHandling_1)
	{
		return (defaultValueHandling_0 & defaultValueHandling_1) == defaultValueHandling_1;
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x0003498C File Offset: 0x00032B8C
	private bool method_26(JsonProperty jsonProperty_0, JsonObjectContract jsonObjectContract_0, object object_0)
	{
		return (object_0 != null || base.method_1(jsonObjectContract_0, jsonProperty_0) != NullValueHandling.Ignore) && (!this.method_25(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(this.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Ignore) || this.method_25(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(this.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Populate) || !Class80.smethod_0(object_0, jsonProperty_0.method_2())) && jsonProperty_0.Writable;
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00034A08 File Offset: 0x00032C08
	private IList method_27(JsonReader jsonReader_0, JsonArrayContract jsonArrayContract_0, out bool bool_0)
	{
		if (!jsonArrayContract_0.method_8())
		{
			throw JsonSerializationException.Create(jsonReader_0, "Cannot create and populate list type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonArrayContract_0.CreatedType));
		}
		if (jsonArrayContract_0.OverrideCreator != null)
		{
			if (jsonArrayContract_0.HasParameterizedCreator)
			{
				bool_0 = true;
				return jsonArrayContract_0.method_12();
			}
			object obj = jsonArrayContract_0.OverrideCreator(new object[0]);
			if (jsonArrayContract_0.method_7())
			{
				obj = jsonArrayContract_0.mRrtQkaEd1(obj);
			}
			bool_0 = false;
			return (IList)obj;
		}
		else
		{
			if (jsonArrayContract_0.bool_3)
			{
				bool_0 = true;
				IList list = jsonArrayContract_0.method_12();
				if (jsonArrayContract_0.method_7())
				{
					list = jsonArrayContract_0.mRrtQkaEd1(list);
				}
				return list;
			}
			if (jsonArrayContract_0.DefaultCreator != null && (!jsonArrayContract_0.DefaultCreatorNonPublic || this.jsonSerializer_0.constructorHandling_0 == ConstructorHandling.AllowNonPublicDefaultConstructor))
			{
				object obj2 = jsonArrayContract_0.DefaultCreator();
				if (jsonArrayContract_0.method_7())
				{
					obj2 = jsonArrayContract_0.mRrtQkaEd1(obj2);
				}
				bool_0 = false;
				return (IList)obj2;
			}
			if (jsonArrayContract_0.method_11())
			{
				bool_0 = true;
				return jsonArrayContract_0.method_12();
			}
			if (!jsonArrayContract_0.bool_5)
			{
				throw JsonSerializationException.Create(jsonReader_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_0(CultureInfo.InvariantCulture, jsonArrayContract_0.UnderlyingType));
			}
			throw JsonSerializationException.Create(jsonReader_0, "Unable to find a constructor to use for type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonArrayContract_0.UnderlyingType));
		}
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00034B38 File Offset: 0x00032D38
	private IDictionary method_28(JsonReader jsonReader_0, JsonDictionaryContract jsonDictionaryContract_0, out bool bool_0)
	{
		if (jsonDictionaryContract_0.OverrideCreator != null)
		{
			if (jsonDictionaryContract_0.HasParameterizedCreator)
			{
				bool_0 = true;
				return jsonDictionaryContract_0.method_13();
			}
			bool_0 = false;
			return (IDictionary)jsonDictionaryContract_0.OverrideCreator(new object[0]);
		}
		else
		{
			if (jsonDictionaryContract_0.bool_3)
			{
				bool_0 = true;
				return jsonDictionaryContract_0.method_13();
			}
			if (jsonDictionaryContract_0.DefaultCreator != null && (!jsonDictionaryContract_0.DefaultCreatorNonPublic || this.jsonSerializer_0.constructorHandling_0 == ConstructorHandling.AllowNonPublicDefaultConstructor))
			{
				object obj = jsonDictionaryContract_0.DefaultCreator();
				if (jsonDictionaryContract_0.method_9())
				{
					obj = jsonDictionaryContract_0.method_12(obj);
				}
				bool_0 = false;
				return (IDictionary)obj;
			}
			if (jsonDictionaryContract_0.method_11())
			{
				bool_0 = true;
				return jsonDictionaryContract_0.method_13();
			}
			if (!jsonDictionaryContract_0.bool_5)
			{
				throw JsonSerializationException.Create(jsonReader_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_0(CultureInfo.InvariantCulture, jsonDictionaryContract_0.UnderlyingType));
			}
			throw JsonSerializationException.Create(jsonReader_0, "Unable to find a default constructor to use for type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonDictionaryContract_0.UnderlyingType));
		}
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00034C20 File Offset: 0x00032E20
	private void method_29(JsonReader jsonReader_0, JsonContract jsonContract_0, object object_0)
	{
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Started deserializing {0}".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
		}
		jsonContract_0.method_2(object_0, this.jsonSerializer_0.streamingContext_0);
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00034C88 File Offset: 0x00032E88
	private void method_30(JsonReader jsonReader_0, JsonContract jsonContract_0, object object_0)
	{
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Finished deserializing {0}".smethod_0(CultureInfo.InvariantCulture, jsonContract_0.UnderlyingType)), null);
		}
		jsonContract_0.method_3(object_0, this.jsonSerializer_0.streamingContext_0);
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00034CF0 File Offset: 0x00032EF0
	private object method_31(IDictionary idictionary_0, JsonReader jsonReader_0, JsonDictionaryContract jsonDictionaryContract_0, JsonProperty jsonProperty_0, string string_0)
	{
		Interface1 @interface;
		object obj = ((@interface = (idictionary_0 as Interface1)) != null) ? @interface.UnderlyingDictionary : idictionary_0;
		if (string_0 != null)
		{
			this.method_24(jsonReader_0, string_0, obj);
		}
		this.method_29(jsonReader_0, jsonDictionaryContract_0, obj);
		int depth = jsonReader_0.Depth;
		if (jsonDictionaryContract_0.method_7() == null)
		{
			jsonDictionaryContract_0.method_8(this.method_6(jsonDictionaryContract_0.DictionaryKeyType));
		}
		if (jsonDictionaryContract_0.EwhtYgWttB() == null)
		{
			jsonDictionaryContract_0.method_5(this.method_6(jsonDictionaryContract_0.DictionaryValueType));
		}
		JsonConverter jsonConverter = jsonDictionaryContract_0.ItemConverter ?? this.method_13(jsonDictionaryContract_0.EwhtYgWttB(), null, jsonDictionaryContract_0, jsonProperty_0);
		JsonPrimitiveContract jsonPrimitiveContract;
		Enum3 @enum = ((jsonPrimitiveContract = (jsonDictionaryContract_0.method_7() as JsonPrimitiveContract)) != null) ? jsonPrimitiveContract.method_5() : ((Enum3)0);
		bool flag = false;
		for (;;)
		{
			JsonToken tokenType = jsonReader_0.TokenType;
			if (tokenType != JsonToken.PropertyName)
			{
				if (tokenType == JsonToken.Comment)
				{
					goto IL_25D;
				}
				if (tokenType != JsonToken.EndObject)
				{
					goto Block_11;
				}
				flag = true;
				goto IL_25D;
			}
			else
			{
				object obj2 = jsonReader_0.Value;
				if (this.method_44(jsonReader_0, obj2.ToString()))
				{
					goto IL_25D;
				}
				try
				{
					try
					{
						if (@enum - (Enum3)26 > 1)
						{
							if (@enum - (Enum3)28 > 1)
							{
								obj2 = this.method_21(jsonReader_0, obj2, CultureInfo.InvariantCulture, jsonDictionaryContract_0.method_7(), jsonDictionaryContract_0.DictionaryKeyType);
							}
							else
							{
								DateTimeOffset dateTimeOffset;
								obj2 = (Class25.smethod_18(obj2.ToString(), jsonReader_0.DateFormatString, jsonReader_0.Culture, out dateTimeOffset) ? dateTimeOffset : this.method_21(jsonReader_0, obj2, CultureInfo.InvariantCulture, jsonDictionaryContract_0.method_7(), jsonDictionaryContract_0.DictionaryKeyType));
							}
						}
						else
						{
							DateTime dateTime;
							obj2 = (Class25.smethod_16(obj2.ToString(), jsonReader_0.DateTimeZoneHandling, jsonReader_0.DateFormatString, jsonReader_0.Culture, out dateTime) ? dateTime : this.method_21(jsonReader_0, obj2, CultureInfo.InvariantCulture, jsonDictionaryContract_0.method_7(), jsonDictionaryContract_0.DictionaryKeyType));
						}
					}
					catch (Exception ex)
					{
						throw JsonSerializationException.Create(jsonReader_0, "Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.".smethod_1(CultureInfo.InvariantCulture, jsonReader_0.Value, jsonDictionaryContract_0.DictionaryKeyType), ex);
					}
					if (!jsonReader_0.method_27(jsonDictionaryContract_0.EwhtYgWttB(), jsonConverter != null))
					{
						throw JsonSerializationException.Create(jsonReader_0, "Unexpected end when deserializing object.");
					}
					object value;
					if (jsonConverter != null && jsonConverter.CanRead)
					{
						value = this.method_39(jsonConverter, jsonReader_0, jsonDictionaryContract_0.DictionaryValueType, null);
					}
					else
					{
						value = this.method_11(jsonReader_0, jsonDictionaryContract_0.DictionaryValueType, jsonDictionaryContract_0.EwhtYgWttB(), null, jsonDictionaryContract_0, jsonProperty_0, null);
					}
					idictionary_0[obj2] = value;
					goto IL_25D;
				}
				catch (Exception exception_)
				{
					if (!base.method_4(obj, jsonDictionaryContract_0, obj2, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, exception_))
					{
						throw;
					}
					this.method_48(jsonReader_0, true, depth);
					goto IL_25D;
				}
			}
			IL_241:
			if (!jsonReader_0.Read())
			{
				break;
			}
			continue;
			IL_25D:
			if (!flag)
			{
				goto IL_241;
			}
			break;
		}
		goto IL_27E;
		Block_11:
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.TokenType);
		IL_27E:
		if (!flag)
		{
			this.method_33(jsonReader_0, jsonDictionaryContract_0, obj, "Unexpected end when deserializing object.");
		}
		this.method_30(jsonReader_0, jsonDictionaryContract_0, obj);
		return obj;
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00034FD0 File Offset: 0x000331D0
	private object method_32(IList ilist_0, JsonReader jsonReader_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, string string_0)
	{
		int arrayRank = jsonArrayContract_0.UnderlyingType.GetArrayRank();
		if (string_0 != null)
		{
			this.method_24(jsonReader_0, string_0, ilist_0);
		}
		this.method_29(jsonReader_0, jsonArrayContract_0, ilist_0);
		JsonContract jsonContract_ = this.method_6(jsonArrayContract_0.CollectionItemType);
		JsonConverter jsonConverter = this.method_13(jsonContract_, null, jsonArrayContract_0, jsonProperty_0);
		int? num = null;
		Stack<IList> stack = new Stack<IList>();
		stack.Push(ilist_0);
		IList list = ilist_0;
		bool flag = false;
		for (;;)
		{
			int depth = jsonReader_0.Depth;
			if (stack.Count == arrayRank)
			{
				try
				{
					if (!jsonReader_0.method_27(jsonContract_, jsonConverter != null))
					{
						goto IL_208;
					}
					JsonToken tokenType = jsonReader_0.TokenType;
					if (tokenType != JsonToken.Comment)
					{
						if (tokenType == JsonToken.EndArray)
						{
							stack.Pop();
							list = stack.Peek();
							num = null;
						}
						else
						{
							object value;
							if (jsonConverter != null && jsonConverter.CanRead)
							{
								value = this.method_39(jsonConverter, jsonReader_0, jsonArrayContract_0.CollectionItemType, null);
							}
							else
							{
								value = this.method_11(jsonReader_0, jsonArrayContract_0.CollectionItemType, jsonContract_, null, jsonArrayContract_0, jsonProperty_0, null);
							}
							list.Add(value);
						}
					}
				}
				catch (Exception ex)
				{
					Struct0 @struct = jsonReader_0.method_5(depth);
					if (!base.method_4(ilist_0, jsonArrayContract_0, @struct.int_0, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, ex))
					{
						throw;
					}
					this.method_48(jsonReader_0, true, depth + 1);
					if (num != null)
					{
						int? num2 = num;
						int int_ = @struct.int_0;
						if (num2.GetValueOrDefault() == int_ & num2 != null)
						{
							throw JsonSerializationException.Create(jsonReader_0, "Infinite loop detected from error handling.", ex);
						}
					}
					num = new int?(@struct.int_0);
				}
			}
			else
			{
				if (!jsonReader_0.Read())
				{
					goto IL_208;
				}
				JsonToken tokenType = jsonReader_0.TokenType;
				if (tokenType != JsonToken.StartArray)
				{
					if (tokenType != JsonToken.Comment)
					{
						if (tokenType != JsonToken.EndArray)
						{
							break;
						}
						stack.Pop();
						if (stack.Count > 0)
						{
							list = stack.Peek();
						}
						else
						{
							flag = true;
						}
					}
				}
				else
				{
					IList list2 = new List<object>();
					list.Add(list2);
					stack.Push(list2);
					list = list2;
				}
			}
			if (flag)
			{
				goto Block_9;
			}
		}
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected token when deserializing multidimensional array: " + jsonReader_0.TokenType);
		Block_9:
		IL_208:
		if (!flag)
		{
			this.method_33(jsonReader_0, jsonArrayContract_0, ilist_0, "Unexpected end when deserializing array.");
		}
		this.method_30(jsonReader_0, jsonArrayContract_0, ilist_0);
		return ilist_0;
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00035214 File Offset: 0x00033414
	private void method_33(JsonReader jsonReader_0, JsonContract jsonContract_0, object object_0, string string_0)
	{
		try
		{
			throw JsonSerializationException.Create(jsonReader_0, string_0);
		}
		catch (Exception exception_)
		{
			if (!base.method_4(object_0, jsonContract_0, null, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, exception_))
			{
				throw;
			}
			this.method_48(jsonReader_0, false, 0);
		}
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00035264 File Offset: 0x00033464
	private object method_34(IList ilist_0, JsonReader jsonReader_0, JsonArrayContract jsonArrayContract_0, JsonProperty jsonProperty_0, string string_0)
	{
		Interface0 @interface;
		object obj = ((@interface = (ilist_0 as Interface0)) != null) ? @interface.UnderlyingCollection : ilist_0;
		if (string_0 != null)
		{
			this.method_24(jsonReader_0, string_0, obj);
		}
		if (ilist_0.IsFixedSize)
		{
			jsonReader_0.Skip();
			return obj;
		}
		this.method_29(jsonReader_0, jsonArrayContract_0, obj);
		int depth = jsonReader_0.Depth;
		if (jsonArrayContract_0.EwhtYgWttB() == null)
		{
			jsonArrayContract_0.method_5(this.method_6(jsonArrayContract_0.CollectionItemType));
		}
		JsonConverter jsonConverter = this.method_13(jsonArrayContract_0.EwhtYgWttB(), null, jsonArrayContract_0, jsonProperty_0);
		int? num = null;
		bool flag = false;
		do
		{
			try
			{
				if (!jsonReader_0.method_27(jsonArrayContract_0.EwhtYgWttB(), jsonConverter != null))
				{
					break;
				}
				JsonToken tokenType = jsonReader_0.TokenType;
				if (tokenType != JsonToken.Comment)
				{
					if (tokenType == JsonToken.EndArray)
					{
						flag = true;
					}
					else
					{
						object value;
						if (jsonConverter != null && jsonConverter.CanRead)
						{
							value = this.method_39(jsonConverter, jsonReader_0, jsonArrayContract_0.CollectionItemType, null);
						}
						else
						{
							value = this.method_11(jsonReader_0, jsonArrayContract_0.CollectionItemType, jsonArrayContract_0.EwhtYgWttB(), null, jsonArrayContract_0, jsonProperty_0, null);
						}
						ilist_0.Add(value);
					}
				}
			}
			catch (Exception ex)
			{
				Struct0 @struct = jsonReader_0.method_5(depth);
				if (!base.method_4(obj, jsonArrayContract_0, @struct.int_0, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, ex))
				{
					throw;
				}
				this.method_48(jsonReader_0, true, depth + 1);
				if (num != null)
				{
					int? num2 = num;
					int int_ = @struct.int_0;
					if (num2.GetValueOrDefault() == int_ & num2 != null)
					{
						throw JsonSerializationException.Create(jsonReader_0, "Infinite loop detected from error handling.", ex);
					}
				}
				num = new int?(@struct.int_0);
			}
		}
		while (!flag);
		if (!flag)
		{
			this.method_33(jsonReader_0, jsonArrayContract_0, obj, "Unexpected end when deserializing array.");
		}
		this.method_30(jsonReader_0, jsonArrayContract_0, obj);
		return obj;
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x00035418 File Offset: 0x00033618
	private object method_35(JsonReader jsonReader_0, JsonISerializableContract jsonISerializableContract_0, JsonProperty jsonProperty_0, string string_0)
	{
		Type underlyingType = jsonISerializableContract_0.UnderlyingType;
		if (!Class124.smethod_18())
		{
			string text = "Type '{0}' implements ISerializable but cannot be deserialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
			text = text.smethod_0(CultureInfo.InvariantCulture, underlyingType);
			throw JsonSerializationException.Create(jsonReader_0, text);
		}
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Deserializing {0} using ISerializable constructor.".smethod_0(CultureInfo.InvariantCulture, jsonISerializableContract_0.UnderlyingType)), null);
		}
		SerializationInfo serializationInfo = new SerializationInfo(jsonISerializableContract_0.UnderlyingType, new Class116(this, jsonISerializableContract_0, jsonProperty_0));
		bool flag = false;
		string text2;
		do
		{
			JsonToken tokenType = jsonReader_0.TokenType;
			if (tokenType != JsonToken.PropertyName)
			{
				if (tokenType != JsonToken.Comment)
				{
					if (tokenType != JsonToken.EndObject)
					{
						goto Block_8;
					}
					flag = true;
				}
			}
			else
			{
				text2 = jsonReader_0.Value.ToString();
				if (!jsonReader_0.Read())
				{
					goto IL_10E;
				}
				serializationInfo.AddValue(text2, JToken.ReadFrom(jsonReader_0));
			}
			if (flag)
			{
				break;
			}
		}
		while (jsonReader_0.Read());
		goto IL_126;
		Block_8:
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.TokenType);
		IL_10E:
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, text2));
		IL_126:
		if (!flag)
		{
			this.method_33(jsonReader_0, jsonISerializableContract_0, serializationInfo, "Unexpected end when deserializing object.");
		}
		if (!jsonISerializableContract_0.bool_5)
		{
			throw JsonSerializationException.Create(jsonReader_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_0(CultureInfo.InvariantCulture, jsonISerializableContract_0.UnderlyingType));
		}
		if (jsonISerializableContract_0.ISerializableCreator == null)
		{
			throw JsonSerializationException.Create(jsonReader_0, "ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present.".smethod_0(CultureInfo.InvariantCulture, underlyingType));
		}
		object obj = jsonISerializableContract_0.ISerializableCreator(new object[]
		{
			serializationInfo,
			this.jsonSerializer_0.streamingContext_0
		});
		if (string_0 != null)
		{
			this.method_24(jsonReader_0, string_0, obj);
		}
		this.method_29(jsonReader_0, jsonISerializableContract_0, obj);
		this.method_30(jsonReader_0, jsonISerializableContract_0, obj);
		return obj;
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x000355EC File Offset: 0x000337EC
	internal object method_36(JToken jtoken_0, Type type_0, JsonISerializableContract jsonISerializableContract_0, JsonProperty jsonProperty_0)
	{
		JsonContract jsonContract_ = this.method_6(type_0);
		JsonConverter jsonConverter = this.method_13(jsonContract_, null, jsonISerializableContract_0, jsonProperty_0);
		JsonReader jsonReader = jtoken_0.CreateReader();
		jsonReader.method_25();
		object result;
		if (jsonConverter != null && jsonConverter.CanRead)
		{
			result = this.method_39(jsonConverter, jsonReader, type_0, null);
		}
		else
		{
			result = this.method_11(jsonReader, type_0, jsonContract_, null, jsonISerializableContract_0, jsonProperty_0, null);
		}
		return result;
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00035644 File Offset: 0x00033844
	private object method_37(JsonReader jsonReader_0, JsonDynamicContract jsonDynamicContract_0, JsonProperty jsonProperty_0, string string_0)
	{
		if (!jsonDynamicContract_0.bool_5)
		{
			throw JsonSerializationException.Create(jsonReader_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_0(CultureInfo.InvariantCulture, jsonDynamicContract_0.UnderlyingType));
		}
		if (jsonDynamicContract_0.DefaultCreator != null && (!jsonDynamicContract_0.DefaultCreatorNonPublic || this.jsonSerializer_0.constructorHandling_0 == ConstructorHandling.AllowNonPublicDefaultConstructor))
		{
			IDynamicMetaObjectProvider dynamicMetaObjectProvider = (IDynamicMetaObjectProvider)jsonDynamicContract_0.DefaultCreator();
			if (string_0 != null)
			{
				this.method_24(jsonReader_0, string_0, dynamicMetaObjectProvider);
			}
			this.method_29(jsonReader_0, jsonDynamicContract_0, dynamicMetaObjectProvider);
			int depth = jsonReader_0.Depth;
			bool flag = false;
			for (;;)
			{
				JsonToken tokenType = jsonReader_0.TokenType;
				if (tokenType != JsonToken.PropertyName)
				{
					if (tokenType != JsonToken.EndObject)
					{
						goto Block_8;
					}
					flag = true;
					goto IL_1D9;
				}
				else
				{
					string text = jsonReader_0.Value.ToString();
					try
					{
						if (!jsonReader_0.Read())
						{
							throw JsonSerializationException.Create(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, text));
						}
						JsonProperty closestMatchProperty = jsonDynamicContract_0.Properties.GetClosestMatchProperty(text);
						if (closestMatchProperty != null && closestMatchProperty.Writable && !closestMatchProperty.Ignored)
						{
							if (closestMatchProperty.method_0() == null)
							{
								closestMatchProperty.method_1(this.method_6(closestMatchProperty.PropertyType));
							}
							JsonConverter jsonConverter_ = this.method_13(closestMatchProperty.method_0(), closestMatchProperty.Converter, null, null);
							if (!this.method_22(closestMatchProperty, jsonConverter_, null, jsonProperty_0, jsonReader_0, dynamicMetaObjectProvider))
							{
								jsonReader_0.Skip();
							}
						}
						else
						{
							Type type_ = Class71.smethod_2(jsonReader_0.TokenType) ? jsonReader_0.ValueType : typeof(IDynamicMetaObjectProvider);
							JsonContract jsonContract_ = this.method_6(type_);
							JsonConverter jsonConverter = this.method_13(jsonContract_, null, null, jsonProperty_0);
							object value;
							if (jsonConverter != null && jsonConverter.CanRead)
							{
								value = this.method_39(jsonConverter, jsonReader_0, type_, null);
							}
							else
							{
								value = this.method_11(jsonReader_0, type_, jsonContract_, null, null, jsonProperty_0, null);
							}
							jsonDynamicContract_0.TrySetMember(dynamicMetaObjectProvider, text, value);
						}
						goto IL_1D9;
					}
					catch (Exception exception_)
					{
						if (!base.method_4(dynamicMetaObjectProvider, jsonDynamicContract_0, text, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, exception_))
						{
							throw;
						}
						this.method_48(jsonReader_0, true, depth);
						goto IL_1D9;
					}
				}
				IL_1C3:
				if (!jsonReader_0.Read())
				{
					break;
				}
				continue;
				IL_1D9:
				if (!flag)
				{
					goto IL_1C3;
				}
				break;
			}
			goto IL_1FA;
			Block_8:
			throw JsonSerializationException.Create(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.TokenType);
			IL_1FA:
			if (!flag)
			{
				this.method_33(jsonReader_0, jsonDynamicContract_0, dynamicMetaObjectProvider, "Unexpected end when deserializing object.");
			}
			this.method_30(jsonReader_0, jsonDynamicContract_0, dynamicMetaObjectProvider);
			return dynamicMetaObjectProvider;
		}
		throw JsonSerializationException.Create(jsonReader_0, "Unable to find a default constructor to use for type {0}.".smethod_0(CultureInfo.InvariantCulture, jsonDynamicContract_0.UnderlyingType));
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x000358A0 File Offset: 0x00033AA0
	private object method_38(JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, ObjectConstructor<object> objectConstructor_0, string string_0)
	{
		Class101.smethod_0(objectConstructor_0, "creator");
		bool flag = jsonObjectContract_0.method_9() || this.method_25(this.jsonSerializer_0.defaultValueHandling_0, DefaultValueHandling.Populate);
		Type underlyingType = jsonObjectContract_0.UnderlyingType;
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			string object_ = string.Join(", ", jsonObjectContract_0.CreatorParameters.Select(new Func<JsonProperty, string>(Class118.Class123.class123_0.method_0)));
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Deserializing {0} using creator with parameters: {1}.".smethod_1(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType, object_)), null);
		}
		List<Class118.Class121> list = this.method_40(jsonObjectContract_0, jsonProperty_0, jsonReader_0, underlyingType);
		if (flag)
		{
			using (IEnumerator<JsonProperty> enumerator = jsonObjectContract_0.Properties.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class118.Class122 @class = new Class118.Class122();
					@class.jsonProperty_0 = enumerator.Current;
					if (!@class.jsonProperty_0.Ignored && list.All(new Func<Class118.Class121, bool>(@class.method_0)))
					{
						list.Add(new Class118.Class121
						{
							jsonProperty_0 = @class.jsonProperty_0,
							string_0 = @class.jsonProperty_0.PropertyName,
							nullable_0 = new Class118.Enum9?((Class118.Enum9)0)
						});
					}
				}
			}
		}
		object[] array = new object[jsonObjectContract_0.CreatorParameters.Count];
		foreach (Class118.Class121 class2 in list)
		{
			if (flag && class2.jsonProperty_0 != null && class2.nullable_0 == null)
			{
				object object_2 = class2.object_0;
				Class118.Enum9 value;
				string string_;
				if (object_2 == null)
				{
					value = (Class118.Enum9)1;
				}
				else if ((string_ = (object_2 as string)) != null)
				{
					value = (Class118.smethod_0(class2.jsonProperty_0.PropertyType, class2.jsonProperty_0.method_0(), string_) ? ((Class118.Enum9)1) : ((Class118.Enum9)2));
				}
				else
				{
					value = (Class118.Enum9)2;
				}
				class2.nullable_0 = new Class118.Enum9?(value);
			}
			JsonProperty jsonProperty = class2.jsonProperty_1;
			if (jsonProperty == null && class2.jsonProperty_0 != null)
			{
				jsonProperty = jsonObjectContract_0.CreatorParameters.smethod_8(new Func<JsonProperty, string>(Class118.Class123.class123_0.method_1), class2.jsonProperty_0.UnderlyingName);
			}
			if (jsonProperty != null && !jsonProperty.Ignored)
			{
				if (flag)
				{
					Class118.Enum9? nullable_ = class2.nullable_0;
					if (!(nullable_.GetValueOrDefault() == (Class118.Enum9)0 & nullable_ != null))
					{
						nullable_ = class2.nullable_0;
						if (!(nullable_.GetValueOrDefault() == (Class118.Enum9)1 & nullable_ != null))
						{
							goto IL_2FB;
						}
					}
					if (jsonProperty.method_0() == null)
					{
						jsonProperty.method_1(this.method_6(jsonProperty.PropertyType));
					}
					if (this.method_25(jsonProperty.DefaultValueHandling.GetValueOrDefault(this.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Populate))
					{
						class2.object_0 = this.method_21(jsonReader_0, jsonProperty.method_2(), CultureInfo.InvariantCulture, jsonProperty.method_0(), jsonProperty.PropertyType);
					}
				}
				IL_2FB:
				int num = jsonObjectContract_0.CreatorParameters.IndexOf(jsonProperty);
				array[num] = class2.object_0;
				class2.bool_0 = true;
			}
		}
		object obj = objectConstructor_0(array);
		if (string_0 != null)
		{
			this.method_24(jsonReader_0, string_0, obj);
		}
		this.method_29(jsonReader_0, jsonObjectContract_0, obj);
		foreach (Class118.Class121 class3 in list)
		{
			if (!class3.bool_0 && class3.jsonProperty_0 != null && !class3.jsonProperty_0.Ignored)
			{
				Class118.Enum9? nullable_ = class3.nullable_0;
				if (!(nullable_.GetValueOrDefault() == (Class118.Enum9)0 & nullable_ != null))
				{
					JsonProperty jsonProperty_ = class3.jsonProperty_0;
					object object_3 = class3.object_0;
					if (this.method_26(jsonProperty_, jsonObjectContract_0, object_3))
					{
						jsonProperty_.ValueProvider.SetValue(obj, object_3);
						class3.bool_0 = true;
					}
					else if (!jsonProperty_.Writable && object_3 != null)
					{
						JsonContract jsonContract = this.jsonSerializer_0.icontractResolver_0.ResolveContract(jsonProperty_.PropertyType);
						if (jsonContract.enum8_0 != (Enum8)2)
						{
							goto IL_4E6;
						}
						JsonArrayContract jsonArrayContract = (JsonArrayContract)jsonContract;
						if (jsonArrayContract.method_8() && !jsonArrayContract.bool_3)
						{
							object value2 = jsonProperty_.ValueProvider.GetValue(obj);
							if (value2 != null)
							{
								IList list2;
								if (!jsonArrayContract.method_7())
								{
									list2 = (IList)value2;
								}
								else
								{
									IList list3 = jsonArrayContract.mRrtQkaEd1(value2);
									list2 = list3;
								}
								IList list4 = list2;
								IEnumerable enumerable;
								if (!jsonArrayContract.method_7())
								{
									enumerable = (IList)object_3;
								}
								else
								{
									IList list3 = jsonArrayContract.mRrtQkaEd1(object_3);
									enumerable = list3;
								}
								using (IEnumerator enumerator3 = enumerable.GetEnumerator())
								{
									while (enumerator3.MoveNext())
									{
										object value3 = enumerator3.Current;
										list4.Add(value3);
									}
									goto IL_5A5;
								}
								goto IL_4E6;
							}
						}
						IL_5A5:
						class3.bool_0 = true;
						continue;
						IL_4E6:
						if (jsonContract.enum8_0 != (Enum8)5)
						{
							goto IL_5A5;
						}
						JsonDictionaryContract jsonDictionaryContract = (JsonDictionaryContract)jsonContract;
						if (jsonDictionaryContract.bool_3)
						{
							goto IL_5A5;
						}
						object value4 = jsonProperty_.ValueProvider.GetValue(obj);
						if (value4 != null)
						{
							IDictionary dictionary;
							if (!jsonDictionaryContract.method_9())
							{
								dictionary = (IDictionary)value4;
							}
							else
							{
								IDictionary dictionary2 = jsonDictionaryContract.method_12(value4);
								dictionary = dictionary2;
							}
							IDictionary dictionary3 = dictionary;
							IDictionary dictionary4;
							if (!jsonDictionaryContract.method_9())
							{
								dictionary4 = (IDictionary)object_3;
							}
							else
							{
								IDictionary dictionary2 = jsonDictionaryContract.method_12(object_3);
								dictionary4 = dictionary2;
							}
							using (IDictionaryEnumerator enumerator4 = dictionary4.GetEnumerator())
							{
								while (enumerator4.MoveNext())
								{
									DictionaryEntry entry = enumerator4.Entry;
									dictionary3[entry.Key] = entry.Value;
								}
							}
							goto IL_5A5;
						}
						goto IL_5A5;
					}
				}
			}
		}
		if (jsonObjectContract_0.ExtensionDataSetter != null)
		{
			foreach (Class118.Class121 class4 in list)
			{
				if (!class4.bool_0)
				{
					Class118.Enum9? nullable_ = class4.nullable_0;
					if (!(nullable_.GetValueOrDefault() == (Class118.Enum9)0 & nullable_ != null))
					{
						jsonObjectContract_0.ExtensionDataSetter(obj, class4.string_0, class4.object_0);
					}
				}
			}
		}
		if (flag)
		{
			foreach (Class118.Class121 class5 in list)
			{
				if (class5.jsonProperty_0 != null)
				{
					this.method_47(obj, jsonReader_0, jsonObjectContract_0, jsonReader_0.Depth, class5.jsonProperty_0, class5.nullable_0.GetValueOrDefault(), !class5.bool_0);
				}
			}
		}
		this.method_30(jsonReader_0, jsonObjectContract_0, obj);
		return obj;
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00036004 File Offset: 0x00034204
	private object method_39(JsonConverter jsonConverter_0, JsonReader jsonReader_0, Type type_0, object object_0)
	{
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Started deserializing {0} with converter {1}.".smethod_1(CultureInfo.InvariantCulture, type_0, jsonConverter_0.GetType())), null);
		}
		object result = jsonConverter_0.ReadJson(jsonReader_0, type_0, object_0, this.method_8());
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Info)
		{
			this.itraceWriter_0.Trace(TraceLevel.Info, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Finished deserializing {0} with converter {1}.".smethod_1(CultureInfo.InvariantCulture, type_0, jsonConverter_0.GetType())), null);
		}
		return result;
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x000360B8 File Offset: 0x000342B8
	private List<Class118.Class121> method_40(JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, JsonReader jsonReader_0, Type type_0)
	{
		List<Class118.Class121> list = new List<Class118.Class121>();
		bool flag = false;
		string text;
		for (;;)
		{
			JsonToken tokenType = jsonReader_0.TokenType;
			if (tokenType != JsonToken.PropertyName)
			{
				if (tokenType != JsonToken.Comment)
				{
					if (tokenType != JsonToken.EndObject)
					{
						goto Block_17;
					}
					flag = true;
				}
			}
			else
			{
				text = jsonReader_0.Value.ToString();
				Class118.Class121 @class = new Class118.Class121
				{
					string_0 = text,
					jsonProperty_1 = jsonObjectContract_0.CreatorParameters.GetClosestMatchProperty(text),
					jsonProperty_0 = jsonObjectContract_0.Properties.GetClosestMatchProperty(text)
				};
				list.Add(@class);
				JsonProperty jsonProperty = @class.jsonProperty_1 ?? @class.jsonProperty_0;
				if (jsonProperty != null && !jsonProperty.Ignored)
				{
					if (jsonProperty.method_0() == null)
					{
						jsonProperty.method_1(this.method_6(jsonProperty.PropertyType));
					}
					JsonConverter jsonConverter = this.method_13(jsonProperty.method_0(), jsonProperty.Converter, jsonObjectContract_0, jsonProperty_0);
					if (!jsonReader_0.method_27(jsonProperty.method_0(), jsonConverter != null))
					{
						goto IL_206;
					}
					if (jsonConverter != null && jsonConverter.CanRead)
					{
						@class.object_0 = this.method_39(jsonConverter, jsonReader_0, jsonProperty.PropertyType, null);
					}
					else
					{
						@class.object_0 = this.method_11(jsonReader_0, jsonProperty.PropertyType, jsonProperty.method_0(), jsonProperty, jsonObjectContract_0, jsonProperty_0, null);
					}
				}
				else
				{
					if (!jsonReader_0.Read())
					{
						goto IL_21D;
					}
					if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
					{
						this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Could not find member '{0}' on {1}.".smethod_1(CultureInfo.InvariantCulture, text, jsonObjectContract_0.UnderlyingType)), null);
					}
					if ((jsonObjectContract_0.MissingMemberHandling ?? this.jsonSerializer_0.missingMemberHandling_0) == MissingMemberHandling.Error)
					{
						break;
					}
					if (jsonObjectContract_0.ExtensionDataSetter != null)
					{
						@class.object_0 = this.method_46(jsonObjectContract_0, jsonProperty_0, jsonReader_0);
					}
					else
					{
						jsonReader_0.Skip();
					}
				}
			}
			if (flag)
			{
				goto IL_252;
			}
			if (!jsonReader_0.Read())
			{
				goto Block_15;
			}
		}
		throw JsonSerializationException.Create(jsonReader_0, "Could not find member '{0}' on object of type '{1}'".smethod_1(CultureInfo.InvariantCulture, text, type_0.Name));
		Block_15:
		goto IL_252;
		Block_17:
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.TokenType);
		IL_206:
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, text));
		IL_21D:
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, text));
		IL_252:
		if (!flag)
		{
			this.method_33(jsonReader_0, jsonObjectContract_0, null, "Unexpected end when deserializing object.");
		}
		return list;
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x0003632C File Offset: 0x0003452C
	public object method_41(JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, JsonProperty jsonProperty_1, string string_0, out bool bool_0)
	{
		object obj = null;
		if (jsonObjectContract_0.OverrideCreator != null)
		{
			if (jsonObjectContract_0.CreatorParameters.Count > 0)
			{
				bool_0 = true;
				return this.method_38(jsonReader_0, jsonObjectContract_0, jsonProperty_0, jsonObjectContract_0.OverrideCreator, string_0);
			}
			obj = jsonObjectContract_0.OverrideCreator(Class20.smethod_17<object>());
		}
		else if (jsonObjectContract_0.DefaultCreator != null && (!jsonObjectContract_0.DefaultCreatorNonPublic || this.jsonSerializer_0.constructorHandling_0 == ConstructorHandling.AllowNonPublicDefaultConstructor || jsonObjectContract_0.method_7() == null))
		{
			obj = jsonObjectContract_0.DefaultCreator();
		}
		else if (jsonObjectContract_0.method_7() != null)
		{
			bool_0 = true;
			return this.method_38(jsonReader_0, jsonObjectContract_0, jsonProperty_0, jsonObjectContract_0.method_7(), string_0);
		}
		if (obj != null)
		{
			bool_0 = false;
			return obj;
		}
		if (!jsonObjectContract_0.bool_5)
		{
			throw JsonSerializationException.Create(jsonReader_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_0(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType));
		}
		throw JsonSerializationException.Create(jsonReader_0, "Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute.".smethod_0(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType));
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00036414 File Offset: 0x00034614
	private object method_42(object object_0, JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, string string_0)
	{
		this.method_29(jsonReader_0, jsonObjectContract_0, object_0);
		Dictionary<JsonProperty, Class118.Enum9> dictionary;
		if (!jsonObjectContract_0.method_9() && !this.method_25(this.jsonSerializer_0.defaultValueHandling_0, DefaultValueHandling.Populate))
		{
			dictionary = null;
		}
		else
		{
			dictionary = jsonObjectContract_0.Properties.ToDictionary(new Func<JsonProperty, JsonProperty>(Class118.Class123.class123_0.method_2), new Func<JsonProperty, Class118.Enum9>(Class118.Class123.class123_0.method_3));
		}
		Dictionary<JsonProperty, Class118.Enum9> dictionary2 = dictionary;
		if (string_0 != null)
		{
			this.method_24(jsonReader_0, string_0, object_0);
		}
		int depth = jsonReader_0.Depth;
		bool flag = false;
		for (;;)
		{
			JsonToken tokenType = jsonReader_0.TokenType;
			if (tokenType != JsonToken.PropertyName)
			{
				if (tokenType == JsonToken.Comment)
				{
					goto IL_28F;
				}
				if (tokenType != JsonToken.EndObject)
				{
					goto Block_10;
				}
				flag = true;
				goto IL_28F;
			}
			else
			{
				string text = jsonReader_0.Value.ToString();
				if (this.method_44(jsonReader_0, text))
				{
					goto IL_28F;
				}
				try
				{
					JsonProperty closestMatchProperty = jsonObjectContract_0.Properties.GetClosestMatchProperty(text);
					if (closestMatchProperty != null)
					{
						if (!closestMatchProperty.Ignored && this.method_43(jsonReader_0, closestMatchProperty, object_0))
						{
							if (closestMatchProperty.method_0() == null)
							{
								closestMatchProperty.method_1(this.method_6(closestMatchProperty.PropertyType));
							}
							JsonConverter jsonConverter = this.method_13(closestMatchProperty.method_0(), closestMatchProperty.Converter, jsonObjectContract_0, jsonProperty_0);
							if (!jsonReader_0.method_27(closestMatchProperty.method_0(), jsonConverter != null))
							{
								throw JsonSerializationException.Create(jsonReader_0, "Unexpected end when setting {0}'s value.".smethod_0(CultureInfo.InvariantCulture, text));
							}
							this.DaqOahUqCy(jsonReader_0, closestMatchProperty, dictionary2);
							if (!this.method_22(closestMatchProperty, jsonConverter, jsonObjectContract_0, jsonProperty_0, jsonReader_0, object_0))
							{
								this.method_45(jsonObjectContract_0, jsonProperty_0, jsonReader_0, text, object_0);
							}
						}
						else if (jsonReader_0.Read())
						{
							this.DaqOahUqCy(jsonReader_0, closestMatchProperty, dictionary2);
							this.method_45(jsonObjectContract_0, jsonProperty_0, jsonReader_0, text, object_0);
						}
						goto IL_28F;
					}
					if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
					{
						this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, "Could not find member '{0}' on {1}".smethod_1(CultureInfo.InvariantCulture, text, jsonObjectContract_0.UnderlyingType)), null);
					}
					if ((jsonObjectContract_0.MissingMemberHandling ?? this.jsonSerializer_0.missingMemberHandling_0) == MissingMemberHandling.Error)
					{
						throw JsonSerializationException.Create(jsonReader_0, "Could not find member '{0}' on object of type '{1}'".smethod_1(CultureInfo.InvariantCulture, text, jsonObjectContract_0.UnderlyingType.Name));
					}
					if (!jsonReader_0.Read())
					{
						goto IL_28F;
					}
					this.method_45(jsonObjectContract_0, jsonProperty_0, jsonReader_0, text, object_0);
					goto IL_28F;
				}
				catch (Exception exception_)
				{
					if (!base.method_4(object_0, jsonObjectContract_0, text, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, exception_))
					{
						throw;
					}
					this.method_48(jsonReader_0, true, depth);
					goto IL_28F;
				}
			}
			IL_275:
			if (!jsonReader_0.Read())
			{
				break;
			}
			continue;
			IL_28F:
			if (!flag)
			{
				goto IL_275;
			}
			break;
		}
		goto IL_2B0;
		Block_10:
		throw JsonSerializationException.Create(jsonReader_0, "Unexpected token when deserializing object: " + jsonReader_0.TokenType);
		IL_2B0:
		if (!flag)
		{
			this.method_33(jsonReader_0, jsonObjectContract_0, object_0, "Unexpected end when deserializing object.");
		}
		if (dictionary2 != null)
		{
			foreach (KeyValuePair<JsonProperty, Class118.Enum9> keyValuePair in dictionary2)
			{
				JsonProperty key = keyValuePair.Key;
				Class118.Enum9 value = keyValuePair.Value;
				this.method_47(object_0, jsonReader_0, jsonObjectContract_0, depth, key, value, true);
			}
		}
		this.method_30(jsonReader_0, jsonObjectContract_0, object_0);
		return object_0;
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00036774 File Offset: 0x00034974
	private bool method_43(JsonReader jsonReader_0, JsonProperty jsonProperty_0, object object_0)
	{
		if (jsonProperty_0.ShouldDeserialize == null)
		{
			return true;
		}
		bool flag = jsonProperty_0.ShouldDeserialize(object_0);
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Verbose)
		{
			this.itraceWriter_0.Trace(TraceLevel.Verbose, Struct0.smethod_1(null, jsonReader_0.Path, "ShouldDeserialize result for property '{0}' on {1}: {2}".smethod_2(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName, jsonProperty_0.DeclaringType, flag)), null);
		}
		return flag;
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x000367EC File Offset: 0x000349EC
	private bool method_44(JsonReader jsonReader_0, string string_0)
	{
		if (this.jsonSerializer_0.MetadataPropertyHandling == MetadataPropertyHandling.ReadAhead && (string_0 == "$id" || string_0 == "$ref" || string_0 == "$type" || string_0 == "$values"))
		{
			jsonReader_0.Skip();
			return true;
		}
		return false;
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00036844 File Offset: 0x00034A44
	private void method_45(JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, JsonReader jsonReader_0, string string_0, object object_0)
	{
		if (jsonObjectContract_0.ExtensionDataSetter != null)
		{
			try
			{
				object value = this.method_46(jsonObjectContract_0, jsonProperty_0, jsonReader_0);
				jsonObjectContract_0.ExtensionDataSetter(object_0, string_0, value);
				return;
			}
			catch (Exception ex)
			{
				throw JsonSerializationException.Create(jsonReader_0, "Error setting value in extension data for type '{0}'.".smethod_0(CultureInfo.InvariantCulture, jsonObjectContract_0.UnderlyingType), ex);
			}
		}
		jsonReader_0.Skip();
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x000368AC File Offset: 0x00034AAC
	private object method_46(JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0, JsonReader jsonReader_0)
	{
		object result;
		if (jsonObjectContract_0.bool_7)
		{
			result = JToken.ReadFrom(jsonReader_0);
		}
		else
		{
			result = this.method_11(jsonReader_0, null, null, null, jsonObjectContract_0, jsonProperty_0, null);
		}
		return result;
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x000368DC File Offset: 0x00034ADC
	private void method_47(object object_0, JsonReader jsonReader_0, JsonObjectContract jsonObjectContract_0, int int_0, JsonProperty jsonProperty_0, Class118.Enum9 enum9_0, bool bool_0)
	{
		if (enum9_0 == (Class118.Enum9)0 || enum9_0 == (Class118.Enum9)1)
		{
			try
			{
				Required required = jsonProperty_0.Ignored ? Required.Default : (jsonProperty_0.nullable_0 ?? (jsonObjectContract_0.ItemRequired ?? Required.Default));
				if (enum9_0 == (Class118.Enum9)0)
				{
					if (required != Required.AllowNull)
					{
						if (required != Required.Always)
						{
							if (!bool_0 || jsonProperty_0.Ignored)
							{
								goto IL_15A;
							}
							if (jsonProperty_0.method_0() == null)
							{
								jsonProperty_0.method_1(this.method_6(jsonProperty_0.PropertyType));
							}
							if (this.method_25(jsonProperty_0.DefaultValueHandling.GetValueOrDefault(this.jsonSerializer_0.defaultValueHandling_0), DefaultValueHandling.Populate) && jsonProperty_0.Writable)
							{
								jsonProperty_0.ValueProvider.SetValue(object_0, this.method_21(jsonReader_0, jsonProperty_0.method_2(), CultureInfo.InvariantCulture, jsonProperty_0.method_0(), jsonProperty_0.PropertyType));
								goto IL_15A;
							}
							goto IL_15A;
						}
					}
					throw JsonSerializationException.Create(jsonReader_0, "Required property '{0}' not found in JSON.".smethod_0(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName));
				}
				if (enum9_0 == (Class118.Enum9)1)
				{
					if (required == Required.Always)
					{
						throw JsonSerializationException.Create(jsonReader_0, "Required property '{0}' expects a value but got null.".smethod_0(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName));
					}
					if (required == Required.DisallowNull)
					{
						throw JsonSerializationException.Create(jsonReader_0, "Required property '{0}' expects a non-null value.".smethod_0(CultureInfo.InvariantCulture, jsonProperty_0.PropertyName));
					}
				}
				IL_15A:;
			}
			catch (Exception exception_)
			{
				if (!base.method_4(object_0, jsonObjectContract_0, jsonProperty_0.PropertyName, jsonReader_0 as IJsonLineInfo, jsonReader_0.Path, exception_))
				{
					throw;
				}
				this.method_48(jsonReader_0, true, int_0);
			}
		}
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00036A90 File Offset: 0x00034C90
	private void DaqOahUqCy(JsonReader jsonReader_0, JsonProperty jsonProperty_0, Dictionary<JsonProperty, Class118.Enum9> dictionary_0)
	{
		if (jsonProperty_0 != null && dictionary_0 != null)
		{
			JsonToken tokenType = jsonReader_0.TokenType;
			Class118.Enum9 value;
			if (tokenType != JsonToken.String)
			{
				if (tokenType - JsonToken.Null > 1)
				{
					value = (Class118.Enum9)2;
				}
				else
				{
					value = (Class118.Enum9)1;
				}
			}
			else
			{
				value = (Class118.smethod_0(jsonProperty_0.PropertyType, jsonProperty_0.method_0(), (string)jsonReader_0.Value) ? ((Class118.Enum9)1) : ((Class118.Enum9)2));
			}
			dictionary_0[jsonProperty_0] = value;
		}
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x0000901D File Offset: 0x0000721D
	private void method_48(JsonReader jsonReader_0, bool bool_0, int int_0)
	{
		base.method_3();
		if (bool_0)
		{
			jsonReader_0.Skip();
			while (jsonReader_0.Depth > int_0 && jsonReader_0.Read())
			{
			}
		}
	}

	// Token: 0x02000138 RID: 312
	internal enum Enum9
	{

	}

	// Token: 0x02000139 RID: 313
	internal class Class121
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x00002621 File Offset: 0x00000821
		public Class121()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x04000550 RID: 1360
		public string string_0;

		// Token: 0x04000551 RID: 1361
		public JsonProperty jsonProperty_0;

		// Token: 0x04000552 RID: 1362
		public JsonProperty jsonProperty_1;

		// Token: 0x04000553 RID: 1363
		public Class118.Enum9? nullable_0;

		// Token: 0x04000554 RID: 1364
		public object object_0;

		// Token: 0x04000555 RID: 1365
		public bool bool_0;
	}

	// Token: 0x0200013A RID: 314
	[CompilerGenerated]
	private sealed class Class122
	{
		// Token: 0x0600097F RID: 2431 RVA: 0x00002621 File Offset: 0x00000821
		public Class122()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00009041 File Offset: 0x00007241
		internal bool method_0(Class118.Class121 class121_0)
		{
			return class121_0.jsonProperty_0 != this.jsonProperty_0;
		}

		// Token: 0x04000556 RID: 1366
		public JsonProperty jsonProperty_0;
	}

	// Token: 0x0200013B RID: 315
	[CompilerGenerated]
	[Serializable]
	private sealed class Class123
	{
		// Token: 0x06000981 RID: 2433 RVA: 0x00009054 File Offset: 0x00007254
		// Note: this type is marked as 'beforefieldinit'.
		static Class123()
		{
			Class202.ofdixO4zTbIfy();
			Class118.Class123.class123_0 = new Class118.Class123();
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00002621 File Offset: 0x00000821
		public Class123()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00008EAD File Offset: 0x000070AD
		internal string method_0(JsonProperty jsonProperty_0)
		{
			return jsonProperty_0.PropertyName;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00008EAD File Offset: 0x000070AD
		internal string method_1(JsonProperty jsonProperty_0)
		{
			return jsonProperty_0.PropertyName;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000055AD File Offset: 0x000037AD
		internal JsonProperty method_2(JsonProperty jsonProperty_0)
		{
			return jsonProperty_0;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000055B0 File Offset: 0x000037B0
		internal Class118.Enum9 method_3(JsonProperty jsonProperty_0)
		{
			return (Class118.Enum9)0;
		}

		// Token: 0x04000557 RID: 1367
		public static readonly Class118.Class123 class123_0;

		// Token: 0x04000558 RID: 1368
		public static Func<JsonProperty, string> func_0;

		// Token: 0x04000559 RID: 1369
		public static Func<JsonProperty, string> func_1;

		// Token: 0x0400055A RID: 1370
		public static Func<JsonProperty, JsonProperty> func_2;

		// Token: 0x0400055B RID: 1371
		public static Func<JsonProperty, Class118.Enum9> func_3;
	}
}
