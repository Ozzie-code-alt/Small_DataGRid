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
    public partial class frmCOURSES : Form
    {
        public frmCOURSES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            gridCOurse.Rows.Add(txtCTITLE.Text, txtCDescription.Text, txtCUNITS.Text);
            ClearALl();
        }

        private void ClearALl()
        {
            txtCTITLE.Clear();
            txtCDescription.Clear();
            txtCUNITS.Clear();  
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            ClearALl();
        }

        private void gridCOurse_SelectionChanged(object sender, EventArgs e)
        {
            if(gridCOurse.SelectedRows.Count > 0)
            {
                txtCTITLE.Text = gridCOurse.SelectedRows[0].Cells[0].Value.ToString(); // gets data from table and puts it back to text box
                txtCDescription.Text = gridCOurse.SelectedRows[0].Cells[1].Value.ToString(); // cell 0 because it starts from there or latest selected
                txtCUNITS.Text = gridCOurse.SelectedRows[0].Cells[2].Value.ToString(); // basically just pulling  out of data
               
            }



        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (gridCOurse.SelectedRows.Count > 0)
            {
              gridCOurse.SelectedRows[0].Cells[0].Value = txtCTITLE.Text;
               gridCOurse.SelectedRows[0].Cells[1].Value =  txtCDescription.Text;
               gridCOurse.SelectedRows[0].Cells[2].Value = txtCUNITS.Text;

            }
        }
    }
}
