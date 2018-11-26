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
    public class JogadorFutebolDAO : PadraoDAO
    {
        public JogadorFutebolDAO()
        {
            Tabela = "JogadorFutebol";
        }
                
        protected override string MontaSQLInsert()
        {
            return 
            "insert into JogadorFutebol(id, nome, NumeroCamisa, TimeId)" +
            "values ( @id, @nome, @NumeroCamisa, @TimeId)";
        }

        protected override string MontaSQLUpdate()
        {
            return 
           "update jogadorFutebol set nome = @nome, NumeroCamisa = @NumeroCamisa, timeId = @timeId " +
           "Where id = @id";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            JogadorFutebolVO j = o as JogadorFutebolVO;

            /*SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("id", o.Id);
            parametros[1] = new SqlParameter("nome", (o  as JogadorFutebolVO).Nome);
            parametros[2] = new SqlParameter("NumeroCamisa", (o as JogadorFutebolVO).NumeroCamisa);
            parametros[3] = new SqlParameter("timeId", ((JogadorFutebolVO)o).TimeId);  */

            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("id", j.Id);
            parametros[1] = new SqlParameter("nome", j.Nome);
            parametros[2] = new SqlParameter("NumeroCamisa", j.NumeroCamisa);
            parametros[3] = new SqlParameter("timeId", j.TimeId); 

            return parametros;
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            JogadorFutebolVO a = new JogadorFutebolVO();
            a.Id = Convert.ToInt32(dr["id"]);
            a.Nome = dr["nome"].ToString();
            a.NumeroCamisa = Convert.ToInt32(dr["NumeroCamisa"]);
            a.TimeId = Convert.ToInt32(dr["timeId"]);
            return a;
        }
             

        public List<JogadorFutebolVO> Lista(string nomeParcial)
        {
            string sql = "select * from jogadorFutebol where nome like @nome order by nome";
            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("nome", "%"+nomeParcial +"%")
                };


            DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
            List<JogadorFutebolVO> lista = new List<JogadorFutebolVO>();
            foreach (DataRow dr in tabela.Rows)
            {
                lista.Add(MontaVO(dr) as JogadorFutebolVO);
            }
            return lista;
        }
    }
}