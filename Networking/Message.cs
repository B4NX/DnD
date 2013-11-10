using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    public class Message {
        private byte[] mssg = new byte[256];
        public enum Head {
            EMPTY,
            STAT,
            LOG,
            FULL,
            MONSTER,
            MAP,
            NPC
        };
        public Message(Head h) {
            this.mssg[0] = (byte)(int)h;
        }
        public static void getLogMessage(string s) {
            Message tmp=new Message(Head.LOG);
            byte[] msgArray=ToByteArray(s);
            for (int i = 0; i <= msgArray.GetLength(0) - 1; i++) {
                tmp.mssg[i + 1] = msgArray[i];
            }
            Console.WriteLine(tmp);
        }
        public static byte[] ToByteArray(string s) {
            return new UnicodeEncoding().GetBytes(s);
        }
        public override string ToString() {
            string s = "";
            for (int i = 1; i <= this.mssg.GetLength(0)-1; i++) {
                s += (char)this.mssg[i];
            }
            return s;
        }
    }
}
