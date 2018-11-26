using CadFerramentas.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public static class FerramentaDAO
    {

        private static SqlParameter[] CriaParametros(FerramentaVO f)
        {
            SqlParameter[] parametros = {
                new SqlParameter("id", f.Id),
                new SqlParameter("descricao", f.Descricao),
                new SqlParameter("FabricanteId", f.FabricanteId),
                new SqlParameter("foto", f.Foto)
            };

            return parametros;
        }


        public static FerramentaVO Consulta(int id)
        {
            string sql = "select * from ferramentas where id = " + id;

            SqlParameter[] parametros = { new SqlParameter("id", id) };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return ObjetoOuNull(tabela);
        }


        public static DataTable  Lista(string filtro)
        {
            string sql = @"select ferramentas.id as 'Id',  ferramentas.descricao as 'Descrição', Fabricantes.descricao as 'Fabricante'
                         from ferramentas
                         inner join Fabricantes on Fabricantes.id = ferramentas.FabricanteId
                         where ferramentas.descricao like @filtro or fabricantes.descricao like @filtro
                         order by ferramentas.descricao";


            SqlParameter[] parametros = { new SqlParameter("filtro", "%"+filtro.Trim()+"%") };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return tabela;
        }


        public static void Incluir(FerramentaVO f)
        {
            string sql =
                @" insert into  ferramentas                     
                   (descricao, foto, fabricanteId)       
                   values
                   (@descricao,  @foto, @fabricanteId)";

            f.Id = Metodos.ExecutaSQL(sql, CriaParametros(f), true);
        }

        public static void Alterar(FerramentaVO f)
        {

            string sql =
                @"update  ferramentas
                   set                            
                    descricao = @descricao,                    
                    foto =  @foto,
                    fabricanteID =  @fabricanteId
                   where id = @id";
            Metodos.ExecutaSQL(sql, CriaParametros(f), false);
        }

        public static void Excluir(int id)
        {
            SqlParameter[] parametro = { new SqlParameter("id", id) };
            string sql = "delete ferramentas where id = @id";
            Metodos.ExecutaSQL(sql, parametro, false);
        }



        private static FerramentaVO MontaVO(DataRow registro)
        {
            FerramentaVO j = new FerramentaVO();
            j.Id = Convert.ToInt32(registro["id"]);
            j.Descricao = registro["descricao"].ToString();
            j.Foto = registro["foto"].ToString();
            j.FabricanteId = Convert.ToInt32(registro["fabricanteId"]);
            return j;
        }


        public static FerramentaVO Primeiro()
        {
            string sql = "select top 1 * from ferramentas order by id  asc";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ObjetoOuNull(tabela);
        }

        public static FerramentaVO Ultimo()
        {
            string sql = "select top 1 * from ferramentas order by id  desc";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ObjetoOuNull(tabela);
        }



        public static FerramentaVO Anterior(int atual)
        {
            string sql = "select top 1 * from ferramentas where id < @atual order by id desc";
            SqlParameter[] parametros = { new SqlParameter("atual", atual) };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return ObjetoOuNull(tabela);
        }

        public static FerramentaVO Proximo(int atual)
        {
            string sql = "select top 1 * from ferramentas where id > @atual order by id asc";
            SqlParameter[] parametros = { new SqlParameter("atual", atual) };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return ObjetoOuNull(tabela);
        }


        private static FerramentaVO ObjetoOuNull(DataTable tabela)
        {
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }
    }
}
