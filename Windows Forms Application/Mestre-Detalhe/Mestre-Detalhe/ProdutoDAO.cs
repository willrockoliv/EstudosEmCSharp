using System;
using System.Collections.Generic;
using System.Data;

namespace Mestre_Detalhe
{
    public class ProdutoDAO
    {

        public static List<ProdutoVO> ConsultaProdutos()
        {
            string sql = "select * from produtos order by ProdutoDescricao";
            DataTable tabela = MetodosBD.ExecutaSelect(sql, null);
            List<ProdutoVO> lista = new List<ProdutoVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaVO(registro));

            return lista;
        }      

        private static ProdutoVO MontaVO(DataRow registro)
        {
            ProdutoVO p = new ProdutoVO();
            p.Codigo = Convert.ToInt32(registro["ProdutoId"]);
            p.Nome = registro["ProdutoDescricao"].ToString();
            p.ValorUnitario = Convert.ToDouble(registro["Valor_Unitario"]);
            return p;
        }
    }
}
