namespace EstimatorCost
{
    partial class Form1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbxFancyDecoration = new System.Windows.Forms.CheckBox();
            this.cbxHealtyDecoration = new System.Windows.Forms.CheckBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of people";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 46);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbxFancyDecoration
            // 
            this.cbxFancyDecoration.AutoSize = true;
            this.cbxFancyDecoration.Checked = true;
            this.cbxFancyDecoration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFancyDecoration.Location = new System.Drawing.Point(12, 91);
            this.cbxFancyDecoration.Name = "cbxFancyDecoration";
            this.cbxFancyDecoration.Size = new System.Drawing.Size(110, 17);
            this.cbxFancyDecoration.TabIndex = 2;
            this.cbxFancyDecoration.Text = "Fancy Decoration";
            this.cbxFancyDecoration.UseVisualStyleBackColor = true;
            this.cbxFancyDecoration.CheckedChanged += new System.EventHandler(this.cbxFancyDecoration_CheckedChanged);
            // 
            // cbxHealtyDecoration
            // 
            this.cbxHealtyDecoration.AutoSize = true;
            this.cbxHealtyDecoration.Location = new System.Drawing.Point(12, 127);
            this.cbxHealtyDecoration.Name = "cbxHealtyDecoration";
            this.cbxHealtyDecoration.Size = new System.Drawing.Size(111, 17);
            this.cbxHealtyDecoration.TabIndex = 3;
            this.cbxHealtyDecoration.Text = "Healty Decoration";
            this.cbxHealtyDecoration.UseVisualStyleBackColor = true;
            this.cbxHealtyDecoration.CheckedChanged += new System.EventHandler(this.cbxHealtyDecoration_CheckedChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(9, 163);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(40, 159);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 191);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.cbxHealtyDecoration);
            this.Controls.Add(this.cbxFancyDecoration);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox cbxFancyDecoration;
        private System.Windows.Forms.CheckBox cbxHealtyDecoration;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
    }
}

