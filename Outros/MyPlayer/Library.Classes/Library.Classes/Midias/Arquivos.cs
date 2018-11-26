using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library.Classes
{
    public static class Arquivos
    {
        #region Propriedades
        static OpenFileDialog Dialog = new OpenFileDialog();
        #endregion

        #region Metodos
        static string Filter()
        {
            return string.Format("{0}|{1}|{2}|{3}", FilterMusica(), FilterVideo(), FilterFoto(),FilterArquivo());
        }

        #region Musica
        static string FilterMusica()
        {
            string retorno = string.Empty;
            foreach (string formato in Enum.GetNames(typeof(EFormatoMusica)))
                retorno += $"*.{formato};";
            return string.Format("Musicas|{0}", retorno.TrimEnd(';'));
        }

        public static Musica PegarMusica()
        {
            Dialog.Multiselect = false;
            Dialog.Filter = FilterMusica();
            if (Dialog.ShowDialog() == DialogResult.OK)
                return new Musica(Dialog.FileName);
            else
                return null;
        }

        public static Lista<Musica> PegarMusicas()
        {
            Dialog.Multiselect = true;
            Dialog.Filter = FilterMusica();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                var musicas = new Lista<Musica>();
                foreach (string fileName in Dialog.FileNames)
                    musicas.Inserir(new Musica(fileName));
                return musicas;
            }
            else
                return null;
        }
        #endregion

        #region Video
        static string FilterVideo()
        {
            string retorno = string.Empty;
            foreach (string formato in Enum.GetNames(typeof(EFormatoVideo)))
                retorno += $"*.{formato};";
            return string.Format("Videos|{0}", retorno.TrimEnd(';'));
        }

        public static Video PegarVideo()
        {
            Dialog.Multiselect = false;
            Dialog.Filter = FilterVideo();
            if (Dialog.ShowDialog() == DialogResult.OK)
                return new Video(Dialog.FileName);
            else
                return null;
        }

        public static Lista<Video> PegarVideos()
        {
            Dialog.Multiselect = true;
            Dialog.Filter = FilterVideo();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                var videos = new Lista<Video>();
                foreach (string fileName in Dialog.FileNames)
                    videos.Inserir(new Video(fileName));
                return videos;
            }
            else
                return null;
        }
        #endregion

        #region Foto
        static string FilterFoto()
        {
            string retorno = string.Empty;
            foreach (string formato in Enum.GetNames(typeof(EFormatoFoto)))
                retorno += $"*.{formato};";
            return string.Format("Fotos|{0}", retorno.TrimEnd(';'));
        }

        public static Foto PegarFoto()
        {
            Dialog.Multiselect = false;
            Dialog.Filter = FilterFoto();
            if (Dialog.ShowDialog() == DialogResult.OK)
                return new Foto(Dialog.FileName);
            else
                return null;
        }

        public static Lista<Foto> PegarFotos()
        {
            Dialog.Multiselect = true;
            Dialog.Filter = FilterFoto();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                var fotos = new Lista<Foto>();
                foreach (string fileName in Dialog.FileNames)
                    fotos.Inserir(new Foto(fileName));
                return fotos;
            }
            else
                return null;
        }
        #endregion

        #region Todos
        static string FilterArquivo()
        {
            string retorno = string.Empty;
            foreach (string formato in Enum.GetNames(typeof(EFormatoMusica)))
                retorno += $"*.{formato};";
            foreach (string formato in Enum.GetNames(typeof(EFormatoVideo)))
                retorno += $"*.{formato};";
            foreach (string formato in Enum.GetNames(typeof(EFormatoFoto)))
                retorno += $"*.{formato};";
            return string.Format("Todos|{0}", retorno.TrimEnd(';'));
        }

        public static Midia PegarArquivo()
        {
            Dialog.Multiselect = false;
            Dialog.Filter = Filter();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                switch (Dialog.FilterIndex)
                {
                    case 1:
                        return new Musica(Dialog.FileName);
                    case 2:
                        return new Video(Dialog.FileName);
                    case 3:
                        return new Foto(Dialog.FileName);
                    default:
                        return GetMidia(Dialog.FileName);
                }
            }
            else
                return null;
        }

        public static Lista<Midia> PegarArquivos()
        {
            Dialog.Multiselect = true;
            Dialog.Filter = Filter();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                var midias = new Lista<Midia>();
                foreach (string fileName in Dialog.FileNames)
                {
                    switch (Dialog.FilterIndex)
                    {
                        case 1:
                            midias.Inserir(new Musica(Dialog.FileName));
                            break;
                        case 2:
                            midias.Inserir(new Video(Dialog.FileName));
                            break;
                        case 3:
                            midias.Inserir(new Foto(Dialog.FileName));
                            break;
                        default:
                            midias.Inserir(GetMidia(fileName));
                            break;
                    }
                }
                return midias;
            }
            else
                return null;
        }

        static Midia GetMidia(string fileName)
        {
            string extension = Path.GetExtension(fileName).TrimStart('.');
            EFormatoMusica eMusica;
            EFormatoVideo eVideo;
            EFormatoFoto eFoto;
            if (Enum.TryParse(extension, out eMusica))
                return new Musica(fileName);
            else if (Enum.TryParse(extension, out eVideo))
                return new Video(fileName);
            else if (Enum.TryParse(extension, out eFoto))
                return new Foto(fileName);
            else
                throw new Exception();
            
        }
        #endregion
        #endregion
    }
}
