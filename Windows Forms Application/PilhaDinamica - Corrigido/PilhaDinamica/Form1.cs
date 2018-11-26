using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PilhaDinamica
{
    public partial class Form1 : Form
    {
        Pilha pilha = new Pilha();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpilhar_Click(object sender, EventArgs e)
        {
            pilha.Empilhar(txtValor.Text);
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnDesempilhar_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = pilha.Desempilhar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pilha.Quantidade.ToString());
        }

        private void btnRetornaTopo_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = pilha.RetornaTopo();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("topo: " + pilha.Listar() + " :base");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValor.Focus();
        }
    }
}
