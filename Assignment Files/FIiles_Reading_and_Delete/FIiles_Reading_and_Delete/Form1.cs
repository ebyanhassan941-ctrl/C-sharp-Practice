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

namespace FIiles_Reading_and_Delete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCreateFile_Click(object sender, EventArgs e)
        {
            //import file writing file
            StreamWriter outputFile;
            //when want to file use createText function
            outputFile = File.CreateText("index.text");

            //writing file somthing
            outputFile.WriteLine("==========================================");
            outputFile.WriteLine("subjects of this course");
            outputFile.WriteLine("C#");
            outputFile.WriteLine("Data Structure Using Java");
            outputFile.WriteLine("computer Networking");
            outputFile.WriteLine("DLD");
            outputFile.WriteLine("English");
            //close the file
            outputFile.Close();
        }

        private void buttReadFile_Click(object sender, EventArgs e)
        {
            //import class for reading file
            StreamReader reader;
            reader = File.OpenText("index.text");

            // another function using reading such as ReadAllLines and this function need arrays 
            
            string[] lines = File.ReadAllLines("index.text");
            //for each loop allows us to display reading class waxa uu haayay 
            //ayado lagu shubaayo variable loopka line 
            // kadib line ayan soo daabacanayna
            foreach(string line in lines)
            {
                // display list box
                listDisplay.Items.Add(line);
            }
        }

        private void buttDeleteFile_Click(object sender, EventArgs e)
        {
            //deleting file
            File.Delete("index.text");
            MessageBox.Show("file deleted succcessfully");
        }
    }
}
