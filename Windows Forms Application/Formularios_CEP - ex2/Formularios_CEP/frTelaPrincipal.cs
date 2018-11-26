using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios_CEP
{
    public partial class frTelaPrincipal : Form
    {
        public frTelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frTelaBuscaCEP telaCEP = new frTelaBuscaCEP();
            telaCEP.txtCEP.Text = "00000-000";
            telaCEP.ShowDialog();
            txtCepREtornado.Text = telaCEP.txtCEP.Text;
        }
    }
}
