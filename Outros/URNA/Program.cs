using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_N1
{
    class Program
    {
        struct Candidatos
        {
            public int num, qvotos;
            public string nome, legenda;
            public char tipo;
        }
        #region Metodos
        static bool Perguntar(string mensagem)
        {
            string resp;            
            do
            {
                EscreverAmarelo("\n Deseja " + mensagem + " (S/N) ");
                resp = Console.ReadLine().Trim().ToUpper();
                if (resp != "S" && resp != "N")
                    EscreverVermelho(" Digite \'s\' ou \'n\' apenas...");
            }
            while(resp!= "S" && resp!= "N");
            Console.Clear();
            if (resp=="S")
		        return true;
	        else					
		        return false;	
        }

        static bool VerificaPeG(Candidatos[] candidato, int limite, int pres, int gov)
        {
            if (Perguntar("cadastrar mais candidatos?") == false)
            {
                for (int h = 0; h < limite; h++) // Verifica se há ao menos 1 presidente e 1 governador
                {
                    if (candidato[h].tipo == 'P')
                        pres++;
                    if (candidato[h].tipo == 'G')
                        gov++;
                    if (pres != 0 && gov != 0) // Caso ele encontre 1 presidente e 1 governador ele não perderá tempo...
                        break; // ... com busca desnecessária
                }
                if (pres != 0 && gov != 0)
                    return true;
                if (pres == 0 && gov != 0)
                    EscreverVermelho(" É necessário cadastrar ao menos 1 Presidente. Pressione ENTER...");
                if (pres != 0 && gov == 0)
                    EscreverVermelho(" É necessário cadastrar ao menos 1 Governador. Pressione ENTER...");
                if (pres == 0 && gov == 0)
                    EscreverVermelho(" É necessário cadastrar ao menos 1 Presidente e 1 Governador. Pressione ENTER...");
                Console.ReadLine(); // Para o usuário ler a mensagem
                Console.Clear();
                return false;
            }
            return false;
        }

        static bool VerificaSeRepete(Candidatos[] candidato, string funcao, int a)
        {
            int repete = 0;
            if (funcao == "numero")
                for (int b = 0; b <= a; b++)
                {
                    if (candidato[a].num == candidato[b].num) // Verifica se o número já foi digitado
                        repete++;
                    if (repete > 2)
                    {
                        EscreverVermelho(" Já existem candidatos cadastrados nesse mesmo número, favor cadastrar outro!");
                        return false;
                    }
                }
            if (funcao == "legenda")
                for (int c = 0; c <= a; c++)
                {
                    if (candidato[a].legenda == candidato[c].legenda) // Verifica se a legenda já foi digitada
                        repete++;
                    if (repete > 2)
                    {
                        EscreverVermelho(" Já existem candidatos cadastrados nesse mesmo partido, favor cadastrar outro!");
                        return false;
                    }
                    if (candidato[a].legenda != candidato[c].legenda && candidato[a].num == candidato[c].num)
                    {
                        EscreverVermelho(" Já existe um partido atribuído ao número digitado!");
                        return false;
                    }
                    if (candidato[a].legenda == candidato[c].legenda && candidato[a].num != candidato[c].num)
                    {
                        EscreverVermelho(" Já existe um número atribuído ao partido digitado!");
                        return false;
                    }
                }
            if (funcao == "tipo")
                for (int d = 0; d <= a; d++)
                {
                    if (candidato[a].legenda == candidato[d].legenda && candidato[a].tipo == candidato[d].tipo) // Verifica se o tipo já...
                        repete++;                                                                              //... existe na legenda
                    if (repete > 1)
                    {
                        EscreverVermelho(" Já existe esse tipo de candidato pertencente desta legenda!");
                        return false;
                    }
                }
            return true;
        }

        static bool VerificaVoto(Candidatos[] candidato, int p, char cargo, string voto)
        {

            if (candidato[p].legenda == voto && candidato[p].tipo == cargo)
            {
                candidato[p].qvotos++;
                return true;
            }
            if (candidato[p].num.ToString() == voto && candidato[p].tipo == cargo)
            {
                candidato[p].qvotos++;
                return true;
            }
            return false;
        }

        static void Apuracao (char candidatura, int limite, Candidatos[] candidato, int maisvotado, int totalvotos)
        {
            bool empate = false;
            int qntde = 0;
            for (int c = 0; c < limite; c++)
            {
                if (candidatura == 'p' && candidato[c].qvotos == maisvotado && candidato[c].tipo == 'P')
                    qntde++;

                if (candidatura == 'g' && candidato[c].qvotos == maisvotado && candidato[c].tipo == 'G')
                    qntde++;
                if (qntde > 1)
                    empate = true;
            }
            string msg;
            if (empate == true)
            {
                System.Threading.Thread.Sleep(1000);
                EscreverAmarelo(msg = " ** Houve um empate entre " + qntde + " candidatos:\n\n");
            }
            double res = Convert.ToDouble(maisvotado)* 100 / Convert.ToDouble(totalvotos);
            for (int x = 0; x < limite; x++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                if ((candidatura == 'p' && candidato[x].qvotos == maisvotado && candidato[x].tipo == 'P') ||
                    (candidatura == 'g' && candidato[x].qvotos == maisvotado && candidato[x].tipo == 'G'))
                {
                    ExibirLento(msg= " * "+candidato[x].nome+" - "+candidato[x].legenda+".");
                    ExibirLento("    Votos: "+candidato[x].qvotos+".");
                    System.Threading.Thread.Sleep(700);
                    Console.Write("    {0:F2}", res);
                    ExibirLento(" % do total de votos.");
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        static void ExibirLento(string msg)
        {
            for (int x = 0; x < msg.Length; x++)
            {
                Console.Write(msg[x]);
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine();
        }               

        static void EscreverVermelho(string texto)
        {
            ConsoleColor cor = Console.ForegroundColor; // Guarda a cor atual na variável cor
            Console.ForegroundColor = ConsoleColor.Red; // Altera a cor atual para vermelho
            Console.WriteLine(texto); // Escreve o texto em vermelho
            Console.ForegroundColor = cor; // Restaura a cor que estava antes de executar o método.
        }

        static void EscreverVerde(string texto)
        {
            ConsoleColor cor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine(texto);
            Console.ForegroundColor = cor; 
        }

        static void EscreverAmarelo(string texto)
        {
            ConsoleColor cor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(texto);
            Console.ForegroundColor = cor;
        }
        #endregion
        static void Main(string[] args)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                //nome no centro
                Console.CursorTop = 10;
                Console.CursorLeft = 26;
                Console.WriteLine("Guilherme Marques de Freitas");
                Console.CursorLeft = 36;
                Console.Write("032147743\n\n\n");
                Console.ReadLine();
                Console.Clear();
                Candidatos[] candidato = new Candidatos[16];
                const int MAX = 16;
                bool correto = false;
                int qinicio = 0, qfinal, totalvotos = 0, pres = 0, gov = 0;
                #region Importar arquivo
                if (File.Exists("CANDIDATOS.txt"))
                {
                    EscreverVerde(" Arquivo com candidatos cadastrados encontrado!");
                    if (Perguntar(" importar dados já existentes?") == true)
                    {
                        string[] arquivo = File.ReadAllLines("CANDIDATOS.txt", Encoding.Default);
                        if (arquivo.Length <= 64) // 4 linhas para cada candidato, ou seja, num máximo de 16 candidatos haverá 64 linhas
                        {
                            int linha = 0;
                            for (int z = 0; z < arquivo.Length / 4; z++)
                            {
                                candidato[z].num = Convert.ToInt32(arquivo[linha]);
                                linha++;
                                candidato[z].nome = arquivo[linha];
                                linha++;
                                candidato[z].legenda = arquivo[linha];
                                linha++;
                                candidato[z].tipo = arquivo[linha][0];
                                linha++;
                                qinicio++;
                            }
                            qfinal = qinicio;
                            if (arquivo.Length != 64)
                            {
                                EscreverVerde(" Arquivo importado com sucesso.");
                                correto = VerificaPeG(candidato, qfinal, pres, gov);
                            }
                            else
                            {
                                EscreverVerde(" Arquivo importado com sucesso.\n Todos os 16 candidatos já foram cadastrados.");
                                correto = true;
                            }
                        }
                        else
                        {
                            EscreverVermelho(" Arquivo inválido. Pressione ENTER para cadastrar novos candidatos... ");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
                #endregion
                qfinal = qinicio;
                if (!correto)
                {
                    #region Cadastro de Candidatos
                    for (int a = qinicio; a < MAX; a++)
                    {
                        EscreverVerde("\n\t\t\t     CADASTRO DE CANDIDATOS\n");
                        #region Numero candidatos
                        do
                        {
                            try
                            {
                                Console.Write("\n Informe o número do candidato: ");
                                candidato[a].num = Convert.ToInt32(Console.ReadLine());
                                correto = VerificaSeRepete(candidato, "numero", a);
                            }
                            catch
                            {
                                EscreverVermelho(" Digite apenas números.");
                                correto = false;
                            }
                        }
                        while (!correto);
                        #endregion
                        #region Nome candidatos
                        do
                        {
                            Console.Write("\n Informe o nome do candidato: ");
                            candidato[a].nome = Console.ReadLine().Trim();
                            if (candidato[a].nome == "")
                            {
                                EscreverVermelho(" Digite um nome válido!");
                                correto = false;
                            }
                            else
                                correto = true;
                        }
                        while (!correto);
                        #endregion
                        #region Legenda candidatos
                        do
                        {
                            Console.Write("\n Informe a legenda: ");
                            candidato[a].legenda = Console.ReadLine().Trim().ToUpper();
                            if (candidato[a].legenda != "PT" && candidato[a].legenda != "PSDB" &&
                                candidato[a].legenda != "PL" && candidato[a].legenda != "PRONA" &&
                                candidato[a].legenda != "PV" && candidato[a].legenda != "DEM" &&
                                candidato[a].legenda != "PCO" && candidato[a].legenda != "PMDB")
                            {
                                EscreverVermelho(" Digite um partido válido: PT, PSDB, PL, PRONA, DEM, PV, PMDB ou PCO.");
                                correto = false;
                            }
                            else
                            {
                                correto = VerificaSeRepete(candidato, "legenda", a);
                            }

                        }
                        while (!correto);
                        #endregion
                        #region Tipo candidatos
                        do
                        {
                            try
                            {
                                Console.Write("\n Informe o tipo: ");
                                candidato[a].tipo = Convert.ToChar(Console.ReadLine().Trim().ToUpper());
                                correto = true;
                            }
                            catch
                            {
                            }

                            if ((candidato[a].tipo != 'P' && candidato[a].tipo != 'G') || !correto)
                            {
                                EscreverVermelho(" Digite P para presidente ou G para governador!");
                                correto = false;
                            }
                            else
                            {
                                correto = VerificaSeRepete(candidato, "tipo", a);
                            }

                        }
                        while (!correto);
                        qfinal++;
                        EscreverVerde("\n Candidato cadastrado com sucesso!");
                        #endregion
                        if (qfinal < MAX)
                            if (VerificaPeG(candidato, qfinal, pres, gov) == true)
                                break;
                    }
                    #endregion
                    #region Salvar arquivo
                    if (Perguntar("salvar os candidatos cadastrados?") == true)
                    {
                        File.WriteAllText("CANDIDATOS.txt", ""); // limpa/subscreve o arquivo já existente para salvar por cima
                        for (int e = 0; e < qfinal; e++)
                        {
                            File.AppendAllText("CANDIDATOS.txt", candidato[e].num.ToString() + "\r\n" + candidato[e].nome + "\r\n" +
                                                candidato[e].legenda + "\r\n" + candidato[e].tipo.ToString() + "\r\n", Encoding.Default);
                            // \r\n e Environment.NewLine exercem a mesma função -> passar para a próxima linha
                            // AppendAllText faz com que o arquivo não seja subescrevido
                        }
                        EscreverVerde("\n Arquivo salvo com sucesso. Pressione ENTER para prosseguir...");
                    }
                    #endregion
                }
                #region Votacao
                string voto, msg;
                for (int j = 0; j < 100; j++)
                {
                    EscreverVerde("\n\t\t\t\t    VOTAÇÃO\n");
                    EscreverAmarelo(" Lista de candidatos:\n\n");
                    for (int l = 0; l < qfinal; l++)
                        EscreverAmarelo(msg = " * Candidato: " + candidato[l].nome + " - Número: " + candidato[l].num + " - Legenda: " +
                                                candidato[l].legenda + " - Tipo: " + candidato[l].tipo + "\n\n");
                    bool votop = false, votog = false;
                    Console.WriteLine();
                    do
                    {
                        votog = false;
                        int posvoto = 0;
                        Console.Write(" Digite o número do candidato a presidência ou a legenda: ");
                        voto = Console.ReadLine().Trim().ToUpper();
                        Console.WriteLine();
                        for (int p = 0; p < qfinal; p++)
                        {
                            if(VerificaVoto(candidato, p, 'P', voto)==true)
                                votop=true;
                            if (candidato[p].legenda == voto && candidato[p].tipo == 'G')
                            {
                                candidato[p].qvotos++;
                                posvoto = p;
                                votog = true;
                            }
                            //votop = VerificaVoto(candidato, p, 'P', voto);
                            if (candidato[p].num.ToString() == voto && candidato[p].tipo == 'P')
                            {
                              //  candidato[p].qvotos++;
                              //  votop = true;
                                EscreverVerde(" Voto computado.");
                                break;
                            }
                            if (p == qfinal - 1 && !votop)
                            {
                                EscreverVermelho(" O número ou a legenda foi digitado incorretamente!\n");
                                if(votog == true)
                                    candidato[posvoto].qvotos--;
                            }
                            if (p == qfinal - 1 && votop == true && !votog)
                            {
                                EscreverVerde(" Voto computado apenas para Presidente.");
                                EscreverVermelho("\n Não existe Governador cadastrado nessa legenda!");
                            }
                        }
                    }
                    while (!votop);
                    if (votop == votog) // ambos serão true - > votop==true && votog==true 
                        EscreverVerde(msg = " O voto computado para Presidente e Governador através da legenda " + voto + ".");
                    if (!votog)
                    {
                        do
                        {
                            Console.Write("\n Digite o número do candidato a governância ou a legenda: ");
                            voto = Console.ReadLine().Trim().ToUpper();
                            Console.WriteLine();
                            for (int p = 0; p < qfinal; p++)
                            {
                                if (VerificaVoto(candidato, p, 'G', voto) == true)
                                {
                                    votog = true;
                                    break;
                                }
                            }

                        }
                        while (!votog);
                        EscreverVerde(" Voto computado.");
                    }
                    totalvotos++;
                    EscreverVerde("\n Obrigado por votar.");
                    if (j < 99) // ou totalvoto<100
                        if (Perguntar("votar novamente?") == false)
                            break;
                }
                #endregion                
                #region Apuração
                EscreverVerde("\n\t\t\t\t   APURAÇÃO\n");
                System.Threading.Thread.Sleep(1000);
                EscreverAmarelo(msg = " Votos apurados: " + totalvotos + "\n\n");
                int maiorvotop = 0, maiorvotog = 0;
                for (int p = 0; p < qfinal; p++) // Verifica qual a maior quantidade de votos que um candidato possui, tanto P quanto G
                {
                    if (candidato[p].qvotos > maiorvotop && candidato[p].tipo == 'P')
                        maiorvotop = candidato[p].qvotos;
                    if (candidato[p].qvotos > maiorvotog && candidato[p].tipo == 'G')
                        maiorvotog = candidato[p].qvotos;
                }
                System.Threading.Thread.Sleep(1000);
                EscreverVerde(" ► Presidência:\n");
                Apuracao('p', qfinal, candidato, maiorvotop, totalvotos);
                System.Threading.Thread.Sleep(1000);
                EscreverVerde(" ► Governância:\n");
                Apuracao('g', qfinal, candidato, maiorvotog, totalvotos);
                #endregion
                Console.WriteLine();
            }
            while (Perguntar("utilizar o software novamente?") == true);
            EscreverVermelho("\n Obrigado por utilizar este software. Pressione ENTER para fechá-lo...");
            Console.ReadLine();
        }                      
    }
}
