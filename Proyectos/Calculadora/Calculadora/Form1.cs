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
    public partial class Form1 : Form
    {
        double Numero1=0;
        double Numero2 = 0;
        char Operador;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void agregar_numero(object sender, EventArgs e) {
            var button = ((Button)sender);
            if (txtResultado.Text=="0") {
                txtResultado.Text = "";
                txtResultado.Text += button.Text;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }
        private void clickOperador(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador =Convert.ToChar ( button.Text);
        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = '+';
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);

            if (Operador == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '−')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == 'X')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '∕')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!!");
                }
            }
        }
    }
}
