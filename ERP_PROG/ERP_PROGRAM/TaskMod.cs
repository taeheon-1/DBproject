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
    public partial class TaskMod : Form
    {
        public TaskMod()
        {
            InitializeComponent();
        }

        string strConn = "server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8;";

        private string modTaskId;

        string select_bigcat = "";
        string select_midcat = "";
        string select_smallcat = "";

        private void LoadBigCat()
        {
            comboBoxTaskBigCat.Items.Clear();
            comboBoxTaskMidCat.Items.Clear();
            comboBoxTaskSmallCat.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"SELECT tmaster_bigcat FROM number7.tmaster GROUP BY tmaster_bigcat";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    comboBoxTaskBigCat.Items.Add(rdr["tmaster_bigcat"]);
                }
                rdr.Close();
                conn.Close();
            }
        }

        public string storeId
        {
            get { return this.modTaskId; }
            set { this.modTaskId = value; }
        }

        private void WorkMod_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"SELECT * FROM task WHERE task_id = '{modTaskId}'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    comboBoxTaskBigCat.Text = rdr["task_bigcat"].ToString();
                    comboBoxTaskMidCat.Text = rdr["task_midcat"].ToString();
                    comboBoxTaskSmallCat.Text = rdr["task_smallcat"].ToString();
                    textBoxTaskDetail.Text = rdr["task_detail"].ToString();
                    textBoxWorker.Text = rdr["task_worker"].ToString();
                    textBoxWrittenBy.Text = rdr["task_writtenby"].ToString();
                    dateTimePickerTaskStart.Value = Convert.ToDateTime(rdr["task_taskstart"] + "");
                    dateTimePickerTaskEnd.Value = Convert.ToDateTime(rdr["task_taskend"] + "");
                }
            }
            LoadBigCat();
        }

        private void buttonModTask_Click(object sender, EventArgs e)
        {
            int count = 0;            

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

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"select count(*) from number7.task where task_worker='{worker}' and task_taskstart < '{finishdt}' and task_taskend > '{startdt}'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    count = Convert.ToInt32(rdr["count(*)"] + "");
                }
                rdr.Close();

                if (count == 0)
                {
                    query = "insert into task(task_bigcat, task_midcat, task_smallcat, task_detail, task_taskstart, task_taskend, task_writtendate, task_writtenby, task_worker)" +
                        $"values ('{taskBigcat}','{taskMidcat}','{taskSmallcat}','{detail}','{startdt}','{finishdt}','{writtendt}','{writtenby}','{worker}') ";

                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("업무 등록 완료", "알림");
                }
                else
                {
                    MessageBox.Show("시간이 겹치는 업무가 존재합니다.", "알림");
                }
                conn.Close();

            }

        }

        private void comboBoxTaskBigCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_bigcat = comboBoxTaskBigCat.SelectedItem.ToString();
            comboBoxTaskMidCat.Items.Clear();
            comboBoxTaskSmallCat.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"SELECT tmaster_midcat FROM number7.tmaster WHERE tmaster_bigcat = '{select_bigcat}' GROUP BY tmaster_midcat";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    comboBoxTaskMidCat.Items.Add(rdr["tmaster_midcat"]);

                }
                rdr.Close();
                conn.Close();
            }

            comboBoxTaskBigCat.Text = select_midcat;
        }

        private void comboBoxTaskMidCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_midcat = comboBoxTaskMidCat.SelectedItem.ToString();
            comboBoxTaskSmallCat.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"SELECT tmaster_smallcat FROM number7.tmaster WHERE tmaster_bigcat = '{select_bigcat}' AND " +
                    $"tmaster_midcat = '{select_midcat}' GROUP BY tmaster_smallcat;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    comboBoxTaskSmallCat.Items.Add(rdr["tmaster_smallcat"]);

                }
                rdr.Close();
                conn.Close();
            }

            comboBoxTaskMidCat.Text = select_midcat;
        }

        private void comboBoxTaskSmallCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_smallcat = comboBoxTaskSmallCat.SelectedItem.ToString();
            comboBoxTaskSmallCat.Text = select_smallcat;
        }

        private void TaskMod_FormClosed(object sender, FormClosedEventArgs e)
        {
            TaskMain taskform = new TaskMain();
            taskform.Show();
            this.Close();
        }
    }
}
