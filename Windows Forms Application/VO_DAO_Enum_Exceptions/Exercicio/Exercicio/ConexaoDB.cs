﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class ConexaoDB
    {
            /// <summary>
            /// Método Estático que retorna um conexao aberta com o BD
            /// </summary>
            /// <returns>Conexão aberta</returns>
            public static SqlConnection GetConexao()
            {
                string strCon = "Data Source=LOCALHOST;Initial Catalog=AULADB;user id=sa; password=123456";
                SqlConnection conexao = new SqlConnection(strCon);
                conexao.Open();
                return conexao;
            }
    }
}
