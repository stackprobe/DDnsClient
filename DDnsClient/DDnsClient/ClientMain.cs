using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Charlotte.Tools;

namespace Charlotte
{
	public class ClientMain
	{
		private static Thread _th;
		private static int _currClientIndex = 0;
		private static Gnd.ClientInfo _info = null;
		private static ClientData _client = null;

		public static void Perform()
		{
			if (_th != null) throw null; // ? 実行中

			if (Gnd.ClientInfos.Count == 0)
				return;

			TimeData now = TimeData.Now();

			// 毎分00秒前後は避ける。
			{
				int s = (int)(now.T % 60);

				if (s < 5 || 50 < s)
					return;
			}

			_currClientIndex++;
			_currClientIndex %= Gnd.ClientInfos.Count;
			_info = Gnd.ClientInfos[_currClientIndex];

			if (_info.Time次回更新 == null)
			{
				if (_info.Time最終更新 != null)
				{
					TimeData td = new TimeData(_info.Time最終更新.T);

					switch (_info.Period)
					{
						case Gnd.ClientInfo.Period_e.Minute_3: td.T += 180; break;
						case Gnd.ClientInfo.Period_e.Minute_5: td.T += 300; break;
						case Gnd.ClientInfo.Period_e.Minute_7: td.T += 420; break;
						case Gnd.ClientInfo.Period_e.Minute_10: td.T += 600; break;
						case Gnd.ClientInfo.Period_e.Minute_20: td.T += 1200; break;
						case Gnd.ClientInfo.Period_e.Minute_30: td.T += 1800; break;
						case Gnd.ClientInfo.Period_e.Hour_1: td.T += 3600 * 1; break;
						case Gnd.ClientInfo.Period_e.Hour_2: td.T += 3600 * 2; break;
						case Gnd.ClientInfo.Period_e.Hour_3: td.T += 3600 * 3; break;

						default:
							throw null;
					}
					_info.Time次回更新 = td;
				}
				else
				{
					_info.Time次回更新 = now;
					//_info.Time次回更新 = new TimeData(now.T + 1L);
				}
			}
			if (now.T < _info.Time次回更新.T)
				return;

			// 実行すること確定！

			_info.Time最終更新 = null;
			_info.Time次回更新 = null;

			_client = new ClientData(_info);

			_th = new Thread(PerformTh);
			_th.Start();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>実行中</returns>
		public static bool End()
		{
			if (_th != null)
			{
				if (_th.Join(0))
				{
					_th = null;
					PostPerform();
				}
			}
			return _th != null;
		}

		private static void PerformTh()
		{
			_client.Perform();
		}

		private static void PostPerform()
		{
			TimeData now = TimeData.Now();

			_info.Time最終更新 = now;
			_info.Time次回更新 = null;

			if (_client.Flag失敗)
				_info.Count失敗++;
			else
				_info.Count失敗 = 0;

			_info = null;
			_client = null;

			{
				int countMax = -1;

				foreach (Gnd.ClientInfo info in Gnd.ClientInfos)
					countMax = Math.Max(countMax, info.Count失敗);

				Gnd.ErrorIconFlag = Gnd.Count失敗Min_ChangeIcon <= countMax;
			}
		}
	}
}
