using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Socket
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener serverSocket = new TcpListener(8888);
            serverSocket.Start();
            Console.WriteLine("Server Started... Awaiting connection");
            serverSocket.AcceptSocket();
            Console.WriteLine("Device Connected");
            Console.ReadKey(true);
        }
    }
}
