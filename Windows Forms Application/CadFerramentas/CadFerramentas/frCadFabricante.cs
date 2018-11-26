using Biblioteca.DAO;
using CadFerramentas.Enumeradores;
using CadFerramentas.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadFerramentas
{
    public partial class frCadFabricante : Form
    {
        public frCadFabricante()
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
            else if (objeto is PictureBox)
                (objeto as PictureBox).ImageLocation = null;
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
            txtDescricao.Enabled = btnGravar.Enabled = btnCancelar.Enabled = (modo != EnumModoOperacao.Navegacao);

            btnAlterar.Enabled = btnExcluir.Enabled =
            btnAnterior.Enabled = btnProximo.Enabled =
            btnPrimeiro.Enabled =
            btnUltimo.Enabled = (modo == EnumModoOperacao.Navegacao) &&
                                txtId.Text.Length > 0;

            btnIncluir.Enabled = (modo == EnumModoOperacao.Navegacao);

            if (modo == EnumModoOperacao.Inclusao)
            {
                LimpaCampos(this);
            }
        }

        private void PreencheCampos(FabricanteVO j)
        {
            if (j != null)
            {
                txtId.Text = j.Id.ToString();
                txtDescricao.Text = j.Descricao;                
            }
            else
                LimpaCampos(this);
        }

        private void frCadFabricante_Load(object sender, EventArgs e)
        {
            btnPrimeiro.PerformClick();
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlteraParaModo(EnumModoOperacao.Inclusao);
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
                {
                    FabricanteDAO.Excluir(Convert.ToInt32(txtId.Text));
                    btnPrimeiro.PerformClick();
                    AlteraParaModo(EnumModoOperacao.Navegacao);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                FabricanteVO j = new FabricanteVO();
                if (txtId.Text.Length > 0)
                    j.Id = Convert.ToInt32(txtId.Text);
                j.Descricao = txtDescricao.Text;
                
                if (txtId.Text.Length == 0)
                {
                    FabricanteDAO.Incluir(j);
                    txtId.Text = j.Id.ToString();
                }
                else
                    FabricanteDAO.Alterar(j);

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
                FabricanteVO j = FabricanteDAO.Primeiro();
                if (j != null)
                    PreencheCampos(j);
            }
            else
                PreencheCampos(FabricanteDAO.Consulta(Convert.ToInt32(txtId.Text)));

            AlteraParaModo(EnumModoOperacao.Navegacao);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            PreencheCampos(FabricanteDAO.Primeiro());
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            var j = FabricanteDAO.Anterior(Convert.ToInt32(txtId.Text));
            if (j == null)
                return;
            else
                PreencheCampos(j);
            
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            var j = FabricanteDAO.Proximo(Convert.ToInt32(txtId.Text));
            if (j == null)
                return;
            else
                PreencheCampos(j);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            PreencheCampos(FabricanteDAO.Ultimo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tela = new frconsultaFabricante())
            {
                tela.ShowDialog();
                if (tela.Selecao != 0)
                {
                    var f = FabricanteDAO.Consulta(tela.Selecao);
                    PreencheCampos(f);
                }
            }
        }
    }
}
