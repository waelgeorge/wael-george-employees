using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindPairEmpWorkedAsTeamLongest.BLL;
using FindPairEmpWorkedAsTeamLongest.DAL;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace FindPairEmpWorkedAsTeamLongest
{
    public partial class FrmFindPairs : Form
    {
        public FrmFindPairs()
        {
            InitializeComponent();
        }

        private void BtnLoadCSV_Click(object sender, EventArgs e)
        {
            csvFileDialog.ShowDialog();
            var csvFile = csvFileDialog.OpenFile();
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                HeaderValidated = null,
                IgnoreBlankLines = true,
                TrimOptions = TrimOptions.Trim,
                MissingFieldFound = null,
            };

            List<EmpProjData> employeesInfoLst;
            using (var streamReader = new StreamReader(csvFile))
            {
                using (var csvReader = new CsvReader(streamReader, csvConfig))
                {
                    csvReader.Context.RegisterClassMap<EmpPorjDataClassMap>();                    
                    employeesInfoLst = csvReader.GetRecords<EmpProjData>().OrderBy(s => s.ProjectID).ToList();
                }
            }

            if (employeesInfoLst.Count == 0)
            {
                MessageBox.Show("No Data Found!");
                return;
            }
            List<EmpProjDataComparison> empProjDataComparisonLst = new List<EmpProjDataComparison>
            {
                CSVProcessing.FindPairsWorkedAsTeamLongest(employeesInfoLst)
            };
            dataGridView1.DataSource = empProjDataComparisonLst;            
        }
    }
}