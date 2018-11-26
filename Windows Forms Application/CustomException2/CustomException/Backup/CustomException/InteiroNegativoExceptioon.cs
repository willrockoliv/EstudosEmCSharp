﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CustomException
{
    class InteiroNegativoExceptioon : Exception 
    {
        //public int Codigo { get; set; }

        
        public InteiroNegativoExceptioon(string erro): base(erro)
        {            
            File.AppendAllText("log.txt", "Em: " + 
                DateTime.Now.ToString() + ": " +  erro + Environment.NewLine);
                           
        } 

        

        public InteiroNegativoExceptioon(int numero): 
            base("Número " + numero + " é inválido pois não é positivo!")
        {
            File.AppendAllText("log.txt",
                "Em: " + DateTime.Now.ToString() + ": " + Message + Environment.NewLine);
        }
    }
}
