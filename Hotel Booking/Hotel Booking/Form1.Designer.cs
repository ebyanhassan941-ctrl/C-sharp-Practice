namespace Hotel_Booking
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttCalculate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtNight = new System.Windows.Forms.TextBox();
            this.txtPerDay = new System.Windows.Forms.TextBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblDiscounts = new System.Windows.Forms.Label();
            this.lblAmounts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(39, 31);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(278, 37);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter guest name:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(39, 82);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(275, 37);
            this.lblRoom.TabIndex = 1;
            this.lblRoom.Text = "Enter Room Type:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(39, 132);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(370, 37);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Enter Number Of Nights:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(39, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(326, 37);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Enter Price Per Nigth:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(27, 369);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(147, 32);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Srvice Tax";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(27, 431);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(230, 32);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Discount Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Amount";
            // 
            // buttCalculate
            // 
            this.buttCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCalculate.Location = new System.Drawing.Point(280, 262);
            this.buttCalculate.Name = "buttCalculate";
            this.buttCalculate.Size = new System.Drawing.Size(248, 88);
            this.buttCalculate.TabIndex = 7;
            this.buttCalculate.Text = "Calculate";
            this.buttCalculate.UseVisualStyleBackColor = true;
            this.buttCalculate.Click += new System.EventHandler(this.buttCalculate_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(439, 31);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(316, 45);
            this.txtName.TabIndex = 8;
            // 
            // txtRoom
            // 
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(439, 93);
            this.txtRoom.Multiline = true;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(316, 44);
            this.txtRoom.TabIndex = 9;
            // 
            // txtNight
            // 
            this.txtNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNight.Location = new System.Drawing.Point(439, 143);
            this.txtNight.Multiline = true;
            this.txtNight.Name = "txtNight";
            this.txtNight.Size = new System.Drawing.Size(316, 38);
            this.txtNight.TabIndex = 10;
            // 
            // txtPerDay
            // 
            this.txtPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerDay.Location = new System.Drawing.Point(439, 201);
            this.txtPerDay.Multiline = true;
            this.txtPerDay.Name = "txtPerDay";
            this.txtPerDay.Size = new System.Drawing.Size(316, 39);
            this.txtPerDay.TabIndex = 11;
            // 
            // lblServices
            // 
            this.lblServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(319, 369);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(421, 48);
            this.lblServices.TabIndex = 12;
            // 
            // lblDiscounts
            // 
            this.lblDiscounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscounts.Location = new System.Drawing.Point(319, 431);
            this.lblDiscounts.Name = "lblDiscounts";
            this.lblDiscounts.Size = new System.Drawing.Size(421, 52);
            this.lblDiscounts.TabIndex = 13;
            // 
            // lblAmounts
            // 
            this.lblAmounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmounts.Location = new System.Drawing.Point(319, 497);
            this.lblAmounts.Name = "lblAmounts";
            this.lblAmounts.Size = new System.Drawing.Size(421, 55);
            this.lblAmounts.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.lblAmounts);
            this.Controls.Add(this.lblDiscounts);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.txtPerDay);
            this.Controls.Add(this.txtNight);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.buttCalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttCalculate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtNight;
        private System.Windows.Forms.TextBox txtPerDay;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblDiscounts;
        private System.Windows.Forms.Label lblAmounts;
    }
}

