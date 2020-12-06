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
    public partial class msgsendview : Form
    {

        string LoginUserName = NormalForm.LoginUserName;
        string strconn = "server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8;";

        public msgsendview()
        {
            InitializeComponent();
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
                        
                        if(rdr.GetString(4)=="False")
                        {
                            lvi.SubItems.Add("읽지 않음");
                        }
                        else if(rdr.GetString(4) == "True")
                        {
                            lvi.SubItems.Add("읽음");
                        }
                        else
                        {
                            lvi.SubItems.Add(" ");
                        }
                        
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

        private void msgsendview_Load(object sender, EventArgs e)
        {
            string query = $"select msg_id,msg_recipient,msg_title,msg_contents,msg_checkreceive from number7.msg where msg_sender='{LoginUserName}'";
            Load_msg(query);
        }

        private void listViewMsg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selected = listViewMsg.FocusedItem;

            string msgid = selected.SubItems[0].Text;
            MSG.msgtitle = selected.SubItems[2].Text;
            MSG.msgreceiver = selected.SubItems[1].Text;
            MSG.msgsender = LoginUserName;
            MSG.msgcontents = selected.SubItems[3].Text;

            MSG msg = new MSG();
            msg.Show();
        }

        private void labelReceiveview_Click(object sender, EventArgs e)
        {
            this.Hide();

            msgview msgview = new msgview();
            msgview.Show();
        }

        private void labelReceiveview_MouseDown(object sender, MouseEventArgs e)
        {
            //Cursor = Cursor.hand;
        }

        private void btn_Msgwrite_Click(object sender, EventArgs e)
        {
            msgWrite msgwrite = new msgWrite();
            msgwrite.Show();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            string query = $"select msg_id,msg_recipient,msg_title,msg_contents,msg_checkreceive from number7.msg where msg_sender='{LoginUserName}'";
            Load_msg(query);
        }

        private void msgsendview_FormClosed(object sender, FormClosedEventArgs e)
        {
            NormalForm normal = new NormalForm();
            normal.Show();
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
                        lvi.SubItems.Add(rdr.GetString(2));
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
        private void btn_Msgsearch_Click(object sender, EventArgs e) //받는사람 출력
        {
            string search_keyword = textBoxSearchtitlecontents.Text;
            string query = "";

            if (radiobutton_recipient.Checked == true)
            {
                query = $"SELECT * FROM number7.msg WHERE msg_recipient ='{LoginUserName}' && msg_recipient LIKE '%{search_keyword}%'";
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

            /*string msgrecipient = "";
            string query2 = "Select * from msg";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
            while (rdr.Read())
            {
                msgrecipient = rdr.GetString("msg_recipient");

                this.textBoxSearchreceiver.Text = msgrecipient;
            }

            rdr.Close();*/
        }
    }
}
