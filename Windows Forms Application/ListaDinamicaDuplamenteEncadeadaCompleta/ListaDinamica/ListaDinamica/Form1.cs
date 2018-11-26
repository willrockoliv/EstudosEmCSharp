using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListaDinamica
{
    public partial class Form1 : Form
    {

        Lista minhaLista = new Lista();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minhaLista.InserirNoInicio(txtValor.Text);
            txtValor.Clear();
            txtValor.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minhaLista.InserirNoFim(txtValor.Text);
            txtValor.Clear();
            txtValor.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                minhaLista.InserirNaPosicao(txtValor.Text, (int)edValor.Value);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = minhaLista.ListarIterativo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = minhaLista.RemoverDaPosicao((int)numericUpDown1.Value);
                MessageBox.Show(valor);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (minhaLista.Pesquisa(textBox2.Text) == true)
                MessageBox.Show("O dado existe");
            else
                MessageBox.Show("O dado NÃO existe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = minhaLista.ListarRecursivo();
        }
    }
}
