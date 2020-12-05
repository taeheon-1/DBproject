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

        /*private void duplication_check(ComboBox combobox)
        {
            List<string> list = new List<string>();
            foreach (string s in combobox.Items)
            {
                if (!list.Contains(s)) list.Add(s);
            }
            combobox.Items.Clear();
            combobox.Items.AddRange(list.ToArray());
        }*/

        public string storeId
        {
            get { return this.modTaskId; }
            set { this.modTaskId = value; }
        }
        
        private void WorkMod_Load(object sender, EventArgs e)
        {
            
            /*using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string query = "select tmaster_bigcat, tmaster_midcat, tmaster_smallcat from tmaster";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string Taskbigcat = string.Format("{0}", rd["tmaster_bigcat"]);
                    string Taskmidcat = string.Format("{0}", rd["tmaster_midcat"]);
                    string Tasksmallcat = string.Format("{0}", rd["tmaster_smallcat"]);

                    comboBoxTaskBigCat.Items.Add(Taskbigcat);
                    comboBoxTaskMidCat.Items.Add(Taskmidcat);
                    comboBoxTaskSmallCat.Items.Add(Tasksmallcat);
                }
                rd.Close();

                // combobox 중복 데이터 삭제
                duplication_check(comboBoxTaskBigCat);
                duplication_check(comboBoxTaskMidCat);
                duplication_check(comboBoxTaskSmallCat);

            }*/
            

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

        private void listViewTaskMaster_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonModTask_Click(object sender, EventArgs e)
        {            
            string[] modData = { comboBoxTaskBigCat.Text, comboBoxTaskMidCat.Text, comboBoxTaskSmallCat.Text, textBoxTaskDetail.Text,
                textBoxWorker.Text, textBoxWrittenBy.Text, dateTimePickerTaskStart.Value.ToString("yyyy-MM-dd HH:mm"),
                dateTimePickerTaskEnd.Value.ToString("yyyy-MM-dd HH:mm") };
            

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"UPDATE task SET task_bigcat = '{modData[0]}', task_midcat = '{modData[1]}', task_smallcat = '{modData[2]}', " +
                    $"task_detail = '{modData[3]}', task_worker = '{modData[4]}', task_writtenby = '{modData[5]}', task_taskstart = '{modData[6]}', " +
                    $"task_taskend = '{modData[7]}' WHERE task_id = '{modTaskId}'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

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

                string query = $"SELECT tmaster_smallcat FROM number7.tmastermaster WHERE tmaster_bigcat = '{select_bigcat}' AND " +
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
    }
}
