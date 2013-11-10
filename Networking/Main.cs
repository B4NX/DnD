using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    class Main {
        public static void Main(string[] args) {
            Console.Write("S/C: ");
            string ans=Console.ReadLine();
            if (ans.ToUpper() == "S") {
                Console.WriteLine("Server");
                Server.init();
            } else if (ans.ToUpper() == "C") {
                Console.WriteLine("Client");
                Client.init();
            }
        }
    }
}
