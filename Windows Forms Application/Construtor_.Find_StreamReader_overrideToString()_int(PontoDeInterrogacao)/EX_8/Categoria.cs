using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_8
{
    class Categoria : object
    {
        
        public int Codigo { get; set; }
     
        public string Descricao { get; set; }

        public static List<Categoria> Carrega()
        {
            String[] linhas = File.ReadAllLines("Categorias.txt");
            List<Categoria> lista = new List<Categoria>();

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');
                Categoria c = new Categoria();
                c.Codigo = Convert.ToInt32(dados[0]);
                c.Descricao = dados[1];
                lista.Add(c);
            }
            return lista;
        }


        public override string ToString()
        {
            return Codigo + " - " + Descricao;
        }

    }
}
