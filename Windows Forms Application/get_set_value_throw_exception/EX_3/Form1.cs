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

namespace EX_3
{
    public partial class Form1 : Form
    {
        Funcionario f;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                f = new Funcionario();
                f.SetCodigo(Convert.ToInt16(txtCodigo.Text));
                f.SetNome(txtNome.Text);
                f.SetRG(txtRG.Text);
                f.SetSalario(Convert.ToDouble(txtSalario.Text));
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + Environment.NewLine  +
                    "Informações para o programador: " + Environment.NewLine + 
                    erro.StackTrace);
            }

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (f == null)
                MessageBox.Show("Crie primeiro!");
            else
            {
                txtResumo.Text = f.GetCodigo() + Environment.NewLine +
                                f.GetNome() + Environment.NewLine +
                                f.GetRG() + Environment.NewLine +
                                f.GetSalario().ToString("0.00") + Environment.NewLine +
                                f.GetInss().ToString("0.00") + Environment.NewLine +
                                f.CalcularSalario().ToString("0.00");
            }

        }
    }
}
