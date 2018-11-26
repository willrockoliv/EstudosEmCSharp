using Biblioteca.VOs;
using System;
using System.Collections.Generic;
using System.Data;
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



        private static AlunoVO MontaVO(DataRow registro)
        {
            AlunoVO aluno = new AlunoVO();
            aluno.Nome = registro["nome"].ToString();
            aluno.CidadeId = Convert.ToInt32(registro["cidadeId"]);
            aluno.Mensalidade = Convert.ToDouble(registro["mensalidade"]);
            aluno.DataNascimento = Convert.ToDateTime(registro["DataNascimento"]);
            aluno.Id = Convert.ToInt32(registro["id"]);
            return aluno;
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



        public static AlunoVO Consulta(int id)
        {
            string sql = "select * from Alunos  where id = @id";
            SqlParameter[] parametro =
            {
                new SqlParameter("id", id)
            };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametro);
            return ObjetoOuNull(tabela);
        }

        private static AlunoVO ObjetoOuNull(DataTable tabela)
        {
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }

        public static AlunoVO Primeiro()
        {
            string sql = "select top 1 * from Alunos order by id";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ObjetoOuNull(tabela);
        }


        public static AlunoVO Ultimo()
        {
            string sql = "select top 1 * from Alunos order by id desc";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ObjetoOuNull(tabela);
        }


        public static AlunoVO Proximo(int atual)
        {
            string sql = "select top 1 * from Alunos where id > @Atual order by id";
            SqlParameter[] parametro =
            {
                new SqlParameter("atual", atual)
            };

            DataTable tabela = Metodos.ExecutaSelect(sql, parametro);
            return ObjetoOuNull(tabela);
        }


        public static AlunoVO Anterior(int atual)
        {
            string sql = "select top 1 * from Alunos where id < @Atual order by id desc";
            SqlParameter[] parametro =
            {
                new SqlParameter("atual", atual)
            };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametro);
            return ObjetoOuNull(tabela);
        }


    }
}