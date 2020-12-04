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
    public partial class New_ApprovalForm : Form
    {
        public New_ApprovalForm()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            comboBox_approval_person.Items.Add("기안자");
            comboBox_approval_person.Items.Add("부서장");
            comboBox_approval_person.Items.Add("사장");

            comboBox_task.Items.Add("관련업무1");
            comboBox_task.Items.Add("관련업무2");
            comboBox_task.Items.Add("관련업무3");
        }

        private void button_register_Click(object sender, EventArgs e) // 신규 결재 등록
        {
            if(textBox_title.Text == "" || comboBox_task.SelectedIndex == -1 || textBox_text.Text == "" || comboBox_approval_person.SelectedIndex == -1 )
            {
                MessageBox.Show("제목, 업무, 내용, 결재자를 적어주세요.");
            }
            if(comboBox_approval_person.Text == "기안자") // 결재자가 기안자일 경우
            {
                string query = "insert into 결재(제목, 관련업무, 내용, 결재자, 결재자1, 코멘트, 진행사항, 결재타입) values('" + textBox_title.Text + "', '" + comboBox_task.Text + "', '" + textBox_text.Text + "', '기안자', '" + comboBox_approval_person.Text + "', '" + textBox_comment.Text + "', '결재중', 1)";
                DBManager.GetInstance().Insert(query);
                MessageBox.Show("결재가 등록 되었습니다.");
                Clear();
            }
            if (comboBox_approval_person.Text == "부서장") // 결재자가 부서장일 경우
            {
                string query = "insert into 결재(제목, 관련업무, 내용, 결재자, 결재자1, 결재자2, 코멘트, 진행사항, 결재타입) values('" + textBox_title.Text + "', '" + comboBox_task.Text + "', '" + textBox_text.Text + "', '기안자', '기안자', '" + comboBox_approval_person.Text + "', '" + textBox_comment.Text + "', '결재중', 1)";
                DBManager.GetInstance().Insert(query);
                MessageBox.Show("결재가 등록 되었습니다.");
                Clear();
            }

            else // 결재자가 사장일 경우
            {
                string query = "insert into 결재(제목, 관련업무, 내용, 결재자, 결재자1, 결재자2, 결재자3, 코멘트, 진행사항, 결재타입) values('" + textBox_title.Text + "', '" + comboBox_task.Text + "', '" + textBox_text.Text + "', '기안자', '기안자', '부서장', '" + comboBox_approval_person.Text + "', '" + textBox_comment.Text + "', '결재중', 1)";
                DBManager.GetInstance().Insert(query);
                MessageBox.Show("결재가 등록 되었습니다.");
                Clear();
            }
        }

        public void Clear()
        {
            textBox_title.Text = "";
            comboBox_task.SelectedIndex = -1;
            textBox_text.Text = "";
            comboBox_approval_person.SelectedIndex = -1;
            textBox_comment.Text = "";
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

        private void button_bussiness_Click(object sender, EventArgs e)
        {
        }
    }
}
