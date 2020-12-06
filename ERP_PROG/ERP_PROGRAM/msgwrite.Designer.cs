namespace ERP_PROG
{
    partial class msgWrite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Msgsend = new System.Windows.Forms.Button();
            this.textBoxMsgcontents = new System.Windows.Forms.TextBox();
            this.textBoxMsgtitle = new System.Windows.Forms.TextBox();
            this.btn_Msgcancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMsgreceiver = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "내용";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "제목";
            // 
            // btn_Msgsend
            // 
            this.btn_Msgsend.BackColor = System.Drawing.Color.Black;
            this.btn_Msgsend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Msgsend.ForeColor = System.Drawing.Color.White;
            this.btn_Msgsend.Location = new System.Drawing.Point(697, 566);
            this.btn_Msgsend.Name = "btn_Msgsend";
            this.btn_Msgsend.Size = new System.Drawing.Size(102, 34);
            this.btn_Msgsend.TabIndex = 6;
            this.btn_Msgsend.Text = "보내기";
            this.btn_Msgsend.UseVisualStyleBackColor = false;
            this.btn_Msgsend.Click += new System.EventHandler(this.btn_Msgsend_Click);
            // 
            // textBoxMsgcontents
            // 
            this.textBoxMsgcontents.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMsgcontents.Location = new System.Drawing.Point(224, 320);
            this.textBoxMsgcontents.Multiline = true;
            this.textBoxMsgcontents.Name = "textBoxMsgcontents";
            this.textBoxMsgcontents.Size = new System.Drawing.Size(575, 227);
            this.textBoxMsgcontents.TabIndex = 7;
            this.textBoxMsgcontents.Text = "쪽지 내용을 입력해 주세요.";
            this.textBoxMsgcontents.Click += new System.EventHandler(this.textBoxMsgcontents_Click);
            // 
            // textBoxMsgtitle
            // 
            this.textBoxMsgtitle.Location = new System.Drawing.Point(224, 238);
            this.textBoxMsgtitle.Name = "textBoxMsgtitle";
            this.textBoxMsgtitle.Size = new System.Drawing.Size(575, 21);
            this.textBoxMsgtitle.TabIndex = 8;
            // 
            // btn_Msgcancel
            // 
            this.btn_Msgcancel.BackColor = System.Drawing.Color.Black;
            this.btn_Msgcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Msgcancel.ForeColor = System.Drawing.Color.White;
            this.btn_Msgcancel.Location = new System.Drawing.Point(224, 566);
            this.btn_Msgcancel.Name = "btn_Msgcancel";
            this.btn_Msgcancel.Size = new System.Drawing.Size(102, 34);
            this.btn_Msgcancel.TabIndex = 9;
            this.btn_Msgcancel.Text = "취소";
            this.btn_Msgcancel.UseVisualStyleBackColor = false;
            this.btn_Msgcancel.Click += new System.EventHandler(this.btn_Msgcancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "받는 사람";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(222, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "쪽지 쓰기";
            // 
            // textBoxMsgreceiver
            // 
            this.textBoxMsgreceiver.Location = new System.Drawing.Point(301, 174);
            this.textBoxMsgreceiver.Name = "textBoxMsgreceiver";
            this.textBoxMsgreceiver.Size = new System.Drawing.Size(136, 21);
            this.textBoxMsgreceiver.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 42);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ERP Program";
            // 
            // msgWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxMsgreceiver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Msgcancel);
            this.Controls.Add(this.textBoxMsgtitle);
            this.Controls.Add(this.textBoxMsgcontents);
            this.Controls.Add(this.btn_Msgsend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "msgWrite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msgwrite";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Msgsend;
        private System.Windows.Forms.TextBox textBoxMsgcontents;
        private System.Windows.Forms.TextBox textBoxMsgtitle;
        private System.Windows.Forms.Button btn_Msgcancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMsgreceiver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}