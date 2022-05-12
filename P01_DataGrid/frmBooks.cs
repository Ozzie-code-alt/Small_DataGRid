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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtISBN.Text,txtTITLE.Text,txtAuthor.Text);
            ClearAll();
        }

        public void ClearAll()
        {
            txtISBN.Clear();
            txtTITLE.Clear();   
            txtAuthor.Clear();
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e) 
        {
            if (dataGridView1.SelectedRows.Count > 0) // checking if rows are > than 0 
            {
               dataGridView1.SelectedRows[0].Cells[0].Value = txtISBN.Text;
                 dataGridView1.SelectedRows[0].Cells[1].Value = txtTITLE.Text;
              dataGridView1.SelectedRows[0].Cells[2].Value = txtAuthor.Text;

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) // selection changed in events click gridbox
        {

            if (dataGridView1.SelectedRows.Count > 0) // checking if rows are > than 0
            {
                txtISBN.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); // gets data from table and puts it back to text box
                txtTITLE.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); // cell 0 because it starts from there or latest selected
                txtAuthor.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); // basically just pulling  out of data
                
            }
        }
    }
}
