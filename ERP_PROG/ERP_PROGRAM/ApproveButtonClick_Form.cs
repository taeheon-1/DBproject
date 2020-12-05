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
    public partial class ApproveButtonClick_Form : Form
    {
        List_ApprovalForm approvalform = new List_ApprovalForm();
        public ApproveButtonClick_Form()
        {
            InitializeComponent();
        }

        private void ApproveButtonClick_Form_Load(object sender, EventArgs e)
        {
            string id = approvalform.textBox_approval_id.Text;
            textBox_number_task.Text = id + "번 업무가";

            Timer t = new Timer();
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string datePart = dt.ToString("hh시 mm분 결재되었습니다.");
            textBox_Date.Text = datePart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
