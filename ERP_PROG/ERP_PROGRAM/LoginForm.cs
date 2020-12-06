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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string strConn = "server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8;";

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberIdCheckStatus)
            {
                textBoxID.Text = Properties.Settings.Default.LoginID;
                checkBoxRememberID.Checked = true;
            }

            if (Properties.Settings.Default.RememberPwCheckStatus)
            {
                textBoxPW.Text = Properties.Settings.Default.LoginPW;
                checkBoxRememberPW.Checked = true;
            }
        }

        private void AutoLoadID()
        {
            if (checkBoxRememberID.Checked)
            {
                Properties.Settings.Default.LoginID = textBoxID.Text;
            }
            else
            {
                Properties.Settings.Default.LoginID = null;
            }

            Properties.Settings.Default.RememberIdCheckStatus = checkBoxRememberID.Checked;
        }

        private void AutoLoadPW()
        {
            if (checkBoxRememberPW.Checked)
            {
                Properties.Settings.Default.LoginPW = textBoxPW.Text;
            }
            else
            {
                Properties.Settings.Default.LoginPW = null;
            }

            Properties.Settings.Default.RememberPwCheckStatus = checkBoxRememberPW.Checked;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            NormalForm normalForm = new NormalForm();

            // id와 pw에 정보를 저장
            string id = textBoxID.Text;
            string pw = textBoxPW.Text;

            // DB에서 정보를 읽은 뒤 그것을 저장 할 변수
            string loadId = "";
            string loadPw = "";
            string loadName = "";
            string loadRank = "";
            int msg_count = 0;

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                // DB에서 id와 동일한 회원의 정보를 받음.
                string query = $"SELECT * FROM number7.사원 WHERE employee_code = '{id}'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    loadId = rdr["employee_code"] + "";
                    loadPw = rdr["employee_password"] + "";
                    loadName = rdr["employee_name"] + "";
                    loadRank = rdr["employee_rank"] + "";
                }
                rdr.Close();

                // id와 pw가 공백이 아닌 경우 즉, 데이터를 입력했을 때
                if ((id != "" && pw != ""))
                {
                    // 입력한 id와 pw가 DB 정보와 일치할 때 (로그인 성공)
                    if ((id == loadId && pw == loadPw))
                    {
                        Properties.Settings.Default.Save();
                        // 현재 접속자의 이름과 관리자 유무를 메인화면으로 전송
                        normalForm.SetLogin(id, loadName, loadRank);

                        AutoLoadID();
                        AutoLoadPW();
                        Properties.Settings.Default.Save();

                        query = $"select count(*) from number7.msg where msg_recipient = '{loadName}' and msg_checkreceive = '0'";
                        rdr = DBManager.GetInstance().Select(query);
                        while (rdr.Read())
                        {
                            msg_count = Convert.ToInt32(rdr["count(*)"]);
                        }

                        if (msg_count != 0)
                        {
                            DialogResult result = MessageBox.Show("확인하지 않은 메시지가 " + msg_count + "건 있습니다. \r\n확인하시겠습니까?", "알림", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                this.Close();
                                msgview msgview = new msgview();
                                msgview.Show();
                            }
                        }
                        else
                        {
                            normalForm.Show();
                            this.Close();
                        }
                        

                    }

                    // 아이디 또는 비밀번호가 DB와 일치하지 않을 때
                    else
                        MessageBox.Show("아이디와 비밀번호를 확인하세요");
                }

                // id, pw가 공백인 경우
                else
                    MessageBox.Show("올바른 로그인 정보를 입력하세요");

            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
