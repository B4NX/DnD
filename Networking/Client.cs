using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace Networking {
    class Client {
        private static byte[] buffer=new byte[256];
        public static void init() {

            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.20.144"), 666);
            Debug.WriteLine("Waiting for connection");
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
            sock.Send(ToByteArray("Talk"));
            
            sock.Receive(buffer);
            WriteByeArray(buffer);

            Console.WriteLine("Please say something nice to your \"friend\".");
            string s = Console.ReadLine();
            sock.Send(ToByteArray(s));
            while (true) {
                sock.Receive(buffer);
                WriteByeArray(buffer);

                Console.Write("Say a thing: ");
                sock.Send(ToByteArray(Console.ReadLine()));
            }

        }
        private static void WriteByeArray(byte[] b) {
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
