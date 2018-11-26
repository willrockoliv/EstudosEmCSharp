using System;
using System.IO;
using NAudio.Wave;
using System.Xml.Linq;

namespace Library.Classes
{
    public class Musica : Midia, ILocal
    {
        #region Atributos
        int _volume = 5;
        string _arquivoMidia;
        #endregion

        #region Inicializadores
        public Musica()
        {
            Tipo = EMidia.Musica;
        }

        public Musica(string arquivoMidia)
        {
            Tipo = EMidia.Musica;
            ArquivoMidia = arquivoMidia;
        }

        public Musica(XElement xElement) : base(xElement)
        {
            XElement x = XElement.Parse(xElement.FirstNode.ToString());
            Tipo = EMidia.Musica;
            Volume = int.Parse(x.Attribute("Volume").Value);
            Duracao = double.Parse(x.Attribute("Duracao").Value.Replace('.', ','));
            Formato = (EFormatoMusica)Enum.Parse(typeof(EFormatoMusica), x.Attribute("Formato").Value);
            _arquivoMidia = Localizacao + ArquivoDados;
        }
        #endregion

        #region Propriedades
        public string Localizacao { get; } = "Arquivos\\Midias\\Musicas\\";
        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value < 0)
                    throw new Exception();
                _volume = value;
            }
        }
        public double Duracao { get; private set; } = 0;
        public EFormatoMusica Formato { get; private set; }
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
                    Formato = (EFormatoMusica)Enum.Parse(typeof(EFormatoMusica), Path.GetExtension(value).TrimStart('.'));
                    AudioFileReader audio = new AudioFileReader(value);
                    Duracao = Math.Round((audio.TotalTime.Minutes + (double)audio.TotalTime.Seconds / 100),2);
                    audio.Close();
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
            x.Add(new XAttribute("Volume", Volume));
            x.Add(new XAttribute("Duracao", Duracao));
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
            return string.Format("{0} Volume: {1} | Duração: {2} | Formato: {3} | Midia: {4} |", base.ToString(), Volume, Duracao, Formato, ArquivoMidia);
        }
        #endregion
    }

}
