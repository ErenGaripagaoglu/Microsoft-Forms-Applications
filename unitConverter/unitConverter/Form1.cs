using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double inputValue;

        private void InputUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputUnitComboBox.Items.Clear();
            outputBox.Clear();

            switch (inputUnitComboBox.SelectedIndex)
            {
                case (0): inputCombo0(); break;
                case (1): inputCombo1(); break;
                case (2): inputCombo2(); break;
                case (3): inputCombo3(); break;
                case (4): inputCombo4(); break;
                case (5): inputCombo5(); break;
            }
        }

        private void inputCombo0()
        {
            outputUnitComboBox.Enabled = true;

            outputUnitComboBox.Items.Add("Kilometer (km)");
            outputUnitComboBox.Items.Add("Feet (ft)");
            outputUnitComboBox.Items.Add("Mile (mi)");
        }

        private void inputCombo1()
        {
            outputUnitComboBox.Enabled = true;

            outputUnitComboBox.Items.Add("Meter (m)");
            outputUnitComboBox.Items.Add("Feet (ft)");
            outputUnitComboBox.Items.Add("Mile (mi)");
        }

        private void inputCombo2()
        {
            outputUnitComboBox.Enabled = true;

            outputUnitComboBox.Items.Add("Kilometer (km)");
            outputUnitComboBox.Items.Add("Meter (m)");
            outputUnitComboBox.Items.Add("Mile (mi)");
        }

        private void inputCombo3()
        {
            outputUnitComboBox.Enabled = true;

            outputUnitComboBox.Items.Add("Kilometer (km)");
            outputUnitComboBox.Items.Add("Meter (m)");
            outputUnitComboBox.Items.Add("Feet (ft)");
        }

        private void inputCombo4()
        {
            outputUnitComboBox.Enabled = true;

            outputUnitComboBox.Items.Add("Pound (lb)");
        }

        private void inputCombo5()
        {
            outputUnitComboBox.Enabled = true;

            outputUnitComboBox.Items.Add("Kilogram (kg)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputUnitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            outputUnitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (inputUnitComboBox.SelectedIndex == 0) //Meter
            {
                if (outputUnitComboBox.SelectedIndex == 0) //Kilometer
                {
                    outputBox.Text = (inputValue / 1000).ToString();
                }

                if (outputUnitComboBox.SelectedIndex == 1) //Feet
                {
                    outputBox.Text = (inputValue * 3.2808399).ToString();
                }

                if (outputUnitComboBox.SelectedIndex == 2) //Miles
                {
                    outputBox.Text = (inputValue * 0.000621371192).ToString();
                }
            }



            if (inputUnitComboBox.SelectedIndex == 1) //Kilometer
            {
                if (outputUnitComboBox.SelectedIndex == 0) //Meter
                {
                    outputBox.Text = (inputValue * 1000).ToString();
                }

                if (outputUnitComboBox.SelectedIndex == 1) //Feet
                {
                    outputBox.Text = (inputValue * 3280.8399).ToString();
                }

                if (outputUnitComboBox.SelectedIndex == 2) //Miles
                {
                    outputBox.Text = (inputValue * 0.621371192).ToString();
                }
            }



            if (inputUnitComboBox.SelectedIndex == 2) //Feet
            {
                if (outputUnitComboBox.SelectedIndex == 0) //Kilometer
                {
                    outputBox.Text = (inputValue * 0.0003048).ToString();
                }

                if (outputUnitComboBox.SelectedIndex == 1) //Meter
                {
                    outputBox.Text = (inputValue * 0.3048).ToString();
                }

                if (outputUnitComboBox.SelectedIndex == 2) //Miles
                {
                    outputBox.Text = (inputValue * 0.000189393939).ToString();
                }
            }



            if (inputUnitComboBox.SelectedIndex == 3) //Miles
            {
                if (outputUnitComboBox.SelectedIndex == 0) //Kilometer
                {
                    outputBox.Text = (inputValue * 1.609344).ToString();
                }

                if (outputUnitComboBox.SelectedIndex == 1) //Meter
                {
                    outputBox.Text = (inputValue * 1609.344).ToString();
                }

                if (outputUnitComboBox.SelectedIndex == 2) //Feet
                {
                    outputBox.Text = (inputValue * 5280).ToString();
                }
            }



            if (inputUnitComboBox.SelectedIndex == 4) //Kilogram
            {
                if (outputUnitComboBox.SelectedIndex == 0) //Pound
                {
                    outputBox.Text = (inputValue * 2.20462262).ToString();
                }
            }



            if (inputUnitComboBox.SelectedIndex == 5) //Pound
            {
                if (outputUnitComboBox.SelectedIndex == 0) //Kilogram
                {
                    outputBox.Text = (inputValue / 2.20462262).ToString();
                }
            }
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            try //else program crashes when inputbox is empty
            {
                inputValue = Convert.ToDouble(inputBox.Text);
            }
            catch { }
        }
    }
}
