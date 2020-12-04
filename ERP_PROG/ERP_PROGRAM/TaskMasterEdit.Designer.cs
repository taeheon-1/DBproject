namespace ERP_PROG
{
    partial class TaskMasterEdit
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
            this.listBoxLargeCategory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxMediumCategory = new System.Windows.Forms.ListBox();
            this.listBoxSmallCategory = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEditBigcat = new System.Windows.Forms.TextBox();
            this.textBoxEditMidcat = new System.Windows.Forms.TextBox();
            this.textBoxEditSmallcat = new System.Windows.Forms.TextBox();
            this.buttonMasterAdd = new System.Windows.Forms.Button();
            this.buttonMasterDelete = new System.Windows.Forms.Button();
            this.buttonInputMasterClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLargeCategory
            // 
            this.listBoxLargeCategory.FormattingEnabled = true;
            this.listBoxLargeCategory.ItemHeight = 12;
            this.listBoxLargeCategory.Location = new System.Drawing.Point(143, 129);
            this.listBoxLargeCategory.Name = "listBoxLargeCategory";
            this.listBoxLargeCategory.Size = new System.Drawing.Size(183, 472);
            this.listBoxLargeCategory.TabIndex = 6;
            this.listBoxLargeCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxLargeCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "부서 (대분류)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "업무 유형 (중분류)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "업무 (소분류)";
            // 
            // listBoxMediumCategory
            // 
            this.listBoxMediumCategory.FormattingEnabled = true;
            this.listBoxMediumCategory.ItemHeight = 12;
            this.listBoxMediumCategory.Location = new System.Drawing.Point(373, 129);
            this.listBoxMediumCategory.Name = "listBoxMediumCategory";
            this.listBoxMediumCategory.Size = new System.Drawing.Size(183, 472);
            this.listBoxMediumCategory.TabIndex = 10;
            this.listBoxMediumCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxMediumCategory_SelectedIndexChanged);
            // 
            // listBoxSmallCategory
            // 
            this.listBoxSmallCategory.FormattingEnabled = true;
            this.listBoxSmallCategory.ItemHeight = 12;
            this.listBoxSmallCategory.Location = new System.Drawing.Point(600, 130);
            this.listBoxSmallCategory.Name = "listBoxSmallCategory";
            this.listBoxSmallCategory.Size = new System.Drawing.Size(183, 472);
            this.listBoxSmallCategory.TabIndex = 11;
            this.listBoxSmallCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxSmallCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(825, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "등록/삭제 할 부서 (대분류)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "등록/삭제 할 유형 (중분류)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(825, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "등록/삭제 할 업무 (소분류)";
            // 
            // textBoxEditBigcat
            // 
            this.textBoxEditBigcat.Location = new System.Drawing.Point(827, 278);
            this.textBoxEditBigcat.Name = "textBoxEditBigcat";
            this.textBoxEditBigcat.Size = new System.Drawing.Size(151, 21);
            this.textBoxEditBigcat.TabIndex = 15;
            // 
            // textBoxEditMidcat
            // 
            this.textBoxEditMidcat.Location = new System.Drawing.Point(827, 338);
            this.textBoxEditMidcat.Name = "textBoxEditMidcat";
            this.textBoxEditMidcat.Size = new System.Drawing.Size(151, 21);
            this.textBoxEditMidcat.TabIndex = 16;
            // 
            // textBoxEditSmallcat
            // 
            this.textBoxEditSmallcat.Location = new System.Drawing.Point(827, 398);
            this.textBoxEditSmallcat.Name = "textBoxEditSmallcat";
            this.textBoxEditSmallcat.Size = new System.Drawing.Size(151, 21);
            this.textBoxEditSmallcat.TabIndex = 17;
            // 
            // buttonMasterAdd
            // 
            this.buttonMasterAdd.Location = new System.Drawing.Point(995, 270);
            this.buttonMasterAdd.Name = "buttonMasterAdd";
            this.buttonMasterAdd.Size = new System.Drawing.Size(131, 35);
            this.buttonMasterAdd.TabIndex = 18;
            this.buttonMasterAdd.Text = "입력된 마스터 등록";
            this.buttonMasterAdd.UseVisualStyleBackColor = true;
            this.buttonMasterAdd.Click += new System.EventHandler(this.buttonMasterAdd_Click);
            // 
            // buttonMasterDelete
            // 
            this.buttonMasterDelete.Location = new System.Drawing.Point(995, 330);
            this.buttonMasterDelete.Name = "buttonMasterDelete";
            this.buttonMasterDelete.Size = new System.Drawing.Size(131, 35);
            this.buttonMasterDelete.TabIndex = 19;
            this.buttonMasterDelete.Text = "선택한 마스터 삭제";
            this.buttonMasterDelete.UseVisualStyleBackColor = true;
            this.buttonMasterDelete.Click += new System.EventHandler(this.buttonMasterDelete_Click);
            // 
            // buttonInputMasterClear
            // 
            this.buttonInputMasterClear.Location = new System.Drawing.Point(995, 390);
            this.buttonInputMasterClear.Name = "buttonInputMasterClear";
            this.buttonInputMasterClear.Size = new System.Drawing.Size(131, 35);
            this.buttonInputMasterClear.TabIndex = 20;
            this.buttonInputMasterClear.Text = "입력 내용 지우기";
            this.buttonInputMasterClear.UseVisualStyleBackColor = true;
            this.buttonInputMasterClear.Click += new System.EventHandler(this.buttonInputMasterClear_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 42);
            this.panel1.TabIndex = 21;
            // 
            // TaskMasterEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonInputMasterClear);
            this.Controls.Add(this.buttonMasterDelete);
            this.Controls.Add(this.buttonMasterAdd);
            this.Controls.Add(this.textBoxEditSmallcat);
            this.Controls.Add(this.textBoxEditMidcat);
            this.Controls.Add(this.textBoxEditBigcat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxSmallCategory);
            this.Controls.Add(this.listBoxMediumCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLargeCategory);
            this.Name = "TaskMasterEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkMasterEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskMasterEdit_FormClosed);
            this.Load += new System.EventHandler(this.WorkMasterEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxLargeCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxMediumCategory;
        private System.Windows.Forms.ListBox listBoxSmallCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEditBigcat;
        private System.Windows.Forms.TextBox textBoxEditMidcat;
        private System.Windows.Forms.TextBox textBoxEditSmallcat;
        private System.Windows.Forms.Button buttonMasterAdd;
        private System.Windows.Forms.Button buttonMasterDelete;
        private System.Windows.Forms.Button buttonInputMasterClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}