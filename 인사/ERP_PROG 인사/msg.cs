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
            combox_text();
        }
        public void combox_text()
        {
            string query = "select * from number7.사원TEST";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query);
            while (rdr.Read())
            {
                string sName = rdr.GetString("employee_name");
                Recipient.Items.Add(sName);
            }
        }
        private void Recipient_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* string query = "select * from number7.사원TEST";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query);
            while (rdr.Read())
            {
                string sName = rdr.GetString("employee_name");
                Recipient.Items.Add(sName);
            }*/

        }
    }
}

