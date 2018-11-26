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

namespace teste2
{
    public partial class frProcurarCadastro : Form
    {
        public string[] arquivo;
        public struct Cadastrados
        {
            public string codigo, nome;
        }

        public int codInterno = -1;

        public frProcurarCadastro()
        {
            InitializeComponent();
            if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\cartas.txt"))
            {
                arquivo = File.ReadAllLines("cartas.txt", Encoding.Default);
                Cadastrados[] Cartas = new Cadastrados[arquivo.Length];

                for (int i = 0; i < arquivo.Length; i++)
                {
                    string[] temp = arquivo[i].Split('|');
                    Cartas[i].codigo = temp[1].Trim();
                    Cartas[i].nome = temp[2].Trim();
                    lstCartas.Items.Add("   > " + Cartas[i].codigo + "   |   " + Cartas[i].nome);
                }
            }

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            codInterno = lstCartas.SelectedIndex;
            if (codInterno == -1)
                MessageBox.Show("Nenhum item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
