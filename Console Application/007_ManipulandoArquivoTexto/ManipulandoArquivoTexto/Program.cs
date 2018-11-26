using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace ManipulandoArquivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario;
            char sexo;
                                 

            if (File.Exists("dados.txt") == true)
            {
                Console.WriteLine("Dados carregados do arquivo:");
                string texto = File.ReadAllText("dados.txt");
                int pos = texto.IndexOf('|');
                nome = texto.Substring(0, pos);

                texto = texto.Remove(0, pos + 1);

                pos = texto.IndexOf('|');
                salario = Convert.ToDouble(texto.Substring(0, pos));

                sexo = texto.Substring(pos + 1)[0];

                Console.WriteLine("{0}  {1}   {2}", nome, salario, sexo);
                Console.ReadLine();
            }
            
            
            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o salário: ");
            salario = Convert.ToDouble( Console.ReadLine());

            Console.Write("Sexo: M/F: ");
            sexo = Console.ReadLine()[0];


            //O "|" (PIPE) serve para separar os campos
            //para que possamos futuramente recuperá-los 
            //Poderia ser qualquer outro caractere, ex: "▒", "╔",etc
            //o comando WriteAllText sempre sobrescreve o arquivo
            //use o AppendAllText para adicionar ao arquivo, sem reescrevê-lo!
            string conteudo = nome + "|" + salario + "|" + sexo + Environment.NewLine; // ou  "\r\n"
            File.WriteAllText("dados.txt", conteudo);
                                                                                                                                                                                                                                                                                                    
            
            Console.ReadLine();
        }
    }
}
