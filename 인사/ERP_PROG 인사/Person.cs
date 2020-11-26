using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_PROG
{
    class Person
    {

        private ComboBox how_;
        private TextBox what_;
        private DataGridView grid_;


        public Person(ComboBox how, TextBox what, DataGridView grid)
        {
            how_ = how; what_ = what; grid_ = grid;
        }

        public void ShowtoGrid()
        {
            string query = null;
            if (how_.Text == "") 
            {
                MessageBox.Show("검색조건을 선택하세요", "검색조건 필요");
                return;
            }
            if(what_.Text =="")
            {
                MessageBox.Show("검색조건을 입력하세요", "검색조건 필요");
                return;
            }
            
            switch (how_.SelectedIndex)
            {
                case 0:     //부서명
                    query = "SELECT * FROM 사원TEST WHERE employee_department = '" + this.what_.Text + "'"; 
                    break;
                case 1:     //사원명
                    query = "SELECT * FROM 사원TEST WHERE employee_name = '" + this.what_.Text + "'";
                    break;
                case 2:     //나이
                    query = "SELECT * FROM 사원TEST WHERE employee_age = '" + this.what_.Text + "'"; 
                    break;

            }

            MySqlDataReader rdr = ERPManager.GetInstance().Select(query); 
            DataTable dt = new DataTable(); 
            dt.Load(rdr);
            grid_.DataSource = dt; 
            rdr.Close();


        }
    }
    }
