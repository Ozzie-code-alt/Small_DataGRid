namespace P01_DataGrid
{
    partial class frmMenu
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
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(299, 35);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(186, 103);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "STUDENTS";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(299, 323);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(186, 95);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "BOOKS INFORMATION";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(299, 189);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(186, 93);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "COURSES";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnStudents);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCourses;
    }
}

