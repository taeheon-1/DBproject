namespace ERP_PROG
{
    partial class TaskMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewWorkDisplay = new System.Windows.Forms.ListView();
            this.task_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task_bigcat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task_midcat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task_smallcat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task_detail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task_taskstart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task_taskend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task_writtendate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task_writtenby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSearchOptionWrittenBy = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchOptionTask = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchOptionWrittenDate = new System.Windows.Forms.RadioButton();
            this.textBoxTaskSearch = new System.Windows.Forms.TextBox();
            this.buttonTaskSearch = new System.Windows.Forms.Button();
            this.buttonGoTaskMod = new System.Windows.Forms.Button();
            this.buttonGoTaskAdd = new System.Windows.Forms.Button();
            this.buttonGoMasterEdit = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonTaskDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 42);
            this.panel1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "일일 업무";
            // 
            // listViewWorkDisplay
            // 
            this.listViewWorkDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.task_id,
            this.task_bigcat,
            this.task_midcat,
            this.task_smallcat,
            this.task_detail,
            this.task_taskstart,
            this.task_taskend,
            this.task_writtendate,
            this.task_writtenby});
            this.listViewWorkDisplay.FullRowSelect = true;
            this.listViewWorkDisplay.GridLines = true;
            this.listViewWorkDisplay.HideSelection = false;
            this.listViewWorkDisplay.Location = new System.Drawing.Point(104, 106);
            this.listViewWorkDisplay.Name = "listViewWorkDisplay";
            this.listViewWorkDisplay.Size = new System.Drawing.Size(1023, 251);
            this.listViewWorkDisplay.TabIndex = 5;
            this.listViewWorkDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewWorkDisplay.View = System.Windows.Forms.View.Details;
            // 
            // task_id
            // 
            this.task_id.Text = "ID";
            // 
            // task_bigcat
            // 
            this.task_bigcat.Text = "부서";
            this.task_bigcat.Width = 79;
            // 
            // task_midcat
            // 
            this.task_midcat.Text = "업무유형";
            this.task_midcat.Width = 85;
            // 
            // task_smallcat
            // 
            this.task_smallcat.Text = "업무";
            this.task_smallcat.Width = 81;
            // 
            // task_detail
            // 
            this.task_detail.Text = "상세내용";
            this.task_detail.Width = 261;
            // 
            // task_taskstart
            // 
            this.task_taskstart.Text = "업무시작시간";
            this.task_taskstart.Width = 109;
            // 
            // task_taskend
            // 
            this.task_taskend.Text = "업무종료시간";
            this.task_taskend.Width = 113;
            // 
            // task_writtendate
            // 
            this.task_writtendate.Text = "등록날짜";
            this.task_writtendate.Width = 142;
            // 
            // task_writtenby
            // 
            this.task_writtenby.Text = "등록자";
            this.task_writtenby.Width = 82;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSearchOptionWrittenBy);
            this.groupBox1.Controls.Add(this.radioButtonSearchOptionTask);
            this.groupBox1.Controls.Add(this.radioButtonSearchOptionWrittenDate);
            this.groupBox1.Controls.Add(this.textBoxTaskSearch);
            this.groupBox1.Controls.Add(this.buttonTaskSearch);
            this.groupBox1.Location = new System.Drawing.Point(104, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 214);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "일일 업무 검색";
            // 
            // radioButtonSearchOptionWrittenBy
            // 
            this.radioButtonSearchOptionWrittenBy.AutoSize = true;
            this.radioButtonSearchOptionWrittenBy.Location = new System.Drawing.Point(21, 177);
            this.radioButtonSearchOptionWrittenBy.Name = "radioButtonSearchOptionWrittenBy";
            this.radioButtonSearchOptionWrittenBy.Size = new System.Drawing.Size(59, 16);
            this.radioButtonSearchOptionWrittenBy.TabIndex = 4;
            this.radioButtonSearchOptionWrittenBy.TabStop = true;
            this.radioButtonSearchOptionWrittenBy.Text = "등록자";
            this.radioButtonSearchOptionWrittenBy.UseVisualStyleBackColor = true;
            // 
            // radioButtonSearchOptionTask
            // 
            this.radioButtonSearchOptionTask.AutoSize = true;
            this.radioButtonSearchOptionTask.Location = new System.Drawing.Point(21, 131);
            this.radioButtonSearchOptionTask.Name = "radioButtonSearchOptionTask";
            this.radioButtonSearchOptionTask.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSearchOptionTask.TabIndex = 3;
            this.radioButtonSearchOptionTask.TabStop = true;
            this.radioButtonSearchOptionTask.Text = "업무";
            this.radioButtonSearchOptionTask.UseVisualStyleBackColor = true;
            // 
            // radioButtonSearchOptionWrittenDate
            // 
            this.radioButtonSearchOptionWrittenDate.AutoSize = true;
            this.radioButtonSearchOptionWrittenDate.Location = new System.Drawing.Point(21, 84);
            this.radioButtonSearchOptionWrittenDate.Name = "radioButtonSearchOptionWrittenDate";
            this.radioButtonSearchOptionWrittenDate.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSearchOptionWrittenDate.TabIndex = 2;
            this.radioButtonSearchOptionWrittenDate.TabStop = true;
            this.radioButtonSearchOptionWrittenDate.Text = "날짜";
            this.radioButtonSearchOptionWrittenDate.UseVisualStyleBackColor = true;
            // 
            // textBoxTaskSearch
            // 
            this.textBoxTaskSearch.Location = new System.Drawing.Point(21, 28);
            this.textBoxTaskSearch.Name = "textBoxTaskSearch";
            this.textBoxTaskSearch.Size = new System.Drawing.Size(192, 21);
            this.textBoxTaskSearch.TabIndex = 1;
            // 
            // buttonTaskSearch
            // 
            this.buttonTaskSearch.BackColor = System.Drawing.Color.Black;
            this.buttonTaskSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTaskSearch.ForeColor = System.Drawing.Color.White;
            this.buttonTaskSearch.Location = new System.Drawing.Point(232, 22);
            this.buttonTaskSearch.Name = "buttonTaskSearch";
            this.buttonTaskSearch.Size = new System.Drawing.Size(101, 30);
            this.buttonTaskSearch.TabIndex = 0;
            this.buttonTaskSearch.Text = "검색";
            this.buttonTaskSearch.UseVisualStyleBackColor = false;
            this.buttonTaskSearch.Click += new System.EventHandler(this.buttonTaskSearch_Click);
            // 
            // buttonGoTaskMod
            // 
            this.buttonGoTaskMod.BackColor = System.Drawing.Color.Black;
            this.buttonGoTaskMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoTaskMod.ForeColor = System.Drawing.Color.White;
            this.buttonGoTaskMod.Location = new System.Drawing.Point(725, 365);
            this.buttonGoTaskMod.Name = "buttonGoTaskMod";
            this.buttonGoTaskMod.Size = new System.Drawing.Size(198, 30);
            this.buttonGoTaskMod.TabIndex = 9;
            this.buttonGoTaskMod.Text = "일일 업무 수정";
            this.buttonGoTaskMod.UseVisualStyleBackColor = false;
            this.buttonGoTaskMod.Click += new System.EventHandler(this.buttonGoTaskMod_Click);
            // 
            // buttonGoTaskAdd
            // 
            this.buttonGoTaskAdd.BackColor = System.Drawing.Color.Black;
            this.buttonGoTaskAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoTaskAdd.ForeColor = System.Drawing.Color.White;
            this.buttonGoTaskAdd.Location = new System.Drawing.Point(521, 365);
            this.buttonGoTaskAdd.Name = "buttonGoTaskAdd";
            this.buttonGoTaskAdd.Size = new System.Drawing.Size(198, 30);
            this.buttonGoTaskAdd.TabIndex = 10;
            this.buttonGoTaskAdd.Text = "일일 업무 등록";
            this.buttonGoTaskAdd.UseVisualStyleBackColor = false;
            this.buttonGoTaskAdd.Click += new System.EventHandler(this.buttonGoTaskAdd_Click);
            // 
            // buttonGoMasterEdit
            // 
            this.buttonGoMasterEdit.BackColor = System.Drawing.Color.Black;
            this.buttonGoMasterEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGoMasterEdit.ForeColor = System.Drawing.Color.White;
            this.buttonGoMasterEdit.Location = new System.Drawing.Point(929, 67);
            this.buttonGoMasterEdit.Name = "buttonGoMasterEdit";
            this.buttonGoMasterEdit.Size = new System.Drawing.Size(198, 30);
            this.buttonGoMasterEdit.TabIndex = 13;
            this.buttonGoMasterEdit.Text = "업무 마스터 관리";
            this.buttonGoMasterEdit.UseVisualStyleBackColor = false;
            this.buttonGoMasterEdit.Click += new System.EventHandler(this.buttonGoMasterEdit_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Black;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(799, 67);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(101, 30);
            this.buttonReturn.TabIndex = 14;
            this.buttonReturn.Text = "되돌리기";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonTaskDelete
            // 
            this.buttonTaskDelete.BackColor = System.Drawing.Color.Black;
            this.buttonTaskDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTaskDelete.ForeColor = System.Drawing.Color.White;
            this.buttonTaskDelete.Location = new System.Drawing.Point(929, 365);
            this.buttonTaskDelete.Name = "buttonTaskDelete";
            this.buttonTaskDelete.Size = new System.Drawing.Size(198, 30);
            this.buttonTaskDelete.TabIndex = 15;
            this.buttonTaskDelete.Text = "일일 업무 삭제";
            this.buttonTaskDelete.UseVisualStyleBackColor = false;
            this.buttonTaskDelete.Click += new System.EventHandler(this.buttonTaskDelete_Click);
            // 
            // TaskMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.buttonTaskDelete);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonGoMasterEdit);
            this.Controls.Add(this.buttonGoTaskAdd);
            this.Controls.Add(this.buttonGoTaskMod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewWorkDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "TaskMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskMain_FormClosed);
            this.Load += new System.EventHandler(this.WorkMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewWorkDisplay;
        private System.Windows.Forms.ColumnHeader task_bigcat;
        private System.Windows.Forms.ColumnHeader task_midcat;
        private System.Windows.Forms.ColumnHeader task_smallcat;
        private System.Windows.Forms.ColumnHeader task_detail;
        private System.Windows.Forms.ColumnHeader task_writtendate;
        private System.Windows.Forms.ColumnHeader task_writtenby;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTaskSearch;
        private System.Windows.Forms.RadioButton radioButtonSearchOptionWrittenBy;
        private System.Windows.Forms.RadioButton radioButtonSearchOptionTask;
        private System.Windows.Forms.RadioButton radioButtonSearchOptionWrittenDate;
        private System.Windows.Forms.TextBox textBoxTaskSearch;
        private System.Windows.Forms.Button buttonGoTaskMod;
        private System.Windows.Forms.Button buttonGoTaskAdd;
        private System.Windows.Forms.Button buttonGoMasterEdit;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ColumnHeader task_taskstart;
        private System.Windows.Forms.ColumnHeader task_taskend;
        private System.Windows.Forms.Button buttonTaskDelete;
        private System.Windows.Forms.ColumnHeader task_id;
    }
}