using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

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
        [Obsolete("This method is obsolete, please SendToAll(Message m)")]
        public static void SendToAll(byte[] b,Header[] head=null) {
            foreach (KeyValuePair<string, NetworkStream> kvp in clients) {
                serializer.Serialize(kvp.Value,b,head);
            }
        }
        public static void SendToAll(MessageOLD m,Header[] head=null) {
            foreach (KeyValuePair<string, NetworkStream> kvp in clients) {
                serializer.Serialize(kvp.Value, m,head);
            }
        }
        public static Queue<MessageOLD> writeQueue = new Queue<MessageOLD>();
        public static void Update() {//r-s
            while (clients.Count != 0) {
                try {
                    //Recieve
                    foreach (KeyValuePair<string, NetworkStream> kvp in clients) {
                        MessageOLD m;
                        m=(MessageOLD)serializer.Deserialize(ns);
                        if (m.Header != MessageOLD.Head.EMPTY) {
                            parseMessage(m);
                        }
                    }
                    //Send
                    if (writeQueue.Count != 0) {
                        SendToAll(writeQueue.Dequeue());
                    } else if (writeQueue.Count == 0) {
                        SendToAll(new MessageOLD(MessageOLD.Head.EMPTY));
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
        public static Queue<MessageOLD> readQueue = new Queue<MessageOLD>();

        [Obsolete("Pass a Message instead")]
        public static void parseMessage(byte[] b) {
            Console.WriteLine(new MessageOLD(MessageOLD.Head.LOG, b).ToString());
            readQueue.Enqueue(new MessageOLD((MessageOLD.Head)b[0], b));
        }
        public static void parseMessage(MessageOLD m) {
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
