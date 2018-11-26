using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                /*Aluno a = new Aluno();
                a.Nome = txtNome.Text;
                a.N1 = Convert.ToDouble(txtN1.Text) ;
                a.N2 = Convert.ToDouble(txtN2.Text); */

                Aluno a = new Aluno(Convert.ToDouble(txtN1.Text),
                    Convert.ToDouble(txtN2.Text),
                    txtNome.Text);
                

                txtResumo.Text =
                    "Nome: " + a.Nome + Environment.NewLine +
                    "N1: " + a.N1.ToString("0.0") + Environment.NewLine +
                    "N2: " + a.N2.ToString("0.0") + Environment.NewLine +
                    "Média: " + a.Media.ToString("0.0");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
