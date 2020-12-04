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
    public partial class NormalForm : Form
    {
        
        public NormalForm()
        {
            InitializeComponent();

        }
        string LoginUserID = "";
        public static string LoginUserName = "";

        public void SetLogin(string id, string name)
        {
            this.LoginUserID = id;
            LoginUserName = name;
        }

        private void NormalForm_Load(object sender, EventArgs e)
        {
            labelLoginUser.Text = $"{LoginUserName}님 로그인 되었습니다.";
        }



        private void button_business_Click(object sender, EventArgs e)
        {
            (new TaskMain()).Show();
            this.Visible = false;
        }

        private void button_personnel_Click(object sender, EventArgs e)
        {
            (new PersonnelForm()).Show();
            this.Visible = false;
        }

        private void button_message_Click(object sender, EventArgs e)
        {
            (new msgview()).Show();
            this.Visible = false;
        }

        private void button_approval_Click_1(object sender, EventArgs e)
        {
            (new ApprovalNormalForm()).Show();
            this.Visible = false;
        }

        private void NormalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
