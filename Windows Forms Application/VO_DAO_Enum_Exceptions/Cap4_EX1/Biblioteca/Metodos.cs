using Biblioteca.DAO;
using Biblioteca.Vos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Metodos
    {
        /// <summary>
        /// Método que executa uma instrução SQL no banco de dados
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parametros"></param>
        public static void ExecutaSQL(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Executa uma instrução Select
        /// </summary>
        /// <param name="sql">instrução SQL</param>
        /// <returns>DataTable com os dados da instrução SQL</returns>
        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    DataTable tabelaTemp = new DataTable();
                    adapter.Fill(tabelaTemp);
                    conexao.Close();
                    return tabelaTemp;
                }
            }
        }

        /// <summary>
        /// Recebe uma linha de um datable e preenche um objeto AlunoVO
        /// </summary>
        /// <param name="registro">1 registro (linha) do DataTable</param>
        /// <returns>Objeto AlunoVO com os atributos preenchidos</returns>
        public static JogoVO MontaVO(DataRow registro)
        {
            JogoVO jogo = new JogoVO();
            jogo.Id = Convert.ToInt32(registro["id"]);
            jogo.Descricao = registro["descricao"].ToString();
            jogo.CategoriaId = Convert.ToInt32(registro["categoriaID"]);
            jogo.Data = Convert.ToDateTime(registro["data_aquisicao"]);
            jogo.valor = Convert.ToDouble(registro["valor_locacao"]);
            return jogo;
        }

        public static JogoVO ObjetoOuNull(DataTable tabela)
        {
            if (tabela.Rows.Count == 0)
                return null;
            else
            {
                JogoVO a = MontaVO(tabela.Rows[0]);
                return a;
            }
        }


    }
}
