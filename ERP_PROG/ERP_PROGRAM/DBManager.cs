using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ERP_PROG
{
    class DBManager
    {
        private string ConnString = "Server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8";

        private static DBManager instance = new DBManager();
        public static DBManager GetInstance() { return instance; }

        public void Insert(string query)
        {
            using (MySqlConnection Conn = new MySqlConnection(ConnString))
            {
                Conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update(string query)
        {
            using (MySqlConnection Conn = new MySqlConnection(ConnString))
            {
                Conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
            }
        }

        public MySqlDataReader Select(string query)
        {
            MySqlConnection Conn = new MySqlConnection(ConnString);
            Conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, Conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
    }
}
