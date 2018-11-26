using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais.Classes
{
    public class Baleia : Mamifero
    {      
     
        public Baleia()
        {
        
        }

        public Baleia(string nome, int sequencial, char sexo, string cordopelo, DateTime datanascimento, bool pelos, int qtdmamas, bool aquatico)
        {
            Nome = nome;
            Sequencial = sequencial;
            Sexo = sexo;
            Cordopelo = cordopelo;
            Datanascimento = datanascimento;
            Pelos = pelos;
            QtdMama = qtdmamas;
            Aquatico = aquatico;
        
        }


        public override string Movimentar()
        {
            return "100;100";
        }

        public override string Comunicar()
        {
            return @"\SomAnimais\somBaleia.wav";
        }

        public override string Amamentar()
        {
            return @"\Amamentar\mamadeiraAnimais.PNG";
        }

        public override string Parir()
        {
            return @"\Filhotes\filhoteBaleia.png";
        }
    }
}
