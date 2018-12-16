namespace ProblemProgram_s216173116
{
    partial class frmLogin
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
            this.btnAllocateProblem = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnterProblem = new System.Windows.Forms.Button();
            this.btnCloseProb = new System.Windows.Forms.Button();
            this.btnAddLog = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnMemo = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAllocateProblem
            // 
            this.btnAllocateProblem.Location = new System.Drawing.Point(69, 146);
            this.btnAllocateProblem.Name = "btnAllocateProblem";
            this.btnAllocateProblem.Size = new System.Drawing.Size(145, 23);
            this.btnAllocateProblem.TabIndex = 0;
            this.btnAllocateProblem.Text = "Allocate Problem";
            this.btnAllocateProblem.UseVisualStyleBackColor = true;
            this.btnAllocateProblem.Visible = false;
            this.btnAllocateProblem.Click += new System.EventHandler(this.btnAllocateProblem_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(81, 71);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 21);
            this.cmbUsers.TabIndex = 1;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // btnEnterProblem
            // 
            this.btnEnterProblem.Location = new System.Drawing.Point(69, 117);
            this.btnEnterProblem.Name = "btnEnterProblem";
            this.btnEnterProblem.Size = new System.Drawing.Size(145, 23);
            this.btnEnterProblem.TabIndex = 4;
            this.btnEnterProblem.Text = "Enter Problem";
            this.btnEnterProblem.UseVisualStyleBackColor = true;
            this.btnEnterProblem.Visible = false;
            this.btnEnterProblem.Click += new System.EventHandler(this.btnEnterProblem_Click);
            // 
            // btnCloseProb
            // 
            this.btnCloseProb.Location = new System.Drawing.Point(69, 203);
            this.btnCloseProb.Name = "btnCloseProb";
            this.btnCloseProb.Size = new System.Drawing.Size(145, 23);
            this.btnCloseProb.TabIndex = 5;
            this.btnCloseProb.Text = "Close Problem";
            this.btnCloseProb.UseVisualStyleBackColor = true;
            this.btnCloseProb.Visible = false;
            this.btnCloseProb.Click += new System.EventHandler(this.btnCloseProb_Click);
            // 
            // btnAddLog
            // 
            this.btnAddLog.Location = new System.Drawing.Point(69, 174);
            this.btnAddLog.Name = "btnAddLog";
            this.btnAddLog.Size = new System.Drawing.Size(145, 23);
            this.btnAddLog.TabIndex = 6;
            this.btnAddLog.Text = "Add Problem Logs";
            this.btnAddLog.UseVisualStyleBackColor = true;
            this.btnAddLog.Visible = false;
            this.btnAddLog.Click += new System.EventHandler(this.btnAddLog_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.Location = new System.Drawing.Point(69, 232);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(145, 23);
            this.btnViewReports.TabIndex = 7;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Visible = false;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // btnMemo
            // 
            this.btnMemo.Location = new System.Drawing.Point(69, 262);
            this.btnMemo.Name = "btnMemo";
            this.btnMemo.Size = new System.Drawing.Size(145, 23);
            this.btnMemo.TabIndex = 8;
            this.btnMemo.Text = "Add memo";
            this.btnMemo.UseVisualStyleBackColor = true;
            this.btnMemo.Visible = false;
            this.btnMemo.Click += new System.EventHandler(this.btnMemo_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(69, 291);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(145, 23);
            this.btnTransfer.TabIndex = 9;
            this.btnTransfer.Text = "Transfer Problems";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Visible = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnMemo);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnAddLog);
            this.Controls.Add(this.btnCloseProb);
            this.Controls.Add(this.btnEnterProblem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.btnAllocateProblem);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllocateProblem;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnterProblem;
        private System.Windows.Forms.Button btnCloseProb;
        private System.Windows.Forms.Button btnAddLog;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnMemo;
        private System.Windows.Forms.Button btnTransfer;
    }
}