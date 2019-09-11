using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//RENAME DESIGNS

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        bool isOperated = false;
        bool isPositive = true;


        public Calculator()
        {
            InitializeComponent();
        }

        private void Num_Click(object sender, EventArgs e)
        {

            if ((calculatorScreen.Text == "0") || isOperated)
                calculatorScreen.Text = "";
            isOperated = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!calculatorScreen.Text.Contains("."))
                    calculatorScreen.Text = calculatorScreen.Text + button.Text;
            }
            else
                calculatorScreen.Text = calculatorScreen.Text + button.Text;
        }

        private void Button24_Click(object sender, EventArgs e)
        {

        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                equal.PerformClick();
                operation = button.Text;
                isOperated = true;
                operationScreen.Text = result + " " + operation + " ";
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(calculatorScreen.Text);
                isOperated = true;
                operationScreen.Text = result + " " + operation + " ";
            }
        }

        private void Clear_Entry_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "0";
            result = 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "0";
            operationScreen.Text = " ";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text.Length != 0)
                calculatorScreen.Text =
                    calculatorScreen.Text.Remove(calculatorScreen.Text.Length - 1, 1);
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    calculatorScreen.Text = (result + Double.Parse(calculatorScreen.Text)).ToString();
                    break;
                case "-":
                    calculatorScreen.Text = (result - Double.Parse(calculatorScreen.Text)).ToString();
                    break;
                case "*":
                    calculatorScreen.Text = (result * Double.Parse(calculatorScreen.Text)).ToString();
                    break;
                case "/":
                    calculatorScreen.Text = (result / Double.Parse(calculatorScreen.Text)).ToString();
                    break;
            }
            //operationScreen.Text = operationScreen.Text + calculatorScreen.Text;
            result = double.Parse(calculatorScreen.Text);
            operationScreen.Text = " ";// NEED TO SEE ALL OPERATION, NEED CHANGING
        }

        private void PosNeg_Click(object sender, EventArgs e)
        {
            if (isPositive)
            {
                calculatorScreen.Text = calculatorScreen.Text.Insert(0, "-");
                isPositive = false;
            }
            else
            {
                calculatorScreen.Text = calculatorScreen.Text.Remove(0, 1);
                isPositive = true;
            }
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            operationScreen.Text = "sqrt" + "(" + calculatorScreen.Text + ")";
            calculatorScreen.Text = Convert.ToString(Math.Sqrt(double.Parse(calculatorScreen.Text)));
            
        }
        //Need to show to operatorscreen

        private void Square_Click(object sender, EventArgs e)
        {
            operationScreen.Text = "sqr" + "(" + calculatorScreen.Text + ")";
            calculatorScreen.Text = Convert.ToString(Math.Pow(double.Parse(calculatorScreen.Text), 2));
        }

        private void OneOver_Click(object sender, EventArgs e)
        {
            operationScreen.Text = "(1/" + calculatorScreen.Text + ")";
            calculatorScreen.Text = Convert.ToString(1 / (double.Parse(calculatorScreen.Text)));
        }
    }
}
