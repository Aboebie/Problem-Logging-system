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
    public partial class frmAllocateProblem : Form
    {
        SqlConnection dbConn;
        SqlCommand dbCommand;
        SqlDataAdapter dbAdapter;
        
        DataSet ds = new DataSet();
        DataAccessLayer dl;
        public frmAllocateProblem()
        {
            InitializeComponent();
           
        }

        private void frmAllocateProblem_Load(object sender, EventArgs e)
        {
            dl = new DataAccessLayer();
            dbConn = new SqlConnection("Data Source= localhost ; Initial Catalog = InfoITDB; Integrated Security=SSPI");
            try {

                dgvProblems.DataSource = dl.getOpenProblems();

                txtDate.Text = DateTime.Now.ToString();
              
                cmbStaffID.DataSource = dl.GetStaff();
                cmbStaffID.DisplayMember = "StaffID";
                cmbStaffID.ValueMember = "StaffID";

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

        private void dgvProblems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProblems.SelectedCells.Count > 0)
            {
                int index = dgvProblems.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProblems.Rows[index];

                txtProbID.Text = Convert.ToString(selectedRow.Cells["ProbID"].Value);
                txtProbComm.Text = Convert.ToString(selectedRow.Cells["ProbComm"].Value);

            }
        }

        private void dgvProblems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProblems.SelectedCells.Count > 0)
            {
                int index = dgvProblems.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvProblems.Rows[index];

                txtProbID.Text = Convert.ToString(selectedRow.Cells["ProbID"].Value);
                txtProbComm.Text = Convert.ToString(selectedRow.Cells["ProbComm"].Value);

            }
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            try
            {

                dl.AddStaffID(int.Parse(txtProbID.Text.ToString()), cmbStaffID.Text.ToString(), "Assigned");
                dl.InsertProblemLog(int.Parse(txtProbID.Text.ToString()), txtDate.Text.ToString(), cmbStaffID.Text.ToString(), "Initial Allocated Staff ID");

                MessageBox.Show("Staff ID Allocated!");
                
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmAllocateMultipleProblems mp = new frmAllocateMultipleProblems(dbConn, dbAdapter);
            mp.ShowDialog();
        }
    }
}
