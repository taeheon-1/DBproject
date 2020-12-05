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
    public partial class msgWrite : Form
    {
        string LoginUser = NormalForm.LoginUserName;
        string strconn = "server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8;";

        public msgWrite()
        {
            InitializeComponent();
        }

        private void textBoxMsgcontents_Click(object sender, EventArgs e)
        {
            textBoxMsgcontents.Clear();
            this.textBoxMsgcontents.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void btn_Msgcancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Msgsend_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxMsgreceiver.Text))
            {
                MessageBox.Show("받는 사람을 입력하세요", "알림");
            }
            else if(string.IsNullOrWhiteSpace(textBoxMsgtitle.Text))
            {
                MessageBox.Show("제목을 입력하세요", "알림");
            }
            else if (string.IsNullOrWhiteSpace(textBoxMsgcontents.Text))
            {
                MessageBox.Show("내용을 입력하세요", "알림");
            }

            string msgreceiver = textBoxMsgreceiver.Text;
            string title = textBoxMsgtitle.Text;
            string contents = textBoxMsgcontents.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    conn.Open();

                    string query = $"insert into number7.msg(msg_sender, msg_recipient, msg_title, msg_contents, msg_checkreceive) " +
                        $"values('{LoginUser}','{msgreceiver}','{title}','{contents}','{0}')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception)
            {

            }

            this.Hide();
        }

        private void button_business_Click(object sender, EventArgs e)
        {
        }

        private void button_approval_Click(object sender, EventArgs e)
        {
        }

        private void button_message_Click(object sender, EventArgs e)
        {
        }

        private void button_personnel_Click(object sender, EventArgs e)
        {
        }
    }
}
