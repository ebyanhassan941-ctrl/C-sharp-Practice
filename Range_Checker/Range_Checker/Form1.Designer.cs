namespace Range_Checker
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.buttCheck = new System.Windows.Forms.Button();
            this.buttClear = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(166, 127);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(316, 43);
            this.txtNumber.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(49, 27);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(404, 37);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Range Checker Application";
            // 
            // buttCheck
            // 
            this.buttCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCheck.Location = new System.Drawing.Point(81, 347);
            this.buttCheck.Name = "buttCheck";
            this.buttCheck.Size = new System.Drawing.Size(233, 122);
            this.buttCheck.TabIndex = 2;
            this.buttCheck.Text = "Check Qualification";
            this.buttCheck.UseVisualStyleBackColor = true;
            this.buttCheck.Click += new System.EventHandler(this.buttCheck_Click);
            // 
            // buttClear
            // 
            this.buttClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClear.Location = new System.Drawing.Point(354, 347);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(159, 53);
            this.buttClear.TabIndex = 3;
            this.buttClear.Text = "Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // buttExit
            // 
            this.buttExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttExit.Location = new System.Drawing.Point(354, 421);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(159, 48);
            this.buttExit.TabIndex = 4;
            this.buttExit.Text = "Exit";
            this.buttExit.UseVisualStyleBackColor = true;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.Location = new System.Drawing.Point(49, 74);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(654, 37);
            this.lblText2.TabIndex = 5;
            this.lblText2.Text = "Enter an integer in the range of 1 throught 10";
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText3.Location = new System.Drawing.Point(212, 190);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(241, 37);
            this.lblText3.TabIndex = 6;
            this.lblText3.Text = "Range Decision";
            this.lblText3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(94, 240);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(473, 74);
            this.lblDisplay.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 523);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.buttCheck);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Rnage_Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button buttCheck;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.Label lblDisplay;
    }
}

