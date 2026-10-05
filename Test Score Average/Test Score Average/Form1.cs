using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void buttCalculate_Click(object sender, EventArgs e)
        {

            // Declare variables
            double score1, score2, score3;
            double total, average;

            try
            {
                //check score1 to enter number
                if (double.TryParse(txtScore1.Text, out score1))
                {
                    //check score2 to enter number
                    if (double.TryParse(txtScore2.Text, out score2))
                    {
                        //check score3 to enter number
                        if (double.TryParse(txtScore3.Text, out score3))
                        {
                            //check if score1 number range 0  100
                            if (score1 < 0 || score1 > 100)
                            {
                                MessageBox.Show("Score 1 must be between 0 and 100");
                            }
                            //check if score2 number range 0  100
                            else if (score2 < 0 || score2 > 100)
                            {
                                MessageBox.Show("Score 2 must be between 0 and 100");
                            }
                            //check if score3 number range 0  100
                            else if (score3 < 0 || score3 > 100)
                            {
                                MessageBox.Show("Score 3 must be between 0 and 100");
                            }
                            else
                            {
                                // Calculate total
                                total = score1 + score2 + score3;

                                // Calculate average
                                average = total / 3;

                                // Display average into the label
                                lblAverages.Text = average.ToString("0.00");
                            }
                        }
                        else
                        {
                            //display if score 3 are not number.
                            MessageBox.Show("Enter a number for Score 3");
                        }
                    }
                    else
                    {
                        //display if score 2 are not number.
                        MessageBox.Show("Enter a number for Score 2");
                    }
                }
                else
                {
                    //display if score 1 are not number.
                    MessageBox.Show("Enter a number for Score 1");
                }
            }
            catch
            {
                MessageBox.Show("please enter only numeric here.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            //clear the text boxes
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
            //clear the average/grade label
            lblAverages.Text = "";
        }
    }
}
