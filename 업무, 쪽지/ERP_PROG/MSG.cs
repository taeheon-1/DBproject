using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_PROG
{
    public partial class msg : Form
    {
        public msg()
        {
            InitializeComponent();
            combobox_load();
        }
    public void combobox_load()
        {
            ERPMannager.GetInstence().Open(); //디비매니저 클래스에서 오픈
            string query = ("select * from 사원TEST");
            MySqlDataReader rdr = ERPMannager.GetInstence().Select(query);

            while (rdr.Read())
            {
                string MName = rdr["employee_name"].ToString();
                Recipient.Items.Add(MName);
            }
            ERPMannager.GetInstence().Close();
        }
    }
}
