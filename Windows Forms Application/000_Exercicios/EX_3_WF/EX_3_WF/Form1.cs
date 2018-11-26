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
            if (txtCodigo.Value <= 0)
            {
                MsgErro("Código inválido");
                return;
            }

            if (bla.Text.Trim() == "")
            {
                MsgErro("Nome inválido");
                return;
            }

            try
            {
                Convert.ToDateTime(txtData.Text);
            }
            catch
            {
                MsgErro("Data inválida");
                return;
            }

            if ((rbFeminino.Checked ^
                rbMasculino.Checked) == false)
            {
                MsgErro("Escolha um sexo");
                return;
            }


            if (ckPossuiCasa.Checked && lbEletrodomesticos.SelectedItems.Count == 0)
            {
                MsgErro("Selecione ao menos um eletrodoméstico");
                return;
            }


            if (cbCidade.SelectedIndex == -1)
            {
                MsgErro("Escolha uma cidade");
                return;
            }


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
