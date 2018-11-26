using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_velha
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Variável que representa a jogada atual
        /// </summary>
        private string jogadaAtual = "X";

        public Form1()
        {
            InitializeComponent();
            MontaTabuleiro();
            Width =  190;
            Height = 210;
        }

        private void MontaTabuleiro()
        {
            tabuleiro.Columns.Clear();


            tabuleiro.Columns.Add("", "");
            tabuleiro.Columns.Add("", "");
            tabuleiro.Columns.Add("", "");
            tabuleiro.Rows.Add(2);
            foreach (DataGridViewRow row in tabuleiro.Rows)
            {
                row.Height = 50;
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn col in tabuleiro.Columns)
                col.Width = 50;

            foreach (DataGridViewRow linha in tabuleiro.Rows)
                linha.Cells[0].Value = linha.Cells[1].Value = linha.Cells[2].Value = "";


            tabuleiro.ScrollBars = ScrollBars.None;
            tabuleiro.Width = 150;
            tabuleiro.Height = 150;
            tabuleiro.AllowUserToResizeColumns = false;
            tabuleiro.AllowUserToResizeRows = false;
            tabuleiro.SelectionMode = DataGridViewSelectionMode.CellSelect;
            tabuleiro.ReadOnly = true;
            tabuleiro.MultiSelect = false;
        }

        
        private void tabuleiro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabuleiro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                return;

            tabuleiro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = jogadaAtual;

            VerificaSeHouveGanhador();

            if (jogadaAtual == "X")
                jogadaAtual = "0";
            else
                jogadaAtual = "X";
        }

        private void VerificaSeHouveGanhador()
        {
            string soma;
            //linhas
            foreach (DataGridViewRow linha in tabuleiro.Rows)
            {
                soma = linha.Cells[0].Value.ToString() +
                       linha.Cells[1].Value.ToString() +
                       linha.Cells[2].Value.ToString();
                if (HaGanhador(soma))
                    return;
            }

            //colunas
            for (int coluna = 0; coluna <= 2; coluna++)
            {
                soma = "";
                foreach (DataGridViewRow linha in tabuleiro.Rows)                
                    soma += linha.Cells[coluna].Value.ToString();                    
                
                if (HaGanhador(soma))
                    return;
            }


            //diagonais
            soma = tabuleiro.Rows[0].Cells[0].Value.ToString() +
                   tabuleiro.Rows[1].Cells[1].Value.ToString() +
                   tabuleiro.Rows[2].Cells[2].Value.ToString();
            if (HaGanhador(soma))
                return;


            //diagonais
            soma = tabuleiro.Rows[0].Cells[2].Value.ToString() +
                   tabuleiro.Rows[1].Cells[1].Value.ToString() +
                   tabuleiro.Rows[2].Cells[0].Value.ToString();

            if (HaGanhador(soma))
                return;

            //ver se deu Velha...
            bool tudoPreenchido = true;
            foreach (DataGridViewRow linha in tabuleiro.Rows)
                if (linha.Cells[0].Value.ToString() == "" ||
                    linha.Cells[1].Value.ToString() == "" ||
                    linha.Cells[2].Value.ToString() == "")
                {
                    tudoPreenchido = false;
                    break;
                }

            if (tudoPreenchido)
            {
                MessageBox.Show("Deu velha!");
                MontaTabuleiro();
            }

        }


        private bool HaGanhador(string soma)
        {
            if (soma == "XXX" || soma == "000")
            {
                MostraGanhador();
                return true;
            }
            return false;
        }


        private void MostraGanhador()
        {
            MessageBox.Show("O jogador da opção: [" + jogadaAtual + "] ganhou");
            MontaTabuleiro();
        }
    }
}
