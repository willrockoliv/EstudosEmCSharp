using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoAnimais.Classes
{
    public class Ornitorrinco : Mamifero, IOviparo
    {

        public Ornitorrinco()
        { }


        public Ornitorrinco(int sequencial, string nome, char sexo, DateTime datanascimento, string cordopelo,  
        bool aquatico, bool pelos, int qtdmamas,  bool possuipenas)
        {
            this.Nome = nome;
            this.Sequencial = sequencial;
            this.Sexo = sexo;
            this.Cordopelo = cordopelo;
            this.Datanascimento = datanascimento;
            this.Pelos = pelos;
            this.QtdMama = qtdmamas;
            this.Aquatico = aquatico;
            this.PossuiPenas = possuipenas;
        
        }     

        public override string Movimentar()
        {
            return "100;100";
        }

        public override string Comunicar()
        {
            return @"\SomAnimais\somOrnitorrinco.wav";
        }

        public override string Amamentar()
        {
            return @"\Amamentar\mamadeiraAnimais.PNG";
        }

        public override string Parir()
        {
            return null;
        }        

        public string Botar()
        {
            return @"\Botar\botarOrnitorrinco.png";
        }

        public string Chocar()
        {
            return @"\Chocar\chocarOrnitorrinco.png";
        }

        private bool possuipenas;
        public bool PossuiPenas
        {
            get
            {
                return possuipenas;
            }
            set
            {
                possuipenas = value;
            }
        }

       
    }
}
