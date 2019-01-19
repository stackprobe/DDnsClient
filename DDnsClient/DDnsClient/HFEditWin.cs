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
	public partial class HFEditWin : Form
	{
		private string[] _headerField;

		public HFEditWin(string[] headerField)
		{
			_headerField = headerField;

			InitializeComponent();
		}

		private void HFEditWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;

			this.LoadData();

			this.BtnOk.ForeColor = Gnd.ColorOkCancel;
			this.BtnCancel.ForeColor = Gnd.ColorOkCancel;
		}

		private void LoadData()
		{
			this.HFName.Text = _headerField[0];
			this.HFValue.Text = StringTools.ConvCRLF(_headerField[1], "\r\n");
		}

		private void SaveData()
		{
			_headerField[0] = this.HFName.Text.Trim();
			_headerField[1] = this.HFValue.Text.Trim();
		}

		private void HFEditWin_Shown(object sender, EventArgs e)
		{
			Utils.PostShown(this);
		}

		private void HFEditWin_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void HFEditWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			// noop
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			this.SaveData();
			this.Close();
		}

		private void HFName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) // enter
			{
				this.HFValue.Focus();
				e.Handled = true;
			}
		}

		private void HFValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // ctrl + a
			{
				this.HFValue.SelectAll();
				e.Handled = true;
			}
			else if (e.KeyChar == (char)10) // ctrl + enter
			{
				this.BtnOk.Focus();
				e.Handled = true;
			}
		}

		private void HFName_TextChanged(object sender, EventArgs e)
		{
			// real-time normalize
			{
				string text = this.HFName.Text;

				//text = StringTools.ConvCRLF(text);
				text = JString.ToAsciiToken(text);
				//text = StringTools.ConvCRLF(text, "\r\n");

				if (this.HFName.Text != text)
				{
					int selPos = this.HFName.SelectionStart;

					this.HFName.Text = text;
					this.HFName.SelectionStart = selPos;
					this.HFName.ScrollToCaret();
				}
			}

			this.UIRefresh();
		}

		private void HFValue_TextChanged(object sender, EventArgs e)
		{
			// real-time normalize
			{
				string text = this.HFValue.Text;

				text = StringTools.ConvCRLF(text);
				text = JString.ToJString(text, false, true, false, true, true);
				text = StringTools.ConvCRLF(text, "\r\n");

				if (this.HFValue.Text != text)
				{
					int selPos = this.HFValue.SelectionStart;

					this.HFValue.Text = text;
					this.HFValue.SelectionStart = selPos;
					this.HFValue.ScrollToCaret();
				}
			}

			this.UIRefresh();
		}

		private void UIRefresh()
		{
			string warning = this.GetWarning();

			this.BtnOk.Enabled = warning == "";

			this.SouthText.Text = warning;
			this.SouthEastText.Text = "";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>"" == 問題ナシ</returns>
		private string GetWarning()
		{
			StringBuilder buff = new StringBuilder();

			string name = this.HFName.Text.Trim();

			if (name == "")
				return "フィールド名を入力して下さい。";

			if (
				StringTools.IsSame(name, "Connection", true) ||
				StringTools.IsSame(name, "Content-Length", true) ||
				StringTools.IsSame(name, "Host", true)
				)
				return "そのフィールドは自動的に追加されます。";

			if (this.HFValue.Text.Trim() == "")
				return "フィールド値を入力して下さい。";

			return buff.ToString();
		}
	}
}
