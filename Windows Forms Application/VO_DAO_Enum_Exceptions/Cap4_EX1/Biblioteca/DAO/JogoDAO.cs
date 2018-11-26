using Biblioteca.Vos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public static class JogoDAO
    {

        private static SqlParameter[] CriaParametros(JogoVO j)
        {
            SqlParameter[] parametros = {
                new SqlParameter("id", j.Id),
                new SqlParameter("descricao", j.Descricao),
                new SqlParameter("valor_locacao", j.valor),
                new SqlParameter("dataCompra", j.Data),
                new SqlParameter("categoriaId", j.CategoriaId)
            };

            return parametros;
        }

        public static void Incluir(JogoVO j)
        {
            string sql =
                @" insert into  jogos                     
                        (id, descricao, valor_locacao,
                         data_aquisicao, categoriaId)       
                       values
                        (@id, @descricao, @valor_locacao,
                         @dataCompra, @categoriaId)";

            var parametros = CriaParametros(j);
            Metodos.ExecutaSQL(sql, parametros);
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
            var parametros = CriaParametros(j);
            Metodos.ExecutaSQL(sql, parametros);
        }

        public static void Excluir(int id)
        {
            string sql = "delete jogos where id = @id";
            var parametro = new SqlParameter[] { new SqlParameter("id", id) };
            Metodos.ExecutaSQL(sql, parametro);
            //Metodos.ExecutaSQL(sql, new SqlParameter[] { new SqlParameter("id", id) });
        }


        public static JogoVO Primeiro()
        {
            string sql = "select top 1 * from jogos order by id";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            JogoVO a = Metodos.ObjetoOuNull(tabela);
            return a;
        }

        public static JogoVO Ultimo()
        {
            string sql = "select top 1 * from jogos order by id desc";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return Metodos.ObjetoOuNull(tabela);
        }

        public static JogoVO Proximo(int atual)
        {
            string sql = @"select top 1 * from jogos where id > @Atual order by id";
            SqlParameter[] p = { new SqlParameter("Atual", atual) };
            DataTable tabela = Metodos.ExecutaSelect(sql, p);
            return Metodos.ObjetoOuNull(tabela);
        }

        public static JogoVO Anterior(int atual)
        {
            string sql = @"select top 1 * from jogos where id < @Atual order by id desc";
            SqlParameter[] p = { new SqlParameter("Atual", atual) };
            DataTable tabela = Metodos.ExecutaSelect(sql, p);
            return Metodos.ObjetoOuNull(tabela);
        }
    }
}
