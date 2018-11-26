using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Carro
    {
        public event EventHandler onCarroAcelerou;
        
        private int velocidadeAtual = 0;
        public int VelocidadeAtual
        {
            get { return velocidadeAtual; }         
        }

        public void Acelerar()
        {
            velocidadeAtual+=10;

            if (onCarroAcelerou != null)
                onCarroAcelerou(this, new EventArgs());
        }



    }
}
