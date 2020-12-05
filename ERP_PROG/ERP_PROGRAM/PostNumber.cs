using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ERP_PROG
{
    public partial class PostNumber : Form
    {
        string currentPage = "1";  //현재 페이지
        string countPerPage = "1000"; //1페이지당 출력 갯수
        string confmKey = "devU01TX0FVVEgyMDIwMTExNDAwMTQyOTExMDQxMzk="; //테스트 Key
        string keyword = "";
        string apiurl = string.Empty;
        string postnumber = "";

        public PostNumber()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void PostNumberInsert()
        {
            string query = "INSERT INTO postnumber(address_value,postnumber_search) " +
                    "values ('"+keyword+"','"+postnumber+"')";
            ERPManager.GetInstance().Insert(query);
        }
        private void PostNumberSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                keyword = textBox1.Text;
                apiurl = "http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage=" + currentPage + "&countPerPage=" + countPerPage + "&keyword=" + keyword + "&confmKey=" + confmKey;

                textBox2.Text = apiurl + "\r\n";

                WebClient wc = new WebClient();

                XmlReader read = new XmlTextReader(wc.OpenRead(apiurl));

                DataSet ds = new DataSet();
                ds.ReadXml(read);

                dataGridView2.DataSource = ds.Tables[0];

                DataRow[] rows = ds.Tables[0].Select();

                textBox2.Text += rows[0]["totalCount"].ToString();

                if (rows[0]["totalCount"].ToString() != "0")
                {
                    dataGridView1.DataSource = ds.Tables[1];
                }
                postnumber = (string)dataGridView1.Rows[0].Cells[5].Value;
                MessageBox.Show("우편번호 : " + postnumber);
            }
            catch (Exception ex)
            {
            }
            PostNumberInsert();
        }

    }
}
