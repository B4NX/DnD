using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace Networking {
    public class ClientNS {
        /// <summary>
        /// Represents the network service for the client.
        /// </summary>
        private static Socket sock;
        private static NetworkStream ns;
        private static BinaryFormatter serializer;
        //private static byte[] buffer = new byte[256];
        public static Thread updateThread;

        public static Queue<Message> writeQueue = new Queue<Message>();
        public static Queue<Message> readQueue = new Queue<Message>();

        public static void init() {
            serializer = new BinaryFormatter();
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
                    ns = new NetworkStream(sock);
                    break;
                } catch (SocketException e) {
                    Debug.WriteLine(e.Message);
                    continue;
                }
            }
            Debug.WriteLine("Connected!");
            updateThread = new Thread(Update);
            updateThread.Name = "Network-C-Update";
            updateThread.Start();
        }
        private static byte[] readBuffer = new byte[256];
        public static void Update() {
            bool hasSocket = true;
            while (hasSocket) {
                //Send
                try {
                    if (writeQueue.Count != 0) {
                        Message sm = writeQueue.Dequeue();
                        serializer.Serialize(ns, sm);
                    }
                    //Receive
                    Message m = (Message)serializer.Deserialize(ns);
                    if (m.Header != Message.Head.EMPTY) {
                        readQueue.Enqueue(m);
                    }
                } catch (SocketException e) {
                    Debug.WriteLine(e.Message);
                    sock.Close();
                    hasSocket = false;
                }
            }
        }

        public static void Close() {
            sock.Close();
        }
    }
}
