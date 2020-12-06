using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERP_PROG
{
    public partial class msgview : Form
    {
        string LoginUserName = NormalForm.LoginUserName;
        string strconn = "server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8;";

        public msgview()
        {
            InitializeComponent();
        }
        private void msgview_Load(object sender, EventArgs e)
        {
            string query = $"select msg_id,msg_sender,msg_title,msg_contents from number7.msg where msg_recipient='{LoginUserName}'";
            Load_msg(query);
        }

        private void Load_msg(string query)
        {
            listViewMsg.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem lvi = new ListViewItem(rdr.GetString(0));
                        lvi.SubItems.Add(rdr.GetString(1));
                        lvi.SubItems.Add(rdr.GetString(2));
                        lvi.SubItems.Add(rdr.GetString(3));
                        listViewMsg.Items.Add(lvi);
                    }
                }
                else
                {
                    MessageBox.Show("데이터가 없습니다.");
                }
                rdr.Close();
                conn.Close();
            }
        }


        string strConn = "server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8;";
        private void LoadTasks(ListView listView, string query)
        {
            listView.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        ListViewItem lvi = new ListViewItem(rdr.GetString(0));
                        lvi.SubItems.Add(rdr.GetString(1));
                        lvi.SubItems.Add(rdr.GetString(3));
                        lvi.SubItems.Add(rdr.GetString(4));
                        lvi.SubItems.Add(rdr.GetString(5));
                        listView.Items.Add(lvi);
                    }
                }
                else
                {
                    MessageBox.Show("데이터가 없습니다.");
                }

                rdr.Close();
                conn.Close();
            }
        }


        // 검색
        private void btn_Msgsearch_Click(object sender, EventArgs e)
        {
            string msgsender1 = "";
            
            string search_keyword = textBoxSearchtitlecontents.Text;
            string query = "";

            if (radiobutton_sender.Checked == true)
            {
                query = $"SELECT * FROM number7.msg WHERE msg_recipient ='{LoginUserName}' && msg_sender LIKE '%{search_keyword}%'";
            }

            if (radioButton_title.Checked == true)
            {
                query = $"SELECT * FROM number7.msg WHERE msg_recipient ='{LoginUserName}' && msg_title LIKE '%{search_keyword}%'";
            }

            if (radioButton_contents.Checked == true)
            {
                query = $"SELECT * FROM number7.msg WHERE msg_recipient ='{LoginUserName}' && msg_contents LIKE '%{search_keyword}%'";
            }

            LoadTasks(listViewMsg, query);
/*
            string query2 = "Select msg_sender from msg";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
            while (rdr.Read())
            {
                msgsender1 = rdr.GetString("msg_sender");

                textBoxSearchsender.Text = msgsender1;
            }
            textBoxSearchsender.Clear();
            textBoxSearchtitlecontents.Clear();*/

        }

        // 쪽지보내기
        private void btn_Msgwrite_Click(object sender, EventArgs e)
        {
            msgWrite msgwrite = new msgWrite();
            msgwrite.Show();
        }

        // 쪽지 확인
        private void listViewMsg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selected = listViewMsg.FocusedItem;

            string msgid = selected.SubItems[0].Text;
            MSG.msgtitle = selected.SubItems[2].Text;
            MSG.msgsender = selected.SubItems[1].Text;
            MSG.msgreceiver = LoginUserName;
            MSG.msgcontents = selected.SubItems[3].Text;

            MSG msg = new MSG();
            msg.Show();

            string query = $"update number7.msg set msg_checkreceive = '1' where msg_id='{msgid}'";

            using(MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }


        private void btn_Reload_Click(object sender, EventArgs e)
        {
            string query = $"select msg_id,msg_sender,msg_title,msg_contents,msg_checkreceive from number7.msg where msg_recipient='{LoginUserName}'";
            Load_msg(query);
        }

        private void labelSendview_Click(object sender, EventArgs e)
        {
            this.Hide();

            msgsendview msgsendview = new msgsendview();
            msgsendview.Show();
        }

        private void msgview_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new NormalForm()).Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
