using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int score1=0, score2=0, contBotao = 0;
        string verifica = "O";
        public void limpar() 
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            verifica = "O";
            contBotao = 0;

        }
        public void score() 
        {
            if (contBotao % 2 != 0)
            {
                if (button1.Text + button2.Text + button3.Text == "XXX")
                    score1 += 1;
                if (button4.Text + button5.Text + button6.Text == "XXX")
                    score1 += 1;
                if (button7.Text + button8.Text + button9.Text == "XXX")
                    score1 += 1;
                if (button1.Text + button4.Text + button7.Text == "XXX")
                    score1 += 1;
                if (button2.Text + button5.Text + button8.Text == "XXX")
                    score1 += 1;
                if (button3.Text + button6.Text + button9.Text == "XXX")
                    score1 += 1;
                if (button1.Text + button5.Text + button9.Text == "XXX")
                    score1 += 1;
                if (button3.Text + button5.Text + button7.Text == "XXX")
                    score1 += 1;
            }
            else 
            {
                if (button1.Text + button2.Text + button3.Text == "OOO")
                    score2 += 1;
                if (button4.Text + button5.Text + button6.Text == "OOO")
                    score2 += 1;
                if (button7.Text + button8.Text + button9.Text == "OOO")
                    score2 += 1;
                if (button1.Text + button4.Text + button7.Text == "OOO")
                    score2 += 1;
                if (button2.Text + button5.Text + button8.Text == "OOO")
                    score2 += 1;
                if (button3.Text + button6.Text + button9.Text == "OOO")
                    score2 += 1;
                if (button1.Text + button5.Text + button9.Text == "OOO")
                    score2 += 1;
                if (button3.Text + button5.Text + button7.Text == "OOO")
                    score2 += 1;
            }

            if (score1.ToString() != tbJoga1.Text)
            {
                MessageBox.Show("Jogador 1 ganhou!");
                tbJoga1.Text = score1.ToString();
                limpar();
            }
            else if (score2.ToString() != tbJoga2.Text)
            {
                MessageBox.Show("Jogador 2 ganhou!");
                tbJoga2.Text = score2.ToString();
                limpar();
            }
            else if (contBotao == 9)
            {
                MessageBox.Show("Empate!!!!");
                limpar();

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == " ")
            {
                if (verifica == "X")
                {
                    button1.Text = "O";
                    verifica = "O";
                }
                else
                {
                    button1.Text = "X";
                    verifica = "X";
                }
                contBotao += 1;
            }
            else
            {
                MessageBox.Show("Escolha outro botão");
                return;
            }
            if (contBotao > 4) { score(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == " ")
            {
                if (verifica == "X")
                {
                    button2.Text = "O";
                    verifica = "O";
                }
                else
                {
                    button2.Text = "X";
                    verifica = "X";
                }
                contBotao += 1;
            }
            else
            {
                MessageBox.Show("Escolha outro botão");
                return;
            }
            if (contBotao > 4) { score(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == " ")
            {
                if (verifica == "X")
                {
                    button3.Text = "O";
                    verifica = "O";
                }
                else
                {
                    button3.Text = "X";
                    verifica = "X";
                }
                contBotao += 1;
            }
            else
            {
                MessageBox.Show("Escolha outro botão");
                return;
            }
            if (contBotao > 4) { score(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == " ")
            {
                if (verifica == "X")
                {
                    button4.Text = "O";
                    verifica = "O";
                }
                else
                {
                    button4.Text = "X";
                    verifica = "X";
                }
                contBotao += 1;
            }
            else
            {
                MessageBox.Show("Escolha outro botão");
                return;
            }
            if (contBotao > 4) { score(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == " ")
            {
                if (verifica == "X")
                {
                    button5.Text = "O";
                    verifica = "O";
                }
                else
                {
                    button5.Text = "X";
                    verifica = "X";
                }
                contBotao += 1;
            }
            else
            {
                MessageBox.Show("Escolha outro botão");
                return;
            }
            if (contBotao > 4) { score(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == " ")
            {
                if (verifica == "X")
                {
                    button6.Text = "O";
                    verifica = "O";
                }
                else
                {
                    button6.Text = "X";
                    verifica = "X";
                }
                contBotao += 1;
            }
            else
            {
                MessageBox.Show("Escolha outro botão");
                return;
            }
            if (contBotao > 4) { score(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == " ")
            {
                if (verifica == "X")
                {
                    button7.Text = "O";
                    verifica = "O";
                }
                else
                {
                    button7.Text = "X";
                    verifica = "X";
                }
                contBotao += 1;
            }
            else
            {
                MessageBox.Show("Escolha outro botão");
                return;
            }
            if (contBotao > 4) { score(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == " ")
            {
                if (verifica == "X")
                {
                    button8.Text = "O";
                    verifica = "O";
                }
                else
                {
                    button8.Text = "X";
                    verifica = "X";
                }
                contBotao += 1;
            }
            else
            {
                MessageBox.Show("Escolha outro botão");
                return;
            }
            if (contBotao > 4) { score(); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == " ")
            {
                if (verifica == "X")
                {
                    button9.Text = "O";
                    verifica = "O";
                }
                else
                {
                    button9.Text = "X";
                    verifica = "X";
                }
                contBotao += 1;
            }
            else
            {
                MessageBox.Show("Escolha outro botão");
                return;
            }
            if (contBotao > 4) { score(); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            limpar();
        }
       
    }
}
