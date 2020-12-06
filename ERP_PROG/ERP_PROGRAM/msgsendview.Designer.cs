namespace ERP_PROG
{
    partial class msgsendview
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
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_Msgwrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewMsg = new System.Windows.Forms.ListView();
            this.msgID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgReceiver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgContents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgCheckreceive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Msgsearch = new System.Windows.Forms.Button();
            this.textBoxSearchtitlecontents = new System.Windows.Forms.TextBox();
            this.labelReceiveview = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_contents = new System.Windows.Forms.RadioButton();
            this.radioButton_title = new System.Windows.Forms.RadioButton();
            this.radiobutton_recipient = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.Black;
            this.btn_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reload.ForeColor = System.Drawing.Color.White;
            this.btn_Reload.Location = new System.Drawing.Point(228, 227);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(82, 32);
            this.btn_Reload.TabIndex = 25;
            this.btn_Reload.Text = "새로고침";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_Msgwrite
            // 
            this.btn_Msgwrite.BackColor = System.Drawing.Color.Black;
            this.btn_Msgwrite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Msgwrite.ForeColor = System.Drawing.Color.White;
            this.btn_Msgwrite.Location = new System.Drawing.Point(325, 227);
            this.btn_Msgwrite.Name = "btn_Msgwrite";
            this.btn_Msgwrite.Size = new System.Drawing.Size(82, 32);
            this.btn_Msgwrite.TabIndex = 24;
            this.btn_Msgwrite.Text = "쪽지 보내기";
            this.btn_Msgwrite.UseVisualStyleBackColor = false;
            this.btn_Msgwrite.Click += new System.EventHandler(this.btn_Msgwrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(342, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "보낸 쪽지함";
            // 
            // listViewMsg
            // 
            this.listViewMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.msgID,
            this.msgReceiver,
            this.msgTitle,
            this.msgContents,
            this.msgCheckreceive});
            this.listViewMsg.FullRowSelect = true;
            this.listViewMsg.GridLines = true;
            this.listViewMsg.HideSelection = false;
            this.listViewMsg.Location = new System.Drawing.Point(228, 272);
            this.listViewMsg.Name = "listViewMsg";
            this.listViewMsg.Size = new System.Drawing.Size(835, 342);
            this.listViewMsg.TabIndex = 22;
            this.listViewMsg.UseCompatibleStateImageBehavior = false;
            this.listViewMsg.View = System.Windows.Forms.View.Details;
            this.listViewMsg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMsg_MouseDoubleClick);
            // 
            // msgID
            // 
            this.msgID.Text = "no";
            // 
            // msgReceiver
            // 
            this.msgReceiver.Text = "받는 사람";
            this.msgReceiver.Width = 96;
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
            // msgCheckreceive
            // 
            this.msgCheckreceive.Text = "수신 확인";
            this.msgCheckreceive.Width = 93;
            // 
            // btn_Msgsearch
            // 
            this.btn_Msgsearch.BackColor = System.Drawing.Color.Black;
            this.btn_Msgsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Msgsearch.ForeColor = System.Drawing.Color.White;
            this.btn_Msgsearch.Location = new System.Drawing.Point(981, 155);
            this.btn_Msgsearch.Name = "btn_Msgsearch";
            this.btn_Msgsearch.Size = new System.Drawing.Size(82, 32);
            this.btn_Msgsearch.TabIndex = 21;
            this.btn_Msgsearch.Text = "검색";
            this.btn_Msgsearch.UseVisualStyleBackColor = false;
            this.btn_Msgsearch.Click += new System.EventHandler(this.btn_Msgsearch_Click);
            // 
            // textBoxSearchtitlecontents
            // 
            this.textBoxSearchtitlecontents.Location = new System.Drawing.Point(513, 160);
            this.textBoxSearchtitlecontents.Name = "textBoxSearchtitlecontents";
            this.textBoxSearchtitlecontents.Size = new System.Drawing.Size(435, 21);
            this.textBoxSearchtitlecontents.TabIndex = 20;
            // 
            // labelReceiveview
            // 
            this.labelReceiveview.AutoSize = true;
            this.labelReceiveview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReceiveview.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelReceiveview.Location = new System.Drawing.Point(225, 112);
            this.labelReceiveview.Name = "labelReceiveview";
            this.labelReceiveview.Size = new System.Drawing.Size(64, 11);
            this.labelReceiveview.TabIndex = 26;
            this.labelReceiveview.Text = "받은 쪽지함";
            this.labelReceiveview.Click += new System.EventHandler(this.labelReceiveview_Click);
            this.labelReceiveview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelReceiveview_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 42);
            this.panel1.TabIndex = 27;
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
            // radioButton_contents
            // 
            this.radioButton_contents.AutoSize = true;
            this.radioButton_contents.Location = new System.Drawing.Point(426, 163);
            this.radioButton_contents.Name = "radioButton_contents";
            this.radioButton_contents.Size = new System.Drawing.Size(47, 16);
            this.radioButton_contents.TabIndex = 24;
            this.radioButton_contents.TabStop = true;
            this.radioButton_contents.Text = "내용";
            this.radioButton_contents.UseVisualStyleBackColor = true;
            // 
            // radioButton_title
            // 
            this.radioButton_title.AutoSize = true;
            this.radioButton_title.Location = new System.Drawing.Point(345, 163);
            this.radioButton_title.Name = "radioButton_title";
            this.radioButton_title.Size = new System.Drawing.Size(47, 16);
            this.radioButton_title.TabIndex = 23;
            this.radioButton_title.TabStop = true;
            this.radioButton_title.Text = "제목";
            this.radioButton_title.UseVisualStyleBackColor = true;
            // 
            // radiobutton_recipient
            // 
            this.radiobutton_recipient.AutoSize = true;
            this.radiobutton_recipient.Location = new System.Drawing.Point(239, 163);
            this.radiobutton_recipient.Name = "radiobutton_recipient";
            this.radiobutton_recipient.Size = new System.Drawing.Size(75, 16);
            this.radiobutton_recipient.TabIndex = 22;
            this.radiobutton_recipient.TabStop = true;
            this.radiobutton_recipient.Text = "받는 사람";
            this.radiobutton_recipient.UseVisualStyleBackColor = true;
            // 
            // msgsendview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.radioButton_contents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton_title);
            this.Controls.Add(this.labelReceiveview);
            this.Controls.Add(this.radiobutton_recipient);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Msgwrite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMsg);
            this.Controls.Add(this.btn_Msgsearch);
            this.Controls.Add(this.textBoxSearchtitlecontents);
            this.Name = "msgsendview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msgsendview";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.msgsendview_FormClosed);
            this.Load += new System.EventHandler(this.msgsendview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_Msgwrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewMsg;
        private System.Windows.Forms.ColumnHeader msgID;
        private System.Windows.Forms.ColumnHeader msgReceiver;
        private System.Windows.Forms.ColumnHeader msgTitle;
        private System.Windows.Forms.ColumnHeader msgContents;
        private System.Windows.Forms.ColumnHeader msgCheckreceive;
        private System.Windows.Forms.Button btn_Msgsearch;
        private System.Windows.Forms.TextBox textBoxSearchtitlecontents;
        private System.Windows.Forms.Label labelReceiveview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_contents;
        private System.Windows.Forms.RadioButton radioButton_title;
        private System.Windows.Forms.RadioButton radiobutton_recipient;
    }
}