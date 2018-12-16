using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProblemProgram_s216173116
{
    public partial class frmReports : Form
    {
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;
        SqlConnection dbConn;
        DataAccessLayer dl;
        public frmReports(SqlConnection dbConn, SqlDataAdapter dbAdapter)
        {
            InitializeComponent();
            this.dbConn = dbConn;
            this.dbAdapter = dbAdapter;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            dl = new DataAccessLayer();
            cmbReport.DisplayMember = "Text";
            cmbReport.ValueMember = "Value";

            var items = new[] {
            new { Text = "All Problems", Value = "1" },
            new { Text = "All Open Problems", Value = "2" },
            new { Text = "All Waiting Problems", Value = "3" },
            new { Text = "All Solved Problems", Value = "4" },
            new { Text = "All Closed Problems", Value = "5" },
            new { Text = "All Problems Assigned to Eugene Holt", Value = "6" },
            new { Text = "All Problems with Machine ID DESKTOP-N3DC3OR", Value = "7" },
            new { Text = "All Problems in the Hardware category", Value = "8" },
            new { Text = "All ProblemLogs for Problem 1", Value = "10" },
            new { Text = "All High Priority Problems", Value = "9" },

             };

            cmbReport.DataSource = items;

            if (Convert.ToString(cmbReport.SelectedValue) == "1")
                dgvReport.DataSource = dl.GetAllProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "2")
                dgvReport.DataSource = dl.getOpenProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "3")
                dgvReport.DataSource = dl.GetWaitingProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "4")
                dgvReport.DataSource = dl.GetSolvedProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "5")
                dgvReport.DataSource = dl.GetClosedProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "6")
                dgvReport.DataSource = dl.GetStaffProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "7")
                dgvReport.DataSource = dl.GetMachIDProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "8")
                dgvReport.DataSource = dl.GetCatProbs();
            else if (Convert.ToString(cmbReport.SelectedValue) == "9")
                dgvReport.DataSource = dl.GetHighProbs();
            else if (Convert.ToString(cmbReport.SelectedValue) == "10")
                dgvReport.DataSource = dl.GetProbLogs(int.Parse("1"));


        }

        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cmbReport.SelectedValue) == "1")
                dgvReport.DataSource = dl.GetAllProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "2")
                dgvReport.DataSource = dl.getOpenProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "3")
                dgvReport.DataSource = dl.GetWaitingProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "4")
                dgvReport.DataSource = dl.GetSolvedProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "5")
                dgvReport.DataSource = dl.GetClosedProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "6")
                dgvReport.DataSource = dl.GetStaffProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "7")
                dgvReport.DataSource = dl.GetMachIDProblems();
            else if (Convert.ToString(cmbReport.SelectedValue) == "8")
                dgvReport.DataSource = dl.GetCatProbs();
            else if (Convert.ToString(cmbReport.SelectedValue) == "9")
                dgvReport.DataSource = dl.GetHighProbs();
            else if (Convert.ToString(cmbReport.SelectedValue) == "10")
                dgvReport.DataSource = dl.GetProbLogs(int.Parse("1"));
        }
    }
}
