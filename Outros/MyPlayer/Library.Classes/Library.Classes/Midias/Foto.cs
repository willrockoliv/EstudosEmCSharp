using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library.Classes
{
    public class Foto : Midia, ILocal, ICatalogo
    {
        #region Atributos
        int _segundos = 1;
        double _megaPixels = 1.0;
        int _anoLancamento = int.Parse(DateTime.Now.ToString("yyyy"));
        string _arquivoMidia;
        #endregion

        #region Inicializadores
        public Foto()
        {
            Tipo = EMidia.Foto;
        }

        public Foto(string arquivoMidia)
        {
            Tipo = EMidia.Foto;
            ArquivoMidia = arquivoMidia;
        }

        public Foto(XElement xElement) : base(xElement)
        {
            XElement x = XElement.Parse(xElement.FirstNode.ToString());
            Tipo = EMidia.Foto;
            Formato = (EFormatoFoto)Enum.Parse(typeof(EFormatoFoto), x.Attribute("Formato").Value);
            MegaPixels = int.Parse(x.Attribute("MegaPixels").Value);
            Segundos = int.Parse(x.Attribute("Segundos").Value);
            AnoLancamento = int.Parse(x.Attribute("AnoLancamento").Value);
            _arquivoMidia = Localizacao + ArquivoDados;
        }
        #endregion

        #region Propriedades
        public string Localizacao { get; } = "Arquivos\\Midias\\Fotos\\";
        public EFormatoFoto Formato { get; private set; }
        public double MegaPixels
        {
            get
            {
                return _megaPixels;
            }
            set
            {
                if (value < 0)
                    throw new Exception();
                _megaPixels = value;
            }
        }
        public int Segundos
        {
            get
            {
                return _segundos;
            }
            set
            {
                if (value < 0)
                    throw new Exception();
                _segundos = value;
            }
        }
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
                    Formato = (EFormatoFoto)Enum.Parse(typeof(EFormatoFoto), Path.GetExtension(value).TrimStart('.'));
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
            x.Add(new XAttribute("MegaPixels", MegaPixels));
            x.Add(new XAttribute("Segundos", Segundos));
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
            return string.Format("{0} Lançamento: {1} | Segundos: {2} | MegaPixels: {3} | Formato: {4} | Midia: {5} |", base.ToString(), AnoLancamento, Segundos, MegaPixels, Formato, ArquivoMidia);
        }
        #endregion
    }
}
