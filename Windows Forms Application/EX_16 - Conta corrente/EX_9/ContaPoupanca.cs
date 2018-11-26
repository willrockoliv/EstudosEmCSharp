using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9
{
    class ContaPoupanca : ContaBancaria
    {

        private int diaDeAniversario;

        public int DiaDeAniversario
        {
            get { return diaDeAniversario; }
            set { diaDeAniversario = value; }
        }
        private string numeroContaAtrelada;

        public string NumeroContaAtrelada
        {
            get { return numeroContaAtrelada; }
            set { numeroContaAtrelada = value; }
        }



        

        public override string ToString()
        {
            return base.ToString() + "  Dia de aniversário: " + 
                DiaDeAniversario + "  Conta atrelada: " + NumeroContaAtrelada;
        }
    }
}
