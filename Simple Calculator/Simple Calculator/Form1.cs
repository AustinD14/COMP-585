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
        public Calculator()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void Button20_Click(object sender, EventArgs e)
        {

        }


        private void Button21_Click(object sender, EventArgs e)
        {

        }


        private void Plus_Click(object sender, EventArgs e)
        {

        }

        public void CalculatorScreen(object sender, EventArgs e)
        {
            
        }

        private void Num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculatorScreen.Text = calculatorScreen.Text + button.Text;
            
        }
    }
}
