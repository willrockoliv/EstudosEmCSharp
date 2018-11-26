using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_8
{
    public partial class Form1 : Form
    {
        List<Produto> ListaProdutos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();

            cbCategoria.DataSource = Categoria.Carrega();
            cbCategoria.ValueMember = "Codigo";
            cbCategoria.DisplayMember = "Descricao";                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();
                p.Codigo = Convert.ToInt32(txtCodigo.Text);
                p.Descricao = txtDescricao.Text;                               
                p.Categoria = cbCategoria.SelectedItem as Categoria;

                ListaProdutos.Add(p);
                listBox1.DataSource = null;
                listBox1.DataSource = ListaProdutos;                
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());

            }
        }
    }
}
