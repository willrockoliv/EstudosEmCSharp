using MediaPlayer.EstruturaDeDados.Fila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.EstruturaDeDados.Ordenacao
{
    public class Ordenacao
    {
        /// <summary>
        /// Ordena os cadastros em uma Fila por ordem alfabética
        /// </summary>
        /// <param name="cadastros">vetor com as linhas de cadastro.txt</param>
        /// <returns>FilaDinamica ordenada alfabéticamente</returns>
        public static FilaDinamica OrdenaFilaPorDescricao(string[] cadastros)
        {
            //Ordena os cadastros em ListaOrdenacao
            ListaDinamica ListaOrdenadacao = new ListaDinamica();
            foreach (string linha in cadastros)
            {
                //Consulta a midia do arquivo
                string[] temp = linha.Split('|');
                int id = Convert.ToInt32(temp[0].Replace("<Id>", ""));
                Midia Midia = Midia.Consultar(id);

                //Lista
                if (ListaOrdenadacao.Tamanho == 0)
                    ListaOrdenadacao.InserirNoInicio(Midia);
                else
                {
                    //Ordena a midia em ListaOrdenacao
                    for (int i = 1; i <= ListaOrdenadacao.Tamanho; i++)
                    {
                        if (Midia.Descricao.CompareTo(ListaOrdenadacao.Pesquisa(i - 1).Descricao) == -1)
                        {
                            ListaOrdenadacao.InserirNaPosicao(Midia, i);
                            break;
                        }
                        else if (Midia.Descricao.CompareTo(ListaOrdenadacao.Pesquisa(i - 1).Descricao) == 0)
                        {
                            ListaOrdenadacao.InserirNaPosicao(Midia, i + 1);
                            break;
                        }
                        else if (Midia.Descricao.CompareTo(ListaOrdenadacao.Pesquisa(i - 1).Descricao) == 1 && ListaOrdenadacao.Tamanho == i)
                        {
                            ListaOrdenadacao.InserirNoFim(Midia);
                            break;
                        }
                    }
                }
            }

            //transfere da ListaOrdenacao para a FilaMidiaPorDescricao
            FilaDinamica FilaMidiaPorDescricao = new FilaDinamica();
            int qtde = ListaOrdenadacao.Tamanho;
            for (int i = 0; i < qtde; i++)
            {
                FilaMidiaPorDescricao.Enfileirar(ListaOrdenadacao.Pesquisa(i));
            }

            return FilaMidiaPorDescricao;
        }
    }
}
