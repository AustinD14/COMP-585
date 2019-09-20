using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        bool isOperated = false;
        bool isPositive = true;
        bool isEqualed = false;
        History historyForm = new History();


        public Calculator()
        {
            InitializeComponent();
        }



        private void Num_Click(object sender, EventArgs e)
        {

            if ((calculatorScreen.Text == "0") || isOperated)
                calculatorScreen.Text = "";

            if(isEqualed)
            {
                calculatorScreen.Text = "";
                result = 0;
            }
   
            isOperated = false;
            isEqualed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!calculatorScreen.Text.Contains("."))
                    calculatorScreen.Text = calculatorScreen.Text + button.Text;
            }
            else
                calculatorScreen.Text = calculatorScreen.Text + button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                operationScreen.Text = operationScreen.Text + " " + calculatorScreen.Text + " " + operation + " ";
                Equal();
                operation = button.Text;
                isOperated = true;
            }

            else
            {
                operation = button.Text;
                result = Double.Parse(calculatorScreen.Text);
                operationScreen.Text = calculatorScreen.Text + " " + operation;
                isOperated = true;
            }
        }

        private void Clear_Entry_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "0";
            operationScreen.Text = " ";
            result = 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            calculatorScreen.Text = "0";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (calculatorScreen.Text.Length != 0)
                calculatorScreen.Text =
                    calculatorScreen.Text.Remove(calculatorScreen.Text.Length - 1, 1);
        }

        private void Equal()
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
           // historyForm.historyData(calculatorScreen.Text);
            result = double.Parse(calculatorScreen.Text);
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            isEqualed = true;
            historyForm.historyData(operationScreen.Text + " " + calculatorScreen.Text + "\n", isEqualed);
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
            result = double.Parse(calculatorScreen.Text);
            historyForm.historyData(calculatorScreen.Text + "\n\n", isEqualed);
            operationScreen.Text = " ";
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
            operationScreen.Text = operationScreen.Text+ "sqrt" + "(" + calculatorScreen.Text + ")";
            calculatorScreen.Text = Convert.ToString(Math.Sqrt(double.Parse(calculatorScreen.Text)));
            
        }

        private void Square_Click(object sender, EventArgs e)
        {
            operationScreen.Text = operationScreen.Text + "sqr" + "(" + calculatorScreen.Text + ")";
            calculatorScreen.Text = Convert.ToString(Math.Pow(double.Parse(calculatorScreen.Text), 2));
        }

        private void OneOver_Click(object sender, EventArgs e)
        {
            operationScreen.Text = operationScreen.Text + "(1/" + calculatorScreen.Text + ")";
            calculatorScreen.Text = Convert.ToString(1 / (double.Parse(calculatorScreen.Text)));
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            if (operationScreen.Text != "" || operationScreen.Text != " "|| operationScreen.Text != null)
            {
                operationScreen.Text = operationScreen.Text + "0";
                calculatorScreen.Text = "0";
            }
            else
            {
            //    calculatorScreen.Text = Convert.ToString(result * double.Parse(calculatorScreen.Text.Insert());
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            //Form calculatorScreen = new Form();
            historyForm.Show();
        }


    }
}
