using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SMS780E.Storage
{
    internal class SQL
    {
        SQLiteConnection conn;

        internal SQL()
        {
            OpenConnect();
        }

        private void OpenConnect()
        {
            conn = new SQLiteConnection("Data Source=.\\SMS.db;Version=3;");//没有数据库则自动创建
            conn.Open();

            string sql = "SELECT name FROM sqlite_master WHERE type='table' AND name='recvbox'";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows == false)
            {
                CreateTable();
            }

        }

        //在指定数据库中创建一个table
        internal void CreateTable()
        {
            string sql = "create table if not exists recvbox (id varchar(50), sender nvarchar(50), msg TEXT, recvtime varchar(50), isunread integer)";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        //插入一些数据
        internal void NewMsg(Msg msg)
        {
            string sql = "insert into recvbox (id, sender, msg, recvtime, isunread) values ('" +
                Convert.ToString(DateTime.Now.Ticks, 16) + "','" +
                msg.from + "','" +
                msg.msgContent + "','" +
                msg.recvTime + "',1)";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
        }

        //使用sql查询语句，并显示结果
        internal DataTable GetAllMsg()
        {
            string sql = "select * from recvbox order by recvtime desc";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //    Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
            //Console.ReadLine();
            DataTable dt = new DataTable();

            dt.Load(reader);

            return dt;
        }

        internal DataTable SearchMsg(string keywords)
        {
            string sql = "select * from recvbox where sender like '%" + keywords + "%' or msg like '%" + keywords + "%'";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //    Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
            //Console.ReadLine();
            DataTable dt = new DataTable();

            dt.Load(reader);

            return dt;
        }



        internal Msg GetOneMsg(string msgid)
        {
            string sql = "select id, sender, msg, recvtime, isunread from recvbox where id = '" + msgid + "'";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //    Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
            //Console.ReadLine();
            DataTable dt = new DataTable();

            dt.Load(reader);

            Msg msg = new Msg(
                dt.Rows[0][0].ToString(),
                dt.Rows[0][1].ToString(),
                dt.Rows[0][2].ToString(),
                Convert.ToDateTime(dt.Rows[0][3].ToString()));
            if (dt.Rows[0][4].ToString().Contains("1"))
            {
                msg.isUnread = true;
            }
            else
            {
                msg.isUnread = false;
            }

            return msg;
        }

        internal void SetReaded(string msgid)
        {
            string sql = "update recvbox set isunread = 0 where id = '" + msgid + "'";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

        }
    }
}
