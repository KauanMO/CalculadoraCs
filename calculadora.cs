using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstForm
{
    public partial class calculadora : Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text +="7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text +="4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text +="5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            } else if (operacao == "MULTIPLICACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISAO")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lbResultado.Text = "-";
            } else
            {
                lbResultado.Text = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lbResultado.Text = "x";
            } else
            {
                lbResultado.Text = "x";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != ""){

                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISAO";
                lbResultado.Text = "/";
            } else
            {
                lbResultado.Text = "/";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lbResultado.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lbResultado.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            lbResultado.Text = "+";
            } else {
                lbResultado.Text = "+";
            }
        }
    }
}
