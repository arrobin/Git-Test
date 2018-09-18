using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

       Calculator aCalculator =new Calculator();
        //this funtion shows 2 numbers addition
        private void addButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Add(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Subtract(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Multiply(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Divide(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }
    }
}
