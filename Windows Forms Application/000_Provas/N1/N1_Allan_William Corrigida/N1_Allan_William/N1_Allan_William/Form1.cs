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

namespace N1_Allan_William
{
    public partial class Form1 : Form
    {
        struct Cadastro
        {
            public string nome, tel;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frAgenda Cadastro = new frAgenda();
            Cadastro.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frPesquisa Pesquisa = new frPesquisa();
            Pesquisa.ShowDialog();
            
            if (Pesquisa.posicao == -1)
                return;
            else
            {
                lblNome.Text = Pesquisa.nome_procurado;
                lblTel.Text = Pesquisa.telefone_procurado;
            }
        }        
    }
}
