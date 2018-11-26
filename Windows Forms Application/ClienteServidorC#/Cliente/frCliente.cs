using Bibliotecas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frCliente : Form
    {
        TcpClient client = null;
        Thread threadProcessaClient;
        bool ativo = false;

        public frCliente()
        {
            InitializeComponent();

            ativo = true;
            threadProcessaClient = new Thread(ProcessaClient);
            threadProcessaClient.IsBackground = true;
            threadProcessaClient.Start();
        }


        private void ProcessaClient()
        {
            while (ativo)
            {                
                if (client != null && client.Available > 0)
                {
                    byte[] buffer = new byte[1024];
                    int qtde = client.Client.Receive(buffer);

                    string texto = Encoding.UTF8.GetString(buffer, 0, qtde);

                    this.Invoke((MethodInvoker)delegate
                    {
                        txtMsgRecebidas.Text += Environment.NewLine +
                            texto;
                    });                    
                }
                else
                {
                    Thread.Sleep(1);
                }
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                MessageBox.Show("Conecte primeiro!");
                return;
            }

            if (!Metodos.EnviaDado(txtMsg.Text, client))
                MessageBox.Show("Cliente está disconectado do servidor.");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (client == null)
                MessageBox.Show("Conecte primeiro!");


            client.Close();
            client = null;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Metodos.IsConnected(client))
                    client.Close();
                client = new TcpClient(txtIP.Text, Convert.ToInt32(txtPorta.Text));               
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível estabelecer uma conexão. Erro: " + erro.Message);
            }
        }

        private void frCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            ativo = false;
        }


    }
}
