namespace FileManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 15;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(400, 300);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.DoubleClick += new System.EventHandler(this.listBoxFiles_DoubleClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 320);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(300, 23);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(318, 320);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 350);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 381);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBoxFiles);
            this.Name = "Form1";
            this.Text = "Файловый менеджер";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
