using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formanimal
{   
        class Nodo
        {
            object dado;

            public object Dado
            {
                get { return dado; }
                set { dado = value; }
            }
            Nodo proximo;

            public Nodo Proximo
            {
                get { return proximo; }
                set { proximo = value; }
            }


            /// <summary>
            /// Construtor parametrizado
            /// </summary>
            /// <param name="dado"></param>
            /// <param name="proximo"></param>
            public Nodo(int dado, Nodo proximo)
            {
                this.dado = dado;
                this.proximo = proximo;
            }

            /// <summary>
            /// construtor sem parâmetros
            /// </summary>
            public Nodo()
            {
                dado = 0;
                proximo = null;
            }



        }
    }

