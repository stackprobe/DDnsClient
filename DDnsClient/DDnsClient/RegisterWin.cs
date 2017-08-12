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
	public partial class RegisterWin : Form
	{
		public RegisterWin()
		{
			InitializeComponent();
		}

		private void RegisterWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = new Size(600, 300);
		}

		private void RegisterWin_Shown(object sender, EventArgs e)
		{
			this.MainSheet.RowCount = 0;
			this.MainSheet.ColumnCount = 0;

			this.MS_AddColumn("行番号");
			this.MS_AddColumn("Method");
			this.MS_AddColumn("URL");
			this.MS_AddColumn("HTTP Version");
			this.MS_AddColumn("Request Header");
			this.MS_AddColumn("Request Body");
			this.MS_AddColumn("Request Body Encoding");
			this.MS_AddColumn("Response Body Encoding");
			this.MS_AddColumn("更新周期");
			this.MS_AddColumn("最終実行日時");
			this.MS_AddColumn("次回実行日時");
			this.MS_AddColumn("エラー回数");

			this.UIRefresh();
			this.MainSheet.ClearSelection();
		}

		private void UIRefresh()
		{
			// MainSheet
			{
				this.MainSheet.RowCount = Gnd.ClientInfos.Count;

				for (int rowidx = 0; rowidx < Gnd.ClientInfos.Count; rowidx++)
					this.MS_SetRow(rowidx, Gnd.ClientInfos[rowidx]);

				for (int colidx = 0; colidx < this.MainSheet.ColumnCount; colidx++)
					this.MS_AutoResizeColumn(colidx);
			}

			this.UIRefresh_MS_以外();
		}

		private void UIRefresh_MS_以外()
		{
			// MS_ボタン
			{
				int selRowIndex = this.MS_GetSelectedRowIndex();

				this.BtnAdd.Enabled = this.MainSheet.RowCount < Gnd.ClientInfoCountMax;
				this.BtnEdit.Enabled = selRowIndex != -1;
				this.BtnDelete.Enabled = selRowIndex != -1;
				this.BtnUp.Enabled = selRowIndex != -1 && 1 <= selRowIndex;
				this.BtnDown.Enabled = selRowIndex != -1 && selRowIndex + 1 < this.MainSheet.RowCount;
			}

			this.簡単登録_ieServerNet_ToolStripMenuItem.Enabled = this.MainSheet.RowCount < Gnd.ClientInfoCountMax;

			this.SouthText.Text = "";
			this.SouthEastText.Text = this.MainSheet.RowCount + " / " + Gnd.ClientInfoCountMax;
		}

		private int MS_GetSelectedRowIndex()
		{
			for (int rowidx = 0; rowidx < this.MainSheet.RowCount; rowidx++)
				if (this.MainSheet.Rows[rowidx].Selected)
					return rowidx;

			return -1;
		}

		private void MS_SetSelectedRowIndex(int rowidx)
		{
			rowidx = IntTools.ToRange(rowidx, -1, this.MainSheet.RowCount - 1);

			if (rowidx == -1)
			{
				this.MainSheet.ClearSelection();
			}
			else
			{
				this.MainSheet.Rows[rowidx].Selected = true;
				this.MS_Scroll(rowidx);
			}
		}

		private void MS_Scroll(int rowidx)
		{
			this.MainSheet.FirstDisplayedScrollingRowIndex = Math.Max(0, rowidx - 2);
		}

		private void MS_SetRow(int rowidx, Gnd.ClientInfo info)
		{
			DataGridViewRow row = this.MainSheet.Rows[rowidx];
			int c = 0;

			row.Cells[c].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			row.Cells[c].Style.BackColor = Gnd.Color行番号;
			row.Cells[c].Value = "" + (rowidx + 1);
			c++;

			row.Cells[c++].Value = this.MS_GetCell(info.Method);
			row.Cells[c++].Value = this.MS_GetCellByUrl(info.Url);
			row.Cells[c++].Value = this.MS_GetCell(info.Version);
			row.Cells[c++].Value = this.MS_GetCellByHeaderFields(info.HeaderFields);
			row.Cells[c++].Value = this.MS_GetCellByBody(info.Body);
			row.Cells[c++].Value = this.MS_GetCell(info.BodyEncoding);
			row.Cells[c++].Value = this.MS_GetCell(info.ResBodyEncoding);
			row.Cells[c++].Value = this.MS_GetCell(info.Period);
			row.Cells[c++].Value = this.MS_GetCell(info.Time最終更新);
			row.Cells[c++].Value = this.MS_GetCell(info.Time次回更新);

			row.Cells[c].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			row.Cells[c].Value = "" + info.Count失敗;
			c++;
		}

		private object MS_GetCell(TimeData td)
		{
			if (td == null)
				return "";

			return td.ToString();
		}

		private object MS_GetCell(Gnd.ClientInfo.Period_e period)
		{
			switch (period)
			{
				case Gnd.ClientInfo.Period_e.Minute_3: return "3 分";
				case Gnd.ClientInfo.Period_e.Minute_5: return "5 分";
				case Gnd.ClientInfo.Period_e.Minute_7: return "7 分";
				case Gnd.ClientInfo.Period_e.Minute_10: return "10 分";
				case Gnd.ClientInfo.Period_e.Minute_20: return "20 分";
				case Gnd.ClientInfo.Period_e.Minute_30: return "30 分";
				case Gnd.ClientInfo.Period_e.Hour_1: return "1 時間";
				case Gnd.ClientInfo.Period_e.Hour_2: return "2 時間";
				case Gnd.ClientInfo.Period_e.Hour_3: return "3 時間";

				default:
					throw null;
			}
		}

		private string MS_GetCell(Gnd.ClientInfo.Method_e method)
		{
			switch (method)
			{
				case Gnd.ClientInfo.Method_e.GET: return "GET";
				case Gnd.ClientInfo.Method_e.POST: return "POST";
				case Gnd.ClientInfo.Method_e.HEAD: return "HEAD";

				default:
					throw null;
			}
		}

		private string MS_GetCell(Gnd.ClientInfo.Encoding_e encoding)
		{
			return Gnd.ClientInfo.Encodings[(int)encoding].EncodingName;
		}

		private string MS_GetCellByUrl(string url)
		{
			if (url[0] != 'h')
				url = "";

			if (100 < url.Length)
				url = url.Substring(0, 90) + " ...";

			return url;
		}

		private string MS_GetCell(Gnd.ClientInfo.Version_e version)
		{
			switch (version)
			{
				case Gnd.ClientInfo.Version_e.HTTP_10: return "HTTP 1.0";
				case Gnd.ClientInfo.Version_e.HTTP_11: return "HTTP 1.1";

				default:
					throw null;
			}
		}

		private string MS_GetCellByHeaderFields(List<string[]> headerFields)
		{
			if (headerFields.Count == 0)
				return "";

			StringBuilder buff = new StringBuilder();

			buff.Append(headerFields[0][0]);
			buff.Append(": ");
			buff.Append(StringTools.ConvCRLF(headerFields[0][1], "(改行)"));

			string ret = buff.ToString();

			if (50 < ret.Length)
				return ret.Substring(0, 40) + " ...";

			if (2 <= headerFields.Count)
				return ret + " ...";

			return ret;
		}

		private string MS_GetCellByBody(string body)
		{
			body = StringTools.ConvCRLF(body, "(改行)");

			if (50 < body.Length)
				body = body.Substring(0, 40) + " ...";

			return body;
		}

		private void MS_AddColumn(string name)
		{
			this.MainSheet.Columns.Add(name, name);
			int colidx = this.MainSheet.Columns.Count - 1;
			this.MainSheet.Columns[colidx].SortMode = DataGridViewColumnSortMode.NotSortable;
			this.MS_AutoResizeColumn(colidx);
		}

		private void MS_AutoResizeColumn(int colidx)
		{
			this.MainSheet.Columns[colidx].Width = 1000; // めっちゃ長く
			this.MainSheet.AutoResizeColumn(colidx, DataGridViewAutoSizeColumnMode.AllCells);
			this.MainSheet.Columns[colidx].Width += 20;
		}

		private void RegisterWin_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void RegisterWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			// normalize
			{
				for (int index = 0; index < Gnd.ClientInfos.Count; index++)
				{
					if (Gnd.ClientInfos[index].Url[0] != 'h')
					{
						Gnd.ClientInfos.RemoveAt(index);
						index--;
					}
				}
			}

			Gnd.SaveToFile();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			Gnd.ClientInfos.Add(new Gnd.ClientInfo());
			this.UIRefresh();
			this.MS_SetSelectedRowIndex(this.MainSheet.RowCount - 1);
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			int index = this.MS_GetSelectedRowIndex();

			if (index == -1)
				return;

			this.Visible = false;
			using (Form f = new EditWin(Gnd.ClientInfos[index]))
			{
				f.ShowDialog();
			}
			this.Visible = true;
			this.UIRefresh();
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			int index = this.MS_GetSelectedRowIndex();

			if (index == -1)
				return;

			Gnd.ClientInfos.RemoveAt(index);
			this.UIRefresh();
			this.MS_SetSelectedRowIndex(index);
		}

		private void BtnUp_Click(object sender, EventArgs e)
		{
			int index = this.MS_GetSelectedRowIndex();

			if (index < 1)
				return;

			this.MS_Swap(index - 1, index);
			this.MS_SetSelectedRowIndex(index - 1);
		}

		private void MS_Swap(int i, int j)
		{
			ArrayTools.Swap(Gnd.ClientInfos, i, j);
			this.UIRefresh();
		}

		private void BtnDown_Click(object sender, EventArgs e)
		{
			int index = this.MS_GetSelectedRowIndex();

			if (index < 0 || this.MainSheet.RowCount - 1 <= index)
				return;

			this.MS_Swap(index, index + 1);
			this.MS_SetSelectedRowIndex(index + 1);
		}

		private void MainSheet_SelectionChanged(object sender, EventArgs e)
		{
			this.UIRefresh_MS_以外();
		}

		private void このウィンドウを閉じるCToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void プログラムを終了するXToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Gnd.Flagプログラム終了要求 = true;
			this.Close();
		}

		private void 簡単登録_ieServerNet_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Gnd.ClientInfoこれ登録してね = null;

			this.Visible = false;
			using (Form f = new 簡単登録_ieServerNet_Win())
			{
				f.ShowDialog();
			}
			this.Visible = true;

			if (Gnd.ClientInfoこれ登録してね != null)
			{
				Gnd.ClientInfos.Add(Gnd.ClientInfoこれ登録してね);
				this.UIRefresh();
				this.MS_SetSelectedRowIndex(this.MainSheet.RowCount - 1);
			}
			Gnd.ClientInfoこれ登録してね = null;
		}
	}
}
