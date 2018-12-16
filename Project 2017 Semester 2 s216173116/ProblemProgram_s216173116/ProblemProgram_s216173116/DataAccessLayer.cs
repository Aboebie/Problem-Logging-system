using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProblemProgram_s216173116
{
    class DataAccessLayer
    {
        private string connString;
        SqlConnection dbConn;
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;

        public DataAccessLayer()
        {
            connString =
                "Data Source= localhost ; Initial Catalog = infoITDB; Integrated Security =SSPI";
            dbConn = new SqlConnection("Data Source= localhost ; Initial Catalog = infoITDB; Integrated Security =SSPI");

        }

        public string ConnString { get; set; }

        public int insertProblem(string date, int probPriority, string repUser, string staffID, string machID, string currDir, string probComm, string probCat, string machLD, string probStat)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string sqlInsert = "INSERT INTO Problem (ProbDateTime, ProbPriority, RepUser, StaffID, MachineID, CurrentDir, ProbComm, ProbCat, MachDrives, ProbStatus)" +
                "Values('" + date + "' , '" + probPriority + "' , '" + repUser + "' , '" + staffID + "' , '" + machID + "' , '" +  currDir + "' , '" +  probComm + "' , '" + probCat + "' , '" + machLD + "' , '" + probStat + "')";
            dbCmd = new SqlCommand(sqlInsert, dbConn);
            int x = dbCmd.ExecuteNonQuery();

            return x;
        }

        public DataTable GetStaff()
        {
            DataTable dtStaff = new DataTable();

            dbCmd = new SqlCommand("SELECT * FROM Staff", dbConn);

            dbAdapter = new SqlDataAdapter(dbCmd);

            dbAdapter.Fill(dtStaff);
            return dtStaff;
        }

        public DataTable GetSolvedProbs()
        {
            DataTable dtProbs = new DataTable();

            dbCmd = new SqlCommand("sp_GetSolvedProbs", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);

            dbAdapter.Fill(dtProbs);
            return dtProbs;
        }

        public DataTable GetProbDetails(int probID)
        {
            DataTable dtDetails = new DataTable();
            dbCmd = new SqlCommand("sp_GetDetails '" + probID + "'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);

            dbAdapter.Fill(dtDetails);
            return dtDetails;
            
        }

        public DataTable GetProbLogs(int probID)
        {
            DataTable dtLogs = new DataTable();
            dbCmd = new SqlCommand("sp_GetLogsForProblem '" + probID + "'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);

            dbAdapter.Fill(dtLogs);
            return dtLogs;
        }
        public DataTable GetCategories()
        {
            DataTable dtCategories = new DataTable();
            dbCmd = new SqlCommand("SELECT * FROM Category", dbConn);

            dbAdapter = new SqlDataAdapter(dbCmd);

            dbAdapter.Fill(dtCategories);
            return dtCategories;
        }

        public DataTable getOpenProblems()
        {
            DataTable dtOpenProbs = new DataTable();
            dbCmd = new SqlCommand("sp_GetOpenProbs", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtOpenProbs);

            return dtOpenProbs;
        }

        public DataTable getStaffProblems(string staffID)
        {
            DataTable dtStaffProbs = new DataTable();
            dbCmd = new SqlCommand("sp_GetStaffProblem '" + staffID + "'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtStaffProbs);

            return dtStaffProbs;
        }

        public int AddStaffID(int probID, string staffID, string probStat)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_UpdateProb '" + probID + "','" + staffID + "','" + probStat + "'", dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertProblemLog(int probID, string logDate,string staffID, string logComm )
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbCmd = new SqlCommand("sp_AddLog '" + probID + "','" + logDate + "','" + staffID + "','" + logComm + "'", dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }



        //GENERATE REPORTS

        public DataTable GetAllProblems()
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetAllProbs", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetWaitingProblems()
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetWaitingProbs", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetSolvedProblems()
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetSolvedProblems", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetClosedProblems()
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetClosedProbs", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetStaffProblems()
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetStaffListProblems", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetMachIDProblems()
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetMachineIDProbs", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetCatProbs()
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetCatProbs", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetHighProbs()
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetHighProblems", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetSpecificProblem()
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetDetails '1'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetProblemLogsForProblem(int probID)
        {
            DataTable dt = new DataTable();
            dbCmd = new SqlCommand("sp_GetLogs '" + probID + "'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);

            return dt;
        }
    }
}
