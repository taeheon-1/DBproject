
namespace ERP_PROG
{
    partial class Evaluation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSelection = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonInpit = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExtendedWork = new System.Windows.Forms.TextBox();
            this.NightWork = new System.Windows.Forms.TextBox();
            this.HolidayWork = new System.Windows.Forms.TextBox();
            this.WorkID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonModify);
            this.groupBox1.Controls.Add(this.buttonInpit);
            this.groupBox1.Controls.Add(this.buttonSelection);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonSelection
            // 
            this.buttonSelection.Location = new System.Drawing.Point(77, 17);
            this.buttonSelection.Name = "buttonSelection";
            this.buttonSelection.Size = new System.Drawing.Size(71, 27);
            this.buttonSelection.TabIndex = 0;
            this.buttonSelection.Text = "조회";
            this.buttonSelection.UseVisualStyleBackColor = true;
            this.buttonSelection.Click += new System.EventHandler(this.buttonSelection_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(724, 232);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonInpit
            // 
            this.buttonInpit.Location = new System.Drawing.Point(328, 17);
            this.buttonInpit.Name = "buttonInpit";
            this.buttonInpit.Size = new System.Drawing.Size(71, 27);
            this.buttonInpit.TabIndex = 1;
            this.buttonInpit.Text = "입력";
            this.buttonInpit.UseVisualStyleBackColor = true;
            this.buttonInpit.Click += new System.EventHandler(this.buttonInpit_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(563, 17);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(71, 27);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "수정";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WorkID);
            this.groupBox2.Controls.Add(this.HolidayWork);
            this.groupBox2.Controls.Add(this.ExtendedWork);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NightWork);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(33, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "수당";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "연장근로";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "야간근로";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "휴일근로";
            // 
            // ExtendedWork
            // 
            this.ExtendedWork.Location = new System.Drawing.Point(101, 24);
            this.ExtendedWork.Multiline = true;
            this.ExtendedWork.Name = "ExtendedWork";
            this.ExtendedWork.Size = new System.Drawing.Size(100, 25);
            this.ExtendedWork.TabIndex = 1;
            // 
            // NightWork
            // 
            this.NightWork.Location = new System.Drawing.Point(328, 24);
            this.NightWork.Multiline = true;
            this.NightWork.Name = "NightWork";
            this.NightWork.Size = new System.Drawing.Size(100, 25);
            this.NightWork.TabIndex = 1;
            // 
            // HolidayWork
            // 
            this.HolidayWork.Location = new System.Drawing.Point(563, 24);
            this.HolidayWork.Multiline = true;
            this.HolidayWork.Name = "HolidayWork";
            this.HolidayWork.Size = new System.Drawing.Size(100, 25);
            this.HolidayWork.TabIndex = 1;
            // 
            // WorkID
            // 
            this.WorkID.Location = new System.Drawing.Point(563, 67);
            this.WorkID.Multiline = true;
            this.WorkID.Name = "WorkID";
            this.WorkID.Size = new System.Drawing.Size(100, 25);
            this.WorkID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "id";
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSelection;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonInpit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ExtendedWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HolidayWork;
        private System.Windows.Forms.TextBox NightWork;
        private System.Windows.Forms.TextBox WorkID;
        private System.Windows.Forms.Label label4;
    }
}