using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Charlotte.Tools;
using System.Threading;

namespace Charlotte
{
	public partial class EditWin : Form
	{
		private Gnd.ClientInfo _info;

		public static Gnd.ClientInfo.Encoding_e W_ResBodyEncoding = Gnd.ClientInfo.Encoding_e.UTF8;

		public EditWin(Gnd.ClientInfo info)
		{
			_info = info;

			InitializeComponent();
		}

		private void EditWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;

			this.Method.SelectedIndex = 0;
			this.Body.Text = "";
			this.BodyEncoding.SelectedIndex = 0;
			this.Period.SelectedIndex = 0;

			this.BtnOk.ForeColor = Gnd.ColorOkCancel;
			this.BtnCancel.ForeColor = Gnd.ColorOkCancel;
		}

		private void EditWin_Shown(object sender, EventArgs e)
		{
			this.HFSheet.RowCount = 0;
			this.HFSheet.ColumnCount = 0;

			this.HFS_AddColumn("行番号");
			this.HFS_AddColumn("フィールド名");
			this.HFS_AddColumn("フィールド値");

			this.LoadData();

			this.UIRefresh();
			this.HFSheet.ClearSelection();

			this.Url.Focus();

			Utils.PostShown(this);
		}

		private void UIRefresh()
		{
			// HFSheet
			{
				this.HFSheet.RowCount = _headerFields.Count;

				for (int rowidx = 0; rowidx < _headerFields.Count; rowidx++)
					this.HFS_SetRow(rowidx, _headerFields[rowidx]);

				for (int colidx = 0; colidx < this.HFSheet.ColumnCount; colidx++)
					this.HFS_AutoResizeColumn(colidx);
			}

			this.UIRefresh_HFS_以外();
		}

