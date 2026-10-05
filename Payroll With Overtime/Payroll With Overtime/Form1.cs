using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_With_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttCalculate_Click(object sender, EventArgs e)
        {
         
            // Declare variables
            double hoursWorked, hourlyPayRate;
            double grossPay, overtimeHours;

            try
            {
                // Check hours worked
                if (double.TryParse(txtHoursWorked.Text, out hoursWorked))
                {
                    // Check hourly pay rate
                if (double.TryParse(txtHourlyPayRate.Text, out hourlyPayRate))
                    {
                        // Check if hours are valid
                    if (hoursWorked >= 0)
                        {
                            // Check if pay rate is valid
                       if (hourlyPayRate >= 0)
                            {
                                // Check for overtime
                          if (hoursWorked <= 40)
                                {
                                    grossPay = hoursWorked * hourlyPayRate;
                                }
                            else
                                {
                                    overtimeHours = hoursWorked - 40;

                                    grossPay = (40 * hourlyPayRate) +
                                               (overtimeHours * hourlyPayRate * 1.5);
                                }

                                // Display gross pay
                                lblGrossPay.Text = grossPay.ToString();
                            }
                          else
                            {
                                //display rate can not be negative
                                MessageBox.Show("Pay rate cannot be negative.");
                            }
                        }
                     else
                        {
                            //display hours worked can not be negative
                            MessageBox.Show("Hours worked cannot be negative.");
                        }
                    }
                    else
                    {
                        //display if you are entered negative number.
                        MessageBox.Show("Enter a valid hourly pay rate.");
                    }
                }
                else
                {
                    //display if you are enter negative number.
                    MessageBox.Show("Enter a valid number of hours.");
                }
            }
            catch
            {
                MessageBox.Show("please entered only numeric:");
            }
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
    
            // Clear all fields
            txtHoursWorked.Clear();
            txtHourlyPayRate.Clear();
            lblGrossPay.Text = "";
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
