using EX_6_TimeFutebol.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_6_TimeFutebol.DAO
{
    public class JogadorFutebolDAO
    {
        /// <summary>
        /// Método estático para inserir um registro no BD
        /// </summary>        
        public static void Inserir(JogadorFutebolVO j)
        {
            string sql =
             "insert into JogadorFutebol(id, nome, NumeroCamisa, TimeId)" +
             "values ( @id, @nome, @NumeroCamisa, @TimeId)";

            Metodos.ExecutaSQL(sql, CriaParametros(j));
        }

        private static SqlParameter[] CriaParametros(JogadorFutebolVO j)
        {
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("id", j.Id);
            parametros[1] = new SqlParameter("nome", j.Nome);
            parametros[2] = new SqlParameter("NumeroCamisa", j.NumeroCamisa);
            parametros[3] = new SqlParameter("timeId", j.TimeId);

            return parametros;
        }


        /// <summary>
        /// Método estático para alterar um regisstro
        /// </summary>        
        public static void Alterar(JogadorFutebolVO j)
        {
            string sql =
            "update jogadorFutebol set nome = @nome, NumeroCamisa = @NumeroCamisa, timeId = @timeId " +
            "Where id = @id";
            Metodos.ExecutaSQL(sql, CriaParametros(j));
        }



        /// <summary>
        /// Método para excluir 
        /// </summary>        
        public static void Excluir(int Id)
        {
            string sql = "delete JogadorFutebol where id =  @id";
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("id", Id);
            Metodos.ExecutaSQL(sql, parametros);
        }



        public static JogadorFutebolVO Consulta(int id)
        {
            string sql = "select * from JogadorFutebol where id  = @id";
            SqlParameter[] parametros =
            {
                    new SqlParameter("id", id)
            };

            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            if (tabela.Rows.Count == 0)
                return null;
            else
            {
                return MontaVO(tabela.Rows[0]);
            }
        }

        private static JogadorFutebolVO MontaVO(DataRow dr)
        {
            JogadorFutebolVO a = new JogadorFutebolVO();
            a.Id = Convert.ToInt32(dr["id"]);
            a.Nome = dr["nome"].ToString();
            a.NumeroCamisa = Convert.ToInt32(dr["NumeroCamisa"]);
            a.TimeId = Convert.ToInt32(dr["timeId"]);
            return a;
        }


        public static JogadorFutebolVO Primeiro()
        {
            string sql = "select top 1 * from JogadorFutebol order by id";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }


        public static JogadorFutebolVO Ultimo()
        {
            string sql = "select top 1 * from JogadorFutebol order by id desc";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }

        public static JogadorFutebolVO Proximo(int atual)
        {
            string sql = @"select  top 1 * from JogadorFutebol
                           where id > @Atual
                           order by id ";
            SqlParameter[] p =
            {
                new SqlParameter("Atual", atual)
            };

            DataTable tabela = Metodos.ExecutaSelect(sql, p);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }


        public static JogadorFutebolVO Anterior(int atual)
        {
            string sql = @"select  top 1 * from JogadorFutebol 
                           where id < @Atual
                           order by id desc";
            SqlParameter[] p =
            {
                new SqlParameter("Atual", atual)
            };

            DataTable tabela = Metodos.ExecutaSelect(sql, p);

            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }
    }
}
