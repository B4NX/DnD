using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Networking {
    public class Send {
        private static TcpClient client = new TcpClient();
        public static void Run() {
            client.Connect("127.0.0.1", 666);
            NetworkStream stream = client.GetStream();
            StreamReader streamReader = new StreamReader(stream);
            StreamWriter streamWriter = new StreamWriter(stream);
            streamWriter.Write("Banana");
        }
    }
}
