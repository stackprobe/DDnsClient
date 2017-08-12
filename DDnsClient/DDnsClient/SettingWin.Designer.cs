namespace Charlotte
{
	partial class SettingWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWin));
			this.ProxyMode = new System.Windows.Forms.ComboBox();
			this.BtnOk = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ProxyPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ProxyHost = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.SouthText = new System.Windows.Forms.ToolStripStatusLabel();
			this.SouthEastText = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ProxyMode
			// 
			this.ProxyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProxyMode.FormattingEnabled = true;
			this.ProxyMode.Items.AddRange(new object[] {
            "ダイレクト接続",
            "インターネットオプションを利用する",
            "ホスト名・ポート番号を指定する"});
			this.ProxyMode.Location = new System.Drawing.Point(86, 26);
			this.ProxyMode.Name = "ProxyMode";
			this.ProxyMode.Size = new System.Drawing.Size(335, 28);
			this.ProxyMode.TabIndex = 0;
			this.ProxyMode.SelectedIndexChanged += new System.EventHandler(this.ProxyMode_SelectedIndexChanged);
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(297, 155);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(117, 37);
			this.BtnOk.TabIndex = 1;
			this.BtnOk.Text = "OK(&O)";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(420, 155);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(117, 37);
			this.BtnCancel.TabIndex = 2;
			this.BtnCancel.Text = "キャンセル(&C)";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.ProxyPort);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.ProxyHost);
			this.groupBox1.Controls.Add(this.ProxyMode);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(525, 137);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "プロキシサーバー";
			// 
			// ProxyPort
			// 
			this.ProxyPort.Location = new System.Drawing.Point(86, 93);
			this.ProxyPort.MaxLength = 5;
			this.ProxyPort.Name = "ProxyPort";
			this.ProxyPort.Size = new System.Drawing.Size(69, 27);
			this.ProxyPort.TabIndex = 4;
			this.ProxyPort.Text = "65535";
			this.ProxyPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ProxyPort.TextChanged += new System.EventHandler(this.ProxyPort_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "ポート番号";
			// 
			// ProxyHost
			// 
			this.ProxyHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProxyHost.Location = new System.Drawing.Point(86, 60);
			this.ProxyHost.MaxLength = 300;
			this.ProxyHost.Name = "ProxyHost";
			this.ProxyHost.Size = new System.Drawing.Size(433, 27);
			this.ProxyHost.TabIndex = 2;
			this.ProxyHost.TextChanged += new System.EventHandler(this.ProxyHost_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "ホスト名";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SouthText,
            this.SouthEastText});
			this.statusStrip1.Location = new System.Drawing.Point(0, 194);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(549, 23);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// SouthText
			// 
			this.SouthText.Name = "SouthText";
			this.SouthText.Size = new System.Drawing.Size(430, 18);
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
			// SettingWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 217);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
			this.Name = "SettingWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DDnsClient";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingWin_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingWin_FormClosed);
			this.Load += new System.EventHandler(this.SettingWin_Load);
			this.Shown += new System.EventHandler(this.SettingWin_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ProxyMode;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox ProxyPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ProxyHost;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel SouthText;
		private System.Windows.Forms.ToolStripStatusLabel SouthEastText;

	}
}
