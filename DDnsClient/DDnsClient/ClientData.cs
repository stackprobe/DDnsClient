using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Charlotte.Tools;

namespace Charlotte
{
	public class ClientData
	{
		private Gnd.ClientInfo _info;

		public ClientData(Gnd.ClientInfo info)
		{
			_info = info;
		}

		public bool Flag失敗 = false;
		public List<object> LastReport = new List<object>();

		public void Perform()
		{
			this.Flag失敗 = false;
			this.LastReport.Clear();

			TimeData startedTime = TimeData.Now();

			//Logger.WriteLog("----");
			Logger.WriteLog("開始日時: " + startedTime);

			try
			{
				Logger.WriteLog("Method: " + _info.Method);
				Logger.WriteLog("URL: " + _info.Url);
				Logger.WriteLog("Version: " + _info.Version);
				Logger.WriteLog("Request Headers {");

				foreach (string[] headerField in _info.HeaderFields)
					Logger.WriteLog(
						headerField[0] +
						": " +
						StringTools.ConvCRLF(headerField[1], "(改行)"),
						1
						);

				Logger.WriteLog("}");
				Logger.WriteLog("Request Body Length: " + _info.Body.Length);
				Logger.WriteLog("Request Body Encoding: " + Gnd.ClientInfo.Encodings[(int)_info.BodyEncoding].EncodingName);
				Logger.WriteLog("リクエスト開始...");

				if (_info.Url.StartsWith("https://"))
				{
					Logger.WriteLog("https://～ mode");

					HttpClient hc = new HttpClient(_info.Url);

					switch (_info.Version)
					{
						case Gnd.ClientInfo.Version_e.HTTP_10:
							hc.SetVersion(HttpRequest.HTTP_10);
							break;

						case Gnd.ClientInfo.Version_e.HTTP_11:
							hc.SetVersion(HttpRequest.HTTP_11);
							break;

						default:
							throw null;
					}
					foreach (string[] headerField in _info.HeaderFields)
						hc.AddHeader(headerField[0], headerField[1]);

					switch (Gnd.ProxyMode)
					{
						case Gnd.ProxyMode_e.Direct:
							hc.SetProxyNone();
							break;

						case Gnd.ProxyMode_e.IE:
							hc.SetIEProxy();
							break;

						case Gnd.ProxyMode_e.Special:
							hc.SetProxy(Gnd.ProxyHost, Gnd.ProxyPort);
							break;

						default:
							throw null;
					}
					switch (_info.Method)
					{
						case Gnd.ClientInfo.Method_e.HEAD:
							hc.Head();
							break;

						case Gnd.ClientInfo.Method_e.GET:
							hc.Get();
							break;

						case Gnd.ClientInfo.Method_e.POST:
							hc.Post(Gnd.ClientInfo.Encodings[(int)_info.BodyEncoding].GetBytes(_info.Body));
							break;

						default:
							throw null;
					}
					Logger.WriteLog("リクエスト完了！");
					Logger.WriteLog("Response Headers {");

					foreach (string headerKey in hc.GetResHeaders().Keys)
						Logger.WriteLog(
							headerKey +
							": " +
							StringTools.ConvCRLF(hc.GetResHeaders()[headerKey], "(改行)"),
							1
							);

					Logger.WriteLog("}");
					Logger.WriteLog("Response Body Size: " + hc.GetResBody().Length);
					Logger.WriteLog("Response Body Encoding: " + Gnd.ClientInfo.Encodings[(int)_info.ResBodyEncoding].EncodingName);
					Logger.WriteLog("Response Body ...");
					Logger.WriteLog("====");
					Logger.WriteLog(ResBodyToResMessage(hc.GetResBody(), Gnd.ClientInfo.Encodings[(int)_info.ResBodyEncoding]));
					Logger.WriteLog("====");

					if (_info.Method == Gnd.ClientInfo.Method_e.HEAD)
						LastReport.Add("HEADリクエストであるため、データは受信しません。");

					LastReport.Add(hc.GetResBody());
				}
				else // ? http://～
				{
					Logger.WriteLog("http://～ mode");

					HttpRequest hReq = new HttpRequest(_info.Url);

					switch (_info.Version)
					{
						case Gnd.ClientInfo.Version_e.HTTP_10:
							hReq.SetVersion(HttpRequest.HTTP_10);
							break;

						case Gnd.ClientInfo.Version_e.HTTP_11:
							hReq.SetVersion(HttpRequest.HTTP_11);
							break;

						default:
							throw null;
					}
					foreach (string[] headerField in _info.HeaderFields)
						hReq.SetHeaderField(headerField[0], headerField[1]);

					switch (Gnd.ProxyMode)
					{
						case Gnd.ProxyMode_e.Direct:
							break;

						case Gnd.ProxyMode_e.IE:
							hReq.SetIEProxy();
							break;

						case Gnd.ProxyMode_e.Special:
							hReq.SetProxy(Gnd.ProxyHost, Gnd.ProxyPort);
							break;

						default:
							throw null;
					}
					HttpResponse hRes;

					switch (_info.Method)
					{
						case Gnd.ClientInfo.Method_e.HEAD:
							hRes = hReq.Head();
							break;

						case Gnd.ClientInfo.Method_e.GET:
							hRes = hReq.Get();
							break;

						case Gnd.ClientInfo.Method_e.POST:
							hRes = hReq.Post(Gnd.ClientInfo.Encodings[(int)_info.BodyEncoding].GetBytes(_info.Body));
							break;

						default:
							throw null;
					}
					Logger.WriteLog("リクエスト完了！");
					Logger.WriteLog("HTTP Status Code: " + hRes.GetStatus());
					Logger.WriteLog("Reason Phrase: " + hRes.GetReasonPhrase());
					Logger.WriteLog("Version: " + hRes.GetHTTPVersion());
					Logger.WriteLog("Response Headers {");

					foreach (string headerKey in hRes.GetHeaderFields().Keys)
						Logger.WriteLog(
							headerKey +
							": " +
							StringTools.ConvCRLF(hRes.GetHeaderFields()[headerKey], "(改行)"),
							1
							);

					Logger.WriteLog("}");

					if (_info.Method == Gnd.ClientInfo.Method_e.HEAD)
					{
						Logger.WriteLog("No Response Body");

						LastReport.Add("HEADリクエストであるため、データは受信しません。");
					}
					else
					{
						Logger.WriteLog("Response Body Size: " + hRes.GetBody().Length);
						Logger.WriteLog("Response Body Encoding: " + Gnd.ClientInfo.Encodings[(int)_info.ResBodyEncoding].EncodingName);
						Logger.WriteLog("Response Message ...");
						Logger.WriteLog("====");
						Logger.WriteLog(ResBodyToResMessage(hRes.GetBody(), Gnd.ClientInfo.Encodings[(int)_info.ResBodyEncoding]));
						Logger.WriteLog("====");

						LastReport.Add(hRes.GetBody());
					}
					if (hRes.GetStatus() != 200)
						throw new Exception("ステータスコードが 200 ではありません。(" + hRes.GetStatus() + ")");
				}
			}
			catch (Exception e)
			{
				this.Flag失敗 = true;

				Logger.WriteLog("---- エラー ----");
				Logger.WriteLog(e.GetType().Name);
				Logger.WriteLog(e.Message);
				Logger.WriteLog(e.StackTrace);

				LastReport.Add("---- エラー ----");
				LastReport.Add(e.Message);
			}
			TimeData endedTime = TimeData.Now();

			Logger.WriteLog("終了日時: " + endedTime);
			Logger.WriteLog("処理時間: " + (endedTime.T - startedTime.T) + " [秒]");
			Logger.WriteLog("----");
		}

