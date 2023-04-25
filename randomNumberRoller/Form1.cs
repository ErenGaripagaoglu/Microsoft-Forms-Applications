using System.Globalization;

namespace randomNumberRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isWorking = false;
        int[] numbers = new int[6];

        private void startStop_Click(object sender, EventArgs e)
        {
            if (!isWorking)
            {
                timer1.Start();
                isWorking = true;
            }
            else
            {
                timer1.Stop();
                isWorking = false;

                Array.Sort(numbers);

                label1.Text = numbers[0].ToString();
                label2.Text = numbers[1].ToString();
                label3.Text = numbers[2].ToString();
                label4.Text = numbers[3].ToString();
                label5.Text = numbers[4].ToString();
                label6.Text = numbers[5].ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int i = 0;
            while (i < 6)
            {
                int num = r.Next(1, 49);

                if (!numbers.Contains(num))
                {
                    numbers[i] = num;
                    i++;
                }
            }

            label1.Text = numbers[0].ToString();
            label2.Text = numbers[1].ToString();
            label3.Text = numbers[2].ToString();
            label4.Text = numbers[3].ToString();
            label5.Text = numbers[4].ToString();
            label6.Text = numbers[5].ToString();
        }
    }
}