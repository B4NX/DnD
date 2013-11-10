using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Networking {
    public static class Server {
        static FileStream fs = File.Create("Server.log");
        static List<Tuple<TcpClient, NetworkStream>> clients = 
            new List<Tuple<TcpClient, NetworkStream>>();

        public static void init() {
            //fs.Write(
            TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"),666);
            server.Start();
            while (true) {
                TcpClient s=server.AcceptTcpClient();
                NetworkStream ns = s.GetStream();
                
            }
        }
    }
}
