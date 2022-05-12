namespace P01_DataGrid
{
    partial class frmCOURSES
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
            this.gridCOurse = new System.Windows.Forms.DataGridView();
            this.crsTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crsUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCTITLE = new System.Windows.Forms.TextBox();
            this.txtCDescription = new System.Windows.Forms.TextBox();
            this.txtCUNITS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnCLear = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCOurse)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCOurse
            // 
            this.gridCOurse.AllowUserToAddRows = false;
            this.gridCOurse.AllowUserToDeleteRows = false;
            this.gridCOurse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCOurse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.crsTitle,
            this.crsDescription,
            this.crsUnits});
            this.gridCOurse.Location = new System.Drawing.Point(231, 36);
            this.gridCOurse.Name = "gridCOurse";
            this.gridCOurse.ReadOnly = true;
            this.gridCOurse.RowHeadersWidth = 51;
            this.gridCOurse.RowTemplate.Height = 24;
            this.gridCOurse.Size = new System.Drawing.Size(528, 380);
            this.gridCOurse.TabIndex = 0;
            this.gridCOurse.SelectionChanged += new System.EventHandler(this.gridCOurse_SelectionChanged);
            // 
            // crsTitle
            // 
            this.crsTitle.HeaderText = "Course Title";
            this.crsTitle.MinimumWidth = 6;
            this.crsTitle.Name = "crsTitle";
            this.crsTitle.ReadOnly = true;
            this.crsTitle.Width = 125;
            // 
            // crsDescription
            // 
            this.crsDescription.HeaderText = "Course Description";
            this.crsDescription.MinimumWidth = 6;
            this.crsDescription.Name = "crsDescription";
            this.crsDescription.ReadOnly = true;
            this.crsDescription.Width = 125;
            // 
            // crsUnits
            // 
            this.crsUnits.HeaderText = "Units";
            this.crsUnits.MinimumWidth = 6;
            this.crsUnits.Name = "crsUnits";
            this.crsUnits.ReadOnly = true;
            this.crsUnits.Width = 125;
            // 
            // txtCTITLE
            // 
            this.txtCTITLE.Location = new System.Drawing.Point(40, 78);
            this.txtCTITLE.Name = "txtCTITLE";
            this.txtCTITLE.Size = new System.Drawing.Size(100, 22);
            this.txtCTITLE.TabIndex = 1;
            // 
            // txtCDescription
            // 
            this.txtCDescription.Location = new System.Drawing.Point(40, 167);
            this.txtCDescription.Name = "txtCDescription";
            this.txtCDescription.Size = new System.Drawing.Size(100, 22);
            this.txtCDescription.TabIndex = 2;
            // 
            // txtCUNITS
            // 
            this.txtCUNITS.Location = new System.Drawing.Point(40, 247);
            this.txtCUNITS.Name = "txtCUNITS";
            this.txtCUNITS.Size = new System.Drawing.Size(100, 22);
            this.txtCUNITS.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "COURSE TITLE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "COURSE DESCRIPTION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "UNITS:";
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(40, 310);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(104, 23);
            this.btnADD.TabIndex = 7;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnCLear
            // 
            this.btnCLear.Location = new System.Drawing.Point(40, 351);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(104, 23);
            this.btnCLear.TabIndex = 8;
            this.btnCLear.Text = "CLEAR";
            this.btnCLear.UseVisualStyleBackColor = true;
            this.btnCLear.Click += new System.EventHandler(this.btnCLear_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(40, 393);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(104, 23);
            this.btnUPDATE.TabIndex = 9;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // frmCOURSES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnCLear);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCUNITS);
            this.Controls.Add(this.txtCDescription);
            this.Controls.Add(this.txtCTITLE);
            this.Controls.Add(this.gridCOurse);
            this.Name = "frmCOURSES";
            this.Text = "frmCOURSES";
            ((System.ComponentModel.ISupportInitialize)(this.gridCOurse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCOurse;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn crsUnits;
        private System.Windows.Forms.TextBox txtCTITLE;
        private System.Windows.Forms.TextBox txtCDescription;
        private System.Windows.Forms.TextBox txtCUNITS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.Button btnUPDATE;
    }
}