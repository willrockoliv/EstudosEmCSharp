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
        /*struct Cadastro
        {
            public string nome, tel;
        }*/
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

            /*
            frPesquisa.Cadastro[] Cadastro;
            Cadastro[] Cadastro = new Cadastro[Pesquisa.arquivo.Length];
            if (Pesquisa.posicao == -1)
                return;
            */

            if (Pesquisa.ok == false)
                return;
            else
            {
                /* Não consigo chamar a struct Cadastro da frPesquisa
                lblNome.Text = Cadastro[Pesquisa.posicao].nome; //Pesquisa.Cadastro[Pesquisa.posicao].nome;
                lblTel.Text = Cadastro[Pesquisa.posicao].tel; //Cadastro[Pesquisa.posicao].tel;
                */

                lblNome.Text = Pesquisa.nome_pesquisa;
                lblTel.Text = Pesquisa.tel_pesquisa;
            }
        }
    }
}
