namespace Assingment2
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
            this.components = new System.ComponentModel.Container();
            this.txtfood = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType2 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.buttProcess = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.lblTypeFood = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfood
            // 
            this.txtfood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfood.Location = new System.Drawing.Point(409, 57);
            this.txtfood.Multiline = true;
            this.txtfood.Name = "txtfood";
            this.txtfood.Size = new System.Drawing.Size(324, 40);
            this.txtfood.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(78, 60);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(227, 37);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Enter the food:";
            this.lblType.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(78, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(242, 37);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Enter the  price:";
            this.lblPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType2.Location = new System.Drawing.Point(78, 165);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(245, 37);
            this.lblType2.TabIndex = 4;
            this.lblType2.Text = "Enter the food2:";
            this.lblType2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.Location = new System.Drawing.Point(78, 220);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(251, 37);
            this.lblPrice2.TabIndex = 5;
            this.lblPrice2.Text = "Enter the price2:";
            this.lblPrice2.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(409, 112);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(324, 40);
            this.txtPrice.TabIndex = 6;
            // 
            // txtfood2
            // 
            this.txtfood2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfood2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfood2.Location = new System.Drawing.Point(409, 165);
            this.txtfood2.Multiline = true;
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(324, 40);
            this.txtfood2.TabIndex = 7;
            // 
            // txtPrice2
            // 
            this.txtPrice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice2.Location = new System.Drawing.Point(409, 220);
            this.txtPrice2.Multiline = true;
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(324, 40);
            this.txtPrice2.TabIndex = 8;
            // 
            // buttProcess
            // 
            this.buttProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttProcess.Location = new System.Drawing.Point(225, 459);
            this.buttProcess.Name = "buttProcess";
            this.buttProcess.Size = new System.Drawing.Size(270, 52);
            this.buttProcess.TabIndex = 9;
            this.buttProcess.Text = "Calculater";
            this.buttProcess.UseVisualStyleBackColor = true;
            this.buttProcess.Click += new System.EventHandler(this.buttProcess_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(225, 291);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(508, 65);
            this.lblDisplay.TabIndex = 10;
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay2.Location = new System.Drawing.Point(225, 376);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(508, 65);
            this.lblDisplay2.TabIndex = 11;
            // 
            // lblTypeFood
            // 
            this.lblTypeFood.AutoSize = true;
            this.lblTypeFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeFood.Location = new System.Drawing.Point(47, 308);
            this.lblTypeFood.Name = "lblTypeFood";
            this.lblTypeFood.Size = new System.Drawing.Size(161, 37);
            this.lblTypeFood.TabIndex = 12;
            this.lblTypeFood.Text = "TypeFood";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(54, 392);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(131, 39);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTypeFood);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.buttProcess);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblType2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtfood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfood;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType2;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.Button buttProcess;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Label lblTypeFood;
        private System.Windows.Forms.Label lblAmount;
    }
}

