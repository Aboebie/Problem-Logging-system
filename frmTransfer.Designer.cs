namespace ProblemProgram_s216173116
{
    partial class frmTransfer
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
            this.dgvProblemLogs = new System.Windows.Forms.DataGridView();
            this.cmbProblemID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProblemLogs
            // 
            this.dgvProblemLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblemLogs.Location = new System.Drawing.Point(37, 117);
            this.dgvProblemLogs.Name = "dgvProblemLogs";
            this.dgvProblemLogs.Size = new System.Drawing.Size(456, 208);
            this.dgvProblemLogs.TabIndex = 0;
            // 
            // cmbProblemID
            // 
            this.cmbProblemID.FormattingEnabled = true;
            this.cmbProblemID.Location = new System.Drawing.Point(136, 67);
            this.cmbProblemID.Name = "cmbProblemID";
            this.cmbProblemID.Size = new System.Drawing.Size(121, 21);
            this.cmbProblemID.TabIndex = 1;
            this.cmbProblemID.SelectedIndexChanged += new System.EventHandler(this.cmbProblemID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transfer Problem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Problem Logs";
            // 
            // cmbStaff
            // 
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(227, 384);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(121, 21);
            this.cmbStaff.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "FROM Staff ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TO Staff ID";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(406, 369);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTransfer.Size = new System.Drawing.Size(87, 36);
            this.btnTransfer.TabIndex = 7;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Problem ID";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Location = new System.Drawing.Point(78, 384);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(100, 20);
            this.txtStaffID.TabIndex = 9;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 429);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProblemID);
            this.Controls.Add(this.dgvProblemLogs);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProblemLogs;
        private System.Windows.Forms.ComboBox cmbProblemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStaffID;
    }
}