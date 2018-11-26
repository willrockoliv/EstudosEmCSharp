using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Cliente
    {
        private bool clienteAtivo = false;

        public string IP { get; set; }
        private Thread threadCliente;
        private TcpClient tcpClient;
        public event EventHandler<DadosRecebidos> OnDadosRecebidos;

        public override string ToString()
        {
            return IP;
        }

        public bool IsConnected()
        {
            return Metodos.IsConnected(tcpClient);
        }

        public bool EnviaDado(string msg)
        {
            return Metodos.EnviaDado(msg, tcpClient);
        }


        public Cliente(TcpClient tcpClient)
        {
            this.IP = (tcpClient.Client.RemoteEndPoint as IPEndPoint).Address.ToString();
            this.tcpClient = tcpClient;
            clienteAtivo = true;
            threadCliente = new Thread(Processa);
            threadCliente.IsBackground = true;
            threadCliente.Start();
        }

        public void Encerra()
        {
            clienteAtivo = false;

            if (threadCliente != null)
                if (!threadCliente.Join(100))
                    threadCliente.Abort();
        }

        private void Processa()
        {
            while (clienteAtivo && tcpClient.Client.Connected)
            {
                try
                {
                    if (tcpClient.Client.Available > 0)
                    {
                        byte[] buffer = new byte[1024];
                        int qtde = tcpClient.Client.Receive(buffer);

                        string texto = Encoding.UTF8.GetString(buffer, 0, qtde);

                        if (OnDadosRecebidos != null)
                            OnDadosRecebidos(this, new DadosRecebidos(texto));
                    }
                    else
                        Thread.Sleep(1);
                }
                catch (Exception erro)
                {
                    //tratar o erro
                }
            }
        }
    }
}
