using CadastroProdutosHeranca.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutosHeranca.DAO
{
  public abstract class PadraoDAO
  {
    protected string Tabela { get; set; }
    protected string Chave { get; set; } = "id"; // valor default
    protected abstract string MontaSQLInsert();
    protected abstract string MontaSQLUpdate();
    protected abstract SqlParameter[] CriaParametros(PadraoVO o);
    protected abstract PadraoVO MontaVO(DataRow dr);
    protected virtual string MontaSQLDelete()
    {
      return $"delete {Tabela} where {Chave} = @id";
    }
    protected virtual string MontaSQLConsulta()
    {
      return $"select * from {Tabela} where {Chave} = @id";
    }
    /// <summary>
    /// Método para inserir um registro no BD
    /// </summary>
    public virtual void Inserir(PadraoVO o)
    {
      if (Consulta(o.Id) != null)
        throw new Exception("Este código já está sendo utilizado!");
      string sql = MontaSQLInsert();
      Metodos.ExecutaSQL(sql, CriaParametros(o));
    }
    /// <summary>
    /// Método para alterar um regisstro
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
      parametros[0] = new SqlParameter("@id", Id);
      Metodos.ExecutaSQL(sql, parametros);
    }
    /// <summary>
    /// Método para consultar 1 registro
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public PadraoVO Consulta(int id)
    {
      using (SqlConnection cx = ConexaoBD.GetConexao())
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
    }
    /// <summary>
    /// Obtem o Proximo id disponível
    /// </summary>
    /// <returns></returns>
    public virtual int ProximoId()
    {
      string sql = $"select isnull(max({Chave})+1,1) from {Tabela}";
      using (SqlConnection cx = ConexaoBD.GetConexao())
      {
        SqlCommand cmd = new SqlCommand(sql, cx);
        return Convert.ToInt32(cmd.ExecuteScalar());
      }
    }
    /// <summary>
    /// Primeiro registro
    /// </summary>
    /// <returns></returns>
    public virtual PadraoVO Primeiro()
    {
      string sql = $"select top 1 * from {Tabela} order by {Chave}";
      return ExecutaSqlLocal(sql, null);
    }

    /// <summary>
    /// Ultimo registro
    /// </summary>
    /// <returns></returns>
    public virtual PadraoVO Ultimo()
    {
      string sql = $"select top 1 * from {Tabela} order by {Chave} desc";
      DataTable tabela = Metodos.ExecutaSelect(sql, null);
      return ExecutaSqlLocal(sql, null);
    }
    /// <summary>
    /// Próximo registro
    /// </summary>
    /// <param name="atual"></param>
    /// <returns></returns>
    public virtual PadraoVO Proximo(int atual)
    {
      string sql = $"select top 1 * from {Tabela} where {Chave} > @Atual order by {Chave} ";
      SqlParameter[] p =
      {
new SqlParameter("Atual", atual)
};
      return ExecutaSqlLocal(sql, p);
    }
    /// <summary>
    /// Registro anterior
    /// </summary>
    /// <param name="atual"></param>
    /// <returns></returns>
    public virtual PadraoVO Anterior(int atual)
    {
      string sql = $"select top 1 * from {Tabela} where {Chave} < @Atual order by {Chave} desc";
      SqlParameter[] p =
      {
new SqlParameter("Atual", atual)
};
      return ExecutaSqlLocal(sql, p);
    }
    /// <summary>
    /// Executa uma instrução SQL
    /// </summary>
    /// <param name="sql">instrução</param>
    /// <param name="parametros">parametros</param>
    /// <returns>Objeto PadraoVO</returns>
    protected PadraoVO ExecutaSqlLocal(string sql, SqlParameter[] parametros)
    {
      DataTable tabela = Metodos.ExecutaSelect(sql, parametros);
      if (tabela.Rows.Count == 0)
        return null;
      else
        return MontaVO(tabela.Rows[0]);
    }
  }
}