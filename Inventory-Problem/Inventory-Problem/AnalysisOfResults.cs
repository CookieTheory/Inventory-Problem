using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Problem
{
    public partial class AnalysisOfResults : Form
    {
        private readonly DataTable dt = new();
        private decimal[,]? analysisTable;
        public AnalysisOfResults()
        {
            InitializeComponent();
        }

        private void AnalysisOfResults_Load(object sender, EventArgs e)
        {

            AddColumns();
            CreateAnalysisTable();
            CalculateAnalysis();
        }

        private void AddColumns()
        {
            dt.Columns.Add(Properties.strings.OtherPeriod, typeof(decimal));
            dt.Columns.Add("I(i-1)", typeof(decimal));
            dt.Columns.Add("Q(i)", typeof(decimal));
            dt.Columns.Add("D(i)", typeof(decimal));
            dt.Columns.Add("I(i)", typeof(decimal));
            dt.Columns.Add("Cp(i)", typeof(decimal));
            dt.Columns.Add("Ch(1)", typeof(decimal));
        }

        private void CreateAnalysisTable()
        {
            int height = MainForm.table.GetLength(0);
            analysisTable = new decimal[height + 2, 7];
            for (int i = 0; i < height; i++)
            {
                analysisTable[0, i] = (decimal)i + 1;
            }
        }

        private void CalculateAnalysis()
        {
            CalculateOptimalProcurements();
            CalculateCosts();
            ShowTable();
        }

        private void CalculateOptimalProcurements()
        {
            analysisTable[0, 1] = 0;
            analysisTable[(analysisTable.GetLength(0) - 2), 4] = 0;
            for (int i = MainForm.table.GetLength(0) - 1; i >= 0; i--)
            {
                analysisTable[i, 3] = MainForm.demands[i];
                analysisTable[i, 2] = LookupValue(analysisTable[i, 4] + analysisTable[i, 3], i + 1);
                if (i > 0)
                {
                    analysisTable[i, 1] = (analysisTable[i, 4] + analysisTable[i, 3]) - analysisTable[i, 2];
                    analysisTable[i - 1, 4] = analysisTable[i, 1];
                }
            }
        }

        private void CalculateCosts()
        {
            throw new NotImplementedException();
        }

        private void ShowTable()
        {
            throw new NotImplementedException();
        }

        private decimal LookupValue(decimal v, int period)
        {
            decimal[] valids = new decimal[MainForm.table.GetLength(0)];
            decimal min = 999999;
            for (int i = 0; i < MainForm.table.GetLength(0); i++)
            {
                if (MainForm.table[i, period * 2 - 1] == v)
                {
                    valids[i] = MainForm.table[i, period * 2 - 1];
                }
                else valids[i] = 999999;
            }
            foreach (decimal d in valids)
            {
                if (d < min) min = d;
            }
            if (min == 999999) min = 0;
            return min;
        }
    }
}
