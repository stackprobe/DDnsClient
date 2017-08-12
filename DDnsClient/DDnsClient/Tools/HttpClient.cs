﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Charlotte.Tools
{
	public class HttpClient
	{
		private HttpWebRequest Hwr;

		public HttpClient(string url)
		{
			Hwr = (HttpWebRequest)HttpWebRequest.Create(url);
			Hwr.Timeout = 20000;
		}

		public int ResBodySizeMax = 20000000; // 20 MB

		public void SetVersion(string version)
		{
			switch (version)
			{
				case HttpRequest.HTTP_10:
					Hwr.ProtocolVersion = HttpVersion.Version10;
					break;

				case HttpRequest.HTTP_11:
					Hwr.ProtocolVersion = HttpVersion.Version11;
					break;

				default:
					throw null;
			}
		}

		public void SetContentType(string contentType)
		{
			Hwr.ContentType = contentType;
		}

		public void AddHeader(string name, string value)
		{
			if (StringTools.IsSame(name, "User-Agent", true))
			{
				Hwr.UserAgent = value;
				return;
			}
			Hwr.Headers.Add(name, value);
		}

		public void SetProxyNone()
		{
			Hwr.Proxy = null;
		}

		public void SetProxy(string host, int port)
		{
			Hwr.Proxy = new WebProxy(host, port);
		}

		public void SetIEProxy()
		{
			Hwr.Proxy = WebRequest.GetSystemWebProxy();
		}

		public void Head()
		{
			Send(null, "HEAD");
		}

		public void Get()
		{
			Send(null);
		}

		public void Post(byte[] body)
		{
			Send(body);
		}

		public void Send(byte[] body)
		{
			Send(body, body == null ? "GET" : "POST");
		}

		public void Send(byte[] body, string method)
		{
			Hwr.Method = method;

			if (body != null)
			{
				using (Stream w = Hwr.GetRequestStream())
				{
					w.Write(body, 0, body.Length);
				}
			}
			WebResponse res = Hwr.GetResponse();
			ResHeaders = DictionaryTools.CreateIgnoreCase<string>();

			foreach (string name in res.Headers.Keys)
				ResHeaders.Add(name, res.Headers[name]);

			using (Stream r = res.GetResponseStream())
			{
				ResBody = FileTools.ReadToEnd(r, this.ResBodySizeMax);
			}
		}

		private Dictionary<string, string> ResHeaders;
		private byte[] ResBody;

		public Dictionary<string, string> GetResHeaders()
		{
			return ResHeaders;
		}

		public byte[] GetResBody()
		{
			return ResBody;
		}
	}
}
