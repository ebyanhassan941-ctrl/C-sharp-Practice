using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Course_Registration_System
{
    public partial class Form1 : Form
    {
        int maxCourses = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int age;
                string studentName = textName.Text.Trim();
                string studentID = textID.Text.Trim();

                if (int.TryParse(textAge.Text, out age))
                {
                    if (age >= 16 && age <= 60)
                    {
                        if (studentName != "" && studentID != "")
                        {
                            if (listDisplay2.Items.Count > 0)
                            {
                                decimal basicFee = 0m;
                                int i = 0;
                                while (i < listDisplay2.Items.Count)
                                {
                                    string[] parts = listDisplay2.Items[i].ToString().Split('|');
                                    basicFee += decimal.Parse(parts[1].Trim());
                                    i++;
                                }

                                int courseCount = listDisplay2.Items.Count;
                                decimal courseRate;
                                if (courseCount == 1)
                                {
                                    courseRate = 0m;
                                }
                                else if (courseCount == 2)
                                {
                                    courseRate = 0.05m;
                                }
                                else if (courseCount <= 4)
                                {
                                    courseRate = 0.10m;
                                }
                                else
                                {
                                    courseRate = 0.15m;
                                }

                                decimal courseDiscount = basicFee * courseRate;
                                decimal finalFee = basicFee - courseDiscount;


                                string status = (finalFee > 0) ? "Approved" : "Rejected";

                                listDisplay1.Items.Clear();
                                listDisplay1.Items.Add("STUDENT REGISTRATION RESULTS");
                                listDisplay1.Items.Add("==============================");
                                listDisplay1.Items.Add("Student Name : " + studentName);
                                listDisplay1.Items.Add("Student ID : " + studentID);
                                listDisplay1.Items.Add("Number of Courses : " + courseCount);
                                listDisplay1.Items.Add("------------------------------");
                                listDisplay1.Items.Add("Basic Registration Fee : " + basicFee.ToString("C2"));
                                listDisplay1.Items.Add("Course Discount :" +courseRate.ToString("0") + " " + courseDiscount.ToString("C2"));
                                listDisplay1.Items.Add("------------------------------");
                                listDisplay1.Items.Add("Final Registration Fee : " + finalFee.ToString("F2"));
                                listDisplay1.Items.Add("Registration Status : " + status);
                            }
                            else
                            {
                                MessageBox.Show("Please register at least one course.", "No Courses");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Student name and student ID cannot be empty.", "Missing Data");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student age must be between 16 and 60.", "Invalid Age");
                    }
                }
                else
                {
                    MessageBox.Show("Student age must be a whole number.", "Invalid Age");
                }
            }
            catch 
            {
                MessageBox.Show("An unexpected error occurred: ");
            }
        
        }

        private void buttAdCourse_Click(object sender, EventArgs e)
        {
        
            try
            {
                string courseName = textCourseName.Text;
                decimal coursePrice;

          
                if (courseName != "")
                {

                    if (decimal.TryParse(textCoursePrice.Text, out coursePrice))
                    {
                        if (coursePrice > 0)
                        {
                     
                            if (listDisplay2.Items.Count < maxCourses)
                            {
                                bool isDuplicate = false;
                                int index = 0;
                                while (index < listDisplay2.Items.Count && !isDuplicate)
                                {
                                    string[] parts = listDisplay2.Items[index].ToString().Split('|');
                                    string existingName = parts[0].Trim();

                                    if (existingName.Equals(courseName, StringComparison.OrdinalIgnoreCase))
                                    {
                                        isDuplicate = true;
                                    }
                                    index++;
                                }

                                if (!isDuplicate)
                                {
                                    listDisplay2.Items.Add(courseName + " = " + coursePrice.ToString("0.00"));
                                    textCourseName.Clear();
                                    textCoursePrice.Clear();
                                    textCourseName.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("This course is already registered.", "Duplicate Course");
                                    textCourseName.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("You can register a maximum of " + maxCourses + " courses.", "Limit Reached");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Course price must be greater than zero.", "Invalid Price");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Course price must be a valid number.", "Invalid Price");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the course name.");
                }
            }
            catch 
            {
                MessageBox.Show("An unexpected error occurred: ");
            }
        }
        

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textID.Clear();
            textAge.Clear();
            listDisplay1.Items.Clear();
        }

        private void buttRemove_Click(object sender, EventArgs e)
        {
        
            try
            {
                int selectedIndex = listDisplay2.SelectedIndex;

                if (selectedIndex >= 0)
                {
                    listDisplay2.Items.RemoveAt(selectedIndex);
                }
                else
                {
                    MessageBox.Show("Please select a course to remove.", "No Selection");
                }
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred: ");
            }
        }
    
    }
}
