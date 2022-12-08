using librarymanagement.Model;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagement
{
    public partial class GetStudentsInfo : Form
    {
        public GetStudentsInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private async void Confirm_Click(object sender, EventArgs e)
        {
            string id = Student_ID.Text;
           
            if (id != null)
            {
                var response = await Controller.Getstudent(id);
                if (response != null)
                {
                    student item = JsonConvert.DeserializeObject<student>(response);
                    MessageBox.Show("Student ID: " + item.Student_ID+ "\n" + 
                                    "First Name: " + item.fname+ "\n" + 
                                    "Last Name: " + item.lname + "\n" +
                                    "Gender: " + item.gender + "\n" +
                                    "Student Email: " + item.student_email + "\n");
                }
            }
        }
        private void Student_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
