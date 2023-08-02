using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS780E.Storage
{
    public class Msg
    {
        public string id { get; }
        public string from { get; }
        public string msgContent { get; }
        public DateTime recvTime { get; }

        public bool isUnread { get; set; }

        public Msg(string id, string from, string msgContent, DateTime recvTime)
        {
            this.id = id;
            this.from = from;
            this.msgContent = msgContent;
            this.recvTime = recvTime;
        }
    }
}
