using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9
{
    abstract class ContaBancaria
    {
        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        String numeroConta;

        public String NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }

        protected Double saldo = 0;

        public Double Saldo
        {
            get { return saldo; }
            protected set
            {
                saldo = value;
            }
        }

        public virtual void Deposito(double valor)
        {
            if (valor <= 0)
                throw new NegocioException("Valor deve ser positivo.");

            saldo += valor;
        }

        public virtual void Saque(double valor)
        {
            if (saldo - valor < 0)
                throw new NegocioException("Saldo não pode ficar negativo.");
            saldo = saldo - valor;
        }


        public override string ToString()
        {
            return "Nome: " + Nome + "  Conta: " + NumeroConta +
                "  Saldo: " + Saldo;
        }
    }
}
