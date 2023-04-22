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
        private int x, y, z;
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
            dt.Columns.Add(Properties.strings.OtherPeriod, typeof(string));
            dt.Columns.Add("I(i-1)", typeof(string));
            dt.Columns.Add("Q(i)", typeof(string));
            dt.Columns.Add("D(i)", typeof(string));
            dt.Columns.Add("I(i)", typeof(string));
            dt.Columns.Add("Cp(i)", typeof(string));
            dt.Columns.Add("Ch(i)", typeof(string));
        }

        private void CreateAnalysisTable()
        {
            int height = MainForm.table.GetLength(0);
            analysisTable = new decimal[height + 2, 7];
            for (int i = 0; i < height; i++)
            {
                analysisTable[i, 0] = (decimal)i + 1;
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
            decimal costs = 0;
            decimal storageCosts = 0;
            for (int i = 0; i < MainForm.table.GetLength(0); i++)
            {
                if (analysisTable[i, 2] > 0) { analysisTable[i, 5] = MainForm.cost; costs += MainForm.cost; }
                if (analysisTable[i, 4] > 0)
                {
                    analysisTable[i, 6] = analysisTable[i, 4] * MainForm.storageCost;
                    storageCosts += analysisTable[i, 4] * MainForm.storageCost;
                }
            }
            analysisTable[analysisTable.GetLength(0) - 2, 5] = costs;
            analysisTable[analysisTable.GetLength(0) - 2, 6] = storageCosts;
            analysisTable[analysisTable.GetLength(0) - 1, 5] = costs + storageCosts;
        }

        private void ShowTable()
        {
            x = 300;
            y = 50;
            z = 75;
            for (int i = 0; i < analysisTable.GetLength(0) - 2; i++)
            {
                string table = "";
                for (int j = 0; j < analysisTable.GetLength(1); j++)
                {
                    if (j == analysisTable.GetLength(1) - 1) table += $"{analysisTable[i, j]}";
                    else if (j == 0) table += $"{analysisTable[i, j]}, ";
                    else table += $"{analysisTable[i, j]}, ";
                }
                decimal[] decimalValues = Array.ConvertAll(table.Split(","), decimal.Parse);
                DataRow dataRow = dt.NewRow();
                for (int j = 0; j < decimalValues.Length; j++) dataRow[j] = decimalValues[j];
                dt.Rows.Add(dataRow);
                z += 25;
            }
            for (int i = analysisTable.GetLength(0) - 2; i < analysisTable.GetLength(0); i++)
            {
                string table = "";
                for (int j = 0; j < analysisTable.GetLength(1); j++)
                {
                    if (j == analysisTable.GetLength(1) - 1) table += $"{analysisTable[i, j]}";
                    else if (j == 0) table += $"{analysisTable[i, j]}, ";
                    else table += $"{analysisTable[i, j]}, ";
                }
                decimal[] decimalValues = Array.ConvertAll(table.Split(","), decimal.Parse);
                DataRow dataRow = dt.NewRow();
                for (int j = 0; j < decimalValues.Length - 3; j++) dataRow[j] = "-";
                for (int j = decimalValues.Length - 2; j < decimalValues.Length; j++) dataRow[j] = decimalValues[j];
                if (i == analysisTable.GetLength(0) - 2) dataRow[decimalValues.Length - 3] = "Zbroj";
                else
                {
                    dataRow[decimalValues.Length - 3] = "Suma";
                    dataRow[decimalValues.Length - 1] = "-";
                }
                dt.Rows.Add(dataRow);
                z += 25;
            }
            DataGridView dgv = new()
            {
                DataSource = dt,
                Location = new Point(x, y),
                Size = new Size(740, z)
            };
            this.Controls.Add(dgv);
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
