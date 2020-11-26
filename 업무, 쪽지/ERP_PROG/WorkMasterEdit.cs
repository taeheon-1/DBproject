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
    public partial class WorkMasterEdit : Form
    {
        string strconn = "Server=49.50.174.201;Database=s5414208;Uid=s5414208;Pwd=s5414208;Charset=utf8";

        public WorkMasterEdit()
        {
            InitializeComponent();
            TaskMasterDataView();
        }

        private void InitlistBox()
        {
            listBoxTaskbigcat.Items.Clear();
            listBoxTaskmidcat.Items.Clear();
            listBoxTasksmallcat.Items.Clear();
        }
        private void TaskMasterDataView() 
        {
            InitlistBox();

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "SELECT tmaster_bigcat,tmaster_midcat,tmaster_smallcat FROM tmaster";

                MySqlCommand cmd = new MySqlCommand(query,conn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string Tmasterbigcat = string.Format("{0}",rd["tmaster_bigcat"]);
                    string Tmastermidcat = string.Format("{0}", rd["tmaster_midcat"]);
                    string Ttmastersmallcat = string.Format("{0}", rd["tmaster_smallcat"]);
                    
                    listBoxTaskbigcat.Items.Add(Tmasterbigcat);
                    listBoxTaskmidcat.Items.Add(Tmastermidcat);
                    listBoxTasksmallcat.Items.Add(Ttmastersmallcat);
                }
                rd.Close();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string Tmasterbigcat = textBoxTaskbigcat.Text;
            string Tmastermidcat = textBoxTaskmidcat.Text;
            string Tmastersmallcat = textBoxTasksmallcat.Text;

            if(Tmasterbigcat == "" || Tmastermidcat == "" || Tmastersmallcat == "")
            {
                MessageBox.Show("부서, 업무 유형, 업무를 모두 입력하세요.", "확인");
                return;
            }

            MessageBox.Show("부서 = " + Tmasterbigcat + " \n업무 유형 = " + Tmastermidcat + "\n업무 = " + Tmastersmallcat, "확인");

            // 해당 textbox값을 DB에 저장
            using(MySqlConnection conn=new MySqlConnection(strconn))
            {
                conn.Open();
                string query = $"insert into tmaster(tmaster_bigcat , tmaster_midcat , tmaster_smallcat) values ('{Tmasterbigcat}' , '{Tmastermidcat}' . '{Tmastersmallcat}')";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            // ListBox Load
            TaskMasterDataView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listBoxTaskbigcat.SelectedItem == null || listBoxTaskmidcat.SelectedItem == null || listBoxTasksmallcat.SelectedItem == null)
            {
                MessageBox.Show("부서, 업무 유형, 업무를 모두 입력하세요.", "확인");
                return;
            }

            string Tmasterbigcat = listBoxTaskbigcat.SelectedItem.ToString();
            string Tmastermidcat = listBoxTaskmidcat.SelectedItem.ToString();
            string Tmastersmallcat = listBoxTasksmallcat.SelectedItem.ToString();

            // 선택된 listbox값을 DB에서 삭제
            using(MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "delete from tmaster WHERE tmaster_bigcat='" + Tmasterbigcat + "',tmaster_midcat='" + Tmastermidcat + "',tmaster_smallcat='" + Tmastersmallcat + "'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            // Listbox Load
            TaskMasterDataView();
        }
    }
}