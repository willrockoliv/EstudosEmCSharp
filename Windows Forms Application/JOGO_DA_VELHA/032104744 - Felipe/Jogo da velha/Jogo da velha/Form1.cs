using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        private void Clica()
        {
            btn1.Enabled = true;
        }
        private void Ganha()
        {
            int play1 = 0, play2 = 0;
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                play1 = 1;
                MessageBox.Show("Jogador 1 ganhou na horizontal de cima");
                Reinicia();
            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                play2 = 1;
                MessageBox.Show("Jogador 2 ganhou na horizontal de cima");
                Reinicia();
            }
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                play1 = 1;
                MessageBox.Show("Jogador 1 ganhou na horizontal do meio");
                Reinicia();
            }
            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                play2 = 1;
                MessageBox.Show("Jogador 2 ganhou na horizontal do meio");
                Reinicia();
            }
            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                play1 = 1;
                MessageBox.Show("Jogador 1 ganhou na horizontal de baixo");
                Reinicia();
            }
            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                play2 = 1;
                MessageBox.Show("Jogador 2 ganhou na horizontal de baixo");
                Reinicia();
            }
            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                play1 = 1;
                MessageBox.Show("Jogador 1 ganhou na vertical da esquerda");
                Reinicia();
            }
            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                play2 = 1;
                MessageBox.Show("Jogador 2 ganhou na vertical da esquerda");
                Reinicia();
            }
            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                play1 = 1;
                MessageBox.Show("Jogador 1 ganhou na vertical do meio");
                Reinicia();
            }
            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                play2 = 1;
                MessageBox.Show("Jogador 2 ganhou na vertical do meio");
                Reinicia();
            }
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                play1 = 1;
                MessageBox.Show("Jogador 1 ganhou na vertical da direita");
                Reinicia();
            }
            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                play2 = 1;
                MessageBox.Show("Jogador 2 ganhou na vertical da direita");
                Reinicia();
            }
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                play1 = 1;
                MessageBox.Show("Jogador 1 ganhou na diagonal da esquerda");
                Reinicia();
            }
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                play2 = 1;
                MessageBox.Show("Jogador 2 ganhou na diagonal da esquerda");
                Reinicia();
            }
            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                play1 = 1;
                MessageBox.Show("Jogador 1 ganhou na diagonal da direita");
                Reinicia();
            }
            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                play2 = 1;
                MessageBox.Show("Jogador 2 ganhou na diagonal da direita");
                Reinicia();
            }
            else if (btn1.Enabled == false && btn2.Enabled == false && btn3.Enabled == false && btn4.Enabled == false && btn5.Enabled == false && btn6.Enabled == false && btn7.Enabled == false && btn8.Enabled == false && btn9.Enabled == false && play1 == 0 && play2 == 0)
            {
                MessageBox.Show("Deu velha");
                Reinicia();
                play1 = 0;
                play2 = 0;
                return;
            }
        }
        private void Reinicia()
        {
            btn1.Text = "";
            btn1.Enabled = true;
            btn2.Text = "";
            btn2.Enabled = true;
            btn3.Text = "";
            btn3.Enabled = true;
            btn4.Text = "";
            btn4.Enabled = true;
            btn5.Text = "";
            btn5.Enabled = true;
            btn6.Text = "";
            btn6.Enabled = true;
            btn7.Text = "";
            btn7.Enabled = true;
            btn8.Text = "";
            btn8.Enabled = true;
            btn9.Text = "";
            btn9.Enabled = true;
            rbtXis.Checked = true;
            return;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ptb1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (rbtXis.Checked)
            {
                btn1.Text = "X";
                btn1.Enabled = false;
                rbtBola.Checked = true;
                Ganha();
                return;
            }
            else
            {
                btn1.Text = "O";
                btn1.Enabled = false;
                rbtXis.Checked = true;
                Ganha();
                return;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (rbtXis.Checked)
            {
                btn2.Text = "X";
                btn2.Enabled = false;
                rbtBola.Checked = true;
                Ganha();
                return;
            }
            else
            {
                btn2.Text = "O";
                btn2.Enabled = false;
                rbtXis.Checked = true;
                Ganha();
                return;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (rbtXis.Checked)
            {
                btn3.Text = "X";
                btn3.Enabled = false;
                rbtBola.Checked = true;
                Ganha();
                return;
            }
            else
            {
                btn3.Text = "O";
                btn3.Enabled = false;
                rbtXis.Checked = true;
                Ganha();
                return;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (rbtXis.Checked)
            {
                btn4.Text = "X";
                btn4.Enabled = false;
                rbtBola.Checked = true;
                Ganha();
                return;
            }
            else
            {
                btn4.Text = "O";
                btn4.Enabled = false;
                rbtXis.Checked = true;
                Ganha();
                return;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (rbtXis.Checked)
            {
                btn5.Text = "X";
                btn5.Enabled = false;
                rbtBola.Checked = true;
                Ganha();
                return;
            }
            else
            {
                btn5.Text = "O";
                btn5.Enabled = false;
                rbtXis.Checked = true;
                Ganha();
                return;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (rbtXis.Checked)
            {
                btn6.Text = "X";
                btn6.Enabled = false;
                rbtBola.Checked = true;
                Ganha();
                return;
            }
            else
            {
                btn6.Text = "O";
                btn6.Enabled = false;
                rbtXis.Checked = true;
                Ganha();
                return;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (rbtXis.Checked)
            {
                btn7.Text = "X";
                btn7.Enabled = false;
                rbtBola.Checked = true;
                Ganha();
                return;
            }
            else
            {
                btn7.Text = "O";
                btn7.Enabled = false;
                rbtXis.Checked = true;
                Ganha();
                return;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (rbtXis.Checked)
            {
                btn8.Text = "X";
                btn8.Enabled = false;
                rbtBola.Checked = true;
                Ganha();
                return;
            }
            else
            {
                btn8.Text = "O";
                btn8.Enabled = false;
                rbtXis.Checked = true;
                Ganha();
                return;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (rbtXis.Checked)
            {
                btn9.Text = "X";
                btn9.Enabled = false;
                rbtBola.Checked = true;
                Ganha();
                return;
            }
            else
            {
                btn9.Text = "O";
                btn9.Enabled = false;
                rbtXis.Checked = true;
                Ganha();
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}
