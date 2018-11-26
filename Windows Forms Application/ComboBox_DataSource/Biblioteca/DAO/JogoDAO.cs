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


        public static JogoVO Consulta(int id)
        {
            string sql = "select * from jogos where id = " + id;

            SqlParameter[] parametros = { new SqlParameter("id", id) };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return ObjetoOuNull(tabela);
        }

        public static void Incluir(JogoVO jogo)
        {
            string sql =
                @" insert into  jogos                     
                        (id, descricao, valor_locacao,
                         data_aquisicao, categoriaId)       
                       values
                        (@id, @descricao, @valor_locacao,
                         @dataCompra, @categoriaId)";

            Metodos.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public static void Alterar(JogoVO jogo)
        {

            string sql =
                @"update  jogos                     
                   set                            
                    descricao = @descricao,
                    valor_locacao = @valor_locacao, 
                    data_aquisicao =  @dataCompra,
                    categoriaID =  @categoriaID
                   where id = @id";
            Metodos.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public static void Excluir(int id)
        {
            SqlParameter[] parametro = { new SqlParameter("id", id) };
            string sql = "delete jogos where id = @id";
            Metodos.ExecutaSQL(sql, parametro);
        }



        private static JogoVO MontaVO(DataRow registro)
        {
            JogoVO j = new JogoVO();
            j.Id = Convert.ToInt32(registro["id"]);
            j.Descricao = registro["descricao"].ToString();
            j.valor = Convert.ToDouble(registro["valor_locacao"]);
            j.CategoriaId = Convert.ToInt32(registro["categoriaId"]);
            j.Data = Convert.ToDateTime(registro["data_aquisicao"]);
            return j;
        }


        public static JogoVO Primeiro()
        {
            string sql = "select top 1 * from jogos order by id  asc";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ObjetoOuNull(tabela);
        }

        public static JogoVO Ultimo()
        {
            string sql = "select top 1 * from jogos order by id  desc";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ObjetoOuNull(tabela);
        }



        public static JogoVO Anterior(int atual)
        {
            string sql = "select top 1 * from jogos where id < @atual order by id desc";
            SqlParameter[] parametros = { new SqlParameter("atual", atual) };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return ObjetoOuNull(tabela);
        }

        public static JogoVO Proximo(int atual)
        {
            string sql = "select top 1 * from jogos where id > @atual order by id asc";
            SqlParameter[] parametros = { new SqlParameter("atual", atual) };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return ObjetoOuNull(tabela);
        }


        private static JogoVO ObjetoOuNull(DataTable tabela)
        {
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }


        public static int ProximoId()
        {
            string sql = "select isnull(max(id)+1,1) from jogos";
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                using (SqlCommand cmd = new SqlCommand(sql, cx))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }


        public static DataTable ConsultaDeJogos(
            string descricao, string preco, string data,
            int categoria, string jogoId)

        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("descricao", "%" + descricao.Trim() + "%"));

            string where = "jogos.descricao like @descricao";

            if (data.Replace("/", "").Trim().Length > 0 )
            {
                parametros.Add(new SqlParameter("@data", data ));
                where += " and convert(varchar, data_aquisicao, 103) = @data";
            }

            if (preco.Trim().Length > 0)
            {
                parametros.Add(new SqlParameter("@preco", Convert.ToDouble(preco)));
                where +=  "  and valor_locacao = @preco";
            }

            if (jogoId.Trim().Length > 0)
            {
                parametros.Add(new SqlParameter("@id", Convert.ToInt32(jogoId)));
                where += " and jogos.id = @id";
            }

            if (categoria > 0)
            {
                parametros.Add(new SqlParameter("@categoria", categoria));
                where += " and categoriaId = @categoria";
            }

            string sql = @"select jogos.*, categorias.descricao as 'Categoria' 
                           from jogos 
                           inner join categorias on categorias.id = jogos.CategoriaId
                           where " + where;

            return Metodos.ExecutaSelect(sql, parametros.ToArray());
        }

    }

}

