using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais
{
    public abstract class Reptil : Animal, IOviparo
    {

        private bool temEscama;

        public bool TemEscama
        {
            get { return temEscama; }
            set { temEscama = value; }
        }

        private bool temCasco;

        public bool TemCasco
        {
            get { return temCasco; }
            set { temCasco = value; }
        }

        public abstract string Botar();
        public abstract string Chocar();        

        private bool possuipenas;
        public bool PossuiPenas
        {
            get
            {
                return possuipenas;
            }
            set
            {
                possuipenas = value;
            }
        }

       
    }
}
