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
    public partial class ApprovalNormalForm : Form
    {
        public ApprovalNormalForm()
        {
            InitializeComponent();
        }

        private void button_approval_list_Click(object sender, EventArgs e)
        {
            List_ApprovalForm list_approvalform = new List_ApprovalForm();
            list_approvalform.ShowDialog();
        }

        private void button_new_approval_Click_1(object sender, EventArgs e)
        {
            New_ApprovalForm new_approvalform = new New_ApprovalForm();
            new_approvalform.ShowDialog();
        }

        private void ApprovalNormalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ApprovalForm normal = new ApprovalForm();
            normal.Show();
        }

        private void button_personnel_Click(object sender, EventArgs e)
        {
        }

        private void button_bussiness_Click(object sender, EventArgs e)
        {
        }

        private void button_approval_Click(object sender, EventArgs e)
        {
        }

        private void button_message_Click(object sender, EventArgs e)
        {
        }

    }
}
