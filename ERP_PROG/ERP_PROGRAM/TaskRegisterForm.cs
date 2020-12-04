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
    public partial class TaskRegister : Form
    {
        string strconn = "Server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8";
        string select_bigcat = "";
        string select_midcat = "";
        string select_smallcat = "";

        public TaskRegister()
        {
            InitializeComponent();
        }

        private void TaskregisteForm_Load(object sender, EventArgs e)
        {
            Initdata();         // textbox, combobox 데이터 초기화
        }

        private void Initdata()
        {
            textBoxWorker.Clear();
            textBoxWrittenBy.Clear();
            textBoxTaskDetail.Clear();

            comboBoxTaskBigCat.Items.Clear();
            comboBoxTaskMidCat.Items.Clear();
            comboBoxTaskSmallCat.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = $"SELECT tmaster_bigcat FROM number7.tmaster  GROUP BY tmaster_bigcat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    comboBoxTaskBigCat.Items.Add(rd["tmaster_bigcat"]);
                }
                rd.Close();
                conn.Close();
            }
        }

        private void comboBoxTaskbigcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_bigcat = comboBoxTaskBigCat.SelectedItem.ToString();

            comboBoxTaskMidCat.Items.Clear();
            comboBoxTaskSmallCat.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = $"SELECT tmaster_midcat FROM tmaster WHERE tmaster_bigcat = '{select_bigcat}' GROUP BY tmaster_midcat";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    comboBoxTaskMidCat.Items.Add(rd["tmaster_midcat"]);
                }
                rd.Close();
                conn.Close();
            }
        }
        private void comboBoxTaskmidcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_midcat = comboBoxTaskMidCat.SelectedItem.ToString();
            comboBoxTaskSmallCat.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();

                string query = $"SELECT tmaster_smallcat FROM tmaster WHERE tmaster_bigcat = '{select_bigcat}' AND " +
                    $"tmaster_midcat = '{select_midcat}' GROUP BY tmaster_smallcat;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    comboBoxTaskSmallCat.Items.Add(rd["tmaster_smallcat"]);
                }
                rd.Close();
                conn.Close();
            }
        }

        private void comboBoxTasksmallcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_smallcat = comboBoxTaskSmallCat.SelectedItem.ToString();

        }
        private void duplication_check(ComboBox combobox)
        {
            List<string> list = new List<string>();

            foreach (string s in combobox.Items)
            {
                if (!list.Contains(s)) list.Add(s);
            }
            combobox.Items.Clear();
            combobox.Items.AddRange(list.ToArray());
        }

        // 일일 등록 버튼 클릭
        private void btn_Taskregister_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (comboBoxTaskBigCat.SelectedItem == null || comboBoxTaskMidCat.SelectedItem == null || comboBoxTaskSmallCat == null)
            {
                MessageBox.Show("부서, 업무 유형, 업무를 모두 선택하세요.", "확인");
                return;
            }
            if (textBoxWorker.Text == "" || textBoxWrittenBy.Text == "")
            {
                MessageBox.Show("업무 수행자와 등록자 이름을 입력하세요.", "확인");
                return;
            }
            if (textBoxTaskDetail.Text == "")
            {
                MessageBox.Show("업무 상세 내용을 입력하세요.", "확인");
                return;
            }
            //시간 중복 오류 msg
            //if()

            DateTime nowdt = DateTime.Now;

            string writtendt = nowdt.ToString("yyyy-MM-dd");
            string taskBigcat = comboBoxTaskBigCat.Text;
            string taskMidcat = comboBoxTaskMidCat.Text;
            string taskSmallcat = comboBoxTaskSmallCat.Text;
            string startdt = dateTimePickerTaskStart.Value.ToString("yyyy-MM-dd HH:mm");
            string finishdt = dateTimePickerTaskEnd.Value.ToString("yyyy-MM-dd HH:mm");
            string worker = textBoxWorker.Text;
            string writtenby = textBoxWrittenBy.Text;
            string detail = textBoxTaskDetail.Text;

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();

                string query = $"SELECT count(task_id) FROM task WHERE task_taskstart >= '{startdt}' AND task_taskend <= '{finishdt}'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    count = Convert.ToInt32(rdr["count(task_id)"] + "");
                }
                rdr.Close();

                if (count != 0)
                    MessageBox.Show("이미 해당 시간에 업무가 존재합니다.");

                else
                {
                    query = "insert into task(task_bigcat, task_midcat, task_smallcat, task_detail, task_taskstart, task_taskend, task_writtendate, task_writtenby, task_worker)" +
                        $"values ('{taskBigcat}','{taskMidcat}','{taskSmallcat}','{detail}','{startdt}','{finishdt}','{writtendt}','{writtenby}','{worker}')";

                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }
            Initdata();
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

        private void TaskRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            TaskMain taskform = new TaskMain();
            taskform.Show();
            this.Close();
        }
    }
}
