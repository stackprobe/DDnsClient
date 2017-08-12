using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using Charlotte.Tools;

namespace Charlotte
{
	public partial class MainWin : Form
	{
		#region ALT_F4 抑止

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			const int WM_SYSCOMMAND = 0x112;
			const long SC_CLOSE = 0xF060L;

			if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt64() & 0xFFF0L) == SC_CLOSE)
				return;

			base.WndProc(ref m);
		}

		#endregion

		public MainWin()
		{
			InitializeComponent();
		}

		private void MainWin_Load(object sender, EventArgs e)
		{
			Gnd.NormalIcon = this.TaskTrayIcon.Icon;
		}

		private void MainWin_Shown(object sender, EventArgs e)
		{
			this.Visible = false;
			this.TaskTrayIcon.Visible = true;
			this.MT_Enabled = true;
		}

		private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void MainWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.MT_Enabled = false;
			this.TaskTrayIcon.Visible = false;
		}

		private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private bool MT_Enabled;
		private bool MT_Busy;
		private long MT_Count;

		private void MainTimer_Tick(object sender, EventArgs e)
		{
			if (this.MT_Enabled == false || this.MT_Busy)
				return;

			this.MT_Busy = true;

			try
			{
				if (Gnd.Flagプログラム終了要求)
				{
					this.Close();
					return;
				}
				if (50 <= this.MT_Count && this.MT_Count % 20 == 10) // 起動してから 5 sec 経過 && 2 sec 毎
				{
					Background.Interval();

					{
						Icon icon;

						if (Gnd.ErrorIconFlag)
							icon = Gnd.ErrorIcon;
						else
							icon = Gnd.NormalIcon;

						if (this.TaskTrayIcon.Icon != icon)
							this.TaskTrayIcon.Icon = icon;
					}

					{
						string message;

						if (Gnd.ErrorIconFlag)
							message = "DDnsClient: 通信エラー(登録内容を確認して下さい)";
						else
							message = "DDnsClient: 正常";

						if (this.TaskTrayIcon.Text != message)
							this.TaskTrayIcon.Text = message;
					}
				}
				if (this.MT_Count % 2000 == 20)
				{
					GC.Collect();
				}
			}
			finally
			{
				this.MT_Busy = false;
				this.MT_Count++;
			}
		}

		private void リクエストの登録RToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MT_Enabled = false;
			this.TaskTrayIcon.Visible = false;

			using (Form f = new BusyDlg(Background.End))
			{
				f.ShowDialog();
			}
			using (Form f = new RegisterWin())
			{
				f.ShowDialog();
			}

			this.TaskTrayIcon.Visible = true;
			this.MT_Enabled = true;
		}

		private void 直ちに更新UToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MT_Enabled = false;
			this.TaskTrayIcon.Visible = false;

			using (Form f = new BusyDlg(Background.End))
			{
				f.ShowDialog();
			}

			{
				TimeData now = TimeData.Now();

				foreach (Gnd.ClientInfo info in Gnd.ClientInfos)
				{
					info.Time次回更新 = now;
				}
			}

			this.TaskTrayIcon.Visible = true;
			this.MT_Enabled = true;
		}

		private void TaskTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//this.リクエストの登録RToolStripMenuItem_Click(null, null); // アイコンが消えた時、隣のアイコンをクリックしてしまって鬱陶しい。ので、没。
		}

		private void 設定SToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MT_Enabled = false;
			this.TaskTrayIcon.Visible = false;

			using (Form f = new BusyDlg(Background.End))
			{
				f.ShowDialog();
			}
			using (Form f = new SettingWin())
			{
				f.ShowDialog();
			}

			this.TaskTrayIcon.Visible = true;
			this.MT_Enabled = true;
		}
	}
}
