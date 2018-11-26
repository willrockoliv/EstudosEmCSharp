using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ProfSorteiaPalavra
{
    class Program
    {
        //é a variável que armazena uma palavra
        struct Palavra
        {
            public string palavra;
            public string[] dicas;
            //será usado para indicar o espaço que a dica será armazenada e dizer quantas dicas são
            public int contaDicas;
        }

        static void Main(string[] args)
        {
            animacaoApresentacao();
            bool jogar = false;
            do
            {
                //esse trecho de código carrega o arquivo para um vetor da struct Palavra
                Palavra[] palavras = carregaArquivo();
                if (palavras[0].palavra == "Sem arquivo")
                {
                    Console.WriteLine("Sem arquivo");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    //esse trecho de código verifica quantos espaços do vetor foram preenchidos para fazer o sorteio de palavra
                    int numPalavras = quantidadePalavras(palavras);


                    //esse trecho de código faz o sorteio
                    Palavra palavraSorteada = sorteio(palavras, numPalavras);
                    //IMPRESSÃO DA PALAVRA SORTEADA
                    //Console.WriteLine(palavraSorteada.palavra);

                    //esse trecho de código exibe as lacunas a serem preenchidas e cria um array de char que vai armazenar as letras corretas
                    char[] lacunas = new char[palavraSorteada.palavra.Length];
                    //essas são as coordenadas das lacunas, serão usadas na impressão delas e para preechimento por letras
                    int x = 5;
                    int y = 10;
                    imprimeLacunas(palavraSorteada, x, y);
                    forca(palavraSorteada, x, y, lacunas);
                    Console.Clear();
                    bool repete;
                    do
                    {
                        repete = false;
                        try
                        {
                            Console.WriteLine("Jogar de novo?(S/N)");
                            char op = Console.ReadLine().ToLower()[0];
                            if (op == 's')
                                jogar = true;
                            else if (op == 'n')
                                jogar = false;
                            else
                                throw new ArgumentException();
                        }
                        catch
                        {
                            repete = true;
                            Console.WriteLine("Resposta inválida");
                        }
                    } while (repete);
                    Console.Clear();
                }
            } while (jogar);
            
        }

        static Palavra[] carregaArquivo()
        {
            if (File.Exists("jogo.txt"))
            {
                string[] texto = File.ReadAllLines("jogo.txt", Encoding.Default);
                Palavra[] palavras = new Palavra[100];

                int contaLinhas = 0;
                int contaPalavras = 0;

                try
                {
                    do
                    {
                        //Esse if foi colocado porque há o risco do arquivo conter linhas vazias
                        if (texto[contaLinhas] != "")
                            if (texto[contaLinhas][0] == 'P' && palavras[contaPalavras].palavra == null)
                            {
                                palavras[contaPalavras].palavra = texto[contaLinhas].Substring(2);
                                palavras[contaPalavras].dicas = new string[10];
                            }
                            else if (texto[contaLinhas][0] == 'D')
                            {
                                palavras[contaPalavras].dicas[palavras[contaPalavras].contaDicas] = texto[contaLinhas].Substring(2);
                                palavras[contaPalavras].contaDicas++;
                            }
                            //Esse if foi colocado porque há o risco do arquivo conter linhas com espaços em branco
                            else if (texto[contaLinhas][0] == ' ')
                            {
                                //Não faça nada
                            }
                            else
                            {
                                contaPalavras++;
                                continue;
                            }
                        contaLinhas++;
                    } while (contaLinhas < texto.Length);
                }
                catch
                {
                    Console.WriteLine("Arquivo em formato inválido");
                }
                return palavras;
            }
            else
            {
                Palavra[] palavras = new Palavra[1];
                palavras[0].palavra = "Sem arquivo";
                return palavras;
            }
        }

        static int quantidadePalavras(Palavra[] palavras)
        {
            int numPalavras = 0;
            for (int l = 0; l < palavras.Length; l++)
            {
                if (palavras[l].palavra == null)
                {
                    numPalavras = l;
                    break;
                }
                //Caso sejam 100 palavras não haverá nulo no vetor, então o número de palavras deve ser obtido assim
                else if (l == palavras.Length - 1)
                    numPalavras = l;
            }
            return numPalavras;
        }

        static Palavra sorteio(Palavra[] palavras, int numPalavras)
        {
            Random sorteio = new Random();
            Palavra palavraSorteada = palavras[sorteio.Next(numPalavras)];
            return palavraSorteada;
        }

        static void imprimeLacunas(Palavra palavraSorteada, int x, int y)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            foreach (char letra in palavraSorteada.palavra)
            {
                if (letra == ' ' || letra == '-')
                    Console.Write("  ");
                else
                    Console.Write("_ ");
            }
        }

        static void exibeDica(Palavra palavraSorteada, int numDica)
        {
            Console.CursorLeft = 5;
            Console.CursorTop = 1;
            //limpa o espaço para próxima dica
            for (int i = 0; i <= 152; i++)
            {
                Console.Write(" ");
            }

            Console.CursorLeft = 5;
            Console.CursorTop = 1;
            //numDica é incrementado em forca() e exibe a próxima dica
            Console.WriteLine("Dica: " + palavraSorteada.dicas[numDica]);
        }

        static char[] verificaLetra(ConsoleKeyInfo tecla, Palavra palavraSorteada, char[] lacunas, int x, int y)
        {
            char caractere = Convert.ToChar(tecla.KeyChar.ToString().ToUpper());
            bool acerto = false;

            for (int IndiceLetra = 0; IndiceLetra < palavraSorteada.palavra.Length; IndiceLetra++)
            {
                if (caractere == palavraSorteada.palavra.ToUpper()[IndiceLetra])
                {
                    if (lacunas[IndiceLetra] == '\0')
                    {
                        lacunas[IndiceLetra] = caractere;
                        Console.CursorLeft = x + IndiceLetra * 2;
                        Console.CursorTop = y;
                        Console.Write(caractere);
                        acerto = true;
                    }
                }
            }

            if (acerto == true)
                return lacunas;
            else
            {
                char[] erro = { 'e', 'r', 'r', 'o', '§' };
                return erro;
            }
        }

        static string RegistraLetrasDigitadas(ConsoleKeyInfo tecla, string letrasDigitadas)
        {
            letrasDigitadas += tecla.KeyChar;
            Console.CursorLeft = 0;
            Console.CursorTop = 4;
            Console.WriteLine("Letras digitadas:");
            Console.WriteLine(letrasDigitadas);
            return letrasDigitadas;
        }

        static int animacao(int posicaoBoneco)
        {
            for (int i = 3; i > 0; i--)
            {
                posicaoBoneco--;
                //Esse laço limpa o trecho onde foi feito o desenho
                Console.CursorTop = 19;
                for (int p = 0; p < 390; p++)
                    Console.Write(" ");
                Console.CursorLeft = 0;
                Console.CursorTop = 24;
                Console.WriteLine("            ####################################################################");
                Console.CursorLeft = posicaoBoneco;
                Console.CursorTop = 19;
                Console.WriteLine("         O");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("       __|__");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("         |");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("        | |");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("        | |");
                Thread.Sleep(200);
                Console.CursorTop = 19;
                for (int p = 0; p < 390; p++)
                    Console.Write(" ");

                Console.CursorLeft = 0;
                Console.CursorTop = 24;
                Console.CursorLeft = posicaoBoneco;
                Console.CursorTop = 19;
                Console.WriteLine("         O");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("       __|__");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("         |");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("        / |");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("       /  |");
                Thread.Sleep(200);
                Console.CursorTop = 19;
                for (int p = 0; p < 390; p++)
                    Console.Write(" ");

                Console.CursorLeft = 0;
                Console.CursorTop = 24;
                Console.CursorLeft = posicaoBoneco;
                Console.CursorTop = 19;
                Console.WriteLine("        O");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("      __|__");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("        |");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("       | \\");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("       |  \\");
                Thread.Sleep(200);
                Console.CursorTop = 19;
                for (int p = 0; p < 390; p++)
                    Console.Write(" ");

                Console.CursorLeft = 0;
                Console.CursorTop = 24;
                Console.CursorLeft = posicaoBoneco;
                Console.CursorTop = 19;
                Console.WriteLine("        O");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("      __|__");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("        |");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("       | |");
                Console.CursorLeft = posicaoBoneco;
                Console.WriteLine("       | |");
            }
            return posicaoBoneco;
        }

        static void animacaoQueda()
        {
            Console.CursorLeft = 0;
            Console.CursorTop = 19;
            Console.WriteLine("    !   O");
            Console.WriteLine("      __|__");
            Console.WriteLine("        |");
            Console.WriteLine("       | |");
            Console.WriteLine("       | |");
            Thread.Sleep(200);
            Console.CursorLeft = 0;
            Console.CursorTop = 19;
            Console.WriteLine("        O     !");
            Console.WriteLine("      __|__");
            Console.WriteLine("        |");
            Console.WriteLine("       | |");
            Console.WriteLine("       | |");
            Thread.Sleep(200);
            Console.CursorLeft = 0;
            Console.CursorTop = 18;
            Console.WriteLine("        !      ");
            Console.WriteLine("        O      ");
            Console.WriteLine("      __|__");
            Console.WriteLine("        |");
            Console.WriteLine("       | |");
            Console.WriteLine("       | |");
            Thread.Sleep(200);
            for (int i = 18; i < 40; i++)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = i;
                Console.WriteLine("          ");
                Console.WriteLine("        O");
                Console.WriteLine("      __|__");
                Console.WriteLine("        |");
                Console.WriteLine("       | |");
                Console.WriteLine("       | |");
                Thread.Sleep(100);
                Console.CursorTop = i;
                Console.WriteLine("           ");
                Console.WriteLine("             ");
                Console.WriteLine("           ");
                Console.WriteLine("            ");
                Console.WriteLine("            ");
                Console.WriteLine("            ");
            }
        }

        static void animacaoApresentacao()
        {
            Console.WriteLine("Nome: Filipe Andrade Lopes        RA: 032136973");
            string[] apresentacao = {"><<<<<<<<  ><<<<     ><<<<<<<      ><<        ><       ","><<      ><<    ><<  ><<    ><< ><<   ><<    >< <<     ",
                                     "><<    ><<        ><<><<    ><<><<          ><  ><<    ","><<<<<<><<        ><<>< ><<    ><<         ><<   ><<   ",
                                     "><<    ><<        ><<><<  ><<  ><<        ><<<<<<>><<  ","><<      ><<     ><< ><<    ><< ><<   ><<><<       ><< ",
                                     "><<        ><<<<     ><<      ><< ><<<< ><<         ><<"};
            Console.CursorTop = 9;
            Console.CursorLeft = 11;
            for (int linha = 0; linha < apresentacao.Length; linha++)
            {
                for (int i = 0; i < apresentacao[linha].Length; i++)
                {
                    Console.Write(apresentacao[linha][i]);
                    Thread.Sleep(1);
                }
                Console.WriteLine();
                Console.CursorLeft = 11;
            }
            Console.WriteLine();
            ConsoleKey digito;
            do
            {
                Console.CursorLeft = 11;
                Console.Write("Pressione ENTER para jogar");
                digito = Console.ReadKey(true).Key;
            } while (digito != ConsoleKey.Enter);
            Console.Clear();
           
        }

        static void forca(Palavra palavraSorteada, int x, int y, char[] lacunas)
        {
            DateTime inicio = DateTime.Now;
            double comparaTempo = 0;
            double tempoemSegundos = 0;
            //palavraFormada será usada para converter o array de char em string para verificar se a palavra foi formada para finalizar o jogo
            string palavraFormada = "";
            //conta os erros
            int erros = 0;
            int posicaoBoneco = 30;
            string letrasDigitadas = "";
            //conta as dicas que já foram exibidas
            int numDica = 0;
            Console.CursorLeft = 5;
            Console.CursorTop = 8;
            Console.Write("Digite letra ou F2 para dicas");
            exibeDica(palavraSorteada, numDica);
            numDica++;

            do
            {
                try
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo tecla;
                        Console.CursorLeft = 5;
                        Console.CursorTop = 9;
                        tecla = Console.ReadKey();


                        if (tecla.Key == ConsoleKey.F2 )
                        {
                            if (numDica < palavraSorteada.contaDicas)
                            {
                                exibeDica(palavraSorteada, numDica);
                                Console.CursorLeft = 5;
                                Console.CursorTop = 3;
                                numDica++;
                                erros++;
                                Console.WriteLine("Erro " + erros);
                                posicaoBoneco = animacao(posicaoBoneco);
                            }
                            else
                            {
                                Console.CursorLeft = 5;
                                Console.CursorTop = 16;
                                Console.WriteLine("Acabaram as dicas");
                            }
                        }

                        //Verifica se a letra é correta e escreve, se incorreta o erro é acumulado
                        else
                        {
                            //Esse trecho exibe caracteres digitados
                            letrasDigitadas = RegistraLetrasDigitadas(tecla, letrasDigitadas);
                            palavraFormada = new string(verificaLetra(tecla, palavraSorteada, lacunas, x, y));
                            if (palavraFormada == "erro§")
                            {
                                Console.CursorLeft = 5;
                                Console.CursorTop = 3;
                                erros++;
                                Console.WriteLine("Erro " + erros);
                                //Animação
                                posicaoBoneco = animacao(posicaoBoneco);
                            }

                        }
                    }
                    //aqui vai o código do tempo
                    tempoemSegundos = DateTime.Now.Subtract(inicio).TotalSeconds;
                    if (comparaTempo != Math.Truncate(tempoemSegundos))
                    {
                        if (Math.Truncate(tempoemSegundos) >= 30 && Math.Truncate(tempoemSegundos) < 50)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        if (Math.Truncate(tempoemSegundos) >= 50)
                            if (Math.Truncate(tempoemSegundos) % 2 == 0)
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            else
                                Console.ForegroundColor = ConsoleColor.Red;
                        Console.CursorLeft = 70;
                        Console.CursorTop = 0;
                        Console.WriteLine((60 - Math.Truncate(tempoemSegundos)) + "seg. ");
                        Console.ResetColor();
                        comparaTempo = Math.Truncate(tempoemSegundos);
                    }
                }
                catch
                {
                    //Exibe a mensagem e depois de 0.7s ela some
                    Console.CursorLeft = 5;
                    Console.CursorTop = 7;
                    Console.WriteLine("Caractere inválido");
                    Thread.Sleep(700);
                    Console.CursorLeft = 5;
                    Console.CursorTop = 7;
                    Console.WriteLine("                       ");

                }
            } while (palavraFormada.Replace("\0", "") != palavraSorteada.palavra.Replace(" ", "").Replace("-", "").ToUpper() && posicaoBoneco > 0 && tempoemSegundos <= 60);

            if (palavraFormada.Replace("\0", "") != palavraSorteada.palavra.Replace(" ", "").Replace("-", "").ToUpper())
            {

                while (posicaoBoneco > 0)
                {
                    posicaoBoneco = animacao(posicaoBoneco);
                }

                animacaoQueda();
                Console.CursorLeft = 0;
                Console.CursorTop = 40;
                Console.WriteLine("Perdeu!");
                Thread.Sleep(2000);
            }

            else
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Venceu!");
                Thread.Sleep(2000);
            }

            Console.CursorLeft = 0;
            Console.CursorTop = 20;
        }
    }
}
