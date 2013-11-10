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
            if (h == Head.EMPTY) {
                mssg=new byte[256];
            }
            this.mssg[0] = (byte)h;
        }
        public Message(Head h,byte[] b):this(h){
            for (int i = 1; i < b.GetLength(0); i++) {
                this.mssg[i]=b[i];
            }
        }
        public static Message getLogMessage(string s) {
            Message tmp=new Message(Head.LOG);
            byte[] msgArray=ToByteArray(s);
            for (int i = 0; i < msgArray.GetLength(0); ++i) {
                tmp.mssg[i + 1] = msgArray[i];
            }
            Console.WriteLine(tmp);
            return tmp;
        }
        public static byte[] ToByteArray(string s) {
            return new UnicodeEncoding().GetBytes(s);
        }
        public override string ToString() {
            string s = "";
            for (int i = 1; i <= this.mssg.GetLength(0)-1; i++) {
                if ((char)this.mssg[i] != 0) {
                    s += (char)this.mssg[i];
                }
            }
            return s;
        }
        public Head Header {
            get {
                return (Head)this.mssg[0];
            }
        }
        public byte[] GetMessage {
            get {
                return this.mssg;
            }
        }
    }
}
