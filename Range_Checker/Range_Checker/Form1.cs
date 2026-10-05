using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttCheck_Click(object sender, EventArgs e)
        {
           //declare variables
            int number;
            try
            {
                //check the number it can be only numeric.
                if (int.TryParse(txtNumber.Text, out number))
                {
                    //check the number is range 1 out of 10
                    if (number >= 1 && number <= 10)
                    {
                        lblDisplay.Text = "This number is in range.";
                    }
                    else
                    {
                        //display if the number out of 10
                        lblDisplay.Text = "This number is out of range.";
                    }
                }
                else
                {
                    //display if the button entered something are not number.
                    lblDisplay.Text = "Please enter a valid integer.";
                }
            }
            catch
            {
                //display if the input are not number.
                MessageBox.Show("please only number.");
            }
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            // clear the label/text
            txtNumber.Clear();
            lblDisplay.Text = "";
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
