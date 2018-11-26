using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaAluno
{
    public partial class Form1 : Form
    {
        List<object> lista = new List<object>();

        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlunoEM a = new AlunoEM();
            PreencheAtributosAluno(a);
            a.N2 = Convert.ToDouble(txtN2_EM.Text);
            a.N3 = Convert.ToDouble(txtN3_EM.Text);
            a.Responsavel = txtResponsavel.Text;

            lista.Add(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlunoFTT a = new AlunoFTT();
            PreencheAtributosAluno(a);
            a.N2 = Convert.ToDouble(txtN2_FTT.Text);
            a.Estagio = Convert.ToInt32(txtHorasEstagio.Text);

            lista.Add(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlunoPos a = new AlunoPos();
            /*a.RA = txtRA.Text;
            a.Nome = txtNomeAluno.Text;
            a.Frequencia = Convert.ToInt32(txtFreq.Text);
            a.N1 = Convert.ToDouble(txtN1.Text); */
            PreencheAtributosAluno(a);
            a.Graduacao = txtGraduacao.Text;

            lista.Add(a);
        }


        private void PreencheAtributosAluno(Aluno a)
        {
            a.RA = txtRA.Text;
            a.Nome = txtNomeAluno.Text;
            a.Frequencia = Convert.ToInt32(txtFreq.Text);
            a.N1 = Convert.ToDouble(txtN1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Aluno a in lista)
            {
                txtListagem.Text += Environment.NewLine +
                   "\t RA:  " + a.RA +
                   "\t Nome: " + a.Nome +
                   "\t Frequência: " + a.Frequencia +
                   "\t N1: " + a.N1.ToString("0.0") +
                   "\t Média: " + a.CalculaMedia().ToString("0.0") +
                   "\t Aprovado: " + a.VerificaAprovacao();

                if (a is AlunoEM)
                {
                    txtListagem.Text +=
                        "\t N2: " + (a as AlunoEM).N2.ToString("0.0") +
                        "\t N3: " + ((AlunoEM)a).N3.ToString("0.0") +
                        "\t Resp: " + (a as AlunoEM).Responsavel;
                }

                if (a is AlunoFTT)
                {
                    txtListagem.Text +=
                        "\t N2: " + (a as AlunoFTT).N2.ToString("0.0") +
                        "\t Estagio: " + (a as AlunoFTT).Estagio;
                }

                if (a is AlunoPos)
                {
                    txtListagem.Text +=
                        "\t Graduação: " + (a as AlunoPos).Graduacao;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Aluno a in lista)            
                txtListagem.Text += Environment.NewLine +
                    a.ToString();            
        }
    }
}
