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
    public partial class frmAddProblemLog : Form
    {
        SqlConnection dbConn;
        SqlDataAdapter dbAdapter;
        DataAccessLayer dl;
        SqlCommand dbCmd;
        public frmAddProblemLog(SqlConnection dbConn, SqlDataAdapter dbAdapter)
        {
            InitializeComponent();
            this.dbConn = dbConn;
            this.dbAdapter = dbAdapter;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvProblems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProblems.SelectedCells.Count > 0)
            {
                int index = dgvProblems.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProblems.Rows[index];

                txtProbID.Text = Convert.ToString(selectedRow.Cells["ProbID"].Value);
                txtProbComm.Text = Convert.ToString(selectedRow.Cells["ProbComm"].Value);

            }
        }

        private void frmAddProblemLog_Load(object sender, EventArgs e)
        {
            dl = new DataAccessLayer();

            cmbStatus.DisplayMember = "Text";
            cmbStatus.ValueMember = "Value";

            var items = new[] {
            new { Text = "Waiting", Value = "Waiting" },
            new { Text = "Solved", Value = "Solved" }

             };
            cmbStatus.DataSource = items;

            try
            {
 

                txtDate.Text = DateTime.Now.ToString();

                cmbStaff.DataSource = dl.GetStaff();
                cmbStaff.DisplayMember = "StaffID";
                cmbStaff.ValueMember = "StaffID";
                dgvProblems.DataSource = dl.getStaffProblems(cmbStaff.SelectedValue.ToString());

                if (dgvProblems.SelectedCells.Count > 0)
                {
                    int index = dgvProblems.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgvProblems.Rows[index];

                    txtProbID.Text = Convert.ToString(selectedRow.Cells["ProbID"].Value);
                    txtProbComm.Text = Convert.ToString(selectedRow.Cells["ProbComm"].Value);

                }

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("SQL exception: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProblems.DataSource = dl.getStaffProblems(cmbStaff.SelectedValue.ToString());

            if (dgvProblems.SelectedCells.Count > 0)
            {
                int index = dgvProblems.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProblems.Rows[index];

                txtProbID.Text = Convert.ToString(selectedRow.Cells["ProbID"].Value);
                txtProbComm.Text = Convert.ToString(selectedRow.Cells["ProbComm"].Value);

            }
        }

        private void btnAddProblemLog_Click(object sender, EventArgs e)
        {
            try { 
                dl.InsertProblemLog(int.Parse(txtProbID.Text.ToString()), DateTime.Now.ToString(), cmbStaff.SelectedValue.ToString(), txtLogComm.Text.ToString());
                dl.AddStaffID(int.Parse(txtProbID.Text.ToString()), cmbStaff.SelectedValue.ToString(), cmbStatus.SelectedValue.ToString());
                MessageBox.Show("Log Added!");
                this.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("SQL exception: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
