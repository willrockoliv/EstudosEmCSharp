using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutosHeranca.VO
{
  class ProdutoVO : PadraoVO
  {
    public string Descricao { get; set; }
    public double Preco { get; set; }
    public string LocalImg { get; set; }
  }
}
