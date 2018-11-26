using Biblioteca;
using Biblioteca.DAO;
using Biblioteca.Enumeradores;
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

namespace CadAlunosBD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoVO a = new AlunoVO();
                a.Id = Convert.ToInt32(txtId.Text);
                a.Nome = txtNome.Text;
                a.CidadeId = Convert.ToInt32(txtCidade.Text);
                a.DataNascimento = Convert.ToDateTime(txtData.Text);
                a.Mensalidade = Convert.ToDouble(txtMensalidade.Text);
                AlunoDAO.Inserir(a);
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
                AlunoVO a = new AlunoVO();
                a.Id = Convert.ToInt32(txtId.Text);
                a.Nome = txtNome.Text;
                a.CidadeId = Convert.ToInt32(txtCidade.Text);
                a.DataNascimento = Convert.ToDateTime(txtData.Text);
                a.Mensalidade = Convert.ToDouble(txtMensalidade.Text);
                AlunoDAO.Alterar(a);
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
                if (Metodos.Mensagem("Deseja mesmo apagar?", TipoMensagemEnum.pergunta))
                {
                    AlunoDAO.Excluir(Convert.ToInt32(txtId.Text));
                    Metodos.Mensagem("Apaguei com sucesso!", TipoMensagemEnum.informacao);
                }
            }
            catch (Exception erro)
            {
                Metodos.Mensagem(erro.Message, TipoMensagemEnum.erro);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlunoVO a = AlunoDAO.Consulta(Convert.ToInt32(txtId.Text));
            if (a == null)
                Metodos.Mensagem("Código não existe!", TipoMensagemEnum.erro);
            else
                PreencheTela(a);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            var a = AlunoDAO.Primeiro();
            PreencheTela(a);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            var a = AlunoDAO.Anterior(Convert.ToInt32(txtId.Text));
            if (a != null)
                PreencheTela(a);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            var a = AlunoDAO.Proximo(Convert.ToInt32(txtId.Text));
            if (a != null)
                PreencheTela(a);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            PreencheTela(AlunoDAO.Ultimo());
        }


        private void PreencheTela(AlunoVO a)
        {
            if (a != null)
            {
                txtId.Text = a.Id.ToString();
                txtNome.Text = a.Nome;
                txtCidade.Text = a.CidadeId.ToString();
                txtData.Text = a.DataNascimento.ToShortDateString();
                txtMensalidade.Text = a.Mensalidade.ToString();
            }
            else
                LimpaCampos(this);
        }
        private void LimpaCampos(Control objeto)
        {
            if (objeto is TextBox || objeto is MaskedTextBox)
                objeto.Text = "";
            else
                foreach (Control o in objeto.Controls)
                    LimpaCampos(o);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrimeiro.PerformClick();

        }
    }
}

