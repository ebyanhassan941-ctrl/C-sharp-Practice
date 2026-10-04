using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttShowInfo_Click(object sender, EventArgs e)
        {
            //creating variable 
            String dayOf_week, name_of_month, Full_Date;
            int numeric_Day;
            int Year;
            //intiation values variable
            dayOf_week = txtDayOfTheWeek.Text;
            name_of_month = txtDayOfTheMonth.Text;
            numeric_Day = int.Parse(txtMonth.Text);
            Year = int.Parse(txtYear.Text);

            //concataninate
            Full_Date = dayOf_week + " " + name_of_month + " " + numeric_Day + " " + Year;
            
            //display the result
            lblOutPut.Text = Full_Date;
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            //clearing textbox and label
            txtDayOfTheWeek.Clear();
            txtDayOfTheMonth.Text = "";
            txtMonth.Text = string.Empty;
            txtYear.Clear();
            //clearing label
            //clearing label - not used clear function
            lblOutPut.Text = "";
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
