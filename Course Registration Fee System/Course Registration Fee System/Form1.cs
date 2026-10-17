using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_Fee_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCalculate_Click(object sender, EventArgs e)
        {
            int numberOfCourse;
            int id;
            int studyLevel;
            int transport;

            String name;
            double feecourse = 0;
            double total;
            double discountRate = 0;
            double DiscountAmount;
            double finalTotal;

            try
            {
                if(int.TryParse(txtCourse.Text, out numberOfCourse) 
                    && numberOfCourse >= 1 && numberOfCourse <= 8)
                {
                    if(int.TryParse(txtId.Text, out id))
                    {
                        if(int.TryParse(txtALvel.Text, out studyLevel)
                            && studyLevel >= 1 && studyLevel <= 4)
                        {
                            if(int.TryParse(txtTrans.Text, out transport)&& transport >= 0)
                            {
                                name = txtName.Text;
                                if (name != "") {
                                    if (studyLevel == 1)
                                    {
                                        feecourse = 40;
                                    }
                                    else if (studyLevel == 2)
                                    {
                                        feecourse = 45;
                                    }
                                    else if (studyLevel == 3) {
                                        feecourse = 50;
                                    }
                                    else if (studyLevel == 4)
                                    {
                                        feecourse = 55;
                                    }
                                    total = numberOfCourse * feecourse;

                                    if (numberOfCourse >= 6)
                                    {
                                        discountRate = 0.10;
                                    }
                                    else if (numberOfCourse == 4 || numberOfCourse == 5)
                                    {
                                        discountRate = 0.05;
                                    }
                                    DiscountAmount = total * discountRate;
                                    finalTotal = total - DiscountAmount + transport;

                                    lblDisplay.Text = "name: " + name;
                                    lblDisplay2.Text = "ID: " + id;
                                    lblDisplay3.Text = "Study level: " + studyLevel;
                                    lblDisplay4.Text = "number of courses: " + numberOfCourse;
                                    lblDisplay5.Text = "fee per course: $" + feecourse.ToString("0.00");
                                    lblDisplay6.Text = "discount amount: $ " + DiscountAmount.ToString("0.00");
                                    lblDisplay7.Text = "transport: $" + transport.ToString();
                                    lblDisplay8.Text = "final Total: $" + finalTotal.ToString("0.00");

                                }
                                else
                                {
                                    lblDisplay.Text = "Enter the name and select yes or no for both services.";
                                }
                            }
                            else
                            {
                                lblDisplay.Text = "transport must greater than 0";
                            }
                        }
                        else
                        {
                            lblDisplay.Text = "study level must be from 1 to 4";
                        }
                    }
                    else
                    {
                        lblDisplay.Text = "Enter valid ID";
                    }
                }
                else
                {
                    lblDisplay.Text = "number of course must be from 1 to 8";
                }
            }
            catch
            {
                MessageBox.Show("error:");
            }
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtId.Clear();
            txtCourse.Clear();
            txtALvel.Clear();
            txtTrans.Clear();
            lblDisplay.Text = "";
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
