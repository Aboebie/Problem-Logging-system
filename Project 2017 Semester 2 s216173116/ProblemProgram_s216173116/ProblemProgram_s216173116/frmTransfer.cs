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


namespace ProblemProgram_s216173116
{
    public partial class frmTransfer : Form
    {
        SqlDataAdapter dbAdapter;
        SqlConnection dbConn;
        DataAccessLayer dl = new DataAccessLayer();
        public frmTransfer(SqlConnection dbConn, SqlDataAdapter dbAdapter)
        {
            InitializeComponent();
            this.dbConn = dbConn;
            this.dbAdapter = dbAdapter;
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            cmbProblemID.DataSource = dl.GetAllProblems();
            cmbProblemID.DisplayMember = "ProbID";
            cmbProblemID.ValueMember = "ProbID";
            cmbStaff.DataSource = dl.GetStaff();
            cmbStaff.DisplayMember = "StaffID";
            cmbStaff.ValueMember = "StaffID";

            dgvProblemLogs.DataSource = dl.GetProblemLogsForProblem(int.Parse(cmbProblemID.Text));
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                dl.AddStaffID(int.Parse(cmbProblemID.Text), cmbStaff.Text.ToString(), "Assigned");
                dl.InsertProblemLog(int.Parse(cmbProblemID.Text), Convert.ToString(DateTime.Now), cmbStaff.Text.ToString(), "Transfer to staff member");
                dgvProblemLogs.DataSource = dl.GetProblemLogsForProblem(int.Parse(cmbProblemID.Text));
                MessageBox.Show("Problem Transferred!");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("SQL exception: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void cmbProblemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                dgvProblemLogs.DataSource = dl.GetProblemLogsForProblem(int.Parse(Convert.ToString(cmbProblemID.Text)));
            }
            catch { }

        }
    }
}
