using Biblioteca.VOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public static class JogosDAO
    {
        public static SqlParameter[] CriaParametros(JogosVO jogo)
        {
            //devemos substituir a ',' por '.'
            string valor_locacao = jogo.Valor_locacao.ToString().Replace(',', '.');

            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("Id", jogo.Id);
            parametros[1] = new SqlParameter("Descricao", jogo.Descricao);
            parametros[2] = new SqlParameter("Data_aquisicao", jogo.Data_aquisicao);
            parametros[3] = new SqlParameter("CategoriaID", jogo.CategoriaID);
            parametros[4] = new SqlParameter("Valor_locacao", valor_locacao);
            return parametros;
        }

        /// <summary>
        /// Método estático para inserir um aluno no BD
        /// </summary>
        /// <param name="jogo">objeto aluno com todas os atributos preenchidos</param>
        public static void Inserir(JogosVO jogo)
        {
            string dataformat = String.Format("set dateformat dmy; ");
            string sql = dataformat + "insert into jogos(id,descricao,data_aquisicao,categoriaID,valor_locacao)" +
                                      "values(@Id, @Descricao, @Data_aquisicao, @CategoriaID, @Valor_locacao)";
            Metodos.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public static void Alterar(JogosVO jogo)
        {
            string dataformat = String.Format("set dateformat dmy; ");
            string sql = dataformat + "update jogos set descricao=@Descricao, valor_locacao=@Valor_locacao, data_aquisicao=@Data_aquisicao, categoriaID=@CategoriaID where id=@Id";
            Metodos.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public static void Excluir(int id)
        {
            SqlParameter[] parametros = { new SqlParameter("id", id) };
            string sql = "delete jogos where id = @id";
            Metodos.ExecutaSQL(sql, parametros);
        }
    }
}
