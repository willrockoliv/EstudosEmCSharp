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
    public class TimeDAO : PadraoDAO
    {

        public TimeDAO()
        {
            Tabela = "Times";
        }


        public  List<TimeVO> Lista(string nomeTimeParcial)
        {
            string sql = "select * from times where nome like @nome order by nome";
            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("nome", "%"+nomeTimeParcial +"%")
                };

            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            List<TimeVO> lista = new List<TimeVO>();
            foreach (DataRow dr in tabela.Rows)
            {               
                lista.Add(MontaVO(dr) as TimeVO);
            }
            return lista;
        }


        protected override PadraoVO MontaVO(DataRow dr)
        {
            TimeVO t = new TimeVO();
            t.Id = Convert.ToInt16(dr["id"]);
            t.Nome = dr["nome"].ToString();
            return t;
        }

        protected override string MontaSQLInsert()
        {
            throw new NotImplementedException();
        }

        protected override string MontaSQLUpdate()
        {
            throw new NotImplementedException();
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            throw new NotImplementedException();
        }

      
    }
}
