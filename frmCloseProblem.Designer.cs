namespace ProblemProgram_s216173116
{
    partial class frmCloseProblem
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvProblems = new System.Windows.Forms.DataGridView();
            this.Close = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Close Problem";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(103, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(218, 62);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvProblems
            // 
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Close});
            this.dgvProblems.Location = new System.Drawing.Point(12, 88);
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.Size = new System.Drawing.Size(473, 319);
            this.dgvProblems.TabIndex = 36;
            // 
            // Close
            // 
            this.Close.HeaderText = "Close";
            this.Close.Name = "Close";
            this.Close.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Close.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmCloseProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 525);
            this.Controls.Add(this.dgvProblems);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "frmCloseProblem";
            this.Text = "frmCloseProblem";
            this.Load += new System.EventHandler(this.frmCloseProblem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvProblems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Close;
    }
}