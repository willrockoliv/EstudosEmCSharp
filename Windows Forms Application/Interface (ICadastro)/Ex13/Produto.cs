using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Produto : ICadastro
    {
        public string Pesquisar(string valor)
        {
            string[] dados = File.ReadAllLines("dados.txt");
            string conteudo = "";

            foreach (string dado in dados)
            {
                string[] temp = dado.Split('|');
                if (temp[0] == "P")
                    if (temp[2].ToUpper() == valor.ToUpper().Trim())
                    {
                        conteudo = temp[1] + "|" + temp[2] + "|" + temp[3];
                        return conteudo;
                    }
            }
            return conteudo;
        }

        public void Salvar(string conteudo)
        {
            File.AppendAllText("dados.txt", conteudo + Environment.NewLine);
        }
    }
}
