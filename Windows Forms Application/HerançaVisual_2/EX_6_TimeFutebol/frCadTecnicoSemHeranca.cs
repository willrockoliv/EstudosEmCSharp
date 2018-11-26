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
    public partial class frCadTecnicoSemHeranca : Form
    {
        TecnicoDAO tecnicoDAO = new TecnicoDAO();

        public frCadTecnicoSemHeranca()
        {
            InitializeComponent();
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
            txtId.Enabled = (modo != EnumModoOperacao.Navegacao);

            btnInclui.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAltera.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnExclui.Enabled = (modo == EnumModoOperacao.Navegacao) &&
                                 txtId.Text.Length > 0;

            btnPrimeiro.Enabled = (modo == EnumModoOperacao.Navegacao);
            btnAnterior.Enabled = (modo == EnumModoOperacao.Navegacao) && txtId.Value > 0;
            btnProximo.Enabled = (modo == EnumModoOperacao.Navegacao) && txtId.Value > 0;
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
            if (objeto is TextBox ||
                objeto is MaskedTextBox)
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
            txtId.Value = tecnicoDAO.ProximoId();
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
                tecnicoDAO.Excluir(Convert.ToInt32(txtId.Text));
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
                Metodos.Mensagem(erro.Message, TipoMensagemEnum.erro);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                TecnicoVO t = new TecnicoVO();
                t.Id = Convert.ToInt32(txtId.Text);
                t.Nome = txtNome.Text;

                if (txtId.Enabled)
                    tecnicoDAO.Inserir(t);
                else
                    tecnicoDAO.Alterar(t);

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
                PreencheTela(tecnicoDAO.Primeiro());
            else
                PreencheTela(tecnicoDAO.Consulta(Convert.ToInt32(txtId.Text)));

            AlteraParaModo(EnumModoOperacao.Navegacao);
        }


        private void PreencheTela(PadraoVO t)
        {
            try
            {
                if (t != null)
                {
                    txtId.Text = (t as TecnicoVO).Id.ToString();
                    txtNome.Text = (t as TecnicoVO).Nome;
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
            PreencheTela(tecnicoDAO.Primeiro());
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            PadraoVO obj = tecnicoDAO.Anterior(Convert.ToInt32(txtId.Text));
            if (obj != null)
                PreencheTela(obj);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            PadraoVO obj = tecnicoDAO.Proximo(Convert.ToInt32(txtId.Text));
            if (obj != null)
                PreencheTela(obj);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            PreencheTela(tecnicoDAO.Ultimo());
        }


    }
}
