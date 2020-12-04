using MySql.Data.MySqlClient;
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
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
        }

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM 수당";

            MySqlDataReader rdr = DetailedStatement.GetInstance().Select(query);
            DataTable dt = new DataTable();

            dt.Load(rdr);
            dataGridView1.DataSource = dt;

            rdr.Close();
        }

        private void buttonInpit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO 수당(연장근로, 야간근로, 휴일근로) VALUES('" + this.ExtendedWork.Text + "', '" + this.NightWork.Text + "', '" + this.HolidayWork.Text + "')";

            DetailedStatement.GetInstance().Insert(query);

            string query2 = "SELECT * FROM 수당";

            MySqlDataReader rdr = DetailedStatement.GetInstance().Select(query2);
            DataTable dt = new DataTable();

            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            string query = "UPDATE 수당 SET 연장근로 = '" + ExtendedWork.Text + "', 야간근로 = '" + NightWork.Text + "', 휴일근로 = '" + HolidayWork.Text + "' WHERE id = '" + this.WorkID.Text + "'";

            DetailedStatement.GetInstance().Update(query);

            string query2 = "SELECT * FROM 수당 WHERE id = '" + this.WorkID.Text + "'";

            MySqlDataReader rdr = ERPManager.GetInstance().Select(query2);
            DataTable dt = new DataTable();

            dt.Load(rdr);
            dataGridView1.DataSource = dt;
            rdr.Close();
        }
    }
}
