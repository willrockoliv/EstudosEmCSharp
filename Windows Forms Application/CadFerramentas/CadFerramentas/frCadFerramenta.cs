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
    public partial class frCadFerramenta : Form
    {
        public frCadFerramenta()
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
            txtDescricao.Enabled = txtFabricante.Enabled = btnFoto.Enabled = btnBuscaFabricante.Enabled =
            btnGravar.Enabled = btnCancelar.Enabled = (modo != EnumModoOperacao.Navegacao);

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

        private void PreencheCampos(FerramentaVO j)
        {
            if (j != null)
            {
                txtId.Text = j.Id.ToString();
                txtDescricao.Text = j.Descricao;
                txtFabricante.Text = j.FabricanteId.ToString();
                imgFerramenta.ImageLocation = j.Foto;
            }
            else
                LimpaCampos(this);
        }




        private void frCadFerramenta_Load(object sender, EventArgs e)
        {
            btnPrimeiro.PerformClick();
            AlteraParaModo(EnumModoOperacao.Navegacao);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgFerramenta.ImageLocation = openFileDialog1.FileName;
            }
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
                    FerramentaDAO.Excluir(Convert.ToInt32(txtId.Text));
                    btnPrimeiro.PerformClick();
                    AlteraParaModo(EnumModoOperacao.Navegacao);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            PreencheCampos(FerramentaDAO.Primeiro());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                FerramentaVO j = new FerramentaVO();
                if (txtId.Text.Length > 0)
                    j.Id = Convert.ToInt32(txtId.Text);
                j.Descricao = txtDescricao.Text;
                j.FabricanteId = Convert.ToInt32(txtFabricante.Text);
                j.Foto = imgFerramenta.ImageLocation;

                if (txtId.Text.Length == 0)
                {
                    FerramentaDAO.Incluir(j);
                    txtId.Text = j.Id.ToString();
                }
                else
                    FerramentaDAO.Alterar(j);

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
                FerramentaVO j = FerramentaDAO.Primeiro();
                if (j != null)
                    PreencheCampos(j);
            }
            else
                PreencheCampos(FerramentaDAO.Consulta(Convert.ToInt32(txtId.Text)));

            AlteraParaModo(EnumModoOperacao.Navegacao);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            var j = FerramentaDAO.Proximo(Convert.ToInt32(txtId.Text));
            if (j == null)
                return;
            else
                PreencheCampos(j);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            var j = FerramentaDAO.Anterior(Convert.ToInt32(txtId.Text));
            if (j == null)
                return;
            else
                PreencheCampos(j);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            PreencheCampos(FerramentaDAO.Ultimo());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tela = new frConsultaFerramenta())
            {
                tela.ShowDialog();
                if (tela.Selecao != 0)
                {
                    var f = FerramentaDAO.Consulta(tela.Selecao);
                    PreencheCampos(f);
                }
            }
        }

        private void btnBuscaFabricante_Click(object sender, EventArgs e)
        {
            using (var tela = new frconsultaFabricante())
            {
                tela.ShowDialog();
                if (tela.Selecao != 0)
                {
                    txtFabricante.Text = tela.Selecao.ToString();
                    //var f = FerramentaDAO.Consulta(tela.Selecao);
                    //PreencheCampos(f);
                }
            }
        }

        private void txtFabricante_TextChanged(object sender, EventArgs e)
        {
            int id = 0;
            txtNomeFabricante.Clear();
            if (int.TryParse(txtFabricante.Text, out id))
            {
                var fabricante = FabricanteDAO.Consulta(id);
                if (fabricante != null)
                {
                    txtNomeFabricante.Text = fabricante.Descricao.ToString();
                }
            }
        }

    }
}
