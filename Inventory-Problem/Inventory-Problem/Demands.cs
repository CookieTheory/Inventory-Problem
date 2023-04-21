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
    public partial class Demands : Form
    {
        private List<TextBox> textBoxList = new List<TextBox>();
        private int numberOfPeriods;
        public Demands(int periods)
        {
            InitializeComponent();
            numberOfPeriods = periods;
        }

        private void Demands_Load(object sender, EventArgs e)
        {
            this.Text = Properties.strings.Demands;
            try
            {
                int pointX = 20;
                int pointY = 20;
                this.Controls.Clear();
                for (int i = 0; i < numberOfPeriods; i++)
                {
                    TextBox a = new TextBox();
                    Label b = new Label();
                    pointY += 1;
                    string text = Properties.strings.DemandsOf + (i + 1) + "." + Properties.strings.Period;
                    b.Text = text;
                    b.TextAlign = ContentAlignment.MiddleRight;
                    b.AutoSize = false;
                    b.Size = new System.Drawing.Size(140, 17);
                    b.Location = new Point(pointX, pointY);
                    pointX += 150;
                    pointY -= 1;
                    this.Controls.Add(b);
                    a.Name = "textBox" + i;
                    a.Location = new Point(pointX, pointY);
                    textBoxList.Add(a);
                    this.Controls.Add(a);
                    pointY += 30;
                    pointX -= 150;
                }
                pointX += 75;
                pointY += 20;
                Button returnPeriods = new Button();
                returnPeriods.Text = Properties.strings.Calculate;
                returnPeriods.Location = new Point(pointX, pointY);
                returnPeriods.Click += new EventHandler(ReturnPeriodValues);
                this.Controls.Add(returnPeriods);
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ReturnPeriodValues(object? sender, EventArgs e)
        {
            MainForm.demands = new decimal[numberOfPeriods];
            try
            {
                for (int i = 0; i < numberOfPeriods; i++)
                {
                    MainForm.demands[i] = decimal.Parse(textBoxList[i].Text);
                }
                Close();
            }
            catch(Exception)
            {
                MessageBox.Show(Properties.strings.Null);
            }
        }
    }
}
