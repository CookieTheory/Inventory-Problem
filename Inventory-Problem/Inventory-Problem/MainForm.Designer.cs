namespace Inventory_Problem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLanguageSelect = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // comboBoxLanguageSelect
            // 
            this.comboBoxLanguageSelect.FormattingEnabled = true;
            this.comboBoxLanguageSelect.Location = new System.Drawing.Point(667, 12);
            this.comboBoxLanguageSelect.Name = "comboBoxLanguageSelect";
            this.comboBoxLanguageSelect.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLanguageSelect.TabIndex = 1;
            this.comboBoxLanguageSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguageSelect_SelectedIndexChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(599, 15);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(62, 15);
            this.languageLabel.TabIndex = 2;
            this.languageLabel.Text = "Language:";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.comboBoxLanguageSelect);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxLanguageSelect;
        private Label languageLabel;
    }
}