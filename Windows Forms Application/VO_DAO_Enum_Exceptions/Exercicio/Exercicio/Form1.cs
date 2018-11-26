using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                agendaVO agendaVO = new agendaVO();
                agendaVO.Id = Convert.ToInt32(mkbId.Text);
                agendaVO.Nome = txtNome.Text;
                agendaVO.Telefone = txtTelefone.Text;

                agendaDAO.Inserir(agendaVO);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(mkbId.Text, out int id))
                    agendaDAO.Excluir(id);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                agendaVO agendaVO = new agendaVO();
                agendaVO.Id = Convert.ToInt32(mkbId.Text);
                agendaVO.Nome = txtNome.Text;
                agendaVO.Telefone = txtTelefone.Text;

                agendaDAO.Alterar(agendaVO);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void PreencheCampos(DataTable dataTable, MaskedTextBox mkbId, TextBox txtNome, TextBox txtTelefone)
        {
            if (dataTable.Rows.Count > 0)
            {
                mkbId.Text = dataTable.Rows[0]["codigo"].ToString();
                txtNome.Text = dataTable.Rows[0]["nome"].ToString();
                txtTelefone.Text = dataTable.Rows[0]["telefone"].ToString();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            PreencheCampos(agendaDAO.Primeiro(), mkbId, txtNome, txtTelefone);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (mkbId.Text == "")
                return;

            PreencheCampos(agendaDAO.Anterior(Convert.ToInt32(mkbId.Text)), mkbId, txtNome, txtTelefone);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (mkbId.Text == "")
                return;

            PreencheCampos(agendaDAO.Proximo(Convert.ToInt32(mkbId.Text)), mkbId, txtNome, txtTelefone);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            PreencheCampos(agendaDAO.Ultimo(), mkbId, txtNome, txtTelefone);
        }
    }
}
