using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_PROG
{
    class DetailedStatement
    {
        private string strconn = "Server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8";
        private static DetailedStatement instance = new DetailedStatement(); //객체 생성
        public static DetailedStatement GetInstance() { return instance; } //객체를 리턴
        private DetailedStatement() { } //생성자

        public MySqlDataReader Select(string query) //Select문
        {
            MySqlConnection conn = new MySqlConnection(strconn);
            
            conn.Open(); //db연결
            
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader(); //값 받아옴
            
            return rdr;
        }

        public void Insert(string query) //Insert문
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open(); //db연결

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery(); //실행
                
                conn.Close();
            }
        }

        public void Update(string query) //Update문
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open(); //db연결

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery(); //실행
            }
        }
    }
}
