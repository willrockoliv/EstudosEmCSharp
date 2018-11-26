using EX_6_TimeFutebol.DAO;
using EX_6_TimeFutebol.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_6_TimeFutebol
{
    public partial class frConsultaTecnico : Form
    {

        public int IdSelecionado { get; private set; }
        public frConsultaTecnico()
        {
            InitializeComponent();
        }
           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<TecnicoVO> lista = (new  TecnicoDAO()).ListarPorNome(txtNome.Text.Trim());
            dataGridView1.DataSource = lista;
            dataGridView1.ReadOnly = true;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                TecnicoVO obj = dataGridView1.CurrentRow.DataBoundItem as TecnicoVO;
                IdSelecionado = obj.Id;
                Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }

    }
}
