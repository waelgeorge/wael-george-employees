using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindPairEmpWorkedAsTeamLongest.DAL;

namespace FindPairEmpWorkedAsTeamLongest.BLL
{
    public static class CSVProcessing
    {
        public static EmpProjDataComparison FindPairsWorkedAsTeamLongest(List<EmpProjData> inputLst)
        {
            var inputLst2 = inputLst;
            var result = inputLst.Join(inputLst2,
                emp1 => emp1.ProjectID,
                emp2 => emp2.ProjectID,
                (emp1, emp2) => new { fstTbl = emp1, secTbl = emp2 })
                .Where(c => int.Parse(c.fstTbl.EmployeeID) > int.Parse(c.secTbl.EmployeeID))
                .Select(s => new
                {
                    Emp1 = s.fstTbl.EmployeeID,
                    Emp2 = s.secTbl.EmployeeID,
                    s.fstTbl.ProjectID,
                    DateFrom = s.fstTbl.DateFrom > s.secTbl.DateFrom ? s.fstTbl.DateFrom : s.secTbl.DateFrom,
                    DateTo = s.fstTbl.DateTo < s.secTbl.DateTo ? s.fstTbl.DateTo : s.secTbl.DateTo,
                    DaysWorked = (((DateTime)(s.fstTbl.DateTo < s.secTbl.DateTo ? s.fstTbl.DateTo : s.secTbl.DateTo)) - (s.fstTbl.DateFrom > s.secTbl.DateFrom ? s.fstTbl.DateFrom : s.secTbl.DateFrom)).Days
                })
                .OrderByDescending(s => s.DaysWorked).ToList().FirstOrDefault();

            EmpProjDataComparison empProjDataComparison;
            if (result != null)
            {
                empProjDataComparison = new EmpProjDataComparison
                {
                    FstEmployeeID = result.Emp1,
                    SecEmployeeID = result.Emp2,
                    ProjectID = result.ProjectID,
                    WorkedDays = result.DaysWorked
                };
            }
            else
                empProjDataComparison = null;
            
            return empProjDataComparison;

        }
    }
}
