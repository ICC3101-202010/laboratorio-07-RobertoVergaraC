using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio7RobertoVergaraC
{
    public partial class Form1 : Form
    {
        double first;
        double second;
        string operador;
        double ans;

        public Form1()
        {
            InitializeComponent();
        }

        Suma suma = new Suma();
        Resta resta = new Resta();
        Multiplicación multiplicacion = new Multiplicación();
        División division = new División();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void igual_Click(object sender, EventArgs e)
        {
            try
            {
                second = double.Parse(Screen.Text);

                double Sum;
                double Res;
                double Mul;
                double Div;

                if (operador == "+")
                {
                    Sum = suma.Sumar(first, second);
                    ans = Sum;
                    Screen.Text = Sum.ToString();
                }
                else if (operador == "-")
                {
                    Res = resta.Restar(first, second);
                    ans = Res;
                    Screen.Text = Res.ToString();
                }
                else if (operador == "X")
                {
                    Mul = multiplicacion.Multiplicar(first, second);
                    ans = Mul;
                    Screen.Text = Mul.ToString();
                }
                else if(operador== "÷")
                {
                    Div = division.Dividir(first, second);
                    if (second == 0)
                    {
                        Screen.Text = "MATH ERROR";
                    }
                    else
                    {
                        ans = Div;
                        Screen.Text = Div.ToString();
                    }
                }
            }
            catch
            {
                Screen.Text = "SINTAX ERROR";
            }  
        }

        private void ANS_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + ans.ToString();
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + ",";
        }

        private void number0_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "0";
        }

        private void rest_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "-";
                first = double.Parse(Screen.Text);
                Screen.Clear();
            }
            catch
            {
                Screen.Clear();
                Screen.Text = "SINTAX ERROR";
            }
        }

        private void number3_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "3";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "2";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "+";
                first = double.Parse(Screen.Text);
                Screen.Clear();
            }
            catch
            {
                Screen.Clear();
                Screen.Text = "SINTAX ERROR";
            }
        }

        private void number1_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "1";
        }

        private void div_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "÷";
                first = double.Parse(Screen.Text);
                Screen.Clear();
            }
            catch
            {
                Screen.Clear();
                Screen.Text = "SINTAX ERROR";
            }
        }

        private void mult_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "X";
                first = double.Parse(Screen.Text);
                Screen.Clear();
            }
            catch
            {
                Screen.Clear();
                Screen.Text = "SINTAX ERROR";
            }
        }

        private void number5_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "6";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "4";
        }

        private void AC_Click(object sender, EventArgs e)
        {
            Screen.Clear();
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 1)
                Screen.Text = "0";
            else
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
        }

        private void number9_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "9";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "8";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            Screen.Text = Screen.Text + "7";
        }
    }
}
