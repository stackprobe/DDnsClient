namespace Charlotte
{
	partial class ResultWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultWin));
			this.MainText = new System.Windows.Forms.TextBox();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.BtnOk = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.ResBodyEncoding = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// MainText
			// 
			this.MainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainText.Location = new System.Drawing.Point(12, 40);
			this.MainText.Multiline = true;
			this.MainText.Name = "MainText";
			this.MainText.ReadOnly = true;
			this.MainText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.MainText.Size = new System.Drawing.Size(627, 376);
			this.MainText.TabIndex = 3;
			this.MainText.WordWrap = false;
			this.MainText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainText_KeyPress);
			// 
			// ResultLabel
			// 
			this.ResultLabel.AutoSize = true;
			this.ResultLabel.Location = new System.Drawing.Point(12, 9);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.Size = new System.Drawing.Size(115, 20);
			this.ResultLabel.TabIndex = 0;
			this.ResultLabel.Text = "準備しています...";
			// 
			// BtnOk
			// 
			this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOk.Location = new System.Drawing.Point(522, 422);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(117, 37);
			this.BtnOk.TabIndex = 4;
			this.BtnOk.Text = "閉じる(&C)";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(388, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Encoding";
			// 
			// ResBodyEncoding
			// 
			this.ResBodyEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ResBodyEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ResBodyEncoding.FormattingEnabled = true;
			this.ResBodyEncoding.Items.AddRange(new object[] {
            "シフトJIS (MS932)",
            "EUC",
            "UTF-8",
            "UTF-16",
            "UTF-16_BE",
            "UTF-32"});
			this.ResBodyEncoding.Location = new System.Drawing.Point(461, 6);
			this.ResBodyEncoding.Name = "ResBodyEncoding";
			this.ResBodyEncoding.Size = new System.Drawing.Size(178, 28);
			this.ResBodyEncoding.TabIndex = 2;
			this.ResBodyEncoding.SelectedIndexChanged += new System.EventHandler(this.ResBodyEncoding_SelectedIndexChanged);
			// 
			// ResultWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 471);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ResBodyEncoding);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.MainText);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
			this.Name = "ResultWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DDnsClient";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultWin_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultWin_FormClosed);
			this.Load += new System.EventHandler(this.ResultWin_Load);
			this.Shown += new System.EventHandler(this.ResultWin_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox MainText;
		private System.Windows.Forms.Label ResultLabel;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox ResBodyEncoding;
	}
}
