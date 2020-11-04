namespace ERP_PROG
{
    partial class LoginForm
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.checkBox_ID = new System.Windows.Forms.CheckBox();
            this.checkBox_PW = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(60, 31);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(155, 21);
            this.textBox_ID.TabIndex = 0;
            // 
            // textBox_PW
            // 
            this.textBox_PW.Location = new System.Drawing.Point(60, 70);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.PasswordChar = '*';
            this.textBox_PW.Size = new System.Drawing.Size(155, 21);
            this.textBox_PW.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(246, 28);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 63);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_ID
            // 
            this.checkBox_ID.AutoSize = true;
            this.checkBox_ID.Location = new System.Drawing.Point(60, 107);
            this.checkBox_ID.Name = "checkBox_ID";
            this.checkBox_ID.Size = new System.Drawing.Size(87, 16);
            this.checkBox_ID.TabIndex = 5;
            this.checkBox_ID.Text = "ID 자동입력";
            this.checkBox_ID.UseVisualStyleBackColor = true;
            this.checkBox_ID.CheckedChanged += new System.EventHandler(this.checkBox_ID_CheckedChanged);
            // 
            // checkBox_PW
            // 
            this.checkBox_PW.AutoSize = true;
            this.checkBox_PW.Location = new System.Drawing.Point(60, 129);
            this.checkBox_PW.Name = "checkBox_PW";
            this.checkBox_PW.Size = new System.Drawing.Size(94, 16);
            this.checkBox_PW.TabIndex = 6;
            this.checkBox_PW.Text = "PW 자동입력";
            this.checkBox_PW.UseVisualStyleBackColor = true;
            this.checkBox_PW.CheckedChanged += new System.EventHandler(this.checkBox_PW_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 206);
            this.Controls.Add(this.checkBox_PW);
            this.Controls.Add(this.checkBox_ID);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.textBox_ID);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.CheckBox checkBox_ID;
        private System.Windows.Forms.CheckBox checkBox_PW;
    }
}