namespace Assingment1
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
            this.txtStudentid = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentid
            // 
            this.txtStudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentid.Location = new System.Drawing.Point(373, 166);
            this.txtStudentid.Name = "txtStudentid";
            this.txtStudentid.Size = new System.Drawing.Size(345, 35);
            this.txtStudentid.TabIndex = 0;
            this.txtStudentid.TextChanged += new System.EventHandler(this.txtstudent_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(373, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 35);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.textname_TextChanged);
            // 
            // lblOutPut
            // 
            this.lblOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutPut.Location = new System.Drawing.Point(53, 370);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(683, 93);
            this.lblOutPut.TabIndex = 4;
            this.lblOutPut.Click += new System.EventHandler(this.lblOutPut_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.Location = new System.Drawing.Point(57, 507);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(216, 54);
            this.btnShowInfo.TabIndex = 5;
            this.btnShowInfo.Text = "show_information";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(337, 507);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(165, 54);
            this.buttClear.TabIndex = 6;
            this.buttClear.Text = "clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(546, 507);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(190, 54);
            this.buttExit.TabIndex = 7;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // txtdepartment
            // 
            this.txtdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(373, 223);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(345, 35);
            this.txtdepartment.TabIndex = 1;
            this.txtdepartment.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSemester
            // 
            this.txtSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemester.Location = new System.Drawing.Point(373, 283);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(345, 35);
            this.txtSemester.TabIndex = 2;
            this.txtSemester.TextChanged += new System.EventHandler(this.txtEnter_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(48, 99);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(259, 29);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Enter the student name";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(48, 161);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(222, 29);
            this.lblstudentid.TabIndex = 9;
            this.lblstudentid.Text = "Enter the student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(48, 219);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(237, 29);
            this.lbldepartment.TabIndex = 10;
            this.lbldepartment.Text = "Enter the department";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(48, 278);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(225, 29);
            this.lblsemester.TabIndex = 11;
            this.lblsemester.Text = "Enter The semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(148, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "STUDENT INFORMATION";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtStudentid);
            this.Name = "Form1";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label label1;
    }
}

