namespace ERP_PROG
{
    partial class MSG
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
            this.label5 = new System.Windows.Forms.Label();
            this.msgContents = new System.Windows.Forms.Label();
            this.msgTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msgSender = new System.Windows.Forms.Label();
            this.msgReceiver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "보낸 사람";
            // 
            // msgContents
            // 
            this.msgContents.AutoSize = true;
            this.msgContents.Location = new System.Drawing.Point(52, 177);
            this.msgContents.Name = "msgContents";
            this.msgContents.Size = new System.Drawing.Size(29, 12);
            this.msgContents.TabIndex = 13;
            this.msgContents.Text = "내용";
            // 
            // msgTitle
            // 
            this.msgTitle.AutoSize = true;
            this.msgTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.msgTitle.Location = new System.Drawing.Point(52, 59);
            this.msgTitle.Name = "msgTitle";
            this.msgTitle.Size = new System.Drawing.Size(46, 12);
            this.msgTitle.TabIndex = 14;
            this.msgTitle.Text = "제목...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "받는 사람";
            // 
            // msgSender
            // 
            this.msgSender.AutoSize = true;
            this.msgSender.Location = new System.Drawing.Point(134, 101);
            this.msgSender.Name = "msgSender";
            this.msgSender.Size = new System.Drawing.Size(9, 12);
            this.msgSender.TabIndex = 19;
            this.msgSender.Text = ".";
            // 
            // msgReceiver
            // 
            this.msgReceiver.AutoSize = true;
            this.msgReceiver.Location = new System.Drawing.Point(134, 131);
            this.msgReceiver.Name = "msgReceiver";
            this.msgReceiver.Size = new System.Drawing.Size(9, 12);
            this.msgReceiver.TabIndex = 20;
            this.msgReceiver.Text = ".";
            // 
            // MSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.msgReceiver);
            this.Controls.Add(this.msgSender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msgTitle);
            this.Controls.Add(this.msgContents);
            this.Name = "MSG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "msg";
            this.Load += new System.EventHandler(this.msg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label msgContents;
        private System.Windows.Forms.Label msgTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label msgSender;
        private System.Windows.Forms.Label msgReceiver;
    }
}