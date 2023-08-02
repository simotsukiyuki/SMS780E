using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SMS780E.Storage
{
    public static class MsgTools
    {
        public static Msg ParseJsonToMsg(string json)
        {
            JObject msgObj = JObject.Parse(json);
            string sender = msgObj["from"].ToString();
            string msgContent = msgObj["data"].ToString();

            Msg msg=new Msg(
                Convert.ToString(DateTime.Now.Ticks, 16),
                sender, msgContent,DateTime.Now);

            return msg;
        }
    }
}
