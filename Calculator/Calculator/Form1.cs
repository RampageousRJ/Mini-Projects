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
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string op1 = string.Empty;
        string sign = string.Empty;
        string op2 = string.Empty;
        double res = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "0";
            this.richTextBox1.Text += input;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "1";
            this.richTextBox1.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "2";
            this.richTextBox1.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "3";
            this.richTextBox1.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "4";
            this.richTextBox1.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "5";
            this.richTextBox1.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "6";
            this.richTextBox1.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "7";
            this.richTextBox1.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "8";
            this.richTextBox1.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = string.Empty;
            input = input + "9";
            this.richTextBox1.Text += input;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            op1 = input;
            sign = "+";
            input = string.Empty;
            this.textBox1.Text = sign;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            op1 = input;
            sign = "-";
            input = string.Empty;
            this.textBox1.Text = sign;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            op1 = input;
            sign = "X";
            input = string.Empty;
            this.textBox1.Text = sign;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            op1 = input;
            sign = "/";
            input = string.Empty;
            this.textBox1.Text = sign;
        }

        private void Power_Click(object sender, EventArgs e)
        {
            op1 = input;
            sign = "^";
            input = string.Empty;
            this.textBox1.Text = sign;
        }

        private void Root_Click(object sender, EventArgs e)
        {
            op1 = input;
            input = string.Empty;
            sign = "root";
            this.textBox1.Text = "root";
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            op1 = input;
            sign = "%";
            input = string.Empty;
            this.textBox1.Text = sign;
        }

        private void Log10_Click(object sender, EventArgs e)
        {
            op1 = input;
            input = string.Empty;
            sign = "log10";
            this.textBox1.Text = "log10";
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            op2 = input;
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);
            if (sign == "+") {
                res = num1 + num2;
                this.richTextBox1.Text = res.ToString();
                input = res.ToString();
            }
            else if (sign == "-") {
                res = num1 - num2;
                this.richTextBox1.Text = res.ToString();
                input = res.ToString();
            }
            else if (sign == "X")
            {
                res = num1 * num2;
                this.richTextBox1.Text = res.ToString();
                input = res.ToString();
            }
            else if (sign == "/")
            {
                if (num2 != 0)
                {
                    res = num1 / num2;
                    this.richTextBox1.Text = res.ToString();
                    input = res.ToString();
                }
                else {
                    this.richTextBox1.Text = "ERROR: Division with zero";
                    input = string.Empty;
                }
            }
            else if (sign == "^") {
                res = Math.Pow(num1,num2);
                this.richTextBox1.Text = res.ToString();
                input = res.ToString();
            }
            else if (sign == "root")
            {
                if (op2 == string.Empty)
                {
                    res = Math.Pow(num1, 0.5);
                    this.richTextBox1.Text = res.ToString();
                    input = res.ToString();
                }
                
            }
            else if (sign == "%")
            {
                res = num1 % num2;
                this.richTextBox1.Text = res.ToString();
                input = res.ToString();
            }
            else if (sign == "log10")
            {
                if (op2 == string.Empty)
                {
                    res = Math.Log10(num1);
                    this.richTextBox1.Text = res.ToString();
                    input = res.ToString();
                }

            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            this.richTextBox1.Text = string.Empty;
            op1 = string.Empty;
            op2 = string.Empty;
            sign = string.Empty;
            this.textBox1.Text = string.Empty;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
