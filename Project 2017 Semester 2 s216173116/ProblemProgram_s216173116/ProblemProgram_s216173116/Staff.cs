using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemProgram_s216173116
{
    class Staff
    {
        private string staffID;
        private string sName;
        private string fName;
        private string sRole;
        private string sUName;

        public Staff()
        {

        }
        public Staff(string staffID, string sName, string fName, string sRole, string sUName)
        {
            this.staffID =  staffID;
            this.sName = sName;
            this.fName = fName;
            this.sRole = sRole;
            this.sUName = sUName;


        }
        public string StaffID { get; set; }
        public string SName { get; set; }
        public string FName { get; set; }
        public string SRole { get; set; }
        public string SUName { get; set; }

        public override string ToString()
        {
            return fName + " " + sName;
        }
    }
}
