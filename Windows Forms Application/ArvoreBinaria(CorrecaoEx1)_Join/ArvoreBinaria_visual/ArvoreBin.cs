﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ArvoreBinaria_visual
{
    class ArvoreBin
    {
        private Nodo raiz = null; // raiz da árvore
        private int qtdeNodosInternos = 0; // qtde de nos internos
        private List<int> resultado  ; // utilizada na listagem dos nodos
        private int maiorProfundidadeEncontrada = 0;
        private int qtdeNodosExternos = 0;


        /// <summary>
        /// Returna a qtde de nós internos
        /// </summary>
        /// <returns></returns>
        public int QtdeNodosInternos() // devolve a qtde de nós internos
        {
            return qtdeNodosInternos;
        }
        /// <summary>
        /// Insere um valor na árvore. Não aceita valores repetidos!!!
        /// </summary>
        /// <param name="valor">valor a ser inserido</param>
        public void Insere(int valor) // insere um valor int
        {
            Nodo no_aux;
            if (qtdeNodosInternos == 0) // árvore vazia!
            {
                // árvore vazia, devemos criar o primeiro Nodo, que será a raiz
                no_aux = new Nodo();
                raiz = no_aux;
                qtdeNodosExternos += 2;
            }
            else
            {
                qtdeNodosExternos++;
                // localiza onde deve ser inserido o novo nó.
                no_aux = PesquisaValor(valor, raiz);
                if (no_aux.EhInterno())
                {
                    throw new Exception("Este valor já existe na árvore!!!!");
                }
            }


            // este era um Nodo externo e portanto não tinha filhos.
            // Agora ele passará a ser interno, portanto devemos criar outros 2
            // nodos externos (filhos) para ele.
            no_aux.SetValor(valor);
            no_aux.SetNoEsquerda(Nodo.CriaNoExterno(no_aux));
            no_aux.SetNoDireita(Nodo.CriaNoExterno(no_aux));
            qtdeNodosInternos++;
        }

        public int TotalNodosExternos()
        {
            return qtdeNodosExternos;
        }

        private void PercursoPosFixado(Nodo no)
        {
            if (no.EhExterno())
                return;
            PercursoPosFixado(no.GetNoEsquerda());
            PercursoPosFixado(no.GetNoDireita());
            resultado.Add(Convert.ToInt32(no.GetValor()));
        }

        /// <summary>
        /// Devolve um string com os elementos da árvore, em ordem crescente
        /// </summary>
        /// <returns></returns>
        public List<int> ListagemPosFixada()
        {
            resultado = new List<int>();
            if (qtdeNodosInternos != 0)
                PercursoPosFixado(raiz);
            return resultado;
        }

        private void PercursoPreFixado(Nodo no)
        {
            if (no.EhExterno())
                return;
            resultado.Add(Convert.ToInt32(no.GetValor()));
            PercursoPreFixado(no.GetNoEsquerda());
            PercursoPreFixado(no.GetNoDireita());
        }


        /// <summary>
        /// Devolve um string com os elementos da árvore, em ordem crescente
        /// </summary>
        /// <returns></returns>
        public List<int> ListagemPreFixada()
        {
            resultado = new List<int>();
            if (qtdeNodosInternos != 0)
                PercursoPreFixado(raiz);
            return resultado;
        }


        private void PercursoInterfixado(Nodo no)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixado(no.GetNoEsquerda());
            resultado.Add(Convert.ToInt32(no.GetValor()));
            PercursoInterfixado(no.GetNoDireita());
        }
        /// <summary>
        /// Devolve um string com os elementos da árvore, em ordem crescente
        /// </summary>
        /// <returns></returns>
        public List<int> ListagemEmOrdem()
        {
            resultado = new List<int>();
            if (qtdeNodosInternos != 0)
                PercursoInterfixado(raiz);
            return resultado;
        }
        /// <summary>
        /// Pesquisa um nodo na árvore e devolve o nodo. Caso não encontre, devolve o nodo
        /// externo onde a pesquisa parou.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="no"></param>
        /// <returns></returns>
        private Nodo PesquisaValor(int valor, Nodo no)
        {
            if (no == null)
                return null;
            else if (no.EhExterno())
                return no; // não achou!
            else if (no.GetValor() == valor)

                return no;
            else if (valor > no.GetValor())
                return PesquisaValor(valor, no.GetNoDireita());
            else
                return PesquisaValor(valor, no.GetNoEsquerda());
        }

        /// <summary>
        /// Remove um valor da árvore
        /// </summary>
        /// <param name="valor"></param>
        public void Remove(int valor)
        {
            //primeiro, procuramos o nodo que tem o valor:
            Nodo noQueSeraApagado = PesquisaValor(valor, raiz);

            if (noQueSeraApagado == null || noQueSeraApagado.EhExterno())
                throw new Exception("Valor não existe na árvore");
            else
            {
                // um dos filhos é um nó externo
                if (noQueSeraApagado.GetNoEsquerda().EhExterno() ||
                noQueSeraApagado.GetNoDireita().EhExterno())
                {
                    ExcluiComNodoExterno(noQueSeraApagado);
                }
                else
                {
                    ExcluiSemNodoExterno(noQueSeraApagado);
                }
            }

            if (qtdeNodosInternos == 0)
                qtdeNodosExternos = 0;
        }
        /// <summary>
        /// Exclui um nodo que abaixo dele possua, ao menos, 1 nodo exteno.
        /// </summary>
        /// <param name="noQueSeraApagado"></param>
        private void ExcluiComNodoExterno(Nodo noQueSeraApagado)
        {
            qtdeNodosExternos--;
            qtdeNodosInternos--;
            //descobre quem será o nodo que irá ficar no lugar do que foi apagado
            Nodo nodo_substituto;
            if (noQueSeraApagado.GetNoEsquerda().EhInterno())
                nodo_substituto = noQueSeraApagado.GetNoEsquerda();
            else
                nodo_substituto = noQueSeraApagado.GetNoDireita();
            // substitui o apagado pelo novo nodo
            Nodo PaiNodoApagado = noQueSeraApagado.GetNoPai();
            //altera o pai do novo substituto
            nodo_substituto.SetNoPai(PaiNodoApagado);
            //o pai do nodo substituto também deve ter sua referência de filho corrigida.
            //mas primeiro precisamos saber o no apagado er a raiz, que neste caso não tem pai.
            if (PaiNodoApagado != null)
            {
                if (PaiNodoApagado.GetNoDireita() == noQueSeraApagado)
                    PaiNodoApagado.SetNoDireita(nodo_substituto);
                else
                    PaiNodoApagado.SetNoEsquerda(nodo_substituto);
            }
            else
                raiz = nodo_substituto;
        }
        /// <summary>
        /// Pesquisa o próximo nodo Interno seguindo o percurso interfixado.
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        private Nodo PesquisaNodoInternoInterfixado(Nodo no)
        {
            if (no.EhExterno())
                return null;
            Nodo retorno = PesquisaNodoInternoInterfixado(no.GetNoEsquerda());
            if (retorno == null)
                return no;
            else
                return retorno;
        }
        /// <summary>
        /// Exclui um nodo que abaixo dele não há nodos externos.
        /// </summary>
        /// <param name="noQueSeraApagado"></param>
        private void ExcluiSemNodoExterno(Nodo noQueSeraApagado)
        {
            //encontra o nodo substituto
            Nodo NodoSubstituto = PesquisaNodoInternoInterfixado(noQueSeraApagado.GetNoDireita());
            Console.Write("Nodo substituto: " + NodoSubstituto.GetValor());
            //Altera o valor do nodo que será removido pelo valor do nodo substituto
            noQueSeraApagado.SetValor(NodoSubstituto.GetValor());
            //Remove o nodo substituto
            ExcluiComNodoExterno(NodoSubstituto);
        }



        public bool Pesquisa(int numero)
        {
            Nodo nodo = PesquisaValor(numero, raiz);
            return (nodo != null && nodo.EhInterno());
        }


        public int CalculaAlturaArvore()
        {
            maiorProfundidadeEncontrada = 0;
            CalculaAltura(raiz);
            return maiorProfundidadeEncontrada;
        }

        private void CalculaAltura(Nodo no)
        {
            if (no.EhExterno())
            {
                //calcular a profundidade deste nodo externo
                Nodo aux = no;
                int qtde = 0;
                while (aux.GetNoPai() != null)
                {
                    qtde++;
                    aux = aux.GetNoPai();
                }

                if (qtde > maiorProfundidadeEncontrada)
                    maiorProfundidadeEncontrada = qtde;
                return;
            }
            CalculaAltura(no.GetNoEsquerda());
            CalculaAltura(no.GetNoDireita());
        }

    }
}