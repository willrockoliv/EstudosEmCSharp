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
  public abstract class PadraoDAO
  {

    #region Métodos e Propriedades Abstratas       

    protected abstract string MontaSQLInsert();
    protected abstract string MontaSQLUpdate();
    protected abstract SqlParameter[] CriaParametros(PadraoVO o);

    protected abstract PadraoVO MontaVO(DataRow dr);

    #endregion

    protected string Tabela { get; set; }


    protected virtual string MontaSQLDelete()
    {
      return $"delete {Tabela} where id =  @id";
    }

    protected virtual string MontaSQLConsulta()
    {
      return $"select * from {Tabela} where id =  @id";
    }


    /// <summary>
    /// Método estático para inserir um registro no BD
    /// </summary>        
    public virtual void Inserir(PadraoVO o)
    {
      if (Consulta(o.Id) != null)
        throw new Exception("Este código já está sendo utilizado!");

      string sql = MontaSQLInsert();

      Metodos.ExecutaSQL(sql, CriaParametros(o));
    }


    /// <summary>
    /// Método estático para alterar um regisstro
    /// </summary>        
    public virtual void Alterar(PadraoVO o)
    {
      string sql = MontaSQLUpdate();
      Metodos.ExecutaSQL(sql, CriaParametros(o));
    }




    /// <summary>
    /// Método para excluir 
    /// </summary>        
    public virtual void Excluir(int Id)
    {
      string sql = MontaSQLDelete();
      SqlParameter[] parametros = new SqlParameter[1];
      parametros[0] = new SqlParameter("id", Id);  // padrão para campo Id
      Metodos.ExecutaSQL(sql, parametros);
    }



    public PadraoVO Consulta(int id)
    {
      string sql = MontaSQLConsulta();
      SqlParameter[] parametros =
      {
                    new SqlParameter("id", id)
                };

      DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
      if (tabela.Rows.Count == 0)
        return null;
      else
      {
        return MontaVO(tabela.Rows[0]);
      }
    }

    public virtual int ProximoId()
    {
      string sql = $"select isnull(max(id)+1,1) from {Tabela}";
      using (SqlConnection cx = ConexaoBD.GetConexao())
      {
        SqlCommand cmd = new SqlCommand(sql, cx);
        return Convert.ToInt32(cmd.ExecuteScalar());
      }
    }



    public virtual PadraoVO Primeiro()
    {
      string sql = $"select top 1 * from {Tabela} order by id";
      return ExecutaSqlLocal(sql, null);
    }




    public virtual PadraoVO Ultimo()
    {
      string sql = $"select top 1 * from {Tabela} order by id desc";
      return ExecutaSqlLocal(sql, null);
    }

    public virtual PadraoVO Proximo(int atual)
    {
      string sql = $"select  top 1 * from {Tabela} where id > @Atual  order by id ";
      SqlParameter[] p =
      {
                new SqlParameter("Atual", atual)
            };
      return ExecutaSqlLocal(sql, p);
    }


    public virtual PadraoVO Anterior(int atual)
    {
      string sql = $"select  top 1 * from {Tabela} where id < @Atual  order by id desc";
      SqlParameter[] p =
      {
                new SqlParameter("Atual", atual)
            };
      return ExecutaSqlLocal(sql, p);
    }


    protected PadraoVO ExecutaSqlLocal(string sql, SqlParameter[] p)
    {
      DataTable tabela = Metodos.ExecutaSelect(sql, p);

      if (tabela.Rows.Count == 0)
        return null;
      else
        return MontaVO(tabela.Rows[0]);
    }

  }
}