		private void UIRefresh_HFS_以外()
		{
			// HFS_ボタン
			{
				int selRowIndex = this.HFS_GetSelectedIndex();

				this.BtnHFAdd.Enabled = this.HFSheet.RowCount < Gnd.HeaderFieldCountMax;
				this.BtnHFEdit.Enabled = selRowIndex != -1;
				this.BtnHFDelete.Enabled = selRowIndex != -1;
				this.BtnHFUp.Enabled = 1 <= selRowIndex;
				this.BtnHFDown.Enabled = selRowIndex != -1 && selRowIndex + 1 < this.HFSheet.RowCount;
			}

			string warning = this.GetWarning();

			this.BtnDoTest.Enabled = warning == "";
			this.BtnOk.Enabled = warning == "";

			this.SouthText.Text = warning;
			this.SouthText.ToolTipText = "";
			this.SouthEastText.Text =
				"ResBdyEnc: " +
				Gnd.ClientInfo.Encodings[(int)W_ResBodyEncoding].EncodingName +
				" ReqHdr: " +
				_headerFields.Count +
				" / " +
				Gnd.HeaderFieldCountMax;

			this.SouthEastText.ToolTipText =
				"応答ボディのエンコーディング: " +
				Gnd.ClientInfo.Encodings[(int)W_ResBodyEncoding].EncodingName +
				"\nリクエストヘッダの件数: " +
				_headerFields.Count +
				" 件 (最大: " +
				Gnd.HeaderFieldCountMax +
				" 件)";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>"" == 問題ナシ</returns>
		private string GetWarning()
		{
			if (this.Url.Text == "")
				return "URL を入力して下さい。";

			if (
				this.Url.Text.StartsWith("http://") == false &&
				this.Url.Text.StartsWith("https://") == false
				)
				return "URL は http://～ または https://～ でなければなりません。";

			return "";
		}

		private void HFS_SetRow(int rowidx, string[] headerField)
		{
			DataGridViewRow row = this.HFSheet.Rows[rowidx];
			row.Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			row.Cells[0].Style.BackColor = Gnd.Color行番号;
			int c = 0;
			row.Cells[c++].Value = "" + (rowidx + 1);
			row.Cells[c++].Value = headerField[0];
			row.Cells[c++].Value = HFS_GetCellByValue(headerField[1]);
		}

		private string HFS_GetCellByValue(string value)
		{
			value = StringTools.ConvCRLF(value, "(改行)");

			if (100 < value.Length)
				value = value.Substring(0, 90) + " ...";

			return value;
		}

		private int HFS_GetSelectedIndex()
		{
			for (int rowidx = 0; rowidx < this.HFSheet.RowCount; rowidx++)
				if (this.HFSheet.Rows[rowidx].Selected)
					return rowidx;

			return -1;
		}

		private void HFS_SetSelectedIndex(int rowidx)
		{
			rowidx = IntTools.ToRange(rowidx, -1, this.HFSheet.RowCount - 1);

			if (rowidx == -1)
			{
				this.HFSheet.ClearSelection();
			}
			else
			{
				this.HFSheet.Rows[rowidx].Selected = true;
				this.HFS_Scroll(rowidx);
			}
		}

		private void HFS_Scroll(int rowidx)
		{
			this.HFSheet.FirstDisplayedScrollingRowIndex = Math.Max(0, rowidx - 2);
		}

		private List<string[]> _headerFields = new List<string[]>();

		private void LoadData()
		{
			string url = _info.Url;

			if (url[0] != 'h')
				url = "";

			this.Method.SelectedIndex = (int)_info.Method;
			this.Url.Text = url;
			this.HTTPVersion.SelectedIndex = (int)_info.Version;

			_headerFields.Clear();

			foreach (string[] headerField in _info.HeaderFields)
			{
				_headerFields.Add(new string[]
				{
					headerField[0],
					headerField[1],
				});
			}
			this.Body.Text = StringTools.ConvCRLF(_info.Body, "\r\n");
			this.BodyEncoding.SelectedIndex = (int)_info.BodyEncoding;
			W_ResBodyEncoding = _info.ResBodyEncoding;
			this.Period.SelectedIndex = (int)_info.Period;
		}

		private void SaveData()
		{
			_info.Method = (Gnd.ClientInfo.Method_e)this.Method.SelectedIndex;
			_info.Url = this.Url.Text;
			_info.Version = (Gnd.ClientInfo.Version_e)this.HTTPVersion.SelectedIndex;

			_info.HeaderFields.Clear();

			foreach (string[] headerField in _headerFields)
				_info.HeaderFields.Add(headerField);

			_info.Body = this.Body.Text;
			_info.BodyEncoding = (Gnd.ClientInfo.Encoding_e)this.BodyEncoding.SelectedIndex;
			_info.ResBodyEncoding = W_ResBodyEncoding;
			_info.Period = (Gnd.ClientInfo.Period_e)this.Period.SelectedIndex;

			// normalize
			{
				_info.Url = JString.ToAsciiToken(_info.Url, 1);

				for (int index = 0; index < _info.HeaderFields.Count; index++)
				{
					if (_info.HeaderFields[index][0] == "" && _info.HeaderFields[index][1] == "")
					{
						_info.HeaderFields.RemoveAt(index);
						index--;
					}
				}
				for (int index = 0; index < _info.HeaderFields.Count; index++)
				{
					_info.HeaderFields[index][0] = JString.ToAsciiToken(_info.HeaderFields[index][0], 1, 300);
					_info.HeaderFields[index][1] = JString.ToAsciiText(_info.HeaderFields[index][1], 1);
				}
				_info.Body = JString.ToDoc(_info.Body);
			}
			// 設定変更に伴う変更
			{
				_info.Time次回更新 = null;
			}
		}

		private void HFS_AddColumn(string name)
		{
			this.HFSheet.Columns.Add(name, name);
			int colidx = this.HFSheet.Columns.Count - 1;
			this.HFSheet.Columns[colidx].SortMode = DataGridViewColumnSortMode.NotSortable;
			this.HFS_AutoResizeColumn(colidx);
		}

		private void HFS_AutoResizeColumn(int colidx)
		{
			this.HFSheet.Columns[colidx].Width = 1000; // めっちゃ長く
			this.HFSheet.AutoResizeColumn(colidx, DataGridViewAutoSizeColumnMode.AllCells);
			this.HFSheet.Columns[colidx].Width += 20;
		}

		private void EditWin_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void EditWin_FormClosed(object sender, FormClosedEventArgs e)
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

		private void Method_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.Method.SelectedIndex == (int)Gnd.ClientInfo.Method_e.POST;

			this.GrpRequestBody.Enabled = flag; // グループを無効にすると、中身も無効になる。
			//this.Body.Enabled = flag;
			//this.LabelEncoding.Enabled = flag;
			//this.BodyEncoding.Enabled = flag;
		}

