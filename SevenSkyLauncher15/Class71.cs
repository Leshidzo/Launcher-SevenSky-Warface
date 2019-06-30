using System;
using Newtonsoft.Json;

// Token: 0x020000E2 RID: 226
internal static class Class71
{
	// Token: 0x060006F9 RID: 1785 RVA: 0x0000773C File Offset: 0x0000593C
	internal static bool smethod_0(JsonToken jsonToken_0)
	{
		return jsonToken_0 - JsonToken.EndObject <= 2;
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00007748 File Offset: 0x00005948
	internal static bool smethod_1(JsonToken jsonToken_0)
	{
		return jsonToken_0 - JsonToken.StartObject <= 2;
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00007753 File Offset: 0x00005953
	internal static bool smethod_2(JsonToken jsonToken_0)
	{
		return jsonToken_0 - JsonToken.Integer <= 5 || jsonToken_0 - JsonToken.Date <= 1;
	}
}
