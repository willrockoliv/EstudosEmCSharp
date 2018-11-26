using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais.Classes
{
    public class Pombo : Ave, IVoar
    {
        public Pombo()
        { }

        public Pombo(int sequencial, string nome, char sexo, DateTime datanascimento,
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
            return @"\Voar\voarPombo.png";
        }
        
        public override string Movimentar()
        {
            return "100;100";
        }

        public override string Comunicar()
        {
            return @"\SomAnimais\nada.wav";
        }

        public override string Ciscar()
        {
            return @"\Ciscar\ciscarPombo.png";
        }

        public override string Botar()
        {
            return @"\Botar\botarPombo.png";
        }

        public override string Chocar()
        {
            return @"\Chocar\chocarPombo.png";
        }
    }
}
