using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataTables_E_Grids
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Variável para representar nossa tabela temporária
        /// </summary>
        DataTable tabela;
        int index = 0;

        public Form1()
        {
            InitializeComponent();

            //cria uma tabela com 2 colunas
            tabela = new DataTable();

            //coluna codigo
            DataColumn coluna = new DataColumn("Codigo", typeof(int));
            tabela.Columns.Add(coluna);

            //coluna nome
            coluna = new DataColumn("Nome", typeof(string));
            tabela.Columns.Add(coluna);


            //configurações do grid
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            //preencha as colunas com os nomes dos campos do datatable.
            //as colunas do grid foram preenchidas pela propriedade columns
            colCodigo.DataPropertyName = "Codigo";
            colNome.DataPropertyName = "Nome";

            //associa a tabela ao grid
            dataGridView1.DataSource = tabela;
        }


        /// <summary>
        /// pesquisa um código do vetor
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>retorna null caso nao encontre. 
        ///          Se encontrar retorna a linha do datatable</returns>
        private DataRow Pesquisa(int codigo)
        {
            //pesquisa um valor na tabela e devolve um vetor com
            //todos os registros que satisfaçam o filtro.
            DataRow[] vetor = tabela.Select("codigo = " + codigo.ToString());

            if (vetor.Length == 0) // não achou o código!
                return null;
            else
                return vetor[0];  // achou!!!
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            int codigo = Convert.ToInt32(txtCodigo.Text);
            bool inclusao = false;

            DataRow registro = Pesquisa(codigo); // pesquisa para ver se é inclusao ou alteração

            if (registro == null)
            {
                registro = tabela.NewRow();  // é inclusão
                inclusao = true;
            }

            //caso seja uma inclusao, um novo registro é preenchido.
            //se for alteração, ele será alterado
            registro["Codigo"] = txtCodigo.Text;
            registro["Nome"] = txtNome.Text;

            if (inclusao)  // se for novo registro, adicione-o a tabela
                tabela.Rows.Add(registro);
            // não tem else, pois se for alteração, já efetuamos ela nas linhas acimas deste if.
        }

        private void dataGridView1_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // se há uma célula selecionada...
            {
                // acha o valor do código 
                int codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[colCodigo.Index].Value);

                //pesquisa se existe no datatable
                DataRow registro = Pesquisa(codigo);

                if (registro != null)
                {
                    // se existir, preenche os campos da tela
                    txtCodigo.Text = registro["Codigo"].ToString();
                    txtNome.Text = registro["Nome"].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // na verdade, essas linhas abaixo removem o registro
            // do datable associado ao grid!!!
            // se quiser, também pode remover direto do datatable
            // com o método tabela.Rows.Remove            
            dataGridView1.Rows.Remove(
                dataGridView1.SelectedRows[0]);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (DataRow registro in tabela.Rows)
            {
                listBox1.Items.Add(registro["Codigo"].ToString() + " - " +
                    registro["Nome"].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                index = dataGridView1.SelectedRows[0].Index;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //testa se a linha ainda existe...
            if (dataGridView1.Rows.Count > index)
                dataGridView1.Rows[index].Selected = true;
        }
    }
}
