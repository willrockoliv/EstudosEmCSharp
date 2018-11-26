using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class Form1 : Form
    {
        string jogador1, jogador2, jogada;
        int contador = 0, empates = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o Jogo da Velha ?", "Aviso", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }



        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            if ((txt_jogador1.Text == "") || (txt_jogador2.Text == ""))
            {
                MessageBox.Show("Digite algum nome!", "Aviso");
                return;
            }

            jogador1 = txt_jogador1.Text;
            txt_jogador1.Visible = false;
            lbl_jogador.Text = jogador1 + " Joga com ";

            jogador2 = txt_jogador2.Text;
            txt_jogador2.Visible = false;
            lbl_jogador2.Text = jogador2 + " Joga com ";

            if (rb_X.Checked)
            {
                lbl_jogador.Text = lbl_jogador.Text + "X";
            }
            else if (rb_O.Checked)
            {
                lbl_jogador.Text = lbl_jogador.Text + "O";
            }

            if (rb_O.Checked)
            {
                lbl_jogador2.Text = lbl_jogador2.Text + "X";
            }
            else if (rb_X.Checked)
            {
                lbl_jogador2.Text = lbl_jogador2.Text + "O";
            }

            gb_Opcoes.Enabled = false;
            panel2.Enabled = true;

        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_1.Text = jogada;
                bt_1.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_1.Text = jogada;
                bt_1.Enabled = false;
            }
            contador++;
            Vencedor();
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_2.Text = jogada;
                bt_2.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_2.Text = jogada;
                bt_2.Enabled = false;
            }
            contador++;
            Vencedor();
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_3.Text = jogada;
                bt_3.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_3.Text = jogada;
                bt_3.Enabled = false;
            }
            contador++;
            Vencedor();
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_4.Text = jogada;
                bt_4.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_4.Text = jogada;
                bt_4.Enabled = false;
            }
            contador++;
            Vencedor();
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_5.Text = jogada;
                bt_5.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_5.Text = jogada;
                bt_5.Enabled = false;
            }
            contador++;
            Vencedor();
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_6.Text = jogada;
                bt_6.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_6.Text = jogada;
                bt_6.Enabled = false;
            }
            contador++;
            Vencedor();
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_7.Text = jogada;
                bt_7.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_7.Text = jogada;
                bt_7.Enabled = false;
            }
            contador++;
            Vencedor();
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_8.Text = jogada;
                bt_8.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_8.Text = jogada;
                bt_8.Enabled = false;
            }
            contador++;
            Vencedor();
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if (rb_X.Checked)
            {
                jogada = rb_X.Text;
                rb_O.Checked = true;
                bt_9.Text = jogada;
                bt_9.Enabled = false;
            }

            else if (rb_O.Checked)
            {
                jogada = rb_O.Text;
                rb_X.Checked = true;
                bt_9.Text = jogada;
                bt_9.Enabled = false;
            }
            contador++;
            Vencedor();
        }
        public void Vencedor()
        {
            if ((bt_1.Text == "X" && bt_2.Text == "X" && bt_3.Text == "X") ||
                (bt_4.Text == "X" && bt_5.Text == "X" && bt_6.Text == "X") ||
                (bt_7.Text == "X" && bt_8.Text == "X" && bt_9.Text == "X") ||
                (bt_1.Text == "X" && bt_5.Text == "X" && bt_9.Text == "X") ||
                (bt_3.Text == "X" && bt_5.Text == "X" && bt_7.Text == "X") ||
                (bt_1.Text == "X" && bt_4.Text == "X" && bt_7.Text == "X") ||
                (bt_2.Text == "X" && bt_5.Text == "X" && bt_8.Text == "X") ||
                (bt_3.Text == "X" && bt_6.Text == "X" && bt_9.Text == "X"))
            {
                MessageBox.Show("Você ganhou!");
                Limpar();
                HabilitaBotoes();
            }

            else if ((bt_1.Text == "O" && bt_2.Text == "O" && bt_3.Text == "O") ||
                (bt_4.Text == "O" && bt_5.Text == "O" && bt_6.Text == "O") ||
                (bt_7.Text == "O" && bt_8.Text == "O" && bt_9.Text == "O") ||
                (bt_1.Text == "O" && bt_5.Text == "O" && bt_9.Text == "O") ||
                (bt_3.Text == "O" && bt_5.Text == "O" && bt_7.Text == "O") ||
                (bt_1.Text == "O" && bt_4.Text == "O" && bt_7.Text == "O") ||
                (bt_2.Text == "O" && bt_5.Text == "O" && bt_8.Text == "O") ||
                (bt_3.Text == "O" && bt_6.Text == "O" && bt_9.Text == "O"))
            {
                MessageBox.Show("Você ganhou!");
                Limpar();
                HabilitaBotoes();
            }

            
            else if ((bt_1.Text == "O" && bt_4.Text == "O" && bt_7.Text == "O") ||
                (bt_2.Text == "O" && bt_5.Text == "O" && bt_8.Text == "O") ||
                (bt_3.Text == "O" && bt_6.Text == "O" && bt_9.Text == "O"))
            {
                MessageBox.Show("Você ganhou!");
                Limpar();
                HabilitaBotoes();
            }

            if (contador >= 9)
            {
                empates = empates + 1;
                MessageBox.Show("Empatou");
                contador = 0;
                Limpar();
                HabilitaBotoes();
            }
        }

        public void Limpar()
        {
            bt_1.Text = "";
            bt_2.Text = "";
            bt_3.Text = "";
            bt_4.Text = "";
            bt_5.Text = "";
            bt_6.Text = "";
            bt_7.Text = "";
            bt_8.Text = "";
            bt_9.Text = "";
            panel2.Enabled = true;
            HabilitaBotoes();
            contador = 0;
        }

        public void HabilitaBotoes()
        {
            bt_1.Enabled = true;
            bt_2.Enabled = true;
            bt_3.Enabled = true;
            bt_4.Enabled = true;
            bt_5.Enabled = true;
            bt_6.Enabled = true;
            bt_7.Enabled = true;
            bt_8.Enabled = true;
            bt_9.Enabled = true;

        }

        private void bt_reiniciar_Click(object sender, EventArgs e)
        {
            Limpar();

        }
    }
}
