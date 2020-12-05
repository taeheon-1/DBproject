namespace ERP_PROG
{
    partial class TaskregisteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskregisteForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTaskdetail = new System.Windows.Forms.TextBox();
            this.btn_Taskregister = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTaskbigcat = new System.Windows.Forms.ComboBox();
            this.comboBoxTaskmidcat = new System.Windows.Forms.ComboBox();
            this.comboBoxTasksmallcat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPerformer = new System.Windows.Forms.TextBox();
            this.textBoxwrittenby = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_message = new System.Windows.Forms.Button();
            this.button_business = new System.Windows.Forms.Button();
            this.button_approval = new System.Windows.Forms.Button();
            this.button_personnel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(232, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "부서 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(380, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "업무 유형 선택";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(538, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "업무 선택";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(812, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "업무 시작 시간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(812, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "업무 종료 시간";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(232, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "상세 내용";
            // 
            // textBoxTaskdetail
            // 
            this.textBoxTaskdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTaskdetail.Location = new System.Drawing.Point(235, 381);
            this.textBoxTaskdetail.Multiline = true;
            this.textBoxTaskdetail.Name = "textBoxTaskdetail";
            this.textBoxTaskdetail.Size = new System.Drawing.Size(780, 138);
            this.textBoxTaskdetail.TabIndex = 15;
            // 
            // btn_Taskregister
            // 
            this.btn_Taskregister.BackColor = System.Drawing.Color.Black;
            this.btn_Taskregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Taskregister.ForeColor = System.Drawing.Color.White;
            this.btn_Taskregister.Location = new System.Drawing.Point(867, 551);
            this.btn_Taskregister.Name = "btn_Taskregister";
            this.btn_Taskregister.Size = new System.Drawing.Size(148, 41);
            this.btn_Taskregister.TabIndex = 16;
            this.btn_Taskregister.Text = "업무 등록";
            this.btn_Taskregister.UseVisualStyleBackColor = false;
            this.btn_Taskregister.Click += new System.EventHandler(this.btn_Taskregister_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(815, 188);
            this.dateTimePickerStart.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerStart.TabIndex = 23;
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFinish.Location = new System.Drawing.Point(815, 283);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerFinish.TabIndex = 24;
            // 
            // comboBoxTaskbigcat
            // 
            this.comboBoxTaskbigcat.FormattingEnabled = true;
            this.comboBoxTaskbigcat.Location = new System.Drawing.Point(235, 188);
            this.comboBoxTaskbigcat.Name = "comboBoxTaskbigcat";
            this.comboBoxTaskbigcat.Size = new System.Drawing.Size(101, 20);
            this.comboBoxTaskbigcat.TabIndex = 25;
            // 
            // comboBoxTaskmidcat
            // 
            this.comboBoxTaskmidcat.FormattingEnabled = true;
            this.comboBoxTaskmidcat.Location = new System.Drawing.Point(380, 188);
            this.comboBoxTaskmidcat.Name = "comboBoxTaskmidcat";
            this.comboBoxTaskmidcat.Size = new System.Drawing.Size(101, 20);
            this.comboBoxTaskmidcat.TabIndex = 26;
            // 
            // comboBoxTasksmallcat
            // 
            this.comboBoxTasksmallcat.FormattingEnabled = true;
            this.comboBoxTasksmallcat.Location = new System.Drawing.Point(541, 188);
            this.comboBoxTasksmallcat.Name = "comboBoxTasksmallcat";
            this.comboBoxTasksmallcat.Size = new System.Drawing.Size(101, 20);
            this.comboBoxTasksmallcat.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(232, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "업무 수행자";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(380, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "업무 등록자";
            // 
            // textBoxPerformer
            // 
            this.textBoxPerformer.Location = new System.Drawing.Point(235, 286);
            this.textBoxPerformer.Name = "textBoxPerformer";
            this.textBoxPerformer.Size = new System.Drawing.Size(100, 21);
            this.textBoxPerformer.TabIndex = 31;
            // 
            // textBoxwrittenby
            // 
            this.textBoxwrittenby.Location = new System.Drawing.Point(383, 286);
            this.textBoxwrittenby.Name = "textBoxwrittenby";
            this.textBoxwrittenby.Size = new System.Drawing.Size(100, 21);
            this.textBoxwrittenby.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button_message);
            this.panel2.Controls.Add(this.button_business);
            this.panel2.Controls.Add(this.button_approval);
            this.panel2.Controls.Add(this.button_personnel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 619);
            this.panel2.TabIndex = 34;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 370);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 253);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 42);
            this.panel1.TabIndex = 33;
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
            // TaskregisteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxwrittenby);
            this.Controls.Add(this.textBoxPerformer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTasksmallcat);
            this.Controls.Add(this.comboBoxTaskmidcat);
            this.Controls.Add(this.comboBoxTaskbigcat);
            this.Controls.Add(this.dateTimePickerFinish);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.btn_Taskregister);
            this.Controls.Add(this.textBoxTaskdetail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "TaskregisteForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TaskregisteForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTaskdetail;
        private System.Windows.Forms.Button btn_Taskregister;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.ComboBox comboBoxTaskbigcat;
        private System.Windows.Forms.ComboBox comboBoxTaskmidcat;
        private System.Windows.Forms.ComboBox comboBoxTasksmallcat;
        protected System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPerformer;
        private System.Windows.Forms.TextBox textBoxwrittenby;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_message;
        private System.Windows.Forms.Button button_business;
        private System.Windows.Forms.Button button_approval;
        private System.Windows.Forms.Button button_personnel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}