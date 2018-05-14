namespace SMK_Nusantara.Forms
{
    partial class FrTeacherNav
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
            this.LblTeacher = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnTeaching = new System.Windows.Forms.Button();
            this.BtnScore = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTeacher
            // 
            this.LblTeacher.ForeColor = System.Drawing.Color.White;
            this.LblTeacher.Location = new System.Drawing.Point(4, 9);
            this.LblTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTeacher.Name = "LblTeacher";
            this.LblTeacher.Size = new System.Drawing.Size(406, 56);
            this.LblTeacher.TabIndex = 0;
            this.LblTeacher.Text = "Welcome, [TeacherName]";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(96, 68);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(248, 55);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "EDIT PROFILE";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnTeaching
            // 
            this.BtnTeaching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnTeaching.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnTeaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeaching.ForeColor = System.Drawing.Color.White;
            this.BtnTeaching.Location = new System.Drawing.Point(96, 129);
            this.BtnTeaching.Name = "BtnTeaching";
            this.BtnTeaching.Size = new System.Drawing.Size(248, 55);
            this.BtnTeaching.TabIndex = 2;
            this.BtnTeaching.Text = "TEACHING SCHEDULE";
            this.BtnTeaching.UseVisualStyleBackColor = false;
            this.BtnTeaching.Click += new System.EventHandler(this.BtnTeaching_Click);
            // 
            // BtnScore
            // 
            this.BtnScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnScore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScore.ForeColor = System.Drawing.Color.White;
            this.BtnScore.Location = new System.Drawing.Point(96, 190);
            this.BtnScore.Name = "BtnScore";
            this.BtnScore.Size = new System.Drawing.Size(248, 55);
            this.BtnScore.TabIndex = 3;
            this.BtnScore.Text = "INPUT SCORE";
            this.BtnScore.UseVisualStyleBackColor = false;
            this.BtnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(96, 251);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(248, 55);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.Text = "LOGOUT";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnMessage
            // 
            this.BtnMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMessage.ForeColor = System.Drawing.Color.White;
            this.BtnMessage.Location = new System.Drawing.Point(311, 9);
            this.BtnMessage.Name = "BtnMessage";
            this.BtnMessage.Size = new System.Drawing.Size(100, 34);
            this.BtnMessage.TabIndex = 5;
            this.BtnMessage.Text = "MESSAGE";
            this.BtnMessage.UseVisualStyleBackColor = false;
            this.BtnMessage.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // FrTeacherNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(423, 334);
            this.Controls.Add(this.BtnMessage);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnScore);
            this.Controls.Add(this.BtnTeaching);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.LblTeacher);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrTeacherNav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Navigation";
            this.Load += new System.EventHandler(this.FrTeacherNav_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTeacher;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnTeaching;
        private System.Windows.Forms.Button BtnScore;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnMessage;
    }
}