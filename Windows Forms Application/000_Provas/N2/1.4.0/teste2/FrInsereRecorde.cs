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

namespace teste2
{
    public partial class FrInsereRecorde : Form
    {
        string Pontos;

        public FrInsereRecorde()
        {
            InitializeComponent();
            Pontos = File.ReadAllText("PontuacaoFinal.txt", Encoding.Default);
            txbPontosFinal.Text = Pontos;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txbNomeJog.Text == "")
            {
                MessageBox.Show("Informe um nome antes de prosseguir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                File.WriteAllText("PontuacaoFinal.txt", txbNomeJog.Text + "|" + Pontos + Environment.NewLine, Encoding.Default);
                Close();
            }
        }
    }
}
