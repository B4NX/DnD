﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    class AnythingYouWant {
        public static void Main(string[] args) {
            Console.Write("S/C: ");
            string ans=Console.ReadLine();
            if (ans.ToUpper() == "S") {
                Console.WriteLine("Server");
                Server.init();
                Server.Connect();
                //Server.Test();
            } else if (ans.ToUpper() == "C") {
                Console.WriteLine("Client");
                Client.init();
            }
        }
    }
}
