using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace Networking {
    [Obsolete("Use ServerNS")]
    public class Client {
        /// <summary>
        /// Represents the network service for the client.
        /// </summary>
        private static Socket sock;
        private static byte[] buffer=new byte[256];
        public static Thread updateThread;

        public static Queue<Message> writeQueue = new Queue<Message>();
        public static Queue<Message> readQueue = new Queue<Message>();

        private static NetworkStream ns;
        private static BinaryFormatter serializer = new BinaryFormatter();
        
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
            ns = new NetworkStream(sock);
            updateThread=new Thread(Update);
            updateThread.Name = "Network-C-Update";
            updateThread.Start();
        }

        private static byte[] readBuffer=new byte[256];
        private static Queue<Message> nsQueue = new Queue<Message>();
        public static void Update() {
            bool hasSocket = true;
            while (hasSocket) {
                //Send
                try {
                    if (writeQueue.Count != 0) {
                        Message message=writeQueue.Dequeue();
                        //sock.Send(message.GetMessage);
                        serializer.Serialize(ns,message,null);
                        
                    }
                    else if (writeQueue.Count == 0) {
                        //sock.Send(new Message(Message.Head.EMPTY).GetMessage);
                        serializer.Serialize(ns, new Message(Message.Head.EMPTY),null);
                    }
                    //Receive
                    //sock.Receive(readBuffer);
                    //Message m = new Message((Message.Head)readBuffer[0], readBuffer);
                    Message m=(Message)serializer.Deserialize(ns);
                    if (m.Header != Message.Head.EMPTY) {
                        readQueue.Enqueue(m);
                    }
                }
                catch (SocketException e) { 
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
