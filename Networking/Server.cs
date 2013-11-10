using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace Networking {
    class Server {
        public static void init() {
            
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 666);
            sock.Bind(ep);
            sock.Listen(Int32.MaxValue);
            Debug.WriteLine("Waiting for connection");
            Socket client;
            while (true) {
                try {
                    client = sock.Accept();
                    break;
                } catch (SocketException e) {
                    Debug.WriteLine(e.Message);
                    continue;
                }
            }
            Debug.WriteLine("Connected!");

            byte[] b = new byte[256];
            client.Receive(b);
            WriteByeArray(b);
            
            Console.WriteLine("Please say something nice to your \"friend\".");
            string s=Console.ReadLine();
            client.Send(ToByteArray(s));

            client.Receive(b);
            WriteByeArray(b);
            while (true) ;
            
        }
        private static void WriteByeArray(byte[] b) {
            foreach (byte x in b) {
                if (x != 0) {
                    Console.Write((char)x);
                }
            }
        }
        private static byte[] ToByteArray(string s) {
            return new UnicodeEncoding().GetBytes(s);
        }
    }
}
