namespace ERP_PROG
{
    partial class msgview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgview));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_message = new System.Windows.Forms.Button();
            this.button_business = new System.Windows.Forms.Button();
            this.button_approval = new System.Windows.Forms.Button();
            this.button_personnel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSearchsender = new System.Windows.Forms.TextBox();
            this.textBoxSearchtitlecontents = new System.Windows.Forms.TextBox();
            this.btn_Msgsearch = new System.Windows.Forms.Button();
            this.listViewMsg = new System.Windows.Forms.ListView();
            this.msgID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgContents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Msgwrite = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.labelSendview = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 70);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ERP Program";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.button_message);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.button_business);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.button_approval);
            this.panel2.Controls.Add(this.button_personnel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 591);
            this.panel2.TabIndex = 3;
            // 
            // button_message
            // 
            this.button_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_message.ForeColor = System.Drawing.Color.Black;
            this.button_message.Location = new System.Drawing.Point(0, 354);
            this.button_message.Margin = new System.Windows.Forms.Padding(0);
            this.button_message.Name = "button_message";
            this.button_message.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.button_message.Size = new System.Drawing.Size(106, 120);
            this.button_message.TabIndex = 5;
            this.button_message.Text = "쪽지";
            this.button_message.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_message.UseVisualStyleBackColor = false;
            this.button_message.Click += new System.EventHandler(this.button_message_Click);
            // 
            // button_business
            // 
            this.button_business.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_business.ForeColor = System.Drawing.Color.Black;
            this.button_business.Location = new System.Drawing.Point(0, 118);
            this.button_business.Margin = new System.Windows.Forms.Padding(0);
            this.button_business.Name = "button_business";
            this.button_business.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.button_business.Size = new System.Drawing.Size(106, 120);
            this.button_business.TabIndex = 4;
            this.button_business.Text = "업무";
            this.button_business.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_business.UseVisualStyleBackColor = false;
            this.button_business.Click += new System.EventHandler(this.button_business_Click);
            // 
            // button_approval
            // 
            this.button_approval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_approval.ForeColor = System.Drawing.Color.Black;
            this.button_approval.Location = new System.Drawing.Point(0, 236);
            this.button_approval.Margin = new System.Windows.Forms.Padding(0);
            this.button_approval.Name = "button_approval";
            this.button_approval.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.button_approval.Size = new System.Drawing.Size(106, 120);
            this.button_approval.TabIndex = 3;
            this.button_approval.Text = "결재";
            this.button_approval.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_approval.UseVisualStyleBackColor = false;
            this.button_approval.Click += new System.EventHandler(this.button_approval_Click);
            // 
            // button_personnel
            // 
            this.button_personnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_personnel.ForeColor = System.Drawing.Color.Black;
            this.button_personnel.Location = new System.Drawing.Point(0, 0);
            this.button_personnel.Margin = new System.Windows.Forms.Padding(0);
            this.button_personnel.Name = "button_personnel";
            this.button_personnel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.button_personnel.Size = new System.Drawing.Size(106, 120);
            this.button_personnel.TabIndex = 2;
            this.button_personnel.Text = "인사";
            this.button_personnel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_personnel.UseVisualStyleBackColor = false;
            this.button_personnel.Click += new System.EventHandler(this.button_personnel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "보낸 사람";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "제목+내용";
            // 
            // textBoxSearchsender
            // 
            this.textBoxSearchsender.Location = new System.Drawing.Point(307, 160);
            this.textBoxSearchsender.Name = "textBoxSearchsender";
            this.textBoxSearchsender.Size = new System.Drawing.Size(100, 21);
            this.textBoxSearchsender.TabIndex = 9;
            // 
            // textBoxSearchtitlecontents
            // 
            this.textBoxSearchtitlecontents.Location = new System.Drawing.Point(513, 160);
            this.textBoxSearchtitlecontents.Name = "textBoxSearchtitlecontents";
            this.textBoxSearchtitlecontents.Size = new System.Drawing.Size(435, 21);
            this.textBoxSearchtitlecontents.TabIndex = 11;
            // 
            // btn_Msgsearch
            // 
            this.btn_Msgsearch.BackColor = System.Drawing.Color.Black;
            this.btn_Msgsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Msgsearch.ForeColor = System.Drawing.Color.White;
            this.btn_Msgsearch.Location = new System.Drawing.Point(981, 155);
            this.btn_Msgsearch.Name = "btn_Msgsearch";
            this.btn_Msgsearch.Size = new System.Drawing.Size(82, 32);
            this.btn_Msgsearch.TabIndex = 12;
            this.btn_Msgsearch.Text = "검색";
            this.btn_Msgsearch.UseVisualStyleBackColor = false;
            this.btn_Msgsearch.Click += new System.EventHandler(this.btn_Msgsearch_Click);
            // 
            // listViewMsg
            // 
            this.listViewMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.msgID,
            this.msgSender,
            this.msgTitle,
            this.msgContents});
            this.listViewMsg.FullRowSelect = true;
            this.listViewMsg.GridLines = true;
            this.listViewMsg.HideSelection = false;
            this.listViewMsg.Location = new System.Drawing.Point(228, 272);
            this.listViewMsg.Name = "listViewMsg";
            this.listViewMsg.Size = new System.Drawing.Size(835, 342);
            this.listViewMsg.TabIndex = 13;
            this.listViewMsg.UseCompatibleStateImageBehavior = false;
            this.listViewMsg.View = System.Windows.Forms.View.Details;
            this.listViewMsg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMsg_MouseDoubleClick);
            // 
            // msgID
            // 
            this.msgID.Text = "no";
            // 
            // msgSender
            // 
            this.msgSender.Text = "보낸 사람";
            this.msgSender.Width = 96;
            // 
            // msgTitle
            // 
            this.msgTitle.Text = "제목";
            this.msgTitle.Width = 163;
            // 
            // msgContents
            // 
            this.msgContents.Text = "내용";
            this.msgContents.Width = 416;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(225, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "받은 쪽지함";
            // 
            // btn_Msgwrite
            // 
            this.btn_Msgwrite.BackColor = System.Drawing.Color.Black;
            this.btn_Msgwrite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Msgwrite.ForeColor = System.Drawing.Color.White;
            this.btn_Msgwrite.Location = new System.Drawing.Point(325, 227);
            this.btn_Msgwrite.Name = "btn_Msgwrite";
            this.btn_Msgwrite.Size = new System.Drawing.Size(82, 32);
            this.btn_Msgwrite.TabIndex = 15;
            this.btn_Msgwrite.Text = "쪽지 보내기";
            this.btn_Msgwrite.UseVisualStyleBackColor = false;
            this.btn_Msgwrite.Click += new System.EventHandler(this.btn_Msgwrite_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.Black;
            this.btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reload.ForeColor = System.Drawing.Color.White;
            this.btn_Reload.Location = new System.Drawing.Point(228, 227);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(82, 32);
            this.btn_Reload.TabIndex = 16;
            this.btn_Reload.Text = "새로고침";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // labelSendview
            // 
            this.labelSendview.AutoSize = true;
            this.labelSendview.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSendview.Location = new System.Drawing.Point(342, 112);
            this.labelSendview.Name = "labelSendview";
            this.labelSendview.Size = new System.Drawing.Size(64, 11);
            this.labelSendview.TabIndex = 17;
            this.labelSendview.Text = "보낸 쪽지함";
            this.labelSendview.Click += new System.EventHandler(this.labelSendview_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(24, 368);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(24, 251);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(24, 132);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 55);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(24, 16);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 55);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // msgview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.labelSendview);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Msgwrite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMsg);
            this.Controls.Add(this.btn_Msgsearch);
            this.Controls.Add(this.textBoxSearchtitlecontents);
            this.Controls.Add(this.textBoxSearchsender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "msgview";
            this.Text = "msgview";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.msgview_FormClosed);
            this.Load += new System.EventHandler(this.msgview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_message;
        private System.Windows.Forms.Button button_business;
        private System.Windows.Forms.Button button_approval;
        private System.Windows.Forms.Button button_personnel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSearchsender;
        private System.Windows.Forms.TextBox textBoxSearchtitlecontents;
        private System.Windows.Forms.Button btn_Msgsearch;
        private System.Windows.Forms.ListView listViewMsg;
        private System.Windows.Forms.ColumnHeader msgSender;
        private System.Windows.Forms.ColumnHeader msgTitle;
        private System.Windows.Forms.ColumnHeader msgContents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Msgwrite;
        private System.Windows.Forms.ColumnHeader msgID;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Label labelSendview;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}