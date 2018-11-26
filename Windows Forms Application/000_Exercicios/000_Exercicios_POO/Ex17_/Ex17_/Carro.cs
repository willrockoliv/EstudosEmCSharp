using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_
{
    class Carro : VeiculoAutomotor, ICarroCaminhao
    {
        private int quantidadeDePortas;
        private bool utilizandoReboque;

        public int QuantidadeDePortas { get => quantidadeDePortas; set => quantidadeDePortas = value; }
        public bool UtilizandoReboque { get => utilizandoReboque; set => utilizandoReboque = value; }

        public override string ToString()// deve refletir todos os atributos da classe.
        {
            return base.ToString() + "Quantidade de portas: " + QuantidadeDePortas + Environment.NewLine +
                                     "utilizando Reboque: " + UtilizandoReboque + Environment.NewLine;
        }

        public override double PagarPedagio()//No método de cálculo do pedágio: caso esteja usando reboque cobrar R$ 10,00. Caso contrário, cobrar R$7,00. Exibir o valor pago em vídeo.
        {
            if (UtilizandoReboque)
                return 10;
            else
                return 7;
        }

        public int VelocidadeLimpador()
        {
            throw new NotImplementedException();
        }

        public void AcionarLimpador()
        {
            throw new NotImplementedException();
        }

        public void AbrirPorta()
        {
            throw new NotImplementedException();
        }
    }
}
