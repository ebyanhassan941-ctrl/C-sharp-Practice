using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Attendency_Information
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

        private void button1_Click(object sender, EventArgs e)
        {
            String name;
            int ID;
            String Department;
            String message="";

            try
            {
                name = txtName.Text;
                ID = int.Parse(txtID.Text);
                Department = txtDepartment.Text;

                if(name != null)
                {
                    if(int.TryParse(txtID.Text , out ID) && ID > 0)
                    {
                        if(Department != null)
                        {
                            if (radioPresent.Checked)
                            {
                                message = "Present";
                            }
                            else if (radioAbsent.Checked)
                            {
                                message = "Absent";
                            }
                            else
                            {
                                MessageBox.Show("select attendance");
                            }

                            StreamWriter writer;

                            writer = File.AppendText("C:\\Users\\hp\\Documents\\student_information\\student_info.Text");

                            writer.WriteLine("employee id:" + txtID.Text);
                            writer.WriteLine("employee name:" + txtName.Text);
                            writer.WriteLine("Department:"+txtDepartment.Text);
                            writer.WriteLine("Attendance:" + message);

                            writer.Close();
                        }
                        else
                        {
                            MessageBox.Show("deparment can not be empty");
                        }
                    }
                    else
                    {
                        MessageBox.Show("id can not be empty");
                    }
                }
                else
                {
                    MessageBox.Show("name can not be empty");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            DialogResult result;
            result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                reader = File.OpenText(openFile.FileName);

                string line;
                while(reader.EndOfStream == false)
                {
                    line = reader.ReadLine();
                    listResult.Items.Add(line);
                }
                reader.Close();
            }
            else if(result == DialogResult.Cancel)
            {
                MessageBox.Show("no save the file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listResult.SelectedIndex != -1)
            {
                listResult.Items.RemoveAt(listResult.SelectedIndex);
            }
            else
            {
                MessageBox.Show("pls select item");
            }
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtID.Clear();
            txtDepartment.Clear();
            listResult.Items.Clear();
            radioPresent.Checked = false;
            radioAbsent.Checked = false;
            
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttCounter_Click(object sender, EventArgs e)
        {
            labelCount.Text= listResult.Items.Count.ToString();
        }
    }
}
