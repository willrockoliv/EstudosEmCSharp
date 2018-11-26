using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_
{
    class Caminhao : VeiculoAutomotor, ICarroCaminhao
    {
        int quantidadeEixos;

        public int QuantidadeEixos { get => quantidadeEixos; set => quantidadeEixos = value; }

        public override double Carregar(double peso)//exibe no console "Carregado". Caso o peso ultrapasse o peso máximo,  NÃO gere uma exceção, mas exiba em vídeo a mensagem “Sobrecarregado”;
        {
            if (CapacidadeCarregadaEmKg >= CapacidadeMaximaEmKg)
            {
                Console.WriteLine("Sobrecarregado");
                return -1;
            }
            else
            {
                Console.WriteLine("Carregado");
                return peso;
            }
        }

        public override double Acelerar() //O método Acelerar não deve acelerar o caminhão caso o peso carregado no caminhão ultrapasse o peso máximo.Neste caso, gere uma exceção com o texto “Sobrecarregado!”.
        {
            if (CapacidadeCarregadaEmKg > CapacidadeMaximaEmKg)
                throw new CapacidadeMaximaAtingidaException("Sobrecarregado");
            else
                return base.Acelerar();
        }

        public override string ToString() //O método ToString deve refletir todos os atributos da classe.
        {
            return base.ToString() + "Quantidade de eixos: " + QuantidadeEixos + Environment.NewLine;
        }

        //Crie o método Descarregar() , que irá retirar todo o peso e escrever "Vazio" no console;
        public string Descarregar()
        {
            if (CapacidadeCarregadaEmKg == 0)
                return "Vazio";
            else
            {
                base.Carregar(-CapacidadeCarregadaEmKg);
                return "Vazio";
            }
        }

        //Cálculo do pedágio: Considerar o valor R$ 5,00 por eixo.Exibir o valor pago em vídeo.
        public override double PagarPedagio()
        {
            return QuantidadeEixos * 5;
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
