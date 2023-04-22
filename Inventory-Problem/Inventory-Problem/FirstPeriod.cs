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
using static System.Windows.Forms.DataFormats;

namespace Inventory_Problem
{
    public partial class FirstPeriod : Form
    {
        private readonly DataTable dt = new();
        private int x, y, z;
        public FirstPeriod()
        {
            InitializeComponent();
            MainForm.forceClose = true;
        }

        private void FirstPeriod_Load(object sender, EventArgs e)
        {
            AddColumns();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            labelFirstPeriod1.Text = new string(MainForm.maxStorage + " + " + MainForm.demands[0] + " - " + MainForm.maxStorage + " <= " + Properties.strings.Procurement + "(1) <= " + MainForm.maxStorage + " + " + MainForm.demands[0]);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            this.Text = Properties.strings.FirstPeriod;
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
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            decimal minProcurement = MainForm.maxStorage + MainForm.demands[0] - MainForm.maxStorage;
            decimal maxProcurement = MainForm.maxStorage + MainForm.demands[0];
#pragma warning restore CS8602 // Dereference of a possibly null reference.
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
                Label a = new();
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
            DataGridView dgv = new()
            {
                DataSource = dt,
                Location = new Point(x, y),
                Size = new Size(740, z)
            };
            this.Controls.Add(dgv);
            y += z + 25;
            x = 215;
            Button b = new()
            {
                Text = Properties.strings.Back,
                Location = new Point(x, y),
                Size = new Size(150, 23)
            };
            b.Click += new EventHandler(GoBack);
            this.Controls.Add(b);
            x += 190;
            Button c = new()
            {
                Text = Properties.strings.NextPeriod,
                Location = new Point(x, y),
                Size = new Size(150, 23)
            };
            c.Click += new EventHandler(GoToNextPeriod);
            this.Controls.Add(c);
        }

        private void FirstPeriod_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.globalPeriod -= 1;
        }

        private void GoToNextPeriod(object? sender, EventArgs e)
        {
            MainForm.globalPeriod += 1;
            this.Hide();
            Form nextPeriod = new OtherPeriods();
            nextPeriod.StartPosition = FormStartPosition.Manual;
            nextPeriod.Location = new Point(100, 100);
            nextPeriod.ShowDialog();
            if (MainForm.forceClose) this.Close();
            else this.Show();
        }

        private void GoBack(object? sender, EventArgs e)
        {
            MainForm.forceClose = false;
            this.Close();
        }
    }
}
