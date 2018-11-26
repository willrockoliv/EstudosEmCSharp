using Biblioteca.DAO;
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
    public partial class frConsultaJogo : Form
    {
        public frConsultaJogo()
        {
            InitializeComponent();

            cbCategoria.DataSource = CategoriaDAO.ListaCategorias();
            cbCategoria.DisplayMember = "descricao";
            cbCategoria.ValueMember = "id";

            gvJogos.AllowUserToAddRows = false;
            gvJogos.AllowUserToDeleteRows = false;
            gvJogos.AllowUserToResizeRows = false;
            gvJogos.MultiSelect = false;
            gvJogos.ReadOnly = true;
            gvJogos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void rbPorCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoria.Enabled = rbPorCategoria.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            char sexo = 'm';
            string sexoStr = sexo == 'f' ? "feminino" : "masculino";
            */

            int categoriaSelecionada = rbPorCategoria.Checked ? (int)cbCategoria.SelectedValue : 0;
            DataTable tabela = JogoDAO.ConsultaDeJogos(txtNome.Text,
                txtPreco.Text, txtData.Text, categoriaSelecionada, txtId.Text);
            gvJogos.DataSource = tabela;
        }


        public int Selecao = 0;
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (gvJogos.CurrentRow != null)
            {
                Selecao = Convert.ToInt32(gvJogos.CurrentRow.Cells[0].Value);
                Close();
            }
        }

        private void gvJogos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }
    }
}
