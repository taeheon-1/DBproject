namespace ERP_PROG
{
    partial class ApprovalNormalForm
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
            this.button_approval_list = new ERP_PROG.CircularButton();
            this.button_new_approval = new ERP_PROG.CircularButton();
            this.panel1.SuspendLayout();
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
            this.panel1.TabIndex = 16;
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
            // button_approval_list
            // 
            this.button_approval_list.BackColor = System.Drawing.Color.Black;
            this.button_approval_list.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_approval_list.ForeColor = System.Drawing.Color.White;
            this.button_approval_list.Location = new System.Drawing.Point(644, 204);
            this.button_approval_list.Name = "button_approval_list";
            this.button_approval_list.Size = new System.Drawing.Size(325, 315);
            this.button_approval_list.TabIndex = 29;
            this.button_approval_list.Text = "결재 및 리스트  확인";
            this.button_approval_list.UseVisualStyleBackColor = false;
            this.button_approval_list.Click += new System.EventHandler(this.button_approval_list_Click);
            // 
            // button_new_approval
            // 
            this.button_new_approval.BackColor = System.Drawing.Color.Black;
            this.button_new_approval.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_new_approval.ForeColor = System.Drawing.Color.White;
            this.button_new_approval.Location = new System.Drawing.Point(202, 204);
            this.button_new_approval.Name = "button_new_approval";
            this.button_new_approval.Size = new System.Drawing.Size(325, 315);
            this.button_new_approval.TabIndex = 28;
            this.button_new_approval.Text = "신규 결재 등록";
            this.button_new_approval.UseVisualStyleBackColor = false;
            this.button_new_approval.Click += new System.EventHandler(this.button_new_approval_Click_1);
            // 
            // ApprovalNormalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.button_approval_list);
            this.Controls.Add(this.button_new_approval);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApprovalNormalForm";
            this.Text = "ERP Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApprovalNormalForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private CircularButton button_new_approval;
        private CircularButton button_approval_list;
    }
}