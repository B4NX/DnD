using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    class Message {
        public Message() {

        }
        public static implicit operator byte[](Message m){

            return new byte[256];
        }
    }
}
