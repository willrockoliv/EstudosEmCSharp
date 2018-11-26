using System;
using System.Collections.Generic;

namespace Mestre_Detalhe
{
    class PedidoVO
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public DateTime Data { get; set; }

        public List<PedidoItemVO> ItensDoPedido { get; set; } = new List<PedidoItemVO>();
    }
}
