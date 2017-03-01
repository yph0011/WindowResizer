namespace WindowsFormsApplication1
{
    partial class Controller
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.ListUpWindows = new System.Windows.Forms.Button();
            this.TargetWindowList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListUpWindows
            // 
            this.ListUpWindows.Location = new System.Drawing.Point(12, 12);
            this.ListUpWindows.Name = "ListUpWindows";
            this.ListUpWindows.Size = new System.Drawing.Size(159, 29);
            this.ListUpWindows.TabIndex = 0;
            this.ListUpWindows.Text = "List up windows";
            this.ListUpWindows.UseVisualStyleBackColor = true;
            this.ListUpWindows.Click += new System.EventHandler(this.ListUpWindows_Click);
            // 
            // TargetWindowList
            // 
            this.TargetWindowList.FormattingEnabled = true;
            this.TargetWindowList.ItemHeight = 12;
            this.TargetWindowList.Location = new System.Drawing.Point(12, 47);
            this.TargetWindowList.Name = "TargetWindowList";
            this.TargetWindowList.Size = new System.Drawing.Size(159, 88);
            this.TargetWindowList.TabIndex = 1;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 366);
            this.Controls.Add(this.TargetWindowList);
            this.Controls.Add(this.ListUpWindows);
            this.Name = "Controller";
            this.Text = "Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListUpWindows;
        private System.Windows.Forms.ListBox TargetWindowList;
    }
}

