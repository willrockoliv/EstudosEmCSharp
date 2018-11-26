namespace Mestre_Detalhe
{    
    class PedidoItemVO
    {        
        public int PedidoId { get; set; }

        public int ProdutoId { get; set; }

        public int Qtde { get; set; }

        public double ValorUnitario { get; set; }


        #region Atributos que não existem na tabela

        public string ProdutoDescricao { get; set; }

        public double ValorTotal
        {
            get
            {
                return ValorUnitario * Qtde;
            }
        }
        #endregion
    }
}
