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
    public partial class OtherPeriods : Form
    {
        private DataTable dt = new DataTable();
        private int x, y, z;
        public OtherPeriods()
        {
            InitializeComponent();
        }

        private void OtherPeriods_Load(object sender, EventArgs e)
        {
            label1.Text = "f(" + MainForm.globalPeriod + ")";
            AddColumns();
            CalculateOtherPeriods();
        }

        private void AddColumns()
        {
            dt.Columns.Add(Properties.strings.Supplies, typeof(decimal));
            for (int i = 0; i < MainForm.numPeriods; i++)
            {
                _ = dt.Columns.Add("Q(" + (i + 1) + ")", typeof(decimal));
                _ = dt.Columns.Add("f(" + (i + 1) + ")", typeof(decimal));
            }
        }

        private void CalculateOtherPeriods()
        {
            x = 10;
            y = 50;
            z = 75;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            for (int i = 0; i < MainForm.table.GetLength(0); i++)
            {
                decimal minimum = 99999;
                decimal selectedProcurement = 0;
                InitialLabel(i);
                decimal minProcurement = MainForm.table[i, 0] + MainForm.demands[MainForm.globalPeriod - 1] - MainForm.maxStorage;
                decimal maxProcurement = MainForm.table[i, 0] + MainForm.demands[MainForm.globalPeriod - 1];
                if (maxProcurement > MainForm.maxVolume) maxProcurement = MainForm.maxVolume;
                SecondLabel(minProcurement, maxProcurement);
                ThirdLabel(i);
                for (decimal j = minProcurement; j <= maxProcurement; j += MainForm.installments)
                {
                    Label a = new Label();
                    decimal procurementCost = 0;
                    if (j > 0) procurementCost = MainForm.cost;
                    decimal findPrevious = MainForm.table[i, 0] + MainForm.demands[MainForm.globalPeriod - 1] - j;
                    decimal addedPrevious = 0;
                    for (int k = 0; k < MainForm.table.GetLength(0); k++)
                    {
                        if (findPrevious == MainForm.table[k, 0]) addedPrevious = MainForm.table[k, (MainForm.globalPeriod - 1) * 2];
                    }
                    decimal calculated = procurementCost + (MainForm.storageCost * MainForm.table[i, 0]) + addedPrevious;
                    if (calculated < minimum)
                    {
                        minimum = calculated;
                        selectedProcurement = j;
                    }
                    a.Text = new string(procurementCost.ToString() + " + " + (MainForm.storageCost * MainForm.table[i, 0]) + " + " + addedPrevious + " = " + calculated);
                    a.Location = new Point(x, y);
                    a.AutoSize = false;
                    a.Size = new Size(437, 23);
                    this.Controls.Add(a);
                    y += 25; z += 25;
                    if (j == maxProcurement)
                    {
                        MainForm.table[i, MainForm.globalPeriod * 2 - 1] = selectedProcurement;
                        MainForm.table[i, MainForm.globalPeriod * 2] = minimum;
                    }
                }
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            FillAndShowUpdatedTable();
        }

        private void InitialLabel(int i)
        {
            Label a = new Label();
            a.Text = new string("f(" + MainForm.globalPeriod + ")[" + MainForm.table[i, 0] + "] " + MainForm.table[i, 0] + " + " + MainForm.demands[MainForm.globalPeriod - 1] + " - " + MainForm.maxStorage +
                " <= " + Properties.strings.Procurement + "(" + MainForm.globalPeriod + ") <= " + MainForm.table[i, 0] + " + " + MainForm.demands[MainForm.globalPeriod - 1]);
            a.Location = new Point(x, y);
            a.AutoSize = false;
            a.Size = new Size(437, 23);
            this.Controls.Add(a);
            y += 25; z += 25;
        }

        private void SecondLabel(decimal minProcurement, decimal maxProcurement)
        {
            Label a = new Label();
            a.Text = new string(minProcurement + " <= " + Properties.strings.Procurement + "(" + MainForm.globalPeriod + ") <= " + maxProcurement);
            a.Location = new Point(x, y);
            a.AutoSize = false;
            a.Size = new Size(437, 23);
            this.Controls.Add(a);
            y += 25; z += 25;
        }

        private void ThirdLabel(int i)
        {
            Label a = new Label();
            a.Text = new string("f(" + (MainForm.globalPeriod) + ")[" + MainForm.table[i, 0] + "] = min ->");
            a.Location = new Point(x, y);
            a.AutoSize = false;
            a.Size = new Size(437, 23);
            this.Controls.Add(a);
            y += 25; z += 25;
        }

        private void FillAndShowUpdatedTable()
        {
            z = 75;
            for (int i = 0; i < MainForm.table.GetLength(0); i++)
            {
                string table = "";
                for (int j = 0; j <= MainForm.globalPeriod; j++)
                {
                    if (j == MainForm.globalPeriod) table += $"{MainForm.table[i, j * 2 - 1]}, {MainForm.table[i, j * 2]}";
                    else if (j == 0) table += $"{MainForm.table[i, j]}, ";
                    else table += $"{MainForm.table[i, j * 2 - 1]}, {MainForm.table[i, j * 2]}, ";
                }
                decimal[] decimalValues = Array.ConvertAll(table.Split(","), decimal.Parse);
                DataRow dataRow = dt.NewRow();
                for(int j = 0; j < decimalValues.Length; j++) dataRow[j] = decimalValues[j];
                dt.Rows.Add(dataRow);
                z += 25;
            }
            DataGridView dgv = new DataGridView();
            dgv.DataSource = dt;
            dgv.Location = new Point(x, y);
            dgv.Size = new Size(540, z);
            this.Controls.Add(dgv);
            y += z + 25;
            x = 115;
            Button b = new Button();
            b.Text = Properties.strings.Back;
            b.Location = new Point(x, y);
            b.Size = new Size(150, 23);
            b.Click += new EventHandler(GoBack);
            this.Controls.Add(b);
            x += 190;
            Button c = new Button();
            c.Text = Properties.strings.NextPeriod;
            if (MainForm.globalPeriod == MainForm.numPeriods) c.Text = Properties.strings.Analysis;
            c.Location = new Point(x, y);
            c.Size = new Size(150, 23);
            c.Click += new EventHandler(GoToNextPeriod);
            this.Controls.Add(c);
        }

        private void GoToNextPeriod(object? sender, EventArgs e)
        {
            if (MainForm.globalPeriod == MainForm.numPeriods)
            {
                this.Hide();
                //Form analysis = new AnalysisOfResults();
                //analysis.ShowDialog();
                this.Show();
            }
            else
            {
                MainForm.globalPeriod += 1;
                this.Hide();
                Form nextPeriod = new OtherPeriods();
                nextPeriod.ShowDialog();
                this.Show();
            }
        }

        private void GoBack(object? sender, EventArgs e)
        {
            MainForm.globalPeriod -= 1;
            this.Close();
        }
    }
}
