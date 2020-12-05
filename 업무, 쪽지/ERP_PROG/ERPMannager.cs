using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_PROG
{
    class ERPMannager
    {
        private static ERPMannager instance = new ERPMannager();
        string strConn = "Server=49.50.174.201; Database=number7; Uid=number7; Pwd=number7; Charset=utf8";


        public static ERPMannager GetInstence() { return instance; }
        MySqlConnection conn;
        private ERPMannager()
        {
            conn = new MySqlConnection(strConn);
        }
        public void Open()
        {
            conn.Open();
        }
        public void Close()
        {
            conn.Close();
        }

        public void Insert(string query)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public MySqlDataReader Select(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            return cmd.ExecuteReader();
        }
    }
}
