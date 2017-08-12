namespace Charlotte
{
	partial class HFEditWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HFEditWin));
			this.label1 = new System.Windows.Forms.Label();
			this.HFName = new System.Windows.Forms.TextBox();
			this.HFValue = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnOk = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.SouthText = new System.Windows.Forms.ToolStripStatusLabel();
			this.SouthEastText = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "フィールド名";
			// 
			// HFName
			// 
			this.HFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HFName.Location = new System.Drawing.Point(105, 12);
			this.HFName.MaxLength = 300;
			this.HFName.Name = "HFName";
			this.HFName.Size = new System.Drawing.Size(395, 27);
			this.HFName.TabIndex = 1;
			this.HFName.TextChanged += new System.EventHandler(this.HFName_TextChanged);
			this.HFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HFName_KeyPress);
			// 
			// HFValue
			// 
			this.HFValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HFValue.Location = new System.Drawing.Point(105, 45);
			this.HFValue.MaxLength = 50000;
			this.HFValue.Multiline = true;
			this.HFValue.Name = "HFValue";
			this.HFValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.HFValue.Size = new System.Drawing.Size(395, 103);
			this.HFValue.TabIndex = 3;
			this.HFValue.Text = "1行目\r\n2行目\r\n3行目\r\n4行目";
			this.HFValue.WordWrap = false;
			this.HFValue.TextChanged += new System.EventHandler(this.HFValue_TextChanged);
			this.HFValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HFValue_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "フィールド値";
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(260, 154);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(117, 37);
			this.BtnOk.TabIndex = 4;
			this.BtnOk.Text = "OK(&O)";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(383, 154);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(117, 37);
			this.BtnCancel.TabIndex = 5;
			this.BtnCancel.Text = "キャンセル(&C)";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SouthText,
            this.SouthEastText});
			this.statusStrip1.Location = new System.Drawing.Point(0, 194);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(512, 23);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// SouthText
			// 
			this.SouthText.Name = "SouthText";
			this.SouthText.Size = new System.Drawing.Size(393, 18);
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
			// HFEditWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 217);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.HFValue);
			this.Controls.Add(this.HFName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
			this.Name = "HFEditWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DDnsClient";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HFEditWin_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HFEditWin_FormClosed);
			this.Load += new System.EventHandler(this.HFEditWin_Load);
			this.Shown += new System.EventHandler(this.HFEditWin_Shown);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox HFName;
		private System.Windows.Forms.TextBox HFValue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel SouthText;
		private System.Windows.Forms.ToolStripStatusLabel SouthEastText;
	}
}
