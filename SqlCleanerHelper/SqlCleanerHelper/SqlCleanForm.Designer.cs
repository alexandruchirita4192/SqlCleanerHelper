
namespace SqlCleanerHelper
{
    partial class SqlCleanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSqlFile = new System.Windows.Forms.TextBox();
            this.tbSqlText = new System.Windows.Forms.TextBox();
            this.btnCleanFile = new System.Windows.Forms.Button();
            this.btnCleanText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSqlFile
            // 
            this.tbSqlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSqlFile.Location = new System.Drawing.Point(13, 12);
            this.tbSqlFile.Name = "tbSqlFile";
            this.tbSqlFile.ReadOnly = true;
            this.tbSqlFile.Size = new System.Drawing.Size(545, 20);
            this.tbSqlFile.TabIndex = 0;
            this.tbSqlFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSqlFile_MouseClick);
            // 
            // tbSqlText
            // 
            this.tbSqlText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSqlText.Location = new System.Drawing.Point(13, 43);
            this.tbSqlText.Multiline = true;
            this.tbSqlText.Name = "tbSqlText";
            this.tbSqlText.Size = new System.Drawing.Size(626, 242);
            this.tbSqlText.TabIndex = 1;
            // 
            // btnCleanFile
            // 
            this.btnCleanFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanFile.Location = new System.Drawing.Point(564, 10);
            this.btnCleanFile.Name = "btnCleanFile";
            this.btnCleanFile.Size = new System.Drawing.Size(75, 23);
            this.btnCleanFile.TabIndex = 3;
            this.btnCleanFile.Text = "Clean file";
            this.btnCleanFile.UseVisualStyleBackColor = true;
            this.btnCleanFile.Click += new System.EventHandler(this.btnCleanFile_Click);
            // 
            // btnCleanText
            // 
            this.btnCleanText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanText.Location = new System.Drawing.Point(564, 291);
            this.btnCleanText.Name = "btnCleanText";
            this.btnCleanText.Size = new System.Drawing.Size(75, 23);
            this.btnCleanText.TabIndex = 4;
            this.btnCleanText.Text = "Clean text";
            this.btnCleanText.UseVisualStyleBackColor = true;
            this.btnCleanText.Click += new System.EventHandler(this.btnCleanText_Click);
            // 
            // SqlCleanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 321);
            this.Controls.Add(this.btnCleanText);
            this.Controls.Add(this.btnCleanFile);
            this.Controls.Add(this.tbSqlText);
            this.Controls.Add(this.tbSqlFile);
            this.Name = "SqlCleanForm";
            this.Text = "SQL Cleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSqlFile;
        private System.Windows.Forms.TextBox tbSqlText;
        private System.Windows.Forms.Button btnCleanFile;
        private System.Windows.Forms.Button btnCleanText;
    }
}

