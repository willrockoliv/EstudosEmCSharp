using CadastroProdutosHeranca.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutosHeranca.DAO
{
  class ProdutoDAO : PadraoDAO
  {

    public ProdutoDAO()
    {
      Tabela = "produtos";
      Chave = "produtoId";
    }


    protected override SqlParameter[] CriaParametros(PadraoVO o)
    {
      return new SqlParameter[]
      {
        new SqlParameter("Produtoid", o.Id),
        new SqlParameter("ProdutoDescricao", (o as ProdutoVO).Descricao),
        new SqlParameter("Valor_unitario", (o as ProdutoVO).Preco),
        new SqlParameter("imagem", (o as ProdutoVO).LocalImg)
      };
    }

    protected override string MontaSQLInsert()
    {
      return @"insert into produtos (Produtoid, 
               ProdutoDescricao,Valor_unitario, imagem)
               values (@Produtoid,  @ProdutoDescricao,
                   @Valor_unitario, @imagem)";
    }

    protected override string MontaSQLUpdate()
    {
      return @"update produtos set 
               ProdutoDescricao =  @ProdutoDescricao,
               Valor_unitario = @Valor_unitario, 
               imagem = @imagem               
               where Produtoid = @Produtoid";
    }

    protected override PadraoVO MontaVO(DataRow dr)
    {
      ProdutoVO p = new ProdutoVO();
      p.Id = Convert.ToInt32(dr["Produtoid"]);
      p.Descricao = dr["ProdutoDescricao"].ToString(); ;
      p.Preco = Convert.ToDouble(dr["Valor_unitario"]);
      p.LocalImg = dr["imagem"].ToString();

      return p;

    }
  }
}
