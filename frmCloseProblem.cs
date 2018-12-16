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
    public partial class frmCloseProblem : Form
    {
        SqlDataAdapter dbAdapter;
        SqlConnection dbConn;
        SqlCommand dbCmd;
        DataAccessLayer dl;
        Problem p = new Problem();
        ProblemLog pl = new ProblemLog();
        public frmCloseProblem(SqlConnection dbConn, SqlDataAdapter dbAdapter)
        {
            InitializeComponent();
            this.dbConn = dbConn;
            this.dbAdapter = dbAdapter;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCloseProblem_Load(object sender, EventArgs e)
        {
            try {
                dbConn.Open();
            }
            catch { }
            

            
            try
            {
       
                dgvProblems.DataSource = p.GetSolvedProblems();
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

        private void btnClose_Click(object sender, EventArgs e)
        {

           
            DataAccessLayer dl = new DataAccessLayer();
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            try
            {

                for (int i = dgvProblems.Rows.Count - 1; i > 0; i--)
                {
                    DataGridViewRow row = dgvProblems.Rows[i - 1];
                    if (Convert.ToBoolean(row.Cells["Close"].Value) == true)
                    {
                        p.UpdateProblem(int.Parse(row.Cells["ProbID"].Value.ToString()), row.Cells["StaffID"].Value.ToString(), "Closed");
                        pl.InsertProblem(int.Parse(row.Cells["ProbID"].Value.ToString()), Convert.ToString(DateTime.Now), row.Cells["StaffID"].Value.ToString(), "Problem Closed");
                    }
                }


                dgvProblems.DataSource = p.GetSolvedProblems();
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
    }
}
