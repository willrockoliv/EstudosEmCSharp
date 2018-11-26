using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        int jogadas = 0;
        bool velha = true, fim = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Vitoria()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                    (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                    (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
                    (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                    (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                    (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                    (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                    (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                MessageBox.Show("Jogador 1 Venceu");
                fim = true;
                velha = false;
                return;
            }
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                MessageBox.Show("Jogador 2 Venceu");
                fim = true;
                velha = false;
                return;
            }

            if (jogadas == 9 && velha == true)
            {
                MessageBox.Show("Deu Velha!");
                fim = true;
                return;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (fim == false)
            {
                if (Player1.Enabled)
                {
                    button1.Text = "X";
                    Player2.Enabled = true;
                    Player2.Checked = true;
                    Player1.Enabled = false;
                    button1.Enabled = false;
                    jogadas++;
                }

                else
                {
                    button1.Text = "O";
                    Player1.Enabled = true;
                    Player1.Checked = true;
                    Player2.Enabled = false;
                    button1.Enabled = false;
                    jogadas++;
                }

                Vitoria();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fim == false)
            {
                if (Player1.Enabled)
                {
                    button2.Text = "X";
                    Player2.Enabled = true;
                    Player2.Checked = true;
                    Player1.Enabled = false;
                    button2.Enabled = false;
                    jogadas++;
                }

                else
                {
                    button2.Text = "O";
                    Player1.Enabled = true;
                    Player1.Checked = true;
                    Player2.Enabled = false;
                    button2.Enabled = false;
                    jogadas++;
                }

                Vitoria();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fim == false)
            {
                if (Player1.Enabled)
                {
                    button3.Text = "X";
                    Player2.Enabled = true;
                    Player2.Checked = true;
                    Player1.Enabled = false;
                    button3.Enabled = false;
                    jogadas++;
                }

                else
                {
                    button3.Text = "O";
                    Player1.Enabled = true;
                    Player1.Checked = true;
                    Player2.Enabled = false;
                    button3.Enabled = false;
                    jogadas++;
                }

                Vitoria();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fim == false)
            {
                if (Player1.Enabled)
                {
                    button4.Text = "X";
                    Player2.Enabled = true;
                    Player2.Checked = true;
                    Player1.Enabled = false;
                    button4.Enabled = false;
                    jogadas++;
                }

                else
                {
                    button4.Text = "O";
                    Player1.Enabled = true;
                    Player1.Checked = true;
                    Player2.Enabled = false;
                    button4.Enabled = false;
                    jogadas++;
                }

                Vitoria();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fim == false)
            {
                if (Player1.Enabled)
                {
                    button5.Text = "X";
                    Player2.Enabled = true;
                    Player2.Checked = true;
                    Player1.Enabled = false;
                    button5.Enabled = false;
                    jogadas++;
                }

                else
                {
                    button5.Text = "O";
                    Player1.Enabled = true;
                    Player1.Checked = true;
                    Player2.Enabled = false;
                    button5.Enabled = false;
                    jogadas++;
                }

                Vitoria();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fim == false)
            {
                if (Player1.Enabled)
                {
                    button6.Text = "X";
                    Player2.Enabled = true;
                    Player2.Checked = true;
                    Player1.Enabled = false;
                    button6.Enabled = false;
                    jogadas++;
                }

                else
                {
                    button6.Text = "O";
                    Player1.Enabled = true;
                    Player1.Checked = true;
                    Player2.Enabled = false;
                    button6.Enabled = false;
                    jogadas++;
                }

                Vitoria();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fim == false)
            {
                if (Player1.Enabled)
                {
                    button7.Text = "X";
                    Player2.Enabled = true;
                    Player2.Checked = true;
                    Player1.Enabled = false;
                    button7.Enabled = false;
                    jogadas++;
                }

                else
                {
                    button7.Text = "O";
                    Player1.Enabled = true;
                    Player1.Checked = true;
                    Player2.Enabled = false;
                    button7.Enabled = false;
                    jogadas++;
                }

                Vitoria();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (fim == false)
            {
                if (Player1.Enabled)
                {
                    button8.Text = "X";
                    Player2.Enabled = true;
                    Player2.Checked = true;
                    Player1.Enabled = false;
                    button8.Enabled = false;
                    jogadas++;
                }

                else
                {
                    button8.Text = "O";
                    Player1.Enabled = true;
                    Player1.Checked = true;
                    Player2.Enabled = false;
                    button8.Enabled = false;
                    jogadas++;
                }

                Vitoria();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (fim == false)
            {
                if (Player1.Enabled)
                {
                    button9.Text = "X";
                    Player2.Enabled = true;
                    Player2.Checked = true;
                    Player1.Enabled = false;
                    button9.Enabled = false;
                    jogadas++;
                }

                else
                {
                    button9.Text = "O";
                    Player1.Enabled = true;
                    Player1.Checked = true;
                    Player2.Enabled = false;
                    button9.Enabled = false;
                    jogadas++;
                }

                Vitoria();
            }
        }
    }
}
