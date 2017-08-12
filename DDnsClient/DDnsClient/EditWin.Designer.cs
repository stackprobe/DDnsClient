namespace Charlotte
{
	partial class EditWin
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWin));
			this.Url = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Method = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnHFDown = new System.Windows.Forms.Button();
			this.BtnHFUp = new System.Windows.Forms.Button();
			this.BtnHFAdd = new System.Windows.Forms.Button();
			this.BtnHFEdit = new System.Windows.Forms.Button();
			this.BtnHFDelete = new System.Windows.Forms.Button();
			this.HFSheet = new System.Windows.Forms.DataGridView();
			this.BtnOk = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.Body = new System.Windows.Forms.TextBox();
			this.Period = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.SouthText = new System.Windows.Forms.ToolStripStatusLabel();
			this.SouthEastText = new System.Windows.Forms.ToolStripStatusLabel();
			this.BtnDoTest = new System.Windows.Forms.Button();
			this.HTTPVersion = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.GrpRequestBody = new System.Windows.Forms.GroupBox();
			this.BodyEncoding = new System.Windows.Forms.ComboBox();
			this.LabelEncoding = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HFSheet)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.GrpRequestBody.SuspendLayout();
			this.SuspendLayout();
			// 
			// Url
			// 
			this.Url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Url.Location = new System.Drawing.Point(75, 46);
			this.Url.MaxLength = 50000;
			this.Url.Multiline = true;
			this.Url.Name = "Url";
			this.Url.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Url.Size = new System.Drawing.Size(623, 83);
			this.Url.TabIndex = 3;
			this.Url.Text = "1行目\r\n2行目\r\n3行目";
			this.Url.WordWrap = false;
			this.Url.TextChanged += new System.EventHandler(this.Url_TextChanged);
			this.Url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Url_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "URL";
			// 
			// Method
			// 
			this.Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Method.FormattingEnabled = true;
			this.Method.Items.AddRange(new object[] {
            "HEAD",
            "GET",
            "POST"});
			this.Method.Location = new System.Drawing.Point(75, 12);
			this.Method.Name = "Method";
			this.Method.Size = new System.Drawing.Size(155, 28);
			this.Method.TabIndex = 1;
			this.Method.SelectedIndexChanged += new System.EventHandler(this.Method_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Method";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.BtnHFDown);
			this.groupBox1.Controls.Add(this.BtnHFUp);
			this.groupBox1.Controls.Add(this.BtnHFAdd);
			this.groupBox1.Controls.Add(this.BtnHFEdit);
			this.groupBox1.Controls.Add(this.BtnHFDelete);
			this.groupBox1.Controls.Add(this.HFSheet);
			this.groupBox1.Location = new System.Drawing.Point(12, 135);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(686, 194);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Request Header";
			// 
			// BtnHFDown
			// 
			this.BtnHFDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnHFDown.Location = new System.Drawing.Point(577, 26);
			this.BtnHFDown.Name = "BtnHFDown";
			this.BtnHFDown.Size = new System.Drawing.Size(103, 37);
			this.BtnHFDown.TabIndex = 4;
			this.BtnHFDown.Text = "下へ(&D)";
			this.BtnHFDown.UseVisualStyleBackColor = true;
			this.BtnHFDown.Click += new System.EventHandler(this.BtnHFDown_Click);
			// 
			// BtnHFUp
			// 
			this.BtnHFUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnHFUp.Location = new System.Drawing.Point(468, 26);
			this.BtnHFUp.Name = "BtnHFUp";
			this.BtnHFUp.Size = new System.Drawing.Size(103, 37);
			this.BtnHFUp.TabIndex = 3;
			this.BtnHFUp.Text = "上へ(&U)";
			this.BtnHFUp.UseVisualStyleBackColor = true;
			this.BtnHFUp.Click += new System.EventHandler(this.BtnHFUp_Click);
			// 
			// BtnHFAdd
			// 
			this.BtnHFAdd.Location = new System.Drawing.Point(6, 26);
			this.BtnHFAdd.Name = "BtnHFAdd";
			this.BtnHFAdd.Size = new System.Drawing.Size(103, 37);
			this.BtnHFAdd.TabIndex = 0;
			this.BtnHFAdd.Text = "追加(&A)";
			this.BtnHFAdd.UseVisualStyleBackColor = true;
			this.BtnHFAdd.Click += new System.EventHandler(this.BtnHFAdd_Click);
			// 
			// BtnHFEdit
			// 
			this.BtnHFEdit.Location = new System.Drawing.Point(115, 26);
			this.BtnHFEdit.Name = "BtnHFEdit";
			this.BtnHFEdit.Size = new System.Drawing.Size(103, 37);
			this.BtnHFEdit.TabIndex = 1;
			this.BtnHFEdit.Text = "編集(&E)";
			this.BtnHFEdit.UseVisualStyleBackColor = true;
			this.BtnHFEdit.Click += new System.EventHandler(this.BtnHFEdit_Click);
			// 
			// BtnHFDelete
			// 
			this.BtnHFDelete.Location = new System.Drawing.Point(224, 26);
			this.BtnHFDelete.Name = "BtnHFDelete";
			this.BtnHFDelete.Size = new System.Drawing.Size(103, 37);
			this.BtnHFDelete.TabIndex = 2;
			this.BtnHFDelete.Text = "削除(&R)";
			this.BtnHFDelete.UseVisualStyleBackColor = true;
			this.BtnHFDelete.Click += new System.EventHandler(this.BtnHFDelete_Click);
			// 
			// HFSheet
			// 
			this.HFSheet.AllowUserToAddRows = false;
			this.HFSheet.AllowUserToDeleteRows = false;
			this.HFSheet.AllowUserToResizeRows = false;
			this.HFSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HFSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.HFSheet.Location = new System.Drawing.Point(6, 69);
			this.HFSheet.MultiSelect = false;
			this.HFSheet.Name = "HFSheet";
			this.HFSheet.ReadOnly = true;
			this.HFSheet.RowHeadersVisible = false;
			this.HFSheet.RowTemplate.Height = 21;
			this.HFSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.HFSheet.Size = new System.Drawing.Size(674, 119);
			this.HFSheet.TabIndex = 5;
			this.HFSheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HFSheet_CellContentClick);
			this.HFSheet.SelectionChanged += new System.EventHandler(this.HFSheet_SelectionChanged);
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(458, 510);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(117, 37);
			this.BtnOk.TabIndex = 11;
			this.BtnOk.Text = "OK(&O)";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(581, 510);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(117, 37);
			this.BtnCancel.TabIndex = 12;
			this.BtnCancel.Text = "キャンセル(&C)";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// Body
			// 
			this.Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Body.Location = new System.Drawing.Point(6, 26);
			this.Body.MaxLength = 50000;
			this.Body.Multiline = true;
			this.Body.Name = "Body";
			this.Body.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Body.Size = new System.Drawing.Size(674, 103);
			this.Body.TabIndex = 0;
			this.Body.Text = "1行目\r\n2行目\r\n3行目\r\n4行目";
			this.Body.WordWrap = false;
			this.Body.TextChanged += new System.EventHandler(this.Body_TextChanged);
			this.Body.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Body_KeyPress);
			// 
			// Period
			// 
			this.Period.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Period.FormattingEnabled = true;
			this.Period.Items.AddRange(new object[] {
            "3 分",
            "5 分",
            "7 分",
            "10 分",
            "20 分",
            "30 分",
            "1 時間",
            "2 時間",
            "3 時間"});
			this.Period.Location = new System.Drawing.Point(91, 510);
			this.Period.Name = "Period";
			this.Period.Size = new System.Drawing.Size(178, 28);
			this.Period.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 513);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "更新周期";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SouthText,
            this.SouthEastText});
			this.statusStrip1.Location = new System.Drawing.Point(0, 550);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.Size = new System.Drawing.Size(710, 23);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// SouthText
			// 
			this.SouthText.Name = "SouthText";
			this.SouthText.Size = new System.Drawing.Size(591, 18);
			this.SouthText.Spring = true;
			this.SouthText.Text = "準備しています...";
			this.SouthText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SouthEastText
			// 
			this.SouthEastText.Name = "SouthEastText";
			this.SouthEastText.Size = new System.Drawing.Size(104, 18);
			this.SouthEastText.Text = "準備しています...";
			// 
			// BtnDoTest
			// 
			this.BtnDoTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnDoTest.Location = new System.Drawing.Point(335, 510);
			this.BtnDoTest.Name = "BtnDoTest";
			this.BtnDoTest.Size = new System.Drawing.Size(117, 37);
			this.BtnDoTest.TabIndex = 10;
			this.BtnDoTest.Text = "テスト(&T)";
			this.BtnDoTest.UseVisualStyleBackColor = true;
			this.BtnDoTest.Click += new System.EventHandler(this.BtnDoTest_Click);
			// 
			// HTTPVersion
			// 
			this.HTTPVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HTTPVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.HTTPVersion.FormattingEnabled = true;
			this.HTTPVersion.Items.AddRange(new object[] {
            "HTTP 1.0",
            "HTTP 1.1"});
			this.HTTPVersion.Location = new System.Drawing.Point(543, 12);
			this.HTTPVersion.Name = "HTTPVersion";
			this.HTTPVersion.Size = new System.Drawing.Size(155, 28);
			this.HTTPVersion.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(444, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "HTTP Version";
			// 
			// GrpRequestBody
			// 
			this.GrpRequestBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GrpRequestBody.Controls.Add(this.LabelEncoding);
			this.GrpRequestBody.Controls.Add(this.Body);
			this.GrpRequestBody.Controls.Add(this.BodyEncoding);
			this.GrpRequestBody.Location = new System.Drawing.Point(12, 335);
			this.GrpRequestBody.Name = "GrpRequestBody";
			this.GrpRequestBody.Size = new System.Drawing.Size(686, 169);
			this.GrpRequestBody.TabIndex = 7;
			this.GrpRequestBody.TabStop = false;
			this.GrpRequestBody.Text = "Request Body";
			// 
			// BodyEncoding
			// 
			this.BodyEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BodyEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BodyEncoding.FormattingEnabled = true;
			this.BodyEncoding.Items.AddRange(new object[] {
            "シフトJIS (MS932)",
            "EUC",
            "UTF-8",
            "UTF-16",
            "UTF-16_BE",
            "UTF-32"});
			this.BodyEncoding.Location = new System.Drawing.Point(79, 135);
			this.BodyEncoding.Name = "BodyEncoding";
			this.BodyEncoding.Size = new System.Drawing.Size(178, 28);
			this.BodyEncoding.TabIndex = 2;
			// 
			// LabelEncoding
			// 
			this.LabelEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LabelEncoding.AutoSize = true;
			this.LabelEncoding.Location = new System.Drawing.Point(6, 138);
			this.LabelEncoding.Name = "LabelEncoding";
			this.LabelEncoding.Size = new System.Drawing.Size(67, 20);
			this.LabelEncoding.TabIndex = 1;
			this.LabelEncoding.Text = "Encoding";
			// 
			// EditWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 573);
			this.Controls.Add(this.GrpRequestBody);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.HTTPVersion);
			this.Controls.Add(this.BtnDoTest);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Method);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Url);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Period);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
			this.Name = "EditWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DDnsClient";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditWin_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditWin_FormClosed);
			this.Load += new System.EventHandler(this.EditWin_Load);
			this.Shown += new System.EventHandler(this.EditWin_Shown);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.HFSheet)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.GrpRequestBody.ResumeLayout(false);
			this.GrpRequestBody.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Url;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Method;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView HFSheet;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnHFAdd;
		private System.Windows.Forms.Button BtnHFDelete;
		private System.Windows.Forms.Button BtnHFEdit;
		private System.Windows.Forms.TextBox Body;
		private System.Windows.Forms.ComboBox Period;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button BtnHFDown;
		private System.Windows.Forms.Button BtnHFUp;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel SouthText;
		private System.Windows.Forms.ToolStripStatusLabel SouthEastText;
		private System.Windows.Forms.Button BtnDoTest;
		private System.Windows.Forms.ComboBox HTTPVersion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox GrpRequestBody;
		private System.Windows.Forms.Label LabelEncoding;
		private System.Windows.Forms.ComboBox BodyEncoding;
	}
}
