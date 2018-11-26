using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class agendaDAO
    {


        public static void Inserir(agendaVO agendaVO)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                SqlParameter[] parametro = new SqlParameter[3];
                parametro[0] = new SqlParameter("id", agendaVO.Id);
                parametro[1] = new SqlParameter("nome", agendaVO.Nome);
                parametro[2] = new SqlParameter("telefone", agendaVO.Telefone);

                string sql = "insert into Agenda(codigo, nome, telefone) values(@id, @nome, @telefone)";
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddRange(parametro);
                comando.ExecuteNonQuery();
            }
        }

        public static void Excluir(int id)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                string sql = "delete from Agenda where codigo=" + id;
                SqlCommand command = new SqlCommand(sql, conexao);
                command.ExecuteNonQuery();
            }
        }

        public static void Alterar(agendaVO agendaVO)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                SqlParameter[] parameter = new SqlParameter[3];
                parameter[0] = new SqlParameter("id", agendaVO.Id);
                parameter[1] = new SqlParameter("nome", agendaVO.Nome);
                parameter[2] = new SqlParameter("telefone", agendaVO.Telefone);

                string sql = "update Agenda set nome=@nome, telefone=@telefone where codigo=@id";
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddRange(parameter);
                comando.ExecuteNonQuery();
            }
        }

        public static DataTable ExecutaSelect(string sql, SqlParameter[] parameter)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    if (parameter != null)
                        adapter.SelectCommand.Parameters.AddRange(parameter);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static DataTable Primeiro()
        {
            string sql = "select top 1 * from Agenda order by codigo";
            return ExecutaSelect(sql, null);
        }

        public static DataTable Proximo(int atual)
        {
            string sql = "select top 1 * from Agenda where codigo > @id order by codigo";
            SqlParameter[] parameter = { new SqlParameter("id", atual) };
            return ExecutaSelect(sql, parameter);
        }

        public static DataTable Ultimo()
        {
            string sql = "select top 1 * from Agenda order by codigo desc";
            return ExecutaSelect(sql, null);
        }

        public static DataTable Anterior(int atual)
        {
            string sql = "select top 1 * from Agenda where codigo < @id order by codigo desc";
            SqlParameter[] parameter = { new SqlParameter("id", atual) };
            return ExecutaSelect(sql, parameter);
        }
    }
}
