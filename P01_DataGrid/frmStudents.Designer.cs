namespace P01_DataGrid
{
    partial class frmStudents
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
            this.dataStudents = new System.Windows.Forms.DataGridView();
            this.studID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudMname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSTudID = new System.Windows.Forms.TextBox();
            this.txtStudLname = new System.Windows.Forms.TextBox();
            this.txtstudFname = new System.Windows.Forms.TextBox();
            this.txtStudMname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStudAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStudents
            // 
            this.dataStudents.AllowUserToAddRows = false;
            this.dataStudents.AllowUserToDeleteRows = false;
            this.dataStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studID,
            this.studLname,
            this.studFname,
            this.StudMname});
            this.dataStudents.Location = new System.Drawing.Point(176, 55);
            this.dataStudents.Name = "dataStudents";
            this.dataStudents.ReadOnly = true;
            this.dataStudents.RowHeadersWidth = 51;
            this.dataStudents.RowTemplate.Height = 24;
            this.dataStudents.Size = new System.Drawing.Size(846, 466);
            this.dataStudents.TabIndex = 0;
            this.dataStudents.SelectionChanged += new System.EventHandler(this.dataStudents_SelectionChanged);
            // 
            // studID
            // 
            this.studID.HeaderText = "Student ID";
            this.studID.MinimumWidth = 6;
            this.studID.Name = "studID";
            this.studID.ReadOnly = true;
            this.studID.Width = 125;
            // 
            // studLname
            // 
            this.studLname.HeaderText = "Last Name";
            this.studLname.MinimumWidth = 6;
            this.studLname.Name = "studLname";
            this.studLname.ReadOnly = true;
            this.studLname.Width = 150;
            // 
            // studFname
            // 
            this.studFname.HeaderText = "First Name";
            this.studFname.MinimumWidth = 6;
            this.studFname.Name = "studFname";
            this.studFname.ReadOnly = true;
            this.studFname.Width = 150;
            // 
            // StudMname
            // 
            this.StudMname.HeaderText = "Middle Name";
            this.StudMname.MinimumWidth = 6;
            this.StudMname.Name = "StudMname";
            this.StudMname.ReadOnly = true;
            this.StudMname.Width = 150;
            // 
            // txtSTudID
            // 
            this.txtSTudID.Location = new System.Drawing.Point(12, 113);
            this.txtSTudID.Name = "txtSTudID";
            this.txtSTudID.Size = new System.Drawing.Size(121, 22);
            this.txtSTudID.TabIndex = 1;
            // 
            // txtStudLname
            // 
            this.txtStudLname.Location = new System.Drawing.Point(12, 206);
            this.txtStudLname.Name = "txtStudLname";
            this.txtStudLname.Size = new System.Drawing.Size(121, 22);
            this.txtStudLname.TabIndex = 2;
            // 
            // txtstudFname
            // 
            this.txtstudFname.Location = new System.Drawing.Point(12, 284);
            this.txtstudFname.Name = "txtstudFname";
            this.txtstudFname.Size = new System.Drawing.Size(121, 22);
            this.txtstudFname.TabIndex = 3;
            // 
            // txtStudMname
            // 
            this.txtStudMname.Location = new System.Drawing.Point(12, 357);
            this.txtStudMname.Name = "txtStudMname";
            this.txtStudMname.Size = new System.Drawing.Size(121, 22);
            this.txtStudMname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "MIddle Name:";
            // 
            // btnStudAdd
            // 
            this.btnStudAdd.Location = new System.Drawing.Point(12, 385);
            this.btnStudAdd.Name = "btnStudAdd";
            this.btnStudAdd.Size = new System.Drawing.Size(125, 23);
            this.btnStudAdd.TabIndex = 9;
            this.btnStudAdd.Text = "ADD";
            this.btnStudAdd.UseVisualStyleBackColor = true;
            this.btnStudAdd.Click += new System.EventHandler(this.btnStudAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(16, 484);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(121, 23);
            this.btnUPDATE.TabIndex = 11;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 545);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStudAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudMname);
            this.Controls.Add(this.txtstudFname);
            this.Controls.Add(this.txtStudLname);
            this.Controls.Add(this.txtSTudID);
            this.Controls.Add(this.dataStudents);
            this.Name = "frmStudents";
            this.Text = "STUDENTS";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStudents;
        private System.Windows.Forms.TextBox txtSTudID;
        private System.Windows.Forms.TextBox txtStudLname;
        private System.Windows.Forms.TextBox txtstudFname;
        private System.Windows.Forms.TextBox txtStudMname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStudAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn studID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn studFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudMname;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUPDATE;
    }
}