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
        private Person Per;
        public PersonnelForm()
        {
            InitializeComponent();
            InitValue();
            lnitCombo();
            dataGridViewDepartment.Visible = false;
        }
        public void InitValue() //기본정보탭 값 초기화 함수
        {
            EmployeeSearchComboBox.Text = "";
            EmployeeSearchTextBox.Text = "";
            EmployeeCode.Text = "";
            EmployeeAge.Text = "";
            EmployeeName.Text = "";
            EmployeeAddress.Text = "";
            EmployeeDetailedAddress.Text = "";
            EmployeeRank.Text = "";
            EmployeeDepartment.Text = "";
            dataGridView1.DataSource = null;
        }

        public void lnitCombo() //기본정보탭 부서명 콤보박스
        {
            EmployeeDepartment.Items.Clear();
            string query = "SELECT 부서명 FROM 부서";
            ERPManager.GetInstance().Insert(query);
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query);

            while (rdr.Read())
            {
                EmployeeDepartment.Items.Add(rdr.GetString(0));
            }
            rdr.Close();

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //탭 이동 선택시
        {
            dataGridView1.DataSource = null;
            dataGridViewDepartment.DataSource = null;

            if (tabControl1.SelectedTab.Text == "기본정보")
            {
                InitValue();
                lnitCombo();

            }

            if (tabControl1.SelectedTab.Text == "부서관리")
            {
                dataGridViewDepartment.Visible = true;
                DepartmentName.Text = "";
                DepartmentHead.Text = "";
                DepartmentCode.Text = "";
            }
        }



        string LoginUserID = "";
        public void SetLogin(string id)
        {
            this.LoginUserID = id;
        }

        private void buttonadd_Click(object sender, EventArgs e) //출근부 등록
        {
            /*label23.Text = $"{LoginUserID}님 로그인 되었습니다.";*/

            DateTime dt = dateTimePicker1.Value;
            string date = string.Format("{0}-{1}-{2}", dt.Year, dt.Month, dt.Day);


            string starttime = StartHour.Text + ":" + StartMinute.Text;
            string endtime = EndHour.Text + ":" + EndMinute.Text;

            if (string.IsNullOrEmpty(StartHour.Text) || string.IsNullOrEmpty(StartMinute.Text))
            {
                MessageBox.Show("출근시간을 정확히 입력해주세요", "입력필요");
                return;

            }
            if (string.IsNullOrEmpty(EndHour.Text) || string.IsNullOrEmpty(EndMinute.Text))
            {
                MessageBox.Show("퇴근시간을 정확히 입력해주세요", "입력필요");
                return;
            }
            
            string query = "INSERT INTO 출근부(사원코드,날짜,출근시간,퇴근시간) VALUES('"+label23.Text+"','" + date + "', '" + starttime + "','" + endtime + "' )" ;
            ERPManager.GetInstance().Insert(query);

            StartHour.Text = "";
            StartMinute.Text = "";
            EndHour.Text = "";
            EndMinute.Text = "";
        }

        private void buttonread_Click(object sender, EventArgs e) //출근부 출력
        {
            string query = "SELECT 날짜,출근시간,퇴근시간 FROM 출근부 WHERE 사원코드= '" + label23.Text + "'";

            MySqlDataReader rdr = ERPManager.GetInstance().Select(query);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }

        //부서 
        private void dataGridViewDepartment_CellClick(object sender, DataGridViewCellEventArgs e) //부서 그리드 뷰
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewDepartment.Rows[e.RowIndex];

                DepartmentID.Text = row.Cells[0].Value.ToString();
                DepartmentCode.Text = row.Cells[1].Value.ToString();
                DepartmentName.Text = row.Cells[2].Value.ToString();
                DepartmentHead.Text = row.Cells[3].Value.ToString();
            }
        }

        private void DepartmentSerach_Click(object sender, EventArgs e) //부서확인
        {

            string query = "SELECT * FROM 부서";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridViewDepartment.DataSource = dt;
            rdr.Close();

        }

        private void DepartmentInsert_Click(object sender, EventArgs e) //부서 등록
        {

            if (DepartmentCode.Text == "")
            {
                MessageBox.Show("부서코드를 입력하세요", "입력필요");
                return;
            }
            if (DepartmentName.Text == "")
            {
                MessageBox.Show("부서이름을 입력하세요", "입력필요");
                return;
            }
            if (DepartmentHead.Text == "")
            {
                MessageBox.Show("부서장을 입력하세요", "입력필요");
                return;
            }

            if (DepartmentCode.Text != "" || DepartmentName.Text != "" || DepartmentHead.Text != "")
            {
                string q1 = "select * from 부서 where 부서명 = '" + DepartmentName.Text + "'";
                MySqlDataReader rr = ERPManager.GetInstance().Select(q1);
                while (rr.Read())
                {
                    MessageBox.Show("동일한 부서명이 존재합니다.");
                    rr.Close();
                    DepartmentName.Text = "";
                    DepartmentHead.Text = "";
                    DepartmentCode.Text = "";
                    return;
                }

                string q2 = "INSERT INTO 부서(부서코드,부서명,부서장) VALUES('" + DepartmentCode.Text + "','" + DepartmentName.Text + "'" +
                    ", '" + DepartmentHead.Text + "')";
                ERPManager.GetInstance().Insert(q2);
                MessageBox.Show("부서가 등록되었습니다.");
                DepartmentName.Text = "";
                DepartmentHead.Text = "";
                DepartmentCode.Text = "";

                //부서등록 그리드뷰
                string q3 = "SELECT * FROM 부서";
                MySqlDataReader rdr = ERPManager.GetInstance().Select(q3);
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridViewDepartment.DataSource = dt;
                rdr.Close();
                rr.Close();
            }

        }

        private void DepartmentUpdate_Click(object sender, EventArgs e) //부서수정
        {
            string q1 = "select * from 부서 where 부서명 = '" + DepartmentName.Text + "'";
            MySqlDataReader rr = ERPManager.GetInstance().Select(q1);
            while (rr.Read())
            {
                MessageBox.Show("동일한 부서명이 존재합니다.");
                rr.Close();
                DepartmentName.Text = "";
                DepartmentHead.Text = "";
                DepartmentCode.Text = "";
                return;
            }

            string q2 = "UPDATE 부서 SET 부서코드 = '" + DepartmentCode.Text + "', 부서장 = '" + DepartmentHead.Text + "'," +
                 "부서명 = '" + DepartmentName.Text + "' WHERE id = '" + this.DepartmentID.Text + "'";
            ERPManager.GetInstance().Update(q2);
            EmployeeDepartment.SelectedIndex = EmployeeDepartment.FindString("DepartmentName.Text");
            MessageBox.Show("부서가 수정 되었습니다.");

            string q3 = "Select * from 부서";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(q3);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridViewDepartment.DataSource = dt;
            rdr.Close();

            DepartmentHead.Text = "";
            DepartmentName.Text = "";
            DepartmentCode.Text = "";

        }

        private void DepartmentDelete_Click(object sender, EventArgs e) //부서삭제
        {
            DialogResult result = MessageBox.Show("정말로 부서를 삭제하겠습니까?", "부서삭제", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string query = "DELETE FROM 부서 WHERE id ='" + this.DepartmentID.Text + "'";
                ERPManager.GetInstance().Delete(query);
                MessageBox.Show("" + DepartmentName.Text + "가 삭제되었습니다.", "삭제완료");

                string query2 = "Select * from 부서";
                MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridViewDepartment.DataSource = dt;
                rdr.Close();

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("삭제를 취소합니다.", "삭제취소");
            }

            DepartmentHead.Text = "";
            DepartmentName.Text = "";
            DepartmentCode.Text = "";

            /*
            
            string query = "DELETE FROM 부서 WHERE id ='" + this.DepartmentID.Text + "'";
            ERPManager.GetInstance().Delete(query);

            MessageBox.Show("" + DepartmentName.Text + "가 삭제되었습니다.", "삭제완료");
            DepartmentHead.Text = "";
            DepartmentName.Text = "";
            DepartmentCode.Text = "";

            string query2 = "Select * from 부서";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridViewDepartment.DataSource = dt;
            rdr.Close();
            */

        }

        private void buttonDeptCancel_Click(object sender, EventArgs e) // 부서 취소
        {
            DepartmentName.Text = "";
            DepartmentHead.Text = "";
            DepartmentCode.Text = "";
            dataGridViewDepartment.DataSource = null;
        }

        //사원관리
        private void buttonStaffSearch_Click(object sender, EventArgs e) //사원검색
        {
            Per = new Person(EmployeeSearchComboBox, EmployeeSearchTextBox, dataGridView1);
            Per.ShowtoGrid();
        }
        private void EmployeeClear_Click(object sender, EventArgs e) //사원취소
        {
            InitValue();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // 인사관리 그리드뷰 선택시 text뜨게
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                EmployeeID.Text = row.Cells[0].Value.ToString();
                EmployeeCode.Text = row.Cells[1].Value.ToString();
                EmployeeAge.Text = row.Cells[2].Value.ToString();
                EmployeeName.Text = row.Cells[3].Value.ToString();
                EmployeeAddress.Text = row.Cells[4].Value.ToString();
                EmployeeRank.SelectedItem = row.Cells[5].Value.ToString();
                EmployeeDetailedAddress.Text = row.Cells[6].Value.ToString();
                EmployeeDepartment.SelectedItem = row.Cells[7].Value.ToString();
            }
        }

        private void EmployeeUpdate_Click(object sender, EventArgs e) //사원관리 수정 
        {
            string query = "UPDATE 사원TEST SET employee_code = '" + EmployeeCode.Text + "', employee_name = '" + EmployeeName.Text + "'," +
                "employee_rank = '" + EmployeeRank.SelectedItem + "',employee_department = '" + EmployeeDepartment.SelectedItem + "', " +
                "employee_age = '" + EmployeeAge.Text + "', employee_address = '" + EmployeeAddress.Text + "'," +
                "employee_detailed_address = '" + EmployeeDetailedAddress.Text + "' where employee_id = '" + this.EmployeeID.Text + "'";
            ERPManager.GetInstance().Update(query);

            MessageBox.Show("수정완료");

            string query2 = "Select * from 사원TEST where employee_code = '" + this.EmployeeCode.Text + "'";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }

        private void EmployeeDelete_Click(object sender, EventArgs e) //사원관리 삭제
        {

            DialogResult result = MessageBox.Show("정말로 사원을 삭제하겠습니까?", "사원삭제", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string query = "DELETE FROM 사원TEST WHERE employee_code = '" + EmployeeCode.Text + "'";
                ERPManager.GetInstance().Delete(query);
                MessageBox.Show("사원코드-" + EmployeeCode.Text + "이 삭제되었습니다.", "삭제완료");

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("삭제를 취소합니다.", "삭제취소");
            }
            InitValue(); //초기화
            /*
            string query = "DELETE FROM 사원TEST WHERE employee_code = '" + EmployeeCode.Text + "'";
            ERPManager.GetInstance().Delete(query);
            InitValue(); //초기화
            MessageBox.Show("사원코드:" + EmployeeCode.Text + " 정보가 삭제되었습니다.","삭제완료");
      */

        }

        private void EmployeeInsert_Click(object sender, EventArgs e) //사원 등록
        {
            string query = "INSERT INTO 사원TEST(employee_code, employee_age, employee_name, employee_address, employee_rank, employee_detailed_address, employee_department) " +
                "values ('" + this.EmployeeCode.Text + "', '" + this.EmployeeAge.Text + "','"
                + this.EmployeeName.Text + "','" + this.EmployeeAddress.Text + "','" + this.EmployeeRank.Text + "'" +
                ",'" + this.EmployeeDetailedAddress.Text + "','" + this.EmployeeDepartment.Text + "')";
            ERPManager.GetInstance().Insert(query);
            InitValue();

            string query2 = "SELECT * FROM 사원TEST";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }

        private void PersonnelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new NormalForm()).Visible = true;
        }
    }
}
