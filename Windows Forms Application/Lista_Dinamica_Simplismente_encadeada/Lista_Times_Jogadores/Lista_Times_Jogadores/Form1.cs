using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Times_Jogadores
{
    public partial class Form1 : Form
    {
        ListaJogadores ListaJogadores;
        ListaTimes ListaTime = new ListaTimes();

        static void PesquisaTime(ListaTimes ListaTime, string time, ref TextBox txtTime, ref TextBox txtTreinador,
                                 ref MaskedTextBox mkbNumero, ref TextBox txtJogador, ref ListBox ltbJogadores, ref Label lblCont)
        {
            string[] lista = ListaTime.Listar();

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == "Time: " + time)
                {
                    LimpaTela(ref txtTime, ref txtTreinador, ref mkbNumero, ref txtJogador, ref ltbJogadores, ref lblCont);
                    txtTime.Text = lista[i].Replace("Time: ", "");
                    txtTreinador.Text = lista[++i].Replace("Treinador: ", "");
                    i++;
                    for (int j = 0; j < 11; j++)
                    {
                        ltbJogadores.Items.Add(lista[++i]);
                    }

                    lblCont.Text = "11/11";
                    break;
                }
                lblCont.Text = "0/11";
            }
        }

        static void LimpaTela(ref TextBox txtTime, ref TextBox txtTreinador, ref MaskedTextBox mkbNumero, ref TextBox txtJogador, ref ListBox ltbJogadores, ref Label lblCont)
        {
            txtTime.Text = null;
            txtTreinador.Text = null;
            mkbNumero.Text = null;
            txtJogador.Text = null;
            ltbJogadores.Items.Clear();
            lblCont.Text = "0/11";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtTime.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do time", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtTreinador.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do treinador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lblCont.Text != "11/11")
            {
                MessageBox.Show("O time não possui 11 jogadores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListaJogadores = new ListaJogadores();
            foreach (string jogador in ltbJogadores.Items)
            {
                string[] temp = jogador.Split('-');
                ListaJogadores.InsereNoFim(temp[1].Trim(), temp[0].Trim());
            }

            string[] lista = ListaTime.Listar();
            foreach (string item in lista)
            {
                if (item == "Time: " + txtTime.Text.Trim())
                {
                    MessageBox.Show("Já existe um time com este nome cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            ListaTime.InserirNoFim(txtTime.Text.Trim(), txtTreinador.Text.Trim(), ListaJogadores);
            MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mkbNumero.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do jogador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtJogador.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do jogador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lblCont.Text == "11/11")
            {
                MessageBox.Show("O time já possui 11 jogadores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ltbJogadores.Items.Add(mkbNumero.Text.Trim() + "  -  " + txtJogador.Text.Trim());
            lblCont.Text = (ltbJogadores.Items.Count).ToString() + "/11";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtTime.Text == "")
                return;

            ListaTimes lista_aux = new ListaTimes();
            PesquisaTime(ListaTime, txtTime.Text.Trim(), ref txtTime, ref txtTreinador, ref mkbNumero, ref txtJogador, ref ltbJogadores, ref lblCont);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpaTela(ref txtTime, ref txtTreinador, ref mkbNumero, ref txtJogador, ref ltbJogadores, ref lblCont);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ltbTodos.Items.Clear();
            string[] lista = ListaTime.Listar();
            foreach (string item in lista)
                ltbTodos.Items.Add(item);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtTime.Text == "")
                return;

            string[] lista = ListaTime.Listar();
            int posicao = -1;

            foreach(string item in lista)
            {
                if (item.Substring(0, 5) == "Time:")
                {
                    posicao++;
                    if (item == "Time: " + txtTime.Text.Trim())
                        break;
                }
            }

            ListaTime.RemoveDaPosicao(posicao);

            MessageBox.Show("Removido com Sucesso!", "Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
