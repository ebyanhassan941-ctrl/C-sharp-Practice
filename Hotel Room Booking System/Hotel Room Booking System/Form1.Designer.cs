namespace Hotel_Room_Booking_System
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
            this.PersonalInformation = new System.Windows.Forms.GroupBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.checkBreakfast = new System.Windows.Forms.CheckBox();
            this.lstBookingDetails = new System.Windows.Forms.ListBox();
            this.buttCalculate = new System.Windows.Forms.Button();
            this.AdditionalOption = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RoomType = new System.Windows.Forms.GroupBox();
            this.radioHight = new System.Windows.Forms.RadioButton();
            this.radioNormal = new System.Windows.Forms.RadioButton();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.PersonalInformation.SuspendLayout();
            this.AdditionalOption.SuspendLayout();
            this.RoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalInformation
            // 
            this.PersonalInformation.Controls.Add(this.txtGuests);
            this.PersonalInformation.Controls.Add(this.txtNights);
            this.PersonalInformation.Controls.Add(this.txtAge);
            this.PersonalInformation.Controls.Add(this.lblGuests);
            this.PersonalInformation.Controls.Add(this.lblNights);
            this.PersonalInformation.Controls.Add(this.lblAge);
            this.PersonalInformation.Controls.Add(this.txtName);
            this.PersonalInformation.Controls.Add(this.lblName);
            this.PersonalInformation.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInformation.Location = new System.Drawing.Point(12, 30);
            this.PersonalInformation.Name = "PersonalInformation";
            this.PersonalInformation.Size = new System.Drawing.Size(714, 246);
            this.PersonalInformation.TabIndex = 0;
            this.PersonalInformation.TabStop = false;
            this.PersonalInformation.Text = "Personla Information";
            this.PersonalInformation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(345, 194);
            this.txtGuests.Multiline = true;
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(333, 46);
            this.txtGuests.TabIndex = 7;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(345, 143);
            this.txtNights.Multiline = true;
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(333, 46);
            this.txtNights.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(345, 94);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(333, 46);
            this.txtAge.TabIndex = 5;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.Location = new System.Drawing.Point(32, 180);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(261, 41);
            this.lblGuests.TabIndex = 4;
            this.lblGuests.Text = "Number Of Guest:";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.Location = new System.Drawing.Point(32, 129);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(268, 41);
            this.lblNights.TabIndex = 3;
            this.lblNights.Text = "Number Of nights:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(73, 84);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(162, 41);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Guest Age:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(345, 46);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(333, 46);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(75, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(192, 41);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Guest Name:";
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Location = new System.Drawing.Point(80, 45);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(147, 39);
            this.radioStandard.TabIndex = 2;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // checkBreakfast
            // 
            this.checkBreakfast.AutoSize = true;
            this.checkBreakfast.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBreakfast.Location = new System.Drawing.Point(95, 41);
            this.checkBreakfast.Name = "checkBreakfast";
            this.checkBreakfast.Size = new System.Drawing.Size(521, 45);
            this.checkBreakfast.TabIndex = 3;
            this.checkBreakfast.Text = "BreakFast (10 per Guest Per nights)";
            this.checkBreakfast.UseVisualStyleBackColor = true;
            // 
            // lstBookingDetails
            // 
            this.lstBookingDetails.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBookingDetails.FormattingEnabled = true;
            this.lstBookingDetails.ItemHeight = 35;
            this.lstBookingDetails.Location = new System.Drawing.Point(804, 30);
            this.lstBookingDetails.Name = "lstBookingDetails";
            this.lstBookingDetails.Size = new System.Drawing.Size(370, 529);
            this.lstBookingDetails.TabIndex = 4;
            // 
            // buttCalculate
            // 
            this.buttCalculate.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCalculate.Location = new System.Drawing.Point(63, 549);
            this.buttCalculate.Name = "buttCalculate";
            this.buttCalculate.Size = new System.Drawing.Size(184, 51);
            this.buttCalculate.TabIndex = 5;
            this.buttCalculate.Text = "Calculate";
            this.buttCalculate.UseVisualStyleBackColor = true;
            this.buttCalculate.Click += new System.EventHandler(this.buttCalculate_Click);
            // 
            // AdditionalOption
            // 
            this.AdditionalOption.Controls.Add(this.groupBox3);
            this.AdditionalOption.Controls.Add(this.checkBreakfast);
            this.AdditionalOption.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalOption.Location = new System.Drawing.Point(12, 400);
            this.AdditionalOption.Name = "AdditionalOption";
            this.AdditionalOption.Size = new System.Drawing.Size(714, 106);
            this.AdditionalOption.TabIndex = 1;
            this.AdditionalOption.TabStop = false;
            this.AdditionalOption.Text = "Additional Options:";
            this.AdditionalOption.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(8, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 111);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // RoomType
            // 
            this.RoomType.Controls.Add(this.radioHight);
            this.RoomType.Controls.Add(this.radioNormal);
            this.RoomType.Controls.Add(this.radioStandard);
            this.RoomType.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomType.Location = new System.Drawing.Point(12, 282);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(714, 98);
            this.RoomType.TabIndex = 1;
            this.RoomType.TabStop = false;
            this.RoomType.Text = "Room Type:";
            // 
            // radioHight
            // 
            this.radioHight.AutoSize = true;
            this.radioHight.Location = new System.Drawing.Point(497, 45);
            this.radioHight.Name = "radioHight";
            this.radioHight.Size = new System.Drawing.Size(99, 39);
            this.radioHight.TabIndex = 4;
            this.radioHight.TabStop = true;
            this.radioHight.Text = "hight";
            this.radioHight.UseVisualStyleBackColor = true;
            // 
            // radioNormal
            // 
            this.radioNormal.AutoSize = true;
            this.radioNormal.Location = new System.Drawing.Point(294, 45);
            this.radioNormal.Name = "radioNormal";
            this.radioNormal.Size = new System.Drawing.Size(126, 39);
            this.radioNormal.TabIndex = 3;
            this.radioNormal.TabStop = true;
            this.radioNormal.Text = "Normal";
            this.radioNormal.UseVisualStyleBackColor = true;
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(322, 549);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(162, 51);
            this.buttClear.TabIndex = 6;
            this.buttClear.Text = "Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(569, 549);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(177, 54);
            this.buttExit.TabIndex = 7;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1186, 615);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.lstBookingDetails);
            this.Controls.Add(this.buttCalculate);
            this.Controls.Add(this.AdditionalOption);
            this.Controls.Add(this.RoomType);
            this.Controls.Add(this.PersonalInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PersonalInformation.ResumeLayout(false);
            this.PersonalInformation.PerformLayout();
            this.AdditionalOption.ResumeLayout(false);
            this.AdditionalOption.PerformLayout();
            this.RoomType.ResumeLayout(false);
            this.RoomType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonalInformation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.CheckBox checkBreakfast;
        private System.Windows.Forms.ListBox lstBookingDetails;
        private System.Windows.Forms.Button buttCalculate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.GroupBox AdditionalOption;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox RoomType;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton radioHight;
        private System.Windows.Forms.RadioButton radioNormal;
    }
}

