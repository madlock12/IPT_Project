
namespace librarymanagement
{
    partial class GetStudentsInfo
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
            this.Student_ID = new System.Windows.Forms.TextBox();
            this.StdID = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_ID
            // 
            this.Student_ID.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Student_ID.Location = new System.Drawing.Point(398, 169);
            this.Student_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(151, 20);
            this.Student_ID.TabIndex = 4;
            this.Student_ID.UseWaitCursor = true;
            this.Student_ID.TextChanged += new System.EventHandler(this.Student_ID_TextChanged);
            // 
            // StdID
            // 
            this.StdID.AutoSize = true;
            this.StdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdID.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.StdID.Location = new System.Drawing.Point(229, 169);
            this.StdID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StdID.Name = "StdID";
            this.StdID.Size = new System.Drawing.Size(92, 20);
            this.StdID.TabIndex = 3;
            this.StdID.Text = "StudentID";
            this.StdID.UseWaitCursor = true;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.SystemColors.Control;
            this.Confirm.Location = new System.Drawing.Point(101, 291);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(68, 28);
            this.Confirm.TabIndex = 11;
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
            this.pictureBox1.Location = new System.Drawing.Point(52, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // GetStudentsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(829, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Student_ID);
            this.Controls.Add(this.StdID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GetStudentsInfo";
            this.Text = "Students Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Student_ID;
        private System.Windows.Forms.Label StdID;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}