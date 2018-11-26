using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EX_8
{
    class Jogo
    {

        const string ARQUIVO = "Jogo.txt";

        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set
            {
                if (value <= 0)
                    throw new Exception("Código inválido.");
                codigo = value;
            }
        }
        string descricao; // : string  (obrigatorio)

        public string Descricao
        {
            get { return descricao; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Descrição inválida.");
                descricao = value;
            }
        }

        DificuldadeEnum dificuldade;

        public DificuldadeEnum Dificuldade
        {
            get { return dificuldade; }
            set { dificuldade = value; }
        }


        double valor; // (entre 1 e 10,00)
        public double Valor
        {
            get { return valor; }
            set
            {
                if (value < 1 || value > 10)
                    throw new Exception("Valor inválido.");
                valor = value;
            }
        }
                

        public Fabricante Fabricante { get; set; }

        public void Salvar()
        {
            string linha =
                Codigo.ToString() + "|" +
                Descricao.ToString() + "|" +
                Valor.ToString() + "|" +
                ((int)Dificuldade).ToString() + "|" +
                Fabricante.Id +
                Environment.NewLine;

            File.AppendAllText(ARQUIVO, linha);
        }





        public static List<Jogo> Carregar(List<Fabricante> listaFabricantes)
        {
            List<Jogo> lista = new List<Jogo>();

            if (!File.Exists(ARQUIVO))
            {
                return lista;
            }

            StreamReader reader = new StreamReader(ARQUIVO);

            try
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    if (linha.Trim().Length == 0)
                        continue;
                    Jogo j = new Jogo();
                    j.codigo = Convert.ToInt32(linha.Substring(0, linha.IndexOf('|')));
                    linha = linha.Remove(0, linha.IndexOf('|') + 1);

                    j.Descricao = linha.Substring(0, linha.IndexOf('|'));
                    linha = linha.Remove(0, linha.IndexOf('|') + 1);

                    j.valor = Convert.ToDouble(linha.Substring(0, linha.IndexOf('|')));
                    linha = linha.Remove(0, linha.IndexOf('|') + 1);

                    j.dificuldade = (DificuldadeEnum)Convert.ToInt32(linha.Substring(0, linha.IndexOf('|')));
                    linha = linha.Remove(0, linha.IndexOf('|') + 1);
                    
                    int idFabricante = Convert.ToInt32(linha);


                    j.Fabricante = listaFabricantes.Find(f => f.Id == idFabricante);
                    /*
                    foreach (Fabricante f in listaFabricantes)
                        if (f.Id == idFabricante)
                        {
                            j.Fabricante = f;
                            break;
                        }*/

                    lista.Add(j);
                }

                return lista;
            }
            finally
            {
                reader.Close();
            }
        }

    }
}
