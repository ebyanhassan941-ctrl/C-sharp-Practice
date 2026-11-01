namespace Student_Course_Registration_System
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
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.listDisplay1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.buttCalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNumberOfCourse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttRemove = new System.Windows.Forms.Button();
            this.textCoursePrice = new System.Windows.Forms.TextBox();
            this.buttAdCourse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCourseName = new System.Windows.Forms.TextBox();
            this.listDisplay2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumberOfCourses = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(22, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(189, 35);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Student Name:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(251, 54);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(305, 42);
            this.textName.TabIndex = 1;
            // 
            // listDisplay1
            // 
            this.listDisplay1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisplay1.FormattingEnabled = true;
            this.listDisplay1.ItemHeight = 35;
            this.listDisplay1.Location = new System.Drawing.Point(799, 12);
            this.listDisplay1.Name = "listDisplay1";
            this.listDisplay1.Size = new System.Drawing.Size(520, 354);
            this.listDisplay1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 437);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(26, 118);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(164, 35);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Student age:";
            this.labelAge.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(26, 183);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(142, 35);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "student ID:";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(251, 118);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(305, 42);
            this.textAge.TabIndex = 6;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(251, 183);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(305, 42);
            this.textID.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.textNumberOfCourses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttClear);
            this.groupBox1.Controls.Add(this.buttExit);
            this.groupBox1.Controls.Add(this.buttCalculate);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.textAge);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.labelAge);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 377);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Infromation";
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(433, 303);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(137, 51);
            this.buttClear.TabIndex = 11;
            this.buttClear.Text = "&Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(251, 303);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(129, 51);
            this.buttExit.TabIndex = 12;
            this.buttExit.Text = "&Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // buttCalculate
            // 
            this.buttCalculate.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCalculate.Location = new System.Drawing.Point(20, 309);
            this.buttCalculate.Name = "buttCalculate";
            this.buttCalculate.Size = new System.Drawing.Size(170, 45);
            this.buttCalculate.TabIndex = 8;
            this.buttCalculate.Text = "&Calculate";
            this.buttCalculate.UseVisualStyleBackColor = true;
            this.buttCalculate.Click += new System.EventHandler(this.buttCalculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox2.Controls.Add(this.textNumberOfCourse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttRemove);
            this.groupBox2.Controls.Add(this.textCoursePrice);
            this.groupBox2.Controls.Add(this.buttAdCourse);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textCourseName);
            this.groupBox2.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 337);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course information";
            // 
            // textNumberOfCourse
            // 
            this.textNumberOfCourse.Location = new System.Drawing.Point(267, 181);
            this.textNumberOfCourse.Name = "textNumberOfCourse";
            this.textNumberOfCourse.Size = new System.Drawing.Size(172, 42);
            this.textNumberOfCourse.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "number of course:";
            // 
            // buttRemove
            // 
            this.buttRemove.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttRemove.Location = new System.Drawing.Point(251, 264);
            this.buttRemove.Name = "buttRemove";
            this.buttRemove.Size = new System.Drawing.Size(147, 58);
            this.buttRemove.TabIndex = 10;
            this.buttRemove.Text = "&Remove course";
            this.buttRemove.UseVisualStyleBackColor = true;
            this.buttRemove.Click += new System.EventHandler(this.buttRemove_Click);
            // 
            // textCoursePrice
            // 
            this.textCoursePrice.Location = new System.Drawing.Point(217, 121);
            this.textCoursePrice.Name = "textCoursePrice";
            this.textCoursePrice.Size = new System.Drawing.Size(205, 42);
            this.textCoursePrice.TabIndex = 3;
            // 
            // buttAdCourse
            // 
            this.buttAdCourse.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttAdCourse.Location = new System.Drawing.Point(19, 264);
            this.buttAdCourse.Name = "buttAdCourse";
            this.buttAdCourse.Size = new System.Drawing.Size(202, 58);
            this.buttAdCourse.TabIndex = 4;
            this.buttAdCourse.Text = "&Add course";
            this.buttAdCourse.UseVisualStyleBackColor = true;
            this.buttAdCourse.Click += new System.EventHandler(this.buttAdCourse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name:";
            // 
            // textCourseName
            // 
            this.textCourseName.Location = new System.Drawing.Point(217, 57);
            this.textCourseName.Name = "textCourseName";
            this.textCourseName.Size = new System.Drawing.Size(205, 42);
            this.textCourseName.TabIndex = 0;
            // 
            // listDisplay2
            // 
            this.listDisplay2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisplay2.FormattingEnabled = true;
            this.listDisplay2.ItemHeight = 35;
            this.listDisplay2.Location = new System.Drawing.Point(549, 420);
            this.listDisplay2.Name = "listDisplay2";
            this.listDisplay2.Size = new System.Drawing.Size(400, 354);
            this.listDisplay2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 35);
            this.label3.TabIndex = 13;
            this.label3.Text = "number of course:";
            // 
            // textNumberOfCourses
            // 
            this.textNumberOfCourses.Location = new System.Drawing.Point(259, 241);
            this.textNumberOfCourses.Name = "textNumberOfCourses";
            this.textNumberOfCourses.Size = new System.Drawing.Size(297, 42);
            this.textNumberOfCourses.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 804);
            this.Controls.Add(this.listDisplay2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listDisplay1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ListBox listDisplay1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textCoursePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCourseName;
        private System.Windows.Forms.Button buttRemove;
        private System.Windows.Forms.Button buttAdCourse;
        private System.Windows.Forms.ListBox listDisplay2;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Button buttCalculate;
        private System.Windows.Forms.TextBox textNumberOfCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNumberOfCourses;
        private System.Windows.Forms.Label label3;
    }
}

