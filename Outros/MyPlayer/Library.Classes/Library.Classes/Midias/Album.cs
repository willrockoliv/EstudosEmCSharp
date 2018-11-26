using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library.Classes
{
    class Album : Midia, ICatalogo
    {
        #region Atributos
        int _anoLancamento = int.Parse(DateTime.Now.ToString("yyyy"));
        #endregion

        #region Inicializadores
        public Album()
        {
            Tipo = EMidia.Album;
        }

        public Album(XElement xElement) : base(xElement)
        {
            XElement x = XElement.Parse(xElement.FirstNode.ToString());
            Tipo = EMidia.Album;
            Artista = x.Attribute("Artista").Value;
            AnoLancamento = int.Parse(x.Attribute("AnoLancamento").Value);
        }
        #endregion

        #region Propriedades
        public string Artista { get; set; }
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
        #endregion

        #region Metodos
        protected override XElement PegarElement()
        {
            XElement x = new XElement("Album");
            x.Add(new XAttribute("Artista", Artista));
            x.Add(new XAttribute("AnoLancamento", AnoLancamento));
            return x;
        }
        #endregion
    }
}
