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
        string LoginUserName = NormalForm.LoginUserName;

        public New_ApprovalForm()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            textBoxApprovalperson.Text = LoginUserName;
            textBox_task.Text = "";
            textBox_title.Text = "";
            textBox_text.Text = "";
            textBox_comment.Text = "";
            textBoxapprover1.Text = "";
            textBoxapprover2.Text = "";
            textBoxapprover3.Text = "";
        }

        private void button_register_Click(object sender, EventArgs e) // 신규 결재 등록
        {
            int compare = 0 ;
            string approver = "";
            var dic = new Dictionary<string, int>();
            dic.Add("일반 사원", 1);
            dic.Add("과장", 2);
            dic.Add("부서장", 3);
            dic.Add("사장", 4);

            if (textBoxapprover1.Text == "" && textBoxapprover2.Text == "")
            {
                MessageBox.Show("결재 라인을 적어주세요.");
                return;
            }
            else
            {
                if (textBoxapprover1.Text != "")
                {
                    compare = dic[textBoxapprover1.Text];
                    approver += textBoxapprover1.Text + " ";
                }

                if (textBoxapprover2.Text != "")
                {
                    if (dic[textBoxapprover2.Text] > compare)
                    {
                        approver += textBoxapprover2.Text + " ";
                    }
                    else
                    {
                        MessageBox.Show("결재 라인을 잘못 입력하였습니다. \r\n다시 입력해주세요.", "알림");
                        return;
                    }
                }

                if (textBoxapprover3.Text != "")
                {
                    if (dic[textBoxapprover3.Text] > compare)
                    {
                        approver += textBoxapprover3.Text + " ";
                    }
                    else
                    {
                        MessageBox.Show("결재 라인을 잘못 입력하였습니다. \r\n다시 입력해주세요.", "알림");
                        return;
                    }
                }
            }
            if(!approver.Contains("사장"))
            {
                MessageBox.Show("결재 라인을 잘못 입력하였습니다. \r\n다시 입력해주세요.", "알림");
                return;
            }

            if (textBox_title.Text == "" || textBox_task.Text == "" || textBox_text.Text == "" || textBox_comment.Text=="")
            {
                MessageBox.Show("제목, 업무, 내용, 참조를 적어주세요.");
                return;
            }
            else
            {
                string query = "insert into 결재(approval_title, approval_task, approval_contents, approval_person, approval_coment, approver, approval_progress, approval_type) values('" + textBox_title.Text + "', '" + textBox_task.Text + "', '" + textBox_text.Text + "' , '" + textBoxApprovalperson.Text + "', '" + textBox_comment.Text + "','"+approver+"', '결재중', 1)";
                DBManager.GetInstance().Insert(query);
                MessageBox.Show("등록 되었습니다.");
                init();
            }

            /*
            if(comboBox_approval_person.Text == "기안자") // 결재자가 기안자일 경우
            {
                string query = "insert into 결재(approval_title, approval_task, approval_contents, approval_person, approver, approval_coment, approval_progress, approval_type) values('" + textBox_title.Text + "', '" + comboBox_task.Text + "', '" + textBox_text.Text + "', '기안자', '" + comboBox_approval_person.Text + "', '" + textBox_comment.Text + "', '결재중', 1)";
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
            */
        }


        //
        // 메뉴바
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
