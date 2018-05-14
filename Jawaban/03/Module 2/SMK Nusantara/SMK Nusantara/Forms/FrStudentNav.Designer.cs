namespace SMK_Nusantara.Forms
{
    partial class FrStudentNav
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
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnViewScore = new System.Windows.Forms.Button();
            this.BtnSchedule = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LblStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(92, 243);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(248, 55);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.Text = "LOGOUT";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnViewScore
            // 
            this.BtnViewScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnViewScore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnViewScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewScore.ForeColor = System.Drawing.Color.White;
            this.BtnViewScore.Location = new System.Drawing.Point(92, 182);
            this.BtnViewScore.Name = "BtnViewScore";
            this.BtnViewScore.Size = new System.Drawing.Size(248, 55);
            this.BtnViewScore.TabIndex = 3;
            this.BtnViewScore.Text = "VIEW SCORE";
            this.BtnViewScore.UseVisualStyleBackColor = false;
            // 
            // BtnSchedule
            // 
            this.BtnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSchedule.ForeColor = System.Drawing.Color.White;
            this.BtnSchedule.Location = new System.Drawing.Point(92, 121);
            this.BtnSchedule.Name = "BtnSchedule";
            this.BtnSchedule.Size = new System.Drawing.Size(248, 55);
            this.BtnSchedule.TabIndex = 2;
            this.BtnSchedule.Text = "CLASS SCHEDULE";
            this.BtnSchedule.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(92, 60);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(248, 55);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "EDIT PROFILE";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // LblStudent
            // 
            this.LblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStudent.ForeColor = System.Drawing.Color.White;
            this.LblStudent.Location = new System.Drawing.Point(13, 9);
            this.LblStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStudent.Name = "LblStudent";
            this.LblStudent.Size = new System.Drawing.Size(397, 53);
            this.LblStudent.TabIndex = 0;
            this.LblStudent.Text = "Welcome, [StudentName]";
            // 
            // FrStudentNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(423, 334);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnViewScore);
            this.Controls.Add(this.BtnSchedule);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.LblStudent);
            this.Name = "FrStudentNav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Navigation";
            this.Load += new System.EventHandler(this.FrStudentNav_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnViewScore;
        private System.Windows.Forms.Button BtnSchedule;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label LblStudent;
    }
}