using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Problem
{
    public partial class AnalysisOfResults : Form
    {
        private readonly DataTable dt = new();
        public AnalysisOfResults()
        {
            InitializeComponent();
        }

        private void AnalysisOfResults_Load(object sender, EventArgs e)
        {

            AddColumns();
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

        private void CalculateAnalysis()
        {
            throw new NotImplementedException();
        }
    }
}
