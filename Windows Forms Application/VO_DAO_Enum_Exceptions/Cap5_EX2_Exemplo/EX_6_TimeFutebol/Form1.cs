using EX_6_TimeFutebol.DAO;
using EX_6_TimeFutebol.Enumeradores;
using EX_6_TimeFutebol.VO;
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

namespace EX_6_TimeFutebol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrimeiro.PerformClick();
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }


        /// <summary>
        /// Altera a tela para se adequar a um determindo modo de operação
        /// que pode ser inclusão, alteração ou consulta
        /// </summary>
        /// <param name="modo">modo para o qual se deseja alterar</param>
        private void AlteraParaModo(EnumModoOperacao modo)
        {
            txtNome.Enabled = (modo != EnumModoOperacao.Navegacao);
            txtNumeroCamisa.Enabled = (modo != EnumModoOperacao.Navegacao);            
            txtIdTime.Enabled = (modo != EnumModoOperacao.Navegacao);

            btnInclui.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAltera.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnExclui.Enabled = (modo == EnumModoOperacao.Navegacao) &&
                                 txtId.Text.Length > 0;

            btnPrimeiro.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAnterior.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnProximo.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnUltimo.Enabled = (modo == EnumModoOperacao.Navegacao);


            btnGravar.Enabled = (modo != EnumModoOperacao.Navegacao);
            btnCancelar.Enabled = (modo != EnumModoOperacao.Navegacao);

            if (modo == EnumModoOperacao.Inclusao)
            {
                txtId.Enabled = true;
                LimpaCampos(this);
                txtId.Focus();
            }
            else
                txtId.Enabled = false;
        }

        private void LimpaCampos(Control objeto)
        {
            if (objeto is TextBoxBase)
                objeto.Text = "";
            else if (objeto is NumericUpDown)
                (objeto as NumericUpDown).Value = 0;
            else
            {
                foreach (Control o in objeto.Controls)
                    LimpaCampos(o);
            }
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Inclusao);
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Alteracao);
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (Metodos.ValidaInt(txtId.Text) == false)
            {
                Metodos.Mensagem("Digite apenas números no campo ID.",
                    TipoMensagemEnum.alerta);
                return;
            }

            if (!Metodos.Mensagem("Confirma?", TipoMensagemEnum.pergunta))
                return;

            try
            {
                JogadorFutebolDAO.Excluir(Convert.ToInt32(txtId.Text));
                btnPrimeiro.PerformClick();
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }


        private void TrataErro(Exception erro)
        {
            if (erro is FormatException)
            {
                Metodos.Mensagem("Campo numérico inválido!", TipoMensagemEnum.erro);
            }            
            else if (erro is SqlException)
            {
                Metodos.Mensagem("Ocorreu um erro no banco de dados.", TipoMensagemEnum.erro);
            }
            else if (erro is Exception)
            {
                Metodos.Mensagem(erro.Message , TipoMensagemEnum.erro);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                JogadorFutebolVO j = new JogadorFutebolVO();
                j.Id = Convert.ToInt32(txtId.Text);
                j.Nome = txtNome.Text;
                j.NumeroCamisa = Convert.ToInt32(txtNumeroCamisa.Text);
                j.TimeId = Convert.ToInt32(txtIdTime.Text);

                if (txtId.Enabled)
                    JogadorFutebolDAO.Inserir(j);
                else
                    JogadorFutebolDAO.Alterar(j);

                AlteraParaModo(EnumModoOperacao.Navegacao);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtId.Enabled)
                PreencheTela(JogadorFutebolDAO.Primeiro());
            else
                PreencheTela(JogadorFutebolDAO.Consulta(Convert.ToInt32(txtId.Text)));

            AlteraParaModo(EnumModoOperacao.Navegacao);
        }


        private void PreencheTela(JogadorFutebolVO j)
        {
            try
            {
                if (j != null)
                {
                    txtId.Text = j.Id.ToString();
                    txtNome.Text = j.Nome;
                    txtNumeroCamisa.Value = j.NumeroCamisa;
                    txtIdTime.Value = j.TimeId;                    
                }
                else
                {
                    LimpaCampos(this);
                }
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            try
            {
                JogadorFutebolVO j = JogadorFutebolDAO.Primeiro();
                PreencheTela(j);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                JogadorFutebolVO j = JogadorFutebolDAO.Anterior(Convert.ToInt32(txtId.Text));
                if (j != null)
                    PreencheTela(j);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                JogadorFutebolVO j = JogadorFutebolDAO.Proximo(Convert.ToInt32(txtId.Text));
                if (j != null)
                    PreencheTela(j);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                JogadorFutebolVO j = JogadorFutebolDAO.Ultimo();
                PreencheTela(j);
            }
            catch (Exception erro)
            {
                TrataErro(erro);
            }
        }
    }
}
