using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;

namespace Networking {
    class Server {
        /// <summary>
        /// Represents the network service for the Server
        /// </summary>
        private static Socket sock;
        public static Dictionary<string, Socket> clients = new Dictionary<string, Socket>();
        static byte[] buffer = new byte[256];
        public static Thread updateThread;
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
            updateThread = new Thread(Update);
            updateThread.Start();
            return client;
        }
        public static void Test() {
            Socket s = clients["Test"];
            byte[] fubar = new byte[256];
            while (true) {
                s.Receive(fubar);
                SendToAll(fubar);

                WriteByteArray(ref fubar);

                Console.Write("Type something: ");
                SendToAll(ToByteArray(Console.ReadLine()));
            }
        }
        public static void SendToAll(byte[] b) {
            foreach (KeyValuePair<string, Socket> kvp in clients) {
                kvp.Value.Send(b);
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
        public static Queue<Message> writeQueue = new Queue<Message>();
        public static void Update() {//r-s
            while (true) {
                //Recieve
                foreach (KeyValuePair<string, Socket> kvp in clients) {
                    byte[] tempRead = new byte[256];
                    kvp.Value.Receive(tempRead);
                    if (new Message(tempRead).Header != Message.HeaderVal.EMPTY) {
                        parseMessage(tempRead);
                    }
                }
                //Send
                if (writeQueue.Count!=0){
                    SendToAll(writeQueue.Dequeue());
                } else if (writeQueue.Count == 0) {
                    SendToAll(Message.EMPTY);
                }
            }
        }
        public static void parseMessage(byte[] b) {
            Console.WriteLine(new Message(b).ToString());
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
