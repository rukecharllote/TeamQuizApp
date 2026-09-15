namespace TeamQuizApp
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
            this.answerButton1 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.answerButton4 = new System.Windows.Forms.Button();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerButton1
            // 
            this.answerButton1.Location = new System.Drawing.Point(307, 610);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(238, 82);
            this.answerButton1.TabIndex = 0;
            this.answerButton1.Text = "1";
            this.answerButton1.UseVisualStyleBackColor = true;
            this.answerButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answerButton2
            // 
            this.answerButton2.Location = new System.Drawing.Point(642, 610);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(238, 82);
            this.answerButton2.TabIndex = 1;
            this.answerButton2.Text = "2";
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // answerButton3
            // 
            this.answerButton3.Location = new System.Drawing.Point(979, 610);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(238, 82);
            this.answerButton3.TabIndex = 2;
            this.answerButton3.Text = "3";
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // answerButton4
            // 
            this.answerButton4.Location = new System.Drawing.Point(1309, 610);
            this.answerButton4.Name = "answerButton4";
            this.answerButton4.Size = new System.Drawing.Size(238, 82);
            this.answerButton4.TabIndex = 3;
            this.answerButton4.Text = "4";
            this.answerButton4.UseVisualStyleBackColor = true;
            this.answerButton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 18;
            this.logListBox.Location = new System.Drawing.Point(583, 233);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(690, 274);
            this.logListBox.TabIndex = 4;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(580, 156);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(44, 18);
            this.questionLabel.TabIndex = 5;
            this.questionLabel.Text = "問題";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 833);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.answerButton4);
            this.Controls.Add(this.answerButton3);
            this.Controls.Add(this.answerButton2);
            this.Controls.Add(this.answerButton1);
            this.Name = "Form1";
            this.Text = "クイズアプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.Button answerButton4;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.Label questionLabel;
    }
}

