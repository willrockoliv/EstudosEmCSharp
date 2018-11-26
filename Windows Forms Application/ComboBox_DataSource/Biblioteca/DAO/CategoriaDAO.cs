using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public class CategoriaDAO
    {
        public static DataTable ListaCategorias()
        {
            string sql = "select * from categorias order by descricao";
            return Metodos.ExecutaSelect(sql, null);
        }
    }
}
