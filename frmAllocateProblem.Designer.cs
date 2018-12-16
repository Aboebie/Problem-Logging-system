namespace ProblemProgram_s216173116
{
    partial class frmAllocateProblem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProbID = new System.Windows.Forms.TextBox();
            this.txtProbComm = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProblems
            // 
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblems.Location = new System.Drawing.Point(12, 126);
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.Size = new System.Drawing.Size(524, 214);
            this.dgvProblems.TabIndex = 0;
            this.dgvProblems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProblems_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Allocate Problem";
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(33, 379);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(121, 21);
            this.cmbStaffID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Staff ID";
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(402, 360);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(105, 39);
            this.btnAllocate.TabIndex = 4;
            this.btnAllocate.Text = "Allocate";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Problem ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Problem Comment";
            // 
            // txtProbID
            // 
            this.txtProbID.Location = new System.Drawing.Point(145, 100);
            this.txtProbID.Name = "txtProbID";
            this.txtProbID.Size = new System.Drawing.Size(100, 20);
            this.txtProbID.TabIndex = 7;
            // 
            // txtProbComm
            // 
            this.txtProbComm.Location = new System.Drawing.Point(286, 100);
            this.txtProbComm.Name = "txtProbComm";
            this.txtProbComm.Size = new System.Drawing.Size(100, 20);
            this.txtProbComm.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(247, 379);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Allocate Multiple Problems";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAllocateProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtProbComm);
            this.Controls.Add(this.txtProbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProblems);
            this.Name = "frmAllocateProblem";
            this.Text = "frmAllocateProblem";
            this.Load += new System.EventHandler(this.frmAllocateProblem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProblems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProbID;
        private System.Windows.Forms.TextBox txtProbComm;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}