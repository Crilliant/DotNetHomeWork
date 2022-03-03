using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCaculator
{
    public partial class Form1 : Form
    {
        double num1=0,num2=0,result;
        string op;
        bool isFirstNum = true;//是否为第一个运算数
        public Form1()
        {
            InitializeComponent();
        }
        private void InputDigit(int buttonNum)
        {
            textBox1.Text += buttonNum.ToString();
            if (isFirstNum)
            {
                num1 = 10 * num1 + buttonNum;
            }
            else
            {
                num2 = 10 * num2 + buttonNum;

            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            InputDigit(0);
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            InputDigit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputDigit(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputDigit(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputDigit(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InputDigit(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InputDigit(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            InputDigit(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            InputDigit(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputDigit(9);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //运算符
        private void button19_Click(object sender, EventArgs e)
        {
            isFirstNum = true;
            textBox1.Text = "";
            num1 = num2 = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = "+";
            isFirstNum = false;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = "-";
            isFirstNum = false;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op = "*";
            isFirstNum = false;
            textBox1.Text = "";
        }
 

        private void button16_Click(object sender, EventArgs e)
        {
            op = "/";
            isFirstNum = false;
            textBox1.Text = "";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            result = Calculator.Calculate(num1, num2, op);
            if (double.IsNaN(result))
            {
                Console.WriteLine("We have got a mathematical error.\n");
                return;
            }
            else
            {
                textBox1.Text=result.ToString();    
            }
        }

    }
    class Calculator
    {
        static public double Calculate(double num1, double num2, string op)
        {
            double result = double.NaN;//result默认为NaN
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    //如果num2==0，result 不会抛异常，而是等于无穷
                    if (num2 != 0)
                        result = num2 / num1;
                    break;

                default://这里result =NaN
                    break;
            }
            return result;
        }

    }
}
