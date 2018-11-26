﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX_6_TimeFutebol.VO;

namespace EX_6_TimeFutebol.DAO
{
    public class TecnicoDAO : PadraoDAO
    {
        public TecnicoDAO()
        {
            Tabela = "Tecnicos";
        }

        protected override SqlParameter[] CriaParametros(PadraoVO o)
        {
            TecnicoVO t = o as TecnicoVO;
            SqlParameter[] parametros =
            {
                new SqlParameter("id", t.Id),
                new SqlParameter("nome", t.Nome)                
            };

            return parametros;
        }

        protected override string MontaSQLInsert()
        {
            return  "insert into tecnicos (id,nome)" +
                    "values(@id, @nome)";
        }

        protected override string MontaSQLUpdate()
        {
            return "update tecnicos set nome=@nome " +
                   "where id = @id";
        }

        protected override PadraoVO MontaVO(DataRow dr)
        {
            TecnicoVO t = new TecnicoVO();
            t.Id = Convert.ToInt32(dr["id"]);
            t.Nome = dr["nome"].ToString();            
            return t;
        }


    }
}
