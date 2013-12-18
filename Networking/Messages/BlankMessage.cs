using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking.Messages {
    [Serializable]
    class BlankMessage :Message{
        public BlankMessage() {
            this.header = Head.EMPTY;
        }
    }
}