		public static string ResBodyToResMessage(byte[] body, Encoding encoding)
		{
			string sBody = encoding.GetString(body);
			int index;

			index = StringTools.IndexOfIgnoreCase(sBody, "<body>");

			if (index != -1)
				sBody = sBody.Substring(index);

#if true
			{
				StringBuilder buff = new StringBuilder();
				bool tagの中 = false;

				foreach (char chr in sBody)
				{
					if (tagの中)
					{
						if (chr == '>')
							tagの中 = false;
					}
					else
					{
						if (chr == '<')
							tagの中 = true;
						else
							buff.Append(chr);
					}
				}
				sBody = buff.ToString();
			}
#else // bottleneck
			for (; ; )
			{
				index = sBody.IndexOf('<');

				if (index == -1)
					break;

				int end = sBody.IndexOf('>', index + 1);

				if (end == -1)
					break;

				sBody = sBody.Substring(0, index) + sBody.Substring(end + 1);
			}
#endif
			return TTL(sBody);
		}

		private static string TTL(string text)
		{
			List<string> lines = new List<string>();

			foreach (string fLine in StringTools.Tokenize(text, "\r\n"))
			{
				string line = fLine;

				line = JString.ToJString(line, true, false, false, true, false);

				if (1000 < line.Length)
					line = line.Substring(0, 990) + " ...";

				if (line != "")
					lines.Add(line);

				if (1000 < lines.Count)
					break;
			}
			return string.Join("\n", lines);
		}

		public static string LastReportToText(List<object> report, Encoding encoding)
		{
			List<string> lines = new List<string>();

			foreach (object lineObj in report)
			{
				string line;

				if (lineObj is byte[])
					line = ResBodyToResMessage((byte[])lineObj, encoding);
				else
					line = lineObj.ToString();

				lines.Add(line);
			}
			return string.Join("\n", lines);
		}

		public class ClientDataTh
		{
			private ClientData _client;
			private Thread _th;

			public ClientDataTh(ClientData client)
			{
				_client = client;
				_th = new Thread(PerformTh);
				_th.Start();
			}

			private void PerformTh()
			{
				_client.Perform();
			}

			public bool End()
			{
				if (_th != null)
					if (_th.Join(0))
						_th = null;

				return _th != null;
			}
		}
	}
}
