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
            // Object which will serve as the socket using port 8888 (random port)
            TcpListener serverSocket = new TcpListener(8888);
            
            // Start socket
            serverSocket.Start();
            Console.WriteLine("Server Started... Awaiting connection");
            
            // Program hangs here until a connection is made
            serverSocket.AcceptSocket();
            
            // If a connection is made, this will display
            Console.WriteLine("Device Connected");
            Console.ReadKey(true);
        }
    }
}
