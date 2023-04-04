namespace BasicCalculator
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
            label1 = new Label();
            resultTextBox = new TextBox();
            num1TextBox = new TextBox();
            num2TextBox = new TextBox();
            sumButton = new Button();
            subButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            moduloButton = new Button();
            powButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 0;
            label1.Text = "Result:";
            // 
            // resultTextBox
            // 
            resultTextBox.Enabled = false;
            resultTextBox.Location = new Point(79, 7);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(161, 23);
            resultTextBox.TabIndex = 1;
            // 
            // num1TextBox
            // 
            num1TextBox.Location = new Point(12, 36);
            num1TextBox.Name = "num1TextBox";
            num1TextBox.Size = new Size(199, 23);
            num1TextBox.TabIndex = 1;
            // 
            // num2TextBox
            // 
            num2TextBox.Location = new Point(12, 65);
            num2TextBox.Name = "num2TextBox";
            num2TextBox.Size = new Size(199, 23);
            num2TextBox.TabIndex = 1;
            // 
            // sumButton
            // 
            sumButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sumButton.Location = new Point(217, 36);
            sumButton.Name = "sumButton";
            sumButton.Size = new Size(23, 23);
            sumButton.TabIndex = 2;
            sumButton.Text = "+";
            sumButton.UseVisualStyleBackColor = true;
            sumButton.Click += sumButton_Click;
            // 
            // subButton
            // 
            subButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            subButton.Location = new Point(217, 65);
            subButton.Name = "subButton";
            subButton.Size = new Size(23, 23);
            subButton.TabIndex = 3;
            subButton.Text = "-";
            subButton.UseVisualStyleBackColor = true;
            subButton.Click += subButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            multiplyButton.Location = new Point(246, 36);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(23, 23);
            multiplyButton.TabIndex = 4;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            divideButton.Location = new Point(246, 65);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(23, 23);
            divideButton.TabIndex = 5;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // moduloButton
            // 
            moduloButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            moduloButton.Location = new Point(275, 36);
            moduloButton.Name = "moduloButton";
            moduloButton.Size = new Size(23, 23);
            moduloButton.TabIndex = 6;
            moduloButton.Text = "%";
            moduloButton.UseVisualStyleBackColor = true;
            moduloButton.Click += moduloButton_Click;
            // 
            // powButton
            // 
            powButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            powButton.Location = new Point(275, 65);
            powButton.Name = "powButton";
            powButton.Size = new Size(23, 23);
            powButton.TabIndex = 7;
            powButton.Text = "^";
            powButton.UseVisualStyleBackColor = true;
            powButton.Click += powButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Location = new Point(246, 7);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(54, 23);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 97);
            Controls.Add(clearButton);
            Controls.Add(powButton);
            Controls.Add(moduloButton);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(subButton);
            Controls.Add(sumButton);
            Controls.Add(num2TextBox);
            Controls.Add(num1TextBox);
            Controls.Add(resultTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox resultTextBox;
        private TextBox num1TextBox;
        private TextBox num2TextBox;
        private Button sumButton;
        private Button subButton;
        private Button multiplyButton;
        private Button divideButton;
        private Button moduloButton;
        private Button powButton;
        private Button clearButton;
    }
}