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
            public string pergunta, tema, correta, alt1, alt2, alt3, alt4;
            public string tema_escolhido;
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

        static string[] QtdPerguntasPorTema(Quiz[] quiz, string[] arquivo)
        {
            string temp = "";
            string[] contador_temas = new string[100];
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
                //i = i + (contador_temp - 1);
                contador_temas[k] = Convert.ToString(contador_temp) + temp;
                k++;
            }
            return contador_temas;
        } //metodo para retornar qtd perguntas disponíveis

        // metodo para avançar. Botao "Avançar"

        // metodo para retorna.Botao "Retornar"

        static string Menu_tema_escolhido()
        {
            Quiz menu = new Quiz();
            ok = false;

            do
            {
                Console.Write("\n >> Esolha o tema desejado: ");
                menu.tema_escolhido = Console.ReadLine();
            }
            while (menu.tema_escolhido == "");

            return menu.tema_escolhido;
        } // mostra temas disponiveis e retorna escolha do usuário

        static int Menu_qtd_perguntas()
        {
            Quiz menu = new Quiz();
            ok = false;

            do
            {
                try
                {
                    Console.Write("\n\n >> Número de perguntas: ");
                    menu.qtd_perguntas = Convert.ToInt32(Console.ReadLine());
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
            do
            {
                Quiz menu = new Quiz();
                Console.Clear();
                Console.WriteLine("\n >>>  Escolha abaixo o tema e a quantidade de perguntas desejados  <<<");
                menu.tema_escolhido = Menu_tema_escolhido();
                menu.qtd_perguntas = Menu_qtd_perguntas();
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
        }
    }
}
