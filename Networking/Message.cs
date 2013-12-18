using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    [Serializable]
    public abstract class Message {
        public enum Head {
            EMPTY,
            STAT,
            LOG,
            FULL,
            MONSTER,
            MAP,
            NPC
        };
        protected Head header;

        public Head Header {
            get {
                return this.header;
            }
        }

        public override string ToString() {
            return this.GetType().ToString();
        }
    }
}
