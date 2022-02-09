using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPairEmpWorkedAsTeamLongest.DAL
{
    public class EmpProjData
    {
        public string EmployeeID { get; set; }
        public string ProjectID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }

    public class EmpProjDataComparison
    {
        public string FstEmployeeID { get; set; }
        public string SecEmployeeID { get; set; }
        public string ProjectID { get; set; }
        public int WorkedDays { get; set; }
    }
}
