namespace ReplaceNewLines
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.btnCommatizeIt = new System.Windows.Forms.Button();
            this.txtCommatized = new System.Windows.Forms.TextBox();
            this.btnSaveCommatized = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(76, 42);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(176, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select File to modify.";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(24, 83);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreview.Size = new System.Drawing.Size(287, 307);
            this.txtPreview.TabIndex = 1;
            // 
            // btnCommatizeIt
            // 
            this.btnCommatizeIt.Location = new System.Drawing.Point(317, 83);
            this.btnCommatizeIt.Name = "btnCommatizeIt";
            this.btnCommatizeIt.Size = new System.Drawing.Size(135, 29);
            this.btnCommatizeIt.TabIndex = 2;
            this.btnCommatizeIt.Text = "Commatize crlf";
            this.btnCommatizeIt.UseVisualStyleBackColor = true;
            this.btnCommatizeIt.Click += new System.EventHandler(this.btnCommatizeIt_Click);
            // 
            // txtCommatized
            // 
            this.txtCommatized.Location = new System.Drawing.Point(458, 83);
            this.txtCommatized.Multiline = true;
            this.txtCommatized.Name = "txtCommatized";
            this.txtCommatized.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommatized.Size = new System.Drawing.Size(360, 315);
            this.txtCommatized.TabIndex = 3;
            this.txtCommatized.WordWrap = false;
            // 
            // btnSaveCommatized
            // 
            this.btnSaveCommatized.Location = new System.Drawing.Point(571, 410);
            this.btnSaveCommatized.Name = "btnSaveCommatized";
            this.btnSaveCommatized.Size = new System.Drawing.Size(128, 27);
            this.btnSaveCommatized.TabIndex = 4;
            this.btnSaveCommatized.Text = "Save Commatized";
            this.btnSaveCommatized.UseVisualStyleBackColor = true;
            this.btnSaveCommatized.Click += new System.EventHandler(this.btnSaveCommatized_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 449);
            this.Controls.Add(this.btnSaveCommatized);
            this.Controls.Add(this.txtCommatized);
            this.Controls.Add(this.btnCommatizeIt);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Button btnCommatizeIt;
        private System.Windows.Forms.TextBox txtCommatized;
        private System.Windows.Forms.Button btnSaveCommatized;
    }
}

