namespace ProblemProgram_s216173116
{
    partial class frmAddProblemLog
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
            this.txtProbID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtProbComm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.btnAddProblemLog = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogComm = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProblems
            // 
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblems.Location = new System.Drawing.Point(14, 96);
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.Size = new System.Drawing.Size(313, 309);
            this.dgvProblems.TabIndex = 0;
            this.dgvProblems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProblems_CellContentClick);
            // 
            // txtProbID
            // 
            this.txtProbID.Location = new System.Drawing.Point(39, 432);
            this.txtProbID.Name = "txtProbID";
            this.txtProbID.Size = new System.Drawing.Size(100, 20);
            this.txtProbID.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(438, 112);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 5;
            // 
            // txtProbComm
            // 
            this.txtProbComm.Location = new System.Drawing.Point(209, 432);
            this.txtProbComm.Name = "txtProbComm";
            this.txtProbComm.Size = new System.Drawing.Size(100, 20);
            this.txtProbComm.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Problem ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Staff ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Log Comment";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Add Problem Log";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Problem Comment";
            // 
            // cmbStaff
            // 
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(85, 69);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(121, 21);
            this.cmbStaff.TabIndex = 14;
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.cmbStaff_SelectedIndexChanged);
            // 
            // btnAddProblemLog
            // 
            this.btnAddProblemLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProblemLog.Location = new System.Drawing.Point(410, 318);
            this.btnAddProblemLog.Name = "btnAddProblemLog";
            this.btnAddProblemLog.Size = new System.Drawing.Size(98, 69);
            this.btnAddProblemLog.TabIndex = 15;
            this.btnAddProblemLog.Text = "Add Log";
            this.btnAddProblemLog.UseVisualStyleBackColor = true;
            this.btnAddProblemLog.Click += new System.EventHandler(this.btnAddProblemLog_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(438, 221);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Problem Status";
            // 
            // txtLogComm
            // 
            this.txtLogComm.Location = new System.Drawing.Point(438, 135);
            this.txtLogComm.Name = "txtLogComm";
            this.txtLogComm.Size = new System.Drawing.Size(121, 72);
            this.txtLogComm.TabIndex = 18;
            this.txtLogComm.Text = "";
            // 
            // frmAddProblemLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 461);
            this.Controls.Add(this.txtLogComm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnAddProblemLog);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProbComm);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtProbID);
            this.Controls.Add(this.dgvProblems);
            this.Name = "frmAddProblemLog";
            this.Text = "frmAddProblemLog";
            this.Load += new System.EventHandler(this.frmAddProblemLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProblems;
        private System.Windows.Forms.TextBox txtProbID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtProbComm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Button btnAddProblemLog;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtLogComm;
    }
}