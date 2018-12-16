using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProblemProgram_s216173116
{
    class Problem
    {

        private int probID;
        private string probDate;
        private int probPriority;
        private string repUser;
        private string staffID;
        private string machID;
        private string currDir;
        private string probComm;
        private string probCat;
        private string machLD;
        private string probStat;

        DataAccessLayer dl = new DataAccessLayer();

        public Problem()
        {

        }
        public Problem(int probID, string probDate, int probPriority, string repUser, string staffID, string machID, string currDir, string probComm, string probCat, string machLD, string probStat )
        {
            this.probID = probID;
            this.probDate = probDate;
            this.probPriority = probPriority;
            this.repUser = repUser;
            this.staffID = staffID;
            this.machID = machID;
            this.currDir = currDir;
            this.probComm = probComm;
            this.probCat = probCat;
            this.machLD = machLD;
            this.probStat = probStat;
        }

        public int ProbID { get; set; }
        public string ProbDate { get; set; }
        public int ProbPriority { get; set; }
        public string StaffID { get; set; }
        public string MachID { get; set; }
        public string CurrDir { get; set; }
        public string ProbComm { get; set; }
        public string ProbCat { get; set; }
        public string MachLD { get; set; }
        public string ProbStat { get; set; }

        public override string ToString()
        {
            return probID + " " + probDate;
        }

        public DataTable GetSolvedProblems()
        {
            return dl.GetSolvedProblems();
        }

        public int UpdateProblem(int ProbID, string StaffID, string ProbStat)
        {
            return dl.AddStaffID(ProbID, StaffID, ProbStat);
        }
    }
}
