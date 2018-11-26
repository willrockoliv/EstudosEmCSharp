using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {

        public int jogador = 1;
        public int mostraGanhador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void Ganhador()
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
                mostraGanhador = 1;
            }

            if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                mostraGanhador = 2;
            }

            if (button1.Text != "" &&
                button2.Text != "" &&
                button3.Text != "" &&
                button4.Text != "" &&
                button5.Text != "" &&
                button6.Text != "" &&
                button7.Text != "" &&
                button8.Text != "" &&
                button9.Text != "")
            {
                mostraGanhador = 3;
            }

            lblInforma.Text = "Jogador " + jogador;

            if (mostraGanhador != 0 && mostraGanhador != 3)
            {
                lblVenceu.Text = "O jogador " + mostraGanhador + " venceu!";
                lblInforma.Text = "";
            }

            if (mostraGanhador == 3)
            {
                lblVenceu.Text = "Não houve vencedor!";
                lblInforma.Text = "";
            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mostraGanhador == 0 && button1.Text == "")
            {
                if (jogador == 1)
                {
                    button1.Text = "X";
                    jogador = 2;
                    
                }
                else
                {
                    button1.Text = "O";
                    jogador = 1;
                }
            }

            button1.FlatStyle = FlatStyle.Standard;
            Ganhador();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mostraGanhador == 0 && button2.Text == "")
            {
                if (jogador == 1)
                {
                    button2.Text = "X";
                    jogador = 2;
                }
                else
                {
                    button2.Text = "O";
                    jogador = 1;
                }
            }

            button2.FlatStyle = FlatStyle.Standard;
            Ganhador();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mostraGanhador == 0 && button3.Text == "")
            {
                if (jogador == 1)
                {
                    button3.Text = "X";
                    jogador = 2;
                }
                else
                {
                    button3.Text = "O";
                    jogador = 1;
                }
            }

            button3.FlatStyle = FlatStyle.Standard;
            Ganhador();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mostraGanhador == 0 && button4.Text == "")
            {
                if (jogador == 1)
                {
                    button4.Text = "X";
                    jogador = 2;
                }
                else
                {
                    button4.Text = "O";
                    jogador = 1;
                }
            }

            button4.FlatStyle = FlatStyle.Standard;
            Ganhador();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mostraGanhador == 0 && button5.Text == "")
            {
                if (jogador == 1)
                {
                    button5.Text = "X";
                    jogador = 2;
                }
                else
                {
                    button5.Text = "O";
                    jogador = 1;
                }
            }

            button5.FlatStyle = FlatStyle.Standard;
            Ganhador();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mostraGanhador == 0 && button6.Text == "")
            {
                if (jogador == 1)
                {
                    button6.Text = "X";
                    jogador = 2;
                }
                else
                {
                    button6.Text = "O";
                    jogador = 1;
                }
            }

            button6.FlatStyle = FlatStyle.Standard;
            Ganhador();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mostraGanhador == 0 && button7.Text == "")
            {
                if (jogador == 1)
                {
                    button7.Text = "X";
                    jogador = 2;
                }
                else
                {
                    button7.Text = "O";
                    jogador = 1;
                }
            }

            button7.FlatStyle = FlatStyle.Standard;
            Ganhador();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mostraGanhador == 0 && button8.Text == "")
            {
                if (jogador == 1)
                {
                    button8.Text = "X";
                    jogador = 2;
                }
                else
                {
                    button8.Text = "O";
                    jogador = 1;
                }
            }

            button8.FlatStyle = FlatStyle.Standard;
            Ganhador();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mostraGanhador == 0 && button9.Text == "")
            {
                if (jogador == 1)
                {
                    button9.Text = "X";
                    jogador = 2;
                }
                else
                {
                    button9.Text = "O";
                    jogador = 1;
                }
            }
            button9.FlatStyle = FlatStyle.Standard;
            Ganhador();
        }

        private void btNovoJogo_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.System;
            button2.FlatStyle = FlatStyle.System;
            button3.FlatStyle = FlatStyle.System;
            button4.FlatStyle = FlatStyle.System;
            button5.FlatStyle = FlatStyle.System;
            button6.FlatStyle = FlatStyle.System;
            button7.FlatStyle = FlatStyle.System;
            button8.FlatStyle = FlatStyle.System;
            button9.FlatStyle = FlatStyle.System;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            jogador = 1;
            mostraGanhador = 0;
            lblInforma.Text = "Jogador 1";
            lblVenceu.Text = "";
        }

        private void lblInforma_Click(object sender, EventArgs e)
        {

        }
    }
}
