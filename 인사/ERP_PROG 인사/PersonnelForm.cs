using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_PROG
{
    public partial class PersonnelForm : Form
    {
        public PersonnelForm()
        {
            InitializeComponent();
            groupBox2.Visible = false;
        }
        
        //출근부
        private void buttonadd_Click(object sender, EventArgs e) //출근부 등록
        {

            DateTime dt = dateTimePicker1.Value;
            string date = string.Format("{0}-{1}-{2}", dt.Year, dt.Month, dt.Day);


            string starttime = textBoxstartHour.Text + ":" + textBoxstartMinute.Text;
            string endtime = textBoxendHour.Text + ":" + textBoxendMinute.Text;

            if (string.IsNullOrEmpty(textBoxstartHour.Text) || string.IsNullOrEmpty(textBoxstartMinute.Text))
            {
                MessageBox.Show("출근시간을 정확히 입력해주세요", "입력필요");
                return;

            }
            if (string.IsNullOrEmpty(textBoxendHour.Text) || string.IsNullOrEmpty(textBoxendMinute.Text))
            {
                MessageBox.Show("퇴근시간을 정확히 입력해주세요", "입력필요");
                return;
            }
            
            
            string query = "INSERT INTO 출근부(날짜,출근시간,퇴근시간) VALUES('" + date + "', '" + starttime + "','" + endtime + "' )";
            ERP.GetInstance().Insert(query);

            textBoxstartHour.Text = "";
            textBoxstartMinute.Text = "";
            textBoxendHour.Text = "";
            textBoxendMinute.Text = "";
        }

        private void buttonread_Click(object sender, EventArgs e) //출근부 출력
        {
            string query = "SELECT 날짜,출근시간,퇴근시간 FROM 출근부";

            MySqlDataReader rdr = ERP.GetInstance().Select(query);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }
       
        //부서
        private void buttonDeptAdd_Click(object sender, EventArgs e) //부서 등록 버튼
        {
            groupBox2.Visible = true;

        }

        private void buttonDeptAdd_Click_1(object sender, EventArgs e) // 부서 등록
        {
            string Deptname = textBoxDeptName2.Text;
            string Depthead = textBoxDeptHead.Text;
            string Deptcode = textBoxDeptCode.Text;

            string query = "INSERT INTO 부서(부서코드,부서명,부서장) VALUES('" + Deptcode + "','" + Deptname + "', '" + Depthead + "')";
            ERP.GetInstance().Insert(query);

            textBoxDeptName2.Text = "";
            textBoxDeptHead.Text = "";
            textBoxDeptCode.Text = "";

            string query2 = "SELECT 부서코드,부서명,부서장 FROM 부서"; //부서등록 그리드뷰
            MySqlDataReader rdr = ERP.GetInstance().Select(query2);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }

        private void buttonDeptCancel_Click(object sender, EventArgs e) // 부서 취소
        {
            groupBox2.Visible = false;

        }


        //사원관리
        private void buttonStaffSearch_Click(object sender, EventArgs e)
        {
            string query = null;
            
            if (comboBoxStaffSearch.SelectedIndex == 0)
            {
                query = "Select * from 사원TEST";
            }
         

            MySqlDataReader rdr = ERP.GetInstance().Select(query);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }

    

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // 인사관리 그리드뷰 선택시 text뜨게
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBoxSTcode.Text = row.Cells["사원코드"].Value.ToString();
                textBoxSTname.Text = row.Cells["사원명"].Value.ToString();
                textBoxSTage.Text = row.Cells["나이"].Value.ToString();
                comboBox2.SelectedItem = row.Cells["직급"].Value.ToString();
            }
        }
    }
}
