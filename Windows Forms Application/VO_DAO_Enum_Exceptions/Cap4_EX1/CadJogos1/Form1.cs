using Biblioteca.DAO;
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
            try
            {
                JogoVO j = new JogoVO();
                j.Id = Convert.ToInt32(txtId.Text);
                j.Descricao = txtDescricao.Text;
                j.valor = Convert.ToDouble(txtPreco.Text);
                j.CategoriaId = Convert.ToInt32(txtCategoria.Text);
                j.Data = Convert.ToDateTime(txtData.Text);

                JogoDAO.Incluir(j);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                JogoVO j = new JogoVO();
                j.Id = Convert.ToInt32(txtId.Text);
                j.Descricao = txtDescricao.Text;
                j.valor = Convert.ToDouble(txtPreco.Text);
                j.CategoriaId = Convert.ToInt32(txtCategoria.Text);
                j.Data = Convert.ToDateTime(txtData.Text);

                JogoDAO.Alterar(j);
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
                JogoDAO.Excluir(Convert.ToInt32(txtId.Text));
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void PreencheTela(JogoVO a)
        {
            if (a != null)
            {
                txtId.Text = a.Id.ToString();
                txtDescricao.Text = a.Descricao;
                txtCategoria.Text = a.CategoriaId.ToString();
                txtData.Text = a.Data.ToShortDateString();
                txtPreco.Text = a.valor.ToString();
            }
            else
                LimpaCampos(this);
        }

        private void LimpaCampos(Control objeto)
        {
            txtId.Text = "";
            txtDescricao.Text = "";
            txtCategoria.Text = "";
            txtData.Text = "";
            txtPreco.Text = "";
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            JogoVO a = JogoDAO.Primeiro();
            PreencheTela(a);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            JogoVO a = JogoDAO.Anterior(Convert.ToInt32(txtId.Text));
            PreencheTela(a);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            JogoVO a = JogoDAO.Proximo(Convert.ToInt32(txtId.Text));
            PreencheTela(a);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            JogoVO a = JogoDAO.Ultimo();
            PreencheTela(a);
        }
    }
}
