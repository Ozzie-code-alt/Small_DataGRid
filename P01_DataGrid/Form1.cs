using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_DataGrid
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmStudents studentForm = new frmStudents();
            studentForm.ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBooks frmBooks = new frmBooks();
            frmBooks.ShowDialog();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            frmCOURSES frmCOURSES = new frmCOURSES();
            frmCOURSES.ShowDialog();
        }
    }
}
