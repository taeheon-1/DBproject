using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERP_PROG
{
    class LoginManager
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int TYPE { get; set; }

        private static LoginManager instance = new LoginManager();
        public static LoginManager GetInstance() { return instance; }
        public int LoginCheck(string id, string pw)
        {
            string query = "select * from 로그인 where login_id = '" + id + "' and login_pw = '" + pw + "'";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);

            while (rdr.Read())
            {
                ID = Int32.Parse(rdr["id"].ToString());
                TYPE = Int32.Parse(rdr["type"].ToString());
                NAME = rdr["name"].ToString();
                rdr.Close();
                return 1;
            }
            rdr.Close();
            return 2;
        }
    }
}
