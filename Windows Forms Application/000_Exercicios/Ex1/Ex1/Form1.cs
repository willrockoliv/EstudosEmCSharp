using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCodigo.Text = "1";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txtCodigo.Text);    
            }
            catch
            {
                MessageBox.Show("O campo Código só aceita números inteiros",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Campo Nome está vazio!",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (Convert.ToDateTime(txtDataNasc.Text) > DateTime.Now)
                    MessageBox.Show("Data de Nascimento inválida!",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Campo Data de Nascimento está vazio!",
                                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
    }
}
