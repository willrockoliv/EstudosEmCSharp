using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodFunc.Text != "" && txtNomeFunc.Text != "")
            {
                string conteudoFunc = "F|" + txtCodFunc.Text.Trim() + "|" + txtNomeFunc.Text.Trim();
                Funcionario Funcionario = new Funcionario();
                Funcionario.Salvar(conteudoFunc);

                txtCodFunc.Text = null;
                txtNomeFunc.Text = null;
            }

            if (txtCodProd.Text != "" && txtNomeProd.Text != "")
            {
                string conteudoProd = "P|" + txtCodProd.Text.Trim() + "|" + txtNomeProd.Text.Trim() + "|" + txtPreco.Text.Trim();
                Produto Produto = new Produto();
                Produto.Salvar(conteudoProd);

                txtCodProd.Text = null;
                txtNomeProd.Text = null;
                txtPreco.Text = null;
            }
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            if (txtPesq.Text != "")
            {
                Funcionario Funcionario = new Funcionario();
                string[] conteudoFunc = Funcionario.Pesquisar(txtPesq.Text).Trim().Split('|');
                if(conteudoFunc.Length == 2)
                {
                    txtCodFunc.Text = conteudoFunc[0];
                    txtNomeFunc.Text = conteudoFunc[1];
                }

                Produto Produto = new Produto();
                string[] conteudoProd = Produto.Pesquisar(txtPesq.Text).Trim().Split('|');
                if (conteudoProd.Length == 3)
                {
                    txtCodProd.Text = conteudoProd[0];
                    txtNomeProd.Text = conteudoProd[1];
                    txtPreco.Text = conteudoProd[2];                    
                }
            }
        }
    }
}
