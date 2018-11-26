using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste2
{
    public partial class frRecordes : Form
    {
        /// <summary>
        /// Struct que recebera as informações que serão exibidas na tela
        /// </summary>
        struct Recorde
        {
            public string nome;
            public int pontos;
        }

        string[] arquivo;
        Recorde[] posicaoRecorde = new Recorde[10];

        /// <summary>
        /// Este método organiza por ordem decrescente as 10 maiores pontuações
        /// </summary>
        /// <param name="posicaoRecorde">Vetor que receberá as 10 maiores pontuações</param>
        /// <param name="pontos">vetor do Struct Recordes com as informações do arquivo</param>
        static void OrdenaRecordes(ref Recorde[] posicaoRecorde, Recorde[] pontos)
        {
            posicaoRecorde[0].nome = pontos[0].nome;
            posicaoRecorde[0].pontos = pontos[0].pontos;
            for (int i = 0; i < pontos.Length; i++)
            {
                if (posicaoRecorde[9].pontos != 0)
                    break;
                else
                {
                    int posicaoMaior = 0;
                    for (int j = 0; j < pontos.Length; j++)
                    {
                        if (posicaoRecorde[i].pontos < pontos[j].pontos)
                        {
                            posicaoRecorde[i].nome = pontos[j].nome;
                            posicaoRecorde[i].pontos = pontos[j].pontos;
                            posicaoMaior = j;
                        }
                    }
                    pontos[posicaoMaior].pontos = 0; //exclui a maior da lista para não ser verificada novamente
                }
            }
        }

        public frRecordes()
        {
            InitializeComponent();

            #region Processamento das Pontuações

            arquivo = File.ReadAllLines("recordes.txt", Encoding.Default);
            Recorde[] pontos = new Recorde[arquivo.Length];
            posicaoRecorde = new Recorde[10];

            if (arquivo.Length == 0)
                return;

            //separa pontos e nomes do arquivo
            for (int i = 0; i < arquivo.Length; i++)
            {
                string[] temp = arquivo[i].Split('|');
                pontos[i].nome = temp[0].Trim();
                pontos[i].pontos = Convert.ToInt32(temp[1].Trim());
            }
            #endregion

            OrdenaRecordes(ref posicaoRecorde, pontos);

            #region Exibição das 10 maiores pontuações

            txbRecordesNome1.Text = posicaoRecorde[0].nome;
            txbRecordesNome2.Text = posicaoRecorde[1].nome;
            txbRecordesNome3.Text = posicaoRecorde[2].nome;
            txbRecordesNome4.Text = posicaoRecorde[3].nome;
            txbRecordesNome5.Text = posicaoRecorde[4].nome;
            txbRecordesNome6.Text = posicaoRecorde[5].nome;
            txbRecordesNome7.Text = posicaoRecorde[6].nome;
            txbRecordesNome8.Text = posicaoRecorde[7].nome;
            txbRecordesNome9.Text = posicaoRecorde[8].nome;
            txbRecordesNome10.Text = posicaoRecorde[9].nome;
            txbRecordesPontos1.Text = Convert.ToString(posicaoRecorde[0].pontos);
            txbRecordesPontos2.Text = Convert.ToString(posicaoRecorde[1].pontos);
            txbRecordesPontos3.Text = Convert.ToString(posicaoRecorde[2].pontos);
            txbRecordesPontos4.Text = Convert.ToString(posicaoRecorde[3].pontos);
            txbRecordesPontos5.Text = Convert.ToString(posicaoRecorde[4].pontos);
            txbRecordesPontos6.Text = Convert.ToString(posicaoRecorde[5].pontos);
            txbRecordesPontos7.Text = Convert.ToString(posicaoRecorde[6].pontos);
            txbRecordesPontos8.Text = Convert.ToString(posicaoRecorde[7].pontos);
            txbRecordesPontos9.Text = Convert.ToString(posicaoRecorde[8].pontos);
            txbRecordesPontos10.Text = Convert.ToString(posicaoRecorde[9].pontos);

            #endregion
        }

        /// <summary>
        /// Evento para fechar a tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSairRecordes_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void frRecordes_Load_1(object sender, EventArgs e)
        {

        }
    }
}
