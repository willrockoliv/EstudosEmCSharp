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
    public partial class frTelaBuscaCEP : Form
    {
        public string cep; // criar na tela que vai ser chamada

        public frTelaBuscaCEP()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cep = txtCEP.Text;         
            Close();
        }

        private void frTelaBuscaCEP_Load(object sender, EventArgs e)
        {
            txtCEP.Text = cep;
        }
    }
}
