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
    public partial class TaskregisteForm : Form
    {
        string strconn = "Server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8";

        public TaskregisteForm()
        {
            InitializeComponent();
        }

        private void TaskregisteForm_Load(object sender, EventArgs e)
        {
            Initdata();         // textbox, combobox 데이터 초기화
        }

        private void Initdata()
        {
            textBoxPerformer.Clear();
            textBoxwrittenby.Clear();
            textBoxTaskdetail.Clear();

            // 데이터 저장 전 combobox 초기화
            comboBoxTaskbigcat.Items.Clear();
            comboBoxTaskmidcat.Items.Clear();
            comboBoxTasksmallcat.Items.Clear();

            using(MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select tmaster_bigcat, tmaster_midcat, tmaster_smallcat from tmaster";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    string Taskbigcat = string.Format("{0}", rd["tmaster_bigcat"]);
                    string Taskmidcat = string.Format("{0}", rd["tmaster_midcat"]);
                    string Tasksmallcat = string.Format("{0}", rd["tmaster_smallcat"]);

                    comboBoxTaskbigcat.Items.Add(Taskbigcat);
                    comboBoxTaskmidcat.Items.Add(Taskmidcat);
                    comboBoxTasksmallcat.Items.Add(Tasksmallcat);
                }
                rd.Close();

                // combobox 중복 데이터 삭제
                duplication_check(comboBoxTaskbigcat);
                duplication_check(comboBoxTaskmidcat);
                duplication_check(comboBoxTasksmallcat);

            }
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
            if(comboBoxTaskbigcat.SelectedItem==null || comboBoxTaskmidcat.SelectedItem==null || comboBoxTasksmallcat==null)
            {
                MessageBox.Show("부서, 업무 유형, 업무를 모두 선택하세요.", "확인");
                return;
            }
            if(textBoxPerformer.Text=="" || textBoxwrittenby.Text=="")
            {
                MessageBox.Show("업무 수행자와 등록자 이름을 입력하세요.", "확인");
                return;
            }
            if(textBoxTaskdetail.Text =="")
            {
                MessageBox.Show("업무 상세 내용을 입력하세요.", "확인");
                return;
            }

            DateTime nowdt = DateTime.Now;

            string writtendt = nowdt.ToString("yyyy-MM-dd");
            string taskBigcat = comboBoxTaskbigcat.Text;
            string taskMidcat = comboBoxTaskmidcat.Text;
            string taskSmallcat = comboBoxTasksmallcat.Text;
            string startdt = dateTimePickerStart.Value.ToString("yyyy-MM-dd HH:mm");
            string finishdt = dateTimePickerFinish.Value.ToString("yyyy-MM-dd HH:mm");
            string performer = textBoxPerformer.Text;
            string writtenby = textBoxwrittenby.Text;
            string detail = textBoxTaskdetail.Text;

            using(MySqlConnection conn=new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "insert into task(task_bigcat, task_midcat, task_smallcat, task_detail, task_start, task_end, task_writtendate, task_writtenby, task_performer)" +
                    $"values ('{taskBigcat}','{taskMidcat}','{taskSmallcat}','{detail}','{startdt}','{finishdt}','{writtendt}','{writtenby}','{performer}')";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            Initdata();
        }
    }
}
