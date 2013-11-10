using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    public class Message {
        public static Message EMPTY=new Message(HeaderVal.EMPTY);
        public enum HeaderVal {
            EMPTY,
            STAT,
            LOG,
            FULL,
            MONSTER,
            MAP,
            NPC
        };
        private byte[] mssg;
        private HeaderVal header;
        //First Byte is the header to indicate what the message means
        public Message() {
            mssg = new byte[256];
        }
        public Message(HeaderVal hv){
            if (hv==HeaderVal.EMPTY){
                mssg=new byte[256];
            }
        }
        public Message(byte[] b) {
            this.header = (HeaderVal)b[0];
            this.mssg = b;
        }
        public static Message getLogMessage(string message) {
            Message temp = new Message();
            temp.header = HeaderVal.LOG;
            temp.mssg[0] = 2;
            byte[] tempMess = ToByteArray(message);
            for (int i = 0; i <= tempMess.Length - 1;++i) {
                temp.mssg[i+1] = tempMess[i];
            }
            return temp;
        }
        public static implicit operator byte[](Message m){
            return m.mssg;
        }
        public static implicit operator Message(byte[] b) {
            Message tmp = new Message();
            tmp.header = (HeaderVal)b[0];
            tmp.mssg = b;
            return tmp;
        }
        private static byte[] ToByteArray(string s) {
            return new UnicodeEncoding().GetBytes(s);
        }
        private static string ByteToString(byte[] b) {
            char[] x = new Char[b.GetLength(0)];
            for (int i = 0; i <= b.GetLength(0) - 1; i++) {
                x[i] = (char)b[i];
            }
            return new String(x);
        }
        public override string ToString() {
            string s="";
            for (int i = 1; i <= this.mssg.Length - 1; i++) {
                if (i != 0) {
                    s += this.mssg[i];
                    continue;
                }
            }
            return s;
        }

        public HeaderVal Header {
            get {
                return this.header;
            }
        }
    }
}
