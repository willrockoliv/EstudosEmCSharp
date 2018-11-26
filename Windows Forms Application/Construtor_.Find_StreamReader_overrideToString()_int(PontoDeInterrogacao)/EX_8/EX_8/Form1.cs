using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EX_8
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Lista de produtos
        /// </summary>
        List<Produto> listaDeProdutos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();

            cbCategoria.DataSource = Categoria.CarregaDados();
            cbCategoria.DisplayMember = "Descricao";
            cbCategoria.ValueMember = "Codigo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Produto produto = new Produto();
                produto.Codigo = Convert.ToInt16(txtCodigo.Text);
                produto.Descricao = txtDescricao.Text;

                produto.Categoria = (Categoria)cbCategoria.SelectedItem;
                
                listaDeProdutos.Add(produto);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbCategoria.SelectedValue.ToString()); 
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Produto p in listaDeProdutos)
            {
                listBox1.Items.Add(                                       
                    "Produto: " + p.Codigo + " - " +
                    p.Descricao + " Categoria: " +
                    p.Categoria.Codigo + " - " +
                    p.Categoria.Descricao);

            }
        }
    }
}
