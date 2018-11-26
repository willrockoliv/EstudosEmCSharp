using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public class Foto : Midia, ILocal, ICatalogo
    {
        private string arquivoMidia;
        private int anoLancamento;
        private string local;
        private double megaPixels;
        private int tempoEmSegundosParaExibir;

        public string ArquivoMidia { get { return arquivoMidia; } set { arquivoMidia = value; } } //local e nome do arquivo da mídia
        public int AnoLancamento { get { return anoLancamento; } set { anoLancamento = value; } } //ano que a mídia foi lançada
        public string Local { get { return local; } set { local = value; } } //(local onde a foto foi tirada)
        public double MegaPixels { get { return megaPixels; } set { megaPixels = value; } }
        public int TempoEmSegundosParaExibir { get { return tempoEmSegundosParaExibir; } set { tempoEmSegundosParaExibir = value; } } //(tempo em segundos que a foto será exibida no player)

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
            return base.ToString() + "|<Midia>Foto" + "|<ArquivoMidia>" + ArquivoMidia + "|<AnoLancamento>" + AnoLancamento + "|<Local>" + Local + "|<MegaPixels>" + MegaPixels + "|<TempoEmSegundosParaExibir>" + TempoEmSegundosParaExibir;
        }

        public override void Alterar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        
    }
}
