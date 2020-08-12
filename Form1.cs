using RestoDaDivisao.Utilitario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDaDivisao
{
    public partial class FormRstDivisao : Form
    {
        Calculadora calc = new Calculadora();

        public FormRstDivisao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                try
                {
                    double dividendo = double.Parse(textBox1.Text);

                    double divisor = double.Parse(textBox2.Text);

                    double resto = calc.RetornaResto(dividendo, divisor);

                    double valor = calc.RetornaValor(dividendo, divisor);

                    textBox3.Text = Convert.ToString(resto);

                    textBox4.Text = Convert.ToString(valor);
                }
                catch (ArgumentException erro)
                {
                    MessageBox.Show(erro.Message,"Coé");
                    throw;
                }
            } while (true);


        }

    }
}
