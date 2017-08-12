namespace Charlotte
{
	partial class RegisterWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterWin));
			this.MainSheet = new System.Windows.Forms.DataGridView();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnEdit = new System.Windows.Forms.Button();
			this.BtnUp = new System.Windows.Forms.Button();
			this.BtnDown = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.SouthText = new System.Windows.Forms.ToolStripStatusLabel();
			this.SouthEastText = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.アプリケーションAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.このウィンドウを閉じるCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.プログラムを終了するXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.簡易登録KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.簡単登録_ieServerNet_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.MainSheet)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainSheet
			// 
			this.MainSheet.AllowUserToAddRows = false;
			this.MainSheet.AllowUserToDeleteRows = false;
			this.MainSheet.AllowUserToResizeRows = false;
			this.MainSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MainSheet.Location = new System.Drawing.Point(12, 77);
			this.MainSheet.MultiSelect = false;
			this.MainSheet.Name = "MainSheet";
			this.MainSheet.ReadOnly = true;
			this.MainSheet.RowHeadersVisible = false;
			this.MainSheet.RowTemplate.Height = 21;
			this.MainSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.MainSheet.Size = new System.Drawing.Size(719, 419);
			this.MainSheet.TabIndex = 5;
			this.MainSheet.SelectionChanged += new System.EventHandler(this.MainSheet_SelectionChanged);
			// 
			// BtnAdd
			// 
			this.BtnAdd.Location = new System.Drawing.Point(12, 27);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(106, 44);
			this.BtnAdd.TabIndex = 0;
			this.BtnAdd.Text = "追加(&A)";
			this.BtnAdd.UseVisualStyleBackColor = true;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnDelete
			// 
			this.BtnDelete.Location = new System.Drawing.Point(236, 27);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(106, 44);
			this.BtnDelete.TabIndex = 2;
			this.BtnDelete.Text = "削除(&T)";
			this.BtnDelete.UseVisualStyleBackColor = true;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// BtnEdit
			// 
			this.BtnEdit.Location = new System.Drawing.Point(124, 27);
			this.BtnEdit.Name = "BtnEdit";
			this.BtnEdit.Size = new System.Drawing.Size(106, 44);
			this.BtnEdit.TabIndex = 1;
			this.BtnEdit.Text = "編集(&E)";
			this.BtnEdit.UseVisualStyleBackColor = true;
			this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// BtnUp
			// 
			this.BtnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnUp.Location = new System.Drawing.Point(513, 27);
			this.BtnUp.Name = "BtnUp";
			this.BtnUp.Size = new System.Drawing.Size(106, 44);
			this.BtnUp.TabIndex = 3;
			this.BtnUp.Text = "上へ(&U)";
			this.BtnUp.UseVisualStyleBackColor = true;
			this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
			// 
			// BtnDown
			// 
			this.BtnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnDown.Location = new System.Drawing.Point(625, 27);
			this.BtnDown.Name = "BtnDown";
			this.BtnDown.Size = new System.Drawing.Size(106, 44);
			this.BtnDown.TabIndex = 4;
			this.BtnDown.Text = "下へ(&D)";
			this.BtnDown.UseVisualStyleBackColor = true;
			this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SouthText,
            this.SouthEastText});
			this.statusStrip1.Location = new System.Drawing.Point(0, 498);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(743, 23);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// SouthText
			// 
			this.SouthText.Name = "SouthText";
			this.SouthText.Size = new System.Drawing.Size(624, 18);
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
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.アプリケーションAToolStripMenuItem,
            this.簡易登録KToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(743, 26);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// アプリケーションAToolStripMenuItem
			// 
			this.アプリケーションAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.このウィンドウを閉じるCToolStripMenuItem,
            this.toolStripMenuItem1,
            this.プログラムを終了するXToolStripMenuItem});
			this.アプリケーションAToolStripMenuItem.Name = "アプリケーションAToolStripMenuItem";
			this.アプリケーションAToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.アプリケーションAToolStripMenuItem.Text = "アプリケーション(&A)";
			// 
			// このウィンドウを閉じるCToolStripMenuItem
			// 
			this.このウィンドウを閉じるCToolStripMenuItem.Name = "このウィンドウを閉じるCToolStripMenuItem";
			this.このウィンドウを閉じるCToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.このウィンドウを閉じるCToolStripMenuItem.Text = "このウィンドウを閉じる(&C)";
			this.このウィンドウを閉じるCToolStripMenuItem.Click += new System.EventHandler(this.このウィンドウを閉じるCToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(247, 6);
			// 
			// プログラムを終了するXToolStripMenuItem
			// 
			this.プログラムを終了するXToolStripMenuItem.Name = "プログラムを終了するXToolStripMenuItem";
			this.プログラムを終了するXToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
			this.プログラムを終了するXToolStripMenuItem.Text = "アプリケーションを終了する(&X)";
			this.プログラムを終了するXToolStripMenuItem.Click += new System.EventHandler(this.プログラムを終了するXToolStripMenuItem_Click);
			// 
			// 簡易登録KToolStripMenuItem
			// 
			this.簡易登録KToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.簡単登録_ieServerNet_ToolStripMenuItem});
			this.簡易登録KToolStripMenuItem.Name = "簡易登録KToolStripMenuItem";
			this.簡易登録KToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
			this.簡易登録KToolStripMenuItem.Text = "簡単登録(&K)";
			// 
			// 簡単登録_ieServerNet_ToolStripMenuItem
			// 
			this.簡単登録_ieServerNet_ToolStripMenuItem.Name = "簡単登録_ieServerNet_ToolStripMenuItem";
			this.簡単登録_ieServerNet_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.簡単登録_ieServerNet_ToolStripMenuItem.Text = "ieServer.Net";
			this.簡単登録_ieServerNet_ToolStripMenuItem.Click += new System.EventHandler(this.簡単登録_ieServerNet_ToolStripMenuItem_Click);
			// 
			// RegisterWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 521);
			this.Controls.Add(this.BtnAdd);
			this.Controls.Add(this.BtnEdit);
			this.Controls.Add(this.BtnDelete);
			this.Controls.Add(this.BtnUp);
			this.Controls.Add(this.BtnDown);
			this.Controls.Add(this.MainSheet);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
			this.Name = "RegisterWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DDnsClient";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterWin_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterWin_FormClosed);
			this.Load += new System.EventHandler(this.RegisterWin_Load);
			this.Shown += new System.EventHandler(this.RegisterWin_Shown);
			((System.ComponentModel.ISupportInitialize)(this.MainSheet)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView MainSheet;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnEdit;
		private System.Windows.Forms.Button BtnUp;
		private System.Windows.Forms.Button BtnDown;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel SouthText;
		private System.Windows.Forms.ToolStripStatusLabel SouthEastText;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem アプリケーションAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem このウィンドウを閉じるCToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem プログラムを終了するXToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 簡易登録KToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 簡単登録_ieServerNet_ToolStripMenuItem;
	}
}
