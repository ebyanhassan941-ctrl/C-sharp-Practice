namespace BMI_Program
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
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listResult = new System.Windows.Forms.ListBox();
            this.buttCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.buttClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(254, 139);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(260, 38);
            this.txtWeight.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // listResult
            // 
            this.listResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 37;
            this.listResult.Location = new System.Drawing.Point(641, 29);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(378, 522);
            this.listResult.TabIndex = 2;
            this.listResult.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttCalculate
            // 
            this.buttCalculate.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCalculate.Location = new System.Drawing.Point(37, 396);
            this.buttCalculate.Name = "buttCalculate";
            this.buttCalculate.Size = new System.Drawing.Size(194, 67);
            this.buttCalculate.TabIndex = 3;
            this.buttCalculate.Text = "&Calculate";
            this.buttCalculate.UseVisualStyleBackColor = true;
            this.buttCalculate.Click += new System.EventHandler(this.buttCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(254, 207);
            this.txtHeight.Multiline = true;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(260, 38);
            this.txtHeight.TabIndex = 6;
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(309, 396);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(129, 67);
            this.buttClear.TabIndex = 7;
            this.buttClear.Text = "&Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 237);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BML Program";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 606);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttCalculate);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Button buttCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

