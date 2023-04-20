using System.Globalization;

namespace Inventory_Problem
{
    public partial class MainForm : Form
    {
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
        }
    }
}