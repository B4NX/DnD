using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    class Program {
        static void Main(string[] args) {
            Console.Write("(C)onsole or (S)erver: ");
            if (Console.ReadLine().ToUpper() == "C") {
                ConsoleTest();
            }
            ServerTest();
        }

        private static void ConsoleTest() { }
        private static void ServerTest() { }
    }
}
