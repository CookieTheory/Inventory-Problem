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
            comboBoxLanguageSelect = new ComboBox();
            languageLabel = new Label();
            labelSizeOfInstallments = new Label();
            labelMaxVolume = new Label();
            labelCostProcurement = new Label();
            labelMaxCapacity = new Label();
            labelNumPeriods = new Label();
            labelStorageCosts = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            buttonCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            SuspendLayout();
            // 
            // comboBoxLanguageSelect
            // 
            comboBoxLanguageSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLanguageSelect.FormattingEnabled = true;
            comboBoxLanguageSelect.Items.AddRange(new object[] { "English", "Hrvatski" });
            comboBoxLanguageSelect.Location = new Point(694, 12);
            comboBoxLanguageSelect.Name = "comboBoxLanguageSelect";
            comboBoxLanguageSelect.Size = new Size(94, 23);
            comboBoxLanguageSelect.TabIndex = 1;
            comboBoxLanguageSelect.SelectionChangeCommitted += comboBoxLanguageSelect_SelectionChangeCommitted;
            // 
            // languageLabel
            // 
            languageLabel.BackColor = SystemColors.Control;
            languageLabel.Location = new Point(605, 15);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(83, 15);
            languageLabel.TabIndex = 2;
            languageLabel.Text = "Language:";
            languageLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelSizeOfInstallments
            // 
            labelSizeOfInstallments.Location = new Point(3, 66);
            labelSizeOfInstallments.Name = "labelSizeOfInstallments";
            labelSizeOfInstallments.Size = new Size(185, 17);
            labelSizeOfInstallments.TabIndex = 5;
            labelSizeOfInstallments.Text = "Size of installments:";
            labelSizeOfInstallments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMaxVolume
            // 
            labelMaxVolume.Location = new Point(3, 95);
            labelMaxVolume.Name = "labelMaxVolume";
            labelMaxVolume.Size = new Size(185, 17);
            labelMaxVolume.TabIndex = 6;
            labelMaxVolume.Text = "Maximum purchase volume:";
            labelMaxVolume.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCostProcurement
            // 
            labelCostProcurement.Location = new Point(3, 124);
            labelCostProcurement.Name = "labelCostProcurement";
            labelCostProcurement.Size = new Size(185, 17);
            labelCostProcurement.TabIndex = 7;
            labelCostProcurement.Text = "Cost per procurement:";
            labelCostProcurement.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMaxCapacity
            // 
            labelMaxCapacity.Location = new Point(3, 152);
            labelMaxCapacity.Name = "labelMaxCapacity";
            labelMaxCapacity.Size = new Size(185, 17);
            labelMaxCapacity.TabIndex = 12;
            labelMaxCapacity.Text = "Maximum storage capacity size:";
            labelMaxCapacity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelNumPeriods
            // 
            labelNumPeriods.Location = new Point(3, 211);
            labelNumPeriods.Name = "labelNumPeriods";
            labelNumPeriods.Size = new Size(185, 17);
            labelNumPeriods.TabIndex = 14;
            labelNumPeriods.Text = "Number of periods:";
            labelNumPeriods.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelStorageCosts
            // 
            labelStorageCosts.Location = new Point(3, 182);
            labelStorageCosts.Name = "labelStorageCosts";
            labelStorageCosts.Size = new Size(185, 17);
            labelStorageCosts.TabIndex = 16;
            labelStorageCosts.Text = "Storage costs per unit:";
            labelStorageCosts.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(194, 64);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(194, 93);
            numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(194, 122);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 19;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(194, 151);
            numericUpDown4.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 20;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(194, 180);
            numericUpDown5.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(120, 23);
            numericUpDown5.TabIndex = 21;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(194, 209);
            numericUpDown6.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(120, 23);
            numericUpDown6.TabIndex = 22;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(349, 267);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 23;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalculate);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(labelStorageCosts);
            Controls.Add(labelNumPeriods);
            Controls.Add(labelMaxCapacity);
            Controls.Add(labelCostProcurement);
            Controls.Add(labelMaxVolume);
            Controls.Add(labelSizeOfInstallments);
            Controls.Add(languageLabel);
            Controls.Add(comboBoxLanguageSelect);
            Name = "MainForm";
            Text = "Inventory problem";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBoxLanguageSelect;
        private Label languageLabel;
        private Label labelSizeOfInstallments;
        private Label labelMaxVolume;
        private Label labelCostProcurement;
        private Label labelMaxCapacity;
        private Label labelNumPeriods;
        private Label labelStorageCosts;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private Button buttonCalculate;
    }
}