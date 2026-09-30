using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttProcess_Click(object sender, EventArgs e)
        {
            String food, food2;
            double Total1 , total2;
            double price1, price2;
            double Tax = 0.07;
            try
            {
                food = txtfood.Text;
                food2 = txtfood2.Text;
                price1 = double.Parse(txtPrice.Text);
                price2 = double.Parse(txtPrice2.Text);

                Total1 = (price1 + price2) * Tax;
                total2 = price1 + price2 + Total1;
                lblDisplay.Text = Total1.ToString();
                lblDisplay2.Text = total2.ToString();
            }
            catch
            {
                MessageBox.Show("something you entered is wrong.");
            }
        }
    }
}
