using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

// Token: 0x02000135 RID: 309
internal abstract class Class117
{
	// Token: 0x06000946 RID: 2374 RVA: 0x00008ED1 File Offset: 0x000070D1
	protected Class117(JsonSerializer jsonSerializer_1)
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
		Class101.smethod_0(jsonSerializer_1, "serializer");
		this.jsonSerializer_0 = jsonSerializer_1;
		this.itraceWriter_0 = jsonSerializer_1.TraceWriter;
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00008EFC File Offset: 0x000070FC
	internal Class19<string, object> method_0()
	{
		if (this.class19_0 == null)
		{
			this.class19_0 = new Class19<string, object>(EqualityComparer<string>.Default, new Class117.Class120(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'. This error may be caused by an object being reused multiple times during deserialization and can be fixed with the setting ObjectCreationHandling.Replace.");
		}
		return this.class19_0;
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x000330D0 File Offset: 0x000312D0
	protected NullValueHandling method_1(JsonObjectContract jsonObjectContract_0, JsonProperty jsonProperty_0)
	{
		NullValueHandling? nullValueHandling = jsonProperty_0.NullValueHandling;
		if (nullValueHandling != null)
		{
			return nullValueHandling.GetValueOrDefault();
		}
		NullValueHandling? nullValueHandling2 = (jsonObjectContract_0 != null) ? jsonObjectContract_0.ItemNullValueHandling : null;
		if (nullValueHandling2 == null)
		{
			return this.jsonSerializer_0.nullValueHandling_0;
		}
		return nullValueHandling2.GetValueOrDefault();
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00008F2B File Offset: 0x0000712B
	private ErrorContext method_2(object object_0, object object_1, string string_0, Exception exception_0)
	{
		if (this.errorContext_0 == null)
		{
			this.errorContext_0 = new ErrorContext(object_0, object_1, string_0, exception_0);
		}
		if (this.errorContext_0.Error != exception_0)
		{
			throw new InvalidOperationException("Current error context error is different to requested error.");
		}
		return this.errorContext_0;
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00008F65 File Offset: 0x00007165
	protected void method_3()
	{
		if (this.errorContext_0 == null)
		{
			throw new InvalidOperationException("Could not clear error context. Error context is already null.");
		}
		this.errorContext_0 = null;
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00033128 File Offset: 0x00031328
	protected bool method_4(object object_0, JsonContract jsonContract_0, object object_1, IJsonLineInfo ijsonLineInfo_0, string string_0, Exception exception_0)
	{
		ErrorContext errorContext = this.method_2(object_0, object_1, string_0, exception_0);
		if (this.itraceWriter_0 != null && this.itraceWriter_0.LevelFilter >= TraceLevel.Error && !errorContext.method_0())
		{
			errorContext.method_1(true);
			string text = (base.GetType() == typeof(Class119)) ? "Error serializing" : "Error deserializing";
			if (jsonContract_0 != null)
			{
				text = text + " " + jsonContract_0.UnderlyingType;
			}
			text = text + ". " + exception_0.Message;
			if (!(exception_0 is JsonException))
			{
				text = Struct0.smethod_1(ijsonLineInfo_0, string_0, text);
			}
			this.itraceWriter_0.Trace(TraceLevel.Error, text, exception_0);
		}
		if (jsonContract_0 != null && object_0 != null)
		{
			jsonContract_0.method_4(object_0, this.jsonSerializer_0.Context, errorContext);
		}
		if (!errorContext.Handled)
		{
			this.jsonSerializer_0.method_6(new ErrorEventArgs(object_0, errorContext));
		}
		return errorContext.Handled;
	}

	// Token: 0x0400054A RID: 1354
	private ErrorContext errorContext_0;

	// Token: 0x0400054B RID: 1355
	private Class19<string, object> class19_0;

	// Token: 0x0400054C RID: 1356
	internal readonly JsonSerializer jsonSerializer_0;

	// Token: 0x0400054D RID: 1357
	internal readonly ITraceWriter itraceWriter_0;

	// Token: 0x0400054E RID: 1358
	protected Class9 class9_0;

	// Token: 0x02000136 RID: 310
	private class Class120 : IEqualityComparer<object>
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x00008F81 File Offset: 0x00007181
		bool IEqualityComparer<object>.Equals(object x, object y)
		{
			return x == y;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00008F87 File Offset: 0x00007187
		int IEqualityComparer<object>.GetHashCode(object obj)
		{
			return RuntimeHelpers.GetHashCode(obj);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002621 File Offset: 0x00000821
		public Class120()
		{
			Class202.ofdixO4zTbIfy();
			base..ctor();
		}
	}
}
