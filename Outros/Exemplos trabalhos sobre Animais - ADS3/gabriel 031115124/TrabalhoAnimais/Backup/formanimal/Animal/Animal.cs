using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais
{
    public abstract class Animal
    {

        private int sequencial;

        public int Sequencial
        {
            get { return sequencial; }
            set
            {
                if (value <= 0)
                {

                    throw new Exception("Sequencial invalido");


                }

                sequencial = value;
            }
        }

        private string nome;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Trim() == "")
                {
                    throw new Exception("Digite um nome");

                }
                nome = value;
            }
        }

        private DateTime datanascimento;

        public DateTime Datanascimento
        {
            get { return datanascimento; }
            set
            {
                if (value == null)
                    throw new Exception("Digite a data de nascimento");
                else
                    datanascimento = value;
            }
        }

        private char sexo;

        public char Sexo
        {
            get { return sexo; }
            set
            {
                if (value.ToString().Trim() == "")
                {

                    throw new Exception("Escolha um sexo");

                }
                else if (value != 'F' && value != 'M')
                {

                    throw new Exception("Você deve usar F para fêmea ou M para macho");
                
                }
                else
                    sexo = value;
            }
        }


        public int Idade()
        {
            int pIdade = 1;

            TimeSpan diff;

            diff = DateTime.Now - datanascimento;

            pIdade = Convert.ToInt32(diff.Days);
       
            return pIdade;

        }

        public abstract string Movimentar();
        public abstract string Comunicar();      
        



    }
}
