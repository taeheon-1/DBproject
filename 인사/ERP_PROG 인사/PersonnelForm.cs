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
            dataGridViewDepartment.Visible = false;
        }
        public void InitValue() //기본정보탭 값 초기화 함수
        {
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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //탭 이동 선택시
        {
            dataGridView1.DataSource = null;
            dataGridViewDepartment.DataSource = null;
            if (tabControl1.SelectedTab.Text == "인사관리")
            {
                InitValue();
            }
            if (tabControl1.SelectedTab.Text == "부서관리")
            {
                dataGridViewDepartment.Visible = true;
            }
        }

       
        private void buttonadd_Click(object sender, EventArgs e) //출근부 등록
        {
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
            
            
            string query = "INSERT INTO 출근부(날짜,출근시간,퇴근시간) VALUES('" + date + "', '" + starttime + "','" + endtime + "' )";
            ERPManager.GetInstance().Insert(query);

            StartHour.Text = "";
            StartMinute.Text = "";
            EndHour.Text = "";
            EndMinute.Text = "";
        }

        private void buttonread_Click(object sender, EventArgs e) //출근부 출력
        {
            string query = "SELECT 날짜,출근시간,퇴근시간 FROM 출근부";

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

        private void DepartmentSerach_Click(object sender, EventArgs e) //부서검색
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
            
            string Deptcode = DepartmentCode.Text;
            string Deptname = DepartmentName.Text;
            string Depthead = DepartmentHead.Text;

            if (Deptcode == "")
            {
                MessageBox.Show("부서코드를 입력하세요", "입력필요");
                return;
            }
            if (Deptname == "")
            {
                MessageBox.Show("부서이름을 입력하세요", "입력필요");
                return;
            }
            if (Depthead == "")
            {
                MessageBox.Show("부서장을 입력하세요", "입력필요");
                return;
            }
            
            if(Deptcode !="" || Deptname!="" || Depthead != "")
            {
                string query1 = "INSERT INTO 부서(부서코드,부서명,부서장) VALUES('" + Deptcode + "','" + Deptname + "', '" + Depthead + "')";
                ERPManager.GetInstance().Insert(query1);

                DepartmentName.Text = "";
                DepartmentHead.Text = "";
                DepartmentCode.Text = "";

                string query2 = "SELECT 부서코드,부서명,부서장 FROM 부서"; //부서등록 그리드뷰
                MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridViewDepartment.DataSource = dt;
                rdr.Close();

                EmployeeDepartment.Items.Add(Deptname);
            }
           
            
        }

        private void DepartmentUpdate_Click(object sender, EventArgs e) //부서수정
        {
            string query = "UPDATE 부서 SET 부서코드 = '" + DepartmentCode.Text + "', 부서장 = '" + DepartmentHead.Text + "'," +
                 "부서명 = '" + DepartmentName.Text + "' WHERE id = '" + this.DepartmentID.Text + "'";
            ERPManager.GetInstance().Update(query);
            
            EmployeeDepartment.SelectedIndex = EmployeeDepartment.FindString("DepartmentName.Text");

            string query2 = "Select * from 부서";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridViewDepartment.DataSource = dt;
            rdr.Close();
            
        }

        private void DepartmentDelete_Click(object sender, EventArgs e) //부서삭제
        {
            
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
            EmployeeDepartment.Items.Remove("DepartmentName.Text");
        }

        private void buttonDeptCancel_Click(object sender, EventArgs e) // 부서 취소
        {
            DepartmentName.Text = "";
            DepartmentHead.Text = "";
            DepartmentCode.Text = "";
            dataGridViewDepartment.DataSource = null;
        }


        
        //사원관리
        private void buttonStaffSearch_Click(object sender, EventArgs e) //ㅇ사원검색
        {
            Per = new Person(EmployeeSearchComboBox, EmployeeSearchTextBox, dataGridView1);
            Per.ShowtoGrid();
            
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // 인사관리 그리드뷰 선택시 text뜨게
        {
         
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                EmployeeID.Text = row.Cells[0].Value.ToString();
                EmployeeCode.Text = row.Cells[1].Value.ToString();
                EmployeeName.Text = row.Cells[3].Value.ToString();
                EmployeeRank.SelectedItem = row.Cells[5].Value.ToString();
                EmployeeDepartment.SelectedItem = row.Cells[7].Value.ToString();
                EmployeeAge.Text = row.Cells[2].Value.ToString();
                EmployeeAddress.Text = row.Cells[4].Value.ToString();
                EmployeeDetailedAddress.Text = row.Cells[6].Value.ToString();
                
            }
        }

        private void EmployeeUpdate_Click(object sender, EventArgs e) //사원관리 수정 
        {
            string query = "UPDATE 사원TEST SET employee_code = '" + EmployeeCode.Text + "', employee_name = '" + EmployeeName.Text + "'," +
                "employee_rank = '" + EmployeeRank.SelectedItem + "',employee_department = '" + EmployeeDepartment.SelectedItem + "', " +
                "employee_age = '" + EmployeeAge.Text + "', employee_address = '" + EmployeeAddress.Text + "'," +
                "employee_detailed_address = '" + EmployeeDetailedAddress.Text + "' where employee_id = '" + this.EmployeeID.Text + "'"; 
            ERPManager.GetInstance().Update(query);

            string query2 = "Select * from 사원TEST where employee_code = '" + this.EmployeeCode.Text + "'";
            MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }

        private void EmployeeDelete_Click(object sender, EventArgs e) //사원관리 삭제
        {
            
            string query = "DELETE FROM 사원TEST WHERE employee_code = '" + EmployeeCode.Text + "'";
            ERPManager.GetInstance().Delete(query);
            InitValue(); //초기화
            MessageBox.Show("사원코드:" + EmployeeCode.Text + " 정보가 삭제되었습니다.","삭제완료");
      
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
    }
}
