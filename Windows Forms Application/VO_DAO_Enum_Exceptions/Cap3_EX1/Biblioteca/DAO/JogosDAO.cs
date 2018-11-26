using Biblioteca.VOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public static class JogosDAO
    {
        /// <summary>
        /// Método estático para inserir um aluno no BD
        /// </summary>
        /// <param name="jogo">objeto aluno com todas os atributos preenchidos</param>
        public static void Inserir(JogosVO jogo)
        {
            //devemos substituir a ',' por '.'
            string valor_locacao = jogo.Valor_locacao.ToString().Replace(',', '.');
            // set dateformat dmy; este comando serve para alterar a
            //forma como o SQL Server entende o formato de data
            string dataformat = String.Format("set dateformat dmy; ");

            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                SqlParameter[] parametros = new SqlParameter[5];
                parametros[0] = new SqlParameter("Id", jogo.Id);
                parametros[1] = new SqlParameter("Descricao", jogo.Descricao);
                parametros[2] = new SqlParameter("Data_aquisicao", jogo.Data_aquisicao);
                parametros[3] = new SqlParameter("CategoriaID", jogo.CategoriaID);
                parametros[4] = new SqlParameter("Valor_locacao", valor_locacao);

                string sql = dataformat + "insert into jogos(id,descricao,data_aquisicao,categoriaID,valor_locacao)" +
                                          "values(@Id, @Descricao, @Data_aquisicao, @CategoriaID, @Valor_locacao)";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddRange(parametros);
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public static void Alterar(JogosVO jogo)
        {
            string valor_locacao = jogo.Valor_locacao.ToString().Replace(',', '.');
            string dataformat = String.Format("set dateformat dmy; ");

            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                SqlParameter[] parametros = new SqlParameter[5];
                parametros[0] = new SqlParameter("Id", jogo.Id);
                parametros[1] = new SqlParameter("Descricao", jogo.Descricao);
                parametros[2] = new SqlParameter("Data_aquisicao", jogo.Data_aquisicao);
                parametros[3] = new SqlParameter("CategoriaID", jogo.CategoriaID);
                parametros[4] = new SqlParameter("Valor_locacao", valor_locacao);

                string sql = dataformat + "update jogos set descricao=@Descricao, valor_locacao=@Valor_locacao, data_aquisicao=@Data_aquisicao, categoriaID=@CategoriaID where id=@Id";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddRange(parametros);
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public static void Excluir(int id)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("Id", id);

                string sql = "delete from jogos where id=@Id";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddRange(parametros);
                comando.ExecuteNonQuery();
                conexao.Close();
            }
        }
    }
}
