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

namespace EX_4_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool haerros = false;

            if (txtNome.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNome, "Preencha este campo");
                haerros = true;
            }

            if (txtTelefone.Text.Replace("-","").Length != 8) 
            {
                errorProvider1.SetError(txtTelefone, "Campo errado!");
                haerros = true;
            }

            if (haerros)
                return;

            string conteudo = txtNome.Text + "|" + txtTelefone.Text + Environment.NewLine;
           
            saveFileDialog1.Filter = "Arquivos texto|*.txt";
            //saveFileDialog1.Filter = "Fotos|*.png;*.gif;*.bmp;*.jpg|Vídeos|*.mpg";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = "dados.txt";
            saveFileDialog1.InitialDirectory = "z:\\";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.AppendAllText(saveFileDialog1.FileName, conteudo);
                MessageBox.Show("Gravado!");
            }
        }

        private void btnMudaCor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==  DialogResult.OK)
            {
                string[] vetor = File.ReadAllLines(openFileDialog1.FileName);

                foreach(string linha in vetor)
                {
                    string[] dados = linha.Split('|');
                    if (dados[0] == txtPesquisa.Text.Trim())
                    {
                        txtNome.Text = dados[0];
                        txtTelefone.Text = dados[1];
                        return;
                    }
                }

                MessageBox.Show("Não encontrei!");
            }
        }
    }
}
