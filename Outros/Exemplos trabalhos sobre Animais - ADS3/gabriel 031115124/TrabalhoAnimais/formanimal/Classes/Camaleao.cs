using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais.Classes
{
    public class Camaleao: Reptil
    {

        public Camaleao()
        {}

         public Camaleao(int sequencial, string nome, DateTime datadenascimento, char sexo, bool temcasco, bool temescama, bool tempena)
        {
            this.Sequencial = sequencial;
            this.Nome = nome;
            this.Datanascimento = datadenascimento;
            this.Sexo = sexo;
            this.TemCasco = temcasco;
            this.TemEscama = temescama;
            this.PossuiPenas = tempena;               
        }


        public override string Movimentar()
        {
            return "100;100";
        }

        public override string Comunicar()
        {
            return @"\SomAnimais\somOrnitorrinco.wav";
        }

        public override string Botar()
        {
            return @"\Botar\botarCamaleao.png";
        }

        public override string Chocar()
        {
            return @"\Chocar\chocarCamaleao.png";
        }

        
    }
}
