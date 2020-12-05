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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_ID.Text == "1234" && textBox_PW.Text == "1234")
            {
                this.Hide();

                NormalForm newForm = new NormalForm();
                newForm.Show();

            }
            else
                MessageBox.Show("정확한 ID와 PW를 입력해주세요.");
        }

        private void checkBox_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ID.Checked == true)
            {
                textBox_ID.Text = "1234";
            }
            else
                textBox_ID.Text = "";
        }

        private void checkBox_PW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PW.Checked == true)
            {
                textBox_PW.Text = "1234";
            }
            else
                textBox_PW.Text = "";
        }
    }
}
