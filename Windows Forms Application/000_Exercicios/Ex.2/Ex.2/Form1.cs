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
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                else if (lbl1.BackColor == Color.Red)
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
            }

            ja_clicou1 = true;
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
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                else if (lbl2.BackColor == Color.Red)
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
            }

            ja_clicou2 = true;
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
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                else if (lbl3.BackColor == Color.Red)
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
            }

            ja_clicou3 = true;
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
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                else if (lbl4.BackColor == Color.Red)
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
            }

            ja_clicou4 = true;
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
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                else if (lbl5.BackColor == Color.Red)
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
            }

            ja_clicou5 = true;
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
                    MessageBox.Show("PARABÉNS O VERDE GANHOU");
                else if (lbl6.BackColor == Color.Red)
                    MessageBox.Show("PARABÉNS O VERMELHO GANHOU");
            }

            ja_clicou6 = true;
        }

        private void lbl7_Click(object sender, EventArgs e)
        {

        }
    }
}
