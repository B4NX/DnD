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
        public static Thread updateThread;

        public static Queue<Message> writeQueue = new Queue<Message>();
        public static Queue<Message> readQueue = new Queue<Message>();
        
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
            updateThread=new Thread(Update);
            updateThread.Name = "Network-C-Update";
            updateThread.Start();
        }
        private static byte[] readBuffer=new byte[256];
        public static void Update() {
            while (true) {
                //Send
                if (writeQueue.Count != 0) {
                    System.Diagnostics.Debug.WriteLine("x");
                    sock.Send(writeQueue.Dequeue());
                } else if (writeQueue.Count == 0) {
                    sock.Send(Message.EMPTY);
                }
                //Receive
                sock.Receive(readBuffer);
                Message m = new Message(readBuffer);
                if (m.Header != Message.HeaderVal.EMPTY) {
                    readQueue.Enqueue(m);
                }
            }
        }
    }
}
