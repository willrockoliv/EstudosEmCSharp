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
    public static class FabricanteDAO
    {

        private static SqlParameter[] CriaParametros(FabricanteVO f)
        {
            SqlParameter[] parametros = {
                new SqlParameter("id", f.Id),
                new SqlParameter("descricao", f.Descricao)
            };

            return parametros;
        }


        public static FabricanteVO Consulta(int id)
        {
            string sql = "select * from fabricantes where id = " + id;
            SqlParameter[] parametros = { new SqlParameter("id", id) };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return ObjetoOuNull(tabela);
        }

        public static List<FabricanteVO> Lista(string filtro)
        {
            string sql = "select * from fabricantes where descricao like @filtro order by descricao";
            SqlParameter[] parametros = { new SqlParameter("filtro", "%" + filtro + "%") };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            List<FabricanteVO> lista = new List<FabricanteVO>();
            foreach(DataRow dr in tabela.Rows)            
                lista.Add(MontaVO(dr));

            return lista;
        }



        public static void Incluir(FabricanteVO f)
        {
            string sql = "insert into  fabricantes(descricao) values (@descricao)";
            f.Id = Metodos.ExecutaSQL(sql, CriaParametros(f), true);
        }

        public static void Alterar(FabricanteVO f)
        {

            string sql =
                @"update  fabricantes
                   set                            
                    descricao = @descricao,                                        
                   where id = @id";
            Metodos.ExecutaSQL(sql, CriaParametros(f), false);
        }

        public static void Excluir(int id)
        {
            SqlParameter[] parametro = { new SqlParameter("id", id) };
            string sql = "delete fabricantes where id = @id";
            Metodos.ExecutaSQL(sql, parametro, false);
        }



        private static FabricanteVO MontaVO(DataRow registro)
        {
            FabricanteVO j = new FabricanteVO();
            j.Id = Convert.ToInt32(registro["id"]);
            j.Descricao = registro["descricao"].ToString();            
            return j;
        }


        public static FabricanteVO Primeiro()
        {
            string sql = "select top 1 * from fabricantes order by id  asc";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ObjetoOuNull(tabela);
        }

        public static FabricanteVO Ultimo()
        {
            string sql = "select top 1 * from fabricantes order by id  desc";
            DataTable tabela = Metodos.ExecutaSelect(sql, null);
            return ObjetoOuNull(tabela);
        }



        public static FabricanteVO Anterior(int atual)
        {
            string sql = "select top 1 * from fabricantes where id < @atual order by id desc";
            SqlParameter[] parametros = { new SqlParameter("atual", atual) };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return ObjetoOuNull(tabela);
        }

        public static FabricanteVO Proximo(int atual)
        {
            string sql = "select top 1 * from fabricantes where id > @atual order by id asc";
            SqlParameter[] parametros = { new SqlParameter("atual", atual) };
            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            return ObjetoOuNull(tabela);
        }


        private static FabricanteVO ObjetoOuNull(DataTable tabela)
        {
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }   


    }
}
