namespace Inventory_Problem
{
    partial class FirstPeriod
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstPeriod1 = new System.Windows.Forms.Label();
            this.labelFirstPeriod2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "f(1)";
            // 
            // labelFirstPeriod1
            // 
            this.labelFirstPeriod1.Location = new System.Drawing.Point(12, 36);
            this.labelFirstPeriod1.Name = "labelFirstPeriod1";
            this.labelFirstPeriod1.Size = new System.Drawing.Size(437, 23);
            this.labelFirstPeriod1.TabIndex = 1;
            this.labelFirstPeriod1.Text = "label2";
            // 
            // labelFirstPeriod2
            // 
            this.labelFirstPeriod2.AutoSize = true;
            this.labelFirstPeriod2.Location = new System.Drawing.Point(12, 59);
            this.labelFirstPeriod2.Name = "labelFirstPeriod2";
            this.labelFirstPeriod2.Size = new System.Drawing.Size(38, 15);
            this.labelFirstPeriod2.TabIndex = 2;
            this.labelFirstPeriod2.Text = "label2";
            // 
            // FirstPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(467, 259);
            this.Controls.Add(this.labelFirstPeriod2);
            this.Controls.Add(this.labelFirstPeriod1);
            this.Controls.Add(this.label1);
            this.Name = "FirstPeriod";
            this.Text = "FirstPeriod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FirstPeriod_FormClosed);
            this.Load += new System.EventHandler(this.FirstPeriod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelFirstPeriod1;
        private Label labelFirstPeriod2;
    }
}