		private void BtnHFAdd_Click(object sender, EventArgs e)
		{
			_headerFields.Add(new string[] { "", "" });
			this.UIRefresh();
			this.HFS_SetSelectedIndex(this.HFSheet.RowCount - 1);
		}

		private void BtnHFEdit_Click(object sender, EventArgs e)
		{
			int index = this.HFS_GetSelectedIndex();

			if (index == -1)
				return;

			this.Visible = false;

			using (Form f = new HFEditWin(_headerFields[index]))
			{
				f.ShowDialog();
			}
			this.Visible = true;
			this.UIRefresh();
		}

		private void BtnHFDelete_Click(object sender, EventArgs e)
		{
			int index = this.HFS_GetSelectedIndex();

			if (index == -1)
				return;

			_headerFields.RemoveAt(index);
			this.UIRefresh();
			this.HFS_SetSelectedIndex(index);
		}

		private void BtnHFUp_Click(object sender, EventArgs e)
		{
			int index = this.HFS_GetSelectedIndex();

			if (index < 1)
				return;

			this.HFS_Swap(index - 1, index);
			this.HFS_SetSelectedIndex(index - 1);
		}

		private void HFS_Swap(int i, int j)
		{
			ArrayTools.Swap(_headerFields, i, j);
			this.UIRefresh();
		}

		private void BtnHFDown_Click(object sender, EventArgs e)
		{
			int index = this.HFS_GetSelectedIndex();

			if (index < 0 || this.HFSheet.RowCount - 1 <= index)
				return;

			this.HFS_Swap(index, index + 1);
			this.HFS_SetSelectedIndex(index + 1);
		}

		private void Url_TextChanged(object sender, EventArgs e)
		{
			// real-time normalize
			{
				string text = this.Url.Text;

				//text = StringTools.ConvCRLF(text);
				text = JString.ToAsciiToken(text);
				//text = StringTools.ConvCRLF(text, "\r\n");

				if (this.Url.Text != text)
				{
					int selPos = this.Url.SelectionStart;

					this.Url.Text = text;
					this.Url.SelectionStart = selPos;
					this.Url.ScrollToCaret();
				}
			}

			this.UIRefresh_HFS_以外();
		}

		private void Url_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // ctrl + a
			{
				this.Url.SelectAll();
				e.Handled = true;
			}
		}

		private void HFSheet_SelectionChanged(object sender, EventArgs e)
		{
			this.UIRefresh_HFS_以外();
		}

		private void HFSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// noop
		}

		private void Body_TextChanged(object sender, EventArgs e)
		{
			//this.UIRefresh_HFS_以外(); // 不要
		}

		private void Body_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // ctrl + a
			{
				this.Body.SelectAll();
				e.Handled = true;
			}
		}

		private void BtnDoTest_Click(object sender, EventArgs e)
		{
			this.Visible = false;

			Gnd.ClientInfo escInfo = _info;
			_info = new Gnd.ClientInfo();
			this.SaveData();
			ClientData client = new ClientData(_info);
			_info = escInfo;

			using (Form f = new BusyDlg(new ClientData.ClientDataTh(client).End))
			{
				f.ShowDialog();
			}
			using (Form f = new ResultWin(client))
			{
				f.ShowDialog();
			}
			this.Visible = true;
			this.UIRefresh();
		}
	}
}
