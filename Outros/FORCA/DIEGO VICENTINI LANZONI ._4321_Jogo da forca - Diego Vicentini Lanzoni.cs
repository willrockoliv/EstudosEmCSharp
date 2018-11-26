using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JogoForca
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Professor, encontrei um local onde há diversas apostilas, vale compartilhar o link.
            https://www.oficinadanet.com.br/apostilas/detalhe/517/apostila_para_iniciantes_em_c_sharp */


            Console.SetWindowSize(100, 60);
            Console.WriteLine("\n" +
                              "                  #----- NOME: Diego vicentini Lanzoni ------- #\n" +
                              "                  #------------- RA.: 082150106 ---------------#\n" +
                              "                  #--------------- [X] JOGO -------------------#\n" +
                              "                  #--------------- [X] DICAS ------------------#\n" +
                              "                  #--------------- [X] TEMPO ------------------#\n");

            Console.WriteLine("\n\r" +
                              "                  _______   ________ _______ _______ _______ \n" +
                              "                 |_     _| |  |  |  |   _   |    |  |_     _|\n" +
                              "                  _|   |_  |  |  |  |       |       | |   |  \n" +
                              "                 |_______| |________|___|___|__|____| |___|  \n" +
                              "\n" +

                              "              _______ _______     ______ _____   _______  ___ ___  \n" +
                              "             |_     _|       |   |   __ |     |_|   _   ||   |   | \n" +
                              "               |   | |   -   |   |    __|       |       | |     |  \n" +
                              "               |___| |_______|   |___|  |_______|___|___|  |___|   \n" +

                              "\n" +

                              "                _______    _______ _______ _______ _______   __  \n" +
                              "               |   _   |  |     __|   _   |   |   |    ___| |  | \n" +
                              "               |       |  |    |  |       |       |    ___| |__| \n" +
                              "               |___|___|  |_______|___|___|__|_|__|_______| |__| \n\n" +

                              "BEM-VINDO AO JOGO DA FORCA DOS JOGOS MORTAIS. CUIDADO PARA O JIGSAW NÃO TE PEGAR! \n\r" +
                              "                   APERTE ENTER PARA QUE OS JOGOS COMECEM!");

            
            Console.ReadLine();
            Jogo.NovoJogo();
        }
    }

   
    class Jogo
    {
                
            public static int vidas, erros, tempo, mostraDica;
            public static bool ganhou; // Verifica se ganhou ou não (boolean)

            public static int posicaoTecla; // Posição do cursor no console
            public static Timer timer; // Variável para armazenar o Timer

            protected static int linhaInicio; // Posição do cursor na linha, ao início do jogo
            protected static int colunaInicio; // Posição do cursor na coluna, ao início do jogo
               
        // Método que limpa as variáveis e começa um novo jogo
        public static void NovoJogo()
        {
            vidas = 8;
            erros = 0;
            tempo = 60;
            ganhou = false;
            posicaoTecla = 0;
            mostraDica = 0;

            Console.Clear();

            Texto.inicioLinha = Console.CursorTop;
            Texto.inicioColuna = Console.CursorLeft;

            List<Palavra> palavras = Arquivo.Carregar("jogo.txt"); // faz uma lista com todos dados do arquivo.
            Palavra palavra = Palavras.Sortear(palavras);

            Tabuleiro(palavra);
        }

        public static void Tempo(Object objeto) //Metodo feito para contagem do tempo para verificar se perdeu por ele.
        {
        
            timer.Change(1000, Timeout.Infinite);
            
            if (vidas > 0 && !ganhou && tempo > 0) // Caso o jogador ainda possua vidas e não tenha terminado o jogo ainda, e ainda haja tempo restante
            {
                tempo = tempo - 1;
                Console.SetCursorPosition(0, 2); //cursor na parte do tempo.
                Console.WriteLine(">>> TEMPO: {0} <<<", tempo);
                Console.SetCursorPosition(posicaoTecla, 6); // volta cursor
            }
            
            if (tempo == 0) // acabou o tempo
            {

                Texto.Posicionado("### TEMPO ACABOU, Aperte uma letra para continuar ###", 0, 4);

                // Assim que o jogador pressionar uma letra, ele será jogado para o loop (do...while) no método Tabuleiro()
                timer.Change(Timeout.Infinite, Timeout.Infinite);
            }
                
        }

        // metodo dos parâmetros do jogo.
        static void Tabuleiro(Palavra palavra) // O arguemento Palavra é uma instância da classe (criada mais abaixo)
        {
            int caracteres = 0; // Caracteres validos digitados pelo jogador
            string resposta = palavra.Resposta.Trim().ToUpper(); // Palavra secreta que o jogador deverá adivinhar
            char[] letras = resposta.ToCharArray(); // Array de caracteres que compõem a palavra secreta
            List<char> corretas = new List<char>(); // Lista de letras certas que o jogador digitou, aprendi com um amigo que fez sistemas.
            List<char> erradas = new List<char>(); // Lista de letras erradas que o jogador digitou, aprendi com um amigo que fez sistemas.

            linhaInicio = Console.CursorTop;
            colunaInicio = Console.CursorLeft;

            Console.Clear(); 
            Console.WriteLine("*** Descubra a palavra secreta - Se necessitar, aperte F2 para receber uma dica***");
            Console.WriteLine(">>> VIDAS: {0} <<<", Jogo.vidas);
            Console.WriteLine(">>> TEMPO: {0} <<<", Jogo.tempo);
            Console.WriteLine("-----------------------------------------------------");

            // Para cara letra na palavra, criei um underline "_"
            foreach (char letra in letras)
            {
                Console.Write("_");
            }
            Console.Write(" >>> {0} letras <<<", resposta.Length); // Informamos ao jogador quantas letras têm na palavra
            Console.WriteLine("\n-----------------------------------------------------\n");
            Console.WriteLine("Dica: {0} \n", palavra.Dicas[mostraDica].Trim());

            //tempo criado para o controle no jogo!
            // - null, pois não precisaremos passar nenhum estado para essa chamada
            // - 1000, tempo de espera em milisegundos
            // - Timeout.Inifinte, sem tempo limite
            // isso chamará o métido tempo.
            timer = new Timer(Tempo, null, 1000, Timeout.Infinite);
            ConsoleKeyInfo tecladigitada; // consolekeyinfo é uma classe que fornece dados do input do teclado.

            do
            {
                tecladigitada = Console.ReadKey(); // Lê a tecla digitada
                string tecla = tecladigitada.Key.ToString(); // Converte o código da tecla para string
                
                    if (tempo == 0)
                    {
                        GameOver(); //chama o metodo de gameover.
                        break;
                    }


                    if (caracteres < resposta.Length && tempo > 0)
                    {
                        // Caso o jogador tecle F2, chamamos o método Dica, que tem a palavra secreta
                        if (tecla == "F2")
                        {
                            Dica(palavra);
                        }

                        else if (tecla == "Escape") //se apertar esc
                        {
                            Environment.Exit(0); //fecha o console
                        }

                        else
                        {
                            posicaoTecla = posicaoTecla + 2;

                            char caractere = Convert.ToChar(tecladigitada.Key.ToString().ToUpper()); // Professor, não consegui validar numeros. Tentei fazer um if logo abaixo para 
                                                                                                     // os caracteres da ascii porém não funcionou!
                            if (caractere >= 65 && caractere <= 90) 
                            {

                                if (letras.Contains(caractere) && !corretas.Contains(caractere)) // contains verifica se dentro de letras há o que está nos parenteses
                                {
                                    int posicao = 0;

                                    foreach (char letra in letras)
                                    {
                                        if (letra == caractere) //verifica se a mesma é igual ao caractere
                                        {
                                            Console.SetCursorPosition(0, 0); // Marca a posição inicial no topo esquerdo da tela
                                            Texto.Posicionado(caractere.ToString(), posicao, 4); // escreve a letra na posição correta

                                            if (!corretas.Contains(caractere))
                                            {
                                                corretas.Add(caractere);
                                            }
                                            caracteres = caracteres + 1;
                                        }
                                        posicao = posicao + 1;
                                    }
                                }


                                // Caso o jogador tenha errado a letra
                                else
                                {


                                    if (!erradas.Contains(caractere) && !corretas.Contains(caractere))
                                    {
                                        erradas.Add(caractere); // adiciona a letra errada ao array
                                        Errou(); // chama o método Errou()
                                    }
                                }
                            }
                            else
                                Console.Write("digite somente letras!");
                        }
                    }

                    if (caracteres == resposta.Length && vidas > 0 && tempo >= 0)
                    {
                        Win(); // Chama o método Win
                }
            }
            while (tecladigitada.Key != ConsoleKey.Escape); // Caso o jogador tecle Escape, interrompemos o loop
        }

        // O método Errou()
        static void Errou()
        {
            vidas = vidas - 1; // Remove uma vida do jogador
            Texto.Posicionado(Jogo.vidas.ToString(), 11, 1); // Posiciona o texto na linha que exibe vidas e subtrai 1
            Texto.Posicionado(Texto.Jigsaw(Jogo.erros), 0, 10 + (Jogo.erros * 5)); // Exibimos a imagem parcial do Jigsaw
            erros = erros + 1; // Incrementa os erros para comparar com as vidas depois
            if (vidas <= 0) //Caso o jogador esteja sem vidas
            {
                GameOver(); // chama o metodo gameover
            }
        }

        // metodo para pegar as dicas do F2
        public static void Dica(Palavra palavra)
        {
            mostraDica = mostraDica + 1; // Incrementamos o número da dica a ser exibida
            if (vidas > 0) 
            {
                // Caso a palavra ainda tenha dicas disponíveis
                if (mostraDica < palavra.Dicas.Count)
                {
                    Texto.Posicionado("Dica: " + palavra.Dicas[mostraDica], 0, 7+mostraDica); // coloca a dica na tela, 
                    Errou(); // metodo errou pra contar 1 erro a cada dica.
                }
                
                else
                {
                    // insere espaço em branco na linha na dica para não deixar nada escrito
                    string espacos = " ";
                    for (int i = 0; i < 45; i++)
                    {
                       espacos += " ";
                    }
                    espacos += "\n------------------------------------------------------------------------\n";
                    Texto.Posicionado("Dica: SEM DICAS PARA MOSTRAR" + espacos, 0, 7+ palavra.Dicas.Count);
                }
            }

            else
            {
                GameOver(); // chama o GameOver()
            }
        }

       
        public static void Win()
        {
            ganhou = true; // Muda a variável ganhou para true, informando que o jogo acabou
            Texto.Posicionado(Texto.Ganhou(), 0, 0); // Posiciona o texto de vitória do jogador
            Tecla(); // Chama o método Tecla()
        }

        
        
        // Método GameOver()
        public static void GameOver()
        {
            
            vidas = 0;
            ganhou = false;
            // Posicionamos o texto PERDEU logo no início da tela, cobrindo todo o conteúdo
            Texto.Posicionado(Texto.Perdeu(), 0, 0);
            Tecla(); // chama o metodo tecla
        }

        // Método Tecla() é responsável por receber inputs do jogador para decidir se jogará de novo ou sairá do jogo.
        public static ConsoleKey Tecla()
        {
            ConsoleKeyInfo teclaDigitada; // mesma coisa de antes
            ConsoleKey retorna = ConsoleKey.Escape; // cria uma variável do tipo ConsoleKey para retornar a tecla digitada
            do
            {
                teclaDigitada = Console.ReadKey(); // Le a tecla digitada
                if (teclaDigitada.Key == ConsoleKey.F9) // se for F9, reinicia o jogo
                {
                    NovoJogo(); // chama o método NovoJogo()
                }
                if (teclaDigitada.Key == ConsoleKey.Escape)
                    Environment.Exit(0);

            }
            while (teclaDigitada.Key != ConsoleKey.Escape); // enquanto for diferente de esq
            return retorna; // Retorns a tecla digitada pelo jogador
        }
    }

    // Classe Palavra
    class Palavra
    {
        public string Resposta { get; set; } // Armazena uma propriedade get/set para a palavra secreta que o jogador deverá acertar - Aprendi com meu amigo
        public List<string> Dicas = new List<string>(); // Armazena uma lista de strings das dicas para a palavra
    }

    // Classe Palavras é relacionado a classe Palavra
    class Palavras
    {
        // O método Sortear retorna um objeto da classe Palavra, e leva como argumento uma lista de palavras que podem ser sorteadas
        public static Palavra Sortear(List<Palavra> lista)
        {
            Random aleatorio = new Random(); // Criamos a variável 'aleatorio' para armazenar o valor aleatório
            int palavraSorteada = aleatorio.Next(lista.Count); // Criamos a variável 'id' para representar a chave da palavra sorteada na lista
            return lista[palavraSorteada]; // Retornamos a palavra com a chave sorteada
        }
    }

    // Classe Arquivo
    class Arquivo
    {
        
        // Método Carregar, abre o arquivo e expõe seu conteúdo. Leva como argumento o nome do arquivo.
        public static List<Palavra> Carregar(string arquivo)
        {
            var file = File.ReadAllText("jogo.txt"); // Lemos o arquivo
            var lines = file.Split(new char[] { '\n' }); // file.split serve para separar o arquivo por linhas
            int count = lines.Count(); //lines.count serve para contar quantas linhas têm no arquivo

            var palavras = new List<Palavra>(); // Cria uma variável para armazenar a lista de palavras
            string palavraSecreta = ""; //variável para armazenar a palavra secreta

            for (int i = 0; i < count; i++) // int cont tem a qtd. de linhas, então esse for é baseado nessa quantidade!
            {
                string[] linha = lines[i].Split(':'); // split serve para separar o indicador (P, D) pegando a partir do :
                if (linha[0] == "P") // Caso o indicador seja a letra P (palavra)
                {
                    palavras.Add(new Palavra { Resposta = linha[1] } ); // pega o que estiver com P e guarda

                    palavraSecreta = linha[1]; // Armazenamos a palavra secreta na variável
                }
                else // Se for D (dica)
                {
                    // Buscamos na lista de palavras todos os objetos que possuam a propriedade Resposta igual à variável - Aprendi com meu amigo
                    var palavra = palavras.Where(a => a.Resposta == palavraSecreta).ToList();
                
                    foreach (Palavra p in palavra)// Para cada palavra encontrada na busca, adicinoamos as dicas referentes a ela
                    {
                        p.Dicas.Add(linha[1]); // add = adiciona dica a propriedade Dicas (que é do tipo List<string>)
                    }
                }
            }
            return palavras; // Ao final da execução, retornamos a lista de palavras
        }
    }

    // Classe Texto
    class Texto
    {
        public static int inicioColuna, inicioLinha;

        public static void Posicionado(string texto, int coluna, int linha)
        {
            try
            {

                Console.SetCursorPosition(inicioColuna + coluna, inicioLinha + linha); // colocando o cursor na posição

                Console.WriteLine(texto);
                // Devolve o cursor à posição original - onde digita as letras
                Console.SetCursorPosition(Jogo.posicaoTecla, 6);
            }
            catch (ArgumentOutOfRangeException erro) // ArgumentOutOfRangeException verifica se tem erro
            {
                // Em caso de erro, limpamos o console e exibimos a mensagem
                Console.Clear();
                Console.WriteLine(erro.Message);
            }
        }
        
        // Método Ganhou()
        public static string Ganhou()
        {
            
            string texto = "     ------------------------------------------------------------------------- \n" +
                           "     #### KAMEHAMEHA!!... Deseja jogar novamente? F9 para Sim, ESC para sair #### \n" +
                           "     ------------------------------------------------------------------------- \n" +
                           "                ██████╗  █████╗ ███╗   ██╗██╗  ██╗ ██████╗ ██╗   ██╗ \n" +
                           "               ██╔════╝ ██╔══██╗████╗  ██║██║  ██║██╔═══██╗██║   ██║ \n" +
                           "               ██║  ███╗███████║██╔██╗ ██║███████║██║   ██║██║   ██║ \n" +
                           "               ██║   ██║██╔══██║██║╚██╗██║██╔══██║██║   ██║██║   ██║ \n" +
                           "               ╚██████╔╝██║  ██║██║ ╚████║██║  ██║╚██████╔╝╚██████╔╝ \n" +
                           "                ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝  \n" +
                           "     ------------------------------------------------------------------------- \n" +
                           "     ------------------------------------------------------------------------- \n\n\r" +

                           "             :+yhho++sssys/-             `yy:                                   \n" +
                           "                 .+s+`   `:oyy+.           ssy.                                 \n" +
                           "                    :h/       -sh+`        `d-y/                                \n" +
                           "                      sy`        :hs`       +s y/                               \n" +
                           "                       oh          :d+      :h `m.                              \n" +
                           "                        h+           oh`    +s  +o                              \n" +
                           "                        :N`           :d.   m-  :y                              \n" +
                           "        ```..-.         `N-            -d` os   +o                              \n" +
                           "             `-+oo:      m:             /o+h   `m`                              \n" +
                           "                 `/y+`  `N.              s+   `h:                               \n" +
                           "                    /h: /m               `    /soss+-                           \n" +
                           "        .:/+++oo++/:-`yod/                         -+ys:                        \n" +
                           "   ./sso+/-.`````.-:/+odo                             .sh:                      \n" +
                           " /so-                                                   .yy`                    \n" +
                           ":++oso:`                                                  +d`                   \n" +
                           "     `/ss:                                                 oy                   \n" +
                           "        `/yo`                                               ysssssssssssso+:-`  \n" +
                           "           -ys`                 .-                          `            ./sdmy:\n" +
                           "        ```  -h+              -o:                                  ./oooo/:.`   \n" +
                           "  :syo+++/++++omh`          -ho     --              .          .+so+:...``      \n" +
                           "  ``.:ooo:`     :+        `oh+   -ohy       .-     sy       :smmsoo++///odo     \n" +
                           "        `:ss-         `  `h:y  /s+`h.     `oy+   `soy/`   ./:.       `/o/`      \n" +
                           "           `+y/       :- y-ydos-   d`    .y.s-  +No+oN`            -ss-         \n" +
                           "              /h/     -d.d/NMMd/   s/   .h``d`+mMNyNhm`.        `+s+`           \n" +
                           "            -/++hd` :y/smh y.yyNd: `d` `h` ydNNyy`so-mo/y:   `/ss/:             \n" +
                           "           :ooo/```:y.-+od  ./ `+Md/-h`+/ /dMo` /-  oo+-.y:`omhodh.             \n" +
                           "               -+s:/y :-sh- `+  `dmhm/sm-mhmd.  +. .hs-: s/```+s-               \n" +
                           "                  :smo`/`sh  +-.``  `  ` `  ``.-+  hs`/`os`/so.                 \n" +
                           "                    .oh+.//o  ``.`     `    `.``  o++.+hmo+-                    \n" +
                           "                      .syosm:          s         -ms+ys-`                       \n" +
                           "                         ` .d`       .`-``.     `d. `                           \n" +
                           "                            .oo+.      ``    .+oo.                              \n" +
                           "                               ./oo:`    `:oo/.                                 \n" +
                           "                                   -oo//oo-                                     \n";


            return texto;
        }

        // Método Perdeu()
        public static string Perdeu()
        {
            
            string texto = "-------------------------------------------------------------------------- \n" +
                            "#### QUE PENA... Deseja jogar novamente? F9 para Sim, ESC para sair ##### \n" +
                            "------------------------------------------------------------------------- \n" +
                            "   ▄███████▄    ▄████████    ▄████████ ████████▄     ▄████████ ███    █▄  \n" +
                            "  ███    ███   ███    ███   ███    ███ ███   ▀███   ███    ███ ███    ███ \n" +
                            "  ███    ███   ███    █▀    ███    ███ ███    ███   ███    █▀  ███    ███ \n" +
                            "  ███    ███  ▄███▄▄▄      ▄███▄▄▄▄██▀ ███    ███  ▄███▄▄▄     ███    ███ \n" +
                            "▀█████████▀  ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ███    ███ ▀▀███▀▀▀     ███    ███ \n" +
                            "  ███          ███    █▄  ▀███████████ ███    ███   ███    █▄  ███    ███ \n" +
                            "  ███          ███    ███   ███    ███ ███   ▄███   ███    ███ ███    ███ \n" +
                            " ▄████▀        ██████████   ███    ███ ████████▀    ██████████ ████████▀  \n" +
                            "                            ███    ███                                    \n" +


                            "\n\n\n\n\n" +
                            "                                ..,,,::::::,..                         \n" +
                            "                         .:::,.     .....      .,::,.                  \n" +
                            "                       .::,.   ..............     ..::.                \n" +
                            "                     .::.   ........          ....   .::.              \n" +
                            "                   .::.  ......                        .,:.            \n" +
                            "                 .:..  ....                              ..:.          \n" +
                            "                .:.  .....   ..                            .:.         \n" +
                            "                :.  ......       .        ' ...              .:        \n" +
                            "               ,,.                 ...   ..                  ..        \n" +
                            "              .,                      .                       ..       \n" +
                            "              .. .:LqMBBBBBBSvi,      :.     ,; YkBBBBBBBB8j:.  .      \n" +
                            "              ..5EBBBBBBBBBBBBBBB2,   :,  :7MBBBBBUL0BBBBBBBJ:..       \n" +
                            "             .. BBBBBBMU:    8BBBBBr.   .,qBBBBB5     JBBBBBk.  .      \n" +
                            "              . .BBBBBB2     .BBBBB:    ..,BBMBBY     SBBBBBi. ..      \n" +
                            "             .,   :UOBBBBi  iBBBOBB.       OBOBBBBuY0BBB1r,  .,:,      \n" +
                            "             :;:.     r8BBBBBBBBBBi.           BBBBBBBBBP,   .:        \n" +
                            "            .r:.  .:     .ir7777i.  .        ,ii::.       ,::::::.     \n" +
                            "           .ri:ii  .u                                   v7  ....:7.    \n" +
                            "           i: .  L. r7          ..                     jr :;.   .,r    \n" +
                            "           7,  Y :r .P        ....           ...      rJ :1 .i, .i:.   \n" +
                            "           iJ::i ri ,S .......,..            .,,....  U7 7i J:  :::    \n" +
                            "           .ii, iY  2i ...,,,:,:..           .:::,... rk .v .i.,,i:    \n" +
                            "            .ri::.:ui ..,,,::::,,.           ..,::::.. u7 :Y::i;Lv     \n" +
                            "             .LY77Li.:::::::::  ...         ..  :iii:,..7LrrvJSFi      \n" +
                            "               ,v;..:::,:BJ  .   ..             ...YB7.......r,        \n" +
                            "                 ,  .....uB1.                    .2Bq....   .          \n" +
                            "                 .:.....  .BBX:     ......    .;FBB.      ..:          \n" +
                            "                  :,....    jBBBB85jLLLLJ2FNBBBBBP    .   .:.          \n" +
                            "                   :,  ....  :BBBBBOZ8MBBBBBBBBBr  ...   .,.           \n" +
                            "                    :,.        P              L:   .    .,,            \n" +
                            "                     :,..     :v              .j      ..,,             \n" +
                            "                          , .:      .....      ,..,                    \n" +
                            "                              ::.    ....     .i:                      \n" +
                            "                               .:ii::::,::::i;r.                       \n" +
                            "                                  .      ...    				        \n";



            return texto;
        }

        // Método Jigsaw(), ele que monta a imagem do personagem
        public static string Jigsaw(int codigo)
        {
        
            string[] jigsaw = new string[8]; // o tamanho é 8 devido a quantidade de vidas que eu estipulei para formar a imagem do jigsaw
            jigsaw[0] = "\n\n\n\n\n"+
                        "                                ..,,,::::::,..                         \n" +
                        "                         .:::,.     .....      .,::,.                  \n" +
                        "                       .::,.   ..............     ..::.                \n" +
                        "                     .::.   ........          ....   .::.              \n" +
                        "                   .::.  ......                        .,:.            \n";




            jigsaw[1] = "\n\n\n\n\n                 .:..  ....                              ..:.          \n" +
                        "                .:.  .....   ..                            .:.         \n" +
                        "                :.  ......       .        ' ...              .:        \n" +
                        "               ,,.                 ...   ..                  ..        \n" +
                        "              .,                      .                       ..       \n";



                
            jigsaw[2] = "\n\n\n\n\n               .. .:LqMBBBBBBSvi,      :.     ,; YkBBBBBBBB8j:.  .       \n" +
                        "              ..5EBBBBBBBBBBBBBBB2,   :,  :7MBBBBBUL0BBBBBBBJ:..       \n" +
                        "             .. BBBBBBMU:    8BBBBBr.   .,qBBBBB5     JBBBBBk.  .      \n" +
                        "              . .BBBBBB2     .BBBBB:    ..,BBMBBY     SBBBBBi. ..      \n" +
                        "             .,   :UOBBBBi  iBBBOBB.       OBOBBBBuY0BBB1r,  .,:,      \n";



            jigsaw[3] = "\n\n\n\n\n"+"             :;:.     r8BBBBBBBBBBi.           BBBBBBBBBP,   .:      \n" +
                        "            .r:.  .:     .ir7777i.  .        ,ii::.       ,::::::.     \n" +
                        "           .ri:ii  .u                                   v7  ....:7.    \n" +
                        "           i: .  L. r7          ..                     jr :;.   .,r    \n" +
                        "           7,  Y :r .P        ....           ...      rJ :1 .i, .i:.   \n";



            jigsaw[4] = "\n\n\n\n\n           iJ::i ri ,S .......,..            .,,....  U7 7i J:  :::    \n" +
                        "           .ii, iY  2i ...,,,:,:..           .:::,... rk .v .i.,,i:    \n" +
                        "            .ri::.:ui ..,,,::::,,.           ..,::::.. u7 :Y::i;Lv     \n" +
                        "             .LY77Li.:::::::::  ...         ..  :iii:,..7LrrvJSFi      \n" +
                        "               ,v;..:::,:BJ  .   ..             ...YB7.......r,        \n";



            jigsaw[5] = "\n\n\n\n\n                 ,  .....uB1.                    .2Bq....   .          \n" +
                        "                 .:.....  .BBX:     ......    .;FBB.      ..:          \n" +
                        "                  :,....    jBBBB85jLLLLJ2FNBBBBBP    .   .:.          \n" +
                        "                   :,  ....  :BBBBBOZ8MBBBBBBBBBr  ...   .,.           \n" +
                        "                    :,.        P              L:   .    .,,            \n" +
                        "                     :,..     :v              .j      ..,,             \n";
            jigsaw[6] = "\n\n\n\n\n                      :,...   1,     ....      1:   ...,:              \n" +
                        "                       :...  ,F       ..       :u   ...,               \n" +
                        "                        :..  Ur .     ..        P,  ..,                \n" +
                        "                         ir7,..      ...        rvi:                   \n" ;


            jigsaw[7] = "\n\n\n\n\n                          , .:      .....      ,..,                    \n" +
                        "                              ::.    ....     .i:                      \n" +
                        "                               .:ii::::,::::i;r.                       \n" +
                        "                                  .      ...    				        \n"; 

            return jigsaw[codigo]; // retorna o valor
        }
    }
}