using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Charlotte.Tools;

namespace Charlotte
{
	public class Background
	{
		public static void Interval()
		{
			if (End())
				return;

			ClientMain.Perform();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>実行中</returns>
		public static bool End()
		{
			return ClientMain.End();
		}
	}
}
