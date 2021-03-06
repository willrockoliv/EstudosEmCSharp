﻿using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using Biblioteca.Vos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        /// <summary>
        /// Método recursivo que limpa os objetos do tipo TextBox e MaskedTextBox
        /// </summary>
        /// <param name="objeto">objeto a ser limpo ou container</param>
        private void LimpaCampos(Control objeto)
        {
            if (objeto is TextBox || objeto is MaskedTextBox)
                objeto.Text = "";
            else
                foreach (Control o in objeto.Controls)
                    LimpaCampos(o);
        }


        /// <summary>
        /// Altera a tela para se adequar a um determindo modo de operação
        /// que pode ser inclusão, alteração ou consulta
        /// </summary>
        /// <param name="modo">modo para o qual se deseja alterar</param>
        private void AlteraParaModo(EnumModoOperacao modo)
        {
            txtDescricao.Enabled = txtPreco.Enabled = cbCategoria.Enabled =
            txtData.Enabled = btnGravar.Enabled =
            btnCancelar.Enabled = (modo != EnumModoOperacao.Navegacao);

            btnAlterar.Enabled = btnExcluir.Enabled =
            btnAnterior.Enabled = btnProximo.Enabled =
            btnPrimeiro.Enabled =
            btnUltimo.Enabled = (modo == EnumModoOperacao.Navegacao) &&
                                txtId.Text.Length > 0;

            btnIncluir.Enabled = (modo == EnumModoOperacao.Navegacao);

            if (modo == EnumModoOperacao.Inclusao)
            {
                txtId.Enabled = true;
                LimpaCampos(this);
                txtId.Focus();
            }
            else
                txtId.Enabled = false;
        }

        private void PreencheCampos(JogoVO j)
        {
            if (j != null)
            {
                txtId.Text = j.Id.ToString();
                txtDescricao.Text = j.Descricao;
                cbCategoria.SelectedValue = j.CategoriaId;
                txtData.Text = j.Data.ToShortDateString();
                txtPreco.Text = j.valor.ToString();
            }
            else
                LimpaCampos(this);
        }

        private void button1_Click(object sender, EventArgs e)

        {
            AlteraParaModo(EnumModoOperacao.Inclusao);
            txtId.Text = JogoDAO.ProximoId().ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Alteracao);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja apagar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    JogoDAO.Excluir(Convert.ToInt32(txtId.Text));
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            PreencheCampos(JogoDAO.Primeiro());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                JogoVO j = new JogoVO();
                j.Id = Convert.ToInt32(txtId.Text);
                j.Descricao = txtDescricao.Text;
                j.valor = Convert.ToDouble(txtPreco.Text);
                j.CategoriaId = Convert.ToInt32(cbCategoria.SelectedValue);
                j.Data = Convert.ToDateTime(txtData.Text);

                if (txtId.Enabled)
                    JogoDAO.Incluir(j);
                else
                    JogoDAO.Alterar(j);

                AlteraParaModo(EnumModoOperacao.Navegacao);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }






        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool estavaIncluindo = txtId.Enabled;

            if (estavaIncluindo)
            {
                JogoVO j = JogoDAO.Primeiro();
                if (j != null)
                    PreencheCampos(j);
            }
            else
                PreencheCampos(JogoDAO.Consulta(Convert.ToInt32(txtId.Text)));

            AlteraParaModo(EnumModoOperacao.Navegacao);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Proximo(Convert.ToInt32(txtId.Text));
            if (j == null)
                return;
            else
                PreencheCampos(j);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Anterior(Convert.ToInt32(txtId.Text));
            if (j == null)
                return;
            else
                PreencheCampos(j);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            PreencheCampos(JogoDAO.Ultimo());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = CategoriaDAO.ListaCategorias();
            cbCategoria.DisplayMember = "descricao";
            cbCategoria.ValueMember = "id";

            btnPrimeiro.PerformClick();
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (frConsultaJogo tela = new frConsultaJogo())
            {
                tela.ShowDialog();
                if (tela.Selecao != 0)
                {
                    JogoVO jogo = JogoDAO.Consulta(tela.Selecao);
                    PreencheCampos(jogo);
                }
            }
        }
    }
}
