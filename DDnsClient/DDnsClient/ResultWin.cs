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
	public partial class ResultWin : Form
	{
		private ClientData _client;

		public ResultWin(ClientData client)
		{
			_client = client;

			InitializeComponent();
		}

		private void ResultWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
			this.MainText.BackColor = new TextBox().BackColor;
		}

		private void ResultWin_Shown(object sender, EventArgs e)
		{
			if (_client.Flag失敗)
			{
				this.ResultLabel.Text = "結果：失敗";
				this.ResultLabel.BackColor = Color.Yellow;
				this.ResultLabel.ForeColor = Color.Red;
			}
			else
			{
				this.ResultLabel.Text = "結果：成功";
				this.ResultLabel.BackColor = Color.Blue;
				this.ResultLabel.ForeColor = Color.White;
			}
			this.ResBodyEncoding.SelectedIndex = (int)EditWin.W_ResBodyEncoding;
		}

		private void ResultWin_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void ResultWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			// noop
		}

		private void MainText_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // ctrl + a
			{
				this.MainText.SelectAll();
				e.Handled = true;
			}
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ResBodyEncoding_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditWin.W_ResBodyEncoding = (Gnd.ClientInfo.Encoding_e)this.ResBodyEncoding.SelectedIndex;

			{
				string text = ClientData.LastReportToText(_client.LastReport, Gnd.ClientInfo.Encodings[this.ResBodyEncoding.SelectedIndex]);

				text = StringTools.ConvCRLF(text, "\r\n");

				this.MainText.Text = text;
				this.MainText.SelectionStart = text.Length;
				this.MainText.ScrollToCaret();
			}
		}
	}
}
