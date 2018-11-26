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
            SqlConnection conexao = ConexaoBD.GetConexao();
            try
            {
                //devemos substituir a ',' por '.'
                string valor_locacao = jogo.Valor_locacao.ToString().Replace(',', '.');
                // set dateformat dmy; este comando serve para alterar a
                //forma como o SQL Server entende o formato de data
                string sql = String.Format("set dateformat dmy; " +
                "insert into jogos(id, descricao, valor_locacao, data_aquisicao, categoriaID) " +
                "values ( {0}, '{1}', {2}, '{3}', {4})",
                jogo.Id, jogo.Descricao, valor_locacao, jogo.Data_aquisicao, jogo.CategoriaID);
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void Alterar(JogosVO jogo)
        {
            SqlConnection conexao = ConexaoBD.GetConexao();

            try
            {
                string valor_locacao = jogo.Valor_locacao.ToString().Replace(',', '.');
                string sql = String.Format("set dateformat dmy; " +
                                            "update jogos set descricao='{0}', valor_locacao={1}, data_aquisicao='{2}', categoriaID={3} where id={4}",
                                            jogo.Descricao, valor_locacao, jogo.Data_aquisicao, jogo.CategoriaID, jogo.Id);
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void Excluir(int id)
        {
            SqlConnection conexao = ConexaoBD.GetConexao();

            try
            {
                string sql = String.Format("delete from jogos where id={0}", id);
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
