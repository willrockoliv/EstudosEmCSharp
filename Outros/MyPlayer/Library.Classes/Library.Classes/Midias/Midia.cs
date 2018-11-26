using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace Library.Classes
{
    public abstract class Midia : Object, IDisposable
    {
        #region Atributos
        const string XML = "Arquivos\\Midias.xml";
        string _arquivoDados = string.Empty;
        #endregion

        #region Inicializadores
        public Midia()
        {

        }

        public Midia(XElement xElement)
        {
            Id = int.Parse(xElement.Attribute("Id").Value);
            Nome = xElement.Attribute("Nome").Value;
            Descricao = xElement.Attribute("Descricao").Value;
            ArquivoDados = xElement.Attribute("ArquivoDados").Value;
        }
        #endregion

        #region Propriedades
        public int Id { get; private set; } = -1;
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public EMidia Tipo { get; set; }
        public string ArquivoDados
        {
            get
            {
                if (Id == -1 || _arquivoDados.StartsWith(Id + "-"))
                    return _arquivoDados;
                else
                    return Id + "-" + _arquivoDados;
            }
            protected set
            {
                _arquivoDados = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Pega o XElement Nodo da midia.
        /// </summary>
        /// <returns>XElement</returns>
        abstract protected XElement PegarElement();

        /// <summary>
        /// Salva os dados da midia no arquivo.
        /// </summary>
        public virtual void Incluir()
        {
            XElement element = PegarElement();
            SetId();
            XElement x = new XElement("Midia", element);
            x.Add(new XAttribute("Id", Id));
            x.Add(new XAttribute("Tipo", Tipo));
            x.Add(new XAttribute("Nome", Nome));
            x.Add(new XAttribute("Descricao", Descricao));
            x.Add(new XAttribute("ArquivoDados", ArquivoDados));
            XElement xml = XElement.Load(XML);
            xml.Add(x);
            xml.Save(XML);
        }

        /// <summary>
        /// Altera o elemento no arquivo.
        /// </summary>
        public virtual void Alterar()
        {
            XElement element = PegarElement();
            XElement xml = XElement.Load(XML);
            XElement x = xml.Elements().Where(m => m.Attribute("Id").Value.Equals(Id.ToString())).First();
            if (x != null)
            {
                x.ReplaceNodes(element);
                x.Attribute("Nome").SetValue(Nome);
                x.Attribute("Descricao").SetValue(Descricao);
                x.Attribute("ArquivoDados").SetValue(ArquivoDados);
            }
            xml.Save(XML);
        }

        /// <summary>
        /// Exclui o elemento do arquivo.
        /// </summary>
        public virtual void Excluir()
        {
            XElement xml = XElement.Load(XML);
            XElement x = xml.Elements().Where(m => m.Attribute("Id").Value.Equals(Id)).First();
            if (x != null)
            {
                x.Remove();
                xml.Save(XML);
            }
        }

        /// <summary>
        /// Define o Id apartir do último elemendo gravado.
        /// </summary>
        protected void SetId()
        {
            try
            {
                Id = int.Parse(XElement.Load(XML).Elements().Last().FirstAttribute.Value) + 1;
            }
            catch
            {
                Id = 0;
            }
        }

        /// <summary>
        /// Preenche os atributos da classe com o id do elemento informado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Midia</returns>
        public virtual Midia Consultar(int id)
        {
            XElement x = XElement.Load(XML).Elements().Where(m => m.Attribute("Id").Value.Equals(Id)).First();
            if (x != null)
                return (CriarMidia(x));
            else
                return null;
        }

        /// <summary>
        /// Lista todas as midias.
        /// </summary>
        /// <returns>Lista de T</returns>
        static public Lista<T> Listar<T>() where T : Midia
        {
            string tipo = typeof(T).Name;
            Lista<T> lista = new Lista<T>();
            Func<XElement, bool> func = x => !x.IsEmpty;
            if (tipo != "Midia")
                func = x => x.Attribute("Tipo").Value.Equals(tipo);

            var xml = XElement.Load(XML).Elements().Where(func);
            foreach (var x in xml)
                lista.Inserir((CriarMidia(x) as T));

            return lista;
        }

        /// <summary>
        /// Cria uma nova midia apartir do xElement.
        /// </summary>
        /// <param name="xElement"></param>
        /// <returns>Midia</returns>
        static Midia CriarMidia(XElement xElement)
        {
            switch (xElement.Attribute("Tipo").Value)
            {
                case "Musica":
                    return new Musica(xElement);
                case "Video":
                    return new Video(xElement);
                case "Foto":
                    return new Foto(xElement);
                case "Album":
                    return new Album(xElement);
                default:
                    throw new Exception();
            }
        }

        public override string ToString()
        {
            return string.Format("| Id: {0} | Nome: {1} | Descriçao: {2} | Tipo: {3} |Arquivo: {4} |", Id, Nome, Descricao, Tipo, ArquivoDados);
        }

        public void Dispose()
        {

        }

        ~Midia()
        {
            Dispose();
        }
        #endregion
    }
}
