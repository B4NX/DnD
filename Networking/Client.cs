using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Networking {
    class Client {
        /// <summary>
        /// Represents the network service for the client.
        /// </summary>
        private static Socket sock;
        private static byte[] buffer=new byte[256];
        public static void init() {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public static void Connect(IPEndPoint endPoints) {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.20.144"), 666);
            Debug.WriteLine("Waiting for connection");
            //Handshake
            while (true) {
                try {
                    sock.Connect(ep);
                    break;
                } catch (SocketException e) {
                    Debug.WriteLine(e.Message);
                    continue;
                }
            }
            Debug.WriteLine("Connected!");
            Console.WriteLine("Connected!");
        }
        public static void talk(Socket sock) {
            //Main Talk loop
            while (true) {
                sock.Receive(buffer);
                WriteByteArray(buffer);

                Console.Write("Say a thing: ");
                sock.Send(ToByteArray(Console.ReadLine()));
            }
        }

        private static void WriteByteArray(byte[] b) {
            foreach (byte x in b) {
                if (x != 0) {
                    Console.Write((char)x);
                }
            }
            Console.WriteLine();
            ClearBuffer();
        }
        private static byte[] ToByteArray(string s) {
            return new UnicodeEncoding().GetBytes(s);
        }
        private static void ClearBuffer() {
            buffer = new byte[256];
        }
    }
}
