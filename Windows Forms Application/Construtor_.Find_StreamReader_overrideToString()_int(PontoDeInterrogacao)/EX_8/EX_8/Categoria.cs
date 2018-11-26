using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EX_8
{
    public class Categoria
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


        public Categoria(int codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }


        /// <summary>
        /// Carrega a lista de categorias do arquivo.
        /// </summary>
        /// <returns></returns>
        public static List<Categoria> CarregaDados()
        {
            List<Categoria> lista = new List<Categoria>();
            if (File.Exists("Categorias.txt"))
            {
                string[] linhas = File.ReadAllLines("Categorias.txt");
                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split(',');
                    Categoria categ = new Categoria(
                            Convert.ToInt16(dados[0]),
                            dados[1]);
                    lista.Add(categ);
                }                              
            }
            return lista;
        }

    }
}
