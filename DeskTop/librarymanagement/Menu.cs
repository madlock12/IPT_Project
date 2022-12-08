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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//search student by id
        {
            GetStudentsInfo name = new GetStudentsInfo();
            name.Show();
        }
        private void button2_Click(object sender, EventArgs e)// Issue Book
        {
            IssueBook name = new IssueBook();
            name.Show();
        }

        private void button4_Click(object sender, EventArgs e)// view book info
        {
            ViewBookInfo name = new ViewBookInfo();
            name.Show();
        }

        private void button3_Click(object sender, EventArgs e)//Return Book
        {
            ReturnBook name = new ReturnBook();
            name.Show();
        }

        private void StdID_Click(object sender, EventArgs e)
        {

        }
    }
}
