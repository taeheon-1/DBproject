namespace ERP_PROG
{
    partial class List_ApprovalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_NewApprovalForm_approve = new System.Windows.Forms.Button();
            this.button_NewApprovalForm_return = new System.Windows.Forms.Button();
            this.dataGridView_approving = new System.Windows.Forms.DataGridView();
            this.dataGridView_approval_list = new System.Windows.Forms.DataGridView();
            this.dataGridView_approval_completion = new System.Windows.Forms.DataGridView();
            this.dataGridView_approval_progress = new System.Windows.Forms.DataGridView();
            this.textBox_approval_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_approving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_approval_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_approval_completion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_approval_progress)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(143, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "결재중";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(143, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "결재완료";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(570, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "나의 결재업무 리스트";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(570, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "결재 진행사항";
            // 
            // button_NewApprovalForm_approve
            // 
            this.button_NewApprovalForm_approve.BackColor = System.Drawing.Color.Black;
            this.button_NewApprovalForm_approve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_NewApprovalForm_approve.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_NewApprovalForm_approve.ForeColor = System.Drawing.Color.White;
            this.button_NewApprovalForm_approve.Location = new System.Drawing.Point(1009, 122);
            this.button_NewApprovalForm_approve.Name = "button_NewApprovalForm_approve";
            this.button_NewApprovalForm_approve.Size = new System.Drawing.Size(127, 52);
            this.button_NewApprovalForm_approve.TabIndex = 28;
            this.button_NewApprovalForm_approve.Text = "결재하기";
            this.button_NewApprovalForm_approve.UseVisualStyleBackColor = false;
            this.button_NewApprovalForm_approve.Click += new System.EventHandler(this.button_NewApprovalForm_approve_Click);
            // 
            // button_NewApprovalForm_return
            // 
            this.button_NewApprovalForm_return.BackColor = System.Drawing.Color.Black;
            this.button_NewApprovalForm_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_NewApprovalForm_return.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_NewApprovalForm_return.ForeColor = System.Drawing.Color.White;
            this.button_NewApprovalForm_return.Location = new System.Drawing.Point(1009, 188);
            this.button_NewApprovalForm_return.Name = "button_NewApprovalForm_return";
            this.button_NewApprovalForm_return.Size = new System.Drawing.Size(127, 52);
            this.button_NewApprovalForm_return.TabIndex = 29;
            this.button_NewApprovalForm_return.Text = "반려하기";
            this.button_NewApprovalForm_return.UseVisualStyleBackColor = false;
            this.button_NewApprovalForm_return.Click += new System.EventHandler(this.button_NewApprovalForm_return_Click);
            // 
            // dataGridView_approving
            // 
            this.dataGridView_approving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_approving.Location = new System.Drawing.Point(147, 110);
            this.dataGridView_approving.Name = "dataGridView_approving";
            this.dataGridView_approving.RowHeadersWidth = 51;
            this.dataGridView_approving.RowTemplate.Height = 23;
            this.dataGridView_approving.Size = new System.Drawing.Size(398, 242);
            this.dataGridView_approving.TabIndex = 30;
            // 
            // dataGridView_approval_list
            // 
            this.dataGridView_approval_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_approval_list.Location = new System.Drawing.Point(574, 111);
            this.dataGridView_approval_list.Name = "dataGridView_approval_list";
            this.dataGridView_approval_list.RowHeadersWidth = 51;
            this.dataGridView_approval_list.RowTemplate.Height = 23;
            this.dataGridView_approval_list.Size = new System.Drawing.Size(398, 241);
            this.dataGridView_approval_list.TabIndex = 31;
            // 
            // dataGridView_approval_completion
            // 
            this.dataGridView_approval_completion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_approval_completion.Location = new System.Drawing.Point(147, 381);
            this.dataGridView_approval_completion.Name = "dataGridView_approval_completion";
            this.dataGridView_approval_completion.RowHeadersWidth = 51;
            this.dataGridView_approval_completion.RowTemplate.Height = 23;
            this.dataGridView_approval_completion.Size = new System.Drawing.Size(398, 242);
            this.dataGridView_approval_completion.TabIndex = 32;
            // 
            // dataGridView_approval_progress
            // 
            this.dataGridView_approval_progress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_approval_progress.Location = new System.Drawing.Point(574, 381);
            this.dataGridView_approval_progress.Name = "dataGridView_approval_progress";
            this.dataGridView_approval_progress.RowHeadersWidth = 51;
            this.dataGridView_approval_progress.RowTemplate.Height = 23;
            this.dataGridView_approval_progress.Size = new System.Drawing.Size(578, 242);
            this.dataGridView_approval_progress.TabIndex = 33;
            this.dataGridView_approval_progress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_approval_progress_CellContentClick);
            // 
            // textBox_approval_id
            // 
            this.textBox_approval_id.Location = new System.Drawing.Point(1009, 80);
            this.textBox_approval_id.Multiline = true;
            this.textBox_approval_id.Name = "textBox_approval_id";
            this.textBox_approval_id.Size = new System.Drawing.Size(45, 36);
            this.textBox_approval_id.TabIndex = 34;
            this.textBox_approval_id.TextChanged += new System.EventHandler(this.textBox_approval_id_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 42);
            this.panel1.TabIndex = 35;
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
            // List_ApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_approval_id);
            this.Controls.Add(this.dataGridView_approval_progress);
            this.Controls.Add(this.dataGridView_approval_completion);
            this.Controls.Add(this.dataGridView_approval_list);
            this.Controls.Add(this.dataGridView_approving);
            this.Controls.Add(this.button_NewApprovalForm_return);
            this.Controls.Add(this.button_NewApprovalForm_approve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "List_ApprovalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERP Program";
            this.Load += new System.EventHandler(this.List_ApprovalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_approving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_approval_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_approval_completion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_approval_progress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_NewApprovalForm_approve;
        private System.Windows.Forms.Button button_NewApprovalForm_return;
        public System.Windows.Forms.DataGridView dataGridView_approving;
        public System.Windows.Forms.DataGridView dataGridView_approval_list;
        public System.Windows.Forms.DataGridView dataGridView_approval_completion;
        public System.Windows.Forms.DataGridView dataGridView_approval_progress;
        public System.Windows.Forms.TextBox textBox_approval_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}