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

namespace EX_3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbCidade.SelectedIndex = -1;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
                txtCodigo.Text = txtCodigo.Minimum.ToString();
        }

        private void MsgErro(string msg)
        {
            MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool haErro = false;

            if (txtCodigo.Value <= 0)
            {
                errorProvider1.SetError(txtCodigo, "Código inválido");
                haErro = true;
            }

            if (txtNome.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNome, "Nome inválido");
                haErro = true;
            }

            try
            {
                Convert.ToDateTime(txtData.Text);
            }
            catch
            {
                errorProvider1.SetError(txtData, "Data inválida");
                haErro = true;
            }

            if ((rbFeminino.Checked ^
                rbMasculino.Checked) == false)
            {
                errorProvider1.SetError(groupBox1, "Escolha um sexo");
                haErro = true;
            }


            if (ckPossuiCasa.Checked && lbEletrodomesticos.SelectedItems.Count == 0)
            {
                errorProvider1.SetError(ckPossuiCasa, "Selecione ao menos um eletrodoméstico");
                haErro = true;
            }


            if (cbCidade.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbCidade, "Escolha uma cidade");
                haErro = true;
            }

            if (haErro)
                return;

            string conteudo = txtCodigo.Value + "|" +
                txtNome.Text + "|" +
                txtData.Text + "|" +
                cbCidade.SelectedIndex + "|" +
                ckPossuiCasa.Checked + "|" +
                (rbFeminino.Checked ? "F" : "M") + "|";

            foreach (string opcao in lbEletrodomesticos.SelectedItems)
            {
                conteudo += opcao + "|";
            }

            File.WriteAllText("dados.txt", conteudo);

            MessageBox.Show("Salvo!");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (File.Exists("dados.txt"))
            {
                string conteudo = File.ReadAllText("dados.txt");
                string[] dados = conteudo.Split('|');

                txtCodigo.Text = dados[0];
                txtNome.Text = dados[1];
                txtData.Text = dados[2];
                cbCidade.SelectedIndex = Convert.ToInt16(dados[3]);
                ckPossuiCasa.Checked = Convert.ToBoolean(dados[4]);
                if (dados[5] == "F")
                    rbFeminino.Checked = true ;
                else
                    rbMasculino.Checked = true;


                lbEletrodomesticos.ClearSelected();
                for (int n=6; n<dados.Length; n++)
                {
                    if (dados[n].Length > 0)
                    {
                        int posicao = lbEletrodomesticos.Items.IndexOf(dados[n]);
                        lbEletrodomesticos.SetSelected(posicao, true);
                    }
                }
            }
            else
            {
                MsgErro("Arquivo não existe!");
            }
        }
    }
}
