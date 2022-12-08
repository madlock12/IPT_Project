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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private async void Confirm_Click(object sender, EventArgs e)
        {
            borrowing br = new borrowing();
            br.Borrowing_ID = Borrowing_ID.Text;
            br.book_ID = Book_ID.Text;
            br.date_borrowed = "string";
            br.date_return = "string";
            br.student_ID = "3fa85f64-5717-4562-b3fc-2c963f66afa6";
            br.librarian_ID = "3fa85f64-5717-4562-b3fc-2c963f66afa6";
            if (br.book_ID != null || br.Borrowing_ID != null)
            {
                var response = await Controller.ReturnBook(br);
                if (!response.Equals(string.Empty))
                {
                    if (response != null)
                    {
                        borrowing item = JsonConvert.DeserializeObject<borrowing>(response);
                        MessageBox.Show("BOOK Returned\n" +
                                        "=============\n" +
                                    "Borrowing ID: " + item.Borrowing_ID + "\n" +
                                    "Date Borrowed: " + item.date_borrowed + "\n" +
                                    "Date Return: " + item.date_return + "\n" +
                                    "Student ID: " + item.student_ID + "\n" +
                                    "Librarian ID: " + item.librarian_ID + "\n");
                    }
                }
                else
                {
                    MessageBox.Show("Book Not Returned");
                }
            }
        }

        private void Borrowing_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Book_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
