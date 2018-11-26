using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private string rg;
        private double salario;

        public void SetCodigo(int valor)
        {
            if (valor <= 0)
                throw new Exception("Código não pode ser negativo!");

            codigo = valor;
        }

        public int GetCodigo()
        {
            return codigo;
        }


        public void SetNome(string valor)
        {
            if (string.IsNullOrEmpty(valor))
                throw new Exception("Nome errado!");

            nome = valor;
        }

        public string GetNome()
        {
            return nome;
        }



        public void SetRG(string rg)
        {
            if (string.IsNullOrEmpty(rg))
                throw new Exception("RG errado!");

            this.rg = rg; // this significa (da classe)
        }



        public string GetRG()
        {
            return rg;
        }


        public void SetSalario(double valor)
        {
            if (salario < 0)
                throw new Exception("Salário inválido!");

            salario = valor;
        }
        
        public double GetSalario()
        {
            return salario;
        }

        public double GetInss()
        {
            return salario * 0.11;
        }


        public double CalcularSalario()
        {
            return salario - GetInss();
        }

    }
}
