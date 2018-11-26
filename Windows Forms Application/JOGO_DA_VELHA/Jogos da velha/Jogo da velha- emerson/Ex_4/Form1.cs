using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ex_4
{
    struct Jogada
    {        
        public bool jogador;
        public int Njogador;
    }
    public partial class Form1 : Form
    {
        // Jogador 1 = true jogador 2 = false
        bool Jogador = true;  
        Jogada[] jogada = new Jogada[9];
        

        private void Texto(bool jog)
        {
            if (!pB1.Enabled && !pB2.Enabled && !pB3.Enabled && !pB4.Enabled && !pB5.Enabled && 
                !pB6.Enabled && !pB7.Enabled && !pB8.Enabled && !pB9.Enabled)
            {
                label1.Text = "Jogo finalizado Deu Velha";
            }
            else
            {
                if (jog)
                {
                    label1.Text = " Sua vez jogador 1";
                }
                else
                {
                    label1.Text = "Sua vez jogador 2";
                }
            }
        }

        private void CarregarImagem(PictureBox pbx, bool jog)
        {
            if (jog)
            {
                pbx.Image = Image.FromFile("x.jpg");
            }
            else
            {
                pbx.Image = Image.FromFile("o.jpg");
            }
            pbx.Enabled = false;
        }

        private void ReiniciarImg(PictureBox img)
        {
            img.Enabled = true;
            img.Image = null;
        }

        private void JogadaGuardar(ref Jogada jogada, bool x)
        {
            jogada.jogador = x;
            if (x)
                jogada.Njogador = 1;
            else
                jogada.Njogador = 2;
        }

        private void JogadaReiniciar(ref Jogada[] jogadas)
        {
            for (int i = 0; i < jogadas.Length; i++)
            {
                jogada[i].jogador = false;
                jogada[i].Njogador = 0;
            }
        }

        private void VerificarGanhador(Jogada[] jogo)
        {
            string V1 = "O jogador 1... Ganhou!!";
            string V2 = "O jogador 2... Ganhou!!";
            bool vencedor = false;
            //Verifica primeira linha
            //Verifica segunda linha
            //Verifica terceira linha
            for (int i = 0; i < 3; i++)
            {
                switch (VerificarCampos(0+(i*3), 1+(i*3), 2+(i*3), jogo))
                {
                    case 1: label1.Text = V1;
                        vencedor = true;
                        break;
                    case 2: label1.Text = V2;
                        vencedor = true;
                        break;
                    default:
                        break;
                }
            }
#region codex
            /*switch (VerificarCampos(3, 4, 5, jogo))
            {
                case 1: label1.Text = V1;
                    break;
                case 2: label1.Text = V2;
                    break;
                default:
                    break;
            }
            
            switch (VerificarCampos(6, 7, 8, jogo))
            {
                case 1: label1.Text = V1;
                    break;
                case 2: label1.Text = V2;
                    break;
                default:
                    break;
            }*/
#endregion
            //verifica primeira coluna
            for (int i = 0; i < 3; i++)
            {
                switch (VerificarCampos(0 + (i * 1), 3 + (i * 1), 6 + (i * 1), jogo))
                {
                    case 1: label1.Text = V1;
                        vencedor = true;
                        break;
                    case 2: label1.Text = V2;
                        vencedor = true;
                        break;
                    default:
                        break;
                }
            }
#region codex
            //verifica segunda coluna
            /*switch (VerificarCampos(1, 4, 7, jogo))
            {
                case 1: label1.Text = V1;
                    break;
                case 2: label1.Text = V2;
                    break;
                default:
                    break;
            }
            //verifica terceira coluna
            switch (VerificarCampos(2, 5, 8, jogo))
            {
                case 1: label1.Text = V1;
                    break;
                case 2: label1.Text = V2;
                    break;
                default:
                    break;
            }*/
#endregion
            //verifica vertical 1
            switch (VerificarCampos(0, 4, 8, jogo))
            {
                case 1: label1.Text = V1;
                    vencedor = true;
                    break;
                case 2: label1.Text = V2;
                    vencedor = true;
                    break;
                default:
                    break;
            }
            //verifica vertical 2
            switch (VerificarCampos(6, 4, 2, jogo))
            {
                case 1: label1.Text = V1;
                    vencedor = true;
                    break;
                case 2: label1.Text = V2;
                    vencedor = true;
                    break;
                default:
                    break;
            }
            if (vencedor)
            {
                pB1.Enabled = false;
                pB2.Enabled = false;
                pB3.Enabled = false;
                pB4.Enabled = false;
                pB5.Enabled = false;
                pB6.Enabled = false;
                pB7.Enabled = false;
                pB8.Enabled = false;
                pB9.Enabled = false;
            }
        }        

        private int VerificarCampos(int c1,int c2,int c3,Jogada[] jogo)
        {
                if ((jogo[c1].Njogador == 1) && (jogo[c2].Njogador == 1) && (jogo[c3].Njogador == 1))
                    return 1;
                if ((jogo[c1].Njogador == 2) && (jogo[c2].Njogador == 2) && (jogo[c3].Njogador == 2))
                    return 2;
                return 0;
        }

        private void Partida(Jogada[] J, PictureBox p, bool JJ,int Npbx)
        {
            JogadaGuardar(ref J[Npbx],JJ);
            CarregarImagem(p, JJ);
            Jogador = !Jogador;
            Texto(Jogador);
            VerificarGanhador(J);
        }      


        public Form1()
        {
            InitializeComponent();
        }

        private void btRei_Click(object sender, EventArgs e)
        {
            
            JogadaReiniciar(ref jogada);            
            ReiniciarImg(pB1);
            ReiniciarImg(pB2);
            ReiniciarImg(pB3);
            ReiniciarImg(pB4);
            ReiniciarImg(pB5);
            ReiniciarImg(pB6);
            ReiniciarImg(pB7);
            ReiniciarImg(pB8);
            ReiniciarImg(pB9);
            label1.Text = " Clique em um quadro para iniciar ";
            Jogador = true;
        }              

        private void pB1_Click(object sender, EventArgs e)
        {
            Partida(jogada, pB1, Jogador, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Partida(jogada, pB2, Jogador, 1);
        } 

        private void pB3_Click(object sender, EventArgs e)
        {
            Partida(jogada, pB3, Jogador, 2);
        }

        private void pB4_Click(object sender, EventArgs e)
        {
            Partida(jogada, pB4, Jogador, 3);
        }

        private void pB5_Click(object sender, EventArgs e)
        {
            Partida(jogada, pB5, Jogador, 4);
        }

        private void pB6_Click(object sender, EventArgs e)
        {
            Partida(jogada, pB6, Jogador, 5);
        }

        private void pB7_Click(object sender, EventArgs e)
        {
            Partida(jogada, pB7, Jogador, 6);
        }

        private void pB8_Click(object sender, EventArgs e)
        {
            Partida(jogada, pB8, Jogador, 7);
        }

        private void pB9_Click(object sender, EventArgs e)
        {
            Partida(jogada, pB9, Jogador, 8);
        }
    }
}
