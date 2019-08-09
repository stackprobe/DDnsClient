using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Charlotte.Tools;
using System.Drawing;

namespace Charlotte
{
	public static class Gnd
	{
		//               flags
		// -----------------------
		// ascii-token   0 0 0 0 0 
		// ascii-line    0 0 0 1 0
		// ascii-text    0 1 0 1 0
		// token         1 0 0 0 0
		// line          1 0 0 1 0
		// text          1 1 0 1 0
		// doc           1 1 1 1 1

		// コメントに上記がある場合、null 不可

		// 改行コード == "\n"

		public static int ClientInfoCountMax = 20; // 1 ～ IMAX
		public static int HeaderFieldCountMax = 20; // 1 ～ IMAX
		public static Color ColorOkCancel = Color.DarkBlue;
		public static Color Color行番号 = Color.LightCyan;
		public static int Count失敗Min_ChangeIcon = 3; // 1 ～ IMAX
		public static List<ClientInfo> ClientInfos = new List<ClientInfo>();

		public class ClientInfo
		{
			public Method_e Method = Method_e.GET;
			public string Url = "none"; // ascii-token 1 ～ 50000
			public Version_e Version = Version_e.HTTP_11;
			public List<string[]> HeaderFields = new List<string[]>(); // { ascii-token 1 ～ 300, ascii-text 1 ～ 50000 } ...
			public string Body = ""; // doc 0 ～ 50000
			public Encoding_e BodyEncoding = Encoding_e.UTF8;
			public Encoding_e ResBodyEncoding = Encoding_e.UTF8;
			public Period_e Period = Period_e.Minute_10;

			public enum Method_e
			{
				HEAD,
				GET,
				POST,
			}

			public enum Version_e
			{
				HTTP_10,
				HTTP_11,
			}

			public enum Encoding_e
			{
				Shift_JIS,
				EUC,
				UTF8,
				UTF16,
				UTF16_BE,
				UTF32,
			}

			public static Encoding[] Encodings = new Encoding[]
			{
				StringTools.ENCODING_SJIS,
				StringTools.ENCODING_EUC,
				Encoding.UTF8,
				Encoding.Unicode,
				Encoding.BigEndianUnicode,
				Encoding.UTF32,
			};

			public enum Period_e
			{
				Minute_3,
				Minute_5,
				Minute_7,
				Minute_10,
				Minute_20,
				Minute_30,
				Hour_1,
				Hour_2,
				Hour_3,
			}

			// status -->

			public TimeData Time最終更新 = null;
			public TimeData Time次回更新 = null;
			public int Count失敗 = 0;
		}

		public static ProxyMode_e ProxyMode = ProxyMode_e.IE;
		public static string ProxyHost = "none"; // ascii-token 1 ～ 300
		public static int ProxyPort = 8080; // 1 ～ 65535

		public enum ProxyMode_e
		{
			Direct,
			IE,
			Special,
		}

		public static void Init()
		{
			ConfFile = StringTools.Combine(BootTools.SelfDir, "DDnsClient.conf");
			SaveDataFile = StringTools.Combine(BootTools.SelfDir, "DDnsClient.dat");
			ErrorIcon = new Icon(GetErrorIconFile());
			NormalIcon = null; // init @ MainWin_Load()
		}

		private static string GetErrorIconFile()
		{
			string file = StringTools.Combine(BootTools.SelfDir, "ErrorIcon.dat");

			if (File.Exists(file) == false)
				file = @"..\..\dc16_error.ico"; // devenv

			return file;
		}

		public static string ConfFile;
		public static string SaveDataFile;
		public static Icon ErrorIcon;
		public static Icon NormalIcon;

		public static void LoadConf()
		{
			try
			{
				List<string> lines = new List<string>();

				foreach (string line in File.ReadAllLines(ConfFile, StringTools.ENCODING_SJIS))
					if (line != "" && line.StartsWith(";") == false)
						lines.Add(line);

				int c = 0;

				// ---- data ----

				ClientInfoCountMax = IntTools.ToInt(lines[c++], 1, IntTools.IMAX, 20);
				HeaderFieldCountMax = IntTools.ToInt(lines[c++], 1, IntTools.IMAX, 20);
				ColorOkCancel = ColorTools.FromRRGGBB(lines[c++]);
				Color行番号 = ColorTools.FromRRGGBB(lines[c++]);
				Count失敗Min_ChangeIcon = IntTools.ToInt(lines[c++], 1, IntTools.IMAX, 3);

				// ----
			}
			catch
			{ }
		}

		public static void LoadFromFile()
		{
			try
			{
				string[] lines = File.ReadAllLines(SaveDataFile, StringTools.ENCODING_SJIS);
				int c = 0;

				// ---- data ----

				int clientInfoCount = int.Parse(lines[c++]);

				for (int clientInfoIndex = 0; clientInfoIndex < clientInfoCount; clientInfoIndex++)
				{
					ClientInfo info = new ClientInfo();

					info.Method = (ClientInfo.Method_e)int.Parse(lines[c++]);
					info.Url = lines[c++];

					int headerFieldCount = int.Parse(lines[c++]);

					for (int headerFieldIndex = 0; headerFieldIndex < headerFieldCount; headerFieldIndex++)
					{
						string[] headerField = new string[2];

						headerField[0] = lines[c++]; // フィールド名
						headerField[1] = StringTools.LineToText(lines[c++]); // フィールド値(改行アリ)

						info.HeaderFields.Add(headerField);
					}
					info.Body = StringTools.LineToText(lines[c++]);
					info.BodyEncoding = (ClientInfo.Encoding_e)int.Parse(lines[c++]);
					info.ResBodyEncoding = (ClientInfo.Encoding_e)int.Parse(lines[c++]);
					info.Period = (ClientInfo.Period_e)int.Parse(lines[c++]);

					ClientInfos.Add(info);
				}

				ProxyMode = (ProxyMode_e)int.Parse(lines[c++]);
				ProxyHost = lines[c++];
				ProxyPort = int.Parse(lines[c++]);

				// ----
			}
			catch
			{ }
		}

		public static void SaveToFile()
		{
			try
			{
				List<string> lines = new List<string>();

				// ---- data ----

				lines.Add("" + ClientInfos.Count);

				foreach (ClientInfo info in ClientInfos)
				{
					lines.Add("" + (int)info.Method);
					lines.Add(info.Url);
					lines.Add("" + info.HeaderFields.Count);

					foreach (string[] headerField in info.HeaderFields)
					{
						lines.Add(headerField[0]); // フィールド名
						lines.Add(StringTools.TextToLine(headerField[1])); // フィールド値(改行アリ)
					}
					lines.Add(StringTools.TextToLine(info.Body));
					lines.Add("" + (int)info.BodyEncoding);
					lines.Add("" + (int)info.ResBodyEncoding);
					lines.Add("" + (int)info.Period);
				}

				lines.Add("" + (int)ProxyMode);
				lines.Add(ProxyHost);
				lines.Add("" + ProxyPort);

				// ----

				File.WriteAllLines(SaveDataFile, lines, StringTools.ENCODING_SJIS);
			}
			catch
			{ }
		}

		public static bool Flagプログラム終了要求 = false;
		public static ClientInfo ClientInfoこれ登録してね = null;
		public static bool ErrorIconFlag = false;
	}
}
