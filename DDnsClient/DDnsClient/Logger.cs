using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Tools;
using System.IO;

namespace Charlotte
{
	public static class Logger
	{
		private static object SYNCROOT = new object();
		private const int LOG_FILE_SIZE_MAX = 100000; // 100 KB
		private static string LOG_FILE_1 = null;
		private static string LOG_FILE_2;

		public static void WriteLog(string line, int indent = 0) // ts_
		{
			line = StringTools.ConvCRLF(line, "\r\n");
			line = line.Trim();
			line += "\r\n";

			lock (SYNCROOT)
			{
				if (LOG_FILE_1 == null)
				{
					LOG_FILE_1 = StringTools.Combine(BootTools.SelfDir, "DDnsClient_Access.log");
					LOG_FILE_2 = StringTools.Combine(BootTools.SelfDir, "DDnsClient_Access0.log");
				}
				try
				{
					using (FileStream fs = new FileStream(LOG_FILE_1, FileMode.Append, FileAccess.Write))
					{
						for (int c = 0; c < indent; c++)
							FileTools.Write(fs, Encoding.UTF8.GetBytes("\t"));

						FileTools.Write(fs, Encoding.UTF8.GetBytes(line));
					}
					if (LOG_FILE_SIZE_MAX < new FileInfo(LOG_FILE_1).Length)
					{
						File.Delete(LOG_FILE_2);
						File.Move(LOG_FILE_1, LOG_FILE_2);
					}
				}
				catch
				{ }
			}
		}
	}
}
