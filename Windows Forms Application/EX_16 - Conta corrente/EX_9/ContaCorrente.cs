using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9
{
    class ContaCorrente : ContaBancaria
    {
        double limitedeCredito;

        public double LimitedeCredito
        {
            get { return limitedeCredito; }
            set { limitedeCredito = value; }
        }
        bool utilizaTalaoCheque;

        public bool UtilizaTalaoCheque
        {
            get { return utilizaTalaoCheque; }
            set { utilizaTalaoCheque = value; }
        }



        public override void Saque(double valor)
        {
            Nome = "";

            if (Saldo + limitedeCredito - valor < 0)
                throw new NegocioException("Limite de crédito foi superado.");
            Saldo -= valor;
        }


        public override string ToString()
        {
            return base.ToString() + " Limite de crédito: " + LimitedeCredito +
                "   Utiliza cheque: " + (UtilizaTalaoCheque ? " Sim " : " Não");
        }



    }
}
