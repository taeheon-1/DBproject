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
    public partial class List_ApprovalForm : Form
    {
        public string Now_Approval_Person { get; set; }
        public string First_Approval_Person { get; set; }
        public string Second_Approval_Person { get; set; }
        public string Third_Approval_Person { get; set; }

        public List_ApprovalForm()
        {
            InitializeComponent();
        }

        private void button_NewApprovalForm_approve_Click(object sender, EventArgs e)
        {
            string approval_id = textBox_approval_id.Text;
            string query1 = "update 결재 set 진행사항 = '결재완료', 결재타입 = 4 where 결재id = '" + approval_id + "' and 결재자 = '기안자' and 결재자1 = '기안자'";

            
            string query2 = "update 결재 set 결재자 = '부서장', 결재타입 = 2 where 결재id = '" + approval_id + "' and 결재자 = '기안자' and 결재자1 = '기안자' and 결재자2 = '부서장'";

            DBManager.GetInstance().Update(query1);
            DBManager.GetInstance().Update(query2);
            MessageBox.Show(approval_id + "번 결재 되었습니다.", "확인");

            ApproveButtonClick_Form form = new ApproveButtonClick_Form();
            form.ShowDialog();
        }

        private void button_NewApprovalForm_return_Click(object sender, EventArgs e)
        {
            ReturnButtonClick_Form returnform = new ReturnButtonClick_Form();
            returnform.ShowDialog();
        }

        private void List_ApprovalForm_Load(object sender, EventArgs e)
        {
            if (LoginManager.GetInstance().TYPE == 1) // 일반사원
            {
                string query1 = "select 결재id, 제목, 관련업무, 내용 from 결재 where 결재자 = '기안자'";
                string query2 = "select 결재id, 제목, 관련업무, 내용 from 결재 where 결재자 = '기안자'";
                string query3 = "select 결재id, 제목, 관련업무, 내용 from 결재 where 진행사항 = '결재완료'";
                string query4 = "select 제목, 관련업무, 내용, 결재자, 진행사항 from 결재 where 진행사항 = '결재중' or 진행사항 = '반려'";

                DB_Load(query1, query2, query3, query4);
            }
            else if (LoginManager.GetInstance().TYPE == 2) // 부서장
            {
                string query1 = "select 결재id, 제목, 관련업무, 내용 from 결재 where 결재자 = '부서장'";
                string query2 = "select 결재id, 제목, 관련업무, 내용 from 결재 where 결재자 = '부서장'";
                string query3 = "select 결재id, 제목, 관련업무, 내용 from 결재 where 진행사항 = '결재완료'";
                string query4 = "select 제목, 관련업무, 내용, 결재자, 진행사항 from 결재 where 진행사항 = '결재중' or 진행사항 = '반려'";

                DB_Load(query1, query2, query3, query4);
            }
            else // 사장
            {
                string query1 = "select 결재id, 제목, 관련업무, 내용 from 결재 where 결재자 = '사장'";
                string query2 = "select 결재id, 제목, 관련업무, 내용 from 결재 where 결재자 = '사장'";
                string query3 = "select 결재id, 제목, 관련업무, 내용 from 결재 where 진행사항 = '결재완료'";
                string query4 = "select 제목, 관련업무, 내용, 결재자, 진행사항 from 결재 where 진행사항 = '결재중' or 진행사항 = '반려'";

                DB_Load(query1, query2, query3, query4);
            }
        }
        public void DB_Load(string query1, string query2, string query3, string query4)
        {
            MySqlDataReader rdr1 = DBManager.GetInstance().Select(query1);
            MySqlDataReader rdr2 = DBManager.GetInstance().Select(query2);
            MySqlDataReader rdr3 = DBManager.GetInstance().Select(query3);
            MySqlDataReader rdr4 = DBManager.GetInstance().Select(query4);

            DataTable dtable1 = new DataTable();
            dtable1.Load(rdr1);
            DataTable dtable2 = new DataTable();
            dtable2.Load(rdr2);
            DataTable dtable3 = new DataTable();
            dtable3.Load(rdr3);
            DataTable dtable4 = new DataTable();
            dtable4.Load(rdr4);

            dataGridView_approving.DataSource = dtable1; // 결재중
            dataGridView_approval_list.DataSource = dtable2; // 결재 업무 리스트
            dataGridView_approval_completion.DataSource = dtable3; // 결재완료
            dataGridView_approval_progress.DataSource = dtable4; // 결재 진행사항  
        }

        private void textBox_approval_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_approval_progress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_personnel_Click(object sender, EventArgs e)
        {
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
    }
}
