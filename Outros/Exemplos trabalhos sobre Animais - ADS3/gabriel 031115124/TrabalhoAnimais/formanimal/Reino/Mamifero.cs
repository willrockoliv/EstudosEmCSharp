using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais
{
    public abstract class Mamifero : Animal
    {

        private int qtdMama;

        public int QtdMama
        {
            get { return qtdMama; }
            set { qtdMama = value; }
        }

        private bool pelos;

        public bool Pelos
        {
            get { return pelos; }
            set { pelos = value; }
        }

        private bool aquatico;

        public bool Aquatico
        {
            get { return aquatico; }
            set { aquatico = value; }
        }

        private string cordopelo;

        public string Cordopelo
        {
            get { return cordopelo; }
            set { cordopelo = value; }
        }

        public abstract string Amamentar();
        public abstract string Parir();
       
        
    }
}
