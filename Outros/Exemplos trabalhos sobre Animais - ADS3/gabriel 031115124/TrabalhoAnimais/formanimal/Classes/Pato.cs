using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais.Classes
{
    public class Pato : Ave, IVoar
    {

        public Pato()
        { }


        public Pato(int sequencial, string nome, char sexo, DateTime datanascimento,
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

        public string Voar()
        {
            return @"\Voar\voarPato.png";
        }

        public override string Movimentar()
        {
            return "100;100";
        }

        public override string Comunicar()
        {
            return @"\SomAnimais\somPato.wav";
        }

        public override string Ciscar()
        {
            return @"\Ciscar\ciscarPato.png";
        }

        public override string Botar()
        {
            return @"\Botar\botarPato.png";
        }

        public override string Chocar()
        {
            return @"\Chocar\chocarPato.png";
        }


    }
}
