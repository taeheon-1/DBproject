namespace ERP_PROG
{
    partial class TaskRegister
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTaskDetail = new System.Windows.Forms.TextBox();
            this.btn_Taskregister = new System.Windows.Forms.Button();
            this.dateTimePickerTaskStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTaskEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTaskBigCat = new System.Windows.Forms.ComboBox();
            this.comboBoxTaskMidCat = new System.Windows.Forms.ComboBox();
            this.comboBoxTaskSmallCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(198, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "부서 선택";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(346, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "업무 유형 선택";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(504, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "업무 선택";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(778, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "업무 시작 시간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(778, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "업무 종료 시간";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(198, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "상세 내용";
            // 
            // textBoxTaskDetail
            // 
            this.textBoxTaskDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTaskDetail.Location = new System.Drawing.Point(201, 380);
            this.textBoxTaskDetail.Multiline = true;
            this.textBoxTaskDetail.Name = "textBoxTaskDetail";
            this.textBoxTaskDetail.Size = new System.Drawing.Size(780, 138);
            this.textBoxTaskDetail.TabIndex = 15;
            // 
            // btn_Taskregister
            // 
            this.btn_Taskregister.BackColor = System.Drawing.Color.Black;
            this.btn_Taskregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Taskregister.ForeColor = System.Drawing.Color.White;
            this.btn_Taskregister.Location = new System.Drawing.Point(833, 550);
            this.btn_Taskregister.Name = "btn_Taskregister";
            this.btn_Taskregister.Size = new System.Drawing.Size(148, 41);
            this.btn_Taskregister.TabIndex = 16;
            this.btn_Taskregister.Text = "업무 등록";
            this.btn_Taskregister.UseVisualStyleBackColor = false;
            this.btn_Taskregister.Click += new System.EventHandler(this.btn_Taskregister_Click);
            // 
            // dateTimePickerTaskStart
            // 
            this.dateTimePickerTaskStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerTaskStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTaskStart.Location = new System.Drawing.Point(781, 187);
            this.dateTimePickerTaskStart.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerTaskStart.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTaskStart.Name = "dateTimePickerTaskStart";
            this.dateTimePickerTaskStart.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerTaskStart.TabIndex = 23;
            // 
            // dateTimePickerTaskEnd
            // 
            this.dateTimePickerTaskEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePickerTaskEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTaskEnd.Location = new System.Drawing.Point(781, 282);
            this.dateTimePickerTaskEnd.Name = "dateTimePickerTaskEnd";
            this.dateTimePickerTaskEnd.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerTaskEnd.TabIndex = 24;
            // 
            // comboBoxTaskBigCat
            // 
            this.comboBoxTaskBigCat.FormattingEnabled = true;
            this.comboBoxTaskBigCat.Location = new System.Drawing.Point(201, 187);
            this.comboBoxTaskBigCat.Name = "comboBoxTaskBigCat";
            this.comboBoxTaskBigCat.Size = new System.Drawing.Size(101, 20);
            this.comboBoxTaskBigCat.TabIndex = 25;
            this.comboBoxTaskBigCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskbigcat_SelectedIndexChanged);
            // 
            // comboBoxTaskMidCat
            // 
            this.comboBoxTaskMidCat.FormattingEnabled = true;
            this.comboBoxTaskMidCat.Location = new System.Drawing.Point(346, 187);
            this.comboBoxTaskMidCat.Name = "comboBoxTaskMidCat";
            this.comboBoxTaskMidCat.Size = new System.Drawing.Size(101, 20);
            this.comboBoxTaskMidCat.TabIndex = 26;
            this.comboBoxTaskMidCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskmidcat_SelectedIndexChanged);
            // 
            // comboBoxTaskSmallCat
            // 
            this.comboBoxTaskSmallCat.FormattingEnabled = true;
            this.comboBoxTaskSmallCat.Location = new System.Drawing.Point(507, 187);
            this.comboBoxTaskSmallCat.Name = "comboBoxTaskSmallCat";
            this.comboBoxTaskSmallCat.Size = new System.Drawing.Size(101, 20);
            this.comboBoxTaskSmallCat.TabIndex = 27;
            this.comboBoxTaskSmallCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxTasksmallcat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(198, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "업무 수행자";
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.Location = new System.Drawing.Point(201, 285);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(100, 21);
            this.textBoxWorker.TabIndex = 31;
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
            // TaskRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTaskSmallCat);
            this.Controls.Add(this.comboBoxTaskMidCat);
            this.Controls.Add(this.comboBoxTaskBigCat);
            this.Controls.Add(this.dateTimePickerTaskEnd);
            this.Controls.Add(this.dateTimePickerTaskStart);
            this.Controls.Add(this.btn_Taskregister);
            this.Controls.Add(this.textBoxTaskDetail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "TaskRegister";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskRegister_FormClosed);
            this.Load += new System.EventHandler(this.TaskregisteForm_Load);
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
        private System.Windows.Forms.TextBox textBoxTaskDetail;
        private System.Windows.Forms.Button btn_Taskregister;
        private System.Windows.Forms.DateTimePicker dateTimePickerTaskStart;
        private System.Windows.Forms.ComboBox comboBoxTaskBigCat;
        private System.Windows.Forms.ComboBox comboBoxTaskMidCat;
        private System.Windows.Forms.ComboBox comboBoxTaskSmallCat;
        protected System.Windows.Forms.DateTimePicker dateTimePickerTaskEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}