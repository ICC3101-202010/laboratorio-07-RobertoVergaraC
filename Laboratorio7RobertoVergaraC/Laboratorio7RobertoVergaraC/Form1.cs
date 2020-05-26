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
        List<string> historial2 = new List<string>();

        public Form1()
        {
            InitializeComponent();
            HisitorialPanel.Visible = false;
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
                    Screen2.Text = Screen2.Text + Screen.Text + "=";
                    Screen.Text = Sum.ToString();
                    first = 0;
                    second = 0;
                    historial2.Add(Screen2.Text + Screen.Text);
                }
                else if (operador == "-")
                {
                    Res = resta.Restar(first, second);
                    ans = Res;
                    Screen2.Text = Screen2.Text + Screen.Text + "=";
                    Screen.Text = Res.ToString();
                    first = 0;
                    second = 0;
                    historial2.Add(Screen2.Text + Screen.Text);
                }
                else if (operador == "X")
                {
                    Mul = multiplicacion.Multiplicar(first, second);
                    ans = Mul;
                    Screen2.Text = Screen2.Text + Screen.Text + "=";
                    Screen.Text = Mul.ToString();
                    first = 1;
                    second = 1;
                    historial2.Add(Screen2.Text + Screen.Text);
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
                        Screen2.Text = Screen2.Text + Screen.Text + "=";
                        Screen.Text = Div.ToString();
                        historial2.Add(Screen2.Text + Screen.Text);
                    }
                    first = 1;
                    second = 1;
                }
            }
            catch
            {
                Screen.Text = "SINTAX ERROR";
            }  
        }

        private void ANS_Click(object sender, EventArgs e)
        {
            Screen.Text = ans.ToString();
            if (operador == "+")
            {
                first = 0;
                second = 0;
            }
            else if (operador == "-")
            {
                first = 0;
                second = 0;
            }
            else if (operador == "X")
            {
                first = 1;
                second = 1;
            }
            else if (operador == "÷")
            {
                first = 1;
                second = 1;
            }
            Screen2.Clear();
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
                Screen2.Text = first.ToString() + "-";
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
                Screen2.Text = first.ToString() + "+";
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
                Screen2.Text = first.ToString() + "÷";
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
                Screen2.Text = first.ToString() + "X";
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
            Screen2.Clear();
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 1)
                Screen.Text = "0";
            else
                Screen.Text = Screen.Text.Substring(0, Screen.Text.Length - 1);
            Screen2.Clear();
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

        private void HisitorialPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HistorialButton_Click(object sender, EventArgs e)
        {
            HisitorialPanel.Visible = true;
            ImprimirValoresHistorial();
        }

        private void VolverCalculadoraButton_Click(object sender, EventArgs e)
        {
            HisitorialPanel.Visible = false;
        }

        private void BorrarHisotrialButton_Click(object sender, EventArgs e)
        {
            historial2.Clear();
            ValoresHistorialTextBox.Text = "";
        }

        private void ValoresHistorialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImprimirValoresHistorial()
        {
            foreach (string datos in historial2)
            {
                ValoresHistorialTextBox.Text += datos + "\r\n";
            }
        }
    }
}
