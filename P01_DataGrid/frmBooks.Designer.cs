namespace P01_DataGrid
{
    partial class frmBooks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTITLE = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.bookISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAUTHOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookISBN,
            this.bookTITLE,
            this.bookAUTHOR});
            this.dataGridView1.Location = new System.Drawing.Point(223, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(535, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(38, 101);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 1;
            // 
            // txtTITLE
            // 
            this.txtTITLE.Location = new System.Drawing.Point(38, 172);
            this.txtTITLE.Name = "txtTITLE";
            this.txtTITLE.Size = new System.Drawing.Size(100, 22);
            this.txtTITLE.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(38, 242);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISBN:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "TITLE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "AUTHOR:";
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(24, 300);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(132, 23);
            this.btnADD.TabIndex = 7;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.Location = new System.Drawing.Point(24, 351);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(132, 23);
            this.btnCLEAR.TabIndex = 8;
            this.btnCLEAR.Text = "CLEAR";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // bookISBN
            // 
            this.bookISBN.HeaderText = "ISBN";
            this.bookISBN.MinimumWidth = 6;
            this.bookISBN.Name = "bookISBN";
            this.bookISBN.ReadOnly = true;
            this.bookISBN.Width = 125;
            // 
            // bookTITLE
            // 
            this.bookTITLE.HeaderText = "Title";
            this.bookTITLE.MinimumWidth = 6;
            this.bookTITLE.Name = "bookTITLE";
            this.bookTITLE.ReadOnly = true;
            this.bookTITLE.Width = 125;
            // 
            // bookAUTHOR
            // 
            this.bookAUTHOR.HeaderText = "Author";
            this.bookAUTHOR.MinimumWidth = 6;
            this.bookAUTHOR.Name = "bookAUTHOR";
            this.bookAUTHOR.ReadOnly = true;
            this.bookAUTHOR.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(24, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTITLE);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBooks";
            this.Text = "frmBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTITLE;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAUTHOR;
        private System.Windows.Forms.Button btnUpdate;
    }
}