
namespace librarymanagement
{
    partial class ViewBookInfo
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
            this.BookID = new System.Windows.Forms.Label();
            this.Book_ID = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookID
            // 
            this.BookID.AutoSize = true;
            this.BookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BookID.Location = new System.Drawing.Point(261, 206);
            this.BookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(74, 20);
            this.BookID.TabIndex = 4;
            this.BookID.Text = "Book ID";
            // 
            // Book_ID
            // 
            this.Book_ID.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Book_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Book_ID.Location = new System.Drawing.Point(483, 206);
            this.Book_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.Size = new System.Drawing.Size(162, 13);
            this.Book_ID.TabIndex = 5;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.Confirm.Location = new System.Drawing.Point(134, 334);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(68, 28);
            this.Confirm.TabIndex = 12;
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
            this.pictureBox1.Location = new System.Drawing.Point(51, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // ViewBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(919, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Book_ID);
            this.Controls.Add(this.BookID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewBookInfo";
            this.Text = "Book Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookID;
        private System.Windows.Forms.TextBox Book_ID;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}