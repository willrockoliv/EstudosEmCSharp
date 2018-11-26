using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    public class Jogos
    {
        private int codigo;
        private string descricao;
        public enum Dificuldade { easy, normal, hard };
        private string difficulty;
        private double valor;
        private string fabricante;

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value > 0)
                    codigo = value;
                else
                    throw new Exception("Código deve ser maior que zero");
            }
        }

        public string Descricao
        {
            get => descricao;
            set
            {
                if (value != "")
                    descricao = value;
                else
                    throw new Exception("Descrição obrigatória");
            }
        }

        public double Valor
        {
            get => valor;
            set
            {
                if (value >= 0 && value <= 10)
                    valor = value;
                else
                    throw new Exception("Valor deve estar entre 0 e 10,00");
            }
        }

        public string Fabricante
        {
            get => fabricante;
            set
            {
                if (value != "")
                    fabricante = value;
                else
                    throw new Exception("Fabricante obrigatório");
            }
        }

        public string Difficulty
        {
            get => difficulty;
            set
            {
                if (value != "")
                    difficulty = value;
                else
                    throw new Exception("Dificuldade obrigatória");
            }
        }

        public void Salvar()
        {
            string conteudo = codigo + "|" + descricao + "|" + difficulty + "|" + valor + "|" + fabricante + Environment.NewLine;
            File.AppendAllText("cadastros.txt", conteudo);
        }
    }
}