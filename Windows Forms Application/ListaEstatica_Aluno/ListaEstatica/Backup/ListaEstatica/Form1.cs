using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListaEstatica
{
    public partial class Form1 : Form
    {
        Lista listaAlunos = new Lista();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaAlunos.Pesquisa(Convert.ToInt32(txtRA.Text)) != null)
                    throw new Exception("Este RA já está cadastrado!");
                Aluno a = new Aluno(Convert.ToInt32(txtRA.Text), txtNome.Text);
                listaAlunos.insereNoFim(a);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números no RA");
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
                Aluno a = listaAlunos.removeDaPosicao(
                                      Convert.ToInt32(txtPosRemove.Text));

                txtSaida.Text += a.Ra + " - " + a.Nome + Environment.NewLine;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = listaAlunos.RetornaPrimeiro();

                txtSaida.Text += a.Ra + " - " + a.Nome + Environment.NewLine;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = listaAlunos.RetornaUltimo();

                txtSaida.Text += a.Ra + " - " + a.Nome + Environment.NewLine;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = listaAlunos.Pesquisa(
                    Convert.ToInt32(txtRAPEsq.Text));

                if (a == null)
                    MessageBox.Show("RA não cadastrado na lista");
                else
                    txtSaida.Text += a.Ra + " - " + a.Nome + Environment.NewLine;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSaida.Text += listaAlunos.ImprimeLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string a = "1";
            char u = '1';
            txtNome.Text = (Convert.ToInt16(a)).ToString() + " " +((int)u).ToString(); 

        }
    }
}
