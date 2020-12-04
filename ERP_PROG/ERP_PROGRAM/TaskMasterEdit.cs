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
    public partial class TaskMasterEdit : Form
    {
        public TaskMasterEdit()
        {
            InitializeComponent();
        }
        string select_bigcat = "";
        string select_midcat = "";
        string select_smallcat = "";

        string strConn = "server=49.50.174.201;Database=number7;Uid=number7;Pwd=number7;Charset=utf8;";

        private void LoadLargeCategory()
        {
            listBoxLargeCategory.Items.Clear();
            listBoxMediumCategory.Items.Clear();
            listBoxSmallCategory.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"SELECT tmaster_bigcat FROM number7.tmaster GROUP BY tmaster_bigcat";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxLargeCategory.Items.Add(rdr["tmaster_bigcat"]);
                }
                rdr.Close();
                conn.Close();
            }
        }

        private void WorkMasterEdit_Load(object sender, EventArgs e)
        {
            LoadLargeCategory();
        }

        private void listBoxLargeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_bigcat = listBoxLargeCategory.SelectedItem.ToString();
            listBoxMediumCategory.Items.Clear();
            listBoxSmallCategory.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"SELECT tmaster_midcat FROM number7.tmaster WHERE tmaster_bigcat = '{select_bigcat}' GROUP BY tmaster_midcat";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxMediumCategory.Items.Add(rdr["tmaster_midcat"]);

                }
                rdr.Close();
                conn.Close();
            }

            textBoxEditBigcat.Text = select_bigcat;
        }

        private void listBoxMediumCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_midcat = listBoxMediumCategory.SelectedItem.ToString();
            listBoxSmallCategory.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"SELECT tmaster_smallcat FROM number7.tmastermaster WHERE tmaster_bigcat = '{select_bigcat}' AND " +
                    $"tmaster_midcat = '{select_midcat}' GROUP BY tmaster_smallcat;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxSmallCategory.Items.Add(rdr["tmaster_smallcat"]);

                }
                rdr.Close();
                conn.Close();
            }

            textBoxEditMidcat.Text = select_midcat;
        }

        private void listBoxSmallCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_smallcat = listBoxSmallCategory.SelectedItem.ToString();
            textBoxEditSmallcat.Text = select_smallcat;
        }

        private void buttonMasterAdd_Click(object sender, EventArgs e)
        {
            string input_bigcat = textBoxEditBigcat.Text;
            string input_midcat = textBoxEditMidcat.Text;
            string input_smallcat = textBoxEditSmallcat.Text;

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"INSERT INTO tmaster(tmaster_bigcat, tmaster_midcat, tmaster_smallcat) VALUES ('{input_bigcat}', '{input_midcat}', '{input_smallcat}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            textBoxEditBigcat.Clear();
            textBoxEditMidcat.Clear();
            textBoxEditSmallcat.Clear();

            LoadLargeCategory();
        }

        private void buttonMasterDelete_Click(object sender, EventArgs e)
        {
            string delete_bigcat = textBoxEditBigcat.Text;
            string delete_midcat = textBoxEditMidcat.Text;
            string delete_smallcat = textBoxEditSmallcat.Text;

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = $"DELETE FROM tmaster WHERE tmaster_bigcat='{delete_bigcat}' AND tmaster_midcat='{delete_midcat}' AND tmaster_smallcat='{delete_smallcat}'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

            }
            textBoxEditBigcat.Clear();
            textBoxEditMidcat.Clear();
            textBoxEditSmallcat.Clear();

            LoadLargeCategory();
        }

        private void buttonInputMasterClear_Click(object sender, EventArgs e)
        {
            textBoxEditBigcat.Clear();
            textBoxEditMidcat.Clear();
            textBoxEditSmallcat.Clear();
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

        private void button_personnel_Click(object sender, EventArgs e)
        {
        }

        private void TaskMasterEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            TaskMain taskform = new TaskMain();
            taskform.Show();
            this.Close();
        }
    }
}
