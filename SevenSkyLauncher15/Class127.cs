using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;

// Token: 0x02000148 RID: 328
internal class Class127 : GInterface2
{
	// Token: 0x06000A2B RID: 2603 RVA: 0x00009728 File Offset: 0x00007928
	public Class127(SerializationBinder serializationBinder_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		this.serializationBinder_0 = serializationBinder_1;
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x0000973C File Offset: 0x0000793C
	public Type BindToType(string assemblyName, string typeName)
	{
		return this.serializationBinder_0.BindToType(assemblyName, typeName);
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x0000974B File Offset: 0x0000794B
	public void BindToName(Type serializedType, out string assemblyName, out string typeName)
	{
		this.serializationBinder_0.BindToName(serializedType, out assemblyName, out typeName);
	}

	// Token: 0x04000573 RID: 1395
	public readonly SerializationBinder serializationBinder_0;
}
