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
    public partial class MSG : Form
    {
        public static string msgtitle = "";
        public static string msgsender = "";
        public static string msgreceiver = "";
        public static string msgcontents = "";

        public string viewMSGId;
        public MSG()
        {
            InitializeComponent();
        }

        public string storeId
        {
            get { return this.viewMSGId; }
            set { this.viewMSGId = value; }
        }

        private void msg_Load(object sender, EventArgs e)
        {
            msgTitle.Text = msgtitle;
            msgSender.Text = msgsender;
            msgReceiver.Text = msgreceiver;
            msgContents.Text = msgcontents;
        }
    }
}
