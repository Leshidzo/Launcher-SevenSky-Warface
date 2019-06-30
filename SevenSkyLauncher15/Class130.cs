using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

// Token: 0x02000150 RID: 336
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class Class130
{
	// Token: 0x06000ADA RID: 2778 RVA: 0x0000A407 File Offset: 0x00008607
	public Class130(JsonSchemaResolver jsonSchemaResolver_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.ilist_0 = new List<JsonSchema>();
		this.idictionary_0 = new Dictionary<string, JsonSchema>();
		this.jsonSchemaResolver_0 = jsonSchemaResolver_1;
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x0000A431 File Offset: 0x00008631
	private void method_0(JsonSchema jsonSchema_1)
	{
		this.jsonSchema_0 = jsonSchema_1;
		this.ilist_0.Add(jsonSchema_1);
		this.jsonSchemaResolver_0.LoadedSchemas.Add(jsonSchema_1);
		this.idictionary_0.Add(jsonSchema_1.Location, jsonSchema_1);
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x0000A469 File Offset: 0x00008669
	private JsonSchema method_1()
	{
		JsonSchema result = this.jsonSchema_0;
		this.ilist_0.RemoveAt(this.ilist_0.Count - 1);
		this.jsonSchema_0 = this.ilist_0.LastOrDefault<JsonSchema>();
		return result;
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x0000A49A File Offset: 0x0000869A
	private JsonSchema method_2()
	{
		return this.jsonSchema_0;
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00039168 File Offset: 0x00037368
	internal JsonSchema method_3(JsonReader jsonReader_0)
	{
		JToken jtoken = JToken.ReadFrom(jsonReader_0);
		this.jobject_0 = (jtoken as JObject);
		JsonSchema jsonSchema = this.method_6(jtoken);
		this.method_5(jsonSchema);
		return jsonSchema;
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x0000A4A2 File Offset: 0x000086A2
	private string method_4(string string_0)
	{
		return Uri.UnescapeDataString(string_0).Replace("~1", "/").Replace("~0", "~");
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0003919C File Offset: 0x0003739C
	private JsonSchema method_5(JsonSchema jsonSchema_1)
	{
		if (jsonSchema_1.method_1() != null)
		{
			string text = jsonSchema_1.method_1();
			bool flag;
			if (flag = text.StartsWith("#", StringComparison.Ordinal))
			{
				text = this.method_4(text);
			}
			JsonSchema jsonSchema = this.jsonSchemaResolver_0.GetSchema(text);
			if (jsonSchema == null)
			{
				if (flag)
				{
					string[] array = jsonSchema_1.method_1().TrimStart(new char[]
					{
						'#'
					}).Split(new char[]
					{
						'/'
					}, StringSplitOptions.RemoveEmptyEntries);
					JToken jtoken = this.jobject_0;
					foreach (string string_ in array)
					{
						string text2 = this.method_4(string_);
						if (jtoken.Type == JTokenType.Object)
						{
							jtoken = jtoken[text2];
						}
						else if (jtoken.Type == JTokenType.Array || jtoken.Type == JTokenType.Constructor)
						{
							int num;
							if (int.TryParse(text2, out num) && num >= 0 && num < jtoken.Count<JToken>())
							{
								jtoken = jtoken[num];
							}
							else
							{
								jtoken = null;
							}
						}
						if (jtoken == null)
						{
							break;
						}
					}
					if (jtoken != null)
					{
						jsonSchema = this.method_6(jtoken);
					}
				}
				if (jsonSchema == null)
				{
					throw new JsonException("Could not resolve schema reference '{0}'.".smethod_0(CultureInfo.InvariantCulture, jsonSchema_1.method_1()));
				}
			}
			jsonSchema_1 = jsonSchema;
		}
		if (jsonSchema_1.method_3())
		{
			return jsonSchema_1;
		}
		jsonSchema_1.method_4(true);
		if (jsonSchema_1.Extends != null)
		{
			for (int j = 0; j < jsonSchema_1.Extends.Count; j++)
			{
				jsonSchema_1.Extends[j] = this.method_5(jsonSchema_1.Extends[j]);
			}
		}
		if (jsonSchema_1.Items != null)
		{
			for (int k = 0; k < jsonSchema_1.Items.Count; k++)
			{
				jsonSchema_1.Items[k] = this.method_5(jsonSchema_1.Items[k]);
			}
		}
		if (jsonSchema_1.AdditionalItems != null)
		{
			jsonSchema_1.AdditionalItems = this.method_5(jsonSchema_1.AdditionalItems);
		}
		if (jsonSchema_1.PatternProperties != null)
		{
			foreach (KeyValuePair<string, JsonSchema> keyValuePair in jsonSchema_1.PatternProperties.ToList<KeyValuePair<string, JsonSchema>>())
			{
				jsonSchema_1.PatternProperties[keyValuePair.Key] = this.method_5(keyValuePair.Value);
			}
		}
		if (jsonSchema_1.Properties != null)
		{
			foreach (KeyValuePair<string, JsonSchema> keyValuePair2 in jsonSchema_1.Properties.ToList<KeyValuePair<string, JsonSchema>>())
			{
				jsonSchema_1.Properties[keyValuePair2.Key] = this.method_5(keyValuePair2.Value);
			}
		}
		if (jsonSchema_1.AdditionalProperties != null)
		{
			jsonSchema_1.AdditionalProperties = this.method_5(jsonSchema_1.AdditionalProperties);
		}
		return jsonSchema_1;
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00039464 File Offset: 0x00037664
	private JsonSchema method_6(JToken jtoken_0)
	{
		JObject jobject;
		if ((jobject = (jtoken_0 as JObject)) == null)
		{
			throw JsonException.Create(jtoken_0, jtoken_0.Path, "Expected object while parsing schema object, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
		}
		JToken value;
		if (jobject.TryGetValue("$ref", out value))
		{
			JsonSchema jsonSchema = new JsonSchema();
			jsonSchema.method_2((string)value);
			return jsonSchema;
		}
		string text = jtoken_0.Path.Replace(".", "/").Replace("[", "/").Replace("]", string.Empty);
		if (!string.IsNullOrEmpty(text))
		{
			text = "/" + text;
		}
		text = "#" + text;
		JsonSchema result;
		if (this.idictionary_0.TryGetValue(text, out result))
		{
			return result;
		}
		this.method_0(new JsonSchema
		{
			Location = text
		});
		this.method_7(jobject);
		return this.method_1();
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x00039548 File Offset: 0x00037748
	private void method_7(JObject jobject_1)
	{
		foreach (KeyValuePair<string, JToken> keyValuePair in jobject_1)
		{
			string key = keyValuePair.Key;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(key);
			if (num <= 2223801888u)
			{
				if (num <= 981021583u)
				{
					if (num <= 353304077u)
					{
						if (num != 299789532u)
						{
							if (num != 334560121u)
							{
								if (num == 353304077u)
								{
									if (key == "divisibleBy")
									{
										this.method_2().DivisibleBy = new double?((double)keyValuePair.Value);
									}
								}
							}
							else if (key == "minItems")
							{
								this.method_2().MinimumItems = new int?((int)keyValuePair.Value);
							}
						}
						else if (key == "properties")
						{
							this.method_2().Properties = this.method_12(keyValuePair.Value);
						}
					}
					else if (num <= 879704937u)
					{
						if (num != 479998177u)
						{
							if (num == 879704937u)
							{
								if (key == "description")
								{
									this.method_2().Description = (string)keyValuePair.Value;
								}
							}
						}
						else if (key == "additionalProperties")
						{
							this.method_10(keyValuePair.Value);
						}
					}
					else if (num != 926444256u)
					{
						if (num == 981021583u)
						{
							if (key == "items")
							{
								this.method_13(keyValuePair.Value);
							}
						}
					}
					else if (key == "id")
					{
						this.method_2().Id = (string)keyValuePair.Value;
					}
				}
				else if (num <= 1693958795u)
				{
					if (num != 1361572173u)
					{
						if (num != 1542649473u)
						{
							if (num == 1693958795u)
							{
								if (key == "exclusiveMaximum")
								{
									this.method_2().ExclusiveMaximum = new bool?((bool)keyValuePair.Value);
								}
							}
						}
						else if (key == "maximum")
						{
							this.method_2().Maximum = new double?((double)keyValuePair.Value);
						}
					}
					else if (key == "type")
					{
						this.method_2().Type = this.method_14(keyValuePair.Value);
					}
				}
				else if (num <= 2051482624u)
				{
					if (num != 1913005517u)
					{
						if (num == 2051482624u)
						{
							if (key == "additionalItems")
							{
								this.method_11(keyValuePair.Value);
							}
						}
					}
					else if (key == "exclusiveMinimum")
					{
						this.method_2().ExclusiveMinimum = new bool?((bool)keyValuePair.Value);
					}
				}
				else if (num != 2171383808u)
				{
					if (num == 2223801888u)
					{
						if (key == "required")
						{
							this.method_2().Required = new bool?((bool)keyValuePair.Value);
						}
					}
				}
				else if (key == "enum")
				{
					this.method_9(keyValuePair.Value);
				}
			}
			else if (num <= 2692244416u)
			{
				if (num <= 2474713847u)
				{
					if (num != 2268922153u)
					{
						if (num != 2470140894u)
						{
							if (num == 2474713847u)
							{
								if (key == "minimum")
								{
									this.method_2().Minimum = new double?((double)keyValuePair.Value);
								}
							}
						}
						else if (key == "default")
						{
							this.method_2().Default = keyValuePair.Value.DeepClone();
						}
					}
					else if (key == "pattern")
					{
						this.method_2().Pattern = (string)keyValuePair.Value;
					}
				}
				else if (num <= 2609687125u)
				{
					if (num != 2556802313u)
					{
						if (num == 2609687125u)
						{
							if (key == "requires")
							{
								this.method_2().Requires = (string)keyValuePair.Value;
							}
						}
					}
					else if (key == "title")
					{
						this.method_2().Title = (string)keyValuePair.Value;
					}
				}
				else if (num != 2642794062u)
				{
					if (num == 2692244416u)
					{
						if (key == "disallow")
						{
							this.method_2().Disallow = this.method_14(keyValuePair.Value);
						}
					}
				}
				else if (key == "extends")
				{
					this.method_8(keyValuePair.Value);
				}
			}
			else if (num <= 3522602594u)
			{
				if (num <= 3114108242u)
				{
					if (num != 2957261815u)
					{
						if (num == 3114108242u)
						{
							if (key == "format")
							{
								this.method_2().Format = (string)keyValuePair.Value;
							}
						}
					}
					else if (key == "minLength")
					{
						this.method_2().MinimumLength = new int?((int)keyValuePair.Value);
					}
				}
				else if (num != 3456888823u)
				{
					if (num == 3522602594u)
					{
						if (key == "uniqueItems")
						{
							this.method_2().UniqueItems = (bool)keyValuePair.Value;
						}
					}
				}
				else if (key == "readonly")
				{
					this.method_2().ReadOnly = new bool?((bool)keyValuePair.Value);
				}
			}
			else if (num <= 3947606640u)
			{
				if (num != 3526559937u)
				{
					if (num == 3947606640u)
					{
						if (key == "patternProperties")
						{
							this.method_2().PatternProperties = this.method_12(keyValuePair.Value);
						}
					}
				}
				else if (key == "maxLength")
				{
					this.method_2().MaximumLength = new int?((int)keyValuePair.Value);
				}
			}
			else if (num != 4128829753u)
			{
				if (num == 4244322099u)
				{
					if (key == "maxItems")
					{
						this.method_2().MaximumItems = new int?((int)keyValuePair.Value);
					}
				}
			}
			else if (key == "hidden")
			{
				this.method_2().Hidden = new bool?((bool)keyValuePair.Value);
			}
		}
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x00039C44 File Offset: 0x00037E44
	private void method_8(JToken jtoken_0)
	{
		IList<JsonSchema> list = new List<JsonSchema>();
		if (jtoken_0.Type == JTokenType.Array)
		{
			using (IEnumerator<JToken> enumerator = ((IEnumerable<JToken>)jtoken_0).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					JToken jtoken_ = enumerator.Current;
					list.Add(this.method_6(jtoken_));
				}
				goto IL_53;
			}
		}
		JsonSchema jsonSchema = this.method_6(jtoken_0);
		if (jsonSchema != null)
		{
			list.Add(jsonSchema);
		}
		IL_53:
		if (list.Count > 0)
		{
			this.method_2().Extends = list;
		}
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x00039CCC File Offset: 0x00037ECC
	private void method_9(JToken jtoken_0)
	{
		if (jtoken_0.Type != JTokenType.Array)
		{
			throw JsonException.Create(jtoken_0, jtoken_0.Path, "Expected Array token while parsing enum values, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
		}
		this.method_2().Enum = new List<JToken>();
		foreach (JToken jtoken in ((IEnumerable<JToken>)jtoken_0))
		{
			this.method_2().Enum.Add(jtoken.DeepClone());
		}
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x0000A4C8 File Offset: 0x000086C8
	private void method_10(JToken jtoken_0)
	{
		if (jtoken_0.Type == JTokenType.Boolean)
		{
			this.method_2().AllowAdditionalProperties = (bool)jtoken_0;
			return;
		}
		this.method_2().AdditionalProperties = this.method_6(jtoken_0);
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x0000A4F8 File Offset: 0x000086F8
	private void method_11(JToken jtoken_0)
	{
		if (jtoken_0.Type == JTokenType.Boolean)
		{
			this.method_2().AllowAdditionalItems = (bool)jtoken_0;
			return;
		}
		this.method_2().AdditionalItems = this.method_6(jtoken_0);
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00039D64 File Offset: 0x00037F64
	private IDictionary<string, JsonSchema> method_12(JToken jtoken_0)
	{
		IDictionary<string, JsonSchema> dictionary = new Dictionary<string, JsonSchema>();
		if (jtoken_0.Type != JTokenType.Object)
		{
			throw JsonException.Create(jtoken_0, jtoken_0.Path, "Expected Object token while parsing schema properties, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
		}
		foreach (JToken jtoken in ((IEnumerable<JToken>)jtoken_0))
		{
			JProperty jproperty = (JProperty)jtoken;
			if (dictionary.ContainsKey(jproperty.Name))
			{
				throw new JsonException("Property {0} has already been defined in schema.".smethod_0(CultureInfo.InvariantCulture, jproperty.Name));
			}
			dictionary.Add(jproperty.Name, this.method_6(jproperty.Value));
		}
		return dictionary;
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00039E28 File Offset: 0x00038028
	private void method_13(JToken jtoken_0)
	{
		this.method_2().Items = new List<JsonSchema>();
		JTokenType type = jtoken_0.Type;
		if (type == JTokenType.Object)
		{
			this.method_2().Items.Add(this.method_6(jtoken_0));
			this.method_2().PositionalItemsValidation = false;
			return;
		}
		if (type != JTokenType.Array)
		{
			throw JsonException.Create(jtoken_0, jtoken_0.Path, "Expected array or JSON schema object, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
		}
		this.method_2().PositionalItemsValidation = true;
		foreach (JToken jtoken_ in ((IEnumerable<JToken>)jtoken_0))
		{
			this.method_2().Items.Add(this.method_6(jtoken_));
		}
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x00039EF8 File Offset: 0x000380F8
	private JsonSchemaType? method_14(JToken jtoken_0)
	{
		JTokenType type = jtoken_0.Type;
		if (type == JTokenType.Array)
		{
			JsonSchemaType? jsonSchemaType = new JsonSchemaType?(JsonSchemaType.None);
			foreach (JToken jtoken in ((IEnumerable<JToken>)jtoken_0))
			{
				if (jtoken.Type != JTokenType.String)
				{
					throw JsonException.Create(jtoken, jtoken.Path, "Expected JSON schema type string token, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
				}
				jsonSchemaType |= Class130.smethod_0((string)jtoken);
			}
			return jsonSchemaType;
		}
		if (type != JTokenType.String)
		{
			throw JsonException.Create(jtoken_0, jtoken_0.Path, "Expected array or JSON schema type string token, got {0}.".smethod_0(CultureInfo.InvariantCulture, jtoken_0.Type));
		}
		return new JsonSchemaType?(Class130.smethod_0((string)jtoken_0));
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00039FF4 File Offset: 0x000381F4
	internal static JsonSchemaType smethod_0(object object_0)
	{
		JsonSchemaType result;
		if (!Class132.idictionary_0.TryGetValue(object_0, out result))
		{
			throw new JsonException("Invalid JSON schema type: {0}".smethod_0(CultureInfo.InvariantCulture, object_0));
		}
		return result;
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x0003A028 File Offset: 0x00038228
	internal static string smethod_1(JsonSchemaType jsonSchemaType_0)
	{
		Class130.Class131 @class = new Class130.Class131();
		@class.jsonSchemaType_0 = jsonSchemaType_0;
		return Class132.idictionary_0.Single(new Func<KeyValuePair<string, JsonSchemaType>, bool>(@class.method_0)).Key;
	}

	// Token: 0x040005A1 RID: 1441
	private readonly IList<JsonSchema> ilist_0;

	// Token: 0x040005A2 RID: 1442
	private readonly JsonSchemaResolver jsonSchemaResolver_0;

	// Token: 0x040005A3 RID: 1443
	private readonly IDictionary<string, JsonSchema> idictionary_0;

	// Token: 0x040005A4 RID: 1444
	private JsonSchema jsonSchema_0;

	// Token: 0x040005A5 RID: 1445
	private JObject jobject_0;

	// Token: 0x02000151 RID: 337
	[CompilerGenerated]
	private sealed class Class131
	{
		// Token: 0x06000AEC RID: 2796 RVA: 0x00002621 File Offset: 0x00000821
		public Class131()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0000A528 File Offset: 0x00008728
		internal bool method_0(KeyValuePair<string, JsonSchemaType> keyValuePair_0)
		{
			return keyValuePair_0.Value == this.jsonSchemaType_0;
		}

		// Token: 0x040005A6 RID: 1446
		public JsonSchemaType jsonSchemaType_0;
	}
}
