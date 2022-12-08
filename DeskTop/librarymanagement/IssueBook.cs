using librarymanagement.Model;
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
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetStudentsInfo name = new GetStudentsInfo();
            name.Show();
        }

        private async void Confirm_Click(object sender, EventArgs e)
        {
            borrowing br=new borrowing();
            br.book_ID = Book_ID.Text;
            br.student_ID= Student_ID.Text;
            br.date_borrowed= dateTimePicker1.Text;
            br.date_return= return_date.Text;
            br.librarian_ID = Librarian_ID.Text;
            //Console.WriteLine("book ID: " + br.book_ID + "\n" +"Student ID: " + br.student_ID + "\n" +"Date Borrowed: " + br.date_borrowed + "\n" +"Date Return: " + br.date_return + "\n" +"Librarian ID: " + br.librarian_ID + "\n");
            if (br.book_ID != null || br.student_ID != null || br.librarian_ID != null)
            {
                var response = await Controller.IssueBook(br);
                if(!response.Equals(string.Empty))
                {
                    if (response != null)
                    {
                        borrowing item = JsonConvert.DeserializeObject<borrowing>(response);
                        MessageBox.Show("BOOK ISSUED\n" +
                                        "===========\n" +
                                    "Borrowing ID: " + item.Borrowing_ID + "\n" +
                                    "Date Borrowed: " + item.date_borrowed + "\n" +
                                    "Date Return: " + item.date_return + "\n" +
                                    "Student ID: " + item.student_ID + "\n" +
                                    "Librarian ID: " + item.librarian_ID + "\n");
                    }
                }
                else
                {
                    MessageBox.Show("Book Not Issued");
                }
            }
        }

        private void Student_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Librarian_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Book_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void return_date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
