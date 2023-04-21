namespace Inventory_Problem
{
    partial class OtherPeriods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "f(2)";
            // 
            // OtherPeriods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(263, 219);
            Controls.Add(label1);
            Name = "OtherPeriods";
            Text = "OtherPeriods";
            FormClosed += OtherPeriods_FormClosed;
            Load += OtherPeriods_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}