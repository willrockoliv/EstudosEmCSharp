using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_
{
    abstract class VeiculoAutomotor
    {
        private string descricao;
        private double capacidadeMaximaEmKg;
        private double velocidadeAtualEmKM; //(atributo apenas leitura)
        private double capacidadeCarregadaEmKg; //(atributo apenas leitura)

        public string Descricao { get => descricao; set => descricao = value; }
        public double CapacidadeMaximaEmKg { get => capacidadeMaximaEmKg; set => capacidadeMaximaEmKg = value; }
        public double VelocidadeAtualEmKM { get => velocidadeAtualEmKM; }
        public double CapacidadeCarregadaEmKg { get => capacidadeCarregadaEmKg; }

        public virtual double Carregar(double peso)// -> gerar exceção (personalizada) se exceder a capacidadeMaximaEmKg//.  Exibir em vídeo a capacidade informada após carregar.
        {
            if (CapacidadeMaximaEmKg >= CapacidadeMaximaEmKg)
                throw new CapacidadeMaximaAtingidaException();
            else
            {
                capacidadeCarregadaEmKg += peso;
                return CapacidadeCarregadaEmKg;
            }
        }

        public virtual double Acelerar() // aumenta em 1 km a velocidade atual do veículo e exibe no console a nova velocidade
        {
            velocidadeAtualEmKM++;
            return VelocidadeAtualEmKM;
        }

        abstract public double PagarPedagio();// seu cálculo depende de características do tipo de veículo. Todo veículo deve pagar pedágio.

        public override string ToString()// deverá exibir todos os atributos da classe, concatenados.
        {
            return "Descrição: " + Descricao + Environment.NewLine +
                   "Capacidade Máxima Em Kg: " + CapacidadeMaximaEmKg + Environment.NewLine +
                   "Velocidade Atual em Km/h: " + VelocidadeAtualEmKM + Environment.NewLine +
                   "Capacidade carrgada em Kg: " + CapacidadeCarregadaEmKg + Environment.NewLine;
        }
    }
}