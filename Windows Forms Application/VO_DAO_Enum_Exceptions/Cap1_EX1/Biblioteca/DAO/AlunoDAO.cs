using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.VOs;
using System.Data.SqlClient;

namespace Biblioteca.DAO
{
    public static class AlunoDAO
    {
        /// <summary>
        /// Método estático para inserir um aluno no BD
        /// </summary>
        /// <param name="aluno">objeto aluno com todas os atributos preenchidos</param>
        public static void Inserir(AlunoVO aluno)
        {
            SqlConnection conexao = ConexaoBD.GetConexao();
            try
            {
                //devemos substituir a ',' por '.'
                string mensalidade = aluno.Mensalidade.ToString().Replace(',', '.');
                // set dateformat dmy; este comando serve para alterar a
                //forma como o SQL Server entende o formato de data
                string sql = String.Format("set dateformat dmy; " +
                "insert into alunos(id, nome, mensalidade, cidadeId, dataNascimento)" +
                "values ( {0}, '{1}', {2}, {3}, '{4}')", aluno.Id,
                aluno.Nome, mensalidade, aluno.CidadeId, aluno.DataNascimento);
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void Alterar(AlunoVO aluno)
        {
            SqlConnection conexao = ConexaoBD.GetConexao();

            try
            {
                string mensalidade = aluno.Mensalidade.ToString().Replace(',', '.');
                string sql = String.Format("set dateformat dmy; " +
                                            "update alunos set id={0}, nome='{1}', mensalidade={2}, cidadeId={3}, dataNascimento='{4}' where id={5}",
                                            aluno.Id, aluno.Nome, mensalidade, aluno.CidadeId, aluno.DataNascimento, aluno.Id);
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
                string sql = String.Format("delete from alunos where id={0}", id);
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
