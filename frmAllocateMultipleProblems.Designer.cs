namespace ProblemProgram_s216173116
{
    partial class frmAllocateMultipleProblems
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
            this.dgvProblems = new System.Windows.Forms.DataGridView();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Assign = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProblems
            // 
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assign});
            this.dgvProblems.Location = new System.Drawing.Point(12, 83);
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.Size = new System.Drawing.Size(452, 252);
            this.dgvProblems.TabIndex = 0;
            this.dgvProblems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProblems_CellContentClick);
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(194, 353);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(105, 39);
            this.btnAllocate.TabIndex = 5;
            this.btnAllocate.Text = "Allocate";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(13, 39);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(121, 21);
            this.cmbStaffID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Staff ID";
            // 
            // Assign
            // 
            this.Assign.HeaderText = "Assign?";
            this.Assign.Name = "Assign";
            // 
            // frmAllocateMultipleProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStaffID);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.dgvProblems);
            this.Name = "frmAllocateMultipleProblems";
            this.Text = "frmAllocateMultipleProblems";
            this.Load += new System.EventHandler(this.frmAllocateMultipleProblems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProblems;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Assign;
    }
}