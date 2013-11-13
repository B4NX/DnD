using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;

namespace Networking {
    public class Server {
        /// <summary>
        /// Represents the network service for the Server
        /// </summary>
        private static Socket sock;
        public static Dictionary<string, Socket> clients = new Dictionary<string, Socket>();
        static byte[] buffer = new byte[256];
        public static Thread updateThread;

        public static void init(int port = 666) {
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, port);
            sock.Bind(ep);
        }

        public static Socket Connect() {
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
            //Console.WriteLine("Connected!");
            clients.Add("Test", client);

            //ClientConnected.BeginInvoke(client, new EventArgs(), null, null);

            updateThread = new Thread(Update);
            updateThread.Name = "Network-S Update";
            updateThread.Start();
            return client;
        }
        public static void SendToAll(byte[] b) {
            foreach (KeyValuePair<string, Socket> kvp in clients) {
                kvp.Value.Send(b);
            }
        }
        public static Queue<Message> writeQueue = new Queue<Message>();
        public static void Update() {//r-s
            while (clients.Count!=0) {
                try
                {
                    //Recieve
                    foreach (KeyValuePair<string, Socket> kvp in clients)
                    {
                        byte[] tempRead = new byte[256];
                        kvp.Value.Receive(tempRead);
                        if (tempRead[0] != (byte)Message.Head.EMPTY)
                        {
                            parseMessage(tempRead);
                        }
                    }
                    //Send
                    if (writeQueue.Count != 0)
                    {
                        SendToAll(writeQueue.Dequeue().GetMessage);
                    }
                    else if (writeQueue.Count == 0)
                    {
                        SendToAll(new Message(Message.Head.EMPTY).GetMessage);
                    }
                }
                catch (SocketException e)
                {
                    Debug.WriteLine(e);
                    Close();
                }
                catch (InvalidOperationException e)
                {
                    Debug.WriteLine(e);
                    Close();
                }
            }
        }
        public static Queue<Message> readQueue = new Queue<Message>();
        public static void parseMessage(byte[] b) {
            Console.WriteLine(new Message(Message.Head.LOG, b).ToString());
            readQueue.Enqueue(new Message((Message.Head)b[0], b));
        }
        public static void Close() {
            List<string> toRemove = new List<string>();
            foreach (KeyValuePair<string,Socket> kvp in clients){
                kvp.Value.Close();
                toRemove.Add(kvp.Key);
            }
            foreach (string s in toRemove) {
                clients.Remove(s);
            }
        }
    }
}
