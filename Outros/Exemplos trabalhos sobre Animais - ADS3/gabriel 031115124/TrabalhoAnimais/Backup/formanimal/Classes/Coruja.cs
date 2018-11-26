using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais.Classes
{
    public class Coruja : Ave, IVoar
    {

        public Coruja()
        {}


        public Coruja(int sequencial, string nome, char sexo, DateTime datanascimento,
        bool aquatico, bool rapina, bool possuipenas)
        {

            this.Sequencial = sequencial;
            this.Nome = nome;
            this.Sexo = sexo;
            this.Datanascimento = datanascimento;
            this.Aquatico = aquatico;
            this.Rapina = rapina;
            this.PossuiPenas = possuipenas;        
        
        }        

        public override string Movimentar()
        {
            return "100;100";
        }

        public override string Comunicar()
        {
            return @"\SomAnimais\somCoruja.wav";
        }

        public override string Ciscar()
        {
            return @"\Ciscar\ciscarCoruja.png";
        }

        public override string Botar()
        {
            return @"\Botar\botarCoruja.png";
        }

        public override string Chocar()
        {
            return @"\Chocar\chocarCoruja.png";
        }

        public string Voar()
        {
            return @"\Voar\voarCoruja.png";
        }

     

      
    }
}
