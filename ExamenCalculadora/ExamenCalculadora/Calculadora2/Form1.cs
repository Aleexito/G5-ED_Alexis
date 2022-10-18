using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        Numeros nus = new Numeros();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            text1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            text1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            text1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            text1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            text1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            text1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            text1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            text1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            text1.Text += "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {

            text1.Text += "0";
        }

        //SUMA
        private void btn16_Click(object sender, EventArgs e)
        {
            if (text1.Text == string.Empty)
            {
                text1.Text = "";
            }
            if (text1.Text != string.Empty)
            {
                nus.Num = Convert.ToDouble(text1.Text);
                nus.Opera = "+";
                text2.Text += text1.Text + "+";
                text1.Text = "";
            }
        }

        //RESTA
        private void btn15_Click(object sender, EventArgs e)
        {
            if (text1.Text == string.Empty)
            {
                text1.Text = "";
            }
            if (text1.Text != string.Empty)
            {
                nus.Num = Convert.ToDouble(text1.Text);
                nus.Opera = "-";
                text2.Text += text1.Text + "-";
                text1.Text = "";
            }
        }

        //MULTIPLICACIÓN
        private void btn14_Click(object sender, EventArgs e)
        {
            if (text1.Text == string.Empty)
            {
                text1.Text = "";
            }
            if (text1.Text != string.Empty)
            {
                nus.Num = Convert.ToDouble(text1.Text);
                nus.Opera = "x";
                text2.Text += text1.Text + "x";
                text1.Text = "";
            }
        }

        //DIVISION
        private void btn19_Click(object sender, EventArgs e)
        {

            if (text1.Text == string.Empty)
            {
                text1.Text = "";
            }
            if (text1.Text != string.Empty)
            {
                nus.Num = Convert.ToDouble(text1.Text);
                nus.Opera = "/";
                text2.Text += text1.Text + "/";
                text1.Text = "";
            }
        }

        //RAÍZ
        private void btn13_Click(object sender, EventArgs e)
        {
            if (text1.Text == string.Empty)
            {
                text1.Text = "";
            }
            if (text1.Text != string.Empty)
            {
                nus.Num = Convert.ToDouble(text1.Text);
                nus.Opera = "√";
                text2.Text += text1.Text + "√";
                text1.Text = "";
            }
        }

        //POTENCIA
        private void btn12_Click(object sender, EventArgs e)
        {
            if (text1.Text == string.Empty)
            {
                text1.Text = "";
            }
            if (text1.Text != string.Empty)
            {
                nus.Num = Convert.ToDouble(text1.Text);
                nus.Opera = "^";
                text2.Text += text1.Text + "^";
                text1.Text = "";
            }
        }

        //BOTON PUNTO
        private void btn11_Click(object sender, EventArgs e)
        {
            text1.Text += ".";
        }

        //BOTON AC
        private void btn20_Click(object sender, EventArgs e)
        {
            text1.Clear();
            text2.Clear();
        }

        //BOTON QUITAR UN DIG
        private void btn18_Click(object sender, EventArgs e)
        {
            if (text1.Text.Length == 1)
            {
                text1.Text = "";
            }
            else
            {
                text1.Text = text1.Text.Substring(0, text1.Text.Length - 1);
            }
        }

        //IGUAL
        private void btn17_Click(object sender, EventArgs e)
        {
            if (nus.Opera == "+" || nus.Opera == "." || nus.Opera == "x" || nus.Opera == "/" || nus.Opera == "^" || nus.Opera == "-")
            {
                nus.Num2 = Convert.ToDouble(text1.Text);
                text2.Text += text1.Text;
                text1.Text = "";
            }
            do
            {
                if (nus.Opera == "+")
                {
                    text1.Text = (nus.ResultadoSuma(Convert.ToDouble(nus.Num), Convert.ToDouble(nus.Num2)).ToString());
                }
               
            } while (text1.Text != text1.Text);

            if (nus.Opera == "-")
            {
                text1.Text = (nus.ResultadoResta(Convert.ToDouble(nus.Num), Convert.ToDouble(nus.Num2)).ToString());
            }
            if (nus.Opera == "x")
            {
                text1.Text = (nus.ResultadoMulti(Convert.ToDouble(nus.Num), Convert.ToDouble(nus.Num2)).ToString());
            }
            if (nus.Opera == "/")
            {
                text1.Text = (nus.ResultadoDivi(Convert.ToDouble(nus.Num), Convert.ToDouble(nus.Num2)).ToString());
            }
            if (nus.Opera == "^")
            {
                text1.Text = (nus.ResultadoPotencia(Convert.ToDouble(nus.Num), Convert.ToDouble(nus.Num2)).ToString());
            }
            if (nus.Opera == "√")
            {
                text1.Text = (nus.ResultadoRaiz(Convert.ToDouble(nus.Num)).ToString());
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                text2.Text += "1";
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                text2.Text += "2";
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                text2.Text += "3";
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                text2.Text += "4";
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                text2.Text += "5";
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                text2.Text += "6";
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                text2.Text += "7";
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                text2.Text += "8";
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                text2.Text += "9";
            }
            if (e.KeyCode == Keys.NumPad0)
            {
                text2.Text += "0";
            }
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                text2.Text += ".";
            }
            if (e.KeyCode == Keys.Add)
            {
                btn16.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btn15.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btn14.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                btn19.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btn17.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                btn18.PerformClick();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
