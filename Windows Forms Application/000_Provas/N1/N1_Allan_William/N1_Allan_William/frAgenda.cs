using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N1_Allan_William
{
    public partial class frAgenda : Form
    {
        public frAgenda()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCad.Text.Trim() == "" || txtTelCad.Text.Replace(' ','.').IndexOf('.') != -1)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string dados = txtNomeCad.Text.Trim() + " | " + txtTelCad.Text.Trim() + Environment.NewLine;

            File.AppendAllText("Agenda.txt", dados, Encoding.Default);

            MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNomeCad.Clear();
            txtTelCad.Clear();

        }
    }
}
