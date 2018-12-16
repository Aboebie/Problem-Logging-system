using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemProgram_s216173116
{
    class Category
    {
        private string catID;
        private string catDesc;

        public Category()
        {

        }

        public Category(string catID, string catDesc)
        {
            this.catID = catID;
            this.catDesc = catDesc;

        }

        public string CatID { get; set; }
        public string CatDesc { get; set; }

        public override string ToString()
        {
            return catID + " " + catDesc;
        }
    }
}
