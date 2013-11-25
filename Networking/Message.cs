using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    [Serializable]
    public abstract class Message {
        protected enum Head {
            EMPTY,
            STAT,
            LOG,
            FULL,
            MONSTER,
            MAP,
            NPC
        };
        protected Head header;
    }
}
