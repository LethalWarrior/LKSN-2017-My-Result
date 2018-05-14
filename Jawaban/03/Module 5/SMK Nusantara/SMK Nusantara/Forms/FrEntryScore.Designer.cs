namespace SMK_Nusantara.Forms
{
    partial class FrEntryScore
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxAssignment = new System.Windows.Forms.TextBox();
            this.TbxMidExam = new System.Windows.Forms.TextBox();
            this.TbxFinalExam = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assignment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mid Exam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Final Exam";
            // 
            // TbxAssignment
            // 
            this.TbxAssignment.Location = new System.Drawing.Point(112, 88);
            this.TbxAssignment.Name = "TbxAssignment";
            this.TbxAssignment.Size = new System.Drawing.Size(193, 20);
            this.TbxAssignment.TabIndex = 1;
            this.TbxAssignment.TextChanged += new System.EventHandler(this.TbxAssignment_TextChanged);
            // 
            // TbxMidExam
            // 
            this.TbxMidExam.Location = new System.Drawing.Point(112, 114);
            this.TbxMidExam.Name = "TbxMidExam";
            this.TbxMidExam.Size = new System.Drawing.Size(193, 20);
            this.TbxMidExam.TabIndex = 1;
            this.TbxMidExam.TextChanged += new System.EventHandler(this.TbxMidExam_TextChanged);
            // 
            // TbxFinalExam
            // 
            this.TbxFinalExam.Location = new System.Drawing.Point(112, 140);
            this.TbxFinalExam.Name = "TbxFinalExam";
            this.TbxFinalExam.Size = new System.Drawing.Size(193, 20);
            this.TbxFinalExam.TabIndex = 1;
            this.TbxFinalExam.TextChanged += new System.EventHandler(this.TbxFinalExam_TextChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(146, 180);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entry Score";
            // 
            // LblStudent
            // 
            this.LblStudent.Location = new System.Drawing.Point(12, 35);
            this.LblStudent.Name = "LblStudent";
            this.LblStudent.Size = new System.Drawing.Size(318, 38);
            this.LblStudent.TabIndex = 8;
            this.LblStudent.Text = "[Student ID] - [Name]";
            this.LblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrEntryScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 219);
            this.Controls.Add(this.LblStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TbxFinalExam);
            this.Controls.Add(this.TbxMidExam);
            this.Controls.Add(this.TbxAssignment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrEntryScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entry Score";
            this.Load += new System.EventHandler(this.FrEntryScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxAssignment;
        private System.Windows.Forms.TextBox TbxMidExam;
        private System.Windows.Forms.TextBox TbxFinalExam;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblStudent;
    }
}