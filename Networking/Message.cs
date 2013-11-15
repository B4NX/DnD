using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Networking {
    [Serializable]
    public class Message {

        //Some thoughts about formats...
        //STAT:
        //  First section: whose stat (player ID - one byte)
        //  Second section: what stat (we'll need an enum or array of stat IDs
        //     - if we want to make DMs able to define stats on the fly, 
        //        we should make it dynamic
        //     - You will never, ever, ever, need to define stats on the fly, it just doesn't happen
        //        all the stats that you have are already predefined unless you're doing some really trippy stuff
        //  Third section: value (could this ever be string? or just int16?)
        //LOG:
        //   - Perhaps split into LOG and CHAT to differentiate between game output
        //     and messages from players/DM?
        //  First section: player name, alias, DM, or monster (whatever goes in [])
        //  Second section: chat message
        //FULL:
        //   - Dafuq is this for?
        //   - It's for the full update of the game state when the plaer first connects to the game
        //MONSTER:
        //   - Is this adding a monster, or changing a monster's stat? If the former,
        //      we'll need to allow monster IDs in the STAT message
        //   - This would be for adding a moster
        //MAP:
        //  First section: type of map revision (tile update, map reset, movement, etc) - ENUM
        //       - This may change a bit as the map changes formats - I need to diferentiate
        //          between the base map and things that are on the map (so you can have partially
        //          filled tiles)
        //  Second section: coordinates of revision (1 byte each, map is 100x100 
        //      so each coord can fit in a byte)
        //NPC:
        //   - Is this adding an NPC, or changing an NPC's stat? See monster. Also need to figure
        //       out how NPCs will figure into what we have, as it might be odd to list them in the
        //      "Monster" section...
        //   - For adding an NPC, you rarely need to change an NPC's stats, infact, stat changes should
        //      just use the same method as player stat changes
        //Hash:
        //   - Hash of the player's client for anti-hack
        //Thinking about how to implement all this, perhaps have a bunch of subclasses of Message?
        //The header should allow the recipient to recreate it on the receiving end.

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
