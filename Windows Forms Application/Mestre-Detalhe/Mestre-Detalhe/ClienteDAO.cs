using System;
using System.Collections.Generic;
using System.Data;

namespace Mestre_Detalhe
{
    class ClienteDAO
    {  
        public static List<ClienteVO> ConsultaClientes()
        {
            string sql = "select * from clientes order by ClienteNome";
            DataTable tabela = MetodosBD.ExecutaSelect(sql, null);
            List<ClienteVO> lista = new List<ClienteVO>();
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaVO(registro));

            return lista;
        }

        private static ClienteVO MontaVO(DataRow registro)
        {
            ClienteVO obj = new ClienteVO();
            obj.Id = Convert.ToInt32(registro["clienteId"]);
            obj.Nome = registro["clienteNome"].ToString();
            return obj;
        }
    }
}
