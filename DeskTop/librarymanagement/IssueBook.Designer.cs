
namespace librarymanagement
{
    partial class IssueBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StdID = new System.Windows.Forms.Label();
            this.EmpID = new System.Windows.Forms.Label();
            this.Student_ID = new System.Windows.Forms.TextBox();
            this.Librarian_ID = new System.Windows.Forms.TextBox();
            this.borrow_date = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Label();
            this.Book_ID = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.return_date = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.returndate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StdID
            // 
            this.StdID.AutoSize = true;
            this.StdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdID.Location = new System.Drawing.Point(91, 184);
            this.StdID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StdID.Name = "StdID";
            this.StdID.Size = new System.Drawing.Size(92, 20);
            this.StdID.TabIndex = 0;
            this.StdID.Text = "StudentID";
            this.StdID.UseWaitCursor = true;
            this.StdID.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmpID
            // 
            this.EmpID.AutoSize = true;
            this.EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpID.Location = new System.Drawing.Point(91, 247);
            this.EmpID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(103, 20);
            this.EmpID.TabIndex = 1;
            this.EmpID.Text = "Librarian ID";
            this.EmpID.UseWaitCursor = true;
            // 
            // Student_ID
            // 
            this.Student_ID.Location = new System.Drawing.Point(208, 184);
            this.Student_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(151, 20);
            this.Student_ID.TabIndex = 2;
            this.Student_ID.UseWaitCursor = true;
            this.Student_ID.TextChanged += new System.EventHandler(this.Student_ID_TextChanged);
            // 
            // Librarian_ID
            // 
            this.Librarian_ID.Location = new System.Drawing.Point(208, 243);
            this.Librarian_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Librarian_ID.Name = "Librarian_ID";
            this.Librarian_ID.Size = new System.Drawing.Size(151, 20);
            this.Librarian_ID.TabIndex = 3;
            this.Librarian_ID.UseWaitCursor = true;
            this.Librarian_ID.TextChanged += new System.EventHandler(this.Librarian_ID_TextChanged);
            // 
            // borrow_date
            // 
            this.borrow_date.AutoSize = true;
            this.borrow_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_date.Location = new System.Drawing.Point(588, 243);
            this.borrow_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.borrow_date.Name = "borrow_date";
            this.borrow_date.Size = new System.Drawing.Size(133, 20);
            this.borrow_date.TabIndex = 5;
            this.borrow_date.Text = "Borrowing Date";
            this.borrow_date.UseWaitCursor = true;
            // 
            // Book
            // 
            this.Book.AutoSize = true;
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.Location = new System.Drawing.Point(595, 188);
            this.Book.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(74, 20);
            this.Book.TabIndex = 6;
            this.Book.Text = "Book ID";
            this.Book.UseWaitCursor = true;
            // 
            // Book_ID
            // 
            this.Book_ID.Location = new System.Drawing.Point(734, 188);
            this.Book_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.Size = new System.Drawing.Size(151, 20);
            this.Book_ID.TabIndex = 9;
            this.Book_ID.UseWaitCursor = true;
            this.Book_ID.TextChanged += new System.EventHandler(this.Book_ID_TextChanged);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.Confirm.Location = new System.Drawing.Point(85, 344);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(68, 28);
            this.Confirm.TabIndex = 10;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.UseWaitCursor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::librarymanagement.Properties.Resources.IPT1;
            this.pictureBox1.Location = new System.Drawing.Point(85, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // return_date
            // 
            this.return_date.Location = new System.Drawing.Point(734, 301);
            this.return_date.Margin = new System.Windows.Forms.Padding(2);
            this.return_date.Name = "return_date";
            this.return_date.Size = new System.Drawing.Size(151, 20);
            this.return_date.TabIndex = 12;
            this.return_date.UseWaitCursor = true;
            this.return_date.ValueChanged += new System.EventHandler(this.return_date_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(734, 243);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.UseWaitCursor = true;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // returndate
            // 
            this.returndate.AutoSize = true;
            this.returndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returndate.Location = new System.Drawing.Point(588, 301);
            this.returndate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(108, 20);
            this.returndate.TabIndex = 14;
            this.returndate.Text = "Return Date";
            this.returndate.UseWaitCursor = true;
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1024, 424);
            this.Controls.Add(this.returndate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.return_date);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Book_ID);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.borrow_date);
            this.Controls.Add(this.Librarian_ID);
            this.Controls.Add(this.Student_ID);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.StdID);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IssueBook";
            this.Text = "Issue book";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StdID;
        private System.Windows.Forms.Label EmpID;
        private System.Windows.Forms.TextBox Student_ID;
        private System.Windows.Forms.TextBox Librarian_ID;
        private System.Windows.Forms.Label borrow_date;
        private System.Windows.Forms.Label Book;
        private System.Windows.Forms.TextBox Book_ID;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker return_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label returndate;
    }
}

