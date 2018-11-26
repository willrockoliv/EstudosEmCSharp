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

namespace EX_6_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private bool DadosValidos()
        {
            errorProvider1.Clear();
            bool haErros = false;

            try
            {
                if (Convert.ToInt32(txtCodigo.Text) < 0)
                {
                    errorProvider1.SetError(txtCodigo, "Código não pode ser negativo!");
                    haErros = true;
                }
            }
            catch
            {
                errorProvider1.SetError(txtCodigo, "Código deve ser numérico!");
                haErros = true;
            }



            if (txtNome.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNome, "Informe o nome!");
                haErros = true;
            }


            try
            {
                if (Convert.ToDateTime(txtData.Text)  > DateTime.Now)
                {
                    errorProvider1.SetError(txtData, "Data inválida!");
                    haErros = true;
                }
            }
            catch
            {
                errorProvider1.SetError(txtData, "Data inválida!");
                haErros = true;
            }



            if (rbAcao.Checked == false && 
                rbCorrida.Checked == false && 
                rbLuta.Checked == false)
            {
                errorProvider1.SetError(groupBox1, "Escolha algo!");
                haErros = true;
            }


            if (cbFabricante.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbFabricante, "Escolha o fabricante!");
                haErros = true;
            }



            try
            {
                if (Convert.ToDouble(txtPreco.Text) < 0)
                {
                    errorProvider1.SetError(txtPreco, "Preço não pode ser negativo!");
                    haErros = true;
                }
            }
            catch
            {
                errorProvider1.SetError(txtPreco, "Preço deve ser numérico!");
                haErros = true;
            }

            return !haErros;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (DadosValidos() == false)
                return;

            string categ = "A";
            if (rbCorrida.Checked)
                categ = "C";
            else if (rbLuta.Checked)
                categ = "L";

            string dados =
                txtCodigo.Text + Environment.NewLine +
                txtNome.Text + Environment.NewLine +
                txtData.Text + Environment.NewLine +
                txtPreco.Text + Environment.NewLine +
                cbFabricante.Text + Environment.NewLine + 
                categ;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, dados);
            }

            txtCodigo.Clear();
            txtData.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            cbFabricante.SelectedIndex = -1;
            rbAcao.Checked = rbCorrida.Checked = rbLuta.Checked = false;

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] vetor = File.ReadAllLines(openFileDialog1.FileName);

                txtCodigo.Text = vetor[0];
                txtNome.Text = vetor[1];
                txtData.Text = vetor[2];
                txtPreco.Text = vetor[3];
                cbFabricante.SelectedIndex = cbFabricante.Items.IndexOf(vetor[4]);

                if (vetor[5] == "A")
                    rbAcao.Checked = true;
                else if (vetor[5] == "C")
                    rbCorrida.Checked = true;
                else
                    rbLuta.Checked = true;
            }
        }
    }
}
