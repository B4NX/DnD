using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    public class Message {
        private byte[] mssg;
        //private byte header;
        //First Byte is the header to indicate what the message means
        public Message() {
            mssg = new byte[256];
        }
        public static Message getLogMessage(string message) {
            Message temp = new Message();
            //temp.header = 2;
            temp.mssg[0] = 2;
            byte[] tempMess = ToByteArray(message);
            for (int i = 0; i <= tempMess.Length - 1;) {
                temp.mssg[i++] = tempMess[i];
            }
            return temp;
        }
        public static implicit operator byte[](Message m){
            return m.mssg;
        }
        private static byte[] ToByteArray(string s) {
            return new UnicodeEncoding().GetBytes(s);
        }
    }
}
