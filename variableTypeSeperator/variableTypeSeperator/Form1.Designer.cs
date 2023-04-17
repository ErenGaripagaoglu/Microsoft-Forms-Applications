namespace variableTypeSeperator
{
    partial class Form1
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
            checkAndAdd = new Button();
            variable = new TextBox();
            integers = new ListBox();
            strings = new ListBox();
            label1 = new Label();
            label3 = new Label();
            cleaner = new Button();
            SuspendLayout();
            // 
            // checkAndAdd
            // 
            checkAndAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkAndAdd.Location = new Point(173, 12);
            checkAndAdd.Name = "checkAndAdd";
            checkAndAdd.Size = new Size(99, 23);
            checkAndAdd.TabIndex = 0;
            checkAndAdd.Text = "Check And Add";
            checkAndAdd.UseVisualStyleBackColor = true;
            checkAndAdd.Click += checkAndAdd_Click;
            // 
            // variable
            // 
            variable.Location = new Point(12, 12);
            variable.Name = "variable";
            variable.Size = new Size(155, 23);
            variable.TabIndex = 1;
            // 
            // integers
            // 
            integers.FormattingEnabled = true;
            integers.ItemHeight = 15;
            integers.Location = new Point(12, 61);
            integers.Name = "integers";
            integers.Size = new Size(155, 94);
            integers.TabIndex = 2;
            // 
            // strings
            // 
            strings.FormattingEnabled = true;
            strings.ItemHeight = 15;
            strings.Location = new Point(173, 61);
            strings.Name = "strings";
            strings.Size = new Size(155, 94);
            strings.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Integers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(173, 43);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Strings";
            // 
            // cleaner
            // 
            cleaner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cleaner.Location = new Point(278, 12);
            cleaner.Name = "cleaner";
            cleaner.Size = new Size(50, 23);
            cleaner.TabIndex = 4;
            cleaner.Text = "Clear";
            cleaner.UseVisualStyleBackColor = true;
            cleaner.Click += cleaner_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 167);
            Controls.Add(cleaner);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(strings);
            Controls.Add(integers);
            Controls.Add(variable);
            Controls.Add(checkAndAdd);
            Name = "Form1";
            Text = "Variable Type Seperator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkAndAdd;
        private TextBox variable;
        private ListBox integers;
        private ListBox strings;
        private Label label1;
        private Label label3;
        private Button cleaner;
    }
}