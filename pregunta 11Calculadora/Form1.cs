using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        Stack<double> numeros = new Stack<double>();
        Stack<char> operadores = new Stack<char>();
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += ((Button)sender).Text;
        }

        






        


        private void buttonSuma_Click(object sender, EventArgs e)
        {
            AgregarOperador('+');
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            AgregarOperador('-');

        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            AgregarOperador('*');

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            AgregarOperador('/');
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            AgregarOperador('=');
            RealizarOperacionesPendientes();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            operadores.Clear();
            textBox1.Text = "";

        }

        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            numeros.Clear();
            operadores.Clear();
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void AgregarOperador(char operador)
        {
            double numero;
            if (double.TryParse(textBox1.Text, out numero))
            {
                numeros.Push(numero);
                textBox1.Text = "";

                if (operador != '=')
                {
                    while (operadores.Count > 0 && Precedencia(operador) <= Precedencia(operadores.Peek()))
                    {
                        RealizarOperacion();
                    }
                    operadores.Push(operador);
                }
            }
            else
            {
                MessageBox.Show("Número inválido.");
            }
        }

        private void RealizarOperacionesPendientes()
        {
            while (operadores.Count > 0)
            {
                RealizarOperacion();
            }

            if (numeros.Count == 1)
            {
                textBox1.Text = numeros.Pop().ToString();
            }
        }

        private void RealizarOperacion()
        {
            double num2 = numeros.Pop();
            double num1 = numeros.Pop();
            char operador = operadores.Pop();
            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero");
                        return;
                    }
                    break;
            }

            numeros.Push(resultado);
        }

        private int Precedencia(char operador)
        {
            switch (operador)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }
    } 



}