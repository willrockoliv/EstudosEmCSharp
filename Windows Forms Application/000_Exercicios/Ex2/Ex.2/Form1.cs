using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
            
        }

        int cont = 0;
        bool ja_clicou1 = false, ja_clicou2 = false, ja_clicou3 = false,
             ja_clicou4 = false, ja_clicou5 = false, ja_clicou6 = false,
             ja_clicou7 = false, ja_clicou8 = false, ja_clicou9 = false;
               
        private void lbl1_Click(object sender, EventArgs e)
        {
            if (ja_clicou1 == true)
                return;

            cont++;
            if (cont % 2 == 0)
                lbl1.BackColor = Color.Green;
            else
                lbl1.BackColor = Color.Red;

            if ((lbl1.BackColor == lbl2.BackColor && lbl2.BackColor == lbl3.BackColor) ||
               (lbl1.BackColor == lbl4.BackColor && lbl3.BackColor == lbl7.BackColor) ||
               (lbl1.BackColor == lbl5.BackColor && lbl5.BackColor == lbl9.BackColor))
            {
                if (lbl1.BackColor == Color.Green)
                {
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
                else if (lbl1.BackColor == Color.Red)
                {
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
            }
            
            ja_clicou1 = true;

            ValidaVelha(ref cont);
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            if (ja_clicou2 == true)
                return;

            cont++;
            if (cont % 2 == 0)
                lbl2.BackColor = Color.Green;
            else
                lbl2.BackColor = Color.Red;

            if ((lbl2.BackColor == lbl1.BackColor && lbl2.BackColor == lbl3.BackColor) ||
               (lbl2.BackColor == lbl5.BackColor && lbl5.BackColor == lbl8.BackColor) ||
               (lbl2.BackColor == lbl3.BackColor && lbl2.BackColor == lbl7.BackColor))
            {
                if (lbl2.BackColor == Color.Green)
                {
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
                else if (lbl2.BackColor == Color.Red)
                {
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
            }

            ja_clicou2 = true;

            ValidaVelha(ref cont);
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            if (ja_clicou3 == true)
                return;

            cont++;
            if (cont % 2 == 0)
                lbl3.BackColor = Color.Green;
            else
                lbl3.BackColor = Color.Red;

            if ((lbl3.BackColor == lbl2.BackColor && lbl2.BackColor == lbl1.BackColor) ||
               (lbl3.BackColor == lbl6.BackColor && lbl6.BackColor == lbl9.BackColor) ||
               (lbl3.BackColor == lbl5.BackColor && lbl5.BackColor == lbl7.BackColor))
            {
                if (lbl3.BackColor == Color.Green)
                {
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
                else if (lbl3.BackColor == Color.Red)
                {
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
            }

            ja_clicou3 = true;

            ValidaVelha(ref cont);
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            if (ja_clicou4 == true)
                return;

            cont++;
            if (cont % 2 == 0)
                lbl4.BackColor = Color.Green;
            else
                lbl4.BackColor = Color.Red;

            if ((lbl4.BackColor == lbl1.BackColor && lbl4.BackColor == lbl7.BackColor) ||
               (lbl4.BackColor == lbl5.BackColor && lbl5.BackColor == lbl6.BackColor))
            {
                if (lbl4.BackColor == Color.Green)
                {
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
                else if (lbl4.BackColor == Color.Red)
                {
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
            }

            ja_clicou4 = true;

            ValidaVelha(ref cont);
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            if (ja_clicou5 == true)
                return;

            cont++;
            if (cont % 2 == 0)
                lbl5.BackColor = Color.Green;
            else
                lbl5.BackColor = Color.Red;

            if ((lbl5.BackColor == lbl2.BackColor && lbl5.BackColor == lbl8.BackColor) ||
               (lbl5.BackColor == lbl4.BackColor && lbl5.BackColor == lbl6.BackColor) ||
               (lbl5.BackColor == lbl1.BackColor && lbl5.BackColor == lbl9.BackColor) ||
               (lbl5.BackColor == lbl3.BackColor && lbl5.BackColor == lbl7.BackColor))
            {
                if (lbl5.BackColor == Color.Green)
                {
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
                else if (lbl5.BackColor == Color.Red)
                {
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
            }

            ja_clicou5 = true;

            ValidaVelha(ref cont);
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            if (ja_clicou6 == true)
                return;

            cont++;
            if (cont % 2 == 0)
                lbl6.BackColor = Color.Green;
            else
                lbl6.BackColor = Color.Red;

            if ((lbl6.BackColor == lbl3.BackColor && lbl6.BackColor == lbl9.BackColor) ||
               (lbl6.BackColor == lbl5.BackColor && lbl6.BackColor == lbl4.BackColor))
            {
                if (lbl6.BackColor == Color.Green)
                {
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
                else if (lbl6.BackColor == Color.Red)
                {
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
            }

            ja_clicou6 = true;

            ValidaVelha(ref cont);
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            if (ja_clicou7 == true)
                return;

            cont++;
            if (cont % 2 == 0)
                lbl7.BackColor = Color.Green;
            else
                lbl7.BackColor = Color.Red;

            if ((lbl7.BackColor == lbl8.BackColor && lbl8.BackColor == lbl9.BackColor) ||
               (lbl7.BackColor == lbl4.BackColor && lbl4.BackColor == lbl1.BackColor) ||
               (lbl7.BackColor == lbl5.BackColor && lbl5.BackColor == lbl3.BackColor))
            {
                if (lbl7.BackColor == Color.Green)
                {
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
                else if (lbl7.BackColor == Color.Red)
                {
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                           ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
            }
            
            ja_clicou7 = true;

            ValidaVelha(ref cont);
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            if (ja_clicou8 == true)
                return;

            cont++;
            if (cont % 2 == 0)
                lbl8.BackColor = Color.Green;
            else
                lbl8.BackColor = Color.Red;

            if ((lbl8.BackColor == lbl9.BackColor && lbl8.BackColor == lbl7.BackColor) ||
               (lbl8.BackColor == lbl5.BackColor && lbl5.BackColor == lbl2.BackColor))
            {
                if (lbl8.BackColor == Color.Green)
                {
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
                else if (lbl8.BackColor == Color.Red)
                {
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
            }

            ja_clicou8 = true;

            ValidaVelha(ref cont);
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            if (ja_clicou9 == true)
                return;

            cont++;
            if (cont % 2 == 0)
                lbl9.BackColor = Color.Green;
            else
                lbl9.BackColor = Color.Red;

            if ((lbl9.BackColor == lbl8.BackColor && lbl8.BackColor == lbl7.BackColor) ||
               (lbl9.BackColor == lbl6.BackColor && lbl6.BackColor == lbl3.BackColor) ||
               (lbl9.BackColor == lbl5.BackColor && lbl5.BackColor == lbl1.BackColor))
            {
                if (lbl9.BackColor == Color.Green)
                {
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
                else if (lbl9.BackColor == Color.Red)
                {
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
                    Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
                    return;
                }
            }

            ja_clicou9 = true;

            ValidaVelha(ref cont);
        }

        private void Reinicia_Jogo(ref int cont,ref bool ja_clicou1, ref bool ja_clicou2,
                                   ref bool ja_clicou3, ref bool ja_clicou4, ref bool ja_clicou5, 
                                   ref bool ja_clicou6, ref bool ja_clicou7, ref bool ja_clicou8, 
                                   ref bool ja_clicou9)
        {
            cont = 0;
            ja_clicou1 = false;
            ja_clicou2 = false;
            ja_clicou3 = false;
            ja_clicou4 = false;
            ja_clicou5 = false;
            ja_clicou6 = false;
            ja_clicou7 = false;
            ja_clicou8 = false;
            ja_clicou9 = false;

            lbl1.BackColor = Color.White;
            lbl2.BackColor = Color.White;
            lbl3.BackColor = Color.White;
            lbl4.BackColor = Color.White;
            lbl5.BackColor = Color.White;
            lbl6.BackColor = Color.White;
            lbl7.BackColor = Color.White;
            lbl8.BackColor = Color.White;
            lbl9.BackColor = Color.White;
        }

        private void ValidaVelha(ref int cont)
        {
            if (cont == 9)
            {
                MessageBox.Show("DEU VELHA!");
                Reinicia_Jogo(ref cont, ref ja_clicou1, ref ja_clicou2, ref ja_clicou3, ref ja_clicou4,
                          ref ja_clicou5, ref ja_clicou6, ref ja_clicou7, ref ja_clicou8, ref ja_clicou9);
            }
        }

    }
}
