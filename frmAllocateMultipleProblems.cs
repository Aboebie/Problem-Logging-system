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
    public partial class frmAllocateMultipleProblems : Form
    {
        SqlDataAdapter dbAdapter;
        SqlConnection dbConn;
        Problem p = new Problem();
        ProblemLog pl = new ProblemLog();
        public frmAllocateMultipleProblems(SqlConnection dbConn, SqlDataAdapter dbAdapter)
        {
            InitializeComponent();
            this.dbConn = dbConn;
            this.dbAdapter = dbAdapter;
        }
        
        private void frmAllocateMultipleProblems_Load(object sender, EventArgs e)
        {
            DataAccessLayer dl = new DataAccessLayer();

            try { 
            dgvProblems.DataSource = dl.getOpenProblems();
            cmbStaffID.DataSource = dl.GetStaff();
            cmbStaffID.DisplayMember = "StaffID";
            cmbStaffID.ValueMember = "StaffID";
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

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            DataAccessLayer dl = new DataAccessLayer();
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            try
            {

                for (int i = dgvProblems.Rows.Count - 1; i > 0; i--)
                {
                    DataGridViewRow row = dgvProblems.Rows[i - 1];
                    if (Convert.ToBoolean(row.Cells["Assign"].Value) == true)
                    {
                        p.UpdateProblem(int.Parse(row.Cells["ProbID"].Value.ToString()), cmbStaffID.Text.ToString(), "Assigned");
                        pl.InsertProblem(int.Parse(row.Cells["ProbID"].Value.ToString()), DateTime.Now.ToString(), cmbStaffID.Text.ToString(), "Initial allocated staff ID");
                    }
                }

                dgvProblems.DataSource = dl.getOpenProblems();

                try 
                    {
                    frmAllocateProblem frm = new frmAllocateProblem();
                    frm.Close();
                }
                catch { }

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

        private void dgvProblems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
