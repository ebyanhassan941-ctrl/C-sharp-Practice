namespace Open_File_Dialog
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
            this.opem = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttCreatingNew = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opem
            // 
            this.opem.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opem.Location = new System.Drawing.Point(16, 137);
            this.opem.Name = "opem";
            this.opem.Size = new System.Drawing.Size(274, 173);
            this.opem.TabIndex = 0;
            this.opem.Text = "Open dialog";
            this.opem.UseVisualStyleBackColor = true;
            this.opem.Click += new System.EventHandler(this.opem_Click);
            // 
            // listResult
            // 
            this.listResult.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 35;
            this.listResult.Location = new System.Drawing.Point(387, 49);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(387, 494);
            this.listResult.TabIndex = 1;
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(16, 334);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(274, 102);
            this.buttClear.TabIndex = 2;
            this.buttClear.Text = "Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttCreatingNew
            // 
            this.buttCreatingNew.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCreatingNew.Location = new System.Drawing.Point(16, 442);
            this.buttCreatingNew.Name = "buttCreatingNew";
            this.buttCreatingNew.Size = new System.Drawing.Size(274, 165);
            this.buttCreatingNew.TabIndex = 3;
            this.buttCreatingNew.Text = "creating new file";
            this.buttCreatingNew.UseVisualStyleBackColor = true;
            this.buttCreatingNew.Click += new System.EventHandler(this.buttCreatingNew_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // saveFile
            // 
            this.saveFile.FileName = "saveFile";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.buttClear);
            this.groupBox1.Controls.Add(this.opem);
            this.groupBox1.Controls.Add(this.buttCreatingNew);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 620);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Dialog";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(60, 37);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(193, 61);
            this.txtInput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 654);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button opem;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttCreatingNew;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.OpenFileDialog saveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
    }
}

