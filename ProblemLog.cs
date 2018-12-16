using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProblemProgram_s216173116
{
    class ProblemLog
    {
        private int probID;
        private string solDate;
        private string lSID;
        private string sLComm;
        DataAccessLayer dl = new DataAccessLayer();

        public ProblemLog()
        {

        }

        public ProblemLog(int probID, string solDate, string lSID, string sLComm)
        {
            this.probID = probID;
            this.solDate = solDate;
            this.lSID = lSID;
            this.sLComm = sLComm;
        }

        public int ProbID { get; set; }
        public string SolDate { get; set; }
        public string LSID { get; set; }
        public string SLComm { get; set; }

        public override string ToString()
        {
            return probID + " "  + LSID;
        }


        public int InsertProblem (int ProbID, string LogDate, string StaffID, string LogComm)
        {
            return dl.InsertProblemLog(ProbID, LogDate, StaffID, LogComm);
        }
    }
}
