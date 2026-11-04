namespace Employee_Attendency_Information
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.buttRecord = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttView = new System.Windows.Forms.Button();
            this.buttRemove = new System.Windows.Forms.Button();
            this.buttCounter = new System.Windows.Forms.Button();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.radioPresent = new System.Windows.Forms.RadioButton();
            this.radioAbsent = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.labelCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(246, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 37);
            this.txtID.TabIndex = 1;
            // 
            // buttRecord
            // 
            this.buttRecord.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttRecord.Location = new System.Drawing.Point(16, 493);
            this.buttRecord.Name = "buttRecord";
            this.buttRecord.Size = new System.Drawing.Size(132, 78);
            this.buttRecord.TabIndex = 2;
            this.buttRecord.Text = "Record";
            this.buttRecord.UseVisualStyleBackColor = true;
            this.buttRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // listResult
            // 
            this.listResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 32;
            this.listResult.Location = new System.Drawing.Point(574, 25);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(595, 292);
            this.listResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtDepartment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 282);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // buttView
            // 
            this.buttView.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttView.Location = new System.Drawing.Point(167, 493);
            this.buttView.Name = "buttView";
            this.buttView.Size = new System.Drawing.Size(133, 78);
            this.buttView.TabIndex = 7;
            this.buttView.Text = "View from file";
            this.buttView.UseVisualStyleBackColor = true;
            this.buttView.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttRemove
            // 
            this.buttRemove.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttRemove.Location = new System.Drawing.Point(327, 493);
            this.buttRemove.Name = "buttRemove";
            this.buttRemove.Size = new System.Drawing.Size(157, 78);
            this.buttRemove.TabIndex = 8;
            this.buttRemove.Text = "Remove";
            this.buttRemove.UseVisualStyleBackColor = true;
            this.buttRemove.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttCounter
            // 
            this.buttCounter.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCounter.Location = new System.Drawing.Point(508, 493);
            this.buttCounter.Name = "buttCounter";
            this.buttCounter.Size = new System.Drawing.Size(204, 78);
            this.buttCounter.TabIndex = 9;
            this.buttCounter.Text = "Count Record";
            this.buttCounter.UseVisualStyleBackColor = true;
            this.buttCounter.Click += new System.EventHandler(this.buttCounter_Click);
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(750, 493);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(186, 78);
            this.buttClear.TabIndex = 10;
            this.buttClear.Text = "Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(1010, 493);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(175, 66);
            this.buttExit.TabIndex = 11;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(246, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 37);
            this.txtName.TabIndex = 12;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(246, 176);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(176, 37);
            this.txtDepartment.TabIndex = 13;
            // 
            // radioPresent
            // 
            this.radioPresent.AutoSize = true;
            this.radioPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPresent.Location = new System.Drawing.Point(37, 362);
            this.radioPresent.Name = "radioPresent";
            this.radioPresent.Size = new System.Drawing.Size(137, 36);
            this.radioPresent.TabIndex = 12;
            this.radioPresent.TabStop = true;
            this.radioPresent.Text = "Present";
            this.radioPresent.UseVisualStyleBackColor = true;
            // 
            // radioAbsent
            // 
            this.radioAbsent.AutoSize = true;
            this.radioAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAbsent.Location = new System.Drawing.Point(292, 362);
            this.radioAbsent.Name = "radioAbsent";
            this.radioAbsent.Size = new System.Drawing.Size(128, 36);
            this.radioAbsent.TabIndex = 13;
            this.radioAbsent.TabStop = true;
            this.radioAbsent.Text = "Absent";
            this.radioAbsent.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(0, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 132);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attendanca";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // labelCount
            // 
            this.labelCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCount.Location = new System.Drawing.Point(833, 362);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(240, 79);
            this.labelCount.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 600);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.radioAbsent);
            this.Controls.Add(this.radioPresent);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.buttCounter);
            this.Controls.Add(this.buttRemove);
            this.Controls.Add(this.buttView);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.buttRecord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button buttRecord;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button buttView;
        private System.Windows.Forms.Button buttRemove;
        private System.Windows.Forms.Button buttCounter;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.RadioButton radioPresent;
        private System.Windows.Forms.RadioButton radioAbsent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label labelCount;
    }
}

