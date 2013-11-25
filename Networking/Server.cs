using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.Serialization;

namespace Networking {
    [Obsolete("Use ServerNS")]
    public class Server {
        /// <summary>
        /// Represents the network service for the Server
        /// </summary>
        private static Socket sock;
        public static Dictionary<string, Socket> clients = new Dictionary<string, Socket>();
        static byte[] buffer = new byte[256];
        public static Thread updateThread;
        private static BinaryFormatter serializer = new BinaryFormatter();

        private static NetworkStream ns;

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
                    //Console.WriteLine(sock.Connected);
                    ns = new NetworkStream(client);
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
        public static Queue<MessageOLD> writeQueue = new Queue<MessageOLD>();
        public static Queue<MessageOLD> nsQueue = new Queue<MessageOLD>();
        public static void Update() {//r-s
            while (clients.Count!=0) {
                try {
                    //Recieve
                    foreach (KeyValuePair<string, Socket> kvp in clients) {
                        byte[] tempRead = new byte[256];
                        kvp.Value.Receive(tempRead);

                        if (tempRead[0] != (byte)MessageOLD.Head.EMPTY) {
                            nsQueue.Enqueue((MessageOLD)serializer.Deserialize(ns));
                            //parseMessage(tempRead);
                            Console.WriteLine();
                        }
                    }
                    //ns.flsu
                    //Send
                    if (writeQueue.Count != 0) {
                        MessageOLD m = writeQueue.Dequeue();
                        //SendToAll(writeQueue.Dequeue().GetMessage);
                        serializer.Serialize(ns, m, null);
                    } else if (writeQueue.Count == 0) {
                        //SendToAll(new Message(Message.Head.EMPTY).GetMessage);
                        serializer.Serialize(ns, new MessageOLD(MessageOLD.Head.EMPTY), null);
                    }
                } catch (SocketException e) {
                    Debug.WriteLine(e);
                    Close();
                } catch (InvalidOperationException e) {
                    Debug.WriteLine(e);
                    Close();
                } catch (SerializationException e) {
                    Debug.WriteLine(e);
                }
            }
        }
        public static Queue<MessageOLD> readQueue = new Queue<MessageOLD>();
        public static void parseMessage(byte[] b) {
            Console.WriteLine(new MessageOLD(MessageOLD.Head.LOG, b).ToString());
            readQueue.Enqueue(new MessageOLD((MessageOLD.Head)b[0], b));
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

        public static List<string> allConnected {
            get {
                List<string> c=new List<string>();
                foreach (KeyValuePair<string, Socket> kvp in clients) {
                    c.Add(kvp.Key);
                }
                return c;
            }
        }
    }
}
