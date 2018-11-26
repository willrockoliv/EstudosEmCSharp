using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
            Text = "Exercício 1";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txtCodigo.Text);            
            }
            catch
            {
                MessageBox.Show("Código errado!", "Erro!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCodigo.Focus();
                txtCodigo.SelectAll();
                //txtCodigo.Select();

                return;
            }

            if (txtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o nome!", "Erro!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }

            try
            {
                if (Convert.ToDateTime(txtData.Text) > DateTime.Now)
                {
                    MessageBox.Show("Não pode ser superior a hoje!", "Erro!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtData.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Data inválida!", "Erro!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtData.Focus();
                return;
            }


            MessageBox.Show("Perfeito!", "OK!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
                txtCodigo.BackColor = Color.Red;
            else
                txtCodigo.BackColor = Color.White;

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0)
                txtNome.BackColor = Color.Red;
            else
                txtNome.BackColor = Color.White;
        }
    }
}
