namespace FileMove
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FileReadBnt = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.FileStroragePathPrefixLabel = new System.Windows.Forms.Label();
            this.FileStroragePathPrefixTextBox = new System.Windows.Forms.TextBox();
            this.FileMoveBnt = new System.Windows.Forms.Button();
            this.BackupFilePathPrefixLabel = new System.Windows.Forms.Label();
            this.BacpUpSourcePathPrefixTextBox = new System.Windows.Forms.TextBox();
            this.CheckCsvProduceBnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileReadBnt
            // 
            this.FileReadBnt.Location = new System.Drawing.Point(44, 36);
            this.FileReadBnt.Name = "FileReadBnt";
            this.FileReadBnt.Size = new System.Drawing.Size(75, 23);
            this.FileReadBnt.TabIndex = 0;
            this.FileReadBnt.Text = "讀取檔案";
            this.FileReadBnt.UseVisualStyleBackColor = true;
            this.FileReadBnt.Click += new System.EventHandler(this.FileReadBnt_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(203, 36);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(515, 22);
            this.FilePathTextBox.TabIndex = 1;
            // 
            // FileStroragePathPrefixLabel
            // 
            this.FileStroragePathPrefixLabel.AutoSize = true;
            this.FileStroragePathPrefixLabel.Location = new System.Drawing.Point(29, 163);
            this.FileStroragePathPrefixLabel.Name = "FileStroragePathPrefixLabel";
            this.FileStroragePathPrefixLabel.Size = new System.Drawing.Size(149, 12);
            this.FileStroragePathPrefixLabel.TabIndex = 2;
            this.FileStroragePathPrefixLabel.Text = "搬運檔案存放目的路徑開頭";
            // 
            // FileStroragePathPrefixTextBox
            // 
            this.FileStroragePathPrefixTextBox.Location = new System.Drawing.Point(203, 153);
            this.FileStroragePathPrefixTextBox.Name = "FileStroragePathPrefixTextBox";
            this.FileStroragePathPrefixTextBox.Size = new System.Drawing.Size(515, 22);
            this.FileStroragePathPrefixTextBox.TabIndex = 3;
            // 
            // FileMoveBnt
            // 
            this.FileMoveBnt.Location = new System.Drawing.Point(31, 238);
            this.FileMoveBnt.Name = "FileMoveBnt";
            this.FileMoveBnt.Size = new System.Drawing.Size(270, 107);
            this.FileMoveBnt.TabIndex = 4;
            this.FileMoveBnt.Text = "搬運檔案";
            this.FileMoveBnt.UseVisualStyleBackColor = true;
            this.FileMoveBnt.Click += new System.EventHandler(this.FileMoveBnt_Click);
            // 
            // BackupFilePathPrefixLabel
            // 
            this.BackupFilePathPrefixLabel.AutoSize = true;
            this.BackupFilePathPrefixLabel.Location = new System.Drawing.Point(29, 121);
            this.BackupFilePathPrefixLabel.Name = "BackupFilePathPrefixLabel";
            this.BackupFilePathPrefixLabel.Size = new System.Drawing.Size(101, 12);
            this.BackupFilePathPrefixLabel.TabIndex = 5;
            this.BackupFilePathPrefixLabel.Text = "備份檔案路徑開頭";
            // 
            // BacpUpSourcePathPrefixTextBox
            // 
            this.BacpUpSourcePathPrefixTextBox.Location = new System.Drawing.Point(203, 110);
            this.BacpUpSourcePathPrefixTextBox.Name = "BacpUpSourcePathPrefixTextBox";
            this.BacpUpSourcePathPrefixTextBox.Size = new System.Drawing.Size(515, 22);
            this.BacpUpSourcePathPrefixTextBox.TabIndex = 6;
            // 
            // CheckCsvProduceBnt
            // 
            this.CheckCsvProduceBnt.Location = new System.Drawing.Point(457, 238);
            this.CheckCsvProduceBnt.Name = "CheckCsvProduceBnt";
            this.CheckCsvProduceBnt.Size = new System.Drawing.Size(261, 107);
            this.CheckCsvProduceBnt.TabIndex = 7;
            this.CheckCsvProduceBnt.Text = "產生檢查結果csv";
            this.CheckCsvProduceBnt.UseVisualStyleBackColor = true;
            this.CheckCsvProduceBnt.Click += new System.EventHandler(this.CheckCsvProduceBnt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckCsvProduceBnt);
            this.Controls.Add(this.BacpUpSourcePathPrefixTextBox);
            this.Controls.Add(this.BackupFilePathPrefixLabel);
            this.Controls.Add(this.FileMoveBnt);
            this.Controls.Add(this.FileStroragePathPrefixTextBox);
            this.Controls.Add(this.FileStroragePathPrefixLabel);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.FileReadBnt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileReadBnt;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Label FileStroragePathPrefixLabel;
        private System.Windows.Forms.TextBox FileStroragePathPrefixTextBox;
        private System.Windows.Forms.Button FileMoveBnt;
        private System.Windows.Forms.Label BackupFilePathPrefixLabel;
        private System.Windows.Forms.TextBox BacpUpSourcePathPrefixTextBox;
        private System.Windows.Forms.Button CheckCsvProduceBnt;
    }
}

