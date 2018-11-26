using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais
{
    public abstract class Ave : Animal, IOviparo
    {

        private bool rapina;

        public bool Rapina
        {
            get { return rapina; }
            set { rapina = value; }
        }

        private bool aquatico;

        public bool Aquatico
        {
            get { return aquatico; }
            set { aquatico = value; }
        }

        public abstract string Ciscar();
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
