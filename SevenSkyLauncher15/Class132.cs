using System;
using System.Collections.Generic;
using Newtonsoft.Json.Schema;

// Token: 0x02000152 RID: 338
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal static class Class132
{
	// Token: 0x06000AEE RID: 2798 RVA: 0x0003A060 File Offset: 0x00038260
	// Note: this type is marked as 'beforefieldinit'.
	static Class132()
	{
		Class202.ofdixO4zTbIfy();
		Class132.idictionary_0 = new Dictionary<string, JsonSchemaType>
		{
			{
				"string",
				JsonSchemaType.String
			},
			{
				"object",
				JsonSchemaType.Object
			},
			{
				"integer",
				JsonSchemaType.Integer
			},
			{
				"number",
				JsonSchemaType.Float
			},
			{
				"null",
				JsonSchemaType.Null
			},
			{
				"boolean",
				JsonSchemaType.Boolean
			},
			{
				"array",
				JsonSchemaType.Array
			},
			{
				"any",
				JsonSchemaType.Any
			}
		};
	}

	// Token: 0x040005A7 RID: 1447
	public static readonly IDictionary<string, JsonSchemaType> idictionary_0;
}
