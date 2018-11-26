using Bibliotecas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class frServidor : Form
    {
        TcpListener server;

        Thread threadProcessaServer;
        List<Cliente> listaClientes;
        private bool serverAtivo = false;


        public frServidor()
        {
            InitializeComponent();

            listaClientes = new List<Cliente>();
                       
            //escutar em todos os ip´s do computador
            server = new TcpListener(IPAddress.Any, 5000);
            server.Start();
            serverAtivo = true;

            threadProcessaServer = new Thread(ProcessaServer);
            threadProcessaServer.IsBackground = true;
            threadProcessaServer.Start();

            //Exibir todos os IPs da máquina
            IPHostEntry iphostentry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipaddress in iphostentry.AddressList)
                if (ipaddress.ToString().Length <= 15) // ignora ipv 6
                    txtIps.Text += ipaddress.ToString() + Environment.NewLine;
        }


        private void ProcessaServer()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bool novoCliente;
            while (serverAtivo)
            {
                novoCliente = false;
                if (server.Pending()) // se existe um novo cliente conectado
                {
                    TcpClient tcpClient = server.AcceptTcpClient();
                    Cliente c = new Cliente(tcpClient);
                    c.OnDadosRecebidos += c_OnDadosRecebidos;
                    listaClientes.Add(c);
                    novoCliente = true;
                }
                else
                {
                    Thread.Sleep(1);

                    if (sw.ElapsedMilliseconds >= 5000 || novoCliente)
                    {
                        sw.Restart();
                        AtualizaListBoxClientes();
                    }
                }
            }
        }



        private void AtualizaListBoxClientes()
        {            
            //verifica se os clientes ainda estão conectados
            List<Cliente> listaClone = new List<Cliente>(listaClientes);
            foreach (Cliente c in listaClone)
                if (!c.IsConnected())
                    listaClientes.Remove(c);


            //atualiza a lista de clientes
            this.Invoke((MethodInvoker)delegate
            {
                
                bool precisaAtualizar = false;
                if (lbClientes.Items.Count == listaClientes.Count && listaClientes.Count != 0)
                {
                    for (int n = 0; n < lbClientes.Items.Count; n++)
                    {
                        if (lbClientes.Items[n].ToString() !=
                            listaClientes[n].IP)
                        {
                            precisaAtualizar = true;
                            break;
                        }
                    }
                }
                else
                {
                    precisaAtualizar = true;
                }

                if (precisaAtualizar)
                {
                    lbClientes.Items.Clear();
                    foreach (Cliente c in listaClientes)
                        lbClientes.Items.Add(c);
                }
            });
        }

        void c_OnDadosRecebidos(object sender, DadosRecebidos e)
        {
            if (Disposing)  // se o form estiver sendo destruido, não processe o evento
                return;
            //executar uma instrução na thead principal do formulário
            this.Invoke((MethodInvoker)delegate
            {
                textBox2.Text += Environment.NewLine +
                    (sender as Cliente).IP + " - " + e.Dados;
            });
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void frServidor_FormClosed(object sender, FormClosedEventArgs e)
        {
            serverAtivo = false;
            server.Stop();

            //fecha todos os clientes
            foreach (Cliente cliente in listaClientes)
            {
                cliente.Encerra();
            }

            if (threadProcessaServer != null)
                if (!threadProcessaServer.Join(1000))
                    threadProcessaServer.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbClientes.SelectedIndex != -1)
            {
                Cliente c = lbClientes.SelectedItem as Cliente;
                c.EnviaDado(txtMsg.Text);
                    
            }
        }


    }
}
