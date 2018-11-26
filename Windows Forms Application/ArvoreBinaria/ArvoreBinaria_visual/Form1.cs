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
                MessageBox.Show("Valor inválido! Digite apenas números!");
            }
            txtValor.Clear();
            txtValor.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = minhaArvore.ListagemEmOrdem();            
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
            /*int altura = minhaArvore.Altura();            
            MessageBox.Show(altura.ToString()); */
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
        
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (minhaArvore.Pesquisa(Convert.ToInt32(txtValorPesquisa.Text)) == true)
                txtValorPesquisa.Text = "True";
            else
                txtValorPesquisa.Text = "False";
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}