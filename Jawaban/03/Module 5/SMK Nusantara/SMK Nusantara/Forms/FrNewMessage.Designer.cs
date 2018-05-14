namespace SMK_Nusantara.Forms
{
    partial class FrNewMessage
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
            this.TbxTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.CbxStudent = new System.Windows.Forms.ComboBox();
            this.CbxTeacher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbxDestination = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbxContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbxTitle
            // 
            this.TbxTitle.Location = new System.Drawing.Point(15, 243);
            this.TbxTitle.Name = "TbxTitle";
            this.TbxTitle.Size = new System.Drawing.Size(204, 23);
            this.TbxTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Content";
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSend.Location = new System.Drawing.Point(343, 486);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(148, 38);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "SEND";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // CbxStudent
            // 
            this.CbxStudent.FormattingEnabled = true;
            this.CbxStudent.Location = new System.Drawing.Point(86, 22);
            this.CbxStudent.Name = "CbxStudent";
            this.CbxStudent.Size = new System.Drawing.Size(304, 24);
            this.CbxStudent.TabIndex = 8;
            this.CbxStudent.SelectedIndexChanged += new System.EventHandler(this.CbxStudent_SelectedIndexChanged);
            // 
            // CbxTeacher
            // 
            this.CbxTeacher.FormattingEnabled = true;
            this.CbxTeacher.Location = new System.Drawing.Point(462, 22);
            this.CbxTeacher.Name = "CbxTeacher";
            this.CbxTeacher.Size = new System.Drawing.Size(312, 24);
            this.CbxTeacher.TabIndex = 7;
            this.CbxTeacher.SelectedIndexChanged += new System.EventHandler(this.CbxTeacher_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teacher";
            // 
            // LbxDestination
            // 
            this.LbxDestination.FormattingEnabled = true;
            this.LbxDestination.ItemHeight = 16;
            this.LbxDestination.Location = new System.Drawing.Point(6, 52);
            this.LbxDestination.Name = "LbxDestination";
            this.LbxDestination.Size = new System.Drawing.Size(768, 132);
            this.LbxDestination.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbxDestination);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CbxTeacher);
            this.groupBox1.Controls.Add(this.CbxStudent);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destination";
            // 
            // TbxContent
            // 
            this.TbxContent.Location = new System.Drawing.Point(15, 313);
            this.TbxContent.Multiline = true;
            this.TbxContent.Name = "TbxContent";
            this.TbxContent.Size = new System.Drawing.Size(780, 167);
            this.TbxContent.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // FrNewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(840, 536);
            this.Controls.Add(this.TbxContent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbxTitle);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrNewMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrNewMessage";
            this.Load += new System.EventHandler(this.FrNewMessage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.ComboBox CbxStudent;
        private System.Windows.Forms.ComboBox CbxTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbxDestination;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbxContent;
        private System.Windows.Forms.Label label1;
    }
}