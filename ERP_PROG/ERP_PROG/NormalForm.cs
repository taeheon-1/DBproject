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
            this.Hide();
            ApprovalForm approvalform = new ApprovalForm();
            approvalform.Show();
        }
    }
}
