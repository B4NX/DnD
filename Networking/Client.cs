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
    public class Client {
        /// <summary>
        /// Represents the network service for the client.
        /// </summary>
        private static Socket sock;
        private static byte[] buffer=new byte[256];
        private static Thread read;
        public static void init() {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public static void init(IPEndPoint endPoint) {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Connect(endPoint);
        }
        public static void Connect(IPEndPoint endPoint) {
            Debug.WriteLine("Waiting for connection");
            //Handshake
            while (true) {
                try {
                    sock.Connect(endPoint);
                    break;
                } catch (SocketException e) {
                    Debug.WriteLine(e.Message);
                    continue;
                }
            }
            Debug.WriteLine("Connected!");
            read=new Thread(AsynchRead);
            read.Start();
        }
        public static void WriteMessage(Message m) {
            sock.Send(m);
        }
        //public static void talk(Socket sock) {
        //    //Main Talk loop
        //    while (true) {
        //        sock.Receive(buffer);
        //        WriteByteArray(buffer);

        //        Console.Write("Say a thing: ");
        //        sock.Send(ToByteArray(Console.ReadLine()));
        //    }
        //}
        //public static void sendString(string s) {
        //    sock.Send(ToByteArray(s));
        //}

        private static void WriteByteArray(byte[] b) {
            foreach (byte x in b) {
                if (x != 0) {
                    Console.Write((char)x);
                }
            }
            Console.WriteLine();
            ClearBuffer();
        }
        private static string ByteToString(byte[] b) {
            char[] x = new Char[b.GetLength(0)];
            for (int i = 0; i <= b.GetLength(0)-1; i++) {
                x[i]=(char)b[i];
            }
            return new String(x);
        }
        private static void ClearBuffer() {
            buffer = new byte[256];
        }
        private static void AsynchRead() {
            byte[] b=new byte[256];
            sock.Receive(b);
            buffer = b;
        }
        public static byte[] Read() {
            read.Suspend();
            byte[] tmp = buffer;
            read.Resume();
            return tmp;
        }
    }
}
