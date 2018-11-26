using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Metodos
    {
        public static int ExecutaSQL(string sql, SqlParameter[] parametros, bool retornaIdentity)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
                if (retornaIdentity)
                {
                    sql = "select @@identity";
                    using (SqlCommand comando = new SqlCommand(sql, conexao))                                            
                        return Convert.ToInt32( comando.ExecuteScalar());                    
                }
                else
                    return 0;
                
            }
        }


        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cx))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }



        public static int ObtemUltimoIdInserido()
        {
            string sql = "select @@identity() as 'ultimoId'";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return Convert.ToInt32(tabela.Rows[0]["ultimoId"]);
        }

    }
}
