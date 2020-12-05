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

        private void button_register_Click(object sender, EventArgs e)
        {
            /*string query = "INSERT INTO 결재(approval_title, approval_task, approval_contents, approval_person, approver1, approver2, approver3, approval_coment,approval_coment,approva_progress,approval_type) " +
                    "values ('" + this.EmployeeCode.Text + "','" + this.EmployeePassword.Text + "', '" + this.EmployeeAge.Text + "','"
                    + this.EmployeeName.Text + "','" + this.EmployeeAddress.Text + "','" + this.EmployeeRank.Text + "'" +
                    ",'" + this.EmployeeDetailedAddress.Text + "','" + this.EmployeeDepartment.Text + "')";
            ERPManager.GetInstance().Insert(query);*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
