using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais.Classes
{
    public class Gato : Mamifero
    {

        public Gato()
        { }


        public Gato(int sequencial, string nome, char sexo, DateTime datanascimento, string cordopelo,
            bool aquatico, bool pelos, int qtdmamas)

        {
        
                    Sequencial = sequencial;
                    Nome = nome;
                    Sexo = sexo;
                    Datanascimento = datanascimento;
                    Cordopelo = cordopelo;
                    Aquatico = aquatico;
                    Pelos = pelos;
                    QtdMama = qtdmamas;
        
        
        }


        public override string Movimentar()
        {
            return "100;100";
        }

        public override string Comunicar()
        {
            return @"\SomAnimais\somGato.wav";
        }

        public override string Amamentar()
        {
            return @"\Amamentar\mamadeiraAnimais.PNG";
        }

        public override string Parir()
        {
            return @"\Filhotes\filhoteGato.png";
        }
    }
}
