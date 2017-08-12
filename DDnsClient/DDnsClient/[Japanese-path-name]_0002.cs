namespace Charlotte
{
	partial class 簡単登録_ieServerNet_Win
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(簡単登録_ieServerNet_Win));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.DomainName = new System.Windows.Forms.ComboBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.UserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.SouthText = new System.Windows.Forms.ToolStripStatusLabel();
			this.BtnOk = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.DomainName);
			this.groupBox1.Controls.Add(this.Password);
			this.groupBox1.Controls.Add(this.UserName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(531, 150);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ieServer.Net";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "パスワード";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "ドメイン名";
			// 
			// DomainName
			// 
			this.DomainName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DomainName.FormattingEnabled = true;
			this.DomainName.Items.AddRange(new object[] {
            "dip.jp",
            "fam.cx",
            "jpn.ph",
            "moe.hm",
            "myhome.cx",
            "or.tp",
            "orz.hm"});
			this.DomainName.Location = new System.Drawing.Point(86, 59);
			this.DomainName.Name = "DomainName";
			this.DomainName.Size = new System.Drawing.Size(143, 28);
			this.DomainName.TabIndex = 3;
			this.DomainName.SelectedIndexChanged += new System.EventHandler(this.DomainName_SelectedIndexChanged);
			this.DomainName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DomainName_KeyPress);
			// 
			// Password
			// 
			this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Password.Location = new System.Drawing.Point(86, 93);
			this.Password.MaxLength = 100;
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(439, 27);
			this.Password.TabIndex = 5;
			this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
			this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
			// 
			// UserName
			// 
			this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UserName.Location = new System.Drawing.Point(86, 26);
			this.UserName.MaxLength = 100;
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(439, 27);
			this.UserName.TabIndex = 1;
			this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
			this.UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "ユーザー名";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SouthText});
			this.statusStrip1.Location = new System.Drawing.Point(0, 208);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(555, 23);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// SouthText
			// 
			this.SouthText.Name = "SouthText";
			this.SouthText.Size = new System.Drawing.Size(104, 18);
			this.SouthText.Text = "準備しています...";
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(303, 168);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(117, 37);
			this.BtnOk.TabIndex = 1;
			this.BtnOk.Text = "登録(&R)";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(426, 168);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(117, 37);
			this.BtnCancel.TabIndex = 2;
			this.BtnCancel.Text = "キャンセル(&C)";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// 簡単登録_ieServerNet_Win
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 231);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
			this.Name = "簡単登録_ieServerNet_Win";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DDnsClient";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.簡単登録_ieServerNet_Win_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.簡単登録_ieServerNet_Win_FormClosed);
			this.Load += new System.EventHandler(this.簡単登録_ieServerNet_Win_Load);
			this.Shown += new System.EventHandler(this.簡単登録_ieServerNet_Win_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel SouthText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox DomainName;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.TextBox UserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Button BtnCancel;
	}
}
