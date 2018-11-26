using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MestreDetalhe
{
    public partial class Form1 : Form
    {
        DataTable TabelaTemp;
        DataTable TabelaProdutos;

        #region Métodos Auxiliares

        /// <summary>
        /// Método para criar e popular a tabela de produtos disponíveis para compra
        /// </summary>
        private void CriaTabelaProdutos()
        {
            TabelaProdutos = new DataTable();

            DataColumn coluna = new DataColumn("ProdutoID", typeof(int));
            TabelaProdutos.Columns.Add(coluna);

            coluna = new DataColumn("ProdutoDescricao", typeof(string));
            TabelaProdutos.Columns.Add(coluna);


            //popula a tabela de produtos
            DataRow registro = TabelaProdutos.NewRow();
            registro["ProdutoID"] = 1;
            registro["ProdutoDescricao"] = "Borracha";
            TabelaProdutos.Rows.Add(registro);

            registro = TabelaProdutos.NewRow();
            registro["ProdutoID"] = 2;
            registro["ProdutoDescricao"] = "Lápis";
            TabelaProdutos.Rows.Add(registro);

            registro = TabelaProdutos.NewRow();
            registro["ProdutoID"] = 3;
            registro["ProdutoDescricao"] = "Caneta";
            TabelaProdutos.Rows.Add(registro);

            registro = TabelaProdutos.NewRow();
            registro["ProdutoID"] = 4;
            registro["ProdutoDescricao"] = "Caderno";
            TabelaProdutos.Rows.Add(registro);

        }


        /// <summary>
        /// Verifica se um determinado valor string é um inteiro válido.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private bool ValidaInteiro(string valor)
        {
            try
            {
                Convert.ToInt32(valor);
                return true;
            }
            catch
            {
                return false;
            }

        }


        /// <summary>
        /// Pesquisa um produto na tabela de produtos
        /// </summary>
        /// <param name="codigoProduto"></param>
        /// <returns></returns>
        private DataRow PesquisaProduto(string codigoProduto)
        {
            if (!ValidaInteiro(codigoProduto))
                return null;

            // o método select de um datatable retorna um vetor com todos os registros
            // do datatable que se encaixem no filtro informado.
            DataRow[] rowProduto = TabelaProdutos.Select("ProdutoId = " + codigoProduto);
            if (rowProduto.Length == 0)
                return null;
            else
                return rowProduto[0];
        }



        /// <summary>
        /// Retorna o caminho onde está e/ou será salvo o arquivo de dados
        /// </summary>
        /// <returns></returns>
        private string RetornaCaminhoXML()
        {
            string arq = System.IO.Path.GetDirectoryName(Application.ExecutablePath) +
                "\\Dados.XML";

            return arq;
        }


        #endregion


        /// <summary>
        /// construtor do form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //this.BackgroundImage = Image.FromFile(".\\imagens\\areia.bmp");


            CriaTabelaProdutos();

            #region Criando a Tabela Temporária
            TabelaTemp = new DataTable();
            TabelaTemp.TableName = "tbDados";

            DataColumn coluna = new DataColumn("ProdutoID", typeof(int));
            TabelaTemp.Columns.Add(coluna);

            coluna = new DataColumn("ProdutoDescricao", typeof(string));
            TabelaTemp.Columns.Add(coluna);

            coluna = new DataColumn("Quantidade", typeof(int));
            TabelaTemp.Columns.Add(coluna);
            #endregion

            #region criação dinâmica das colunas do DataGridView
            DataGridViewTextBoxColumn colProdutoId = new DataGridViewTextBoxColumn();
            colProdutoId.Name = "colProdutoId";
            colProdutoId.ReadOnly = true;
            colProdutoId.Width = 100;
            colProdutoId.DataPropertyName = "ProdutoID"; // o nome do campo do datatable
            colProdutoId.HeaderText = "Produto";
            colProdutoId.DefaultCellStyle.BackColor = SystemColors.ButtonFace;

            dataGridView1.Columns.Add(colProdutoId);

            DataGridViewTextBoxColumn colProdutoDescricao = new DataGridViewTextBoxColumn();
            colProdutoDescricao.Name = "colProdutoDescricao";
            colProdutoDescricao.ReadOnly = true;
            colProdutoDescricao.Width = 300;
            colProdutoDescricao.DataPropertyName = "ProdutoDescricao"; // o nome do campo do datatable            
            colProdutoDescricao.HeaderText = "Descrição";
            colProdutoDescricao.DefaultCellStyle.BackColor = SystemColors.ButtonFace;
            dataGridView1.Columns.Add(colProdutoDescricao);

            DataGridViewTextBoxColumn colQtde = new DataGridViewTextBoxColumn();
            colQtde.Name = "colQtde";
            colQtde.ReadOnly = false; // permite escrita nesse campo
            colQtde.Width = 100;
            colQtde.DataPropertyName = "Quantidade"; // o nome do campo do datatable                                   
            colQtde.HeaderText = "Quantidade";            
            dataGridView1.Columns.Add(colQtde);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = false;


            dataGridView1.DataSource = TabelaTemp;

            #endregion
        }




        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!ValidaInteiro(txtQtde.Text))
            {
                MessageBox.Show("Quantidade inválida!");
                return;
            }

            DataRow rowProduto = PesquisaProduto(txtProduto.Text);
            if (rowProduto == null)
            {
                MessageBox.Show("O produto informado não existe ou não foi informado (dã!)!");
                return;
            }


            //verifica se o produto já havia sido adicionado 
            //e neste caso só incrementa a quantidade.

            DataRow[] registros = TabelaTemp.Select("ProdutoID = " + txtProduto.Text);
            if (registros.Length == 1) // se já existir, só altera a quantidade
            {
                registros[0]["Quantidade"] = Convert.ToInt32(registros[0]["Quantidade"]) +
                                             Convert.ToInt32(txtQtde.Text);
            }
            else
            {
                // Se não encontrar, cria um novo registro.
                DataRow registro = TabelaTemp.NewRow();
                registro["ProdutoID"] = txtProduto.Text;
                registro["ProdutoDescricao"] = rowProduto["ProdutoDescricao"];
                registro["Quantidade"] = txtQtde.Text;
                TabelaTemp.Rows.Add(registro);
            }
        }



        /// <summary>
        /// Ao sair do campo txtProduto, ele dispara este evento e preenche o nome do produto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProduto_Leave(object sender, EventArgs e)
        {
            DataRow rowProduto = PesquisaProduto(txtProduto.Text);
            if (rowProduto != null)
            {
                txtDescricaoProduto.Text = rowProduto["ProdutoDescricao"].ToString();
            }
            else
            {
                txtDescricaoProduto.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)                
            {
                MessageBox.Show("Não há linha selecionada!");
                return;
            }

            if (MessageBox.Show("Confirma?", "Atenção", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                return;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);           
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma?", "Atenção", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                TabelaTemp.Clear();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TabelaTemp.WriteXml(RetornaCaminhoXML());
            MessageBox.Show("Dados salvos com sucesso!");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(RetornaCaminhoXML()))
            {
                MessageBox.Show("Arquivo de dados não existe!");
                return;
            }
            
            TabelaTemp.ReadXml(RetornaCaminhoXML());
            MessageBox.Show("Dados carregados com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbProdutos.Items.Clear();

            foreach (DataRow registro in TabelaProdutos.Rows)            
            {
                /*
                Produto p = new Produto();
                p.SetCodigo(registro["ProdutoID"].ToString());
                p.SetNome(registro["ProdutoDescricao"].ToString());
                ProdutoDAO.Inserir(p);
                */
                lbProdutos.Items.Add(
                     registro["ProdutoID"].ToString() + "  - " +
                     registro["ProdutoDescricao"].ToString()  );
            }
        }


        /// <summary>
        /// Este evendo do grid serve para validar os dados
        /// digitados diretamente no grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellValidating(object sender, 
            DataGridViewCellValidatingEventArgs e)
        {
            //verifica se é a coluna de quantidade
            if (e.ColumnIndex == dataGridView1.Columns[2].Index)
            {
                string valor = e.FormattedValue.ToString();
                if (!ValidaInteiro(valor))
                {
                    MessageBox.Show("Valor inválido!");
                    e.Cancel = true;
                }
            }
        }



    }
}
