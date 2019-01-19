using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Charlotte.Tools;

namespace Charlotte
{
	public partial class SettingWin : Form
	{
		public SettingWin()
		{
			InitializeComponent();
		}

		private void SettingWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
			this.ProxyMode.SelectedIndex = 0;
			this.BtnOk.ForeColor = Gnd.ColorOkCancel;
			this.BtnCancel.ForeColor = Gnd.ColorOkCancel;

			this.LoadData();
		}

		private void LoadData()
		{
			this.ProxyMode.SelectedIndex = (int)Gnd.ProxyMode;
			this.ProxyHost.Text = Gnd.ProxyHost;
			this.ProxyPort.Text = "" + Gnd.ProxyPort;
		}

		private void SaveData()
		{
			Gnd.ProxyMode = (Gnd.ProxyMode_e)this.ProxyMode.SelectedIndex;
			Gnd.ProxyHost = this.ProxyHost.Text;
			Gnd.ProxyPort = IntTools.ToInt(this.ProxyPort.Text, 1, 65535, 8080);

			// normalize
			{
				if (Gnd.ProxyHost == "")
					Gnd.ProxyHost = "none";

				Gnd.ProxyHost = JString.ToAsciiToken(Gnd.ProxyHost, 1, 300);
			}

			Gnd.SaveToFile();
		}

		private void SettingWin_Shown(object sender, EventArgs e)
		{
			this.UIRefresh();

			Utils.PostShown(this);
		}

		private void SettingWin_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void SettingWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			// noop
		}

		private void ProxyMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.UIRefresh();
		}

		private void UIRefresh()
		{
			{
				bool flag = this.ProxyMode.SelectedIndex == 2;

				this.ProxyHost.Enabled = flag;
				this.ProxyPort.Enabled = flag;

				if (flag == false)
				{
					if (this.ProxyHost.Text == "")
						this.ProxyHost.Text = "none";

					this.ProxyPort.Text = "" + IntTools.ToInt(this.ProxyPort.Text, 1, 65535, 8080);
				}
			}

			{
				string message = this.GetWarning();

				this.BtnOk.Enabled = message == "";

				this.SouthText.Text = message;
				this.SouthEastText.Text = "";
			}
		}

		private string GetWarning()
		{
			if (this.ProxyHost.Text == "")
				return "ホスト名を入力して下さい。";

			{
				string text = this.ProxyPort.Text;

				text = "" + IntTools.ToInt(text, 1, 65535);

				if (text != this.ProxyPort.Text)
					return "ポート番号に 1 ～ 65535 の整数を指定して下さい。";
			}

			return "";
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			this.SaveData();
			this.Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ProxyHost_TextChanged(object sender, EventArgs e)
		{
			// real-time normalize
			{
				string text = this.ProxyHost.Text;

				//text = StringTools.ConvCRLF(text);
				text = JString.ToAsciiToken(text);
				//text = StringTools.ConvCRLF(text, "\r\n");

				if (this.ProxyHost.Text != text)
				{
					int selPos = this.ProxyHost.SelectionStart;

					this.ProxyHost.Text = text;
					this.ProxyHost.SelectionStart = selPos;
					this.ProxyHost.ScrollToCaret();
				}
			}

			this.UIRefresh();
		}

		private void ProxyPort_TextChanged(object sender, EventArgs e)
		{
			this.UIRefresh();
		}
	}
}
