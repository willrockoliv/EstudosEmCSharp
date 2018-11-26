using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public class Musica : Midia, ILocal
    {
        public enum FormatoEnum { MP3, WAV, WMA }

        private string arquivoMidia;
        private double duracao;
        private int volume;
        private FormatoEnum formato = new FormatoEnum();

        public FormatoEnum Formato { get { return formato; } set { formato = value; } }
        public string ArquivoMidia { get { return arquivoMidia; } set { arquivoMidia = value; } } //local e nome do arquivo da mídia
        public double Duracao { get { return duracao; } set { duracao = value; } }
        public int Volume { get { return volume; } set { volume = value; } } //volume da música, para ser utilizado no media player

        public bool ValidaCaminho()
        {
            return File.Exists(arquivoMidia);
        }

        public bool ValidaCaminho(string caminho)
        {
            return File.Exists(caminho);
        }

        public override string ToString()
        {
            return base.ToString() + "|<Midia>Musica" + "|<ArquivoMidia>" + ArquivoMidia + "|<Formato>" + Formato + "|<Duracao>" + Duracao + "|<Volume>" + Volume;
        }

        /// <summary>
        /// compara o formato do arquivo importado com os formatos disponíveis no enum Musica.FormatoEnum
        /// </summary>
        /// <param name="formato">formato da mídia importada</param>
        /// <returns>retorna um enum correspondente ao formato da mídia importada</returns>
        public FormatoEnum EFormatoMusica(string formato)
        {
            if (formato == FormatoEnum.MP3.ToString())
                return FormatoEnum.MP3;
            else if (formato == FormatoEnum.WAV.ToString())
                return FormatoEnum.WAV;
            else if (formato == FormatoEnum.WMA.ToString())
                return FormatoEnum.WMA;
            else
                throw new Exception("Formato de mídia inválido");
        }
    }
}
