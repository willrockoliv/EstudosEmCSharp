using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        private ArvoreBinaria minhaArvore = new ArvoreBinaria();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            try
            {
                minhaArvore.Insere(Convert.ToInt32(txtValor.Text));
                listBox1.Items.Add("Inserido: " + txtValor.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string r = minhaArvore.ListagemEmOrdem();
            if (r.Length == 0)
                listBox1.Items.Add("Árvore vazia!");
            else
                listBox1.Items.Add(r);
        }

        private void btnQtdeNosInternos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Qtde: " + minhaArvore.QtdeNodosInternos());
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                minhaArvore.Remove(Convert.ToInt16(txtValor.Text));
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnArvoreTeste_Click(object sender, EventArgs e)
        {
            //Valores para criar uma árvore com o objetivo de facilitar os testes...
            minhaArvore.Insere(58);
            minhaArvore.Insere(31);
            minhaArvore.Insere(25);
            minhaArvore.Insere(42);
            minhaArvore.Insere(12);
            minhaArvore.Insere(36);
            minhaArvore.Insere(90);
            minhaArvore.Insere(62);
            minhaArvore.Insere(75);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //int test;
            Nodo no_aux;
            if (Int32.TryParse(txtValor.Text, out int test))
            {
                no_aux = minhaArvore.PesquisaValor(test, minhaArvore.raiz);
                if (no_aux.EhInterno())
                    listBox1.Items.Add("Valor " + txtValor.Text + " existente na árvore");
                else
                    listBox1.Items.Add("Valor " + txtValor.Text + " não encontrado");
            }
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Altura: " + minhaArvore.Altura());
        }

        private void btnQtdeNosExternos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Qtde: " + minhaArvore.QtdeNodosExternos());
        }
    }
}
