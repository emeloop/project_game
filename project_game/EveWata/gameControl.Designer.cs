namespace EveWata
{
    partial class gameControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.testString = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testString
            // 
            this.testString.AutoSize = true;
            this.testString.Location = new System.Drawing.Point(18, 64);
            this.testString.Name = "testString";
            this.testString.Size = new System.Drawing.Size(118, 24);
            this.testString.TabIndex = 0;
            this.testString.Text = "ゲーム画面";
            this.testString.Click += new System.EventHandler(this.testString_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "戻る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EveWata.Properties.Resources.backGroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testString);
            this.Name = "gameControl";
            this.Size = new System.Drawing.Size(1202, 642);
            this.Load += new System.EventHandler(this.gameSceneControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testString;
        private System.Windows.Forms.Button button1;
    }
}
