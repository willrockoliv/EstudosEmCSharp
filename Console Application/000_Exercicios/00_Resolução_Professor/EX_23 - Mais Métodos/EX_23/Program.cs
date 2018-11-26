using System;
using System.Collections.Generic;

using static System.Console;
using static System.Convert;

namespace EX_23
{

    struct Modelo
    {
        public string marca, tipo;
    }

    struct Carro
    {
        public string placa;
        public int ano;
        public Modelo modelo;
    }

    class Program
    {
        /*
         23. Automóvel
        Crie uma estrutura (MODELO) para guardar o modelo de um automóvel:
          string marca  (obrigatório)
          string tipo (obrigatório)

        Crie outra estrutura (CARRO) para guardar os dados de um determinado automóvel:
          string placa  (obrigatório 3 letras, um hífen, 4 números: EX: XXX-9999)
          int ano de fabricação    >= 2000
          MODELO modelo

        Crie um vetor para cadastrar até 10 carros. 
        Pergunte se o usuário deseja parar o  cadastro após cadastrar um carro.
        Ao final, exiba os dados em vídeo.
         */

        static bool IsInteger(string numero)
        {
            try
            {
                ToInt32(numero);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Verifica se um caractere está compreendido entre A e Z
        /// </summary>
        /// <param name="valor">o caractere que se quer testar</param>
        /// <returns>True se estiver de A a Z</returns>
        static bool AaZ(char valor)
        {
            if (ToInt32(valor) >= 65 && ToInt32(valor) <= 90)
                return true;
            else
                return false;

        }


        /// <summary>
        /// Le e valida a placa de um carro
        /// </summary>
        /// <returns>A placa validada e no formato PPP-9999</returns>
        static string LePlaca()
        {
            string placa;
            bool correto = false;
            do
            {
                WriteLine("\n\nDigite a placa: ");
                placa = ReadLine().ToUpper();

                if (placa.Length == 8 &&
                    placa[3] == '-' &&
                    IsInteger(placa.Substring(4)) == true &&
                    AaZ(placa[0]) &&
                    AaZ(placa[1]) &&
                    AaZ(placa[2]))
                    correto = true;
            }
            while (!correto);

            return placa;
        }


        static int LeAno()
        {
            int ano = 0;
            do
            {
                try
                {
                    WriteLine("Digite o ano >= 2000 : ");
                    ano = ToInt32(ReadLine());
                }
                catch
                {
                    WriteLine("Digite o ano numérico! ");
                }
            }
            while (ano < 2000);
            return ano;
        }


        static void ListaDados(Carro[] carros, int qtde)
        {
            for (int n = 0; n < qtde; n++)
            {
                WriteLine("{0} - {1} - {2} - {3} ",
                    carros[n].placa,
                    carros[n].ano,
                    carros[n].modelo.marca,
                    carros[n].modelo.tipo);
            }
        }


        static string LeTipo()
        {
            string tipo;
            do
            {
                WriteLine("Digite a tipo : ");
                tipo = ReadLine();
            }
            while (tipo.Length == 0);
            return tipo;
        }


        static string LeMarca()
        {
            string marca;
            do
            {
                WriteLine("Digite a marca : ");
                marca = ReadLine();
            }
            while (marca.Length == 0);
            return marca;
        }

        static void Main(string[] args)
        {
            Carro[] carros = new Carro[10];

            int qtde = 0;
            char resp;

            for (int n = 0; n < carros.Length; n++)
            {
                qtde++;
                carros[n].placa = LePlaca();
                carros[n].ano = LeAno();
                carros[n].modelo.marca = LeMarca();
                carros[n].modelo.tipo = LeTipo();

                Write("Quer continuar? <s/n> ");
                resp = char.ToUpper(ReadKey().KeyChar);
                if (resp == 'N')
                    break;
            }


            Clear();

            ListaDados(carros, qtde);

            ReadLine();
        }
    }
}

