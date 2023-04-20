using System.Globalization;

namespace Inventory_Problem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Start();
            AddText();
            RefreshLanguageStrings();
        }

        private void Start()
        {
            this.comboBoxLanguageSelect.DataSource = new string[] { "Hrvatski", "English" };
        }

        private void RefreshLanguageStrings()
        {
            this.label1.Text = Properties.strings.Hello;
            this.languageLabel.Text = Properties.strings.Language;
        }

        private void AddText()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("hr");
            this.label1.Text = Properties.strings.Hello;
        }

        private void comboBoxLanguageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? language = comboBoxLanguageSelect.SelectedItem.ToString();
            if (language == "Hrvatski") language = "hr";
            else language = "en";
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);
            RefreshLanguageStrings();
        }
    }
}