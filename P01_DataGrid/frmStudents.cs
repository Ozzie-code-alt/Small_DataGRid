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
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudAdd_Click(object sender, EventArgs e)
        {
            dataStudents.Rows.Add(txtSTudID.Text,txtStudLname.Text,txtstudFname.Text,txtStudMname.Text); // adding data to rows
            clearAll(); // executes clear functikon after butotn was pressed
        }
        private void clearAll() // clear funtion after add button

        { 
            txtSTudID.Clear();
            txtStudLname.Clear();
            txtstudFname.Clear();
            txtStudMname.Clear();
            btnStudAdd.Enabled = true; // enabled button add
            btnUPDATE.Enabled = false; // diabled button update
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll(); // clears data inputs in text box
           
        }

        private void dataStudents_SelectionChanged(object sender, EventArgs e) // selection changed in events
        {
            if(dataStudents.SelectedRows.Count > 0) // checking if rows are > than 0
            {
                txtSTudID.Text = dataStudents.SelectedRows[0].Cells[0].Value.ToString(); // gets data from table and puts it back to text box
                txtStudLname.Text = dataStudents.SelectedRows[0].Cells[1].Value.ToString(); // cell 0 because it starts from there or latest selected
                txtstudFname.Text = dataStudents.SelectedRows[0].Cells[2].Value.ToString(); // basically just pulling  out of data
                txtStudMname.Text = dataStudents.SelectedRows[0].Cells[3].Value.ToString();
                btnUPDATE.Enabled = true; // enabled button update 
                btnStudAdd.Enabled = false; // button add is false when updating forms
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if(dataStudents.SelectedRows.Count > 0) // just revers to check if textbox has data to send to data rows
            {
                dataStudents.SelectedRows[0].Cells[0].Value = txtSTudID.Text; // reverse data rows first then text box
                dataStudents.SelectedRows[0].Cells[1].Value = txtStudLname.Text;
                dataStudents.SelectedRows[0].Cells[2].Value = txtstudFname.Text;
                dataStudents.SelectedRows[0].Cells[3].Value = txtStudMname.Text;
                clearAll();
                
            }
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            btnUPDATE.Enabled = false;
        }
    }
}
