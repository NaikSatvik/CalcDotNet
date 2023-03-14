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
    public partial class calc_form : Form
    {
        public calc_form()
        {
            InitializeComponent();
        }

        private void calc_form_Load(object sender, EventArgs e)
        {

        }

        static Boolean containsOperator(string displayBoxText)
        {
            char[] operators = { '+', '-', '*', '/', '%' };
            char sign = ' ';
            bool flag = false;

            if (string.IsNullOrEmpty(displayBoxText) == true)
            {
                return true;
            }

            // finding operator
            for (int i = 0; i < operators.Length; i++)
            {
                if (displayBoxText.Contains(operators[i]) == true)
                {
                    sign = operators[i];
                    flag = true;
                }
            }
            return flag;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.display.Text += 9;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.display.Text += 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.display.Text += 8;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.display.Text += 6;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.display.Text += 5;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.display.Text += 4;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.display.Text += 3;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.display.Text += 2;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.display.Text += 1;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.display.Text += 0;
        }

        private void doubleZero_Click(object sender, EventArgs e)
        {
            this.display.Text += "00";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (containsOperator(this.display.Text) == true)
            {

            } else
            {
                this.display.Text += '/';
            } 
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (containsOperator(this.display.Text) == true)
            {

            }
            else
            {
                this.display.Text += '*';
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (containsOperator(this.display.Text) == true)
            {

            }
            else
            {
                this.display.Text += '-';
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (containsOperator(this.display.Text) == true)
            {

            }
            else
            {
                this.display.Text += '+';
            }
        }

        private void modulo_Click(object sender, EventArgs e)
        {
            if (containsOperator(this.display.Text) == true)
            {

            }
            else
            {
                this.display.Text += '%';
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            string displayBoxText = display.Text;
            // Console.WriteLine(displayBoxText);

            char[] operators = {'+', '-', '*', '/', '%'};
            char sign = ' ';

            // finding operator
            for (int i=0;i<operators.Length;i++)
            {
                if (displayBoxText.Contains(operators[i]) == true)
                {
                    sign = operators[i];
                }
            }

            String[] operands = displayBoxText.Split(sign);

            switch (sign)
            {
                case '+':
                    display.Clear();
                    this.display.Text += float.Parse(operands[0]) + float.Parse(operands[1]);
                    break;

                case '-':
                    display.Clear();
                    this.display.Text += float.Parse(operands[0]) - float.Parse(operands[1]);
                    break;

                case '/':
                    display.Clear();
                    if (float.Parse(operands[1]) == 0)
                    {
                        this.display.Text += 0;
                    } else
                    {
                        this.display.Text += float.Parse(operands[0]) / float.Parse(operands[1]);
                    }
                    break;

                case '*':
                    display.Clear();
                    this.display.Text += float.Parse(operands[0]) * float.Parse(operands[1]);
                    break;

                case '%':
                    display.Clear();
                    this.display.Text += float.Parse(operands[0]) % float.Parse(operands[1]);
                    break;
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.display.Text += '.';
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if ((String.Compare(display.Text, " ") < 0))
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1 + 1);
            }
            else
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void display_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
