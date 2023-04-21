using System.Globalization;

namespace Inventory_Problem
{
    public partial class MainForm : Form
    {
        public static decimal[]? demands;
        public static decimal installments, maxVolume, cost, maxStorage, storageCost, numPeriods;
        public static decimal[,]? table;
        public static int globalPeriod = 0;

        public MainForm()
        {
            InitializeComponent();
            RefreshLanguageStrings();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.comboBoxLanguageSelect.SelectedIndex = 0;
        }

        private void comboBoxLanguageSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string language = "en";
            if (comboBoxLanguageSelect.SelectedItem.ToString() == "Hrvatski") language = "hr";
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);
            RefreshLanguageStrings();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            AddValues();
            Form demand = new Demands((int)this.numericUpDown6.Value);
            demand.ShowDialog();
            this.Hide();
            MainForm.globalPeriod += 1;
            Form firstPeriod = new FirstPeriod();
            firstPeriod.ShowDialog();
            this.Show();
        }

        private void AddValues()
        {
            installments = this.numericUpDown1.Value;
            maxVolume = this.numericUpDown2.Value;
            cost = this.numericUpDown3.Value;
            maxStorage= this.numericUpDown4.Value;
            storageCost = this.numericUpDown5.Value;
            numPeriods = this.numericUpDown6.Value;
        }

        private void RefreshLanguageStrings()
        {
            this.Text = Properties.strings.AppName;
            this.languageLabel.Text = Properties.strings.Language;
            this.labelCostProcurement.Text = Properties.strings.CostPerProcurement;
            this.labelMaxCapacity.Text = Properties.strings.MaxCapacity;
            this.labelMaxVolume.Text = Properties.strings.MaxPurchase;
            this.labelNumPeriods.Text = Properties.strings.NumPeriods;
            this.labelSizeOfInstallments.Text = Properties.strings.Size;
            this.labelStorageCosts.Text = Properties.strings.StorageCosts;
            this.buttonCalculate.Text = Properties.strings.Calculate;
        }
    }
}