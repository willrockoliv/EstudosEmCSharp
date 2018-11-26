using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ImagensCSharp
{
    /*     
    --Tabela utilizada neste exemplo:
    CREATE TABLE [dbo].[TbImagens](
	    [id] [int] NOT NULL primary key,
	    [imagem] [varchar(max)] NOT NULL)      
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregarIMG_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }


        private SqlConnection GetConexao()
        {
            SqlConnection conexao = new SqlConnection("Data Source=localhost;Initial Catalog=AulaDB;Integrated Security=False; user id=sa;password=123456");
            conexao.Open();
            return conexao;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pictureBox1.ImageLocation))
            {
                MessageBox.Show("Selecione uma imagem.");
                return;
            }
            using (SqlConnection conexao = GetConexao())
            {
                //O método abaixo obriga a ler os bytes do arquivo novamente
                //byte[] vetor = File.ReadAllBytes(pictureBox1.ImageLocation);

                //desta forma, não é necessário carregar o arquivo novamente
                ImageConverter converter = new ImageConverter();
                byte[] vetor = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));


                string sql = "insert into TbImagens (id,imagem) " +
                              "values (@id, @imagem)"; // @imagem é um parâmetro

                int id = Convert.ToInt16(txtID.Text);

                SqlParameter[] parametros = { new SqlParameter("id", id),
                                              new SqlParameter("imagem", vetor) };

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("Gravado com sucesso!");
                conexao.Close();
            }
        }

        private void btnCarregaImg_Click(object sender, EventArgs e)
        {
            //só para testar, carrega a imagem apenas do 1º registro da tabela
            using (SqlConnection conexao = GetConexao())
            {
                string sql = "select * from tbImagens where id = " + txtID.Text;
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    if (tabela.Rows.Count == 0)
                    {
                        MessageBox.Show("Não há registros na tabela!");
                        return;
                    }

                    // uma imagem representada na linguagem é um vetor de bytes!
                    byte[] bytesImagem = (tabela.Rows[0]["imagem"] as byte[]);
                    pictureBox1.Image = Image.FromStream(new MemoryStream(bytesImagem));
                    conexao.Close();
                }
            }
        }        

    }
}