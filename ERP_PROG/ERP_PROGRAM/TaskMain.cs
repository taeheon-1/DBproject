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
    public partial class TaskMain : Form
    {
        public TaskMain()
        {
            InitializeComponent();
        }

        string LoginUserName = NormalForm.LoginUserName;

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
                        lvi.SubItems.Add(rdr.GetString(2));
                        lvi.SubItems.Add(rdr.GetString(3));
                        lvi.SubItems.Add(rdr.GetString(4));
                        lvi.SubItems.Add(rdr.GetString(5));
                        lvi.SubItems.Add(rdr.GetString(6));
                        lvi.SubItems.Add(rdr.GetString(7));
                        lvi.SubItems.Add(rdr.GetString(8));
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

        private void WorkMain_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM number7.task WHERE task_worker = '{LoginUserName}'";

            LoadTasks(listViewWorkDisplay, query);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM number7.task WHERE task_worker = '{LoginUserName}'";

            LoadTasks(listViewWorkDisplay, query);
        }

        private void buttonGoMasterEdit_Click(object sender, EventArgs e)
        {
            TaskMasterEdit WorkMasterEdit = new TaskMasterEdit();
            WorkMasterEdit.ShowDialog();

        }

        private void buttonTaskSearch_Click(object sender, EventArgs e)
        {
            string search_keyword = textBoxTaskSearch.Text;
            string query = "";

            if (radioButtonSearchOptionWrittenDate.Checked == true)
            {
                query = $"SELECT * FROM number7.task WHERE task_worker = '{LoginUserName}' AND task_writtendate = '{search_keyword}'";
            }

            if (radioButtonSearchOptionTask.Checked == true)
            {
                query = $"SELECT * FROM number7.task WHERE task_worker = '{LoginUserName}' AND task_smallcat = '{search_keyword}'";
            }

            if (radioButtonSearchOptionWrittenBy.Checked == true)
            {
                query = $"SELECT * FROM number7.task WHERE task_worker = '{LoginUserName}' AND task_writtenby = '{search_keyword}'";
            }

            LoadTasks(listViewWorkDisplay, query);


        }

        private void buttonGoTaskMod_Click(object sender, EventArgs e)
        {
            TaskMod TaskMod = new TaskMod();
            int SelectRow = listViewWorkDisplay.SelectedItems[0].Index;
            TaskMod.storeId = listViewWorkDisplay.Items[SelectRow].SubItems[0].Text;
            TaskMod.ShowDialog();
        }

        private void buttonTaskDelete_Click(object sender, EventArgs e)
        {
            int SelectRow = listViewWorkDisplay.SelectedItems[0].Index;
            string deleteTaskId = listViewWorkDisplay.Items[SelectRow].SubItems[0].Text;

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"DELETE FROM task WHERE task_id = '{deleteTaskId}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            string load_query = $"SELECT * FROM number7.task WHERE task_worker = '{LoginUserName}'";

            LoadTasks(listViewWorkDisplay, load_query);
        }

        private void buttonGoTaskAdd_Click(object sender, EventArgs e)
        {
            TaskRegister TaskRegister = new TaskRegister();
            TaskRegister.ShowDialog();
        }

        private void TaskMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            NormalForm normal = new NormalForm();
            normal.Show();
        }

        private void button_business_Click(object sender, EventArgs e)
        {
            
        }

        private void button_approval_Click(object sender, EventArgs e)
        {
            ApprovalForm approvalForm = new ApprovalForm();
            approvalForm.Show();
            this.Close();
        }

        private void button_message_Click(object sender, EventArgs e)
        {
            msgview msgview = new msgview();
            msgview.Show();
            this.Close();
        }

        private void button_personnel_Click(object sender, EventArgs e)
        {
        }
    }
}
