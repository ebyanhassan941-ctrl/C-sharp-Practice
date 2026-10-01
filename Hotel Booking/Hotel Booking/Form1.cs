using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Booking
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

        private void buttCalculate_Click(object sender, EventArgs e)
        {
            //declaring variables
            string guestName, roomType;
            double nights, priceNight;
            double Tax = 0.10;
            double Discount = 0.05;
            double roomCost, serviceTax, discountAmount, totalAmount;
            // try find place error accur
            try
            {
                //initilization variables
                guestName = txtName.Text;
                roomType = txtRoom.Text;
                nights = double.Parse(txtNight.Text);
                priceNight = double.Parse(txtPerDay.Text);

                // process the Amount
                roomCost = nights * priceNight;
                serviceTax = roomCost * Tax;
                discountAmount = roomCost * Discount;
                totalAmount = roomCost + serviceTax - discountAmount;

                //display the total amount our service
                lblServices.Text = serviceTax.ToString();
                lblDiscounts.Text = discountAmount.ToString();
                lblAmounts.Text = totalAmount.ToString();
            }
            // when found error they display message
            catch
            {
                MessageBox.Show("Something you entered is wrong.");
            }
        }
    }
}
