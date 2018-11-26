using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6_TimeFutebol.VO
{
    public class JogadorFutebolVO : PadraoVO
    {
        private int id;
        private string nome;
        private int numeroCamisa;
        private int timeId;

        public override int Id
        {
            get
            {
                return id;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Código  tem que ser maior que zero.");
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Nome obrigatório.");
                nome = value;
            }
        }

        public int NumeroCamisa
        {
            get
            {
                return numeroCamisa;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Número da camisa tem que ser maior que zero.");
                numeroCamisa = value;
            }
        }

        public int TimeId
        {
            get
            {
                return timeId;
            }

            set
            {
                if (value <= 0)
                    throw new Exception("Código do time tem que ser maior que zero.");
                timeId = value;
            }
        }
    }
}
