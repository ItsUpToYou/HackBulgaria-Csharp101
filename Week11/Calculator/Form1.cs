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
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        decimal result = 0;

        private void numbersAdd_Click(object sender, EventArgs e)
        {

            Button sendBtn = sender as Button;
            this.textBox1.Text += sendBtn.Text;
            input = this.textBox1.Text;

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.result = 0;
            counter = 0;
        }

        private void btnЕqual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            decimal num1, num2;
            decimal.TryParse(operand1, out num1);
            decimal.TryParse(operand2, out num2);

            if (operation == '+')
            {
                if (counter > 1)
                {
                    result += num2;
                    textBox1.Text = result.ToString();
                    operand1 = string.Empty;
                }
                else
                {
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    operand1 = string.Empty;
                }
            }
            else if (operation == '-')
            {
                if (counter > 1)
                {
                    result -= num2;
                    textBox1.Text = result.ToString();
                    operand1 = string.Empty;
                }
                else
                {
                    result = num1 - num2;
                    this.textBox1.Text = result.ToString();
                }

            }
            else if (operation == '*')
            {
                if (counter > 1)
                {
                    result = result * num2;
                    textBox1.Text = result.ToString();
                    operand1 = string.Empty;
                }
                else
                {
                    result = num1 * num2;
                    this.textBox1.Text = result.ToString();
                }
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    if (counter > 1)
                    {
                        result /= num2;
                        textBox1.Text = result.ToString();
                        operand1 = string.Empty;
                    }
                    else
                    {
                        result = num1 / num2;
                        this.textBox1.Text = result.ToString();
                    }
                }
                else
                {
                    textBox1.Text = "Div/Zero";
                }

            }
        }

        private void arithmetic(object sender, EventArgs e)
        {

            if (sender == btnAdd)
            {
                operand1 = input;
                operation = '+';
                input = string.Empty;
                textBox1.Clear();
                counter++;
            }
            else if (sender == btnMinus)
            {
                operand1 = input;
                operation = '-';
                input = string.Empty;
                textBox1.Clear();
                counter++;
            }
            else if (sender == btnMultiple)
            {
                operand1 = input;
                operation = '*';
                input = string.Empty;
                textBox1.Clear();
                counter++;
            }
            else if (sender == btnDivide)
            {
                operand1 = input;
                operation = '/';
                input = string.Empty;
                textBox1.Clear();
                counter++;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }

        }
    }
}
