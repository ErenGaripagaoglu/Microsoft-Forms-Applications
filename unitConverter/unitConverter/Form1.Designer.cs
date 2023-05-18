namespace unitConverter
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputUnitComboBox = new System.Windows.Forms.ComboBox();
            this.outputUnitComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(12, 52);
            this.inputBox.MaxLength = 20;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(126, 22);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // outputBox
            // 
            this.outputBox.Enabled = false;
            this.outputBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(12, 102);
            this.outputBox.MaxLength = 20;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(126, 22);
            this.outputBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNITS CONVERTER";
            // 
            // inputUnitComboBox
            // 
            this.inputUnitComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUnitComboBox.Items.AddRange(new object[] {
            "Meter (m)",
            "Kilometer (km)",
            "Feet (ft)",
            "Mile (mi)",
            "Kilograms (kg)",
            "Pound (lb)"});
            this.inputUnitComboBox.Location = new System.Drawing.Point(144, 52);
            this.inputUnitComboBox.Name = "inputUnitComboBox";
            this.inputUnitComboBox.Size = new System.Drawing.Size(121, 21);
            this.inputUnitComboBox.TabIndex = 2;
            this.inputUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.InputUnitComboBox_SelectedIndexChanged);
            // 
            // outputUnitComboBox
            // 
            this.outputUnitComboBox.Enabled = false;
            this.outputUnitComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputUnitComboBox.FormattingEnabled = true;
            this.outputUnitComboBox.Location = new System.Drawing.Point(144, 102);
            this.outputUnitComboBox.Name = "outputUnitComboBox";
            this.outputUnitComboBox.Size = new System.Drawing.Size(121, 21);
            this.outputUnitComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(103, 129);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 160);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputUnitComboBox);
            this.Controls.Add(this.inputUnitComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Units Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox outputUnitComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputUnitComboBox;
        private System.Windows.Forms.Button convertButton;
    }
}

