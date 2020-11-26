using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_PROG
{
    class ERPManager
    {
       
        private static ERPManager instance = new ERPManager(); //객체 생성
        private string strConn = "Server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8";

        public static ERPManager GetInstance() { return instance; } //객체를 리턴

        private ERPManager() { } //생성자


        public void Insert(string query) //insert 문
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {

                conn.Open(); //db연결
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery(); //실행
                conn.Close();
            }
        }

        public MySqlDataReader Select(string query) //select 문
        {
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open(); //db연결
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader(); //값 받아옴
            return rdr;
        }

        public void Update(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open(); //db연결
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery(); //실행
            }
        }

        public void Delete(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open(); //db연결
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery(); //실행
            }
        }

    }
}
    
