using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    public interface IMessage {
        IMessage Create();
    }
}
