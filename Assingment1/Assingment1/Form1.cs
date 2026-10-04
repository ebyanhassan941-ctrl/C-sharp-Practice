using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment1
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtstudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            string NameStudent, Department, Outbut;
            int Semester;
            int StudentID;
            NameStudent = txtName.Text;
            StudentID = int.Parse(txtStudentid.Text);
            Department = txtdepartment.Text;
            Semester = int.Parse(txtSemester.Text);
            Outbut = txtName + " " + StudentID + " " + Department + " " + Semester;
            lblOutPut.Text = Outbut;
        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtStudentid.Text = "";
            txtdepartment.Text = string.Empty;
            txtSemester.Clear();
            lblOutPut.Text = "";
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOutPut_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
