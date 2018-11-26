using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex15
{
    public partial class Form1 : Form
    {
        List<Produto> listProduto = new List<Produto>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] categorias = File.ReadAllLines("categorias.txt", Encoding.Default);
            foreach (string item in categorias)
                cbCategoria.Items.Add(item.Replace(",", " - "));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void brnSalvar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            try
            {
                int teste;
                if (Int32.TryParse(txtCodigo.Text, out teste))
                    p.Codigo = Convert.ToInt32(txtCodigo.Text);
                else
                    throw new Exception("Código inválido");
                p.Descricao = txtDescricao.Text;
                if (cbCategoria.SelectedItem != null)
                    p.Categoria = cbCategoria.SelectedItem.ToString();
                else
                    throw new Exception("Categoria Obrigatória");

                listProduto.Add(p);

                MessageBox.Show("Salvo com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ltbProdutos.Items.Clear();
            foreach(Produto item in listProduto)
            {
                string conteudo = "Código: " + item.Codigo +
                                  " Descrição: " + item.Descricao +
                                  " Categoria: " + item.Categoria;
                ltbProdutos.Items.Add(conteudo);
            }
        }
    }
}
