using Biblioteca.Vos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    public static class JogoDAO
    {
        public static  void Incluir (JogoVO jogo)
        {
            var cx = ConexaoBD.GetConexao();
            try
            {
                string sql =
                    $@"set dateformat dmy;
                        insert into  jogos                     
                        (id, descricao, valor_locacao,
                         data_aquisicao, categoriaId)       
                       values
                        ({jogo.Id}, '{jogo.Descricao}',
                        {jogo.valor.ToString().Replace(",", ".")},
                        '{jogo.Data}', {jogo.CategoriaId})";                       

                var cmd = new SqlCommand(sql, cx);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cx.Close();
            }
        }

        public static void Alterar(JogoVO jogo)
        {
            var cx = ConexaoBD.GetConexao();
            try
            {
                string sql = 
                    $@"set dateformat dmy;
                       update  jogos                     
                       set                            
                        descricao = '{jogo.Descricao}',
                        valor_locacao = {jogo.valor.ToString().Replace(",",".")},
                        data_aquisicao = '{jogo.Data}',
                        categoriaID = {jogo.CategoriaId}
                       where id = {jogo.Id}";

                var cmd = new SqlCommand(sql, cx);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cx.Close();
            }
        }

        public static void Excluir(int id)
        {
            var cx = ConexaoBD.GetConexao();
            try
            {
                string sql = $"delete jogos where id = {id}";
                var cmd = new SqlCommand(sql, cx);                                
                cmd.ExecuteNonQuery();                
            }
            finally
            {
                cx.Close();
            }
        }


    }
}
