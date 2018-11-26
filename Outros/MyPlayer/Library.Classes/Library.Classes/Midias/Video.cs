using System;
using System.IO;
using System.Xml.Linq;

namespace Library.Classes
{
    public class Video : Midia, ILocal, ICatalogo
    {
        #region Atributos
        int _anoLancamento = int.Parse(DateTime.Now.ToString("yyyy"));
        string _arquivoMidia;
        #endregion

        #region Inicializadores
        public Video()
        {
            Tipo = EMidia.Video;
        }

        public Video(string arquivoMidia)
        {
            Tipo = EMidia.Video;
            ArquivoMidia = arquivoMidia;
        }

        public Video(XElement xElement) : base(xElement)
        {
            XElement x = XElement.Parse(xElement.FirstNode.ToString());
            Tipo = EMidia.Video;
            Formato = (EFormatoVideo)Enum.Parse(typeof(EFormatoVideo), x.Attribute("Formato").Value);
            Idioma = (EIdioma)Enum.Parse(typeof(EIdioma), x.Attribute("Idioma").Value);
            Legenda = bool.Parse(x.Attribute("Legenda").Value);
            AnoLancamento = int.Parse(x.Attribute("AnoLancamento").Value);
            _arquivoMidia = Localizacao + ArquivoDados;
        }
        #endregion

        #region Propriedades
        public string Localizacao { get; } = "Arquivos\\Midias\\Videos\\";
        public EFormatoVideo Formato { get; private set; }
        public EIdioma Idioma { get; set; }
        public bool Legenda { get; set; }
        public int AnoLancamento
        {
            get
            {
                return _anoLancamento;
            }
            set
            {
                if (int.Parse(DateTime.Now.ToString("yyyy")) < value)
                    throw new Exception();
                _anoLancamento = value;
            }
        }
        public string ArquivoMidia
        {
            get
            {
                return _arquivoMidia;
            }
            set
            {
                try
                {
                    Nome = Path.GetFileNameWithoutExtension(value);
                    Formato = (EFormatoVideo)Enum.Parse(typeof(EFormatoVideo), Path.GetExtension(value).TrimStart('.'));
                }
                catch
                {
                    throw new Exception();
                }
                _arquivoMidia = value;
            }
        }
        #endregion

        #region Metodos
        protected override XElement PegarElement()
        {
            XElement x = new XElement("Video");
            x.Add(new XAttribute("AnoLancamento", AnoLancamento));
            x.Add(new XAttribute("Idioma", Idioma));
            x.Add(new XAttribute("Legenda", Legenda));
            x.Add(new XAttribute("Formato", Formato));
            return x;
        }

        public override void Incluir()
        {
            if (Id == -1 && ValidaCaminho())
            {
                ArquivoDados = $"{Nome}.{Formato}";
                base.Incluir();

                File.Copy(ArquivoMidia, Localizacao + ArquivoDados, true);
                _arquivoMidia = Localizacao + ArquivoDados;
            }
        }

        public override void Alterar()
        {
            if (Id != -1 && ValidaCaminho())
            {
                if (!string.Equals(Localizacao + ArquivoDados, ArquivoMidia))
                {
                    File.Delete(Localizacao + ArquivoDados);
                    ArquivoDados = $"{Nome}.{Formato}";
                    File.Copy(ArquivoMidia, Localizacao + ArquivoDados, true);
                    _arquivoMidia = Localizacao + ArquivoDados;
                }
                else if (!string.Equals(ArquivoDados, $"{Id}-{Nome}.{Formato}"))
                {
                    ArquivoDados = $"{Nome}.{Formato}";
                    File.Copy(ArquivoMidia, Localizacao + ArquivoDados, true);
                    File.Delete(ArquivoMidia);
                    _arquivoMidia = Localizacao + ArquivoDados;
                }
                base.Alterar();
            }
        }

        public override void Excluir()
        {
            if (Id != -1)
            {
                base.Excluir();
                if (ValidaCaminho())
                    File.Delete(Localizacao + ArquivoDados);
            }
        }

        public bool ValidaCaminho()
        {
            return File.Exists(ArquivoMidia);
        }

        public override string ToString()
        {
            return string.Format("{0} Lançamento: {1} | Idioma: {2} | Legenda: {3} | Formato: {4} | Midia: {5} |", base.ToString(), AnoLancamento, Idioma, Legenda, Formato, ArquivoMidia);
        }
        #endregion
    }
}
