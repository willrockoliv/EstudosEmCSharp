using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste2
{
    public partial class frCadastro : Form
    {
        #region Variáveis Públicas

        /// <summary>
        /// Struct com os dados das cartas
        /// </summary>
        public struct Cartas
        {
            public int codInterno, sono, fome, raiva, malandragem, humanas;
            public string codigo, nome, imagem;
        }

        public string[] arquivo;
        public Cartas[] Cadastros;

        #endregion

        #region Métodos

        /// <summary>
        /// Recebe por referencia o vetor struct e o vetor arquivos e separa
        /// cada dado em arquivo dentro de uma variavel da struct
        /// </summary>
        /// <param name="Cadastros">vetor de struct</param>
        /// <param name="arquivo">vetor com cada linha do cadastro.txt</param>
        static void CarregaArquivo(ref Cartas[] Cadastros, ref string[] arquivo)
        {
            //try
            //{
            for (int i = 0; i < arquivo.Length; i++)
            {
                string[] temp = arquivo[i].Split('|');
                Cadastros[i].codInterno = Convert.ToInt16(temp[0].Trim());
                Cadastros[i].codigo = temp[1].Trim();
                Cadastros[i].nome = temp[2].Trim();
                Cadastros[i].sono = Convert.ToInt16(temp[3].Trim());
                Cadastros[i].fome = Convert.ToInt16(temp[4].Trim());
                Cadastros[i].raiva = Convert.ToInt16(temp[5].Trim());
                Cadastros[i].malandragem = Convert.ToInt16(temp[6].Trim());
                Cadastros[i].humanas = Convert.ToInt16(temp[7].Trim());
                Cadastros[i].imagem = Path.GetDirectoryName(Application.ExecutablePath) + temp[8].Trim();
            }
            //}
            //catch
            //{
            //}
        }

        /// <summary>
        /// Recebe por referencia todos os componentes da carta na tela de cadastros e
        /// verifica se a carta a ser mostrada é uma carta específica atravé da variável
        /// inteira codigoEspecifico, a qual determina a posição do vetor de Cadastros. Caso
        /// o valor de codigoEspecifico seja -1, o metodo chamará o método LimpaTelaCadastro
        /// o qual restaurará cada componente da tela Cadastro aos valores iniciais 
        /// </summary>
        /// <param name="ultimoCodInterno">Utilizado para chamar o método LimpaTelaCadastro</param>
        /// <param name="btnCarregarImagem">Ao final do método valida se este botão será habilitado ou desabilidado</param>
        /// <param name="lblCodInterno">Define a carta que será mostrada</param>
        /// <param name="lblCodigo">label no canto superior direito da carta (invisível durante a execução do programa)</param>
        /// <param name="txtNome">Campo nome</param>
        /// <param name="ptbImagemCarta">Local onde será carregado a imagem da carta</param>
        /// <param name="btnRemoverImgem">Remove a imagem da carta e adiciona ao arquivo lixeira.txt</param>
        /// <param name="lblSonoForca">exibe porcentagem de sono</param>
        /// <param name="progressBarSono">exibe visualmente porcentagem de sono</param>
        /// <param name="btnMaisSono">aumenta porcentagem de sono</param>
        /// <param name="btnMenosSono">diminui porcentagem de sono</param>
        /// <param name="lblFomeForca">exibe porcentagem de fome</param>
        /// <param name="progressBarFome">exibe visualmente porcentagem de fome</param>
        /// <param name="btnMaisFome">aumenta porcentagem de fome</param>
        /// <param name="btnMenosFome">diminui porcentagem de fome</param>
        /// <param name="lblRaivaForca">exibe porcentagem de raiva</param>
        /// <param name="progressBarRaiva">exibe visualmente porcentagem de raiva</param>
        /// <param name="btnMaisRaiva">aumenta porcentagem de raiva</param>
        /// <param name="btnMenosRaiva">diminui porcentagem de raiva</param>
        /// <param name="lblMalandragemForca">exibe porcentagem de malandragem</param>
        /// <param name="progressBarMalandragem">exibe visualmente porcentagem de malandragem</param>
        /// <param name="btnMaisMalandragem">aumenta porcentagem de malandragem</param>
        /// <param name="btnMenosMalandragem">diminui porcentagem de malandragem</param>
        /// <param name="lblHumanasForca">exibe porcentagem de humanas</param>
        /// <param name="progressBarHumanas">exie visualmente porcentagem de humanas</param>
        /// <param name="btnMaisHumanas">aumenta porcentagem de humanas</param>
        /// <param name="btnMenosHumanas">diminui porcentagem de humanas</param>
        /// <param name="Cadastros">Vetor da Struct Cartas</param>
        /// <param name="arquivo">Variável com cada linha do arquivo cartas.txt</param>
        /// <param name="codigoEspecifico">Variável que indicará uma carta específica a ser mostrada. 
        ///                                Caso seu valor seja -1, o método mostrará a primeira carta cadastrada</param>
        static void MostrarCarta(int ultimoCodInterno, ref Button btnCarregarImagem, ref Label lblCodInterno, ref Label lblCodigo, ref TextBox txtNome,
                                 ref PictureBox ptbImagemCarta, ref Button btnRemoverImgem,
                                 ref Label lblSonoForca, ref ProgressBar progressBarSono, ref Button btnMaisSono, ref Button btnMenosSono,
                                 ref Label lblFomeForca, ref ProgressBar progressBarFome, ref Button btnMaisFome, ref Button btnMenosFome,
                                 ref Label lblRaivaForca, ref ProgressBar progressBarRaiva, ref Button btnMaisRaiva, ref Button btnMenosRaiva,
                                 ref Label lblMalandragemForca, ref ProgressBar progressBarMalandragem, ref Button btnMaisMalandragem, ref Button btnMenosMalandragem,
                                 ref Label lblHumanasForca, ref ProgressBar progressBarHumanas, ref Button btnMaisHumanas, ref Button btnMenosHumanas,
                                 ref Cartas[] Cadastros, ref string[] arquivo, int codigoEspecifico)
        {
            //Caso o solicitado for uma carta, mostra de acordo com o código passado como parâmetro
            if (codigoEspecifico != -1)
            {
                lblCodInterno.Text = (codigoEspecifico).ToString();
                lblCodigo.Text = (Cadastros[codigoEspecifico].codigo).ToString().Trim();
                txtNome.Text = (Cadastros[codigoEspecifico].nome).ToString().Trim();
                ptbImagemCarta.ImageLocation = (Cadastros[codigoEspecifico].imagem).ToString().Trim();
                btnRemoverImgem.Enabled = true;

                lblSonoForca.Text = (Cadastros[codigoEspecifico].sono).ToString().Trim() + "%";
                progressBarSono.Value = Cadastros[codigoEspecifico].sono;
                HabilitaMaisMenos(ref progressBarSono, ref btnMaisSono, ref btnMenosSono);

                lblFomeForca.Text = (Cadastros[codigoEspecifico].fome).ToString().Trim() + "%";
                progressBarFome.Value = Cadastros[codigoEspecifico].fome;
                HabilitaMaisMenos(ref progressBarFome, ref btnMaisFome, ref btnMenosFome);

                lblRaivaForca.Text = (Cadastros[codigoEspecifico].raiva).ToString().Trim() + "%";
                progressBarRaiva.Value = Cadastros[codigoEspecifico].raiva;
                HabilitaMaisMenos(ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva);

                lblMalandragemForca.Text = (Cadastros[codigoEspecifico].malandragem).ToString().Trim() + "%";
                progressBarMalandragem.Value = Cadastros[codigoEspecifico].malandragem;
                HabilitaMaisMenos(ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem);

                lblHumanasForca.Text = (Cadastros[codigoEspecifico].humanas).ToString().Trim() + "%";
                progressBarHumanas.Value = Cadastros[codigoEspecifico].humanas;
                HabilitaMaisMenos(ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);
            }
            //Caso nenhuma carta for solicitada, mostrará a carta vazia
            else
                LimpaTelaCadastro(ultimoCodInterno, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                                  ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                                  ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                                  ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                                  ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                                  ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);

            if (ptbImagemCarta.ImageLocation != null)
                btnCarregarImagem.Enabled = false;
            else
                btnCarregarImagem.Enabled = true;
        }

        /// <summary>
        /// Recebe por parâmetro cada componete da carta para restaurar aos valores iniciais
        /// </summary>
        /// <param name="ultimoCodinterno">Indicará o último código interno para definir o código da próxima carta</param>
        /// <param name="btnCarregarImagem">Ao final do método valida se este botão será habilitado ou desabilidado</param>
        /// <param name="lblcodInterno">Define a carta que será mostrada</param>
        /// <param name="lblCodigo">Campo que exibira o código da carta</param>
        /// <param name="txtNome">Campo para o usuario digitar o nome</param>
        /// <param name="ptbImagemCarta">Onde será exibida a imagem carregada</param>
        /// <param name="btnRemoverImgem">Botão para carregar a imagem</param>
        /// <param name="lblSonoForca">Exibe a porcentagem de sono</param>
        /// <param name="progressBarSono">Exibe visualmente a porcentagem de sono</param>
        /// <param name="btnMaisSono">Botão para aumentar a porcentagem de sono</param>
        /// <param name="btnMenosSono">Botão para diminuir a porcentagem de sono</param>
        /// <param name="lblFomeForca">Exibe a porcentagem de fome</param>
        /// <param name="progressBarFome">Exibe visualmente a porcentagem de fome</param>
        /// <param name="btnMaisFome">Botão para aumentar a porcentagem de fome</param>
        /// <param name="btnMenosFome">Botão para diminuir a porcentagem de fome</param>
        /// <param name="lblRaivaForca">Exibe a porcentagem de raiva</param>
        /// <param name="progressBarRaiva">Exibe visualmente a porcentagem de raiva</param>
        /// <param name="btnMaisRaiva">Botão para aumentar a porcentagem de raiva</param>
        /// <param name="btnMenosRaiva">Botão para diminuir a porcentagem de raiva</param>
        /// <param name="lblMalandragemForca">Exibe a porcentagem de malandragem</param>
        /// <param name="progressBarMalandragem">Exibe visualmente a porcentagem de malandragem</param>
        /// <param name="btnMaisMalandragem">Botão para aumentar a porcentagem de malandragem</param>
        /// <param name="btnMenosMalandragem">Botão para diminuir a porcentagem de malandragem</param>
        /// <param name="lblHumanasForca">Exibe a porcentagem de humanas</param>
        /// <param name="progressBarHumanas">Exibe visualmente a porcentagem de humanas</param>
        /// <param name="btnMaisHumanas">Botão para aumentar a porcentagem de humanas</param>
        /// <param name="btnMenosHumanas">Botão para diminuir a porcentagem de humanas</param>
        static void LimpaTelaCadastro(int ultimoCodinterno, ref Button btnCarregarImagem, ref Label lblcodInterno, ref Label lblCodigo, ref TextBox txtNome,
                                      ref PictureBox ptbImagemCarta, ref Button btnRemoverImgem,
                                      ref Label lblSonoForca, ref ProgressBar progressBarSono, ref Button btnMaisSono, ref Button btnMenosSono,
                                      ref Label lblFomeForca, ref ProgressBar progressBarFome, ref Button btnMaisFome, ref Button btnMenosFome,
                                      ref Label lblRaivaForca, ref ProgressBar progressBarRaiva, ref Button btnMaisRaiva, ref Button btnMenosRaiva,
                                      ref Label lblMalandragemForca, ref ProgressBar progressBarMalandragem, ref Button btnMaisMalandragem, ref Button btnMenosMalandragem,
                                      ref Label lblHumanasForca, ref ProgressBar progressBarHumanas, ref Button btnMaisHumanas, ref Button btnMenosHumanas)
        {
            if (ultimoCodinterno != -1)
                lblcodInterno.Text = (ultimoCodinterno + 1).ToString();
            else
                lblcodInterno.Text = "0";

            lblCodigo.Text = null;
            txtNome.Text = "NOME";
            ptbImagemCarta.ImageLocation = null;
            btnRemoverImgem.Enabled = false;

            lblSonoForca.Text = "0%";
            progressBarSono.Value = 0;
            btnMaisSono.Enabled = true;
            btnMenosSono.Enabled = false;

            lblFomeForca.Text = "0%";
            progressBarFome.Value = 0;
            btnMaisFome.Enabled = true;
            btnMenosFome.Enabled = false;

            lblRaivaForca.Text = "0%";
            progressBarRaiva.Value = 0;
            btnMaisRaiva.Enabled = true;
            btnMenosRaiva.Enabled = false;

            lblMalandragemForca.Text = "0%";
            progressBarMalandragem.Value = 0;
            btnMaisMalandragem.Enabled = true;
            btnMenosMalandragem.Enabled = false;

            lblHumanasForca.Text = "0%";
            progressBarHumanas.Value = 0;
            btnMaisHumanas.Enabled = true;
            btnMenosHumanas.Enabled = false;

            if (ptbImagemCarta.ImageLocation != null)
                btnCarregarImagem.Enabled = false;
            else
                btnCarregarImagem.Enabled = true;
        }

        /// <summary>
        /// Método para apagar as imagens que não estão vinculadas à uma carta
        /// </summary>
        /// <param name="Cadastros">Vetor da Struct Cartas para pegar o caminho das imagens cadastradas</param>
        static void ApagaImgSemUso(Cartas[] Cadastros)
        {
            bool cancelaOperacao = false;
            string[] filesNames;

            //Move as imagens cadastradas para uma pasta temporária
            string pathPastaTemp = Path.GetDirectoryName(Application.ExecutablePath) + "\\Imagens\\Cartas\\temp\\";
            for (int i = 0; i < Cadastros.Length; i++)
            {
                string nomeImagem = Cadastros[i].imagem.Replace(Path.GetDirectoryName(Application.ExecutablePath) + "\\Imagens\\Cartas\\", null);
                try
                {
                    File.Move(Cadastros[i].imagem, pathPastaTemp + nomeImagem);
                }
                catch
                {
                    cancelaOperacao = true;
                    break;
                }
            }

            if (cancelaOperacao == false)
            {
                //apaga todas as imagens que sobraram na pasta
                filesNames = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath) + "\\Imagens\\Cartas", "*.*");
                foreach (string file in filesNames)
                    try
                    {
                        File.Delete(file);
                    }
                    catch
                    {
                        //A operação Delete pode falhar se o arquivo ainda estiver em uso na memória,
                        //nesse caso vai ignorar a execução e excluirá da proxima vez que a tela cadastro for aberta.
                    }
            }

            //Move as imagens da pasta temporária para a pasta inicial
            filesNames = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath) + "\\Imagens\\Cartas\\temp", "*.*");
            foreach (string file in filesNames)
                File.Move(file, file.Replace("\\temp", null));
        }

        /// <summary>
        /// Este método valida se deve habilitar ou desabilitar os botões btnAnterior e 
        /// btnProximo verificando pelo código da carta se esta é a primeira ou a última 
        /// carta
        /// </summary>
        /// <param name="btnAnterior">Botão que passará o código da carta anterior</param>
        /// <param name="btnProximo">Botão que passará o código da próxima carta</param>
        /// <param name="codigo">Código da carta</param>
        /// <param name="ultimaCarta">indica o último cadastro no arquivo cartas.txt</param>
        static void HabilitaDesabilitaCursores(ref Button btnAnterior, ref Button btnProximo, int proxCodigo, int ultimaCarta)
        {
            if (proxCodigo == 0 && proxCodigo == (ultimaCarta))
            {
                btnAnterior.Enabled = false;
                btnProximo.Enabled = false;
            }
            else if (proxCodigo == (ultimaCarta))
            {
                btnAnterior.Enabled = true;
                btnProximo.Enabled = false;
            }
            else if (proxCodigo == 0)
            {
                btnAnterior.Enabled = false;
                btnProximo.Enabled = true;
            }
            else
            {
                if (proxCodigo > ultimaCarta)
                {
                    btnAnterior.Enabled = true;
                    btnProximo.Enabled = false;
                }
                else
                {
                    btnAnterior.Enabled = true;
                    btnProximo.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Valida se o cadastro da carta está correto ou se falta alguma informação obrigatória
        /// </summary>
        /// <param name="txtNome">Campo nome obrigatório</param>
        /// <param name="ptbImagemCarta">Campo imagem obrigatório</param>
        /// <returns>retorna true caso o cadastro esteja correto e false caso não esteja</returns>
        static bool ValidaCarta(TextBox txtNome, PictureBox ptbImagemCarta)
        {
            bool ok;

            if (txtNome.Text == "NOME" || txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo NOME antes de prosseguir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ok = false;
            }
            else if (ptbImagemCarta.ImageLocation == null)
            {
                MessageBox.Show("Carregue uma imagem antes de prosseguir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ok = false;
            }
            else
                ok = true;

            return ok;
        }

        /// <summary>
        /// Verifica se a quantidade máxima de cartas já foi atingida e determina se a ação
        /// a ser realizada, se é alterar uma carta ou salvar uma nova
        /// </summary>
        /// <param name="Cadastros">Vetor Struct Cartas</param>
        /// <param name="arquivo">Vetor com as linhas do arquivo cartas.txt</param>
        /// <param name="codInterno">Código da carta que será salva. Útil nesse método para comparar com os códigos já cadastrados</param>
        /// <returns>retornará uma string com "alterar" ou "salvar novo"</returns>
        static string VerificaAcao(ref Cartas[] Cadastros, ref string[] arquivo, string codInterno)
        {
            bool jaCadastrado = false;
            for (int i = 0; i < arquivo.Length; i++)
            {
                if (Cadastros[i].codInterno == Convert.ToInt16(codInterno))
                {
                    jaCadastrado = true;
                    break;
                }
            }

            string acao;
            if (jaCadastrado == true)
                acao = "alterar";
            else
                acao = "salvar novo";

            return acao;
        }

        /// <summary>
        /// Sorteia o código de 1A até 8D
        /// </summary>
        /// <param name="Cadastros">Struct Cartas</param>
        /// <param name="arquivo">Vetor com todas as linhas do arquivo cartas.txt</param>
        /// <returns>Retorna o novo código</returns>
        static string SorteiaCodigo(Cartas[] Cadastros, string[] arquivo)
        {
            string novoCod;
            char novoNum, novaLetra;
            Random sorteio = new Random();
            bool existe;
            do
            {
                existe = false;
                novoNum = Convert.ToChar(sorteio.Next(49, 57)); //48=0 ... 57=9 (Decimal ASCII)
                novaLetra = Convert.ToChar(sorteio.Next(65, 69)); //65=A ... 90=Z (Decimal ASCII)
                novoCod = (novoNum).ToString() + (novaLetra).ToString();
                for (int i = 0; i < arquivo.Length; i++)
                {
                    if (Cadastros[i].codigo == novoCod)
                        existe = true;
                }
            }
            while (existe == true);

            return novoCod;
        }

        /// <summary>
        /// Faz a validação de quando habilitar os botões de + e - para o evitar do usurário 
        /// clicar e o valor da progressBar passar de 0 ou 100
        /// </summary>
        /// <param name="progressBar">referencia a progressBar correspondente</param>
        /// <param name="btnMais">referencia o botão correspondente</param>
        /// <param name="btnMenos">referencia o botão correspondente</param>
        static void HabilitaMaisMenos(ref ProgressBar progressBar, ref Button btnMais, ref Button btnMenos)
        {
            if (progressBar.Value == 100)
                btnMais.Enabled = false;
            else if (progressBar.Value < 100)
                btnMais.Enabled = true;

            if (progressBar.Value == 0)
                btnMenos.Enabled = false;
            else if (progressBar.Value > 0)
                btnMenos.Enabled = true;
        }

        #endregion

        public frCadastro()
        {
            InitializeComponent();

            //Carrega dados de cartas.txt
            if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\cartas.txt"))
            {
                arquivo = File.ReadAllLines("cartas.txt", Encoding.Default);
                Cadastros = new Cartas[arquivo.Length];
                CarregaArquivo(ref Cadastros, ref arquivo);
            }
            else
                File.AppendAllText("cartas.txt", null);

            //Verifica se há algum cadastro, se não há, atribui à carta o CodInterno = 0
            if (arquivo == null || arquivo.Length == 0)
            {
                lblCodInterno.Text = "0";
                HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, 0, 0);
            }

            //Verifica se a quantidade máxima de cadastros já foi atingida
            else if (arquivo.Length == 32)
            {
                btnAnterior.Enabled = false;
                btnProximo.Enabled = true;
                btnNovo.Enabled = false;
                int ultimoCodInterno = Convert.ToInt16(Cadastros[arquivo.Length - 1].codInterno);
                MostrarCarta(ultimoCodInterno, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                             ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                             ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                             ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                             ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                             ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas,
                             ref Cadastros, ref arquivo, Convert.ToInt16(lblCodInterno.Text));
                HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, 0, ultimoCodInterno);
                ApagaImgSemUso(Cadastros);
            }

            //Cajo haja algum cadastro, exibe primeira carta cadastrada
            else
            {
                int ultimoCodInterno = Convert.ToInt16(Cadastros[arquivo.Length - 1].codInterno);
                lblCodInterno.Text = "0";
                MostrarCarta(ultimoCodInterno, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                             ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                             ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                             ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                             ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                             ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas,
                             ref Cadastros, ref arquivo, Convert.ToInt16(lblCodInterno.Text));
                HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, 0, ultimoCodInterno);
                ApagaImgSemUso(Cadastros);
            }

            //HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, Convert.ToInt16(lblCodInterno.Text), arquivo.Length - 1);
        }

        #region Eventos

        /// <summary>
        /// Evento click do btnSalvar que salva uma carta nova ou realiza uma alteração
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            arquivo = File.ReadAllLines("cartas.txt", Encoding.Default);
            Cadastros = new Cartas[arquivo.Length];
            CarregaArquivo(ref Cadastros, ref arquivo);
            bool ok = ValidaCarta(txtNome, ptbImagemCarta);
            string acao = VerificaAcao(ref Cadastros, ref arquivo, lblCodInterno.Text);
            string[] dados = new string[arquivo.Length + 1];

            if (acao == "salvar novo")
            {
                if (ok == true)
                {
                    int i = 0;
                    foreach (string linha in arquivo)
                        dados[i++] = linha;

                    string novoCod = SorteiaCodigo(Cadastros, arquivo);
                    if (novoCod == "-1")
                    {
                        MessageBox.Show("Número máximo de cartas cadastradas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else
                    {
                        dados[arquivo.Length] = lblCodInterno.Text + " | " +
                                                novoCod + " | " +
                                                txtNome.Text.Trim() + " | " +
                                                progressBarSono.Value.ToString() + " | " +
                                                progressBarFome.Value.ToString() + " | " +
                                                progressBarRaiva.Value.ToString() + " | " +
                                                progressBarMalandragem.Value.ToString() + " | " +
                                                progressBarHumanas.Value.ToString() + " | " +
                                                ptbImagemCarta.ImageLocation.Replace(Path.GetDirectoryName(Application.ExecutablePath), null);

                        File.WriteAllLines("cartas.txt", dados, Encoding.Default);

                        MessageBox.Show("Salvo com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int ultimoCodInterno;
                        if (arquivo.Length == 0)
                            ultimoCodInterno = 0;
                        else
                            ultimoCodInterno = Convert.ToInt16(Cadastros[arquivo.Length - 1].codInterno) + 1;

                        LimpaTelaCadastro(ultimoCodInterno, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                                          ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                                          ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                                          ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                                          ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                                          ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);

                        HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, Convert.ToInt16(lblCodInterno.Text), arquivo.Length - 1);
                        btnProximo.Enabled = false;

                    }

                }
            }
            else if (acao == "alterar")
            {

                if (ok == true)
                {
                    int posicaoVetor = Convert.ToInt16(lblCodInterno.Text);
                    dados[posicaoVetor] = lblCodInterno.Text + " | " +
                                          lblCodigo.Text + " | " +
                                          txtNome.Text.Trim() + " | " +
                                          progressBarSono.Value.ToString() + " | " +
                                          progressBarFome.Value.ToString() + " | " +
                                          progressBarRaiva.Value.ToString() + " | " +
                                          progressBarMalandragem.Value.ToString() + " | " +
                                          progressBarHumanas.Value.ToString() + " | " +
                                          ptbImagemCarta.ImageLocation.Replace(Path.GetDirectoryName(Application.ExecutablePath), null);

                    File.WriteAllText("cartas.txt", null);

                    for (int i = 0; i < arquivo.Length; i++)
                    {
                        if (i == posicaoVetor)
                        {
                            File.AppendAllText("cartas.txt", dados[i] + Environment.NewLine, Encoding.Default);
                        }
                        else
                            File.AppendAllText("cartas.txt", arquivo[i] + Environment.NewLine, Encoding.Default);
                    }

                    MessageBox.Show("Alterado com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, Convert.ToInt16(lblCodInterno.Text), arquivo.Length - 1);

            }
        }

        /// <summary>
        /// Este evento chama o método LimpaTelaCadastro() que irá restaurar cada componente
        /// da tela de cadastro aos valores iniciais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCarregarImagem.Enabled = true;
            if (arquivo.Length == 0)
                return;
            int ultimoCodInterno = Convert.ToInt16(Cadastros[arquivo.Length - 1].codInterno);
            LimpaTelaCadastro(ultimoCodInterno, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                              ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                              ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                              ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                              ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                              ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);
            if (arquivo.Length == 1)
            {
                btnAnterior.Enabled = true;
                btnProximo.Enabled = false;
            }
            else
                HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, Convert.ToInt16(lblCodInterno.Text) - 1, arquivo.Length - 1);
        }

        /// <summary>
        /// Abre a janela de Pesquisa que retonará a posição do cadastro da carta no vetor arquivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            frProcurarCadastro Procurar = new frProcurarCadastro();
            Procurar.ShowDialog();
            arquivo = File.ReadAllLines("cartas.txt", Encoding.Default);
            if (arquivo.Length == 0)
                return;
            Cadastros = new Cartas[arquivo.Length];
            CarregaArquivo(ref Cadastros, ref arquivo);
            int ultimoCodInterno = Convert.ToInt16(Cadastros[arquivo.Length - 1].codInterno);
            int pesquisa = Procurar.codInterno;
            if (pesquisa == -1)
                return;
            MostrarCarta(ultimoCodInterno, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                         ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                         ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                         ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                         ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                         ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas,
                         ref Cadastros, ref arquivo, Procurar.codInterno);
            HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, pesquisa, arquivo.Length - 1);
        }

        /// <summary>
        /// Este método além de excluir a carta, atribui novos códigos internos a cada carta       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            arquivo = File.ReadAllLines("cartas.txt", Encoding.Default);
            Cadastros = new Cartas[arquivo.Length];
            CarregaArquivo(ref Cadastros, ref arquivo);

            if (arquivo.Length == 0)
                return;
            // Se o código atual for de uma carta ainda não cadastrada, não faz nada
            else if (Convert.ToInt16(lblCodInterno.Text) > Cadastros[arquivo.Length - 1].codInterno)
                return;
            // Se Houver mais que uma carta cadastrada, exclui a carta e redefine o código interno das cartas seguintes
            else if (arquivo.Length > 1)
            {
                string[] novoArquivo = new string[arquivo.Length - 1];

                int codAtual = Convert.ToInt16(lblCodInterno.Text);

                File.WriteAllText("cartas.txt", null);

                for (int i = 0; i < codAtual; i++)
                {
                    novoArquivo[i] = arquivo[i];
                }

                for (int i = (codAtual + 1); i < arquivo.Length; i++)
                {
                    novoArquivo[i - 1] = (Convert.ToInt16((arquivo[i][0]).ToString()) - 1).ToString() +
                                 arquivo[i].Substring(1, arquivo[i].Length - 1);
                }

                File.AppendAllLines("cartas.txt", novoArquivo, Encoding.Default);

                arquivo = File.ReadAllLines("cartas.txt", Encoding.Default);
                Cadastros = new Cartas[arquivo.Length];
                CarregaArquivo(ref Cadastros, ref arquivo);

                int ultimoCodInterno = Convert.ToInt16(Cadastros[arquivo.Length - 1].codInterno);
                int proxCodInterno = ultimoCodInterno + 1;
                LimpaTelaCadastro(ultimoCodInterno, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                                  ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                                  ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                                  ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                                  ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                                  ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);
                HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, proxCodInterno, ultimoCodInterno);
                //btnProximo.Enabled = false;
            }
            // Se houver apenas uma, exclui a carta e define o próximo código como 0
            else if (arquivo.Length == 1)
            {
                File.WriteAllText("cartas.txt", null);
                int ultimoCodInterno = -1;
                LimpaTelaCadastro(ultimoCodInterno, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                                  ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                                  ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                                  ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                                  ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                                  ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);
                HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, 0, 0);
                //btnProximo.Enabled = false;
            }
            else
                return;
        }

        /// <summary>
        /// Chama o método CarregaImagemCadastro e passa por referência o openFileDiologCadastro, o btnRemoverImgem e a ptbImagemCarta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            //armazena todos os nomes das imagens para pegar o ultimo código
            string[] filesNames = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath) + "\\Imagens\\Cartas\\");

            //caso não haja imagem na pasta atribui como último código -1
            if (filesNames.Length == 0)
            {
                Array.Resize(ref filesNames, 1);
                filesNames[0] = "0";
            }

            //remove o ultimo vetor que armazena o caminho do arquivo desktop.ini
            else if (filesNames[filesNames.Length - 1] == Path.GetDirectoryName(Application.ExecutablePath) + "\\Imagens\\Cartas\\desktop.ini")
            {
                Array.Resize(ref filesNames, filesNames.Length - 1);
                if (filesNames.Length == 0)
                {
                    Array.Resize(ref filesNames, 1);
                    filesNames[0] = "0";
                }
            }

            openFileDiologCadastro.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDiologCadastro.ShowDialog() == DialogResult.OK)
            {
                string caminhoDestino = Path.GetDirectoryName(Application.ExecutablePath) + "\\Imagens\\Cartas\\";

                string nomeImagem;
                //caso haja imagem cadastrada
                if (filesNames[0] != "0")
                {
                    //remove o caminho e a extensão da imagem, deixando apenas o índice
                    int maiorIndice = Convert.ToInt32(filesNames[0].Replace(caminhoDestino, null).Replace(Path.GetExtension(filesNames[0]), null));
                    //armazena o maior indice
                    for (int i = 1; i < filesNames.Length; i++)
                    {
                        int indice = Convert.ToInt32(filesNames[i].Replace(caminhoDestino, null).Replace(Path.GetExtension(filesNames[i]), null));
                        if (indice > maiorIndice)
                            maiorIndice = indice;
                    }

                    //Define o indice da nova imagem carregada
                    nomeImagem = (maiorIndice + 1).ToString() + Path.GetExtension(Path.GetFileName(openFileDiologCadastro.FileName));
                }
                //Caso seja a primeira carta a ser cadastrada, seu título será 0 + extensão da imagem carregada
                else
                    nomeImagem = filesNames[0] + Path.GetExtension(Path.GetFileName(openFileDiologCadastro.FileName));

                string caminhoOrigem = openFileDiologCadastro.FileName;

                if (Directory.Exists(caminhoDestino) == false)
                    Directory.CreateDirectory(caminhoDestino);

                try
                {
                    File.Copy(caminhoOrigem, caminhoDestino + nomeImagem, true);
                    if (File.Exists(caminhoDestino + nomeImagem) == true)
                    {
                        ptbImagemCarta.ImageLocation = caminhoDestino + nomeImagem;
                        ptbImagemCarta.Load();
                        btnRemoverImgem.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro, tente novamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Remove a imagem atual da ptbImagemCarta e desabilita o btnRemoverImagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverImgem_Click(object sender, EventArgs e)
        {
            ptbImagemCarta.ImageLocation = null;
            btnRemoverImgem.Enabled = false;
            btnCarregarImagem.Enabled = true;
        }

        /// <summary>
        /// Mostra a carta anterior chamando o método MostrarCarta() e passando o código da 
        /// carta anterior. Enquanto isso valida antes e depois de chamar o método 
        /// MostrarCarta() se deve habilitar ou desabilitar os botões btnProximo e btnAnterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            arquivo = File.ReadAllLines("cartas.txt", Encoding.Default);
            Cadastros = new Cartas[arquivo.Length];
            CarregaArquivo(ref Cadastros, ref arquivo);
            int codAnterior = Convert.ToInt16(lblCodInterno.Text) - 1;
            HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, codAnterior, arquivo.Length - 1);
            MostrarCarta(0, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                         ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                         ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                         ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                         ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                         ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas,
                         ref Cadastros, ref arquivo, codAnterior);
            if (arquivo.Length == 1)
            {
                btnAnterior.Enabled = true;
                btnProximo.Enabled = false;
            }
            else
                HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, codAnterior, arquivo.Length - 1);
        }

        /// <summary>
        /// Mostra a próxima carta chamando o método MostrarCarta() e passando o código da 
        /// próxima carta. Enquanto isso valida antes e depois de chamar o método 
        /// MostrarCarta() se deve habilitar ou desabilitar os botões btnProximo e btnAnterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProximo_Click(object sender, EventArgs e)
        {
            arquivo = File.ReadAllLines("cartas.txt", Encoding.Default);
            Cadastros = new Cartas[arquivo.Length];
            CarregaArquivo(ref Cadastros, ref arquivo);
            int codProximo = Convert.ToInt16(lblCodInterno.Text) + 1;
            HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, codProximo, arquivo.Length - 1);
            MostrarCarta(0, ref btnCarregarImagem, ref lblCodInterno, ref lblCodigo, ref txtNome, ref ptbImagemCarta, ref btnRemoverImgem,
                         ref lblSonoForca, ref progressBarSono, ref btnMaisSono, ref btnMenosSono,
                         ref lblFomeForca, ref progressBarFome, ref btnMaisFome, ref btnMenosFome,
                         ref lblRaivaForca, ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva,
                         ref lblMalandragemForca, ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem,
                         ref lblHumanasForca, ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas,
                         ref Cadastros, ref arquivo, codProximo);
            HabilitaDesabilitaCursores(ref btnAnterior, ref btnProximo, codProximo, arquivo.Length - 1);
        }

        #region Botões + e -

        #region Sono
        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenosSono_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarSono, ref btnMaisSono, ref btnMenosSono);
            progressBarSono.Value = progressBarSono.Value - 10;
            lblSonoForca.Text = progressBarSono.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarSono, ref btnMaisSono, ref btnMenosSono);
        }

        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaisSono_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarSono, ref btnMaisSono, ref btnMenosSono);
            progressBarSono.Value = progressBarSono.Value + 10;
            lblSonoForca.Text = progressBarSono.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarSono, ref btnMaisSono, ref btnMenosSono);
        }
        #endregion

        #region Fome
        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenosFome_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarFome, ref btnMaisFome, ref btnMenosFome);
            progressBarFome.Value = progressBarFome.Value - 10;
            lblFomeForca.Text = progressBarFome.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarFome, ref btnMaisFome, ref btnMenosFome);
        }

        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaisFome_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarFome, ref btnMaisFome, ref btnMenosFome);
            progressBarFome.Value = progressBarFome.Value + 10;
            lblFomeForca.Text = progressBarFome.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarFome, ref btnMaisFome, ref btnMenosFome);
        }
        #endregion

        #region Raiva
        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenosRaiva_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva);
            progressBarRaiva.Value = progressBarRaiva.Value - 10;
            lblRaivaForca.Text = progressBarRaiva.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva);
        }

        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaisRaiva_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva);
            progressBarRaiva.Value = progressBarRaiva.Value + 10;
            lblRaivaForca.Text = progressBarRaiva.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarRaiva, ref btnMaisRaiva, ref btnMenosRaiva);
        }
        #endregion

        #region Malandragem
        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenosMalandragem_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem);
            progressBarMalandragem.Value = progressBarMalandragem.Value - 10;
            lblMalandragemForca.Text = progressBarMalandragem.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem);
        }

        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaisMalandragem_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem);
            progressBarMalandragem.Value = progressBarMalandragem.Value + 10;
            lblMalandragemForca.Text = progressBarMalandragem.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarMalandragem, ref btnMaisMalandragem, ref btnMenosMalandragem);
        }
        #endregion

        #region Humanas
        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenosHumanas_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);
            progressBarHumanas.Value = progressBarHumanas.Value - 10;
            lblHumanasForca.Text = progressBarHumanas.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);
        }

        /// <summary>
        /// Faz a validação primeiro pra ver se deve habilitar ou desabilitar 
        /// os botões + e -, faz a soma ou subtração do valor da barra e 
        /// faz a validação novamente com essa alteração.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaisHumanas_Click(object sender, EventArgs e)
        {
            HabilitaMaisMenos(ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);
            progressBarHumanas.Value = progressBarHumanas.Value + 10;
            lblHumanasForca.Text = progressBarHumanas.Value.ToString() + " %";
            HabilitaMaisMenos(ref progressBarHumanas, ref btnMaisHumanas, ref btnMenosHumanas);
        }
        #endregion

        #endregion

        /// <summary>
        /// Fecha a tela de cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
