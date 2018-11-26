using System;
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
            if (File.Exists("QUIZ.TXT") == false || arquivo[0] == "" && arquivo[1] == "" && arquivo[2] == "")
            {
                Console.WriteLine("\n                 Não foi possível carregar o aqruivo \"QUIZ.TXT\"." +
                                  "\n     Verifique se o arquivo está na pasta correta ou se o nome do arquivo está correto." +
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

        static string[] TemasDisponiveis(Quiz[] quiz)
        {
            string[] temas_disponiveis = foreach(string tema in quiz)
            return temas_disponiveis;
        }

        static string[] QtdPerguntasPorTema(Quiz[] quiz, string[] arquivo)
        {
            string temp = "";
            string[] contador_temas = new string[arquivo.Length];
            int k = 0;
            for (int i = 0; i < quiz.Length; i++)
            {
                int contador_temp = 0;
                if (quiz[i].tema != "-")
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
                        quiz[j].tema = "-";
                    }
                }
                contador_temas[k] = Convert.ToString(contador_temp) + temp;
                k++;
            }
            return contador_temas;
        } //metodo para retornar qtd perguntas disponíveis

        static string Menu_tema_escolhido(string[] qtd_perguntas_por_tema)
        {
            int i = 0, escolha = 0;
            Console.WriteLine("\n >>> Temas disponíveis <<<");
            foreach (string tema in qtd_perguntas_por_tema)
            {
                if (qtd_perguntas_por_tema[i] == null)
                    break;
                Console.WriteLine("\n < {0} > {1}", i + 1, qtd_perguntas_por_tema[i].Substring(2, qtd_perguntas_por_tema[i].Length - 3));
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
                Console.WriteLine("\n >> Esse tema possui 1 pergunta disponíveis");
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

        static void SorteiaPergutntas()
        {

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
            string[] temas_disponiveis = TemasDisponiveis(quiz);
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
                menu.tema_escolhido = Menu_tema_escolhido(qtd_perguntas_por_tema);
                menu.qtd_perguntas = Menu_qtd_perguntas(menu);
                #endregion

                #region Sorteio de Perguntas
                int[] numeros = SorteiaNumeros(menu.qtd_perguntas);
                SorteiaPergutntas();
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
