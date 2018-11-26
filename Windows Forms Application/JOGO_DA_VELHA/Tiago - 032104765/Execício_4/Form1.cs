using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Execício_4
{
    
    public partial class Form1 : Form
    {
        string bola = @"bola.bmp";
        string x = @"x.bmp";
        static char a1 = '0', a2 = '0', a3 = '0', a4 = '0', a5 = '0', a6 = '0', a7 = '0', a8 = '0', a9 = '0';
        
        static int cont = 0;

        static void verifica123()
        {
            if (a1 == '1' && a2 == '1' && a3 == '1')
            {
                MessageBox.Show("Fim do Jogo! Bola ganhou!");
                Environment.Exit(1);
            }
            else if (a1 == '2' && a2 == '2' && a3 == '2')
            {
                MessageBox.Show("Fim do Jogo! X ganhou!");
                Environment.Exit(1);
            }
            else if (cont >= 9)
            {
                MessageBox.Show("Fim do Jogo! Ninguém ganhou!");
                Environment.Exit(1);
            }

        }

        static void verifica456()
        {
            if (a4 == '1' && a5 == '1' && a6 == '1')
            {
                MessageBox.Show("Fim do Jogo! Bola ganhou!");
                Environment.Exit(1);
            }
            else if (a4 == '2' && a5 == '2' && a6 == '2')
            {
                MessageBox.Show("Fim do Jogo! X ganhou!");
                Environment.Exit(1);
            }
            else if (cont >= 9)
            {
                MessageBox.Show("Fim do Jogo! Ninguém ganhou!");
                Environment.Exit(1);
            }

        }

        static void verifica789()
        {
            if (a7 == '1' && a8 == '1' && a9 == '1')
            {
                MessageBox.Show("Fim do Jogo! Bola ganhou!");
                Environment.Exit(1);
            }
            else if (a7 == '2' && a8 == '2' && a9 == '2')
            {
                MessageBox.Show("Fim do Jogo! X ganhou!");
                Environment.Exit(1);
            }
            else if (cont >= 9)
            {
                MessageBox.Show("Fim do Jogo! Ninguém ganhou!");
                Environment.Exit(1);
            }

        }

        static void verifica147()
        {
            if (a1 == '1' && a4 == '1' && a7 == '1')
            {
                MessageBox.Show("Fim do Jogo! Bola ganhou!");
                Environment.Exit(1);
            }
            else if (a1 == '2' && a4 == '2' && a7 == '2')
            {
                MessageBox.Show("Fim do Jogo! X ganhou!");
                Environment.Exit(1);
            }
            else if (cont >= 9)
            {
                MessageBox.Show("Fim do Jogo! Ninguém ganhou!");
                Environment.Exit(1);
            }

        }

        static void verifica258()
        {
            if (a2 == '1' && a5 == '1' && a8 == '1')
            {
                MessageBox.Show("Fim do Jogo! Bola ganhou!");
                Environment.Exit(1);
            }
            else if (a2 == '2' && a5 == '2' && a8 == '2')
            {
                MessageBox.Show("Fim do Jogo! X ganhou!");
                Environment.Exit(1);
            }
            else if (cont >= 9)
            {
                MessageBox.Show("Fim do Jogo! Ninguém ganhou!");
                Environment.Exit(1);
            }

        }

        static void verifica369()
        {
            if (a3 == '1' && a6 == '1' && a9 == '1')
            {
                MessageBox.Show("Fim do Jogo! Bola ganhou!");
                Environment.Exit(1);
            }
            else if (a3 == '2' && a6 == '2' && a9 == '2')
            {
                MessageBox.Show("Fim do Jogo! X ganhou!");
                Environment.Exit(1);
            }
            else if (cont >= 9)
            {
                MessageBox.Show("Fim do Jogo! Ninguém ganhou!");
                Environment.Exit(1);
            }

        }

        static void verifica159()
        {
            if (a1 == '1' && a5 == '1' && a9 == '1')
            {
                MessageBox.Show("Fim do Jogo! Bola ganhou!");
                Environment.Exit(1);
            }
            else if (a1 == '2' && a5 == '2' && a9 == '2')
            {
                MessageBox.Show("Fim do Jogo! X ganhou!");
                Environment.Exit(1);
            }
            else if (cont >= 9)
            {
                MessageBox.Show("Fim do Jogo! Ninguém ganhou!");
                Environment.Exit(1);
            }

        }

        static void verifica357()
        {
            if (a7 == '1' && a5 == '1' && a3 == '1')
            {
                MessageBox.Show("Fim do Jogo! Bola ganhou!");
                Environment.Exit(1);
            }
            else if (a7 == '2' && a5 == '2' && a3 == '2')
            {
                MessageBox.Show("Fim do Jogo! X ganhou!");
                Environment.Exit(1);
            }
            else if (cont >= 9)
            {
                MessageBox.Show("Fim do Jogo! Ninguém ganhou!");
                Environment.Exit(1);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pctb1_Click(object sender, EventArgs e)
        {
            if (pctb10.ImageLocation == bola)
            {
                pctb1.ImageLocation = bola;
                pctb10.ImageLocation = x;
                a1 = '1';
            }
            else
            {
                pctb1.ImageLocation = x;
                pctb10.ImageLocation = bola;
                a1 = '2';
            }
            cont++;
            verifica123();
            verifica159();
            verifica147();
            pctb1.Enabled = false;
        }

        private void pctb2_Click(object sender, EventArgs e)
        {
            if (pctb10.ImageLocation == bola)
            {
                pctb2.ImageLocation = bola;
                pctb10.ImageLocation = x;
                a2 = '1';
            }
            else
            {
                pctb2.ImageLocation = x;
                pctb10.ImageLocation = bola;
                a2 = '2';
            }
            cont++;
            verifica123();
            verifica258();
            pctb2.Enabled = false;
        }

        private void pctb3_Click(object sender, EventArgs e)
        {
            if (pctb10.ImageLocation == bola)
            {
                pctb3.ImageLocation = bola;
                pctb10.ImageLocation = x;
                a3 = '1';
            }
            else
            {
                pctb3.ImageLocation = x;
                pctb10.ImageLocation = bola;
                a3 = '2';
            }
            cont++;
            verifica123();
            verifica357();
            verifica369();
            pctb3.Enabled = false;
        }

        private void pctb4_Click(object sender, EventArgs e)
        {
            if (pctb10.ImageLocation == bola)
            {
                pctb4.ImageLocation = bola;
                pctb10.ImageLocation = x;
                a4 = '1';
            }
            else
            {
                pctb4.ImageLocation = x;
                pctb10.ImageLocation = bola;
                a4 = '2';
            }
            cont++;
            verifica147();
            verifica456();
            pctb4.Enabled = false;
        }

        private void pctb5_Click(object sender, EventArgs e)
        {
            if (pctb10.ImageLocation == bola)
            {
                pctb5.ImageLocation = bola;
                pctb10.ImageLocation = x;
                a5 = '1';
            }
            else
            {
                pctb5.ImageLocation = x;
                pctb10.ImageLocation = bola;
                a5 = '2';
            }
            cont++;
            verifica159();
            verifica258();
            verifica357();
            verifica456();
            pctb5.Enabled = false;
        }

        private void pctb6_Click(object sender, EventArgs e)
        {
            if (pctb10.ImageLocation == bola)
            {
                pctb6.ImageLocation = bola;
                pctb10.ImageLocation = x;
                a6 = '1';
            }
            else
            {
                pctb6.ImageLocation = x;
                pctb10.ImageLocation = bola;
                a6 = '2';
            }
            cont++;
            verifica456();
            verifica369();
            pctb6.Enabled = false;
        }

        private void pctb7_Click(object sender, EventArgs e)
        {
            if (pctb10.ImageLocation == bola)
            {
                pctb7.ImageLocation = bola;
                pctb10.ImageLocation = x;
                a7 = '1';
            }
            else
            {
                pctb7.ImageLocation = x;
                pctb10.ImageLocation = bola;
                a7 = '2';
            }
            cont++;
            verifica147();
            verifica357();
            verifica789();
            pctb7.Enabled = false;
        }

        private void pctb8_Click(object sender, EventArgs e)
        {
            if (pctb10.ImageLocation == bola)
            {
                pctb8.ImageLocation = bola;
                pctb10.ImageLocation = x;
                a8 = '1';
            }
            else
            {
                pctb8.ImageLocation = x;
                pctb10.ImageLocation = bola;
                a8 = '2';
            }
            cont++;
            verifica789();
            verifica258();
            pctb8.Enabled = false;
        }

        private void pctb9_Click(object sender, EventArgs e)
        {
            if (pctb10.ImageLocation == bola)
            {
                pctb9.ImageLocation = bola;
                pctb10.ImageLocation = x;
                a9 = '1';
            }
            else
            {
                pctb9.ImageLocation = x;
                pctb10.ImageLocation = bola;
                a9 = '2';
            }
            cont++;
            verifica159();
            verifica369();
            verifica789();
            pctb9.Enabled = false;
        }


    }
}
