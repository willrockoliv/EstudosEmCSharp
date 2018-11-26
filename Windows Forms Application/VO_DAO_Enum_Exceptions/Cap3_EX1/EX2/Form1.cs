using Biblioteca.DAO;
using Biblioteca.VOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                JogosVO jogo = new JogosVO();
                jogo.CategoriaID = 1;
                jogo.Data_aquisicao = Convert.ToDateTime("10/12/2018");
                jogo.Descricao = "God of War";
                jogo.Valor_locacao = 25.10;
                jogo.Id = 1;

                JogosDAO.Inserir(jogo);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                JogosVO jogo = new JogosVO();
                jogo.Id = 1;
                jogo.Descricao = "God of War 3";
                jogo.Data_aquisicao = Convert.ToDateTime("10/02/2019");
                jogo.Valor_locacao = 25.10;
                jogo.CategoriaID = 1;

                JogosDAO.Alterar(jogo);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                JogosDAO.Excluir(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
