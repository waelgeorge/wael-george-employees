using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPairEmpWorkedAsTeamLongest.DAL
{
    public class EmpPorjDataClassMap : ClassMap<EmpProjData>
    {
        public EmpPorjDataClassMap()
        {
            Map(c => c.EmployeeID).Name("EmpID");
            Map(c => c.ProjectID).Name("ProjectID");
            Map(c => c.DateFrom).Name("DateFrom");
            Map(c => c.DateTo).Name("DateTo").Convert(s => s.Row.GetField("DateTo").Contains("NULL") ? DateTime.Today : s.Row.GetField<DateTime?>("DateTo"));
        }
    }
}
