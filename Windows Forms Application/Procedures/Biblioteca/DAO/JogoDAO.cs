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
            SqlParameter[] parametros = { new SqlParameter("id", id) };
            DataTable tabela = Metodos.ExecutaProcResultSet("spConsultaJogo", parametros);
            return ObjetoOuNull(tabela);
        }

        public static void Incluir(JogoVO jogo)
        {
            Metodos.ExecutaProcedure("spIncluiOuAteraJogo", CriaParametros(jogo));
        }

        public static void Alterar(JogoVO jogo)
        {
            Metodos.ExecutaProcedure("spIncluiOuAteraJogo", CriaParametros(jogo));
        }

        public static void Excluir(int id)
        {
            SqlParameter[] parametro = { new SqlParameter("id", id) };            
            Metodos.ExecutaProcedure("spApagaJogo", parametro);
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
            DataTable tabela = Metodos.ExecutaProcResultSet("spNavegaPrimeiroJogo", null);
            return ObjetoOuNull(tabela);
        }

        public static JogoVO Ultimo()
        {
            DataTable tabela = Metodos.ExecutaProcResultSet("spNavegaUltimoJogo", null);
            return ObjetoOuNull(tabela);
        }



        public static JogoVO Anterior(int atual)
        {            
            SqlParameter[] parametros = { new SqlParameter("@idAtual", atual) };
            DataTable tabela = Metodos.ExecutaProcResultSet("spNavegaJogoAnterior", parametros);
            return ObjetoOuNull(tabela);
        }

        public static JogoVO Proximo(int atual)
        {
            SqlParameter[] parametros = { new SqlParameter("@idAtual", atual) };
            DataTable tabela = Metodos.ExecutaProcResultSet("spNavegaProximoJogo", parametros);
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
            string resposta =  Metodos.ExecutaProcedureComRetorno("spProximoIdJogo", null);
            return Convert.ToInt32(resposta);
        }


        public static DataTable ConsultaDeJogos(
            string descricao, string preco, string data,
            int categoria, string jogoId)

        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("descricao", descricao.Trim()));
            
            if (data.Replace("/", "").Trim().Length > 0)            
                parametros.Add(new SqlParameter("@data", data));                
            else
                parametros.Add(new SqlParameter("@data", DBNull.Value));

            if (preco.Trim().Length > 0)            
                parametros.Add(new SqlParameter("@preco", Convert.ToDouble(preco)));                
            else
                parametros.Add(new SqlParameter("@preco", DBNull.Value));

            if (jogoId.Trim().Length > 0)            
                parametros.Add(new SqlParameter("@id", Convert.ToInt32(jogoId)));
            else
                parametros.Add(new SqlParameter("@id", DBNull.Value));            

            if (categoria > 0)            
                parametros.Add(new SqlParameter("@categoria", categoria));                
            else
                parametros.Add(new SqlParameter("@categoria", DBNull.Value));

            return Metodos.ExecutaProcResultSet("spConsultaAvancada", parametros.ToArray());
        }

    }

}

