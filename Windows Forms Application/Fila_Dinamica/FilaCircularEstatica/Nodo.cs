using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilaCircularEstatica
{
    class Nodo
    {
        /*
        string valor = "";

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        */

        public string Valor { get; set; }
        

        Nodo proximo = null;

        public Nodo Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
    }
}
