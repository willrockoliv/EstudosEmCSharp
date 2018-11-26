using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_
{
    class Moto : VeiculoAutomotor
    {
        private int cilindradas;

        public int Cilindradas { get => cilindradas; set => cilindradas = value; }

        public string Empinar()// -> exibe no console "Empinando..."
        {
            return "Empinando...";
        }

        public override string ToString() // deve refletir todos os atributos da classe.
        {
            return base.ToString() + "Cilindradas: " + Cilindradas + Environment.NewLine;
        }

        public override double PagarPedagio()//Cálculo do pedágio: Para moto, considerar o valor R$ 2,00. Exibir o valor pago em vídeo
        {
            return 2;
        }
    }
}
