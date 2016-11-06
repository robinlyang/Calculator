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
        string number1, number2, operation;
        double value1, value2, total;

        private void plusBtn_Click(object sender, EventArgs e)
        {
            operation = "+";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            operation = "-";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            operation = "*";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(number1);
            value2 = Convert.ToDouble(number2);
            if(operation=="+")
            {
                total = value1 + value2;
            }
            if (operation == "-")
            {
                total = value1 - value2;
            }
            if (operation == "*")
            {
                total = value1 * value2;
            }
            if (operation == "/")
            {
                total = value1 / value2;
            }
            AnswerTxtBox.Text = total.ToString();
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + ".";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + ".";
                AnswerTxtBox.Text = number2;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            AnswerTxtBox.Text = "";
            number1 = "";
            number2 = "";
            operation = "";
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + "2";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "2";
                AnswerTxtBox.Text = number2;
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + "3";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "3";
                AnswerTxtBox.Text = number2;
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + "4";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "4";
                AnswerTxtBox.Text = number2;
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + "5";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "5";
                AnswerTxtBox.Text = number2;
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + "6";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "6";
                AnswerTxtBox.Text = number2;
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + "7";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "7";
                AnswerTxtBox.Text = number2;
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + "18";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "8";
                AnswerTxtBox.Text = number2;
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + "9";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "9";
                AnswerTxtBox.Text = number2;
            }
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 + "0";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "0";
                AnswerTxtBox.Text = number2;
            }
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnswerTxtBox.Text = "";
            number1 = "";
            number2 = "";
            operation = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation = "/";
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if(operation=="")
            {
                number1 = number1 + "1";
                AnswerTxtBox.Text = number1;
            }
            else
            {
                number2 = number2 + "1";
                AnswerTxtBox.Text = number2;
            }
        }
    }
}
