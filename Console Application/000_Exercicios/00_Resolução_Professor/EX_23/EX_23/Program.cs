using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        static bool AaZ(char valor)
        {
            if (ToInt32(valor) >= 65 && ToInt32(valor) <= 90)
                return true;
            else
                return false;

        }

        static void Main(string[] args)
        {
            Carro[] carros = new Carro[10];

            int qtde = 0;
            char resp;

            for (int n = 0; n < carros.Length; n++)
            {
                qtde++;

                bool correto = false;
                do
                {
                    WriteLine("\n\nDigite a placa: ");
                    carros[n].placa = ReadLine().ToUpper();

                    if (carros[n].placa.Length == 8 &&
                        carros[n].placa[3] == '-' &&
                        IsInteger(carros[n].placa.Substring(4)) == true &&
                        AaZ(carros[n].placa[0]) &&
                        AaZ(carros[n].placa[1]) &&
                        AaZ(carros[n].placa[2]))
                        correto = true;
                }
                while (!correto);


                do
                {
                    try
                    {
                        WriteLine("Digite o ano >= 2000 : ");
                        carros[n].ano = ToInt32(ReadLine());
                    }
                    catch
                    {
                        WriteLine("Digite o ano numérico! ");
                    }
                }
                while (carros[n].ano < 2000);


                do
                {
                    WriteLine("Digite a marca : ");
                    carros[n].modelo.marca = ReadLine();
                }
                while (carros[n].modelo.marca.Length == 0);

                do
                {
                    WriteLine("Digite a tipo : ");
                    carros[n].modelo.tipo = ReadLine();
                }
                while (carros[n].modelo.tipo.Length == 0);
                                                
                Write("Quer continuar? <s/n> ");
                resp = char.ToUpper( ReadKey().KeyChar);
                if (resp == 'N')
                    break;
            }


            Clear();

            for (int n=0; n< qtde; n++)
            {
                WriteLine("{0} - {1} - {2} - {3} ",
                    carros[n].placa,
                    carros[n].ano,
                    carros[n].modelo.marca,
                    carros[n].modelo.tipo);
            }

            ReadLine();
        }
    }
}

