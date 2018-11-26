using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ads2.EXJogoDaVelha
{
    public partial class Frm_JogoDaVelha : Form
    {
        string Nome_jogador1, Nome_jogador2;
        int contador = 0, pntsJog1 = 0, pntsJog2 = 0, empates = 0, jogadas = 0;

        public Frm_JogoDaVelha()
        {
            InitializeComponent();
            MessageBox.Show("Bem vindo ao Jogo da velha *--------*" + Environment.NewLine + "Para iniciar digite seu nome e de seu oponente no local indicado, ou se preferir, jogue com a configuração default", "Jogo Da Velha =D", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Frm_JogoDaVelha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do jogo.?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            Nome_jogador1 = txt_jogador1.Text;
            Nome_jogador2 = txt_jogador2.Text;

            txt_jogador1.Visible = false;
            txt_jogador2.Visible = false;

            lbl_jogador1.Text = Nome_jogador1 + " joga com";
            lbl_jogador2.Text = Nome_jogador2 + " joga com";
            lbl_placar1.Text = "0";
            lbl_placar2.Text = "0";

            if (rbtn_xjog1.Checked)
            {
                MessageBox.Show("" + txt_jogador1.Text + " começa a partida", "Vamos começar =D", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lbl_jogador1.Text = lbl_jogador1.Text + " X ";

                lbl_jogador2.Text = lbl_jogador2.Text + " O ";
            }
            if (rbtn_ojog1.Checked)
            {
                MessageBox.Show("" + txt_jogador2.Text + " começa a partida", "Vamos começar =D", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lbl_jogador1.Text = lbl_jogador1.Text + " O ";

                lbl_jogador2.Text = lbl_jogador2.Text + " X ";
            }
            rbtn_xjog1.Visible = false;
            rbtn_ojog1.Visible = false;
            pnl_Baixo.Enabled = true;
            btn_iniciar.Enabled = false;
        }


        private void Empate()
        {
            if (jogadas == 9)
            {
                MessageBox.Show("Empate.!!!" + Environment.NewLine + "Clique em OK para continuar", "Deu Velha.!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                empates++;
                jogadas = 0;
                contador = 0;
            }
            lbl_empate.Text = Convert.ToString(empates);

        }
        private void Vencedor()
        {
            if ((btn1.Text == "X") && (btn2.Text == "X") && (btn3.Text == "X") ||
                (btn4.Text == "X") && (btn5.Text == "X") && (btn6.Text == "X") ||
                (btn7.Text == "X") && (btn8.Text == "X") && (btn9.Text == "X") ||
                (btn1.Text == "X") && (btn4.Text == "X") && (btn7.Text == "X") ||
                (btn2.Text == "X") && (btn5.Text == "X") && (btn8.Text == "X") ||
                (btn3.Text == "X") && (btn6.Text == "X") && (btn9.Text == "X") ||
                (btn1.Text == "X") && (btn5.Text == "X") && (btn9.Text == "X") ||
                (btn3.Text == "X") && (btn5.Text == "X") && (btn7.Text == "X"))
            {
                if (rbtn_xjog1.Checked == true)
                {
                    if (txt_jogador1.Text == "Fran")
                    {
                        MessageBox.Show("Parabéns meu Amorzinho *------*" + Environment.NewLine + "Você Venceu *-----------*", "Parabéns *--------*", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        pntsJog1++;
                        lbl_placar1.Text = Convert.ToString(pntsJog1);
                    }

                    else
                    {
                        MessageBox.Show("Parabéns " + txt_jogador1.Text + " !!!" + Environment.NewLine + "Você Venceu *-----------*", "Parabéns *--------*", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        pntsJog1++;
                        lbl_placar1.Text = Convert.ToString(pntsJog1);
                    }
                }
                else
                {
                    if (txt_jogador2.Text == "Fran")
                    {
                        MessageBox.Show("Parabéns meu Amorzinho *------*" + Environment.NewLine + "Você Venceu *-----------*", "Parabéns *--------*", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        pntsJog2++;
                        lbl_placar2.Text = Convert.ToString(pntsJog2);
                    } 
                    MessageBox.Show("Parabéns " + txt_jogador2.Text + " !!!" + Environment.NewLine + "Você Venceu *-----------*", "Parabéns *--------*", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    pntsJog2++;
                    lbl_placar2.Text = Convert.ToString(pntsJog2);
                }
                Desabilitar_btns();
                contador = 0;
                jogadas = 0;
            }

            if ((btn1.Text == "O") && (btn2.Text == "O") && (btn3.Text == "O") ||
                (btn4.Text == "O") && (btn5.Text == "O") && (btn6.Text == "O") ||
                (btn7.Text == "O") && (btn8.Text == "O") && (btn9.Text == "O") ||
                (btn1.Text == "O") && (btn4.Text == "O") && (btn7.Text == "O") ||
                (btn2.Text == "O") && (btn5.Text == "O") && (btn8.Text == "O") ||
                (btn3.Text == "O") && (btn6.Text == "O") && (btn9.Text == "O") ||
                (btn1.Text == "O") && (btn5.Text == "O") && (btn9.Text == "O") ||
                (btn3.Text == "O") && (btn5.Text == "O") && (btn7.Text == "O"))
            {

                if (rbtn_ojog1.Checked == true)
                {
                    MessageBox.Show("Parabéns " + txt_jogador1.Text + " !!!" + Environment.NewLine + "Você Venceu *-----------*", "Parabéns *--------*", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    pntsJog1++;
                    lbl_placar1.Text = Convert.ToString(pntsJog1);
                }
                else
                {
                    MessageBox.Show("Parabéns " + txt_jogador2.Text + " !!!" + Environment.NewLine + "Você Venceu *-----------*", "Parabéns *--------*", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    pntsJog2++;
                    lbl_placar2.Text = Convert.ToString(pntsJog2);
                }
                Desabilitar_btns();
                contador = 0;
                jogadas = 0;
            }

        }
        private void MtdBtn(Button btn)
        {
            if (contador == 0)
            {
                btn.Text = "X";
                contador = 1;
            }
            else if (contador == 1)
            {
                btn.Text = "O";
                contador = 0;
            }
            jogadas++;
            btn.Enabled = false;            
            Vencedor();
            Empate();


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MtdBtn(btn1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            MtdBtn(btn2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            MtdBtn(btn3);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            MtdBtn(btn4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            MtdBtn(btn5);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            MtdBtn(btn6);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            MtdBtn(btn7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            MtdBtn(btn8);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            MtdBtn(btn9);
        }


        public void limpar()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }
        public void Habilitar_btns()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

        }
        public void Desabilitar_btns()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

        }
        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            limpar();
            Habilitar_btns();
            jogadas = 0;

        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_jogador1_Click(object sender, EventArgs e)
        {
            txt_jogador1.SelectAll();
            txt_jogador1.Focus();

        }

        private void txt_jogador2_Click(object sender, EventArgs e)
        {
            txt_jogador2.SelectAll();
            txt_jogador2.Focus();
        }

        
    }
}
