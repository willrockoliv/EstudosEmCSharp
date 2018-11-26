using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace trabalhoN1
{
    class Program
    {
        public struct Candidato /// Estrutura do candidato
        {
            public int numero, totalVoto;
            public string nome, legenda;
            public char tipo;
        }

        #region posicionacursor
        static void PosicaoCursor(int a, int b)
        {
            Console.CursorLeft = a;
            Console.CursorTop = b;
        }
        #endregion
        #region vesetemcandidato
        static bool VerificaCand(int total, Candidato[] candidato, char X)
        {
            for (int n = 0; n < total; n++)
            {
                if (candidato[n].tipo == X)
                    return false;
            }
            return true;
        }
        #endregion
        #region desenhourna
        static void Urna()
        {
            Console.BackgroundColor = ConsoleColor.Gray;

            int top = 1, esq = 2;
            for (int n = 0; n < 20; n++)
            {
                PosicaoCursor(esq, top);
                Console.Write(" ");
                Thread.Sleep(1);
                top++;
            }

            for (int n = 0; n < 74; n++)
            {
                PosicaoCursor(esq, top);
                Console.Write(" ");
                Thread.Sleep(1);
                esq++;
            }

            for (int n = 0; n < 20; n++)
            {
                PosicaoCursor(esq, top);
                Console.Write(" ");
                Thread.Sleep(1);
                top--;
            }

            for (int n = 0; n < 74; n++)
            {
                PosicaoCursor(esq, top);
                Console.Write(" ");
                Thread.Sleep(1);
                esq--;
            }

            Console.BackgroundColor = ConsoleColor.White;
            top = 18;
            while (top <= 19)
            {
                esq = 46;
                for (int n = 0; n < 8; n++)
                {
                    PosicaoCursor(esq, top);
                    Console.Write(" ");
                    esq++;
                }
                top++;
            }

            Console.BackgroundColor = ConsoleColor.Red;
            top = 18;
            while (top <= 19)
            {
                esq = 56;
                for (int n = 0; n < 8; n++)
                {
                    PosicaoCursor(esq, top);
                    Console.Write(" ");
                    esq++;
                }
                top++;
            }

            Console.BackgroundColor = ConsoleColor.Green;
            top = 17;
            while (top <= 19)
            {
                esq = 66;
                for (int n = 0; n < 8; n++)
                {
                    PosicaoCursor(esq, top);
                    Console.Write(" ");
                    esq++;
                }
                top++;
            }

            Console.ResetColor();
        }
        #endregion
        #region textoUrna
        static void TextoUrna()
        {
            string urna = "*   * ***** *   * ******   * *   * **  * *   *" +
                "*   * *   * * * * *   **   * ****  *  ** ******   * *   * *   * *   ****** *   * *   * *   *";
            Console.ForegroundColor = ConsoleColor.Cyan;

            int aux = 0;
            int i = 0;
            Console.CursorTop = 4;
            for (int z = 1; z < 7; z++)
            {
                Console.CursorLeft = 27;
                for (int n = i; n < i + 23; n++)
                {
                    Console.Write(urna[n]);
                    if (urna[n] != ' ')
                        Thread.Sleep(2);
                    aux++;
                }
                Console.WriteLine();
                i = aux;
            }

            urna = "***** *     ***** ***** ****  ***** *   *   *   ***** ******     *     *       *   *   * *   * **  *   *   *     *   *" +
                "****  *     ****    *   ****  *   * * * *   *   *     ******     *     *       *   *   * *   * *  **   *   *     *   *" +
                "***** ***** *****   *   *   * ***** *   *   *   ***** *   *";

            aux = 0;
            i = 0;
            Console.CursorTop = 11;
            for (int z = 1; z < 6; z++)
            {
                Console.CursorLeft = 10;
                for (int n = i; n < i + 59; n++)
                {
                    Console.Write(urna[n]);
                    if (urna[n] != ' ')
                        Thread.Sleep(2);
                    aux++;
                }
                Console.WriteLine();
                i = aux;
            }

            PosicaoCursor(23, 23);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        #endregion
        #region VerificaçãoPartido
        static bool VerificaLegenda(string legen, string[] part)
        {
            for (int n = 0; n < part.Length; n++)
            {
                if (legen == part[n])
                    return false;
            }
            return true;
        }
        #endregion
        #region AvisoVermelho
        static void AvisoVermelho(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text + "\r\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
        #region AvisoVerde
        static void AvisoVerde(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
        #region ApagaVotos
        static void ApagaVotos(Candidato[] candidato, int total)
        {
            for (int n = 0; n < total; n++)
            {
                candidato[total].totalVoto = 0;
            }
        }
        #endregion
        #region Salva
        static void Salva(Candidato[] candidato, int total)
        {
            string tudo;

            File.Delete("candidatos.txt");
            for (int n = 0; n < total; n++)
            {
                tudo = candidato[n].numero + "\r\n" + candidato[n].nome + "\r\n" +
                       candidato[n].legenda + "\r\n" + candidato[n].tipo + "\r\n";
                File.AppendAllText("candidatos.txt", tudo, Encoding.Default);
            }
            AvisoVermelho("Candidatos exportados!");
        }
        #endregion
        #region VotoNumerico
        /// <summary>
        /// Voto quando apenas for digitado numero
        /// </summary>
        /// <param name="candidato"> STRUCT </param>
        /// <param name="total"> TOTAL DE CANDIDATOS</param>
        /// <param name="votoNum"> NUMERO DO VOTO </param>
        /// <param name="X"> X = LETRA PRA CONTROLE P/G </param>
        /// <returns></returns>
        static bool VotoNum(Candidato[] candidato, int total, int votoNum, char X)
        {
            for (int n = 0; n < total; n++)
            {
                if (votoNum == candidato[n].numero && candidato[n].tipo == X)
                {
                    candidato[n].totalVoto++;
                    AvisoVerde("Voto Computado!");
                    Thread.Sleep(200);
                    if (X == 'G')
                    {
                        AvisoVerde("Obrigado!");
                        Thread.Sleep(500);
                    }
                    Console.Clear();
                    return false;
                }
            }
            AvisoVermelho("Não existe candidato com este número!");
            return true;
        }
        #endregion
        #region VotoPartido
        static bool VotoPartido(Candidato[] candidato, int total, string voto, bool correto, char controle)
        {
            int auxp = 0, auxg = 0;
            for (int n = 0; n < total; n++)
            {
                if (candidato[n].legenda == voto && candidato[n].tipo == 'P')
                {
                    auxp = 1;
                    candidato[n].totalVoto++;
                    break;
                }
            }

            if (auxp == 1)
            {
                for (int n = 0; n < total; n++)
                {
                    if (candidato[n].legenda == voto && candidato[n].tipo == 'G')
                    {
                        auxg = 1;
                        candidato[n].totalVoto++;
                        break;
                    }
                }

                if (auxg == 1)
                {
                    AvisoVerde("Votos computados!");
                    Thread.Sleep(900);
                    Console.Clear();
                    return false;
                }
                else if (auxg == 0)
                {
                    AvisoVerde("Voto para presidente computado!");
                    AvisoVermelho("Este partido não tem candidato a governador!");
                    int votoNum = 0;
                    do
                    {
                        if (VerificaCand(total, candidato, 'G'))
                        {
                            AvisoVermelho("Não existem candidatos a governador! Pressione ENTER para continuar");
                            Console.ReadLine();
                            break;
                        }

                        do
                        {
                            Console.Write("Governadores disponíveis: ");

                            for (int n = 0; n < total; n++)
                            {
                                if (candidato[n].tipo == 'G')
                                    Console.Write(candidato[n].numero);
                                if (n < total - 1)
                                    Console.Write(", ");
                            }

                            try
                            {

                                Console.Write("\nDigite o número do candidato à governador: ");
                                votoNum = Convert.ToInt16(Console.ReadLine());
                                correto = false;
                            }
                            catch
                            {
                                AvisoVermelho("Digite apenas números!");
                                correto = true;
                            }
                        }
                        while (correto);

                        controle = 'G';
                        correto = VotoNum(candidato, total, votoNum, controle);
                    }
                    while (correto);

                    Thread.Sleep(200);
                    Console.Clear();
                    return false;
                }
            }
            else
            {
                AvisoVermelho("Não existe candidato à presidencia neste partido!");
                return true;
            }
            return true;
        }
        #endregion
        #region Apuração
        static void Apuracao(Candidato[] candidato, int total)
        {
            string ganhadorP = "", ganhadorG = "";
            int auxP = 0, auxG = 0;

            for (int n = 0; n < total; n++)
            {
                if (candidato[n].tipo == 'P')
                {
                    auxP = candidato[n].totalVoto; ////
                    if (candidato[n].totalVoto != 0)
                        ganhadorP = candidato[n].nome; //// CONTROLE DE VOTO PRESIDENTE
                    break;
                }
                else if (n == total - 1 && ganhadorP.Length == 0)
                {
                    ganhadorP = "Não há candidato";
                }
            }

            for (int n = 0; n < total; n++)
            {
                if (candidato[n].tipo == 'G')
                {
                    auxG = candidato[n].totalVoto; //// CONTROLE DE VOTO GOVERNADOR
                    if (candidato[n].totalVoto != 0)
                        ganhadorG = candidato[n].nome; ////
                    break;
                }
                else if (n == total - 1 && ganhadorG.Length == 0)
                {
                    ganhadorG = "Não há candidato";
                }
            }

            Console.WriteLine("Presidente: ");

            int t = 3;
            for (int n = 0; n < total; n++) //// GANHADORES
            {
                if (candidato[n].tipo == 'P')
                {
                    PosicaoCursor(2, t);
                    t++;
                    Console.WriteLine(candidato[n].nome);
                    PosicaoCursor(12, t);
                    t++;
                    if (candidato[n].totalVoto == 0)
                        Console.Write("Nenhum voto");
                    else
                    {
                        Console.Write(candidato[n].totalVoto);
                        if (candidato[n].totalVoto == 1)
                            Console.Write(" voto");
                        else
                            Console.Write(" votos");
                    }


                    if (candidato[n].totalVoto > auxP)
                    {
                        auxP = candidato[n].totalVoto;
                        ganhadorP = candidato[n].nome;
                    }
                    else if (candidato[n].totalVoto == auxP && candidato[n].nome != ganhadorP)
                    {
                        ganhadorP = ganhadorP + " e " + candidato[n].nome;
                    }
                }

                if (candidato[n].tipo == 'G')
                {
                    if (candidato[n].totalVoto > auxG)
                    {
                        auxG = candidato[n].totalVoto;
                        ganhadorG = candidato[n].nome;
                    }
                    else if (candidato[n].totalVoto == auxG && candidato[n].nome != ganhadorG)
                    {
                        ganhadorG = ganhadorG + " e " + candidato[n].nome;
                    }
                }
            }
            //-----------GOV
            Console.WriteLine();
            PosicaoCursor(40, 2);
            Console.WriteLine("Governador: ");
            t = 3;
            for (int n = 0; n < total; n++)
            {
                if (candidato[n].tipo == 'G')
                {
                    PosicaoCursor(42, t);
                    t++;
                    Console.WriteLine(candidato[n].nome);
                    PosicaoCursor(52, t);
                    t++;
                    if (candidato[n].totalVoto == 0)
                        Console.Write("Nenhum voto");
                    else
                    {
                        Console.Write(candidato[n].totalVoto);
                        if (candidato[n].totalVoto == 1)
                            Console.Write(" voto");
                        else
                            Console.Write(" votos");
                    }
                }
            }
            //------------------
            Console.WriteLine();
            AvisoVerde("\nGanhador(es) para presidente: " + ganhadorP + "\nGanhador(es) para governador: " + ganhadorG);

        }
        #endregion

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            PosicaoCursor(32, 11);
            AvisoVermelho("André Paxiega");
            PosicaoCursor(34, 12);
            AvisoVermelho("032147621");
            PosicaoCursor(31, 23);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Pressione ENTER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Urna();
            TextoUrna();

            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.White;

            Candidato[] candidato = new Candidato[16];
            string[] partido = { "PT", "PSDB", "PL", "PRONA", "DEMOCRATAS", "PV", "PMDB", "PCO" };
            int total = 0, totalOld = 0, auxCadastro = 0;
            bool correto = false, temCand;
            char resp = 'a';

            if (File.Exists("candidatos.txt"))  //verificação de arquivo
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Existe um arquivo com candidatos, deseja importar? <s/n>");
                        resp = Console.ReadLine().ToLower().Trim()[0];
                        correto = false;
                    }
                    catch
                    {
                        Console.WriteLine("Digite apenas \"s\" ou \"n\"!");
                        correto = true;
                    }
                } while (correto);

                if (resp == 's')
                {
                    string[] linha = File.ReadAllLines("candidatos.txt", Encoding.Default);
                    total = linha.Length / 4;
                    totalOld = total;

                    if (total > 16)
                    {
                        total = 16;
                        AvisoVermelho("Arquivo contém mais que 16 candidatos, serão importados somente os 16 primeiros!");
                    }

                    int aux2 = 0;  // SIMPLES CONTROLE
                    for (int n = 0; n < linha.Length; n++)
                    {
                        int aux = n % 4;

                        switch (aux)
                        {
                            case 0:
                                candidato[aux2].numero = Convert.ToInt16(linha[n]);
                                break;
                            case 1:
                                candidato[aux2].nome = linha[n];
                                break;
                            case 2:
                                candidato[aux2].legenda = linha[n];
                                break;
                            case 3:
                                candidato[aux2].tipo = linha[n][0];
                                break;
                        }
                        if (aux == 3)
                            aux2++;
                    }
                    AvisoVerde(total + " candidatos carregados!");
                }
            }

            //cadastro ------------------------------------------------

            do
            {
                if (total == 16)
                {
                    AvisoVermelho("Todas as vagas estão preenchidas, a etapa de cadastramento será pulada para a votação");
                    break;
                }

                bool correto1 = false;
                do
                {
                    try
                    {
                        Console.WriteLine("\nDeseja cadastrar candidatos?" +
                                          "\nSenão partiremos para a votação se hover candidatos! <s/n>");
                        resp = Console.ReadLine().ToLower().Trim()[0];
                        correto1 = false;
                    }
                    catch
                    {
                        Console.WriteLine("Digite apenas s ou n!");
                    }
                }
                while (correto1);

                if (resp == 's')
                {
                    Console.Clear();

                    // CADASTRO NUMERO ---------------------------------

                    do
                    {
                        try
                        {
                            correto = false;
                            Console.Write("Digite o número do candidato: ");
                            candidato[total].numero = Convert.ToInt16(Console.ReadLine());

                            for (int n = 0; n < total; n++)
                            {
                                if (candidato[total].numero == candidato[n].numero)
                                {
                                    correto = true;
                                    AvisoVermelho("Já existe um candidato com este número!");
                                    break;
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Digite apenas números!");
                            correto = true;
                        }
                    }
                    while (correto);

                    // CADASTRO NOME ------------------------------------

                    do
                    {
                        Console.Write("Digite o nome do candidato: ");
                        candidato[total].nome = Console.ReadLine();
                    }
                    while (candidato[total].nome.Length == 0);

                    // CADASTRO PARTIDO ---------------------------------

                    do
                    {
                        Console.Write("Digite um partido (PT, PSDB, PL, PRONA, DEMOCRATAS, PV, PMDB, PCO): ");
                        candidato[total].legenda = Console.ReadLine().ToUpper();

                        correto = VerificaLegenda(candidato[total].legenda, partido);
                        if (correto == false)
                        {
                            auxCadastro = 0;

                            for (int n = 0; n < total; n++)
                                if (candidato[total].legenda == candidato[n].legenda)
                                {
                                    auxCadastro++;
                                    if (auxCadastro == 2)
                                        break;
                                }

                            if (auxCadastro >= 2)
                                AvisoVermelho("Já existem dois candidatos deste partido.");
                        }
                    }
                    while (correto || (auxCadastro >= 2));

                    // CADASTRO CARGO -----------------------------------

                    do
                    {
                        Console.WriteLine("Digite o cargo: <p/g>");
                        candidato[total].tipo = Console.ReadLine().ToUpper()[0];

                        auxCadastro = 0;
                        for (int n = 0; n < total; n++)
                            if (candidato[total].legenda == candidato[n].legenda)
                                if (candidato[n].tipo == candidato[total].tipo)
                                {
                                    auxCadastro++;
                                    Console.WriteLine("Um candidato já existe neste cargo!");
                                }
                    }
                    while ((candidato[total].tipo != 'P' && candidato[total].tipo != 'G') || auxCadastro == 1);
                    total++;
                }
            }
            while (resp == 's');

            //------GRAVAR NO ARQUIVO DEVOLTA-------------------------------------------
            Console.Clear();
            AvisoVermelho("EXPORTAÇÃO");

            if ((!VerificaCand(total, candidato, 'P') || !VerificaCand(total, candidato, 'G')) && (total != totalOld))
            {
                bool respE = true;
                do
                {
                    try
                    {
                        Console.WriteLine("\nDeseja exportar os candidatos? <s/n>");
                        resp = Console.ReadLine().ToLower().Trim()[0];
                        respE = false;
                    }
                    catch
                    {
                        AvisoVermelho("Digite apenas s ou n!");
                        respE = true;
                    }
                }
                while (respE);

                if (resp == 's')
                    Salva(candidato, total);
            }
            else if ((!VerificaCand(total, candidato, 'P') || !VerificaCand(total, candidato, 'G')) && total == totalOld)
            {
                AvisoVerde("Não teve alterações nos candidatos, não será necessário exportar!\nPressione ENTER para continuar");
                Console.ReadLine();
            }
            else
            {
                AvisoVermelho("Sem candidatos para exportar!\nPressione ENTER para contiuar!");
                Console.ReadLine();
            }
            //---------MODO DE VOTAÇÃO--------------------------------------------------

            Console.Clear();
            ApagaVotos(candidato, total);
            AvisoVermelho("MODO VOTAÇÃO");

            int pessoas = 0, votoNum = 0;
            string resposta = "", voto = "";
            char controle;
            bool candi, gov = true;
            temCand = true;

            do
            {
                if (total < 1)
                {
                    AvisoVerde("Não há candidatos.\nPressione ENTER para continuar!");
                    temCand = false;
                    Console.ReadLine();
                    break;
                }

                do
                {
                    if (VerificaCand(total, candidato, 'P'))
                    {
                        AvisoVermelho("Não tem candidato a presidencia!");
                        gov = true;
                        break;
                    }
                    Console.WriteLine("Desejar votar pelo número do candidato a presidencia ou pelo partido? \n<numero/partido>");
                    resposta = Console.ReadLine().Trim().ToLower();
                }
                while (resposta != "numero" && resposta != "partido");

                if (resposta == "numero")
                {
                    /////// NUMERO PRESIDENTE

                    candi = false;
                    do
                    {
                        do
                        {
                            Console.Write("Presidentes disponíveis: ");

                            for (int n = 0; n < total; n++)
                            {
                                if (candidato[n].tipo == 'P')
                                    Console.Write(candidato[n].numero);
                                if (n < total - 1)
                                    Console.Write(", ");
                            }

                            try
                            {
                                Console.Write("\nDigite o número do candidato à presidencia: ");
                                votoNum = Convert.ToInt16(Console.ReadLine());
                                correto = false;
                            }
                            catch
                            {
                                Console.WriteLine("Digite apenas números!");
                                correto = true;
                            }
                        }
                        while (correto);

                        controle = 'P';
                        candi = VotoNum(candidato, total, votoNum, controle);
                    }
                    while (candi);
                }
                else if (resposta == "partido") ////// PARTIDO
                {
                    correto = false;
                    do
                    {
                        Console.WriteLine("\nPartidos: PT, PSDB, PL, PRONA, DEMOCRATAS, PV, PMDB, PCO");
                        Console.Write("Digite o partido que deseja votar: ");
                        voto = Console.ReadLine().ToUpper().Trim();

                        controle = ' ';
                        correto = VotoPartido(candidato, total, voto, correto, controle);
                    }
                    while (correto); /// SETAR A VARIAVEL CORRETO PARA FALSE LÁ DENTRO ///
                }

                if (resposta == "numero" || gov)
                {
                    ////// NUMERO GOVERNADOR

                    do
                    {
                        if (VerificaCand(total, candidato, 'G'))
                        {
                            AvisoVermelho("Não tem candidato a governador!");
                            break;
                        }

                        Console.Write("Governadores disponíveis: ");

                        for (int n = 0; n < total; n++)
                        {
                            if (candidato[n].tipo == 'G')
                                Console.Write(candidato[n].numero);
                            if (n < total - 1)
                                Console.Write(", ");
                        }

                        do
                        {
                            try
                            {
                                Console.Write("\nDigite o número do candidato à governador: ");
                                votoNum = Convert.ToInt16(Console.ReadLine());
                                correto = false;
                            }
                            catch
                            {
                                Console.WriteLine("Digite apenas números!");
                                correto = true;
                            }
                        }
                        while (correto);

                        controle = 'G';
                        candi = VotoNum(candidato, total, votoNum, controle);
                    }
                    while (candi);
                }

                pessoas++;

                do
                {
                    Console.WriteLine("Deseja continuar votando? <s/n>");
                    resp = Console.ReadLine().ToLower().Trim()[0];
                }
                while (resp != 's' && resp != 'n');
            }
            while (resp != 'n' && pessoas <= 100);

            Console.Clear();
            if (temCand)
            {
                AvisoVermelho("\tMODO APURAÇÃO");
                Apuracao(candidato, total);
            }
            else
            {
                AvisoVermelho("Não há candidatos para apuração, pressione ENTER para sair!");
            }
            Console.ReadLine();
        }
    }
}