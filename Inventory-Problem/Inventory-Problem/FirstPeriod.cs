using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Problem
{
    public partial class FirstPeriod : Form
    {
        private DataTable dt = new DataTable();
        private int x, y, z;
        public FirstPeriod()
        {
            InitializeComponent();
        }

        private void FirstPeriod_Load(object sender, EventArgs e)
        {
            AddColumns();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            labelFirstPeriod1.Text = new string(MainForm.maxStorage + " + " + MainForm.demands[0] + " - " + MainForm.maxStorage + " <= " + Properties.strings.Procurement + "(1) <= " + MainForm.maxStorage + " + " + MainForm.demands[0]);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            CalculateFirstPeriod();
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

        private void CalculateFirstPeriod()
        {
            x = 10;
            y = 100;
            z = 75;
            decimal minProcurement = MainForm.maxStorage + MainForm.demands[0] - MainForm.maxStorage;
            decimal maxProcurement = MainForm.maxStorage + MainForm.demands[0];
            labelFirstPeriod2.Text = new string(minProcurement + " <= " + Properties.strings.Procurement + "(1) <= " + maxProcurement);
            int j = 0;
            for (decimal i = minProcurement; i <= maxProcurement; i += MainForm.installments)
            {
                j++;
            }
            MainForm.table = new decimal[j, (int)MainForm.numPeriods * 2 + 1];
            j = 0;
            for (decimal i = minProcurement; i <= maxProcurement; i += MainForm.installments)
            {
                Label a = new Label();
                decimal procurementCost = 0;
                if (i > 0) procurementCost = MainForm.cost;
                MainForm.table[j, (MainForm.globalPeriod - 1)] = j * MainForm.installments;
                MainForm.table[j, MainForm.globalPeriod] = i;
                MainForm.table[j, MainForm.globalPeriod + 1] = procurementCost + (j * MainForm.installments * MainForm.storageCost);
                a.Text = "f(" + (j + 1) + ") = [" + i + ", " + (j - MainForm.installments) + "] = " + procurementCost + " + " + ((i - MainForm.installments) * MainForm.storageCost) + " = " + MainForm.table[j, MainForm.globalPeriod].ToString();
                a.Location = new Point(x, y);
                a.AutoSize = false;
                a.Size = new Size(437, 23);
                this.Controls.Add(a);
                dt.Rows.Add(MainForm.table[j, MainForm.globalPeriod - 1], i, MainForm.table[j, MainForm.globalPeriod + 1]);
                y += 25; z += 25; j++;
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
            c.Location = new Point(x, y);
            c.Size = new Size(150, 23);
            c.Click += new EventHandler(GoToNextPeriod);
            this.Controls.Add(c);
        }

        private void GoToNextPeriod(object? sender, EventArgs e)
        {
            MainForm.globalPeriod += 1;
            this.Hide();
            Form nextPeriod = new OtherPeriods();
            nextPeriod.ShowDialog();
            this.Show();
        }

        private void GoBack(object? sender, EventArgs e)
        {
            MainForm.globalPeriod -= 1;
            this.Close();
        }
    }
}
