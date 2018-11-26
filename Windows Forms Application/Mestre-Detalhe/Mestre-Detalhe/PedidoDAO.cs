using System.Data.SqlClient;

namespace Mestre_Detalhe
{
    static class PedidoDAO
    {
        /// <summary>
        /// Insere o pedido e seus itens
        /// </summary>
        /// <param name="pedido"></param>
        public static void Insere(PedidoVO pedido)
        {
            //transações
            //https://msdn.microsoft.com/pt-br/library/system.transactions.transactionscope(v=vs.110).aspx            

            using (var transacao = new System.Transactions.TransactionScope()) // início da transação
            {
                string sql = "insert into pedidos (pedidoId, clienteId, data) values " +
                              "(@pedidoId, @clienteid, @data)";
                MetodosBD.ExecutaSQL(sql, CriaParametros(pedido));

                foreach (PedidoItemVO item in pedido.ItensDoPedido)
                {
                    item.PedidoId = pedido.Id;
                    PedidoItemDAO.InsereItemPedido(item);
                }

                transacao.Complete(); // efetua o commit. Se der uma exception neste código, ou ele não passar por esta linha, será considerado rollback
            }
        }


        private static SqlParameter[] CriaParametros(PedidoVO pedido)
        {
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("pedidoId", pedido.Id);
            parametros[1] = new SqlParameter("clienteId", pedido.ClienteId);
            parametros[2] = new SqlParameter("data", pedido.Data);            
            return parametros;
        }
    }
}
