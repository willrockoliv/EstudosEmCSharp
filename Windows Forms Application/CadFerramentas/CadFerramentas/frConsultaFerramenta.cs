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

namespace CadFerramentas
{
    public partial class frConsultaFerramenta : Form
    {
        public int Selecao = 0;
        public frConsultaFerramenta()
        {
            InitializeComponent();
            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;
            gv.AllowUserToResizeRows = false;
            gv.MultiSelect = false;
            gv.ReadOnly = true;
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            gv.DataSource = FerramentaDAO.Lista(txtNome.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (gv.CurrentRow != null)
            {
                Selecao = Convert.ToInt32(gv.CurrentRow.Cells[0].Value);
                Close();
            }
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {
            btnSelecionar.PerformClick();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                gv.DataSource = FerramentaDAO.Lista(txtNome.Text);
            }
        }
    }
}
