using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace Networking {
    class Server {
        /// <summary>
        /// Represents the network service for the Server
        /// </summary>
        private static Socket sock;
        public static Dictionary<string, Socket> clients = new Dictionary<string, Socket>();
        static byte[] buffer = new byte[256];
        public static void init() {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 666);
            sock.Bind(ep);            
        }
        public static Socket connect() {
            sock.Listen(Int32.MaxValue);
            Debug.WriteLine("Waiting for connection");
            Socket client;
            //Handshake
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
            Console.WriteLine("Connected!");
            clients.Add("Test", client);
            return client;
        }
        public static void Test() {
            Socket s = clients["Test"];
            byte[] fubar = new byte[256];
            while (true) {
                s.Receive(fubar);
                WriteByteArray(ref fubar);
            }
        }
        public static void Talk(Socket client) {
            //Main Talk loop
            while (true) {
                Console.Write("Say thing: ");
                client.Send(ToByteArray(Console.ReadLine()));

                client.Receive(buffer);
                WriteByteArray(ref buffer);
            }
        }
        private static void WriteByteArray(ref byte[] b) {
            foreach (byte x in b) {
                if (x != 0) {
                    Console.Write((char)x);
                }
            }
            Console.WriteLine();
            clearBuffer(ref b);
        }
        private static byte[] ToByteArray(string s) {
            return new UnicodeEncoding().GetBytes(s);
        }
        private static void clearBuffer(ref byte[] b){
            b = new byte[b.Length];
        }
    }
}
