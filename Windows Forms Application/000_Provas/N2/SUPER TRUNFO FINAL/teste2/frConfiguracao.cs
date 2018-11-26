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
    public partial class frConfiguracao : Form
    {
        public bool som = true;
        public frConfiguracao()
        {
            InitializeComponent();
            string configuracaoTexto = File.ReadAllText("Cfg.txt");
            string[] configuracaoVetor = configuracaoTexto.Split('|');
            rbsomligado.Checked = Convert.ToBoolean(configuracaoVetor[0]);
            rbsomdesligado.Checked = Convert.ToBoolean(configuracaoVetor[1]);
            rbfacil.Checked = Convert.ToBoolean(configuracaoVetor[2]);
            rbmedio.Checked = Convert.ToBoolean(configuracaoVetor[3]);
            rbdificil.Checked = Convert.ToBoolean(configuracaoVetor[4]);
        }

        private void btnSairSobre_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Cfg.txt", rbsomligado.Checked + "|" + rbsomdesligado.Checked + "|" + rbfacil.Checked + "|" + rbmedio.Checked + "|" + rbdificil.Checked);
            if (rbsomdesligado.Checked == true)
                som = false;
            Close();

        }

        private void rbsomligado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsomligado.Checked == true)
                rbsomdesligado.Checked = false;
        }

        private void rbsomdesligado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsomdesligado.Checked == true)
                rbsomligado.Checked = false;
        }

        private void rbfacil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfacil.Checked == true)
            {
                rbdificil.Checked = false;
                rbmedio.Checked = false;
            }
        }

        private void rbdificil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbdificil.Checked == true)
            {
                rbfacil.Checked = false;
                rbmedio.Checked = false;
            }
        }

        private void rbmedio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmedio.Checked == true)
            {
                rbfacil.Checked = false;
                rbdificil.Checked = false;
            }
        }
    }
}
