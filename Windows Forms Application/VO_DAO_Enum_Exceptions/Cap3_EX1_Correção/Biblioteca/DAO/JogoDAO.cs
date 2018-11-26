using Biblioteca.Vos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public static class JogoDAO
    {

        public static void Incluir(JogoVO j)
        {
            string sql =
                @" insert into  jogos                     
                        (id, descricao, valor_locacao,
                         data_aquisicao, categoriaId)       
                       values
                        (@id, @descricao, @valor_locacao,
                         @dataCompra, @categoriaId)";

            SqlParameter[] parametros = {
                new SqlParameter("id", j.Id),
                new SqlParameter("descricao", j.Descricao),
                new SqlParameter("descricao", j.Descricao),
                new SqlParameter("valor_locacao", j.valor),
                new SqlParameter("dataCompra", j.Data),
                new SqlParameter("categoriaId", j.CategoriaId)
            };

            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }                
            }
        }

        public static void Alterar(JogoVO j)
        {

            string sql =
                @"update  jogos                     
                   set                            
                    descricao = @descricao,
                    valor_locacao = @valor_locacao, 
                    data_aquisicao =  @dataCompra
                    categoriaID =  @categoriaID
                   where id = @id";
            SqlParameter[] parametros = {
                new SqlParameter("id", j.Id),
                new SqlParameter("descricao", j.Descricao),
                new SqlParameter("descricao", j.Descricao),
                new SqlParameter("valor_locacao", j.valor),
                new SqlParameter("dataCompra", j.Data),
                new SqlParameter("categoriaId", j.CategoriaId)
            };

            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }                
            }
        }

        public static void Excluir(int id)
        {            
            string sql = "delete jogos where id = @id";
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.Add(new SqlParameter("id", id));
                    comando.ExecuteNonQuery();
                }              
            }
        }


    }
}
