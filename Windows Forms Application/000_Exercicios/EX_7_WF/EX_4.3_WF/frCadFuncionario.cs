using EX_4._3_WF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_4._3_WF
{
    public partial class frCadFuncionario : Form
    {
        public frCadFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool erro = false;
            errorProvider1.Clear();
                       

            try
            {
                if (Convert.ToInt32(txtCodigo.Text) <= 0)
                {
                    errorProvider1.SetError(txtCodigo, "Código inválido");
                    erro = true;
                }                
            }
            catch
            {
                errorProvider1.SetError(txtCodigo, "Código inválido");
                erro = true;
            }


            if (txtNome.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNome, "Nome inválido");
                erro = true;
            }            

            if (!ValidaDouble(txtSalario, "Salário inválido"))
                erro = true;            

            if (!ValidaDouble(txtHExtra, "H.extra inválida"))
                erro = true;
            
            if (!ValidaDouble(txtDescontos, "Desconto inválido"))
                erro = true;           


            if (erro)
            {                
                return;
            }
            else
            {
                double salarioFinal = Convert.ToDouble(txtSalario.Text) +
                    Convert.ToDouble(txtHExtra.Text) -
                    Convert.ToDouble(txtDescontos.Text);

                txtSFinal.Text = salarioFinal.ToString();
            }
        }


        private bool ValidaDouble(TextBox caixaTexto, string msg)
        {
            try
            {
                if (Convert.ToDouble(caixaTexto.Text) <= 0)
                {
                    errorProvider1.SetError(caixaTexto, msg);
                    return false;
                }
                return true;
            }
            catch
            {
                caixaTexto.Clear(); 
                errorProvider1.SetError(caixaTexto, msg);
                return false;
            }
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frResumo telaResumo = new frResumo();            
            telaResumo.resumo = 
                "Código: " + txtCodigo.Text + " - " +
                "Nome: " + txtNome.Text + " - " +
                "Salário: " + txtSalario.Text + " - " +
                "H.Extra: " + txtHExtra.Text + " - " +
                "Desconto: " + txtDescontos.Text+ " - " +
                "Salário final: " + txtSFinal.Text;

            telaResumo.ShowDialog();  
        }
    }
}
