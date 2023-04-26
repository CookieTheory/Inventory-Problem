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
            this.comboBoxLanguageSelect = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.labelSizeOfInstallments = new System.Windows.Forms.Label();
            this.labelMaxVolume = new System.Windows.Forms.Label();
            this.labelCostProcurement = new System.Windows.Forms.Label();
            this.labelMaxCapacity = new System.Windows.Forms.Label();
            this.labelNumPeriods = new System.Windows.Forms.Label();
            this.labelStorageCosts = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLanguageSelect
            // 
            this.comboBoxLanguageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguageSelect.FormattingEnabled = true;
            this.comboBoxLanguageSelect.Items.AddRange(new object[] {
            "English",
            "Hrvatski"});
            this.comboBoxLanguageSelect.Location = new System.Drawing.Point(436, 12);
            this.comboBoxLanguageSelect.Name = "comboBoxLanguageSelect";
            this.comboBoxLanguageSelect.Size = new System.Drawing.Size(94, 23);
            this.comboBoxLanguageSelect.TabIndex = 1;
            this.comboBoxLanguageSelect.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLanguageSelect_SelectionChangeCommitted);
            // 
            // languageLabel
            // 
            this.languageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.languageLabel.Location = new System.Drawing.Point(347, 15);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(83, 15);
            this.languageLabel.TabIndex = 2;
            this.languageLabel.Text = "Language:";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSizeOfInstallments
            // 
            this.labelSizeOfInstallments.Location = new System.Drawing.Point(3, 66);
            this.labelSizeOfInstallments.Name = "labelSizeOfInstallments";
            this.labelSizeOfInstallments.Size = new System.Drawing.Size(185, 17);
            this.labelSizeOfInstallments.TabIndex = 5;
            this.labelSizeOfInstallments.Text = "Size of installments:";
            this.labelSizeOfInstallments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaxVolume
            // 
            this.labelMaxVolume.Location = new System.Drawing.Point(3, 95);
            this.labelMaxVolume.Name = "labelMaxVolume";
            this.labelMaxVolume.Size = new System.Drawing.Size(185, 17);
            this.labelMaxVolume.TabIndex = 6;
            this.labelMaxVolume.Text = "Maximum purchase volume:";
            this.labelMaxVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCostProcurement
            // 
            this.labelCostProcurement.Location = new System.Drawing.Point(3, 124);
            this.labelCostProcurement.Name = "labelCostProcurement";
            this.labelCostProcurement.Size = new System.Drawing.Size(185, 17);
            this.labelCostProcurement.TabIndex = 7;
            this.labelCostProcurement.Text = "Cost per procurement:";
            this.labelCostProcurement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaxCapacity
            // 
            this.labelMaxCapacity.Location = new System.Drawing.Point(3, 152);
            this.labelMaxCapacity.Name = "labelMaxCapacity";
            this.labelMaxCapacity.Size = new System.Drawing.Size(185, 17);
            this.labelMaxCapacity.TabIndex = 12;
            this.labelMaxCapacity.Text = "Maximum storage capacity size:";
            this.labelMaxCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNumPeriods
            // 
            this.labelNumPeriods.Location = new System.Drawing.Point(3, 211);
            this.labelNumPeriods.Name = "labelNumPeriods";
            this.labelNumPeriods.Size = new System.Drawing.Size(185, 17);
            this.labelNumPeriods.TabIndex = 14;
            this.labelNumPeriods.Text = "Number of periods:";
            this.labelNumPeriods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStorageCosts
            // 
            this.labelStorageCosts.Location = new System.Drawing.Point(3, 182);
            this.labelStorageCosts.Name = "labelStorageCosts";
            this.labelStorageCosts.Size = new System.Drawing.Size(185, 17);
            this.labelStorageCosts.TabIndex = 16;
            this.labelStorageCosts.Text = "Storage costs per unit:";
            this.labelStorageCosts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(194, 64);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(194, 93);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(194, 122);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown3.TabIndex = 19;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(194, 151);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown4.TabIndex = 20;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(194, 180);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown5.TabIndex = 21;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(194, 209);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown6.TabIndex = 22;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(239, 256);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(548, 296);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelStorageCosts);
            this.Controls.Add(this.labelNumPeriods);
            this.Controls.Add(this.labelMaxCapacity);
            this.Controls.Add(this.labelCostProcurement);
            this.Controls.Add(this.labelMaxVolume);
            this.Controls.Add(this.labelSizeOfInstallments);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.comboBoxLanguageSelect);
            this.Name = "MainForm";
            this.Text = "Inventory problem";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);

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