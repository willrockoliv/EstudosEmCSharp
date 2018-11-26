﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz
{
    class Program
    {
        static bool ok;

        struct Quiz
        {
            public string pergunta, tema, correta, alt1, alt2, alt3, alt4, tema_escolhido, perg_sorteadas;
            public int qtd_perguntas;
        }

        #region Game Over
        static void GameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n                         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n" +
                                                  "                         @@@@     @@@   @@@   @@@   @       @@@@    @@  @@@  @      @      @@@\n" +
                                                  "                         @@@  @@@@@@  @   @    @    @  @@@@@@@@  @@  @  @@@  @  @@@@@  @@@  @@\n" +
                                                  "                         @@  @@@@@@  @@@  @         @  @@@@@@@@  @@  @  @@@  @  @@@@@  @@@  @@\n" +
                                                  "                         @@  @@   @  @@@  @         @     @@@@@  @@  @   @   @     @@  @@   @@\n" +
                                                  "                         @@  @@@  @       @   @ @   @  @@@@@@@@  @@  @@     @@  @@@@@     @@@@\n" +
                                                  "                         @@@  @@  @  @@@  @   @@@   @  @@@@@@@@  @@  @@@   @@@  @@@@@  @   @@@\n" +
                                                  "                         @@@@     @  @@@  @   @@@   @       @@@@    @@@@@ @@@@      @  @@   @@\n" +
                                                  "                         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region Parabens
        static void Parabens()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
"      /\\  /\\      |\n" +
"  ___/  \\/  \\___  |\n" +
" |              / |                                                ##'\n" +
" |             /_ |                                              ,##\n" +
" /      \\_| \\_| / |\n" +
"/      \\/  \\/  \\/ | ######    ##    #######.    ##    ######: ####### ####  ### :####,\n" +
"\\   _  (o   )o  ) | ##  ##   ####   ###  ###   ####'  ##  ### ###     ####+ ### ###\n" +
" \\ /c   \\__/ --.  | ##  ##   ####   ###  ###   ####'  ##  ### ###     ####+ ### ###\n" +
" | \\_   ,     -'  | ##..##  ##''##  ###  ###  ##''##  ##  ### ###     ##### ### ###\n" +
" |_ |  '\\_______) | ###### .##''##  #######  .##''##  #####:  ######  ##+######  ###'\n" +
"   ||      _)     | ##     ######## ###:##   ######## ##  ### ###     ##+,####+   ###.\n" +
"    |     |       | ##    ,##:  ### ### ##' ,##:  ### ##  ### ###     ##+ ####' + ,##'\n" +
"    OOOOOOO       | ##    ###   :## ### ### ###   :## ######: ####### ##+  ###' #####\n" +
"   /       \\      |");

            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region Abertura
        static void Abertura()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(
                    "\n\n     ,---.                      |      .++++.\n" +
                    "   ,.'-.   \\                    |     .+++++++.\n" +
                    "     ,'\"\"\"\"\" -.                 |    .++++++++++.\n" +
                    "  `,X          `.               |    ++++   ++++++                    .++.\n" +
                    "  /` `           `.             |   ++++     ++++++                   ++++\n" +
                    " (            ,   ,_\\           |  .++++      ++++++                  '++'\n" +
                    " |          ,---.,'o `.         |  +++++      ++++++                      \n" +
                    " |         / o   \\     )        |  +++++      ++++++  +++++  +++++   +++++   ++++++++\n" +
                    "  \\ ,.    (      .____,         |  +++++      ++++++  +++++  '++++   +++++   ++++++++\n" +
                    "   \\| \\    \\____,'     \\        |  +++++      '+++++   ++++   ++++    ++++   ++  `++\n" +
                    " '`'\\  \\        _,____,'        |  +++++.      +++++   ++++   ++++    ++++   +   ++\n" +
                    " \\  ,--      ,-'     \\          |  ++++++      +++++   ++++   ++++    ++++      +++\n" +
                    "   ( C     ,'         \\         |  ++++++      +++++   ++++   ++++    ++++     +++\n" +
                    "    `--'  .'           |        |  ++++++      ++++    ++++   ++++    ++++    +++\n" +
                    "      |   |         .O |        |   ++++++     ++++    ++++   ++++    ++++   +++   '+\n" +
                    "    __|    \\        ,-'_        |   '+++++    ,+++'    +++'   +++'    ++++   +++  +++\n" +
                    "   / `L     `._  _,'  ' `.      |    ++++++   +++'     ++++++++'''    ++++  +++++++++\n" +
                    "  /    `--.._  `',.   _\\  `     |     '++++++++++      +++++++++++   ;++++  +++++++++   ##########\n" +
                    "  `-.       /\\  | `. ( ,\\  \\    |      '+++++++'       ++++++ +++++  +++++  +++++++++,##############\n" +
                    " _/  `-._  /  \\ |--'  (     \\   |        ;+++:                                       #################\n" +
                    "'  `-.   `'    \\/\\`.   `.    )  |     ++++++++++                                      #################\n" +
                    "      \\           \\ `.  |    |  |     +++++++++++++                                   ########      ####\n" +
                    "                                |          '+++++++ #########                                        ###\n" +
                    "                                |            +++++#############       #######                        ####\n" +
                    "                                |              ++##############    ##############                  ######\n" +
                    "                                |                 #############           #############          ########\n" +
                    "                                |                  ##########                ###########################\n" +
                    "                                |                                              ########################\n" +
                    "                                |                                                 ####################\n" +
                    "                                |                                                    ###############\n" +
                    "                                |                                                      ############\n" +
                    "\n                   Press Enter para contnuar...");
            Console.ReadLine();

        }
        #endregion

        static string[] CarregaArquivoQuiz()
        {
            string[] arquivo = new string[100];
            if (File.Exists("QUIZ.TXT") == false || File.ReadAllText("QUIZ.TXT") == "")
            {
                Console.WriteLine("\n                  Não foi possível carregar o aqruivo \"QUIZ.TXT\"." +
                                  "\n            Certifique-se de que o arquivo está na pasta ou não está vazio." +
                                  "\n                        E então execute o jogo novamente.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (File.Exists("QUIZ.TXT"))
            {
                arquivo = File.ReadAllLines("QUIZ.TXT", Encoding.UTF8);
            }
            return arquivo;
        }

        static string[] QtdPerguntasPorTema(Quiz[] quiz, string[] arquivo)
        {
            string temp = "";
            string[] contador_temas = new string[arquivo.Length];
            int k = 0;
            for (int i = 0; i < quiz.Length; i++)
            {
                int contador_temp = 0;
                if (quiz[i].tema.Trim()[0] != '-')
                {
                    temp = quiz[i].tema;
                }
                else
                    continue;

                for (int j = 0; j < quiz.Length; j++)
                {
                    if (quiz[j].tema == temp)
                    {
                        contador_temp++;
                        quiz[j].tema = "-" + quiz[j].tema;
                    }
                }
                contador_temas[k] = Convert.ToString(contador_temp) + temp;
                k++;
            }
            LimpaTemas(quiz);
            return contador_temas;
        } //metodo para retornar qtd perguntas disponíveis

        static void LimpaTemas(Quiz[] quiz)
        {
            for (int i = 0; i < quiz.Length; i++)
            {
                quiz[i].tema = quiz[i].tema.Replace("- ", "");
            }
        }

        static string Menu_tema_escolhido(string[] qtd_perguntas_por_tema)
        {
            int i = 0, escolha = 0;
            Console.WriteLine("\n >>> Temas disponíveis <<<");
            foreach (string tema in qtd_perguntas_por_tema)
            {
                if (qtd_perguntas_por_tema[i] == null)
                    break;
                else if (i == 10)
                    break;
                Console.WriteLine("\n < {0} > {1}", i + 1, qtd_perguntas_por_tema[i].Trim().Substring(2, qtd_perguntas_por_tema[i].Length - 3));
                i++;
            }
            ok = false;
            do
            {
                try
                {
                    Console.Write("\n\n >> Escolha o tema: ");
                    escolha = Convert.ToInt16(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("\n !! Informe apenas números inteiros !!");
                }
            }
            while (ok == false);
            return qtd_perguntas_por_tema[escolha - 1];
        } // mostra temas disponiveis e retorna escolha do usuário

        static int Menu_qtd_perguntas(Quiz menu)
        {
            Console.Clear();
            Console.WriteLine("\n >>> {0}", menu.tema_escolhido.Substring(2, menu.tema_escolhido.Length - 3));
            if (menu.tema_escolhido[0] == '1')
            {
                char s_ou_n;
                do
                {
                    Console.Write("\n >> Esse tema possui 1 pergunta disponível. Deseja continuar? (S/N) ");
                    s_ou_n = Console.ReadLine()[0];
                    ok = TesteSimOuNao(s_ou_n);
                }
                while (ok == false);
                if (char.ToUpper(s_ou_n) == 'N')
                    return menu.qtd_perguntas = -1;
            }
            else
                Console.WriteLine("\n >> Esse tema possui {0} perguntas disponíveis", menu.tema_escolhido[0]);
            ok = false;
            do
            {
                try
                {
                    Console.Write("\n\n > Quantas deseja responder? ");
                    menu.qtd_perguntas = Convert.ToInt16(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n Digite um número inteiro!");
                }
            }
            while (ok == false);
            return menu.qtd_perguntas;
        } //mostrar qtd de perguntas disponiveis para o tema escolhido (inverter sequencia de execução com Menu_Tema_escolhido

        static int[] SorteiaNumeros(int qtd_perguntas)
        {
            Random sorteio = new Random();
            int[] numeros = new int[qtd_perguntas];
            for (int n = 0; n < numeros.Length; n++)
            {
                bool existe;
                do
                {
                    existe = false;
                    numeros[n] = sorteio.Next(1, qtd_perguntas + 1);
                    for (int p = 0; p < n; p++)
                    {
                        if (numeros[p] == numeros[n])
                        {
                            existe = true;
                            break;
                        }
                    }
                }
                while (existe == true);
            }
            return numeros;
        }

        static void SorteiaPergutntas(int[] numeros, Quiz[] quiz, Quiz menu)
        {
            Console.Clear();
            int j = 1;
            for (int i = 0; i < menu.qtd_perguntas; i++)
            {
                string[] perguntas = new string[Convert.ToInt16(menu.tema_escolhido[0])];//aqui troquei pra versão Quiz 1.5 pois apaguei LimpaTemas()
                if(menu.tema_escolhido == quiz[i].tema)

                Console.WriteLine("\n {0}) {1}", j, quiz[numeros[i]].pergunta);
            }
        }


        static bool TesteSimOuNao(char s_ou_n)
        {
            if (s_ou_n == ' ' && Char.ToUpper(s_ou_n) != 'S' && Char.ToUpper(s_ou_n) != 'N')
                return false;
            else
                return true;
        }

        static void Main(string[] args)
        {
            bool sair = false;
            char opcao;

            #region Carregamento do Jogo
            string[] arquivo = CarregaArquivoQuiz();
            Quiz[] quiz = new Quiz[arquivo.Length];
            for (int i = 0; i < arquivo.Length; i++)
            {
                string[] temp = arquivo[i].Split('|');
                quiz[i].pergunta = temp[0];
                quiz[i].tema = temp[1];
                quiz[i].correta = temp[2];
                quiz[i].alt1 = temp[3];
                quiz[i].alt2 = temp[4];
                quiz[i].alt3 = temp[5];
                quiz[i].alt4 = temp[6];
            } // separa informações por categoria
            string[] qtd_perguntas_por_tema = QtdPerguntasPorTema(quiz, arquivo);
            Abertura();
            #endregion

            #region Jogo
            do
            {
                #region Menu do Jogo
                Quiz menu = new Quiz();
                Console.Clear();
                Console.WriteLine("\n >>>  Escolha abaixo o tema e a quantidade de perguntas desejados  <<<");
                do
                {
                    menu.tema_escolhido = Menu_tema_escolhido(qtd_perguntas_por_tema);
                    menu.qtd_perguntas = Menu_qtd_perguntas(menu);
                }
                while (menu.qtd_perguntas == -1);
                #endregion

                #region Sorteio de Perguntas
                int[] numeros = SorteiaNumeros(menu.qtd_perguntas);
                SorteiaPergutntas(numeros, quiz, menu);
                #endregion

                do
                {
                    Console.Clear();
                    Console.Write("\n Deseja iniciar um novo jogo? (S/N): ");
                    opcao = Console.ReadKey().KeyChar;
                    sair = TesteSimOuNao(opcao);
                }
                while (sair == false);
            }
            while (sair == false);
            #endregion
        }
    }
}
