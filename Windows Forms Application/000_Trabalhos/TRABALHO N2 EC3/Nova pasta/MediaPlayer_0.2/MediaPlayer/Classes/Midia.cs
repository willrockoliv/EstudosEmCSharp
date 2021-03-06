﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MediaPlayer
{
    public abstract class Midia : Object
    {
        int id;
        string descricao;
        string arquivoDeDados;

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 0)
                    id = value;
                else
                    throw new Exception("ID inválido");
            }
        }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public string ArquivoDeDados { get { return arquivoDeDados; } set { arquivoDeDados = value; } } //local e nome do arquivo de dados(onde as mídias serão armazenadas)

        // inclui  um novo elemento no arquivo. Não permita Id´s repetidos independente do tipo de mídia
        public void Inclui(string dados, int p_id)
        {
            string[] cadastro = CarregaCadastroTXT();

            bool existeID = false;

            foreach (string linha in cadastro)
            {
                string[] temp = linha.Split('|');
                if (temp[0].Replace("<Id>", "") == p_id.ToString())
                    existeID = true;
            }

            if (existeID)
                throw new Exception("Já existe um cadastro com ID: " + p_id);
            else
                File.AppendAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\cadastro.txt", dados + Environment.NewLine, Encoding.Default);
        }

        public abstract void Alterar(); // altera o emento no arquivo

        public abstract void Excluir(); // exclui o elemento do arquivo

        // preenche os atributos da classe com o id do elemento informado.
        public static Midia Consultar(int p_id)
        {
            string[] cadastro = CarregaCadastroTXT();
            foreach (string linha in cadastro)
            {
                string[] temp = linha.Split('|');
                if (temp[0].Replace("<Id>", "") == p_id.ToString())
                {
                    if (temp[3].Replace("<Midia>", "") == "Musica")
                    {
                        Musica Musica = new Musica();
                        Musica.Id = p_id;
                        Musica.Descricao = temp[1].Replace("<Descricao>", "");
                        Musica.ArquivoDeDados = temp[2].Replace("<ArquivoDeDados>", "");
                        Musica.ArquivoMidia = temp[4].Replace("<ArquivoMidia>", "");
                        Musica.Formato = Musica.EFormatoMusica(temp[5].Replace("<Formato>", ""));
                        Musica.Duracao = Convert.ToDouble(temp[6].Replace("<Duracao>", ""));
                        Musica.Volume = Convert.ToInt32(temp[7].Replace("<Volume>", ""));
                        return Musica;
                    }
                    else if (temp[3].Replace("<Midia>", "") == "Foto")
                    {
                        Foto Foto = new Foto();
                        Foto.Id = p_id;
                        Foto.Descricao = temp[1].Replace("<Descricao>", "");
                        Foto.ArquivoDeDados = temp[2].Replace("<ArquivoDeDados>", "");
                        Foto.ArquivoMidia = temp[4].Replace("<ArquivoMidia>", "");
                        Foto.AnoLancamento = Convert.ToInt32(temp[5].Replace("<AnoLancamento>", ""));
                        Foto.Local = temp[6].Replace("<Local>", "");
                        Foto.MegaPixels = Convert.ToDouble(temp[7].Replace("<MegaPixels>", ""));
                        Foto.TempoEmSegundosParaExibir = Convert.ToInt32(temp[8].Replace("<TempoEmSegundosParaExibir>", ""));
                        return Foto;
                    }
                    else if (temp[3].Replace("<Midia>", "") == "Video")
                    {
                        Video Video = new Video();
                        Video.Id = p_id;
                        Video.Descricao = temp[1].Replace("<Descricao>", "");
                        Video.arquivoDeDados = temp[2].Replace("<ArquivoDeDados>", "");
                        Video.ArquivoMidia = temp[4].Replace("<ArquivoMidia>", "");
                        Video.AnoLancamento = Convert.ToInt32(temp[5].Replace("<AnoLancamento>", ""));
                        Video.PossuiLegenda = temp[6].Replace("<PossuiLegenda>", "") == "True";
                        Video.Formato = Video.EFormatoVideo(temp[7].Replace("<Formato>", ""));
                        Video.Idioma = Video.EIdioma(temp[8].Replace("<Idioma>", ""));
                        return Video;
                    }
                }
            }
            throw new Exception("Não existe um cadastro com o ID: " + p_id);
        }

        /// <summary>
        /// Carrega um arquivo cadastro.txt
        /// </summary>
        /// <param name="caminhoArquivo"></param>
        /// <returns>vetor com as linhas do arquivo</returns>
        public static string[] CarregaCadastroTXT()
        {
            string caminhoArquivo = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\cadastro.txt";

            if (File.Exists(caminhoArquivo) == false)
                File.WriteAllText(caminhoArquivo, null);

            return File.ReadAllLines(caminhoArquivo, Encoding.Default);
        }

        public override string ToString()
        {
            return "<Id>" + Id + "|<Descricao>" + Descricao + "|<ArquivoDeDados>" + ArquivoDeDados;
        }
    }
}
