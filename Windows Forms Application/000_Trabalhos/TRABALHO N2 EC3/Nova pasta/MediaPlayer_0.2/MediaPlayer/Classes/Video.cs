using MediaPlayer.EstruturaDeDados;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public class Video : Midia, ILocal, ICatalogo
    {
        public enum FormatoEnum { AVI, WMV, MKV, MP4, MPEG, OUTROS }
        public enum IdiomaEnum { portugues, inglês, espanhol, outros }

        private string arquivoMidia;
        private int anoLancamento;
        private bool possuiLegenda;
        private FormatoEnum formato = new FormatoEnum();
        private IdiomaEnum idioma = new IdiomaEnum();


        public string ArquivoMidia { get { return arquivoMidia; } set { arquivoMidia = value; } } //local e nome do arquivo da mídia
        public int AnoLancamento { get { return anoLancamento; } set { anoLancamento = value; } }
        public bool PossuiLegenda { get { return possuiLegenda; } set { possuiLegenda = value; } }
        public FormatoEnum Formato { get { return formato; } set { formato = value; } }
        public IdiomaEnum Idioma { get { return idioma; } set { idioma = value; } }

        public bool ValidaCaminho()
        {
            return File.Exists(arquivoMidia);
        }

        public bool ValidaCaminho(string caminho)
        {
            return File.Exists(caminho);
        }

        public override void Alterar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        

        public override string ToString()
        {
            return base.ToString() + "|<Midia>Video" + "|<ArquivoMidia>" + ArquivoMidia + "|<AnoLancamento>" + AnoLancamento + "|<PossuiLegenda>" + PossuiLegenda + "|<Formato>" + Formato + "|<Idioma>" + Idioma;
        }

        /// <summary>
        /// compara o idioma do arquivo importado com os formatos disponóveis no enum Video.IdiomaEnum
        /// </summary>
        /// <param name="idioma">idioma da mídia importada</param>
        /// <returns>retorna um enum correspondente ao idioma da mídia importada</returns>
        public IdiomaEnum EIdioma(string idioma)
        {
            if (idioma == IdiomaEnum.portugues.ToString())
                return IdiomaEnum.portugues;
            else if (idioma == IdiomaEnum.inglês.ToString())
                return IdiomaEnum.inglês;
            else if (idioma == IdiomaEnum.espanhol.ToString())
                return IdiomaEnum.espanhol;
            else
                return IdiomaEnum.outros;
        }

        /// <summary>
        /// compara o formato do arquivo importado com os formatos disponpíveis no enum Video.FormatoEnum
        /// </summary>
        /// <param name="formato">formato da mídia importada</param>
        /// <returns>retorna um enum correspondente ao formato da mídia importada</returns>
        public FormatoEnum EFormatoVideo(string formato)
        {
            if (formato == FormatoEnum.AVI.ToString())
                return FormatoEnum.AVI;
            else if (formato == FormatoEnum.MKV.ToString())
                return FormatoEnum.MKV;
            else if (formato == FormatoEnum.MP4.ToString())
                return FormatoEnum.MP4;
            else if (formato == FormatoEnum.MPEG.ToString())
                return FormatoEnum.MPEG;
            else if (formato == FormatoEnum.WMV.ToString())
                return FormatoEnum.WMV;
            else
                return FormatoEnum.OUTROS;
        }
    }
}
