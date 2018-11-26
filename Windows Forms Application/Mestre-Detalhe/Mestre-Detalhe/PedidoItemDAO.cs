using System.Data.SqlClient;

namespace Mestre_Detalhe
{
    class PedidoItemDAO
    {
        public static void InsereItemPedido(PedidoItemVO item)
        {
            string sql = "insert into PedidoItem (PedidoId, ProdutoId,Qtde, ValorUnitario) " +
                "values (@PedidoId, @ProdutoId, @Qtde, @ValorUnitario)";
            MetodosBD.ExecutaSQL(sql, CriaParametros(item));
        }
        
        private static SqlParameter[] CriaParametros(PedidoItemVO item)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("pedidoId", item.PedidoId);
            parametros[1] = new SqlParameter("ProdutoId", item.ProdutoId);
            parametros[2] = new SqlParameter("Qtde", item.Qtde);
            parametros[3] = new SqlParameter("ValorUnitario", item.ValorUnitario);
            return parametros;
        }

    }
}
