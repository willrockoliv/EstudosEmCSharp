using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public class AlbumMusical : Midia, ICatalogo
    {
        private int anoLancamento;
        private string artista;
        static string caminhoBD = Path.GetDirectoryName(Application.ExecutablePath) + "\\BD";

        public int AnoLancamento { get { return anoLancamento; } set { anoLancamento = value; } }

        public string Artista { get { return artista; } set { artista = value; } }

        public static void AlteraMusica(string album, string id_musica)
        {
            RemoveMusica(id_musica);
            string[] albuns = CarregaAlbumMusicalTXT();
            AddMusica(album, id_musica);
        }

        public static void RemoveMusica(string id_musica)
        {
            ValidaAlbumMusical();
            string[] albuns = CarregaAlbumMusicalTXT();

            File.WriteAllText(caminhoBD + "\\albumMusical.txt", null);

            foreach (string linha in albuns)
            {
                string new_dado = "";

                string[] cadastro = linha.Split('|');

                foreach (string dado in cadastro)
                {
                    if (dado != id_musica)
                        new_dado = new_dado + "|" + dado;
                }

                new_dado = new_dado.Substring(1, new_dado.Length - 1).Replace("||", "|");

                File.AppendAllText(caminhoBD + "\\albumMusical.txt", new_dado + Environment.NewLine, Encoding.Default);
            }
        }

        public static void AddMusica(string album, string id_musica)
        {
            ValidaAlbumMusical();
            string[] albuns = CarregaAlbumMusicalTXT();
            File.WriteAllText(caminhoBD + "\\albumMusical.txt", null);

            foreach (string linha in albuns)
            {
                string[] cadastro = linha.Split('|');

                if (cadastro[0] == album)
                    File.AppendAllText(caminhoBD + "\\albumMusical.txt", linha + "|" + id_musica + Environment.NewLine, Encoding.Default);
                else
                    File.AppendAllText(caminhoBD + "\\albumMusical.txt", linha + Environment.NewLine, Encoding.Default);
            }
        }

        public static void Salvar(string dados)
        {
            ValidaAlbumMusical();
            File.AppendAllText(caminhoBD + "\\albumMusical.txt", dados + Environment.NewLine, Encoding.Default);
        }

        public static void ValidaAlbumMusical()
        {
            if (!Directory.Exists(caminhoBD))
                Directory.CreateDirectory(caminhoBD);

            if (!File.Exists(caminhoBD + "\\albumMusical.txt"))
                File.WriteAllText(caminhoBD + "\\albumMusical.txt", "");
        }

        public static string[] CarregaAlbumMusicalTXT()
        {
            ValidaAlbumMusical();
            return File.ReadAllLines(caminhoBD + "\\albumMusical.txt", Encoding.Default);
        }


        public static string ConsultaAlbumPorID(string id_musica)
        {
            ValidaAlbumMusical();
            string[] albuns = CarregaAlbumMusicalTXT();

            foreach (string linha in albuns)
            {
                string[] cadastro = linha.Split('|');

                foreach (string dado in cadastro)
                {
                    if (dado == id_musica)
                        return linha;
                }
            }
            return "";
        }

        public static string ConsultaAlbumPorAlbum(string p_album)
        {
            string[] arquivo = CarregaAlbumMusicalTXT();
            string album = "";

            foreach (string item in arquivo)
            {
                string[] temp = item.Split('|');
                if (p_album == temp[0])
                    return album;
            }

            return album;
        }

        public override string ToString()
        {
            return Descricao + "|" + artista.Trim() + "|" + anoLancamento.ToString();
        }
    }
}
