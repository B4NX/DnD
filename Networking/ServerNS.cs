using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Networking.Messages;

namespace Networking {
    public class ServerNS {
        /// <summary>
        /// Represents the network service for the Server
        /// </summary>
        private static Socket localSock;
        public static Dictionary<string, NetworkStream> clients = new Dictionary<string, NetworkStream>();
        private static NetworkStream ns;
        static byte[] buffer = new byte[256];
        public static Thread updateThread;

        private static BinaryFormatter serializer = new BinaryFormatter();

        public static void init(int port = 666) {
            localSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, port);
            localSock.Bind(ep);
        }

        public static Socket Connect() {
            localSock.Listen(Int32.MaxValue);
            Debug.WriteLine("Waiting for connection");
            Socket client;
            //Handshake
            while (true) {
                try {
                    client = localSock.Accept();
                    ns = new NetworkStream(client);
                    break;
                } catch (SocketException e) {
                    Debug.WriteLine(e.Message);
                    continue;
                }
            }
            Debug.WriteLine("Connected!");
            //Console.WriteLine("Connected!");
            clients.Add("Test", new NetworkStream(client));

            //ClientConnected.BeginInvoke(client, new EventArgs(), null, null);

            updateThread = new Thread(Update);
            updateThread.Name = "Network-S Update";
            updateThread.Start();
            return client;
        }

        [Obsolete("This method is obsolete, use SendToAll(Message m)")]
        public static void SendToAll(byte[] b,Header[] head=null) {
            foreach (KeyValuePair<string, NetworkStream> kvp in clients) {
                serializer.Serialize(kvp.Value,b,head);
            }
        }

        public static void SendToAll(Message m,Header[] head=null) {
            foreach (KeyValuePair<string, NetworkStream> kvp in clients) {
                serializer.Serialize(kvp.Value, m,head);
            }
        }
        public static Queue<Message> writeQueue = new Queue<Message>();
        public static void Update() {//r-s
            while (clients.Count != 0) {
                try {
                    //Recieve
                    foreach (KeyValuePair<string, NetworkStream> kvp in clients) {
                        Message m;
                        m=(Message)serializer.Deserialize(ns);
                        if (m.Header != Message.Head.EMPTY) {
                            parseMessage(m);
                        }
                    }
                    //Send
                    if (writeQueue.Count != 0) {
                        SendToAll(writeQueue.Dequeue());
                    } else if (writeQueue.Count == 0) {
                        SendToAll(new BlankMessage());
                    }
                } catch (SocketException e) {
                    Debug.WriteLine(e);
                    Close();
                } catch (InvalidOperationException e) {
                    Debug.WriteLine(e);
                    Close();
                }
            }
        }
        public static Queue<Message> readQueue = new Queue<Message>();

        public static void parseMessage(Message m) {
            writeQueue.Enqueue(m);
            Console.WriteLine(m.ToString());
            readQueue.Enqueue(m);
        }
        public static void Close() {
            List<string> toRemove = new List<string>();
            foreach (KeyValuePair<string, NetworkStream> kvp in clients) {
                kvp.Value.Close();
                toRemove.Add(kvp.Key);
            }
            foreach (string s in toRemove) {
                clients.Remove(s);
            }
        }
        public static List<string> allConnected {
            get {
                List<string> c = new List<string>();
                foreach (KeyValuePair<string, NetworkStream> kvp in clients) {
                    c.Add(kvp.Key);
                }
                return c;
            }
        }
    }
}
