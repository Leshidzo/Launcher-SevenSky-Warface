using System;
using System.IO;
using System.Net;
using HttpDownload;

// Token: 0x02000010 RID: 16
internal class Class4
{
	// Token: 0x06000047 RID: 71 RVA: 0x00010904 File Offset: 0x0000EB04
	public static HttpWebRequest smethod_0(string string_0)
	{
		HttpWebRequest httpWebRequest = WebRequest.Create(string_0) as HttpWebRequest;
		httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
		httpWebRequest.Accept = "*/*";
		httpWebRequest.KeepAlive = false;
		httpWebRequest.ReadWriteTimeout = 500000;
		httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";
		httpWebRequest.AllowAutoRedirect = true;
		httpWebRequest.ProtocolVersion = HttpVersion.Version10;
		ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
		ServicePointManager.Expect100Continue = true;
		return httpWebRequest;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00010978 File Offset: 0x0000EB78
	public static void smethod_1(string string_0, ref long long_0, ref bool bool_0)
	{
		HttpWebRequest httpWebRequest = Class4.smethod_0(string_0);
		using (HttpWebResponse response = httpWebRequest.GetResponse2())
		{
			long_0 = response.ContentLength;
		}
		httpWebRequest.Abort();
		httpWebRequest = Class4.smethod_0(string_0);
		httpWebRequest.AddRange(0L, long_0 / 2L);
		using (HttpWebResponse response2 = httpWebRequest.GetResponse2())
		{
			bool_0 = (response2.ContentLength == long_0 / 2L + 1L);
			response2.Close();
		}
		httpWebRequest.Abort();
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00010A2C File Offset: 0x0000EC2C
	public static FileStream smethod_2(string string_0, bool bool_0)
	{
		FileStream result;
		if (bool_0)
		{
			if (File.Exists(string_0))
			{
				result = new FileStream(string_0, FileMode.Append, FileAccess.Write);
			}
			else
			{
				result = null;
			}
		}
		else if (File.Exists(string_0))
		{
			result = new FileStream(string_0, FileMode.Truncate, FileAccess.ReadWrite);
		}
		else
		{
			result = new FileStream(string_0, FileMode.Create, FileAccess.Write);
		}
		return result;
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00010A70 File Offset: 0x0000EC70
	public static int smethod_3(long long_0, double double_0)
	{
		return (int)((double)long_0 / double_0);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00010A84 File Offset: 0x0000EC84
	public static double tyBdCtExbY(long long_0, long long_1)
	{
		return double.Parse(((double)long_0 * 100.0 / (double)long_1).ToString("0.00"));
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002621 File Offset: 0x00000821
	public Class4()
	{
		Class202.ofdixO4zTbIfy();
		base..ctor();
	}
}
