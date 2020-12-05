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

        private void button_approval_Click(object sender, EventArgs e)
        {
            ApprovalForm approvalform = new ApprovalForm();
            approvalform.Show();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PersonnelForm newForm = new PersonnelForm();
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TaskMain newForm = new TaskMain();
            newForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            msg newForm = new msg();
            newForm.Show();
        }
            
        private void button_message_Click(object sender, EventArgs e)
        {
            msg newForm = new msg();
            newForm.Show();
        }
    }
}
