using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

// Token: 0x0200015F RID: 351
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class Class141
{
	// Token: 0x06000B66 RID: 2918 RVA: 0x0000A9BE File Offset: 0x00008BBE
	public Class141(JsonWriter jsonWriter_1, JsonSchemaResolver jsonSchemaResolver_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		Class101.smethod_0(jsonWriter_1, "writer");
		this.jsonWriter_0 = jsonWriter_1;
		this.jsonSchemaResolver_0 = jsonSchemaResolver_1;
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x0003B1AC File Offset: 0x000393AC
	private void method_0(JsonSchema jsonSchema_0)
	{
		if (jsonSchema_0.Id != null && this.jsonSchemaResolver_0.GetSchema(jsonSchema_0.Id) != null)
		{
			this.jsonWriter_0.WriteStartObject();
			this.jsonWriter_0.WritePropertyName("$ref");
			this.jsonWriter_0.WriteValue(jsonSchema_0.Id);
			this.jsonWriter_0.WriteEndObject();
			return;
		}
		this.method_1(jsonSchema_0);
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x0003B214 File Offset: 0x00039414
	public void method_1(JsonSchema jsonSchema_0)
	{
		Class101.smethod_0(jsonSchema_0, "schema");
		if (!this.jsonSchemaResolver_0.LoadedSchemas.Contains(jsonSchema_0))
		{
			this.jsonSchemaResolver_0.LoadedSchemas.Add(jsonSchema_0);
		}
		this.jsonWriter_0.WriteStartObject();
		this.method_5(this.jsonWriter_0, "id", jsonSchema_0.Id);
		this.method_5(this.jsonWriter_0, "title", jsonSchema_0.Title);
		this.method_5(this.jsonWriter_0, "description", jsonSchema_0.Description);
		this.method_5(this.jsonWriter_0, "required", jsonSchema_0.Required);
		this.method_5(this.jsonWriter_0, "readonly", jsonSchema_0.ReadOnly);
		this.method_5(this.jsonWriter_0, "hidden", jsonSchema_0.Hidden);
		this.method_5(this.jsonWriter_0, "transient", jsonSchema_0.Transient);
		if (jsonSchema_0.Type != null)
		{
			this.method_4("type", this.jsonWriter_0, jsonSchema_0.Type.GetValueOrDefault());
		}
		if (!jsonSchema_0.AllowAdditionalProperties)
		{
			this.jsonWriter_0.WritePropertyName("additionalProperties");
			this.jsonWriter_0.WriteValue(jsonSchema_0.AllowAdditionalProperties);
		}
		else if (jsonSchema_0.AdditionalProperties != null)
		{
			this.jsonWriter_0.WritePropertyName("additionalProperties");
			this.method_0(jsonSchema_0.AdditionalProperties);
		}
		if (!jsonSchema_0.AllowAdditionalItems)
		{
			this.jsonWriter_0.WritePropertyName("additionalItems");
			this.jsonWriter_0.WriteValue(jsonSchema_0.AllowAdditionalItems);
		}
		else if (jsonSchema_0.AdditionalItems != null)
		{
			this.jsonWriter_0.WritePropertyName("additionalItems");
			this.method_0(jsonSchema_0.AdditionalItems);
		}
		this.method_2(this.jsonWriter_0, "properties", jsonSchema_0.Properties);
		this.method_2(this.jsonWriter_0, "patternProperties", jsonSchema_0.PatternProperties);
		this.method_3(jsonSchema_0);
		this.method_5(this.jsonWriter_0, "minimum", jsonSchema_0.Minimum);
		this.method_5(this.jsonWriter_0, "maximum", jsonSchema_0.Maximum);
		this.method_5(this.jsonWriter_0, "exclusiveMinimum", jsonSchema_0.ExclusiveMinimum);
		this.method_5(this.jsonWriter_0, "exclusiveMaximum", jsonSchema_0.ExclusiveMaximum);
		this.method_5(this.jsonWriter_0, "minLength", jsonSchema_0.MinimumLength);
		this.method_5(this.jsonWriter_0, "maxLength", jsonSchema_0.MaximumLength);
		this.method_5(this.jsonWriter_0, "minItems", jsonSchema_0.MinimumItems);
		this.method_5(this.jsonWriter_0, "maxItems", jsonSchema_0.MaximumItems);
		this.method_5(this.jsonWriter_0, "divisibleBy", jsonSchema_0.DivisibleBy);
		this.method_5(this.jsonWriter_0, "format", jsonSchema_0.Format);
		this.method_5(this.jsonWriter_0, "pattern", jsonSchema_0.Pattern);
		if (jsonSchema_0.Enum != null)
		{
			this.jsonWriter_0.WritePropertyName("enum");
			this.jsonWriter_0.WriteStartArray();
			foreach (JToken jtoken in jsonSchema_0.Enum)
			{
				jtoken.WriteTo(this.jsonWriter_0, new JsonConverter[0]);
			}
			this.jsonWriter_0.WriteEndArray();
		}
		if (jsonSchema_0.Default != null)
		{
			this.jsonWriter_0.WritePropertyName("default");
			jsonSchema_0.Default.WriteTo(this.jsonWriter_0, new JsonConverter[0]);
		}
		if (jsonSchema_0.Disallow != null)
		{
			this.method_4("disallow", this.jsonWriter_0, jsonSchema_0.Disallow.GetValueOrDefault());
		}
		if (jsonSchema_0.Extends != null && jsonSchema_0.Extends.Count > 0)
		{
			this.jsonWriter_0.WritePropertyName("extends");
			if (jsonSchema_0.Extends.Count == 1)
			{
				this.method_0(jsonSchema_0.Extends[0]);
			}
			else
			{
				this.jsonWriter_0.WriteStartArray();
				foreach (JsonSchema jsonSchema_ in jsonSchema_0.Extends)
				{
					this.method_0(jsonSchema_);
				}
				this.jsonWriter_0.WriteEndArray();
			}
		}
		this.jsonWriter_0.WriteEndObject();
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x0003B6BC File Offset: 0x000398BC
	private void method_2(JsonWriter jsonWriter_1, string string_0, IDictionary<string, JsonSchema> idictionary_0)
	{
		if (idictionary_0 != null)
		{
			jsonWriter_1.WritePropertyName(string_0);
			jsonWriter_1.WriteStartObject();
			foreach (KeyValuePair<string, JsonSchema> keyValuePair in idictionary_0)
			{
				jsonWriter_1.WritePropertyName(keyValuePair.Key);
				this.method_0(keyValuePair.Value);
			}
			jsonWriter_1.WriteEndObject();
		}
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x0003B730 File Offset: 0x00039930
	private void method_3(JsonSchema jsonSchema_0)
	{
		if (jsonSchema_0.Items == null && !jsonSchema_0.PositionalItemsValidation)
		{
			return;
		}
		this.jsonWriter_0.WritePropertyName("items");
		if (jsonSchema_0.PositionalItemsValidation)
		{
			this.jsonWriter_0.WriteStartArray();
			if (jsonSchema_0.Items != null)
			{
				foreach (JsonSchema jsonSchema_ in jsonSchema_0.Items)
				{
					this.method_0(jsonSchema_);
				}
			}
			this.jsonWriter_0.WriteEndArray();
			return;
		}
		if (jsonSchema_0.Items != null && jsonSchema_0.Items.Count > 0)
		{
			this.method_0(jsonSchema_0.Items[0]);
			return;
		}
		this.jsonWriter_0.WriteStartObject();
		this.jsonWriter_0.WriteEndObject();
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x0003B808 File Offset: 0x00039A08
	private void method_4(string string_0, JsonWriter jsonWriter_1, JsonSchemaType jsonSchemaType_0)
	{
		if (Enum.IsDefined(typeof(JsonSchemaType), jsonSchemaType_0))
		{
			jsonWriter_1.WritePropertyName(string_0);
			jsonWriter_1.WriteValue(Class130.smethod_1(jsonSchemaType_0));
			return;
		}
		IEnumerator<JsonSchemaType> enumerator = Class53.smethod_1<JsonSchemaType>(jsonSchemaType_0).Where(new Func<JsonSchemaType, bool>(Class141.Class142.class142_0.method_0)).GetEnumerator();
		if (enumerator.MoveNext())
		{
			jsonWriter_1.WritePropertyName(string_0);
			JsonSchemaType jsonSchemaType_ = enumerator.Current;
			if (enumerator.MoveNext())
			{
				jsonWriter_1.WriteStartArray();
				jsonWriter_1.WriteValue(Class130.smethod_1(jsonSchemaType_));
				do
				{
					jsonWriter_1.WriteValue(Class130.smethod_1(enumerator.Current));
				}
				while (enumerator.MoveNext());
				jsonWriter_1.WriteEndArray();
				return;
			}
			jsonWriter_1.WriteValue(Class130.smethod_1(jsonSchemaType_));
		}
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x0000A9E4 File Offset: 0x00008BE4
	private void method_5(JsonWriter jsonWriter_1, string string_0, object object_0)
	{
		if (object_0 != null)
		{
			jsonWriter_1.WritePropertyName(string_0);
			jsonWriter_1.WriteValue(object_0);
		}
	}

	// Token: 0x040005E3 RID: 1507
	private readonly JsonWriter jsonWriter_0;

	// Token: 0x040005E4 RID: 1508
	private readonly JsonSchemaResolver jsonSchemaResolver_0;

	// Token: 0x02000160 RID: 352
	[CompilerGenerated]
	[Serializable]
	private sealed class Class142
	{
		// Token: 0x06000B6D RID: 2925 RVA: 0x0000A9F7 File Offset: 0x00008BF7
		// Note: this type is marked as 'beforefieldinit'.
		static Class142()
		{
			Class202.ofdixO4zTbIfy();
			Class141.Class142.class142_0 = new Class141.Class142();
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00002621 File Offset: 0x00000821
		public Class142()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0000AA08 File Offset: 0x00008C08
		internal bool method_0(JsonSchemaType jsonSchemaType_0)
		{
			return jsonSchemaType_0 > JsonSchemaType.None;
		}

		// Token: 0x040005E5 RID: 1509
		public static readonly Class141.Class142 class142_0;

		// Token: 0x040005E6 RID: 1510
		public static Func<JsonSchemaType, bool> func_0;
	}
}
