namespace Airline_Tricket_Booking_System
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
            this.lblName = new System.Windows.Forms.Label();
            this.buttCaulculate = new System.Windows.Forms.Button();
            this.checkBaggage = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.TravelClass = new System.Windows.Forms.GroupBox();
            this.radioBussinessClass = new System.Windows.Forms.RadioButton();
            this.radioFirstClass = new System.Windows.Forms.RadioButton();
            this.radioNormalClass = new System.Windows.Forms.RadioButton();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TravelClass.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Turquoise;
            this.lblName.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(52, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(290, 48);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Passenger Name:";
            // 
            // buttCaulculate
            // 
            this.buttCaulculate.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCaulculate.Location = new System.Drawing.Point(21, 545);
            this.buttCaulculate.Name = "buttCaulculate";
            this.buttCaulculate.Size = new System.Drawing.Size(191, 71);
            this.buttCaulculate.TabIndex = 1;
            this.buttCaulculate.Text = "Calculate";
            this.buttCaulculate.UseVisualStyleBackColor = true;
            this.buttCaulculate.Click += new System.EventHandler(this.buttCaulculate_Click);
            // 
            // checkBaggage
            // 
            this.checkBaggage.AutoSize = true;
            this.checkBaggage.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBaggage.Location = new System.Drawing.Point(43, 58);
            this.checkBaggage.Name = "checkBaggage";
            this.checkBaggage.Size = new System.Drawing.Size(542, 45);
            this.checkBaggage.TabIndex = 2;
            this.checkBaggage.Text = "Add Travel Insurance($25 per ticket)";
            this.checkBaggage.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(381, 53);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 47);
            this.txtName.TabIndex = 3;
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 48;
            this.lstDisplay.Location = new System.Drawing.Point(814, 28);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(530, 676);
            this.lstDisplay.TabIndex = 4;
            // 
            // TravelClass
            // 
            this.TravelClass.Controls.Add(this.radioBussinessClass);
            this.TravelClass.Controls.Add(this.radioFirstClass);
            this.TravelClass.Controls.Add(this.radioNormalClass);
            this.TravelClass.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelClass.Location = new System.Drawing.Point(23, 298);
            this.TravelClass.Name = "TravelClass";
            this.TravelClass.Size = new System.Drawing.Size(767, 111);
            this.TravelClass.TabIndex = 5;
            this.TravelClass.TabStop = false;
            this.TravelClass.Text = "Travel Class";
            // 
            // radioBussinessClass
            // 
            this.radioBussinessClass.AutoSize = true;
            this.radioBussinessClass.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBussinessClass.Location = new System.Drawing.Point(504, 46);
            this.radioBussinessClass.Name = "radioBussinessClass";
            this.radioBussinessClass.Size = new System.Drawing.Size(248, 45);
            this.radioBussinessClass.TabIndex = 10;
            this.radioBussinessClass.TabStop = true;
            this.radioBussinessClass.Text = "Bussiness Class";
            this.radioBussinessClass.UseVisualStyleBackColor = true;
            // 
            // radioFirstClass
            // 
            this.radioFirstClass.AutoSize = true;
            this.radioFirstClass.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFirstClass.Location = new System.Drawing.Point(53, 46);
            this.radioFirstClass.Name = "radioFirstClass";
            this.radioFirstClass.Size = new System.Drawing.Size(180, 45);
            this.radioFirstClass.TabIndex = 6;
            this.radioFirstClass.TabStop = true;
            this.radioFirstClass.Text = "First Class";
            this.radioFirstClass.UseVisualStyleBackColor = true;
            // 
            // radioNormalClass
            // 
            this.radioNormalClass.AutoSize = true;
            this.radioNormalClass.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNormalClass.Location = new System.Drawing.Point(261, 46);
            this.radioNormalClass.Name = "radioNormalClass";
            this.radioNormalClass.Size = new System.Drawing.Size(223, 45);
            this.radioNormalClass.TabIndex = 7;
            this.radioNormalClass.TabStop = true;
            this.radioNormalClass.Text = "Normal Class";
            this.radioNormalClass.UseVisualStyleBackColor = true;
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(300, 545);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(160, 71);
            this.buttClear.TabIndex = 8;
            this.buttClear.Text = "Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(566, 545);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(156, 71);
            this.buttExit.TabIndex = 9;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBaggage);
            this.groupBox2.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 109);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Options";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Turquoise;
            this.lblAge.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(52, 110);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(255, 48);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Passenger Age:";
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.BackColor = System.Drawing.Color.Turquoise;
            this.lblTicket.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(47, 173);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(317, 48);
            this.lblTicket.TabIndex = 13;
            this.lblTicket.Text = "Number Of Tricket:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Turquoise;
            this.lblWeight.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(52, 226);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(286, 48);
            this.lblWeight.TabIndex = 14;
            this.lblWeight.Text = "Baggage Weight:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(381, 108);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(330, 47);
            this.txtAge.TabIndex = 15;
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(381, 164);
            this.txtTicket.Multiline = true;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(330, 47);
            this.txtTicket.TabIndex = 16;
            this.txtTicket.TextChanged += new System.EventHandler(this.txtTicket_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(381, 217);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(330, 47);
            this.txtWeight.TabIndex = 17;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.txtTicket);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblTicket);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 288);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 786);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.TravelClass);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.buttCaulculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Airline Ticket Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TravelClass.ResumeLayout(false);
            this.TravelClass.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button buttCaulculate;
        private System.Windows.Forms.CheckBox checkBaggage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.GroupBox TravelClass;
        private System.Windows.Forms.RadioButton radioFirstClass;
        private System.Windows.Forms.RadioButton radioNormalClass;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.RadioButton radioBussinessClass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

