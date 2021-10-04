using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class Calculadora : Form
    {
        double n1 = 0, n2 = 0;
        char operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }
            txtResultado.Text += boton.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(txtResultado.Text);
            if(operador == '+')
            {
                txtResultado.Text = (n1 + n2).ToString();
                n1 = Convert.ToDouble(txtResultado.Text);
            }else
                if(operador == '-')
            {
                txtResultado.Text = (n1 - n2).ToString();
                n1 = Convert.ToDouble(txtResultado.Text);
            }else
                if(operador == 'X')
            {
                txtResultado.Text = (n1 * n2).ToString();
                n1 = Convert.ToDouble(txtResultado.Text);
            }else
                if(operador == '÷')
            {
                if(txtResultado.Text != "0")
                {
                    txtResultado.Text = (n1 / n2).ToString();
                    n1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    txtResultado.Text = "SINTAX ERROR";
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtResultado.Text);
            n1 *= -1;
            txtResultado.Text = n1.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operacion(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            n1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {
                n1 = Math.Pow(n1, 2);
                txtResultado.Text = n1.ToString();
            }else
                if(operador == '√')
            {
                n1 = Math.Sqrt(n1);
                txtResultado.Text = n1.ToString();
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

    }
}
