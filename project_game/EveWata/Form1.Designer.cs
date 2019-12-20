namespace EveWata
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainControlPanel = new EveWata.mainControlPanel();
            this.userControl11 = new EveWata.settingControlPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1732, 900);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // mainControlPanel
            // 
            this.mainControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainControlPanel.Location = new System.Drawing.Point(0, 0);
            this.mainControlPanel.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.mainControlPanel.Name = "mainControlPanel";
            this.mainControlPanel.Size = new System.Drawing.Size(1127, 568);
            this.mainControlPanel.TabIndex = 0;
            this.mainControlPanel.Load += new System.EventHandler(this.mainControl1_Load);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1040, 566);
            this.userControl11.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainControlPanel);
            this.Controls.Add(this.userControl11);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "俺たちのイヴは渡さねぇ！";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private mainControlPanel mainControlPanel;
        private settingControlPanel userControl11;
        private System.Windows.Forms.Panel panel1;
    }
}

