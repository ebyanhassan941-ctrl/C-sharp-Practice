namespace Home_Assignment
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
            this.DayWeekLbl = new System.Windows.Forms.Label();
            this.lblNameMonth = new System.Windows.Forms.Label();
            this.lblNumeric = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.txtDayOfTheWeek = new System.Windows.Forms.TextBox();
            this.txtDayOfTheMonth = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.buttShowInfo = new System.Windows.Forms.Button();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayWeekLbl
            // 
            this.DayWeekLbl.AutoSize = true;
            this.DayWeekLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayWeekLbl.Location = new System.Drawing.Point(57, 50);
            this.DayWeekLbl.Name = "DayWeekLbl";
            this.DayWeekLbl.Size = new System.Drawing.Size(282, 29);
            this.DayWeekLbl.TabIndex = 0;
            this.DayWeekLbl.Text = "Enter the day of the week";
            // 
            // lblNameMonth
            // 
            this.lblNameMonth.AutoSize = true;
            this.lblNameMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMonth.Location = new System.Drawing.Point(46, 109);
            this.lblNameMonth.Name = "lblNameMonth";
            this.lblNameMonth.Size = new System.Drawing.Size(312, 29);
            this.lblNameMonth.TabIndex = 1;
            this.lblNameMonth.Text = "Enter the name of the month";
            // 
            // lblNumeric
            // 
            this.lblNumeric.AutoSize = true;
            this.lblNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeric.Location = new System.Drawing.Point(23, 174);
            this.lblNumeric.Name = "lblNumeric";
            this.lblNumeric.Size = new System.Drawing.Size(382, 29);
            this.lblNumeric.TabIndex = 2;
            this.lblNumeric.Text = "Enter the numeric day of the month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(98, 237);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(161, 29);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Enter the year";
            // 
            // lblOutPut
            // 
            this.lblOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutPut.Location = new System.Drawing.Point(51, 332);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(682, 104);
            this.lblOutPut.TabIndex = 4;
            // 
            // txtDayOfTheWeek
            // 
            this.txtDayOfTheWeek.Location = new System.Drawing.Point(411, 54);
            this.txtDayOfTheWeek.Name = "txtDayOfTheWeek";
            this.txtDayOfTheWeek.Size = new System.Drawing.Size(322, 26);
            this.txtDayOfTheWeek.TabIndex = 5;
            // 
            // txtDayOfTheMonth
            // 
            this.txtDayOfTheMonth.Location = new System.Drawing.Point(411, 119);
            this.txtDayOfTheMonth.Name = "txtDayOfTheMonth";
            this.txtDayOfTheMonth.Size = new System.Drawing.Size(322, 26);
            this.txtDayOfTheMonth.TabIndex = 6;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(411, 178);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(322, 26);
            this.txtMonth.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(411, 227);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(322, 26);
            this.txtYear.TabIndex = 8;
            // 
            // buttShowInfo
            // 
            this.buttShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttShowInfo.Location = new System.Drawing.Point(62, 477);
            this.buttShowInfo.Name = "buttShowInfo";
            this.buttShowInfo.Size = new System.Drawing.Size(206, 62);
            this.buttShowInfo.TabIndex = 9;
            this.buttShowInfo.Text = "Show Date";
            this.buttShowInfo.UseVisualStyleBackColor = true;
            this.buttShowInfo.Click += new System.EventHandler(this.buttShowInfo_Click);
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(330, 477);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(164, 62);
            this.buttClear.TabIndex = 10;
            this.buttClear.Text = "clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(534, 477);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(199, 62);
            this.buttExit.TabIndex = 11;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.buttShowInfo);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDayOfTheMonth);
            this.Controls.Add(this.txtDayOfTheWeek);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblNumeric);
            this.Controls.Add(this.lblNameMonth);
            this.Controls.Add(this.DayWeekLbl);
            this.Name = "Form1";
            this.Text = "Date of birth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayWeekLbl;
        private System.Windows.Forms.Label lblNameMonth;
        private System.Windows.Forms.Label lblNumeric;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.TextBox txtDayOfTheWeek;
        private System.Windows.Forms.TextBox txtDayOfTheMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button buttShowInfo;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttExit;
    }
}

