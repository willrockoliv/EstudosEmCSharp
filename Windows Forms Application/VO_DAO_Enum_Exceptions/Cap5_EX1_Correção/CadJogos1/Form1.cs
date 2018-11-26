using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.Vos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadJogos1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerenciaCamposTela(EnumModoOperacao.inclusao);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            GerenciaCamposTela(EnumModoOperacao.alteracao);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                JogoDAO.Excluir(Convert.ToInt32(txtId.Text));
                btnPrimeiro.PerformClick();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Primeiro();
            PreencheTela(j);
        }

        private void PreencheTela(JogoVO j)
        {
            if (j != null)
            {
                txtId.Text = j.Id.ToString();
                txtDescricao.Text = j.Descricao;
                txtCategoria.Text = j.CategoriaId.ToString();
                txtData.Text = j.Data.ToShortDateString();
                txtPreco.Text = j.valor.ToString();

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Anterior(Convert.ToInt32(txtId.Text));
            PreencheTela(j);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Proximo(Convert.ToInt32(txtId.Text));
            PreencheTela(j);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Ultimo();
            PreencheTela(j);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrimeiro.PerformClick();
            GerenciaCamposTela(EnumModoOperacao.navegacao);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                JogoVO j = new JogoVO();
                j.Id = Convert.ToInt32(txtId.Text);
                j.Descricao = txtDescricao.Text;
                j.valor = Convert.ToDouble(txtPreco.Text);
                j.CategoriaId = Convert.ToInt32(txtCategoria.Text);
                j.Data = Convert.ToDateTime(txtData.Text);

                if (txtId.Enabled)
                    JogoDAO.Incluir(j);
                else
                    JogoDAO.Alterar(j);
                GerenciaCamposTela(EnumModoOperacao.navegacao);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }



        private void GerenciaCamposTela(EnumModoOperacao modo)
        {
            btnIncluir.Enabled = modo == EnumModoOperacao.navegacao;
            btnAlterar.Enabled = modo == EnumModoOperacao.navegacao;
            btnExcluir.Enabled = modo == EnumModoOperacao.navegacao;

            btnGravar.Enabled = modo != EnumModoOperacao.navegacao;
            btnCancelar.Enabled = modo != EnumModoOperacao.navegacao;

            btnPrimeiro.Enabled = btnAnterior.Enabled =
            btnProximo.Enabled = btnUltimo.Enabled = modo == EnumModoOperacao.navegacao;

            txtDescricao.Enabled = txtCategoria.Enabled =
            txtPreco.Enabled = txtData.Enabled =
            modo != EnumModoOperacao.navegacao;
            txtId.Enabled = modo == EnumModoOperacao.inclusao;

            if (modo == EnumModoOperacao.inclusao)
            {
                txtId.Clear();
                txtCategoria.Clear();
                txtData.Clear();
                txtDescricao.Clear();
                txtPreco.Clear();
                txtId.Focus();
            }            
             
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            if (txtId.Enabled)
            {                
                PreencheTela(JogoDAO.Primeiro());
            }
            else
            {
                JogoVO j = JogoDAO.Consulta(Convert.ToInt32(txtId.Text));
                PreencheTela(j);
            }
            GerenciaCamposTela(EnumModoOperacao.navegacao);
        }
    }
}
