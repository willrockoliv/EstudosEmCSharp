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
    public partial class frconsultaFabricante : Form
    {
        public int Selecao;
        public frconsultaFabricante()
        {
            InitializeComponent();
            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;
            gv.AllowUserToResizeRows = false;
            gv.MultiSelect = false;
            gv.ReadOnly = true;
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv.AutoGenerateColumns = false;
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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            gv.DataSource = FabricanteDAO.Lista(txtNome.Text);
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gv.DataSource = FabricanteDAO.Lista(txtNome.Text);
            }
        }
    }
}
