﻿using EX_6_TimeFutebol.DAO;
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
    public partial class frConsultaTimes : Form
    {

        public int IdSelecionado { get; private set; }
        public frConsultaTimes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<TimeVO> lista = (new TimeDAO()).Lista(txtNome.Text.Trim());
            dataGridView1.DataSource = lista;
            dataGridView1.ReadOnly = true;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                IdSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecionar.PerformClick();
        }
    }
}
