using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutandoProcsBD
{
    static class SPs
    {
        public static bool ValidaCPF(String cpf)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                using (SqlCommand cmd = new SqlCommand("validaCPF", cx))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("CPF", cpf.Replace(".","").Replace("-","")));
                    cmd.Parameters["CPF"].Direction = System.Data.ParameterDirection.Input;

                    cmd.Parameters.Add(new SqlParameter("retorno", SqlDbType.Bit));
                    cmd.Parameters["retorno"].Direction = System.Data.ParameterDirection.ReturnValue;

                    cmd.ExecuteNonQuery();

                    return Convert.ToBoolean(cmd.Parameters["retorno"].Value);
                }
            }

        }

    }
}
