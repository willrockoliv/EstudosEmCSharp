using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArvoreBinaria_visual
{

    public partial class Form1 : Form
    {
        private ArvoreBin minhaArvore = new ArvoreBin();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                minhaArvore.Insere(Convert.ToInt32(txtValor.Text));
                textBox1.Text += "Inserido: " + txtValor.Text;
            }
            catch
            {
                MessageBox.Show("Valor inv�lido! Digite apenas n�meros!");
            }
            txtValor.Clear();
            txtValor.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Join(" - ", minhaArvore.ListagemEmOrdem());            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Qtde: " + minhaArvore.QtdeNodosInternos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int altura = minhaArvore.CalculaAlturaArvore();
            MessageBox.Show(altura.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
                        
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                minhaArvore.Remove(Convert.ToInt16(txtValor.Text));
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(minhaArvore.TotalNodosExternos().ToString());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(txtValorPesquisa.Text);

                if (minhaArvore.Pesquisa(valor))
                    MessageBox.Show("Encontrei");
                else
                    MessageBox.Show("N�o Encontrei");
            }
            catch
            {
                MessageBox.Show("Digite um n�mero.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Join(" - ", minhaArvore.ListagemPreFixada());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Join(" - ", minhaArvore.ListagemPosFixada());
        }
    }
    
}