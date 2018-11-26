using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    public class Fabricante
    {
        private int codigo;
        private string nome;
        private List<string> fabricantes = new List<string> { "1 – Konami", "2 – Capcom", "3  - Nintendo", "4 – EA", "5 – Acclaim", "6 – IronHide", "7 – SEGA" };
        
        public List<string> Fabricantes { get => fabricantes; set => fabricantes = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}
