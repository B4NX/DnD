using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    public class MessageAbstract {

        protected byte[] message;//Each message is 256 bytes, head+message
        protected byte head;

        public enum Head {
            EMPTY,      //0
            STAT,       //1
            LOG,        //2- aka Text Message
            FULL,       //3
            MONSTER,    //4
            MAP,        //5
            NPC         //6
        };

        public MessageAbstract(Head h, byte[] m) {
            this.message = new byte[256];
            getHeadByte(h);

            if (m.Length > this.message.Length) {
                throw new WTFDidYouDoAndyException();
            } else {
                this.message = m;
            }
        }
        private byte[] getMessage(byte[] m) {
            
            return m;
        }
        protected void getHeadByte(Head h) {
            this.head = (byte)h;
        }
    }
}
