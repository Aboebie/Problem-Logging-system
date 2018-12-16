using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace ProblemProgram_s216173116
{
    public partial class frmLogin : Form
    {
        SqlConnection dbConn;
        SqlDataAdapter dbAdapter;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dbConn = new SqlConnection("Data Source= localhost ; Initial Catalog = infoITDB; Integrated Security=SSPI");

            
            cmbUsers.DisplayMember = "Text";
            cmbUsers.ValueMember = "Value";

            var items = new[] {
            new { Text = "User", Value = "User" },
            new { Text = "Staff", Value = "Staff" },
            new { Text = "Lab Manager", Value = "Lab Manager" }
            };
            cmbUsers.DataSource = items;
            if (cmbUsers.SelectedValue.ToString() == "User")
            {
                btnEnterProblem.Visible = true;
                btnAddLog.Visible = false;
                btnAllocateProblem.Visible = false;
                btnCloseProb.Visible = false;
                btnViewReports.Visible = false;
                btnMemo.Visible = false;
            }
            else if (cmbUsers.SelectedValue.ToString() == "Staff")
            {
                btnEnterProblem.Visible = true;
                btnAddLog.Visible = true;
                btnAllocateProblem.Visible = false;
                btnCloseProb.Visible = false;
                btnViewReports.Visible = false;
                btnMemo.Visible = true;

            }
            else if (cmbUsers.SelectedValue.ToString() == "Lab Manager")
            {
                btnEnterProblem.Visible = true;
                btnAddLog.Visible = true;
                btnAllocateProblem.Visible = true;
                btnCloseProb.Visible = true;
                btnViewReports.Visible = true;
                btnMemo.Visible = true;
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedValue.ToString() == "User")
            {
                btnEnterProblem.Visible = true;
                btnAddLog.Visible = false;
                btnAllocateProblem.Visible = false;
                btnCloseProb.Visible = false;
                btnViewReports.Visible = false;
                btnMemo.Visible = true;
                btnTransfer.Visible = false;
            }
            else if (cmbUsers.SelectedValue.ToString() == "Staff")
            {
                btnEnterProblem.Visible = true;
                btnAddLog.Visible = true;
                btnAllocateProblem.Visible = false;
                btnCloseProb.Visible = false;
                btnViewReports.Visible = false;
                btnMemo.Visible = true;
                btnTransfer.Visible = false;

            }
            else if (cmbUsers.SelectedValue.ToString() == "Lab Manager")
            {
                btnEnterProblem.Visible = true;
                btnAddLog.Visible = true;
                btnAllocateProblem.Visible = true;
                btnCloseProb.Visible = true;
                btnViewReports.Visible = true;
                btnMemo.Visible = true;
                btnTransfer.Visible = true;
            }
        }

        private void btnEnterProblem_Click(object sender, EventArgs e)
        {
            frmEnterProblem en = new frmEnterProblem();
            en.ShowDialog();
        }

        private void btnAllocateProblem_Click(object sender, EventArgs e)
        {
            frmAllocateProblem fAll = new frmAllocateProblem();
            fAll.ShowDialog();
        }

        private void btnAddLog_Click(object sender, EventArgs e)
        {
            frmAddProblemLog fAdd = new frmAddProblemLog(dbConn, dbAdapter);
            fAdd.ShowDialog();
        }

        private void btnCloseProb_Click(object sender, EventArgs e)
        {
            frmCloseProblem cProb = new frmCloseProblem(dbConn, dbAdapter);
            cProb.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            frmReports fr = new frmReports(dbConn, dbAdapter);
            fr.ShowDialog();
        }

        private void btnMemo_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Users/Aboebie/Desktop/NMMU/ONT2000/! Semester 2/Practical4_s216173116/memo.txt");
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            frmTransfer frt = new frmTransfer(dbConn, dbAdapter);
            frt.ShowDialog();
        }
    }
}
