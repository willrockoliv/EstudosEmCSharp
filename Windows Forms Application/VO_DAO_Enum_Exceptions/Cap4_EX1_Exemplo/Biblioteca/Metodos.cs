using Biblioteca.DAO;
using Biblioteca.Enumeradores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public static class Metodos
    {
        public static bool Mensagem(string msg, TipoMensagemEnum tipo)
        {
            if (tipo == TipoMensagemEnum.alerta)
                MessageBox.Show(msg, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tipo == TipoMensagemEnum.erro)
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tipo == TipoMensagemEnum.informacao)
                MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (tipo == TipoMensagemEnum.pergunta)
            {
                if (MessageBox.Show(msg, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    return true;
            }

            return false;
        }

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
                conexao.Close();
            }
        }



        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cx))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }
    }
}
