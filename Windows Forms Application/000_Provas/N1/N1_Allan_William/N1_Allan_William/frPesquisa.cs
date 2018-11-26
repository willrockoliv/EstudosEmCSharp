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

namespace N1_Allan_William
{
    public partial class frPesquisa : Form
    {
        public string[] arquivo;

        //public int posicao = -1;
        public bool ok = false;

        public struct Cadastro
        {
            public string nome, tel;
        }

        public string nome_pesquisa, tel_pesquisa;

        public frPesquisa()
        {
            InitializeComponent();
        }

        private void btnPesquisar2_Click(object sender, EventArgs e)
        {
            if (File.Exists("Agenda.txt"))
            {
                arquivo = File.ReadAllLines("Agenda.txt");                
                Cadastro[] Cadastro = new Cadastro[arquivo.Length];
                for (int i = 0; i < arquivo.Length; i++)
                {
                    string[] temp = arquivo[i].Split('|');
                    Cadastro[i].nome = temp[0].Trim();
                    Cadastro[i].tel = temp[1].Trim();
                }
                for (int i = 0; i < arquivo.Length; i++)
                {
                    if (txtNomePesquisa.Text.Trim().ToUpper() == Cadastro[i].nome.ToUpper())
                    {
                        nome_pesquisa = Cadastro[i].nome;
                        tel_pesquisa = Cadastro[i].tel;
                        ok = true;
                        break;
                    }
                }
                if (ok == false)
                {
                    MessageBox.Show("Nome não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
                else
                    Close();
            }
        }
    }
}
