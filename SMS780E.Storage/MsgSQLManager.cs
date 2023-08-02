using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS780E.Storage
{
    public class MsgSQLManager
    {
        SQL sql;

        public MsgSQLManager()
        {
            sql = new SQL();
        }

        public void InsertNewMsgToDb(Msg msg)
        {
            sql.NewMsg(msg);
        }

        public DataTable GetMsgDataTable()
        {
            return sql.GetAllMsg();
        }

        public Msg GetMsg(string msgid)
        {
            return sql.GetOneMsg(msgid);
        }

        public DataTable SearchMsg(string keywords)
        {
            return sql.SearchMsg(keywords);
        }

        public void SetMsgReadedState(string msgid)
        {
            sql.SetReaded(msgid);
        }
    }
}
