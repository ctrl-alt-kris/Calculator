using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty; //String storing user input
        string numOneString = string.Empty; //string saving first number
        string numTwoString = string.Empty; //string saving second number
        char operation; // char saving the operator
        double result = 0.0; //result
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            input += ".";
            this.textBox1.Text = input;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            numOneString = string.Empty;
            numTwoString = string.Empty;
            this.textBox1.Text = input;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            input += "0";
            this.textBox1.Text = input;
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            input += "1";
            this.textBox1.Text = input;
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            input += "2";
            this.textBox1.Text = input;
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            input += "3";
            this.textBox1.Text = input;
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            input += "4";
            this.textBox1.Text = input;
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            input += "5";
            this.textBox1.Text = input;
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            input += "6";
            this.textBox1.Text = input;
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            input += "7";
            this.textBox1.Text = input;
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            input += "8";
            this.textBox1.Text = input;
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            input += "9";
            this.textBox1.Text = input;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            operation = '/';
            numOneString = input;
            input = string.Empty;
            this.textBox1.Text = input;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            operation = '*';
            numOneString = input;
            input = string.Empty;
            this.textBox1.Text = input;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            operation = '+';
            numOneString = input;
            input = string.Empty;
            this.textBox1.Text = input;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            operation = '-';
            numOneString = input;
            input = string.Empty;
            this.textBox1.Text = input;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            numTwoString = input;
            input = string.Empty;
            double num1, num2;
            double.TryParse(numOneString, out num1);
            double.TryParse(numTwoString, out num2);
            if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "You want to destroy the universe? No dividing by 0!";
                }
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
        }
    }
}
