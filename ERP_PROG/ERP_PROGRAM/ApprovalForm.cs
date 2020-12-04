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
    public partial class ApprovalForm : Form
    {
        public ApprovalForm()
        {
            InitializeComponent();
        }

        private void ApprovalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NormalForm normal = new NormalForm();
            normal.Show();
        }

        private void button_personnel_Click(object sender, EventArgs e)
        {
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

    }
}
