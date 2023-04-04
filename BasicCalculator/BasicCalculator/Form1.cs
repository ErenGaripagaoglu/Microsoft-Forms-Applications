namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1TextBox.Text);
            double num2 = Convert.ToDouble(num2TextBox.Text);

            double sonuc = num1 + num2;
            resultTextBox.Text = sonuc.ToString();

            num1TextBox.Text = sonuc.ToString();
            num1TextBox.Enabled = false;
            num2TextBox.Clear();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1TextBox.Text);
            double num2 = Convert.ToDouble(num2TextBox.Text);

            double sonuc = num1 - num2;
            resultTextBox.Text = sonuc.ToString();

            num1TextBox.Text = sonuc.ToString();
            num1TextBox.Enabled = false;
            num2TextBox.Clear();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1TextBox.Text);
            double num2 = Convert.ToDouble(num2TextBox.Text);

            double sonuc = num1 * num2;
            resultTextBox.Text = sonuc.ToString();

            num1TextBox.Text = sonuc.ToString();
            num1TextBox.Enabled = false;
            num2TextBox.Clear();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1TextBox.Text);
            double num2 = Convert.ToDouble(num2TextBox.Text);

            double sonuc = num1 / num2;
            resultTextBox.Text = sonuc.ToString();

            num1TextBox.Text = sonuc.ToString();
            num1TextBox.Enabled = false;
            num2TextBox.Clear();
        }

        private void moduloButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1TextBox.Text);
            double num2 = Convert.ToDouble(num2TextBox.Text);

            double sonuc = num1 % num2;
            resultTextBox.Text = sonuc.ToString();

            num1TextBox.Text = sonuc.ToString();
            num1TextBox.Enabled = false;
            num2TextBox.Clear();
        }

        private void powButton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1TextBox.Text);
            double num2 = Convert.ToDouble(num2TextBox.Text);

            double sonuc = Math.Pow(num1, num2);
            resultTextBox.Text = sonuc.ToString();

            num1TextBox.Text = sonuc.ToString();
            num1TextBox.Enabled = false;
            num2TextBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            num1TextBox.Clear();
            num2TextBox.Clear();
            resultTextBox.Clear();
            num1TextBox.Enabled = true;
        }
    }
}