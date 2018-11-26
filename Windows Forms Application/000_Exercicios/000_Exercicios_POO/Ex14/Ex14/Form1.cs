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

namespace Ex14
{
    public partial class Form1 : Form
    {
        List<Jogos> listJogos = new List<Jogos>();

        static void Listar(List<Jogos> listJogos, ListBox ltbJogos)
        {
            ltbJogos.Items.Clear();
            foreach (Jogos jogo in listJogos)
            {
                string conteudo = "Código: " + jogo.Codigo +
                                  " Descrição: " + jogo.Descricao +
                                  " Dificuldade: " + jogo.Difficulty +
                                  " Valor: " + jogo.Valor +
                                  " Fabricante: " + jogo.Fabricante;
                ltbJogos.Items.Add(conteudo);
            }
        }

        static void Listar(List<Jogos> listJogos, ListBox ltbJogos, string difficulty)
        {
            ltbJogos.Items.Clear();
            foreach (Jogos jogo in listJogos)
            {
                if (jogo.Difficulty == difficulty)
                {
                    string conteudo = "Código: " + jogo.Codigo +
                                  " Descrição: " + jogo.Descricao +
                                  " Dificuldade: " + jogo.Difficulty +
                                  " Valor: " + jogo.Valor +
                                  " Fabricante: " + jogo.Fabricante;
                    ltbJogos.Items.Add(conteudo);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fabricante a = new Fabricante();
            foreach (string item in a.Fabricantes)
                cbFabricante.Items.Add(item);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Jogos a = new Jogos();
            try
            {
                int teste;
                if (Int32.TryParse(txtCodigo.Text, out teste))
                    a.Codigo = Convert.ToInt32(txtCodigo.Text);
                else
                    throw new Exception("Código inválido");
                a.Descricao = txtDescricao.Text;
                a.Difficulty = cbDificuldade.Text;
                double teste2;
                if (Double.TryParse(txtValor.Text, out teste2))
                    a.Valor = Convert.ToDouble(txtValor.Text);
                else
                    throw new Exception("Valor inválido");
                a.Fabricante = cbFabricante.Text;
                a.Salvar();
                MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            listJogos = new List<Jogos>();
            string[] cadastros = File.ReadAllLines("cadastros.txt");

            foreach (string item in cadastros)
            {
                Jogos a = new Jogos();
                string[] temp = item.Split('|');
                a.Codigo = Convert.ToInt32(temp[0]);
                a.Descricao = temp[1];
                a.Difficulty = temp[2];
                a.Valor = Convert.ToDouble(temp[3]);
                a.Fabricante = temp[4];
                listJogos.Add(a);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cbDificuldades.SelectedIndex == -1)
                Listar(listJogos, ltbJogos);
            else
                Listar(listJogos, ltbJogos, cbDificuldades.SelectedItem.ToString());
        }
    }
}
