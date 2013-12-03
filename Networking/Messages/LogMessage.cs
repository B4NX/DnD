using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking.Messages {
    public class LogMessage:Message{
        private string message;
        public bool isShrinkWrapped = false;

        private LogMessage() {
            this.header = Head.LOG;
        }

        public static LogMessage createMessage(string s) {
            LogMessage m=new LogMessage();
            m.message = s;
            return m;
        }
        public LogMessage(string s) {
            createMessage(s);
        }

        public bool IsShrinkWrapped {
            get {
                throw new WTFDidYouDoAndyException();
            }
        }
    }
}
