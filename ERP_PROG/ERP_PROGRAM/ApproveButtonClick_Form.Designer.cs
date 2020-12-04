namespace ERP_PROG
{
    partial class ApproveButtonClick_Form
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_Date = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_number_task = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Date
            // 
            this.textBox_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Date.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Date.Location = new System.Drawing.Point(21, 77);
            this.textBox_Date.Multiline = true;
            this.textBox_Date.Name = "textBox_Date";
            this.textBox_Date.Size = new System.Drawing.Size(407, 34);
            this.textBox_Date.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(133, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_number_task
            // 
            this.textBox_number_task.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_number_task.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_number_task.Location = new System.Drawing.Point(21, 40);
            this.textBox_number_task.Multiline = true;
            this.textBox_number_task.Name = "textBox_number_task";
            this.textBox_number_task.Size = new System.Drawing.Size(157, 34);
            this.textBox_number_task.TabIndex = 2;
            // 
            // ApproveButtonClick_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 184);
            this.Controls.Add(this.textBox_number_task);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Date);
            this.Name = "ApproveButtonClick_Form";
            this.Text = "ERP Program";
            this.Load += new System.EventHandler(this.ApproveButtonClick_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_number_task;
    }
}