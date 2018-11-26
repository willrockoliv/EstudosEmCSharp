using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

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
            Aluno a = new Aluno();
            a.Codigo = Convert.ToInt32(txtCodigo.Text);
            a.Nome = txtNome.Text;

            minhaLista.InserirNoInicio(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            a.Codigo = Convert.ToInt32(txtCodigo.Text);
            a.Nome = txtNome.Text;

            minhaLista.InserirNoFim(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno();
                a.Codigo = Convert.ToInt32(txtCodigo.Text);
                a.Nome = txtNome.Text;

                minhaLista.InserirNaPosicao(a,(int)edValor.Value);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = minhaLista.Listar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {                

                object valor = minhaLista.RemoverDaPosicao((int)numericUpDown1.Value);
                
                MessageBox.Show((valor as Aluno).ToString());
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ComparadorDeCodigo comparador = new ComparadorDeCodigo();

            Aluno a = new Aluno();
            a.Codigo = Convert.ToInt32(textBox2.Text);

            if (minhaLista.Pesquisa(a, comparador) == true)
                MessageBox.Show("O dado existe");
            else
                MessageBox.Show("O dado NÃO existe");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            minhaLista.Listar(minhaLista.RetornaPrimeiro());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ComparadorDeCodigo comparador = new ComparadorDeCodigo();
            minhaLista = BubbleSort.Ordena_BubbleSort(minhaLista, comparador);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ComparadorDeNome comparador = new ComparadorDeNome();
            minhaLista = BubbleSort.Ordena_BubbleSort(minhaLista, comparador);
        }

       
        
        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Aluno dado in minhaLista)
            {
                textBox1.Text += Environment.NewLine + dado.ToString();                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        

    }
}
