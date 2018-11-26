using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Metodos
    {
        /// <summary>
        /// Método que executa uma instrução SQL no banco de dados
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parametros"></param>
        public static void ExecutaSQL(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                SqlCommand comando = new SqlCommand(sql, conexao);
                if (parametros != null)
                    comando.Parameters.AddRange(parametros);
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }
    }
}
