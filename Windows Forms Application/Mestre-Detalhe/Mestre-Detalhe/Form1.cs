using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mestre_Detalhe
{
    public partial class Form1 : Form
    {
        BindingList<PedidoItemVO> carrinhoCompras = new BindingList<PedidoItemVO>();

        private void ConfiguraColunasGridView()
        {
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
            colProdutoDescricao.Width = 200;
            colProdutoDescricao.DataPropertyName = "ProdutoDescricao"; // o nome do campo do datatable            
            colProdutoDescricao.HeaderText = "Descrição";
            colProdutoDescricao.DefaultCellStyle.BackColor = SystemColors.ButtonFace;
            dataGridView1.Columns.Add(colProdutoDescricao);

            DataGridViewTextBoxColumn colQtde = new DataGridViewTextBoxColumn();
            colQtde.Name = "colQtde";
            colQtde.ReadOnly = false; // permite escrita nesse campo
            colQtde.Width = 80;
            colQtde.DataPropertyName = "Qtde"; // o nome do campo do datatable                                   
            colQtde.HeaderText = "Quantidade";
            colQtde.DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.Columns.Add(colQtde);


            DataGridViewTextBoxColumn colValorUnitario = new DataGridViewTextBoxColumn();
            colValorUnitario.Name = "colValorUnitario";
            colValorUnitario.ReadOnly = true; // permite escrita nesse campo
            colValorUnitario.Width = 100;
            colValorUnitario.DataPropertyName = "ValorUnitario"; // o nome do campo do datatable                                   
            colValorUnitario.HeaderText = "Valor Unitário";
            colValorUnitario.DefaultCellStyle.BackColor = SystemColors.ButtonFace;
            dataGridView1.Columns.Add(colValorUnitario);


            DataGridViewTextBoxColumn colValorTotal = new DataGridViewTextBoxColumn();
            colValorTotal.Name = "colValorTotal";
            colValorTotal.ReadOnly = true; // permite escrita nesse campo
            colValorTotal.Width = 100;
            colValorTotal.DataPropertyName = "ValorTotal"; // o nome do campo do datatable                                   
            colValorTotal.HeaderText = "Valor Total";
            colValorTotal.DefaultCellStyle.BackColor = SystemColors.ButtonFace;
            dataGridView1.Columns.Add(colValorTotal);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = false;


            dataGridView1.DataSource = carrinhoCompras;

            #endregion
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfiguraColunasGridView();

            try
            {
                cbProduto.DisplayMember = "Nome";
                cbProduto.ValueMember = "Codigo";
                cbProduto.DataSource = ProdutoDAO.ConsultaProdutos();

                cbCliente.DisplayMember = "Nome";
                cbCliente.ValueMember = "Id";
                cbCliente.DataSource = ClienteDAO.ConsultaClientes();
                cbCliente.SelectedIndex = -1;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }
        
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            //pega o produto selecionado no combobox
            ProdutoVO produto = cbProduto.SelectedItem as ProdutoVO;

            /*
            PedidoItemVO produtoPesquisado = 
                         carrinhoCompras.FirstOrDefault(
                             item => item.ProdutoId == produto.Codigo);
           */

            PedidoItemVO produtoPesquisado = null;                         
            foreach (PedidoItemVO item in carrinhoCompras)
                if (item.ProdutoId == produto.Codigo)
                {
                    produtoPesquisado = item;
                    break;
                }
            

            if (produtoPesquisado != null)
                produtoPesquisado.Qtde++; // apenas altera a quantidade
            else
            {
                //Insere o produto no carrinho (item do pedido)
                PedidoItemVO item = new PedidoItemVO();
                item.ProdutoDescricao = produto.Nome;
                item.ProdutoId = produto.Codigo;
                item.ValorUnitario = produto.ValorUnitario;
                item.Qtde = 1;
                carrinhoCompras.Add(item);
            }
            //dataGridView1.Invalidate();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ////o objetivo deste código atualizar a coluna preço total.            
            dataGridView1.InvalidateCell(dataGridView1.CurrentRow.Cells["colValorTotal"]);
        }


        private void dataGridView1_CellValidating(object sender,
            DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.IsCurrentCellInEditMode)
            {
                //Validação para a coluna quantidade 
                if (e.ColumnIndex == dataGridView1.Columns["colQtde"].Index)
                {
                    try
                    {
                        Convert.ToInt32(e.FormattedValue);
                        e.Cancel = false;
                    }
                    catch
                    {
                        e.Cancel = true;
                        MessageBox.Show("Valor inválido! Pressione ESC para cancelar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnGravaPedido_Click(object sender, EventArgs e)
        {
            //faça as validações aqui
            try
            {
                PedidoVO pedido = new PedidoVO();
                pedido.Id = Convert.ToInt32(txtPedidoID.Text);
                pedido.Data = txtData.Value;
                pedido.ClienteId = Convert.ToInt32(cbCliente.SelectedValue);
                pedido.ItensDoPedido = carrinhoCompras.ToList();

                PedidoDAO.Insere(pedido);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }        
    }
}
