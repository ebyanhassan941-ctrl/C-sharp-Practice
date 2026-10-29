namespace FIiles_Reading_and_Delete
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
            this.buttCreateFile = new System.Windows.Forms.Button();
            this.listDisplay = new System.Windows.Forms.ListBox();
            this.buttReadFile = new System.Windows.Forms.Button();
            this.buttDeleteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttCreateFile
            // 
            this.buttCreateFile.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCreateFile.Location = new System.Drawing.Point(49, 21);
            this.buttCreateFile.Name = "buttCreateFile";
            this.buttCreateFile.Size = new System.Drawing.Size(457, 147);
            this.buttCreateFile.TabIndex = 0;
            this.buttCreateFile.Text = "Create New File";
            this.buttCreateFile.UseVisualStyleBackColor = true;
            this.buttCreateFile.Click += new System.EventHandler(this.buttCreateFile_Click);
            // 
            // listDisplay
            // 
            this.listDisplay.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.ItemHeight = 41;
            this.listDisplay.Location = new System.Drawing.Point(612, 46);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(373, 414);
            this.listDisplay.TabIndex = 1;
            // 
            // buttReadFile
            // 
            this.buttReadFile.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttReadFile.Location = new System.Drawing.Point(49, 221);
            this.buttReadFile.Name = "buttReadFile";
            this.buttReadFile.Size = new System.Drawing.Size(457, 147);
            this.buttReadFile.TabIndex = 2;
            this.buttReadFile.Text = "Read File";
            this.buttReadFile.UseVisualStyleBackColor = true;
            this.buttReadFile.Click += new System.EventHandler(this.buttReadFile_Click);
            // 
            // buttDeleteFile
            // 
            this.buttDeleteFile.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttDeleteFile.Location = new System.Drawing.Point(49, 434);
            this.buttDeleteFile.Name = "buttDeleteFile";
            this.buttDeleteFile.Size = new System.Drawing.Size(457, 147);
            this.buttDeleteFile.TabIndex = 3;
            this.buttDeleteFile.Text = "Delete File";
            this.buttDeleteFile.UseVisualStyleBackColor = true;
            this.buttDeleteFile.Click += new System.EventHandler(this.buttDeleteFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 623);
            this.Controls.Add(this.buttDeleteFile);
            this.Controls.Add(this.buttReadFile);
            this.Controls.Add(this.listDisplay);
            this.Controls.Add(this.buttCreateFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttCreateFile;
        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.Button buttReadFile;
        private System.Windows.Forms.Button buttDeleteFile;
    }
}

