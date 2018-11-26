using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

// Vinícius Sena EC2 RA: 082160014
namespace QUIZ
{
    class Program
    {
        struct DadosPergunta
        {
            public string pergunta, tema, correta, alt1, alt2, alt3, alt4, resp;
        }
        struct Resposta
        {
            public string pergunta, correta, resposta;
        }
        /// <summary>
        /// Lê os temas e escreve os temas na tela sem repetir
        /// </summary>
        /// <param name="pergunta"></param>
        /// <param name="qtd"></param>
        /// <returns></returns temas[]>
        static string[] LeTemas(DadosPergunta[] pergunta, int qtd)
        {
            string[] temas = new string[100];

            for (int n = 0; n < pergunta.Length; n++)
                if (!temas.Contains(pergunta[n].tema))
                {
                    temas[n] = pergunta[n].tema;

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.Write("->>");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(" " + temas[n].Trim());
                }
            return temas;
        }
        /// <summary>
        /// Gera números aleatórios para chamar as perguntas de forma aleatoria
        /// </summary>
        /// <returns></returns vetor[] >
        static int[] GeradorNumerosAleatorios()
        {
            Random gerador = new Random();
            int[] vetor = new int[100];

            for (int n = 0; n < vetor.Length - 1; n++)
            {
                bool existe;
                do
                {
                    existe = false;
                    vetor[n] = gerador.Next(1, 100);

                    for (int p = 0; p < n; p++)
                    {
                        if (vetor[p] == vetor[n])
                        {
                            existe = true;
                            vetor[n] = gerador.Next(1, 99);
                            break;
                        }
                        else
                            existe = false;
                    }
                }
                while (existe);
            }
            return vetor;
        }
        /// <summary>
        /// seleciona as perguntas do tema escolhido
        /// </summary>
        /// <param name="perguntas"></param>
        /// <param name="temaesc"></param>
        /// <param name="qntd"></param>
        /// <returns></returns quantos>
        static int NumerodasperguntasdoTemaescolhido(DadosPergunta[] perguntas, string temaesc, int qntd)
        {
            int quantos = 0;
            for (int p = 0; p < qntd; p++)
                if (perguntas[p].tema.Trim().ToUpper() == temaesc.Trim().ToUpper())
                {
                    quantos++;
                }
            return quantos;

        }
        /// <summary>
        /// Escreve as perguntas na tela, verifica se está certo ou errado e mostra o tempo na tela
        /// </summary>
        /// <param name="errou"></param>
        /// <param name="acertou"></param>
        /// <param name="temaesco"></param>
        /// <param name="quantasresponder"></param>
        /// <param name="conta"></param>
        /// <param name="resp"></param>
        /// <param name="perguntas"></param>
        /// <param name="tempo"></param>
        /// <param name="inicio"></param>
        static void EscrevePerguntas(int errou, int acertou, DadosPergunta[] temaesco, int quantasresponder, int conta, string resp, DadosPergunta[] perguntas, double tempo, DateTime inicio)
        {
            Resposta[] Verifica = new Resposta[10];
            for (int n = 0; n < quantasresponder; n++)
            {

                for (int s = 0; s < perguntas.Length; s++)
                    if (temaesco[s].tema != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        conta++;
                        if (conta <= quantasresponder && tempo >= 0)
                        {
                            Console.Clear();
                            Console.CursorLeft = 0;
                            Console.CursorTop = 0;
                            string a, b, c, d;
                            resp = "";
                            a = temaesco[s].alt1;
                            b = temaesco[s].alt2;
                            c = temaesco[s].alt3;
                            d = temaesco[s].alt4;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" Pergunta: " + temaesco[s].pergunta);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\n  Alternativas>>>>");
                            Console.WriteLine("     a) " + temaesco[s].alt1);
                            Console.WriteLine("     b) " + temaesco[s].alt2);
                            Console.WriteLine("     c) " + temaesco[s].alt3);
                            Console.WriteLine("     d) " + temaesco[s].alt4);
                            Console.WriteLine("\n  Digite a alternativa correta (ex. a): ");

                            do
                            {
                                Console.CursorLeft = 65;
                                Console.CursorTop = 3;
                                Console.CursorVisible = false;
                                tempo = DateTime.Now.Subtract(inicio).TotalSeconds;
                                Console.WriteLine("TEMPO: " + (quantasresponder * 15 - Math.Truncate(tempo)) + "SEG");
                                if (Console.KeyAvailable)
                                {
                                    Console.CursorLeft = 0;
                                    Console.CursorTop = 9;
                                    resp = Convert.ToString(Console.ReadKey().KeyChar);
                                    if (resp.ToUpper().Trim() == "A")
                                    {
                                        resp = a;
                                        break;
                                    }
                                    else if (resp.ToUpper().Trim() == "B")
                                    {
                                        resp = b;
                                        break;
                                    }
                                    else if (resp.ToUpper().Trim() == "C")
                                    {
                                        resp = c;
                                        break;
                                    }
                                    else if (resp.ToUpper().Trim() == "D")
                                    {
                                        resp = d;
                                        break;
                                    }
                                    else
                                        Console.WriteLine("Resposta fora dos padrões");
                                }

                            }
                            while (tempo <= quantasresponder * 15);
                            Console.CursorLeft = 0;
                            Console.CursorTop = 11;
                            if (resp == temaesco[s].correta.Trim())
                            {
                                acertou++;
                            }
                            else if (resp == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nO TEMPO ACABOU!");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n\nPressione ENTER para continuar");
                            }
                            else
                            {
                                errou++;

                            }





                            temaesco[s].resp = resp;

                        }



                    }

            }
            Console.Clear();
            for (int p = 0; p < temaesco.Length; p++)
            {
                if (temaesco[p].pergunta != null)
                    if (temaesco[p].correta == temaesco[p].resp)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n" + temaesco[p].pergunta);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" " + temaesco[p].resp + " - ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" CORRETO!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n" + temaesco[p].pergunta);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" " + temaesco[p].resp + " - ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" ERRADO!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" Resposta correta -> ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(temaesco[p].correta);
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nVocê acertou: {0} e errou: {1}", acertou, errou);
        }

        static void Main(string[] args)
        {
            string respos = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\n\n\n\n");

            Console.WriteLine("            xxxxxx  xxxxxx  xxxxxx       xxxxxx  xx  xx  xx  xxxxx \n" +
                              "            xxxxxx  xxxxxx  xxxxxx       xx  xx  xx  xx  xx    xx  \n" +
                              "            xxx       xx      xx         xx  xx  xx  xx  xx   xx   \n" +
                              "            xxx       xx      xx         xxxxxx  xxxxxx  xx  xxxxx \n" +
                              "                                             xxx");
            Console.WriteLine("\n\n\n                       PRESSIONE ENTER PRA CONTINUAR: ");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                if (File.Exists("QUIZ.txt")) // veriifica se o arquivo txt existena pasta bin/Debug
                {


                    Console.Clear();
                    int qntd = 0;
                    string[] todasasperguntas = File.ReadAllLines("QUIZ.txt", Encoding.Default); // atribui cada linha do txt à uma posição no vetor
                    string[] pergunta = new string[7];
                    DadosPergunta[] perguntas = new DadosPergunta[100];
                    for (int n = 0; n < todasasperguntas.Length; n++) //atribui cada pedaço da pergunta a sua variável dentro do vetor
                    {
                        pergunta = todasasperguntas[n].Split('|');
                        perguntas[n].pergunta = pergunta[0].Trim();
                        perguntas[n].tema = pergunta[1].Trim();
                        perguntas[n].correta = pergunta[2].Trim();
                        perguntas[n].alt1 = pergunta[3].Trim();
                        perguntas[n].alt2 = pergunta[4].Trim();
                        perguntas[n].alt3 = pergunta[5].Trim();
                        perguntas[n].alt4 = pergunta[6].Trim();
                        qntd++;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("<<< Temas >>>");
                    Console.ForegroundColor = ConsoleColor.Black;
                    LeTemas(perguntas, qntd);

                    Console.WriteLine("\n\nDigite o tema escolhido (ESCREVER DA MESMA FORMA QUE ESTÁ ACIMA): ");
                    string temaesc = Console.ReadLine();

                    int[] Sequenciadasperguntas = GeradorNumerosAleatorios();


                    int qntsdotema = NumerodasperguntasdoTemaescolhido(perguntas, temaesc, qntd);
                    int quantasresponder = 0;
                    do
                    {
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Existem {0} perguntas do tema escolhido, digite quantas você deseja responder: ", NumerodasperguntasdoTemaescolhido(perguntas, temaesc, qntd));
                            quantasresponder = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Digite apenas números!");
                            Console.ReadLine();
                        }

                    }
                    while (quantasresponder == 0 || quantasresponder > qntsdotema);


                    DadosPergunta[] temaesco = new DadosPergunta[perguntas.Length];
                    for (int x = 0; x < perguntas.Length; x++)
                        if (perguntas[Sequenciadasperguntas[x]].tema != null)
                        {
                            if (perguntas[Sequenciadasperguntas[x]].tema.Trim().ToUpper() == temaesc.Trim().ToUpper())
                            {
                                temaesco[x] = perguntas[Sequenciadasperguntas[x]];
                            }

                        }

                    int acertou = 0, errou = 0;
                    int conta = 0;
                    double tempo = quantasresponder * 15;
                    DateTime inicio = DateTime.Now;
                    Console.Clear();
                    string resp = "";
                    EscrevePerguntas(errou, acertou, temaesco, quantasresponder, conta, resp, perguntas, tempo, inicio);



                    Console.WriteLine("Deseja jogar novamente? (s/n)");
                    respos = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("ARQUIVO QUIZ.txt NAO ENCONTRADO!");
                    Console.ReadLine();
                }
            }
            while (respos.ToUpper().Trim() == "S");
        }
    }
}
