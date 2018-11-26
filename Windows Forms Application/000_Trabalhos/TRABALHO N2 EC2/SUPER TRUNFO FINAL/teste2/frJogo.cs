using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace teste2
{

    public partial class frJogo : Form
    {/// <summary>
     /// Método que recebe uma variavel inteira e com base no valor, o computador seleciona qual progressBar irá escolher.
     /// </summary>
     /// <param name="Natributo"></param>Variavel inteira recebida de outro método que define qual o atributo escolhido.
     /// <param name="atributo"></param>Variavel inteira que recebe o valor da ProgressBar para comparação entre cartas.
     /// <param name="Sono"></param> Refere-se a ProgressBar Sono do computador.
     /// <param name="Fome"></param>Refere-se a ProgressBar Fome do computador.
     /// <param name="Raiva"></param>Refere-se a ProgressBar Raiva do computador.
     /// <param name="Malandragem"></param>Refere-se a ProgressBar Malandragem do computador.
     /// <param name="Humanas"></param>Refere-se a ProgressBar Humanas do computador.
        static void EscolheProgress(ref int Natributo, ref int atributo, ProgressBar Sono, ProgressBar Fome, ProgressBar Raiva, ProgressBar Malandragem, ProgressBar Humanas)
        {
            if (Natributo == 1)
                atributo = Sono.Value;
            else if (Natributo == 2)
                atributo = Fome.Value;
            else if (Natributo == 3)
                atributo = Raiva.Value;
            else if (Natributo == 4)
                atributo = Malandragem.Value;
            else
                atributo = Humanas.Value;
        }
        /// <summary>
        /// Método que faz com que o computador jogue de acordo com a dificuldade escolhida, onde o computador análisa
        /// o vetor de struct com as cartas do computador e faz sua escolha.
        /// </summary>
        /// <param name="dificuldade"></param>Variavel do tipo Char com a dificuldade escolhida
        /// <param name="CartasComp"></param>Vetor de struct com as cartas do computador.
        /// <param name="escolhaComp"></param>Varivel do tipo inteiro que armazenará um valor referente ao 
        /// atributo escolhido.
        /// <param name="Natributo"></param>Variavel do tipo inteiro que armazenará um numero referente ao 
        /// atributo escolhido
        static void ComputadorJoga(char dificuldade, Cartas[] CartasComp, ref int escolhaComp, ref int Natributo)
        {
            int menor, medio, maior, sono, fome, raiva, malandragem, humanas;
            sono = CartasComp[0].sono;
            fome = CartasComp[0].fome;
            raiva = CartasComp[0].raiva;
            malandragem = CartasComp[0].malandragem;
            humanas = CartasComp[0].humanas;
            if (dificuldade == 'F')
            {
                menor = sono;
                if (fome < menor && fome < raiva && fome < malandragem && fome < humanas)
                {
                    menor = fome;
                    Natributo = 2;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Fome!", Encoding.Default);
                }
                else if (raiva < menor && raiva < malandragem && raiva < humanas)
                {
                    menor = raiva;
                    Natributo = 3;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Fúria!", Encoding.Default);
                }
                else if (malandragem < menor && malandragem < humanas)
                {
                    menor = malandragem;
                    Natributo = 4;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Sagacidade!", Encoding.Default);
                }
                else if (humanas < menor)
                {
                    menor = humanas;
                    Natributo = 5;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Humanas!", Encoding.Default);
                }
                else if (menor == sono)
                {
                    escolhaComp = menor;
                    Natributo = 1;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Sono!", Encoding.Default);
                }
                escolhaComp = menor;
            }
            else if (dificuldade == 'D')
            {
                maior = sono;
                if (fome > maior && fome > raiva && fome > malandragem && fome > humanas)
                {
                    maior = fome;
                    Natributo = 2;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Fome!", Encoding.Default);
                }
                else if (raiva > maior && raiva > malandragem && raiva > humanas)
                {
                    maior = raiva;
                    Natributo = 3;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Fúria!", Encoding.Default);
                }
                else if (malandragem > maior && malandragem > humanas)
                {
                    maior = malandragem;
                    Natributo = 4;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Sagacidade!", Encoding.Default);
                }
                else if (humanas > maior)
                {
                    maior = humanas;
                    Natributo = 5;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Humanas!", Encoding.Default);
                }
                else if (maior == sono)
                {
                    escolhaComp = maior;
                    Natributo = 1;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Sono!", Encoding.Default);
                }
                escolhaComp = maior;
            }
            else
            {
                Random sorteio = new Random();
                int choice = sorteio.Next(1, 6);
                if (choice == 1)
                {
                    medio = sono;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Sono!", Encoding.Default);
                    Natributo = 1;
                    escolhaComp = sono;
                }
                else if (choice == 2)
                {
                    medio = fome;
                    Natributo = 2;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Fome!", Encoding.Default);
                    escolhaComp = fome;
                }
                else if (choice == 3)
                {
                    medio = raiva;
                    Natributo = 3;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Fúria!", Encoding.Default);
                    escolhaComp = raiva;
                }
                else if (choice == 4)
                {
                    medio = malandragem;
                    Natributo = 4;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Sagacidade!", Encoding.Default);
                    escolhaComp = malandragem;
                }
                else
                {
                    medio = humanas;
                    Natributo = 5;
                    File.WriteAllText("escolha.txt", "O Computador Escolheu Humanas!", Encoding.Default);
                    escolhaComp = humanas;
                }
                escolhaComp = medio;
            }
        }
        /// <summary>
        /// Método que lê o arquivo txt de configuração e determina a dificuldade escolhida pelo usuário.
        /// </summary>
        /// <param name="dificuldade"></param>Variavel do tipo char de acordo com a dificuldade escolhida.
        static void VerificaDificuldade(ref char dificuldade)
        {
            string txt = File.ReadAllText("Cfg.txt").Trim();
            string[] txtvetor = txt.Trim().Split('|');
            if (txtvetor[2] == "True")
                dificuldade = 'F';
            else if (txtvetor[3] == "True")
                dificuldade = 'M';
            else if (txtvetor[4] == "True")
                dificuldade = 'D';
        }
        /// <summary>
        /// Método que verifica quem ganhou o jogo.
        /// </summary>
        /// <param name="vitoria"></param>Condição booleana que informa quem ganhou o jogo.
        /// <param name="pontofinal"></param>Váriavel inteira que armazena a pontuação do vencedor.
        /// <param name="cartajogador"></param>Vetor de struct com as cartas do jogador.
        /// <param name="cartacomputador"></param>Vetor de struct com as cartas do computador.
        /// <param name="tempo"></param>Timer Geral do jogo
        /// <param name="pontojog"></param>Variavel inteira que contém a quantidade de pontos do jogador.
        /// <param name="pontocomp"></param>Variavel inteira que contém a quantidade de pontos do computador.
        /// <returns></returns>
        static bool VerificaGanhador(ref bool vitoria, ref int pontofinal, Cartas[] cartajogador,
            Cartas[] cartacomputador, Timer tempo, int pontojog, int pontocomp)
        {
            bool fim = false;
            if (cartacomputador.Length < 1 || cartajogador.Length < 1)
            {
                tempo.Dispose();

                if (cartacomputador.Length < 1)
                {
                    pontofinal = pontojog;
                    MessageBox.Show("PARABÉNS, VOCÊ VENCEU !!!", "VENCEU", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    File.WriteAllText("PontuacaoFinal.txt", Convert.ToString(pontofinal));
                    fim = true;
                }
                else if (cartajogador.Length < 1)
                {
                    MessageBox.Show("NÃO FOI DESSA VEZ...", "TENTE DE NOVO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    fim = true;
                    vitoria = false;
                }
            }
            return fim;
        }
        /// <summary>
        /// Método que aumenta o tamanho do vetor ganhador e insere no baralho ganhador a carta ganha na rodada e
        /// diminui o tamanho do vetor perdedor.
        /// </summary>
        /// <param name="cartacomputador"></param>Vetor de struct que contém as cartas do computador.
        /// <param name="cartajogador"></param>Vetor de struct que contém as cartas do jogador.
        /// <param name="cartaPerdida"></param>Vetor de struct que contém a carta perdida na rodada.
        /// <param name="vencedor"></param>Variavel do tipo char que informa o ganhador da rodada.
        /// <param name="rodada"></param>Variavel do tipo inteiro que informa a rodada a ser análisada.
        static void InsereCarta(ref Cartas[] cartacomputador, ref Cartas[] cartajogador, Cartas[] cartaPerdida, 
            char vencedor, int rodada)
        {
            if (vencedor == 'J')
            {
                Array.Resize(ref cartajogador, cartajogador.Length + 1);
                cartajogador[cartajogador.Length - 1].codigo = cartajogador[0].codigo;
                cartajogador[cartajogador.Length - 1].nome = cartajogador[0].nome;
                cartajogador[cartajogador.Length - 1].sono = cartajogador[0].sono;
                cartajogador[cartajogador.Length - 1].fome = cartajogador[0].fome;
                cartajogador[cartajogador.Length - 1].raiva = cartajogador[0].raiva;
                cartajogador[cartajogador.Length - 1].malandragem = cartajogador[0].malandragem;
                cartajogador[cartajogador.Length - 1].humanas = cartajogador[0].humanas;
                cartajogador[cartajogador.Length - 1].imagem = cartajogador[0].imagem;
                for (int n = 0; n < cartajogador.Length - 1; n++)
                {
                    cartajogador[n].codigo = cartajogador[n + 1].codigo;
                    cartajogador[n].nome = cartajogador[n + 1].nome;
                    cartajogador[n].sono = cartajogador[n + 1].sono;
                    cartajogador[n].fome = cartajogador[n + 1].fome;
                    cartajogador[n].raiva = cartajogador[n + 1].raiva;
                    cartajogador[n].malandragem = cartajogador[n + 1].malandragem;
                    cartajogador[n].humanas = cartajogador[n + 1].humanas;
                    cartajogador[n].imagem = cartajogador[n + 1].imagem;
                }
                cartajogador[cartajogador.Length - 1].codigo = cartaPerdida[0].codigo;
                cartajogador[cartajogador.Length - 1].nome = cartaPerdida[0].nome;
                cartajogador[cartajogador.Length - 1].sono = cartaPerdida[0].sono;
                cartajogador[cartajogador.Length - 1].fome = cartaPerdida[0].fome;
                cartajogador[cartajogador.Length - 1].raiva = cartaPerdida[0].raiva;
                cartajogador[cartajogador.Length - 1].malandragem = cartaPerdida[0].malandragem;
                cartajogador[cartajogador.Length - 1].humanas = cartaPerdida[0].humanas;
                cartajogador[cartajogador.Length - 1].imagem = cartaPerdida[0].imagem;

                for (int n = 0; n < cartacomputador.Length - 1; n++)
                {
                    cartacomputador[n].codigo = cartacomputador[n + 1].codigo;
                    cartacomputador[n].nome = cartacomputador[n + 1].nome;
                    cartacomputador[n].sono = cartacomputador[n + 1].sono;
                    cartacomputador[n].fome = cartacomputador[n + 1].fome;
                    cartacomputador[n].raiva = cartacomputador[n + 1].raiva;
                    cartacomputador[n].malandragem = cartacomputador[n + 1].malandragem;
                    cartacomputador[n].humanas = cartacomputador[n + 1].humanas;
                    cartacomputador[n].imagem = cartacomputador[n + 1].imagem;
                }
                Array.Resize(ref cartacomputador, cartacomputador.Length - 1);
            }
            else if (vencedor == 'C')
            {
                Array.Resize(ref cartacomputador, cartacomputador.Length + 1);
                cartacomputador[cartacomputador.Length - 1].codigo = cartacomputador[0].codigo;
                cartacomputador[cartacomputador.Length - 1].nome = cartacomputador[0].nome;
                cartacomputador[cartacomputador.Length - 1].sono = cartacomputador[0].sono;
                cartacomputador[cartacomputador.Length - 1].fome = cartacomputador[0].fome;
                cartacomputador[cartacomputador.Length - 1].raiva = cartacomputador[0].raiva;
                cartacomputador[cartacomputador.Length - 1].malandragem = cartacomputador[0].malandragem;
                cartacomputador[cartacomputador.Length - 1].humanas = cartacomputador[0].humanas;
                cartacomputador[cartacomputador.Length - 1].imagem = cartacomputador[0].imagem;
                for (int n = 0; n < cartacomputador.Length - 1; n++)
                {
                    cartacomputador[n].codigo = cartacomputador[n + 1].codigo;
                    cartacomputador[n].nome = cartacomputador[n + 1].nome;
                    cartacomputador[n].sono = cartacomputador[n + 1].sono;
                    cartacomputador[n].fome = cartacomputador[n + 1].fome;
                    cartacomputador[n].raiva = cartacomputador[n + 1].raiva;
                    cartacomputador[n].malandragem = cartacomputador[n + 1].malandragem;
                    cartacomputador[n].humanas = cartacomputador[n + 1].humanas;
                    cartacomputador[n].imagem = cartacomputador[n + 1].imagem;
                }
                cartacomputador[cartacomputador.Length - 1].codigo = cartaPerdida[0].codigo;
                cartacomputador[cartacomputador.Length - 1].nome = cartaPerdida[0].nome;
                cartacomputador[cartacomputador.Length - 1].sono = cartaPerdida[0].sono;
                cartacomputador[cartacomputador.Length - 1].fome = cartaPerdida[0].fome;
                cartacomputador[cartacomputador.Length - 1].raiva = cartaPerdida[0].raiva;
                cartacomputador[cartacomputador.Length - 1].malandragem = cartaPerdida[0].malandragem;
                cartacomputador[cartacomputador.Length - 1].humanas = cartaPerdida[0].humanas;
                cartacomputador[cartacomputador.Length - 1].imagem = cartaPerdida[0].imagem;

                for (int n = 0; n < cartajogador.Length - 1; n++)
                {
                    cartajogador[n].codigo = cartajogador[n + 1].codigo;
                    cartajogador[n].nome = cartajogador[n + 1].nome;
                    cartajogador[n].sono = cartajogador[n + 1].sono;
                    cartajogador[n].fome = cartajogador[n + 1].fome;
                    cartajogador[n].raiva = cartajogador[n + 1].raiva;
                    cartajogador[n].malandragem = cartajogador[n + 1].malandragem;
                    cartajogador[n].humanas = cartajogador[n + 1].humanas;
                    cartajogador[n].imagem = cartajogador[n + 1].imagem;
                }
                Array.Resize(ref cartajogador, cartajogador.Length - 1);
            }
            else
            {
                Array.Resize(ref cartajogador, cartajogador.Length + 1);
                Array.Resize(ref cartacomputador, cartacomputador.Length + 1);

                cartajogador[cartajogador.Length - 1].codigo = cartacomputador[0].codigo;
                cartajogador[cartajogador.Length - 1].nome = cartacomputador[0].nome;
                cartajogador[cartajogador.Length - 1].sono = cartacomputador[0].sono;
                cartajogador[cartajogador.Length - 1].fome = cartacomputador[0].fome;
                cartajogador[cartajogador.Length - 1].raiva = cartacomputador[0].raiva;
                cartajogador[cartajogador.Length - 1].malandragem = cartacomputador[0].malandragem;
                cartajogador[cartajogador.Length - 1].humanas = cartacomputador[0].humanas;
                cartajogador[cartajogador.Length - 1].imagem = cartacomputador[0].imagem;

                cartacomputador[cartacomputador.Length - 1].codigo = cartajogador[0].codigo;
                cartacomputador[cartacomputador.Length - 1].nome = cartajogador[0].nome;
                cartacomputador[cartacomputador.Length - 1].sono = cartajogador[0].sono;
                cartacomputador[cartacomputador.Length - 1].fome = cartajogador[0].fome;
                cartacomputador[cartacomputador.Length - 1].raiva = cartajogador[0].raiva;
                cartacomputador[cartacomputador.Length - 1].malandragem = cartajogador[0].malandragem;
                cartacomputador[cartacomputador.Length - 1].humanas = cartajogador[0].humanas;
                cartacomputador[cartacomputador.Length - 1].imagem = cartajogador[0].imagem;

                for (int n = 0; n < cartajogador.Length - 1; n++)
                {
                    cartajogador[n].codigo = cartajogador[n + 1].codigo;
                    cartajogador[n].nome = cartajogador[n + 1].nome;
                    cartajogador[n].sono = cartajogador[n + 1].sono;
                    cartajogador[n].fome = cartajogador[n + 1].fome;
                    cartajogador[n].raiva = cartajogador[n + 1].raiva;
                    cartajogador[n].malandragem = cartajogador[n + 1].malandragem;
                    cartajogador[n].humanas = cartajogador[n + 1].humanas;
                    cartajogador[n].imagem = cartajogador[n + 1].imagem;
                }
                
                for (int n = 0; n < cartacomputador.Length - 1; n++)
                {
                    cartacomputador[n].codigo = cartacomputador[n + 1].codigo;
                    cartacomputador[n].nome = cartacomputador[n + 1].nome;
                    cartacomputador[n].sono = cartacomputador[n + 1].sono;
                    cartacomputador[n].fome = cartacomputador[n + 1].fome;
                    cartacomputador[n].raiva = cartacomputador[n + 1].raiva;
                    cartacomputador[n].malandragem = cartacomputador[n + 1].malandragem;
                    cartacomputador[n].humanas = cartacomputador[n + 1].humanas;
                    cartacomputador[n].imagem = cartacomputador[n + 1].imagem;
                }
                Array.Resize(ref cartajogador, cartajogador.Length - 1);
                Array.Resize(ref cartacomputador, cartacomputador.Length - 1);
            }
        }
        /// <summary>
        /// Método que armazena em um vetor de struct a carta perdida na rodada.
        /// </summary>
        /// <param name="cartaPerdida"></param>Vetor que armazenará a carta perdida e seus atributos.
        /// <param name="cartajogador"></param>Vetor de struct com as informações da carta do jogador.
        /// <param name="cartacomputador"></param>Vetor de struct com as informações da carta do computador.
        /// <param name="vencedor"></param>Variavel do tipo char que informa quem ganhou a rodada.
        /// <param name="rodada"></param>Variavel do tipo inteiro que informa a rodada a ser análisada.
        static void CartaPerdida(ref Cartas[] cartaPerdida, Cartas[] cartajogador, Cartas[] cartacomputador, 
            char vencedor, ref int rodada)
        {
            if (vencedor == 'J')
            {
                cartaPerdida[rodada].codigo = cartacomputador[rodada].codigo;
                cartaPerdida[rodada].nome = cartacomputador[rodada].nome;
                cartaPerdida[rodada].sono = cartacomputador[rodada].sono;
                cartaPerdida[rodada].fome = cartacomputador[rodada].fome;
                cartaPerdida[rodada].raiva = cartacomputador[rodada].raiva;
                cartaPerdida[rodada].malandragem = cartacomputador[rodada].malandragem;
                cartaPerdida[rodada].humanas = cartacomputador[rodada].humanas;
                cartaPerdida[rodada].imagem = cartacomputador[rodada].imagem;
            }
            else if (vencedor == 'C')
            {
                cartaPerdida[rodada].codigo = cartajogador[rodada].codigo;
                cartaPerdida[rodada].nome = cartajogador[rodada].nome;
                cartaPerdida[rodada].sono = cartajogador[rodada].sono;
                cartaPerdida[rodada].fome = cartajogador[rodada].fome;
                cartaPerdida[rodada].raiva = cartajogador[rodada].raiva;
                cartaPerdida[rodada].malandragem = cartajogador[rodada].malandragem;
                cartaPerdida[rodada].humanas = cartajogador[rodada].humanas;
                cartaPerdida[rodada].imagem = cartajogador[rodada].imagem;
            }
        }
        /// <summary>
        /// Método que processa o resultado da rodada em questão, através de uma variavel do tipo char o método 
        /// modifica a pontuação dos jogadores, para o cronometro geral e da rodada, modifica a quantidade
        /// de cartas e apresenta uma tela com as informações do vencedor.
        /// </summary>
        /// <param name="contador2"></param>Variavel inteira que contém a quantidade de segundos decorridos na rodada.
        /// <param name="min2"></param>Variavel inteira que contém a quantidade de minutos acumulados na rodada.
        /// <param name="seg2"></param>Variavel inteira que contém a quantidade de segundos acumulados na rodada.
        /// <param name="cartajog"></param> TextBox que contém a quantidade de cartas do Jogador.
        /// <param name="cartacomp"></param>TextBox que contém a quantidade de cartas do Computador.
        /// <param name="vez"></param>condição booleana que alterna quem joga na próxima rodada.
        /// <param name="tempo"></param>Timer geral do jogo.
        /// <param name="tempoPontos"></param>Timer da rodada.
        /// <param name="textovencedor"></param>variavel do tipo String que armazena a informação do vencedor da rodada
        /// <param name="Vencedor"></param>Variavel do tipo Char recebida que informa quem ganhou a rodada.
        /// <param name="pontojog"></param>Váriavel do tipo inteiro que contém a quantidade de pontos do Jogador.
        /// <param name="pontocomp"></param>Váriavel do tipo inteiro que contém a quantidade de pontos do computador.
        /// <param name="PontosJog"></param>TextBox que contém a quantidade de pontos do jogador.
        /// <param name="PontosComp"></param>TextBox que contém a quantidade de pontos do Computador.
        /// <param name="cartasJog"></param>Painel com informações da carta do jogador
        /// <param name="cartasComp"></param>Painel com informações da carta do computador.
        /// <param name="cartajogador"></param>Vetor de cartas do jogador a ser análisado
        /// <param name="cartacomputador"></param>Vetor de cartas do computador a ser análisado
        static void ProcessaRodada(ref int contador2,ref int min2, ref int seg2, Panel cartajog, Panel cartacomp, ref bool vez, ref Timer tempo, ref Timer tempoPontos,
            ref string textovencedor, char Vencedor, ref int pontojog, ref int pontocomp, ref TextBox PontosJog, ref TextBox PontosComp, 
            ref TextBox cartasJog, ref TextBox cartasComp, Cartas[] cartajogador, Cartas[] cartacomputador)
        {
            tempo.Dispose();
            tempoPontos.Dispose();
            int total = (min2 / 60) + seg2;
            min2 = 0;
            seg2 = 0;
            contador2 = 0;
            if (Vencedor == 'J')
            {
                pontojog += 1000 / total;
                textovencedor = "O Jogador venceu!";
                vez = true;
            }
            else if (Vencedor == 'C')
            {
                pontocomp += 1000 / total;
                textovencedor = "O Computador venceu!";
                vez = false;
            }
            else
            {
                pontocomp += 500 / total;
                pontojog += 500 / total;
                textovencedor = "Empatou!";
            }
            PontosJog.Text = Convert.ToString(pontojog);
            PontosComp.Text = Convert.ToString(pontocomp);
            cartasJog.Text = Convert.ToString(cartajogador.Length);
            cartasComp.Text = Convert.ToString(cartacomputador.Length);
            cartajog.Visible = true;
            cartacomp.Visible = true;
            File.WriteAllText("Vencedor.txt", textovencedor, Encoding.Default);
            FrResultado Resultado = new FrResultado();
            Resultado.ShowDialog();
            File.Delete("Vencedor.txt");
            tempoPontos.Stop();
            tempo.Start();
            tempoPontos.Start();
        }
        /// <summary>
        /// Método que recebe duas variaveis do tipo inteiro contendo os valores escolhidos para comparação e após
        /// comparar retorna uma variavel do tipo char informando quem ganhou na comparação.
        /// </summary>
        /// <param name="escolhidoJog"></param>Variavel inteira contendo o valor do atributo escolhido do jogador.
        /// <param name="escolhidoComp"></param>Variavel inteira contendo o valor do atributo escolhido do computador.
        /// <returns></returns>
        static char Compara(int escolhidoJog, int escolhidoComp)
        {
            char retorno;
            if (escolhidoJog > escolhidoComp)
                retorno = 'J';
            else if (escolhidoJog < escolhidoComp)
                retorno = 'C';
            else
                retorno = 'E';
            return retorno;
        }
        /// <summary>
        /// Método que análisa uma condição booleana que informa quem irá jogar e com base nisso mostra 
        /// ou oculta as informações das cartas.
        /// </summary>
        /// <param name="jogPlay"></param>Condição booleana recebida que informa quem irá jogar a próxima rodada.
        /// <param name="CartaCompFrente"></param>Painel com as informações da carta do computador.
        /// <param name="CartaJogFrente"></param>Painel com as informações da carta do Jogador.
        static void VezDeJogar(bool jogPlay, ref Panel CartaCompFrente, ref Panel CartaJogFrente)
        {
            if (jogPlay == true)
            {
                CartaCompFrente.Visible = false;
                CartaJogFrente.Visible = true;
            }
            else
            {
                CartaCompFrente.Visible = true;
                CartaJogFrente.Visible = false;
            }
        }
        /// <summary>
        /// Método que recebe as informações dos paineis do jogador e do computador assim como os vetores com as 
        /// cartas de ambos. O método lê o vetor na posição indicada e copia as informações para seu devido campo nos 
        /// paineis
        /// </summary>
        /// <param name="Rodada"></param>informa a rodada atual/a posição do vetor a ser análisado.
        /// <param name="Nome"></param>Referente a TextBox que recebe o nome da Carta.
        /// <param name="codigo"></param>Referente a Label que recebe o código da Carta.
        /// <param name="Foto"></param>Referente a PictureBox que recebe a Imagem da Carta.
        /// <param name="Sono"></param>Referente a ProgressBar Sono da Carta.
        /// <param name="Fome"></param>Referente a ProgressBar Fome da Carta.
        /// <param name="Raiva"></param>Referente a ProgressBar Raiva da Carta.
        /// <param name="Malandragem"></param>Referente a ProgressBar Malandragem da Carta.
        /// <param name="Humanas"></param>Referente a ProgressBar Humana da Carta.
        /// <param name="Vez"></param>Referente ao vetora ser análisado.
        /// <param name="ValorSono"></param>Referente a label Sono com o valor da ProgressBar sono da Carta.
        /// <param name="ValorFome"></param>Referente a label fome com o valor da ProgressBar fome da Carta.
        /// <param name="ValorRaiva"></param>Referente a label raiva com o valor da ProgressBar raiva da Carta.
        /// <param name="ValorMalandragem"></param>Referente a label malandragem com o valor da ProgressBar Malandragem da Carta.
        /// <param name="ValorHumanas"></param>Referente a label humanas com o valor da ProgressBar humanas da Carta.
        static void MostraCartas(ref int Rodada, ref TextBox Nome, ref Label codigo, ref PictureBox Foto, ref ProgressBar Sono, ref ProgressBar Fome,
                                 ref ProgressBar Raiva, ref ProgressBar Malandragem, ref ProgressBar Humanas, ref Cartas[] Vez,
                                 ref Label ValorSono, ref Label ValorFome, ref Label ValorRaiva, ref Label ValorMalandragem, ref Label ValorHumanas)
        {
            if (Vez.Length >= 1)
            {
                codigo.Text = Vez[Rodada].codigo;
                Foto.ImageLocation = Vez[Rodada].imagem;
                Nome.Text = Vez[Rodada].nome;
                Sono.Value = Convert.ToInt32(Vez[Rodada].sono);
                Fome.Value = Convert.ToInt32(Vez[Rodada].fome);
                Raiva.Value = Convert.ToInt32(Vez[Rodada].raiva);
                Malandragem.Value = Convert.ToInt32(Vez[Rodada].malandragem);
                Humanas.Value = Convert.ToInt32(Vez[Rodada].humanas);
                ValorSono.Text = Convert.ToString(Sono.Value) + "%";
                ValorFome.Text = Convert.ToString(Fome.Value) + "%";
                ValorRaiva.Text = Convert.ToString(Raiva.Value) + "%";
                ValorMalandragem.Text = Convert.ToString(Malandragem.Value) + "%";
                ValorHumanas.Text = Convert.ToString(Humanas.Value) + "%";
            }
        }
        public struct Cartas
        {
            public int sono, fome, raiva, malandragem, humanas;
            public string codigo, nome, imagem;
        }
        char vencedor, dificuldade;
        string textovencedor;
        int pontofinal, pontojog = 0, pontocomp = 0, contador = 0,contador2=0, min, min2,seg,seg2, mili, Natributo, 
            QntCartas, ParImpar, metade, escolha, escolhaComp,atributo, Rodada = 0;
        Random DivideCartas = new Random();
        bool jogPlay = true, fim = false, vitoria = true;

        Cartas[] CartasJog = new Cartas[1];
        Cartas[] CartasComp = new Cartas[1];
        Cartas[] CartasPerdidas = new Cartas[1];

        public frJogo()
        {
            InitializeComponent();

        }

        private void CompJoga_Tick(object sender, EventArgs e)
        {
            contador2++;
            min2 = (contador2 / 3600);
            seg2 = (contador2 % 3600) / 60;
            if (seg2 < 1)
                seg2 = 1;
        }

        private void TmTempoJogo_Tick(object sender, EventArgs e)
        {
            if (jogPlay == false)
            {
                ComputadorJoga(dificuldade, CartasComp, ref escolhaComp, ref Natributo);
                TmTempoJogo.Dispose();
                FrEscolhaComp EscolhaComp = new FrEscolhaComp();
                EscolhaComp.ShowDialog();
                File.Delete("escolha.txt");
                TmTempoJogo.Start();
                EscolheProgress(ref Natributo, ref atributo, progressBarSonoJog, progressBarFomeJog, progressBarRaivaJog, progressBarMalandragemJog, progressBarHumanasJog);
                vencedor = Compara(atributo, escolhaComp);
                CartaPerdida(ref CartasPerdidas, CartasJog, CartasComp, vencedor, ref Rodada);
                InsereCarta(ref CartasComp, ref CartasJog, CartasPerdidas, vencedor, Rodada);
                ProcessaRodada(ref contador2,ref min, ref seg, CartaJogFrente, CartaCompFrente, ref jogPlay, ref TmTempoJogo, ref TempoPontos, ref textovencedor, vencedor, 
                    ref pontojog, ref pontocomp, ref txbPontosJog, ref txbPontosComp,ref txbCartasJog,ref txbCartasComp, CartasJog, CartasComp);
                fim = VerificaGanhador(ref vitoria, ref pontofinal, CartasJog, CartasComp, TmTempoJogo, pontojog,
                    pontocomp);
                VezDeJogar(jogPlay, ref CartaCompFrente, ref CartaJogFrente);
                MostraCartas(ref Rodada, ref txbNomeJog, ref lblCodigoJog, ref ptbImagemCartaJog, ref progressBarSonoJog, ref progressBarFomeJog,
                             ref progressBarRaivaJog, ref progressBarMalandragemJog, ref progressBarHumanasJog, ref CartasJog,
                             ref lblSonoForcaJog, ref lblFomeForcaJog, ref lblRaivaForcaJog, ref lblMalandragemForcaJog, ref lblHumanasForcaJog);
                MostraCartas(ref Rodada, ref txbNomeComp, ref lblCodigoComp, ref ptbImagemCartaComp, ref progressBarSonoComp, ref progressBarFomeComp,
                             ref progressBarRaivaComp, ref progressBarMalandragemComp, ref progressBarHumanasComp, ref CartasComp,
                             ref lblSonoForcaComp, ref lblFomeForcaComp, ref lblRaivaForcaComp, ref lblMalandragemForcaComp, ref lblHumanasForcaComp);
                if (fim == true && vitoria == true)
                {
                    CartaCompVerso.Visible = true;
                    CartaCompFrente.Visible = false;
                    CartaJogVerso.Visible = true;
                    CartaJogFrente.Visible = false;
                    Close();
                    FrInsereRecorde insereRecorde = new FrInsereRecorde();
                    insereRecorde.ShowDialog();
                }
                else if (fim == true && vitoria == false)
                    Close();
            }
            contador++;
            min = (contador / 3600);
            seg = (contador % 3600) / 60;
            mili = (contador % 3600) % 60;
            txbTempoJogo.Text = String.Format("{0:#,0#}:{1:#0#}:{2:#0#}", min, seg, mili);
        }

        private void progressBarFomeJog_Click(object sender, EventArgs e)
        {

            escolha = progressBarFomeJog.Value;
            vencedor = Compara(escolha, progressBarFomeComp.Value);
            CartaPerdida(ref CartasPerdidas, CartasJog, CartasComp, vencedor, ref Rodada);
            InsereCarta(ref CartasComp, ref CartasJog, CartasPerdidas, vencedor, Rodada);
            ProcessaRodada(ref contador2, ref min2, ref seg2, CartaJogFrente, CartaCompFrente, ref jogPlay, ref TmTempoJogo,ref TempoPontos, ref textovencedor, vencedor, 
                ref pontojog, ref pontocomp, ref txbPontosJog, ref txbPontosComp, ref txbCartasJog, ref txbCartasComp, CartasJog, CartasComp);
            fim = VerificaGanhador(ref vitoria, ref pontofinal, CartasJog, CartasComp, TmTempoJogo, pontojog,
                pontocomp);
            VezDeJogar(jogPlay, ref CartaCompFrente, ref CartaJogFrente);
            MostraCartas(ref Rodada, ref txbNomeJog, ref lblCodigoJog, ref ptbImagemCartaJog, ref progressBarSonoJog, ref progressBarFomeJog,
         ref progressBarRaivaJog, ref progressBarMalandragemJog, ref progressBarHumanasJog, ref CartasJog,
         ref lblSonoForcaJog, ref lblFomeForcaJog, ref lblRaivaForcaJog, ref lblMalandragemForcaJog, ref lblHumanasForcaJog);
            MostraCartas(ref Rodada, ref txbNomeComp, ref lblCodigoComp, ref ptbImagemCartaComp, ref progressBarSonoComp, ref progressBarFomeComp,
         ref progressBarRaivaComp, ref progressBarMalandragemComp, ref progressBarHumanasComp, ref CartasComp,
         ref lblSonoForcaComp, ref lblFomeForcaComp, ref lblRaivaForcaComp, ref lblMalandragemForcaComp, ref lblHumanasForcaComp);
            if (fim == true && vitoria == true)
            {
                CartaCompVerso.Visible = true;
                CartaCompFrente.Visible = false;
                CartaJogVerso.Visible = true;
                CartaJogFrente.Visible = false;
                Close();
                FrInsereRecorde insereRecorde = new FrInsereRecorde();
                insereRecorde.ShowDialog();
            }
            else if (fim == true && vitoria == false)
                Close();
        }

        private void progressBarRaivaJog_Click(object sender, EventArgs e)
        {

            escolha = progressBarRaivaJog.Value;
            vencedor = Compara(escolha, progressBarRaivaComp.Value);
            CartaPerdida(ref CartasPerdidas, CartasJog, CartasComp, vencedor, ref Rodada);
            InsereCarta(ref CartasComp, ref CartasJog, CartasPerdidas, vencedor, Rodada);
            ProcessaRodada(ref contador2, ref min2, ref seg2, CartaJogFrente, CartaCompFrente, ref jogPlay, ref TmTempoJogo,ref TempoPontos, ref textovencedor, vencedor, 
                ref pontojog, ref pontocomp, ref txbPontosJog, ref txbPontosComp, ref txbCartasJog,ref txbCartasComp, CartasJog, CartasComp);
            fim = VerificaGanhador(ref vitoria, ref pontofinal, CartasJog, CartasComp, TmTempoJogo, pontojog,
                pontocomp);
            VezDeJogar(jogPlay, ref CartaCompFrente, ref CartaJogFrente);
            MostraCartas(ref Rodada, ref txbNomeJog, ref lblCodigoJog, ref ptbImagemCartaJog, ref progressBarSonoJog, ref progressBarFomeJog,
         ref progressBarRaivaJog, ref progressBarMalandragemJog, ref progressBarHumanasJog, ref CartasJog,
         ref lblSonoForcaJog, ref lblFomeForcaJog, ref lblRaivaForcaJog, ref lblMalandragemForcaJog, ref lblHumanasForcaJog);
            MostraCartas(ref Rodada, ref txbNomeComp, ref lblCodigoComp, ref ptbImagemCartaComp, ref progressBarSonoComp, ref progressBarFomeComp,
         ref progressBarRaivaComp, ref progressBarMalandragemComp, ref progressBarHumanasComp, ref CartasComp,
         ref lblSonoForcaComp, ref lblFomeForcaComp, ref lblRaivaForcaComp, ref lblMalandragemForcaComp, ref lblHumanasForcaComp);
            if (fim == true && vitoria == true)
            {
                CartaCompVerso.Visible = true;
                CartaCompFrente.Visible = false;
                CartaJogVerso.Visible = true;
                CartaJogFrente.Visible = false;
                Close();
                FrInsereRecorde insereRecorde = new FrInsereRecorde();
                insereRecorde.ShowDialog();
            }
            else if (fim == true && vitoria == false)
                Close();
        }

        private void progressBarMalandragemJog_Click(object sender, EventArgs e)
        {

            escolha = progressBarMalandragemJog.Value;
            vencedor = Compara(escolha, progressBarMalandragemComp.Value);
            CartaPerdida(ref CartasPerdidas, CartasJog, CartasComp, vencedor, ref Rodada);
            InsereCarta(ref CartasComp, ref CartasJog, CartasPerdidas, vencedor, Rodada);
            ProcessaRodada(ref contador2, ref min2, ref seg2, CartaJogFrente, CartaCompFrente, ref jogPlay, ref TmTempoJogo,ref TempoPontos, ref textovencedor, vencedor, 
                ref pontojog, ref pontocomp, ref txbPontosJog, ref txbPontosComp, ref txbCartasJog,ref txbCartasComp, CartasJog, CartasComp);
            fim = VerificaGanhador(ref vitoria, ref pontofinal, CartasJog, CartasComp, TmTempoJogo, pontojog,
                pontocomp);
            VezDeJogar(jogPlay, ref CartaCompFrente, ref CartaJogFrente);
            MostraCartas(ref Rodada, ref txbNomeJog, ref lblCodigoJog, ref ptbImagemCartaJog, ref progressBarSonoJog, ref progressBarFomeJog,
         ref progressBarRaivaJog, ref progressBarMalandragemJog, ref progressBarHumanasJog, ref CartasJog,
         ref lblSonoForcaJog, ref lblFomeForcaJog, ref lblRaivaForcaJog, ref lblMalandragemForcaJog, ref lblHumanasForcaJog);
            MostraCartas(ref Rodada, ref txbNomeComp, ref lblCodigoComp, ref ptbImagemCartaComp, ref progressBarSonoComp, ref progressBarFomeComp,
         ref progressBarRaivaComp, ref progressBarMalandragemComp, ref progressBarHumanasComp, ref CartasComp,
         ref lblSonoForcaComp, ref lblFomeForcaComp, ref lblRaivaForcaComp, ref lblMalandragemForcaComp, ref lblHumanasForcaComp);
            if (fim == true && vitoria == true)
            {
                CartaCompVerso.Visible = true;
                CartaCompFrente.Visible = false;
                CartaJogVerso.Visible = true;
                CartaJogFrente.Visible = false;
                Close();
                FrInsereRecorde insereRecorde = new FrInsereRecorde();
                insereRecorde.ShowDialog();
            }
            else if (fim == true && vitoria == false)
                Close();
        }

        private void progressBarHumanasJog_Click(object sender, EventArgs e)
        {
            escolha = progressBarHumanasJog.Value;
            vencedor = Compara(escolha, progressBarHumanasComp.Value);
            CartaPerdida(ref CartasPerdidas, CartasJog, CartasComp, vencedor, ref Rodada);
            InsereCarta(ref CartasComp, ref CartasJog, CartasPerdidas, vencedor, Rodada);
            ProcessaRodada(ref contador2, ref min2, ref seg2, CartaJogFrente, CartaCompFrente, ref jogPlay, ref TmTempoJogo,ref TempoPontos, ref textovencedor, vencedor, 
                ref pontojog, ref pontocomp, ref txbPontosJog, ref txbPontosComp, ref txbCartasJog, ref txbCartasComp,CartasJog,CartasComp);
            fim = VerificaGanhador(ref vitoria, ref pontofinal, CartasJog, CartasComp, TmTempoJogo, pontojog,
                pontocomp);
            VezDeJogar(jogPlay, ref CartaCompFrente, ref CartaJogFrente);
            MostraCartas(ref Rodada, ref txbNomeJog, ref lblCodigoJog, ref ptbImagemCartaJog, ref progressBarSonoJog, ref progressBarFomeJog,
                         ref progressBarRaivaJog, ref progressBarMalandragemJog, ref progressBarHumanasJog, ref CartasJog,
                         ref lblSonoForcaJog, ref lblFomeForcaJog, ref lblRaivaForcaJog, ref lblMalandragemForcaJog, ref lblHumanasForcaJog);
            MostraCartas(ref Rodada, ref txbNomeComp, ref lblCodigoComp, ref ptbImagemCartaComp, ref progressBarSonoComp, ref progressBarFomeComp,
                         ref progressBarRaivaComp, ref progressBarMalandragemComp, ref progressBarHumanasComp, ref CartasComp,
                         ref lblSonoForcaComp, ref lblFomeForcaComp, ref lblRaivaForcaComp, ref lblMalandragemForcaComp, ref lblHumanasForcaComp);
            if (fim == true && vitoria == true)
            {
                CartaCompVerso.Visible = true;
                CartaCompFrente.Visible = false;
                CartaJogVerso.Visible = true;
                CartaJogFrente.Visible = false;
                Close();
                FrInsereRecorde insereRecorde = new FrInsereRecorde();
                insereRecorde.ShowDialog();
            }
            else if (fim == true && vitoria == false)
                Close();
        }


        private void progressBarSonoJog_Click_1(object sender, EventArgs e)
        {

            escolha = progressBarSonoJog.Value;
            vencedor = Compara(escolha, progressBarSonoComp.Value);
            CartaPerdida(ref CartasPerdidas, CartasJog, CartasComp, vencedor, ref Rodada);
            InsereCarta(ref CartasComp, ref CartasJog, CartasPerdidas, vencedor, Rodada);
            ProcessaRodada(ref contador2, ref min2, ref seg2, CartaJogFrente, CartaCompFrente, ref jogPlay, ref TmTempoJogo,ref TempoPontos, ref textovencedor, vencedor, 
                ref pontojog, ref pontocomp, ref txbPontosJog, ref txbPontosComp, ref txbCartasJog,ref txbCartasComp,CartasJog,CartasComp);
            fim = VerificaGanhador(ref vitoria, ref pontofinal, CartasJog, CartasComp, TmTempoJogo, pontojog,
                pontocomp);
            VezDeJogar(jogPlay, ref CartaCompFrente, ref CartaJogFrente);
            MostraCartas(ref Rodada, ref txbNomeJog, ref lblCodigoJog, ref ptbImagemCartaJog, ref progressBarSonoJog, ref progressBarFomeJog,
         ref progressBarRaivaJog, ref progressBarMalandragemJog, ref progressBarHumanasJog, ref CartasJog,
         ref lblSonoForcaJog, ref lblFomeForcaJog, ref lblRaivaForcaJog, ref lblMalandragemForcaJog, ref lblHumanasForcaJog);
            MostraCartas(ref Rodada, ref txbNomeComp, ref lblCodigoComp, ref ptbImagemCartaComp, ref progressBarSonoComp, ref progressBarFomeComp,
         ref progressBarRaivaComp, ref progressBarMalandragemComp, ref progressBarHumanasComp, ref CartasComp,
         ref lblSonoForcaComp, ref lblFomeForcaComp, ref lblRaivaForcaComp, ref lblMalandragemForcaComp, ref lblHumanasForcaComp);
            if (fim == true && vitoria == true)
            {
                CartaCompVerso.Visible = true;
                CartaCompFrente.Visible = false;
                CartaJogVerso.Visible = true;
                CartaJogFrente.Visible = false;
                Close();
                FrInsereRecorde insereRecorde = new FrInsereRecorde();
                insereRecorde.ShowDialog();
            }
            else if (fim == true && vitoria == false)
                Close();
        }

        private void frJogo_Load(object sender, EventArgs e)
        {
            TmTempoJogo.Start();
            TempoPontos.Start();
            string[] Ncartas = File.ReadAllLines("cartas.txt", Encoding.Default);//Cria um vetor de tamanho semelhante a qnt de linhas do txt.(numerod de cartas).
            QntCartas = Ncartas.Length;//Passa o tamanho do vetor para uma variavel inteira.
            metade = QntCartas / 2;
            if (QntCartas % 2 == 0)
                ParImpar = QntCartas;
            else
                ParImpar = QntCartas - 1;
            int[] CartasTemp = new int[ParImpar];//Cria um vetor temporário, para armazenar o sorteio de cartas.
            Cartas[] recebetxt = new Cartas[QntCartas];
            Cartas[] recebeVet = new Cartas[ParImpar];
            Array.Resize(ref CartasJog, metade);
            Array.Resize(ref CartasComp, metade);
            for (int n = 0; n < ParImpar; n++)
            {
                string[] linha = Ncartas[n].Trim().Split('|');
                recebetxt[n].codigo = linha[1].Trim();
                recebetxt[n].nome = linha[2].Trim();
                recebetxt[n].sono = Convert.ToInt32(linha[3].Trim());
                recebetxt[n].fome = Convert.ToInt32(linha[4].Trim());
                recebetxt[n].raiva = Convert.ToInt32(linha[5].Trim());
                recebetxt[n].malandragem = Convert.ToInt32(linha[6].Trim());
                recebetxt[n].humanas = Convert.ToInt32(linha[7].Trim());
                recebetxt[n].imagem = Path.GetDirectoryName(Application.ExecutablePath) + linha[8].Trim();
            }

            for (int n = 0; n < ParImpar; n++)
            {
                bool condição;
                if (QntCartas % 2 == 0)
                {
                    do
                    {
                        condição = false;
                        CartasTemp[n] = DivideCartas.Next(0, ParImpar);

                        for (int p = 0; p < n; p++)
                        {
                            if (CartasTemp[p] == CartasTemp[n])
                            {
                                condição = true;
                                break;
                            }
                        }
                    }
                    while (condição == true);
                }
                else
                {
                    do
                    {
                        condição = false;
                        CartasTemp[n] = DivideCartas.Next(0, ParImpar + 1);

                        for (int p = 0; p < n; p++)
                        {
                            if (CartasTemp[p] == CartasTemp[n])
                            {
                                condição = true;
                                break;
                            }
                        }
                    }
                    while (condição == true);
                }
            }

            for (int n = 0; n < ParImpar; n++)
            {
                recebeVet[n].codigo = recebetxt[CartasTemp[n]].codigo;
                recebeVet[n].nome = recebetxt[CartasTemp[n]].nome;
                recebeVet[n].sono = recebetxt[CartasTemp[n]].sono;
                recebeVet[n].fome = recebetxt[CartasTemp[n]].fome;
                recebeVet[n].raiva = recebetxt[CartasTemp[n]].raiva;
                recebeVet[n].malandragem = recebetxt[CartasTemp[n]].malandragem;
                recebeVet[n].humanas = recebetxt[CartasTemp[n]].humanas;
                recebeVet[n].imagem = recebetxt[CartasTemp[n]].imagem;
            }
            for (int n = 0; n < metade; n++)
            {
                CartasJog[n].codigo = recebeVet[n].codigo;
                CartasJog[n].nome = recebeVet[n].nome;
                CartasJog[n].sono = recebeVet[n].sono;
                CartasJog[n].fome = recebeVet[n].fome;
                CartasJog[n].raiva = recebeVet[n].raiva;
                CartasJog[n].malandragem = recebeVet[n].malandragem;
                CartasJog[n].humanas = recebeVet[n].humanas;
                CartasJog[n].imagem = recebeVet[n].imagem;
            }
            int u = metade;
            int z;
            for (z = 0; z < metade; z++)
            {
                for (int i = u; i < ParImpar; i++)
                {
                    CartasComp[z].codigo = recebeVet[i].codigo;
                    CartasComp[z].nome = recebeVet[i].nome;
                    CartasComp[z].sono = recebeVet[i].sono;
                    CartasComp[z].fome = recebeVet[i].fome;
                    CartasComp[z].raiva = recebeVet[i].raiva;
                    CartasComp[z].malandragem = recebeVet[i].malandragem;
                    CartasComp[z].humanas = recebeVet[i].humanas;
                    CartasComp[z].imagem = recebeVet[i].imagem;
                    z++;
                    u = i;
                }
            }
            VerificaDificuldade(ref dificuldade);
            VezDeJogar(jogPlay, ref CartaCompFrente, ref CartaJogFrente);
            MostraCartas(ref Rodada, ref txbNomeJog, ref lblCodigoJog, ref ptbImagemCartaJog, ref progressBarSonoJog, ref progressBarFomeJog,
         ref progressBarRaivaJog, ref progressBarMalandragemJog, ref progressBarHumanasJog, ref CartasJog,
         ref lblSonoForcaJog, ref lblFomeForcaJog, ref lblRaivaForcaJog, ref lblMalandragemForcaJog, ref lblHumanasForcaJog);
            MostraCartas(ref Rodada, ref txbNomeComp, ref lblCodigoComp, ref ptbImagemCartaComp, ref progressBarSonoComp, ref progressBarFomeComp,
         ref progressBarRaivaComp, ref progressBarMalandragemComp, ref progressBarHumanasComp, ref CartasComp,
         ref lblSonoForcaComp, ref lblFomeForcaComp, ref lblRaivaForcaComp, ref lblMalandragemForcaComp, ref lblHumanasForcaComp);
            txbCartasJog.Text = Convert.ToString(CartasJog.Length);
            txbCartasComp.Text = Convert.ToString(CartasComp.Length);
        }
    }
}
