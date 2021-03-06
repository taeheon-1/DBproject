﻿namespace ERP_PROG
{
    partial class TaskMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskMod));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerTaskStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTaskEnd = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTaskDetail = new System.Windows.Forms.TextBox();
            this.buttonModTask = new System.Windows.Forms.Button();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.textBoxWrittenBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTaskBigCat = new System.Windows.Forms.ComboBox();
            this.comboBoxTaskMidCat = new System.Windows.Forms.ComboBox();
            this.comboBoxTaskSmallCat = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(793, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "업무 시작 시간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(793, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "업무 종료 시간";
            // 
            // dateTimePickerTaskStart
            // 
            this.dateTimePickerTaskStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerTaskStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTaskStart.Location = new System.Drawing.Point(795, 150);
            this.dateTimePickerTaskStart.Name = "dateTimePickerTaskStart";
            this.dateTimePickerTaskStart.Size = new System.Drawing.Size(356, 21);
            this.dateTimePickerTaskStart.TabIndex = 16;
            // 
            // dateTimePickerTaskEnd
            // 
            this.dateTimePickerTaskEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerTaskEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTaskEnd.Location = new System.Drawing.Point(795, 220);
            this.dateTimePickerTaskEnd.Name = "dateTimePickerTaskEnd";
            this.dateTimePickerTaskEnd.Size = new System.Drawing.Size(356, 21);
            this.dateTimePickerTaskEnd.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "상세 내용";
            // 
            // textBoxTaskDetail
            // 
            this.textBoxTaskDetail.Location = new System.Drawing.Point(148, 396);
            this.textBoxTaskDetail.Multiline = true;
            this.textBoxTaskDetail.Name = "textBoxTaskDetail";
            this.textBoxTaskDetail.Size = new System.Drawing.Size(1004, 166);
            this.textBoxTaskDetail.TabIndex = 27;
            // 
            // buttonModTask
            // 
            this.buttonModTask.BackColor = System.Drawing.Color.Black;
            this.buttonModTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModTask.ForeColor = System.Drawing.Color.White;
            this.buttonModTask.Location = new System.Drawing.Point(954, 580);
            this.buttonModTask.Name = "buttonModTask";
            this.buttonModTask.Size = new System.Drawing.Size(198, 30);
            this.buttonModTask.TabIndex = 28;
            this.buttonModTask.Text = "해당 일일 업무 수정";
            this.buttonModTask.UseVisualStyleBackColor = false;
            this.buttonModTask.Click += new System.EventHandler(this.buttonModTask_Click);
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
            this.panel2.TabIndex = 31;
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
            this.panel1.TabIndex = 30;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "업무 수행자";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 33;
            this.label8.Text = "업무 등록자";
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(214, 248);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(121, 21);
            this.textBoxWorker.TabIndex = 34;
            // 
            // textBoxWrittenBy
            // 
            this.textBoxWrittenBy.Location = new System.Drawing.Point(387, 248);
            this.textBoxWrittenBy.Name = "textBoxWrittenBy";
            this.textBoxWrittenBy.Size = new System.Drawing.Size(121, 21);
            this.textBoxWrittenBy.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "부서 선택";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "업무 유형 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "업무 선택";
            // 
            // comboBoxTaskBigCat
            // 
            this.comboBoxTaskBigCat.FormattingEnabled = true;
            this.comboBoxTaskBigCat.Location = new System.Drawing.Point(214, 135);
            this.comboBoxTaskBigCat.Name = "comboBoxTaskBigCat";
            this.comboBoxTaskBigCat.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTaskBigCat.TabIndex = 39;
            this.comboBoxTaskBigCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskBigCat_SelectedIndexChanged);
            // 
            // comboBoxTaskMidCat
            // 
            this.comboBoxTaskMidCat.FormattingEnabled = true;
            this.comboBoxTaskMidCat.Location = new System.Drawing.Point(387, 135);
            this.comboBoxTaskMidCat.Name = "comboBoxTaskMidCat";
            this.comboBoxTaskMidCat.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTaskMidCat.TabIndex = 40;
            this.comboBoxTaskMidCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskMidCat_SelectedIndexChanged);
            // 
            // comboBoxTaskSmallCat
            // 
            this.comboBoxTaskSmallCat.FormattingEnabled = true;
            this.comboBoxTaskSmallCat.Location = new System.Drawing.Point(568, 135);
            this.comboBoxTaskSmallCat.Name = "comboBoxTaskSmallCat";
            this.comboBoxTaskSmallCat.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTaskSmallCat.TabIndex = 41;
            this.comboBoxTaskSmallCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskSmallCat_SelectedIndexChanged);
            // 
            // TaskMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.comboBoxTaskSmallCat);
            this.Controls.Add(this.comboBoxTaskMidCat);
            this.Controls.Add(this.comboBoxTaskBigCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWrittenBy);
            this.Controls.Add(this.textBoxWorker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonModTask);
            this.Controls.Add(this.textBoxTaskDetail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerTaskEnd);
            this.Controls.Add(this.dateTimePickerTaskStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "TaskMod";
            this.Text = "WorkModDelete";
            this.Load += new System.EventHandler(this.WorkMod_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTaskStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerTaskEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTaskDetail;
        private System.Windows.Forms.Button buttonModTask;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.TextBox textBoxWrittenBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTaskBigCat;
        private System.Windows.Forms.ComboBox comboBoxTaskMidCat;
        private System.Windows.Forms.ComboBox comboBoxTaskSmallCat;
    }
}