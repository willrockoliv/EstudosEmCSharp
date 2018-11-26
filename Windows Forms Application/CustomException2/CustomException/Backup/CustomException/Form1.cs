using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CustomException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt16(textBox1.Text);
                if (numero < 0)
                    throw new InteiroNegativoExceptioon(numero);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int numero = Convert.ToInt16(textBox1.Text);
                if (numero < 0)
                    throw new InteiroNegativoExceptioon("Presta atenção! Digite só números positivos!");
                if (numero > 100)
                    throw new InteiroMaiorQueCemException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números");
            }
            catch (InteiroNegativoExceptioon erro)
            {
                MessageBox.Show(erro.Message);
            }
            catch (InteiroMaiorQueCemException erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
    }
}
