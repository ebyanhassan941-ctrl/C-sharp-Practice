namespace Payroll_With_Overtime
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
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHouWorking = new System.Windows.Forms.Label();
            this.txtHourlyPayRate = new System.Windows.Forms.TextBox();
            this.lblRatePay = new System.Windows.Forms.Label();
            this.lblGrossName = new System.Windows.Forms.Label();
            this.buttCalculate = new System.Windows.Forms.Button();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(396, 52);
            this.txtHoursWorked.Multiline = true;
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(312, 47);
            this.txtHoursWorked.TabIndex = 0;
            // 
            // lblHouWorking
            // 
            this.lblHouWorking.AutoSize = true;
            this.lblHouWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouWorking.Location = new System.Drawing.Point(102, 62);
            this.lblHouWorking.Name = "lblHouWorking";
            this.lblHouWorking.Size = new System.Drawing.Size(232, 37);
            this.lblHouWorking.TabIndex = 1;
            this.lblHouWorking.Text = "Hours Worked:";
            // 
            // txtHourlyPayRate
            // 
            this.txtHourlyPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyPayRate.Location = new System.Drawing.Point(396, 130);
            this.txtHourlyPayRate.Multiline = true;
            this.txtHourlyPayRate.Name = "txtHourlyPayRate";
            this.txtHourlyPayRate.Size = new System.Drawing.Size(312, 47);
            this.txtHourlyPayRate.TabIndex = 2;
            // 
            // lblRatePay
            // 
            this.lblRatePay.AutoSize = true;
            this.lblRatePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatePay.Location = new System.Drawing.Point(90, 140);
            this.lblRatePay.Name = "lblRatePay";
            this.lblRatePay.Size = new System.Drawing.Size(256, 37);
            this.lblRatePay.TabIndex = 4;
            this.lblRatePay.Text = "Hourly Pay Rate:";
            // 
            // lblGrossName
            // 
            this.lblGrossName.AutoSize = true;
            this.lblGrossName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossName.Location = new System.Drawing.Point(130, 221);
            this.lblGrossName.Name = "lblGrossName";
            this.lblGrossName.Size = new System.Drawing.Size(175, 37);
            this.lblGrossName.TabIndex = 5;
            this.lblGrossName.Text = "Gross Pay:";
            this.lblGrossName.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttCalculate
            // 
            this.buttCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCalculate.Location = new System.Drawing.Point(72, 320);
            this.buttCalculate.Name = "buttCalculate";
            this.buttCalculate.Size = new System.Drawing.Size(224, 89);
            this.buttCalculate.TabIndex = 6;
            this.buttCalculate.Text = "Calculate";
            this.buttCalculate.UseVisualStyleBackColor = true;
            this.buttCalculate.Click += new System.EventHandler(this.buttCalculate_Click);
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(337, 326);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(129, 83);
            this.buttClear.TabIndex = 7;
            this.buttClear.Text = "Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(518, 326);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(151, 83);
            this.buttExit.TabIndex = 8;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(396, 220);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(312, 59);
            this.lblGrossPay.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 470);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.buttCalculate);
            this.Controls.Add(this.lblGrossName);
            this.Controls.Add(this.lblRatePay);
            this.Controls.Add(this.txtHourlyPayRate);
            this.Controls.Add(this.lblHouWorking);
            this.Controls.Add(this.txtHoursWorked);
            this.Name = "Form1";
            this.Text = "Payroll With Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblHouWorking;
        private System.Windows.Forms.TextBox txtHourlyPayRate;
        private System.Windows.Forms.Label lblRatePay;
        private System.Windows.Forms.Label lblGrossName;
        private System.Windows.Forms.Button buttCalculate;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Label lblGrossPay;
    }
}

