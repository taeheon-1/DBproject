namespace ERP_PROG
{
    partial class PersonnelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.기본정보 = new System.Windows.Forms.TabPage();
            this.PostNumberSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeePassword = new System.Windows.Forms.TextBox();
            this.PostNumberText = new System.Windows.Forms.TextBox();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmployeeClear = new System.Windows.Forms.Button();
            this.EmployeeUpdate = new System.Windows.Forms.Button();
            this.EmployeeDelete = new System.Windows.Forms.Button();
            this.EmployeeSearchComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeeSearch = new System.Windows.Forms.Button();
            this.EmployeeSearchTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeAge = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.EmployeeDepartment = new System.Windows.Forms.ComboBox();
            this.EmployeeRank = new System.Windows.Forms.ComboBox();
            this.EmployeeInsert = new System.Windows.Forms.Button();
            this.EmployeeCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EmployeeDetailedAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmployeeAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.출근부 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AttendanceRead = new System.Windows.Forms.Button();
            this.AttendanceInsert = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.EndMinute = new System.Windows.Forms.TextBox();
            this.StartMinute = new System.Windows.Forms.TextBox();
            this.EndHour = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.StartHour = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.부서관리 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DepartmentInCancel = new System.Windows.Forms.Button();
            this.DepartmentSerach = new System.Windows.Forms.Button();
            this.DepartmentInsert = new System.Windows.Forms.Button();
            this.DepartmentDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DepartmentUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DepartmentID = new System.Windows.Forms.TextBox();
            this.DepartmentHead = new System.Windows.Forms.TextBox();
            this.DepartmentCode = new System.Windows.Forms.TextBox();
            this.DepartmentName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.급여내역서 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.기본정보.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.출근부.SuspendLayout();
            this.부서관리.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.기본정보);
            this.tabControl1.Controls.Add(this.출근부);
            this.tabControl1.Controls.Add(this.부서관리);
            this.tabControl1.Controls.Add(this.급여내역서);
            this.tabControl1.Location = new System.Drawing.Point(156, 70);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 238);
            this.tabControl1.TabIndex = 91;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // 기본정보
            // 
            this.기본정보.Controls.Add(this.PostNumberSearch);
            this.기본정보.Controls.Add(this.label1);
            this.기본정보.Controls.Add(this.EmployeePassword);
            this.기본정보.Controls.Add(this.PostNumberText);
            this.기본정보.Controls.Add(this.EmployeeID);
            this.기본정보.Controls.Add(this.groupBox1);
            this.기본정보.Controls.Add(this.EmployeeAge);
            this.기본정보.Controls.Add(this.label20);
            this.기본정보.Controls.Add(this.EmployeeDepartment);
            this.기본정보.Controls.Add(this.EmployeeRank);
            this.기본정보.Controls.Add(this.EmployeeInsert);
            this.기본정보.Controls.Add(this.EmployeeCode);
            this.기본정보.Controls.Add(this.label13);
            this.기본정보.Controls.Add(this.label10);
            this.기본정보.Controls.Add(this.EmployeeDetailedAddress);
            this.기본정보.Controls.Add(this.label6);
            this.기본정보.Controls.Add(this.EmployeeAddress);
            this.기본정보.Controls.Add(this.label11);
            this.기본정보.Controls.Add(this.label9);
            this.기본정보.Controls.Add(this.EmployeeName);
            this.기본정보.Controls.Add(this.label8);
            this.기본정보.Controls.Add(this.label7);
            this.기본정보.Location = new System.Drawing.Point(4, 22);
            this.기본정보.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.기본정보.Name = "기본정보";
            this.기본정보.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.기본정보.Size = new System.Drawing.Size(624, 212);
            this.기본정보.TabIndex = 0;
            this.기본정보.Text = "기본정보";
            this.기본정보.UseVisualStyleBackColor = true;
            // 
            // PostNumberSearch
            // 
            this.PostNumberSearch.BackColor = System.Drawing.Color.Black;
            this.PostNumberSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PostNumberSearch.ForeColor = System.Drawing.Color.White;
            this.PostNumberSearch.Location = new System.Drawing.Point(555, 114);
            this.PostNumberSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PostNumberSearch.Name = "PostNumberSearch";
            this.PostNumberSearch.Size = new System.Drawing.Size(63, 22);
            this.PostNumberSearch.TabIndex = 94;
            this.PostNumberSearch.Text = "주소검색";
            this.PostNumberSearch.UseVisualStyleBackColor = false;
            this.PostNumberSearch.Click += new System.EventHandler(this.PostNumberSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 104;
            this.label1.Text = "비밀번호";
            // 
            // EmployeePassword
            // 
            this.EmployeePassword.Location = new System.Drawing.Point(368, 177);
            this.EmployeePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeePassword.Name = "EmployeePassword";
            this.EmployeePassword.Size = new System.Drawing.Size(181, 21);
            this.EmployeePassword.TabIndex = 103;
            // 
            // PostNumberText
            // 
            this.PostNumberText.Location = new System.Drawing.Point(368, 114);
            this.PostNumberText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PostNumberText.Name = "PostNumberText";
            this.PostNumberText.Size = new System.Drawing.Size(57, 21);
            this.PostNumberText.TabIndex = 102;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(576, 85);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(20, 21);
            this.EmployeeID.TabIndex = 99;
            this.EmployeeID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmployeeClear);
            this.groupBox1.Controls.Add(this.EmployeeUpdate);
            this.groupBox1.Controls.Add(this.EmployeeDelete);
            this.groupBox1.Controls.Add(this.EmployeeSearchComboBox);
            this.groupBox1.Controls.Add(this.EmployeeSearch);
            this.groupBox1.Controls.Add(this.EmployeeSearchTextBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(578, 55);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사원관리";
            // 
            // EmployeeClear
            // 
            this.EmployeeClear.BackColor = System.Drawing.Color.Black;
            this.EmployeeClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeClear.ForeColor = System.Drawing.Color.White;
            this.EmployeeClear.Location = new System.Drawing.Point(487, 19);
            this.EmployeeClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeClear.Name = "EmployeeClear";
            this.EmployeeClear.Size = new System.Drawing.Size(60, 22);
            this.EmployeeClear.TabIndex = 93;
            this.EmployeeClear.Text = "취소";
            this.EmployeeClear.UseVisualStyleBackColor = false;
            this.EmployeeClear.Click += new System.EventHandler(this.EmployeeClear_Click);
            // 
            // EmployeeUpdate
            // 
            this.EmployeeUpdate.BackColor = System.Drawing.Color.Black;
            this.EmployeeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeUpdate.ForeColor = System.Drawing.Color.White;
            this.EmployeeUpdate.Location = new System.Drawing.Point(347, 19);
            this.EmployeeUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeUpdate.Name = "EmployeeUpdate";
            this.EmployeeUpdate.Size = new System.Drawing.Size(60, 22);
            this.EmployeeUpdate.TabIndex = 92;
            this.EmployeeUpdate.Text = "수정";
            this.EmployeeUpdate.UseVisualStyleBackColor = false;
            this.EmployeeUpdate.Click += new System.EventHandler(this.EmployeeUpdate_Click);
            // 
            // EmployeeDelete
            // 
            this.EmployeeDelete.BackColor = System.Drawing.Color.Black;
            this.EmployeeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeDelete.ForeColor = System.Drawing.Color.White;
            this.EmployeeDelete.Location = new System.Drawing.Point(412, 19);
            this.EmployeeDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeDelete.Name = "EmployeeDelete";
            this.EmployeeDelete.Size = new System.Drawing.Size(60, 22);
            this.EmployeeDelete.TabIndex = 91;
            this.EmployeeDelete.Text = "삭제";
            this.EmployeeDelete.UseVisualStyleBackColor = false;
            this.EmployeeDelete.Click += new System.EventHandler(this.EmployeeDelete_Click);
            // 
            // EmployeeSearchComboBox
            // 
            this.EmployeeSearchComboBox.FormattingEnabled = true;
            this.EmployeeSearchComboBox.Items.AddRange(new object[] {
            "부서명",
            "사원명",
            "나이"});
            this.EmployeeSearchComboBox.Location = new System.Drawing.Point(31, 19);
            this.EmployeeSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeSearchComboBox.Name = "EmployeeSearchComboBox";
            this.EmployeeSearchComboBox.Size = new System.Drawing.Size(93, 20);
            this.EmployeeSearchComboBox.TabIndex = 87;
            // 
            // EmployeeSearch
            // 
            this.EmployeeSearch.BackColor = System.Drawing.Color.Black;
            this.EmployeeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeSearch.ForeColor = System.Drawing.Color.White;
            this.EmployeeSearch.Location = new System.Drawing.Point(281, 19);
            this.EmployeeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeSearch.Name = "EmployeeSearch";
            this.EmployeeSearch.Size = new System.Drawing.Size(60, 22);
            this.EmployeeSearch.TabIndex = 90;
            this.EmployeeSearch.Text = "검색";
            this.EmployeeSearch.UseVisualStyleBackColor = false;
            this.EmployeeSearch.Click += new System.EventHandler(this.buttonStaffSearch_Click);
            // 
            // EmployeeSearchTextBox
            // 
            this.EmployeeSearchTextBox.Location = new System.Drawing.Point(147, 19);
            this.EmployeeSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeSearchTextBox.Name = "EmployeeSearchTextBox";
            this.EmployeeSearchTextBox.Size = new System.Drawing.Size(118, 21);
            this.EmployeeSearchTextBox.TabIndex = 89;
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.Location = new System.Drawing.Point(368, 86);
            this.EmployeeAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeAge.Name = "EmployeeAge";
            this.EmployeeAge.Size = new System.Drawing.Size(181, 21);
            this.EmployeeAge.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(318, 91);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 50;
            this.label20.Text = "나이";
            // 
            // EmployeeDepartment
            // 
            this.EmployeeDepartment.FormattingEnabled = true;
            this.EmployeeDepartment.Location = new System.Drawing.Point(130, 177);
            this.EmployeeDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeDepartment.Name = "EmployeeDepartment";
            this.EmployeeDepartment.Size = new System.Drawing.Size(122, 20);
            this.EmployeeDepartment.TabIndex = 49;
            // 
            // EmployeeRank
            // 
            this.EmployeeRank.FormattingEnabled = true;
            this.EmployeeRank.Items.AddRange(new object[] {
            "일반 사원",
            "과장",
            "부서장",
            "사장"});
            this.EmployeeRank.Location = new System.Drawing.Point(130, 148);
            this.EmployeeRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeRank.Name = "EmployeeRank";
            this.EmployeeRank.Size = new System.Drawing.Size(122, 20);
            this.EmployeeRank.TabIndex = 48;
            // 
            // EmployeeInsert
            // 
            this.EmployeeInsert.BackColor = System.Drawing.Color.Black;
            this.EmployeeInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeInsert.ForeColor = System.Drawing.Color.White;
            this.EmployeeInsert.Location = new System.Drawing.Point(558, 177);
            this.EmployeeInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeInsert.Name = "EmployeeInsert";
            this.EmployeeInsert.Size = new System.Drawing.Size(60, 25);
            this.EmployeeInsert.TabIndex = 44;
            this.EmployeeInsert.Text = "등록";
            this.EmployeeInsert.UseVisualStyleBackColor = false;
            this.EmployeeInsert.Click += new System.EventHandler(this.EmployeeInsert_Click);
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.Location = new System.Drawing.Point(130, 86);
            this.EmployeeCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.Size = new System.Drawing.Size(122, 21);
            this.EmployeeCode.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 46;
            this.label13.Text = "사원코드";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "부서";
            // 
            // EmployeeDetailedAddress
            // 
            this.EmployeeDetailedAddress.Location = new System.Drawing.Point(368, 144);
            this.EmployeeDetailedAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeDetailedAddress.Name = "EmployeeDetailedAddress";
            this.EmployeeDetailedAddress.Size = new System.Drawing.Size(181, 21);
            this.EmployeeDetailedAddress.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "상세주소";
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.Location = new System.Drawing.Point(430, 114);
            this.EmployeeAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.Size = new System.Drawing.Size(119, 21);
            this.EmployeeAddress.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "주소";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "직급";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(130, 114);
            this.EmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(122, 21);
            this.EmployeeName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "사원명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 1;
            // 
            // 출근부
            // 
            this.출근부.Controls.Add(this.dateTimePicker1);
            this.출근부.Controls.Add(this.AttendanceRead);
            this.출근부.Controls.Add(this.AttendanceInsert);
            this.출근부.Controls.Add(this.label17);
            this.출근부.Controls.Add(this.label19);
            this.출근부.Controls.Add(this.label18);
            this.출근부.Controls.Add(this.label16);
            this.출근부.Controls.Add(this.EndMinute);
            this.출근부.Controls.Add(this.StartMinute);
            this.출근부.Controls.Add(this.EndHour);
            this.출근부.Controls.Add(this.label15);
            this.출근부.Controls.Add(this.StartHour);
            this.출근부.Controls.Add(this.label14);
            this.출근부.Location = new System.Drawing.Point(4, 22);
            this.출근부.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.출근부.Name = "출근부";
            this.출근부.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.출근부.Size = new System.Drawing.Size(624, 212);
            this.출근부.TabIndex = 1;
            this.출근부.Text = "출근부";
            this.출근부.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 43);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // AttendanceRead
            // 
            this.AttendanceRead.BackColor = System.Drawing.Color.Black;
            this.AttendanceRead.ForeColor = System.Drawing.Color.White;
            this.AttendanceRead.Location = new System.Drawing.Point(487, 83);
            this.AttendanceRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceRead.Name = "AttendanceRead";
            this.AttendanceRead.Size = new System.Drawing.Size(82, 54);
            this.AttendanceRead.TabIndex = 9;
            this.AttendanceRead.Text = "출력";
            this.AttendanceRead.UseVisualStyleBackColor = false;
            this.AttendanceRead.Click += new System.EventHandler(this.buttonread_Click);
            // 
            // AttendanceInsert
            // 
            this.AttendanceInsert.BackColor = System.Drawing.Color.Black;
            this.AttendanceInsert.ForeColor = System.Drawing.Color.White;
            this.AttendanceInsert.Location = new System.Drawing.Point(381, 83);
            this.AttendanceInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AttendanceInsert.Name = "AttendanceInsert";
            this.AttendanceInsert.Size = new System.Drawing.Size(82, 54);
            this.AttendanceInsert.TabIndex = 8;
            this.AttendanceInsert.Text = "등록";
            this.AttendanceInsert.UseVisualStyleBackColor = false;
            this.AttendanceInsert.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(197, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 7;
            this.label17.Text = "시";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(309, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 7;
            this.label19.Text = "분";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(309, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 7;
            this.label18.Text = "분";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(197, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 7;
            this.label16.Text = "시";
            // 
            // EndMinute
            // 
            this.EndMinute.Location = new System.Drawing.Point(234, 115);
            this.EndMinute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndMinute.Name = "EndMinute";
            this.EndMinute.Size = new System.Drawing.Size(71, 21);
            this.EndMinute.TabIndex = 5;
            // 
            // StartMinute
            // 
            this.StartMinute.Location = new System.Drawing.Point(234, 84);
            this.StartMinute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartMinute.Name = "StartMinute";
            this.StartMinute.Size = new System.Drawing.Size(71, 21);
            this.StartMinute.TabIndex = 5;
            // 
            // EndHour
            // 
            this.EndHour.Location = new System.Drawing.Point(123, 115);
            this.EndHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndHour.Name = "EndHour";
            this.EndHour.Size = new System.Drawing.Size(71, 21);
            this.EndHour.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "퇴근시간";
            // 
            // StartHour
            // 
            this.StartHour.Location = new System.Drawing.Point(123, 84);
            this.StartHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartHour.Name = "StartHour";
            this.StartHour.Size = new System.Drawing.Size(71, 21);
            this.StartHour.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "출근시간";
            // 
            // 부서관리
            // 
            this.부서관리.Controls.Add(this.groupBox3);
            this.부서관리.Controls.Add(this.groupBox2);
            this.부서관리.Location = new System.Drawing.Point(4, 22);
            this.부서관리.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.부서관리.Name = "부서관리";
            this.부서관리.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.부서관리.Size = new System.Drawing.Size(624, 212);
            this.부서관리.TabIndex = 4;
            this.부서관리.Text = "부서관리";
            this.부서관리.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DepartmentInCancel);
            this.groupBox3.Controls.Add(this.DepartmentSerach);
            this.groupBox3.Controls.Add(this.DepartmentInsert);
            this.groupBox3.Controls.Add(this.DepartmentDelete);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.DepartmentUpdate);
            this.groupBox3.Location = new System.Drawing.Point(29, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(556, 40);
            this.groupBox3.TabIndex = 106;
            this.groupBox3.TabStop = false;
            // 
            // DepartmentInCancel
            // 
            this.DepartmentInCancel.BackColor = System.Drawing.Color.Black;
            this.DepartmentInCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepartmentInCancel.ForeColor = System.Drawing.Color.White;
            this.DepartmentInCancel.Location = new System.Drawing.Point(458, 12);
            this.DepartmentInCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentInCancel.Name = "DepartmentInCancel";
            this.DepartmentInCancel.Size = new System.Drawing.Size(62, 22);
            this.DepartmentInCancel.TabIndex = 105;
            this.DepartmentInCancel.Text = "취소";
            this.DepartmentInCancel.UseVisualStyleBackColor = false;
            this.DepartmentInCancel.Click += new System.EventHandler(this.buttonDeptCancel_Click);
            // 
            // DepartmentSerach
            // 
            this.DepartmentSerach.BackColor = System.Drawing.Color.Black;
            this.DepartmentSerach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepartmentSerach.ForeColor = System.Drawing.Color.White;
            this.DepartmentSerach.Location = new System.Drawing.Point(32, 12);
            this.DepartmentSerach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentSerach.Name = "DepartmentSerach";
            this.DepartmentSerach.Size = new System.Drawing.Size(62, 22);
            this.DepartmentSerach.TabIndex = 106;
            this.DepartmentSerach.Text = "검색";
            this.DepartmentSerach.UseVisualStyleBackColor = false;
            this.DepartmentSerach.Click += new System.EventHandler(this.DepartmentSerach_Click);
            // 
            // DepartmentInsert
            // 
            this.DepartmentInsert.BackColor = System.Drawing.Color.Black;
            this.DepartmentInsert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DepartmentInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepartmentInsert.ForeColor = System.Drawing.Color.White;
            this.DepartmentInsert.Location = new System.Drawing.Point(138, 12);
            this.DepartmentInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentInsert.Name = "DepartmentInsert";
            this.DepartmentInsert.Size = new System.Drawing.Size(62, 22);
            this.DepartmentInsert.TabIndex = 104;
            this.DepartmentInsert.Text = "등록";
            this.DepartmentInsert.UseVisualStyleBackColor = false;
            this.DepartmentInsert.Click += new System.EventHandler(this.DepartmentInsert_Click);
            // 
            // DepartmentDelete
            // 
            this.DepartmentDelete.BackColor = System.Drawing.Color.Black;
            this.DepartmentDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepartmentDelete.ForeColor = System.Drawing.Color.White;
            this.DepartmentDelete.Location = new System.Drawing.Point(352, 12);
            this.DepartmentDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentDelete.Name = "DepartmentDelete";
            this.DepartmentDelete.Size = new System.Drawing.Size(62, 22);
            this.DepartmentDelete.TabIndex = 105;
            this.DepartmentDelete.Text = "삭제";
            this.DepartmentDelete.UseVisualStyleBackColor = false;
            this.DepartmentDelete.Click += new System.EventHandler(this.DepartmentDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 0;
            // 
            // DepartmentUpdate
            // 
            this.DepartmentUpdate.BackColor = System.Drawing.Color.Black;
            this.DepartmentUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DepartmentUpdate.ForeColor = System.Drawing.Color.White;
            this.DepartmentUpdate.Location = new System.Drawing.Point(245, 12);
            this.DepartmentUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentUpdate.Name = "DepartmentUpdate";
            this.DepartmentUpdate.Size = new System.Drawing.Size(62, 22);
            this.DepartmentUpdate.TabIndex = 104;
            this.DepartmentUpdate.Text = "수정";
            this.DepartmentUpdate.UseVisualStyleBackColor = false;
            this.DepartmentUpdate.Click += new System.EventHandler(this.DepartmentUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DepartmentID);
            this.groupBox2.Controls.Add(this.DepartmentHead);
            this.groupBox2.Controls.Add(this.DepartmentCode);
            this.groupBox2.Controls.Add(this.DepartmentName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(29, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(556, 86);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "부서정보";
            // 
            // DepartmentID
            // 
            this.DepartmentID.Location = new System.Drawing.Point(516, 59);
            this.DepartmentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Size = new System.Drawing.Size(28, 21);
            this.DepartmentID.TabIndex = 104;
            this.DepartmentID.Visible = false;
            // 
            // DepartmentHead
            // 
            this.DepartmentHead.Location = new System.Drawing.Point(426, 34);
            this.DepartmentHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentHead.Name = "DepartmentHead";
            this.DepartmentHead.Size = new System.Drawing.Size(118, 21);
            this.DepartmentHead.TabIndex = 103;
            // 
            // DepartmentCode
            // 
            this.DepartmentCode.Location = new System.Drawing.Point(73, 33);
            this.DepartmentCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentCode.Name = "DepartmentCode";
            this.DepartmentCode.Size = new System.Drawing.Size(113, 21);
            this.DepartmentCode.TabIndex = 102;
            // 
            // DepartmentName
            // 
            this.DepartmentName.Location = new System.Drawing.Point(253, 34);
            this.DepartmentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(103, 21);
            this.DepartmentName.TabIndex = 102;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(375, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "부서장";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "부서코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "부서명";
            // 
            // 급여내역서
            // 
            this.급여내역서.Location = new System.Drawing.Point(4, 22);
            this.급여내역서.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.급여내역서.Name = "급여내역서";
            this.급여내역서.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.급여내역서.Size = new System.Drawing.Size(624, 212);
            this.급여내역서.TabIndex = 2;
            this.급여내역서.Text = "급여내역서";
            this.급여내역서.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 323);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(632, 190);
            this.dataGridView1.TabIndex = 93;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewDepartment
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(159, 323);
            this.dataGridViewDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.RowHeadersWidth = 51;
            this.dataGridViewDepartment.RowTemplate.Height = 27;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(632, 190);
            this.dataGridViewDepartment.TabIndex = 94;
            this.dataGridViewDepartment.Visible = false;
            this.dataGridViewDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartment_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 42);
            this.panel1.TabIndex = 95;
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
            // PersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDepartment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PersonnelForm";
            this.Text = "PersonnelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersonnelForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.기본정보.ResumeLayout(false);
            this.기본정보.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.출근부.ResumeLayout(false);
            this.출근부.PerformLayout();
            this.부서관리.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 기본정보;
        private System.Windows.Forms.Button EmployeeInsert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EmployeeAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage 출근부;
        private System.Windows.Forms.TabPage 급여내역서;
        private System.Windows.Forms.ComboBox EmployeeDepartment;
        private System.Windows.Forms.ComboBox EmployeeRank;
        private System.Windows.Forms.TextBox EmployeeCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EmployeeDetailedAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EndMinute;
        private System.Windows.Forms.TextBox StartMinute;
        private System.Windows.Forms.TextBox EndHour;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox StartHour;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox EmployeeAge;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AttendanceRead;
        private System.Windows.Forms.Button AttendanceInsert;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage 부서관리;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EmployeeUpdate;
        private System.Windows.Forms.Button EmployeeDelete;
        private System.Windows.Forms.ComboBox EmployeeSearchComboBox;
        private System.Windows.Forms.Button EmployeeSearch;
        private System.Windows.Forms.TextBox EmployeeSearchTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DepartmentInCancel;
        private System.Windows.Forms.Button DepartmentInsert;
        private System.Windows.Forms.TextBox DepartmentHead;
        private System.Windows.Forms.TextBox DepartmentName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DepartmentSerach;
        private System.Windows.Forms.Button DepartmentDelete;
        private System.Windows.Forms.Button DepartmentUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DepartmentCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DepartmentID;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.TextBox PostNumberText;
        private System.Windows.Forms.Button EmployeeClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeePassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PostNumberSearch;
    }
}