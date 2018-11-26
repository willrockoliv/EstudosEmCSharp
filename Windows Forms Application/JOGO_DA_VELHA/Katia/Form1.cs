using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Jogo_Velha
{
    public partial class Form1 : Form
    {
        int x1, x2, x3, x4, x5, x6, x7, x8, x9, O, O1, O2, O3, O4, O5, O6, O7, O8, O9, MAQ=0, EMP=0, QTD=0, JOG=0;

        public Form1()
        {
            InitializeComponent();
        }

        #region Jogadas
        private void lbl_1_Click(object sender, EventArgs e)
        {
            if ((lbl_1.Text == ""))
            {
                lbl_1.Text = "X";
                x1 = 1;
                Verficar_Jogador();
                QTD = (QTD + 1);
                if ((QTD <= 4))
                {
                    Maquina();
                    Verificar_Maquina();
                }
                else
                {
                    MessageBox.Show("Empate");
                    empate();
                }
            }
            else
            {
                MessageBox.Show("Jogada Irregular", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void lbl_2_Click(object sender, EventArgs e)
        {
            if ((lbl_2.Text == ""))
            {
                lbl_2.Text = "X";
                x2 = 1;
                Verficar_Jogador();
                QTD = (QTD + 1);
                if ((QTD <= 4))
                {
                    Maquina();
                    Verificar_Maquina();
                }
                else
                {
                    MessageBox.Show("Empate");
                    empate();
                }
            }
            else
            {
                MessageBox.Show("Jogada Irregular", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void lbl_3_Click(object sender, EventArgs e)
        {
            if ((lbl_3.Text == ""))
            {
                lbl_3.Text = "X";
                x3 = 1;
                Verficar_Jogador();
                QTD = (QTD + 1);
                if ((QTD <= 4))
                {
                    Maquina();
                    Verificar_Maquina();
                }
                else
                {
                    MessageBox.Show("Empate");
                    empate();
                }
            }
            else
            {
                MessageBox.Show("Jogada Irregular", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void lbl_4_Click(object sender, EventArgs e)
        {
            if ((lbl_4.Text == ""))
            {
                lbl_4.Text = "X";
                x4 = 1;
                Verficar_Jogador();
                QTD = (QTD + 1);
                if ((QTD <= 4))
                {
                    Maquina();
                    Verificar_Maquina();
                }
                else
                {
                    MessageBox.Show("Empate");
                    empate();
                }
            }
            else
            {
                MessageBox.Show("Jogada Irregular", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void lbl_5_Click(object sender, EventArgs e)
        {
            if ((lbl_5.Text == ""))
            {
                lbl_5.Text = "X";
                x5 = 1;
                Verficar_Jogador();
                QTD = (QTD + 1);
                if ((QTD <= 4))
                {
                    Maquina();
                    Verificar_Maquina();
                }
                else
                {
                    MessageBox.Show("Empate");
                    empate();
                }
            }
            else
            {
                MessageBox.Show("Jogada Irregular", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void lbl_6_Click(object sender, EventArgs e)
        {

            if ((lbl_6.Text == ""))
            {
                lbl_6.Text = "X";
                x6 = 1;
                Verficar_Jogador();
                QTD = (QTD + 1);
                if ((QTD <= 4))
                {
                    Maquina();
                    Verificar_Maquina();
                }
                else
                {
                    MessageBox.Show("Empate");
                    empate();
                }
            }
            else
            {
                MessageBox.Show("Jogada Irregular", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void lbl_7_Click(object sender, EventArgs e)
        {
            if ((lbl_7.Text == ""))
            {
                lbl_7.Text = "X";
                x7 = 1;
                Verficar_Jogador();
                QTD = (QTD + 1);
                if ((QTD <= 4))
                {
                    Maquina();
                    Verificar_Maquina();
                }
                else
                {
                    MessageBox.Show("Empate");
                    empate();
                }
            }
            else
            {
                MessageBox.Show("Jogada Irregular", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void lbl_8_Click(object sender, EventArgs e)
        {
            if ((lbl_8.Text == ""))
            {
                lbl_8.Text = "X";
                x8 = 1;
                Verficar_Jogador();
                QTD = (QTD + 1);
                if ((QTD <= 4))
                {
                    Maquina();
                    Verificar_Maquina();
                }
                else
                {
                    MessageBox.Show("Empate");
                    empate();
                }
            }
            else
            {
                MessageBox.Show("Jogada Irregular", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void lbl_9_Click(object sender, EventArgs e)
        {
            if ((lbl_9.Text == ""))
            {
                lbl_9.Text = "X";
                x9 = 1;
                Verficar_Jogador();
                QTD = (QTD + 1);
                if ((QTD <= 4))
                {
                    Maquina();
                    Verificar_Maquina();
                }
                else
                {
                    MessageBox.Show("Empate");
                    empate();
                }
            }
            else
            {
                MessageBox.Show("Jogada Irregular", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        # endregion
        #region Limpar
        private void Limpar()
        {
            O1 = 0;
            O2 = 0;
            O3 = 0;
            O4 = 0;
            O5 = 0;
            O6 = 0;
            O7 = 0;
            O8 = 0;
            O9 = 0;
            x1 = 0;
            x2 = 0;
            x3 = 0;
            x4 = 0;
            x5 = 0;
            x6 = 0;
            x7 = 0;
            x8 = 0;
            x9 = 0;
            QTD = 0;
        }
        #endregion
        #region Empate
        private void empate()
        {
            EMP = (EMP + 1);
            lblEmpate.Text = EMP.ToString();
            lbl_1.Text = "";
            lbl_2.Text = "";
            lbl_3.Text = "";
            lbl_4.Text = "";
            lbl_5.Text = "";
            lbl_6.Text = "";
            lbl_7.Text = "";
            lbl_8.Text = "";
            lbl_9.Text = "";
            Limpar();
        }
        # endregion
        #region Verificar_Maquina
        private void Verificar_Maquina()
        {
            if (((O1 + O2 + O3) == 3) || ((O4 + O5 + O6) == 3) || ((O1 + O4 + O7) == 3)
              || ((O2 + O5 + O8) == 3) || ((O3 + O6 + O9) == 3) || ((O7 + O8 + O9) == 3)
              || ((x1 + x5 + x9) == 3) || ((x3 + x5 + x7) == 3))
            {
                MessageBox.Show("GAME OVER!!!", "A Máquina Ganhou!!!!");
                MAQ = (MAQ + 1);
                lblMaquina.Text = MAQ.ToString();
                lbl_1.Text = "";
                lbl_2.Text = "";
                lbl_3.Text = "";
                lbl_4.Text = "";
                lbl_5.Text = "";
                lbl_6.Text = "";
                lbl_7.Text = "";
                lbl_8.Text = "";
                lbl_9.Text = "";
                Limpar();
            }
        }


        #endregion
        #region  Jogadas_Maquina
        private void Maquina()
        {
            int A=0;
            Random rnd = new Random ();
            while (A == 0)
            {
              O =  rnd.Next(9);
                if ((O == 1) && (lbl_1.Text == ""))
                {
                    lbl_1.Text = "O";
                    A = 1;
                    O1 = 1;
                }
                if ((O == 2) && (lbl_2.Text == ""))              
                {
                    lbl_2.Text = "O";
                    A = 1;
                    O2 = 1;
                }
                if ((O == 3) && (lbl_3.Text == ""))
                {
                    lbl_3.Text = "O";
                    A = 1;
                    O3 = 1;
                }
                if ((O == 4) && (lbl_4.Text == ""))
                {
                    lbl_4.Text = "O";
                    A = 1;
                    O4 = 1;
                }
                if ((O == 5) && (lbl_5.Text == ""))
                {
                    lbl_5.Text = "O";
                    A = 1;
                    O5 = 1;
                }
                if ((O == 6) && (lbl_6.Text == ""))
                {
                    lbl_6.Text = "O";
                    A = 1;
                    O6 = 1;
                }
                if ((O == 7) && (lbl_7.Text == ""))
                {
                    lbl_7.Text = "O";
                    A = 1;
                    O7 = 1;
                }
                if (((O == 8) && (lbl_8.Text == "")))
                {
                    lbl_8.Text = "O";
                    A = 1;
                    O8 = 1;
                }
                if ((O == 9) && (lbl_9.Text == ""))
                {
                    lbl_9.Text = "O";
                    A = 1;
                    O9 = 1;
                }
            }
        }
        # endregion
        #region Verificar Jogador
        private void Verficar_Jogador()
        {
            if (((x1 + x2 + x3) == 3) || ((x4 + x5 + x6) == 3) || ((x1 + x4 + x7) == 3)
              || ((x2 + x5 + x8) == 3) || ((x3 + x6 + x9) == 3) || ((x7 + x8 + x9) == 3)
              || ((x1 + x5 + x9) == 3) || ((x3 + x5 + x7) == 3))
            {
                MessageBox.Show("Você Ganhou", "Ótimo Desempenho!!!!");
                JOG = (JOG + 1);
                lblJogador.Text = JOG.ToString();
                lbl_1.Text = "";
                lbl_2.Text = "";
                lbl_3.Text = "";
                lbl_4.Text = "";
                lbl_5.Text = "";
                lbl_6.Text = "";
                lbl_7.Text = "";
                lbl_8.Text = "";
                lbl_9.Text = "";
                Limpar();
            }
        }
        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_7_DoubleClick(object sender, EventArgs e)
        {
            
        }


    }
}

