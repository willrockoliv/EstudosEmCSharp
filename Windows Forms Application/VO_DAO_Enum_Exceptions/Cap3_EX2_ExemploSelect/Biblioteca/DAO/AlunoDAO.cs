using Biblioteca.VOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public static class AlunoDAO
    {

        private static SqlParameter[] CriaParametros(AlunoVO aluno)
        {
            SqlParameter[] parametros = {
                new SqlParameter("id", aluno.Id),
                new SqlParameter("nome", aluno.Nome),
                new SqlParameter("mensalidade", aluno.Mensalidade),
                new SqlParameter("cidadeId", aluno.CidadeId),
                new SqlParameter("dataNascimento", aluno.DataNascimento)
             };
            return parametros;
        }

        /// <summary>
        /// Método estático para inserir um aluno no BD
        /// </summary>
        /// <param name="aluno">objeto aluno com todas os atributos preenchidos</param>
        public static void Inserir(AlunoVO aluno)
        {
            string sql =
            "insert into alunos(id, nome, mensalidade, cidadeId, dataNascimento)" +
            "values ( @id, @nome, @mensalidade, @cidadeId, @dataNascimento)";
            Metodos.ExecutaSQL(sql, CriaParametros(aluno));
        }
        public static void Alterar(AlunoVO aluno)
        {
            string sql =
            "update alunos set nome=@nome, mensalidade=@mensalidade, " +
            "cidadeId=@cidadeId, dataNascimento=@dataNascimento where id = @id";
            Metodos.ExecutaSQL(sql, CriaParametros(aluno));
        }
        public static void Excluir(int id)
        {
            SqlParameter[] parametros = { new SqlParameter("id", id) };
            string sql = "delete alunos where id = @id";
            Metodos.ExecutaSQL(sql, parametros);
        }


    }
}