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
    public partial class frmEnterProblem : Form
    {
        SqlConnection dbConn;
        DataAccessLayer dl;
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;
        DataSet ds = new DataSet();
        public frmEnterProblem()
        {
            InitializeComponent();
        }

        private void frmEnterProblem_Load(object sender, EventArgs e)
        {
            dbConn = new SqlConnection("Data Source= localhost ; Initial Catalog = infoITDB; Integrated Security=SSPI");

            dl = new DataAccessLayer();

            cmbCategory.DataSource = dl.GetCategories();
            cmbCategory.DisplayMember = "CatDescription";
            cmbCategory.ValueMember = "CatID";
            

            txtUser.Text = Environment.UserName;

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
            string [] drives = Environment.GetLogicalDrives();

            int x = dl.insertProblem(DateTime.Now.ToString(), int.Parse(txtPriority.Text), txtUser.Text, "", Environment.MachineName, Environment.CurrentDirectory, txtComm.Text, cmbCategory.SelectedValue.ToString(), String.Join(",", drives), "Open");
            MessageBox.Show("Problem Added!");
            this.Close();
        }

        private void allocateProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllocateProblem fAll = new frmAllocateProblem();
            fAll.ShowDialog();
        }

        private void addProblemLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProblemLog fAdd = new frmAddProblemLog(dbConn, dbAdapter);
            fAdd.ShowDialog();
        }

        private void closeProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCloseProblem cProb = new frmCloseProblem(dbConn, dbAdapter);
            cProb.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void generateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReports fr = new frmReports(dbConn, dbAdapter);
            fr.ShowDialog();
        }

        private void generateReportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReports fr = new frmReports(dbConn, dbAdapter);
            fr.ShowDialog();
        }
    }
}
