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
	public partial class 簡単登録_ieServerNet_Win : Form
	{
		public 簡単登録_ieServerNet_Win()
		{
			InitializeComponent();
		}

		private void 簡単登録_ieServerNet_Win_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
			this.DomainName.SelectedIndex = 0;
			this.BtnOk.ForeColor = Gnd.ColorOkCancel;
			this.BtnCancel.ForeColor = Gnd.ColorOkCancel;
		}

		private void 簡単登録_ieServerNet_Win_Shown(object sender, EventArgs e)
		{
			this.UIRefresh();
		}

		private void UIRefresh()
		{
			{
				string message = this.GetWarning();

				this.BtnOk.Enabled = message == "";
				this.SouthText.Text = message;
			}
		}

		private string GetWarning()
		{
			if (this.UserName.Text == "")
				return "ユーザー名を入力して下さい。";

			if (this.Password.Text == "")
				return "パスワードを入力して下さい。";

			return "";
		}

		private void 簡単登録_ieServerNet_Win_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void 簡単登録_ieServerNet_Win_FormClosed(object sender, FormClosedEventArgs e)
		{
			// noop
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			// 登録
			{
				Gnd.ClientInfo info = new Gnd.ClientInfo();

				info.Url =
					"http://ieserver.net/cgi-bin/dip.cgi?username=" +
					this.UserName.Text +
					"&domain=" +
					this.DomainName.Text +
					"&password=" +
					this.Password.Text +
					"&updatehost=1";

				info.HeaderFields.Add(new string[]
				{
					"User-Agent",
					"DDnsClient"
				});

				Gnd.ClientInfoこれ登録してね = info;
			}

			this.Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void UserName_TextChanged(object sender, EventArgs e)
		{
			// real-time normalize
			{
				string text = this.UserName.Text;

				//text = StringTools.ConvCRLF(text);
				text = JString.ToAsciiToken(text);
				//text = StringTools.ConvCRLF(text, "\r\n");

				if (this.UserName.Text != text)
				{
					int selPos = this.UserName.SelectionStart;

					this.UserName.Text = text;
					this.UserName.SelectionStart = selPos;
					this.UserName.ScrollToCaret();
				}
			}

			this.UIRefresh();
		}

		private void Password_TextChanged(object sender, EventArgs e)
		{
			// real-time normalize
			{
				string text = this.Password.Text;

				//text = StringTools.ConvCRLF(text);
				text = JString.ToAsciiToken(text);
				//text = StringTools.ConvCRLF(text, "\r\n");

				if (this.Password.Text != text)
				{
					int selPos = this.Password.SelectionStart;

					this.Password.Text = text;
					this.Password.SelectionStart = selPos;
					this.Password.ScrollToCaret();
				}
			}

			this.UIRefresh();
		}

		private void DomainName_SelectedIndexChanged(object sender, EventArgs e)
		{
			//this.UIRefresh(); // 不要
		}

		private void UserName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) // enter
			{
				this.DomainName.Focus();
				this.DomainName.DroppedDown = true;
				e.Handled = true;
			}
		}

		private void DomainName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) // enter
			{
				this.Password.Focus();
				e.Handled = true;
			}
		}

		private void Password_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) // enter
			{
				this.BtnOk.Focus();
				e.Handled = true;
			}
		}
	}
}
