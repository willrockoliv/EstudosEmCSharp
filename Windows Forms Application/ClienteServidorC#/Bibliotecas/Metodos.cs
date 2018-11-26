using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Bibliotecas
{
    public static class Metodos
    {
        public static bool IsConnected(TcpClient cliente)
        {
            try
            {
                if (cliente == null || cliente.Client == null)
                    return false;
                return !(cliente.Client.Poll(1, SelectMode.SelectRead) && 
                    cliente.Client.Available == 0);
            }
            catch (SocketException) { return false; }
        }



        public static bool EnviaDado(string msg, TcpClient cliente)
        {            
            if (IsConnected(cliente))
            {
                byte[] dados = Encoding.UTF8.GetBytes(msg);                
                return cliente.Client.Send(dados) > 0;
            }
            return false;            
        }
    }
}
