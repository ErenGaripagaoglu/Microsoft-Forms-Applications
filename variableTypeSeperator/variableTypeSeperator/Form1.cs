namespace variableTypeSeperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkAndAdd_Click(object sender, EventArgs e)
        {
            string varValue = variable.Text;

            if (varValue != null)
            {
                foreach (char s in varValue)
                {
                    if (char.IsNumber(s) == false)
                    {
                        strings.Items.Add(varValue);
                        break;
                    }
                }

                if (strings.Items.IndexOf(varValue) == -1)
                {
                    integers.Items.Add(varValue);
                }
            }

            variable.Clear();
        }

        private void cleaner_Click(object sender, EventArgs e)
        {
            variable.Clear();
            strings.Items.Clear();
            integers.Items.Clear();
        }
    }
}