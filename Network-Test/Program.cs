using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkingTest {
    class Program {
        static void Main(string[] args) {
            Console.Write("(C)onsole or (S)erver: ");
            if (Console.ReadLine().ToUpper() == "C") {
                ClientTest();
            }
            ServerTest();
        }

        private static void ClientTest() {
            Client.init();

        }
        private static void ServerTest() { }
    }
}
