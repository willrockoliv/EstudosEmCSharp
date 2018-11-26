using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Testes
{
    class Program
    {
        #region Constants
        const string MENU_ACTION_PLAY = "play";
        const string MENU_ACTION_CONFIG = "config";
        const string INITIAL_MESSAGE = "Descubra a palavra e não deixe Cartman detonar a bomba";
        const string MENU_VIEW = "menuView";
        const string CONFIGUTATION_VIEW = "configurationView";
        const string GAME_VIEW = "gameView";
        const string LOOSER_VIEW = "looser_view";
        const string TIP_TEXT = "Pressione F2 para visualizar uma nova dica. (Você perderá uma vida.)";
        const int INTIAL_LIFES = 6;
        const int INITAL_TIMER = 45;
        #endregion

        #region Configuration Parameters
        static bool enableTimer         = true; // habilita o timer
        static bool enableTip           = true; // habilita as dicas
        static int lifes;                       // número de vidas do jogador
        #endregion

        #region Game Properties
        static int frameRate            = 60;   // Condifuração utilizada no Thread.Sleep()
        static string activatedView;            // Armazena a tela que está sendo exibida
        static GameData gameData;               // É a palavra e suas dicas
        static ConsoleKeyInfo pressedKey;       // armazena a tecla pressionada pelo usuário
        static int nTip = 0;                    // número de dicas sendo exibidas na tela
        static string chars = String.Empty;     // armazena as letras já escolhidas pelo usuário
        static int rightAnswers = 0;
        static int cartmanLeft = 1;
        static int cartmanFactor;
        static Timer gameTimer;
        static int currTime;
        static bool timeOut = false;

        public struct GameData
        {
            public string word;
            public List<string> tips;
            public GameData(string[] data)
            {
                word = String.Empty;
                tips = new List<string>();
                formatGameData(data);
            }

            private void formatGameData(string[] data)
            {
                string tempData = data[new Random().Next(1, data.Length)];
                data = Regex.Split(tempData, "D:");
                for (int i = 0; i < data.Length; i++)
                {
                    if (i == 0)
                    {
                        word = data[i].ToUpper().Trim();
                        Console.WriteLine(word);
                    }
                    else
                    {
                        tips.Add(data[i].Trim());
                    }
                }
            }
        }
        #endregion

        #region Menu View
        static void CreateMenuView()
        {
            Console.Clear();
            activatedView = MENU_VIEW;
            string menuAction = MENU_ACTION_PLAY;
            Console.CursorVisible = false;

            DrawLogo(0, 12, true);
            DrawCartman(11, 1, true);
            DrawBomb(17, 62, true);
            CreatePlayButtom(menuAction, true);
            CreateConfigButtom(menuAction, true);
            Console.SetCursorPosition(alignCenter(INITIAL_MESSAGE.Length), 10);
            Console.Write(INITIAL_MESSAGE);
            CreateFooter();
            do
            {
                pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.UpArrow:
                        // toggle menuAction
                        menuAction = menuAction == MENU_ACTION_PLAY ? MENU_ACTION_CONFIG : MENU_ACTION_PLAY;

                        CreatePlayButtom(menuAction, false);
                        CreateConfigButtom(menuAction, false);
                        break;
                    case ConsoleKey.Enter:
                        if (menuAction == MENU_ACTION_PLAY)
                        {
                            CreateGameView();
                        }
                        else if (menuAction == MENU_ACTION_CONFIG)
                        {
                            CreateConfigurationView();
                        }
                        break;
                    default:
                        break;
                }
            } while (activatedView == MENU_VIEW);
        }

        // Menu Buttons
        static void CreatePlayButtom(string menuAction, bool animate)
        {
            Console.CursorTop = 12;
            int left;
            if (menuAction == MENU_ACTION_PLAY)
            {
                left = alignCenter(("(y) PLAY (y)").Length);
                MyConsole(left, " _        _", animate);
                MyConsole(left, "(y) PLAY (y)", animate);
                MyConsole(left, " =        =", animate);
            }
            else
            {
                left = alignCenter(("    PLAY    ").Length);
                MyConsole(left, "            ", animate);
                MyConsole(left, "    PLAY    ", animate);
                MyConsole(left, "            ", animate);
            }

        }

        static void CreateConfigButtom(string menuAction, bool animate)
        {
            Console.CursorTop = 15;
            int left;
            if (menuAction == MENU_ACTION_CONFIG)
            {
                left = alignCenter(("(y) CONFIG (y)").Length);
                MyConsole(left, " _          _", animate);
                MyConsole(left, "(y) CONFIG (y)", animate);
                MyConsole(left, " =          =", animate);
            }
            else
            {
                left = alignCenter(("    CONFIG    ").Length);
                MyConsole(left, "              ", animate);
                MyConsole(left, "    CONFIG    ", animate);
                MyConsole(left, "              ", animate);
            }

        }

        static void CreateFooter()
        {
            string text = "Rodrigo Nappi - RA: 082150354";
            Console.SetCursorPosition(alignCenter(text.Length), 23);
            Console.Write(text);
        }
        #endregion

        #region Game View
        static void CreateGameView()
        {
            Console.Clear();
            activatedView = GAME_VIEW;
            cartmanLeft = 1;
            cartmanFactor = Convert.ToInt32((62 - 26) / lifes);

            // carrega o arquivo de texto
            try
            {
                string[] textData = Regex.Split(File.ReadAllText("jogo.txt"), "P:");
                gameData = new GameData(textData);
            }
            catch (Exception)
            {
                Console.WriteLine("Arquivo de texto não encontrado. Pressione ENTER para finalizar.");
            }

            DrawGameView();
            // verifica se o cronometro deve ser criado
            if (enableTimer)
            {
                gameTimer = new Timer(TimeTest, null, 1000, 1000);
            }
            do
            {
                pressedKey = Console.ReadKey(true);
                // verifica se a tecla pressionada foi uma letra
                if (Char.IsLetter(pressedKey.KeyChar))
                {
                    char currChar = pressedKey.KeyChar.ToString().ToUpper()[0];
                    int charIndex = gameData.word.IndexOf(currChar);
                    if (chars.IndexOf(currChar) < 0)
                    {
                        chars += currChar;

                        if (charIndex < 0)
                        {
                            RemoveLife();
                        }
                        DrawGameView();
                    }
                    else
                    {
                        ShowWarning("Warning: Está letra já foi escolhida.");
                    }
                }
                switch (pressedKey.Key)
                {
                    case ConsoleKey.F2:
                        if (enableTip && gameData.tips.Count-1 > nTip)
                        {
                            nTip ++;
                            RemoveLife();
                            DrawGameView();
                        }
                        break;
                    default:
                        break;
                }
            } while (activatedView == GAME_VIEW);
        }

        static void DrawGameView()
        {
            Console.Clear();
            rightAnswers = 0;
            PrintLifes();
            PrintWord();
            ShowTips();
            DrawCartman(12, cartmanLeft, false);
            DrawBomb(19, 62, false);
            CheckFinish();
        }

        static void RemoveLife()
        {
            lifes--;
            if (lifes < 0)
            {
                lifes = 0;
            }
            else
            {
                cartmanLeft += cartmanFactor;
            }
        }

        static void ShowTips()
        {
            Console.CursorTop = 7;
            for (int i = 0; i <= nTip; i++)
            {
                Console.CursorLeft = 2;
                Console.WriteLine("DICA{0}: {1}", i+1, gameData.tips[i]);
            }
            if (enableTip && nTip < gameData.tips.Count - 1)
            {
                Console.CursorLeft = 2;
                Console.WriteLine(TIP_TEXT);
            }
            else if (nTip >= gameData.tips.Count - 1)
            {
                ShowWarning("Você já utilizou todas as dicas disponíveis.");
            }
        }

        static void ShowWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(2,6);
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void PrintLifes()
        {
            if(lifes <= 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Vidas restantes: {0}", lifes);
            Console.ResetColor();
        }

        static void PrintWord()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(2, 4);
            Console.Write("PALAVRA: ");
            for (int i = 0; i < gameData.word.Length; i++)
            {
                int charIndex = chars.IndexOf(gameData.word[i]);
                if (charIndex >= 0)
                {
                    rightAnswers++;
                    Console.Write(chars[charIndex]);
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.ResetColor();
        }

        static void CheckFinish()
        {
            if (rightAnswers == gameData.word.Length)
            {
                if(enableTimer) gameTimer.Dispose();
                CreateWinnerView();
            }
            else if (lifes == 0 || timeOut)
            {
                if(enableTimer) gameTimer.Dispose();
                CreateLooserView();
            }
        }

        static void TimeTest(object state)
        {
            currTime--;
            Console.SetCursorPosition(2,0);
            Console.WriteLine("Tempo restante: {0}",currTime);
            if (currTime < 0)
            {
                timeOut = true;
                CheckFinish();
            }
        }
        #endregion

        #region FinalsViews
        static void CreateLooserView()
        {
            activatedView = LOOSER_VIEW;
            Console.Clear();
            DrawLogo(0, 12, true);
            DrawCartman(9, 13, false);
            DrawBomb(16, 48, true);
            ExplodeBomb(9, 38, true);
            Console.ForegroundColor = ConsoleColor.Red;
            MyConsole(22, alignCenter("Você Perdeu!".Length), "Você Perdeu!", false);
            Console.ResetColor();
            MyConsole(23, alignCenter("Jogar novamente? (Y) (N)".Length), "Jogar novamente? (Y) (N)", false);
      
            do
            {
                pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Y:
                        Main();
                        break;
                    case ConsoleKey.N:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (activatedView == LOOSER_VIEW);
        }

        static void CreateWinnerView()
        {
            activatedView = LOOSER_VIEW;
            Console.Clear();
            DrawLogo(0, 12, true);
            DrawCartman(9, 1, true);
            DrawBomb(15, 62, true);
            Console.ForegroundColor = ConsoleColor.Green;
            MyConsole(22, alignCenter("PARABÉNS! Você ganhou!".Length), "PARABÉNS! Você ganhou!", false);
            Console.ResetColor();
            MyConsole(23, alignCenter("Jogar novamente? (Y) (N)".Length), "Jogar novamente? (Y) (N)", false);

            do
            {
                pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Y:
                        Main();
                        break;
                    case ConsoleKey.N:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (activatedView == LOOSER_VIEW);
        }
        #endregion

        #region Configuration View
        static void CreateConfigurationView()
        {
            Console.Clear();
            activatedView = CONFIGUTATION_VIEW;
            DrawLogo(0, 12, false);
            refreshConfigurationView();
            MyConsole(19, 16, "Pressione o [Número] correspondente para alterar", false);
            MyConsole(20, 25, "Pressione [Enter] para confirmar", false);
            Console.CursorTop = 21;
            do
            {
                pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.D1:
                        // toggle timer
                        enableTimer = !enableTimer;
                        refreshConfigurationView();
                        break;
                    case ConsoleKey.D2:
                        // toggle tip
                        enableTip = !enableTip;
                        refreshConfigurationView();
                        break;
                    case ConsoleKey.Enter:
                        CreateMenuView();
                        break;
                    default:
                        break;
                }
            } while (activatedView == CONFIGUTATION_VIEW);
        }

        static void refreshConfigurationView()
        {
            MyConsole(12, 25, "(1) Habilitar Cronometro: " + (enableTimer ? "SIM" : "NÃO"), false);
            MyConsole(13, 25, "(2) Habilitar Dicas: " + (enableTip ? "SIM" : "NÃO"), false);
        }
        #endregion

        #region Utils
        static int alignCenter(int textLen)
        {
            return (int)Math.Round((double)(Console.BufferWidth - textLen) / 2);
        }

        static void MyConsole(int top, int left, string text, bool animate = false)
        {
            Console.SetCursorPosition(left, top);
            MyConsole(left, text, animate);
        }

        static void MyConsole(int left, string text, bool animate = false)
        {
            Console.CursorLeft = left;
            Console.WriteLine(text);
            if (animate) Thread.Sleep(frameRate);
        }
        #endregion

        #region Game Elements        
        // game logo
        static void DrawLogo(int top, int left, bool animate)
        {
            Console.SetCursorPosition(left, top);
            MyConsole(top, left, " ________  ________  ________  _____ ______   ___       ", animate);
            MyConsole(left, "|\\   __  \\|\\   __  \\|\\   __  \\|\\   _ \\  _   \\|\\  \\      ", animate);
            MyConsole(left, "\\ \\  \\|\\ /\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\\\\\__\\ \\  \\ \\  \\     ", animate);
            MyConsole(left, " \\ \\   __  \\ \\  \\\\\\  \\ \\  \\\\\\  \\ \\  \\\\|__| \\  \\ \\  \\    ", animate);
            MyConsole(left, "  \\ \\  \\|\\  \\ \\  \\\\\\  \\ \\  \\\\\\  \\ \\  \\    \\ \\  \\ \\__\\   ", animate);
            MyConsole(left, "   \\ \\_______\\ \\_______\\ \\_______\\ \\__\\    \\ \\__\\|__|", animate);
            MyConsole(left, "    \\|_______|\\|_______|\\|_______|\\|__|     \\|__|  ___", animate);
            MyConsole(left, "                                                  |\\__\\", animate);
            MyConsole(left, "                                                  \\|__| ", animate);
        }

        // cartman
        static void DrawCartman(int top, int left, bool animate)
        {
            MyConsole(top, left, "           _,", animate);
            MyConsole(left, "       _.-{__}-._", animate);
            MyConsole(left, "     .:-'`____`'-:.", animate);
            MyConsole(left, "    /_.-\"`_  _`\"-._\\", animate);
            MyConsole(left, "   /`   / .\\/. \\   `\\", animate);
            MyConsole(left, "   |    \\__/\\__/    |", animate);
            MyConsole(left, " .-\\                >-.", animate);
            MyConsole(left, "/   '._-.__--__.-_.'   \\", animate);
            MyConsole(left, "\\   /  `\"\"\"\"\"\"\"\"`'`\\   /", animate);
            MyConsole(left, " \\ |        '       | /", animate);
            MyConsole(left, "  `_________'________`", animate);
            MyConsole(left, "  ____________________", animate);
        }

        // bomb
        static void DrawBomb(int top, int left, bool animate)
        {
            MyConsole(top, left, "    ,--.!,", animate);
            MyConsole(left, "  __/   -*-", animate);
            MyConsole(left, ",d08b.  '|`", animate);
            MyConsole(left, "0088MM", animate);
            MyConsole(left, "`9MMP'", animate);
        }

        static void ExplodeBomb(int top, int left, bool animate)
        {
            MyConsole(top + 4, left, "         ..-^~~~^-..", animate);
            MyConsole(left, "       .~           ~.          ", animate);
            MyConsole(left, "      (;:           :;)         ", animate);
            MyConsole(left, "       (:           :)          ", animate);
            MyConsole(left, "         ':._   _.:'            ", animate);
            MyConsole(left, "             | |                ", animate);
            MyConsole(left, "             | |                ", animate);
            MyConsole(left, "          ((/   \\))            ", animate);

            MyConsole(top + 1, left, "      _.-^^---....,,-- ", animate);
            MyConsole(left, "  _--                  --_      ", animate);
            MyConsole(left, " <                        >)    ", animate);
            MyConsole(left, " |                         |    ", animate);
            MyConsole(left, "`  \\._                   _./'  ", animate);
            MyConsole(left, "     ```--. . , ; .--'''        ", animate);
            MyConsole(left, "           | |   |              ", animate);
            MyConsole(left, "        .-=||  | |=-.           ", animate);
            MyConsole(left, "        `-=#$%&%$#=-'           ", animate);
            MyConsole(left, "           | ;  :|              ", animate);
            MyConsole(left, "  _____.,-#%&$@%#&#~,._____     ", animate);

            MyConsole(top, left, "              ____         ", animate);
            MyConsole(left, "      __,-~~/~    `---.         ", animate);
            MyConsole(left, "    _/_,---(      ,    )        ", animate);
            MyConsole(left, "__ /        <    /   )  \\_     ", animate);
            MyConsole(left, "====------------------===;;;=   ", animate);
            MyConsole(left, "   \\/  ~\"~\"~\"~\"~\"~\\~\"~)~\" / ", animate);
            MyConsole(left, "   (_ (   \\  (     >    \\)    ", animate);
            MyConsole(left, "    \\_( _ <         >_>'       ", animate);
            MyConsole(left, "       ~ `-i' ::>|--\"          ", animate);
            MyConsole(left, "           I;|.|.|              ", animate);
            MyConsole(left, "          <|i::|i|`.            ", animate);
            MyConsole(left, "         (` ^'\"`-' \")         ", animate);
        }
        #endregion

        static void Main()
        {
            lifes = INTIAL_LIFES;
            currTime = INITAL_TIMER;
            rightAnswers = 0;
            chars = String.Empty;
            nTip = 0;
            timeOut = false;
            CreateMenuView();
        }
    }
}