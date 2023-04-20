using System.Globalization;

namespace Inventory_Problem
{
    public partial class MainForm : Form
    {
        public static float[]? demands;

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

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Form demand = new Demands((int)this.numericUpDown6.Value);
            demand.ShowDialog();

        }
    }
}