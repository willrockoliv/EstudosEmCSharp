using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_10
{
    class CCorrente
    {
        public int Agencia { get; set; }
        public string CC { get; set; }
        public string Nometitular { get; set; }
        public double Saldo { get; private set; } = 0;


        public CCorrente(int agencia, string cc, string titular)
        {
            Saldo = 0;
            Agencia = agencia;
            CC = cc;
            Nometitular = titular;
        }



        public void Saque(double valor)
        {
            if (valor > Saldo)
                throw new Exception("Não há saldo!");
            else
                Saldo -= valor;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

    }
}
