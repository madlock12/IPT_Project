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
    public partial class ViewBookInfo : Form
    {
        public ViewBookInfo()
        {
            InitializeComponent();
        }

        private async void Confirm_Click(object sender, EventArgs e)
        {
            string id = Book_ID.Text;
            if (id != null)
            {
                var response = await Controller.ViewBookInfo(id);
                if (response != null)
                {
                    book item = JsonConvert.DeserializeObject<book>(response);
                    MessageBox.Show("Book ID: " + item.Book_ID+ "\n" +
                                    "Book Title: " + item.bk_title + "\n" +
                                    "Author: " + item.author + "\n" +
                                    "Publishing date: " + item.pub_date + "\n" +
                                    "Available: " + item.available + "\n");
                }
            }
        }
    }
}
