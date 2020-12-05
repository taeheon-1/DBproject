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
    public partial class msgview : Form
    {

        string search_title = "";
        string search_contents = "";
        string query = "";
        public msgview()
        {
            InitializeComponent();
        }



       /* private void btn_Msgsearch_Click(object sender, EventArgs e)
        {

                query = $"SELECT * FROM number7.msg WHERE msg_title = '{search_title}' AND msg_content = '{search_contents}'";
            

            if (radioButtonSearchOptionTask.Checked == true)
            {
                query = $"SELECT * FROM number7.task WHERE task_worker = '{LoginUser}' AND task_smallcat = '{search_keyword}'";
            }

            if (radioButtonSearchOptionWrittenBy.Checked == true)
            {
                query = $"SELECT * FROM number7.task WHERE task_worker = '{LoginUser}' AND task_writtenby = '{search_keyword}'";
            }
        }*/

        private void textBoxSearchtitle_TextChanged(object sender, EventArgs e)
        {
            search_title = textBoxSearchtitle.Text;
            search_contents = textBoxSearchtitle.Text;
            query = $"SELECT * FROM number7.msg WHERE msg_title = '{search_title}'AND msg_contents = '{search_contents}'";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query);
            while (rdr.Read())
            {
                ListViewItem lvi = new ListViewItem(rdr.GetString(1));
                lvi.SubItems.Add(rdr.GetString(3));
                lvi.SubItems.Add(rdr.GetString(4));
                lvi.SubItems.Add(rdr.GetString(5));
                listViewMsg.Items.Add(lvi);
            }

        }
    }
}
