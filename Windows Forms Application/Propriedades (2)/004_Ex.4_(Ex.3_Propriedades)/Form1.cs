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

namespace _004_Ex._4__Ex._3_Propriedades_
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
                f.Codigo = Convert.ToInt16(txtCodigo.Text);
                f.Nome = txtNome.Text;
                f.RG = txtRG.Text;
                f.Salario = Convert.ToDouble(txtSalario.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + Environment.NewLine +
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
                txtResumo.Text = f.Codigo + Environment.NewLine +
                                f.Nome + Environment.NewLine +
                                f.RG + Environment.NewLine +
                                f.Salario.ToString("0.00") + Environment.NewLine +
                                f.Inss.ToString("0.00") + Environment.NewLine +
                                f.CalcularSalario.ToString("0.00");
            }
        }
    }
}
