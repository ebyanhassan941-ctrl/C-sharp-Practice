using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttCalculate_Click(object sender, EventArgs e)
        {

            //declaring varibales
            double Weight;
            double Height;
            double BMI;

            try
            {
                Weight = double.Parse(txtWeight.Text);
                Height = double.Parse(txtHeight.Text);
                //check if the user input a string
                if (double.TryParse(txtWeight.Text, out Weight) && Weight > 0)
                {
                    if (double.TryParse(txtHeight.Text, out Height) && Height > 0)
                    {
                        //formula of BMI
                        BMI = Weight / (Height * Height);
                       //check BMI
                        if(BMI < 18.5)
                        {
                            MessageBox.Show("underWeight");
                        }
                        else if(BMI >= 18.5 &&  BMI <= 25)
                        {
                            MessageBox.Show("optimal weight");
                        }
                        else if(BMI > 25)
                        {
                            MessageBox.Show("overWeight");
                        }
                        //display result
                        listResult.Items.Add("your weigh is:" + Weight);
                        listResult.Items.Add("your height is :" + Height);
                        listResult.Items.Add("BMI:" + BMI.ToString("F2"));
                    }
                    else
                    {
                        MessageBox.Show("invalid input! please enter a numeric value");
                    }
                }
                else
                {
                    MessageBox.Show("invalid input! please enter a numeric value");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            //clear controls
            txtHeight.Clear();
            txtWeight.Clear();
            listResult.Items.Clear();
        }
    }
}
