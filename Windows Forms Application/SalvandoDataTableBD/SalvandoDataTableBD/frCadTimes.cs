using EX_6_TimeFutebol.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalvandoDataTableBD
{
    public partial class frCadTimes : Form
    {
        #region SQL
        /*
         
CREATE TABLE Times(
	[id] [int] NOT NULL,
	[nome] [varchar](50) NULL);


CREATE TYPE [TypeTime] AS TABLE(
    [Id] int NOT NULL,
    [Nome] [varchar](50) NULL
)
;


Create Procedure spIncluiTimes
    @tabela TypeTime readonly
AS
BEGIN
    select * into #TabTemp from @tabela;

    insert into times (id, nome)
	select * from #TabTemp
	where not exists(select times.id from times where id = #TabTemp.id)
END
         * */
        #endregion
                    
        public frCadTimes()
        {
            InitializeComponent();
            DataTable tabela = new DataTable();  // cria uma tabela temporária
            DataColumn c = new DataColumn("id", typeof(int)); // cria a coluna id
            tabela.Columns.Add(c);

            c = new DataColumn("nome", typeof(string));  // cria a coluna nome
            tabela.Columns.Add(c);

            dataGridView1.DataSource = tabela; // exibe no gridview
            dataGridView1.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            using (SqlConnection  cx = ConexaoBD.GetConexao())
            {
                SqlCommand cmd = new SqlCommand("spIncluiTimes", cx);                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("tabela", SqlDbType.Structured);
                cmd.Parameters[0].Value = dataGridView1.DataSource;
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Salvo com sucesso!!!");
        }
    }
}
