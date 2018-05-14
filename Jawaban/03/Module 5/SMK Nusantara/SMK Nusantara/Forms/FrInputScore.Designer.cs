namespace SMK_Nusantara.Forms
{
    partial class FrInputScore
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
            this.DGVStudents = new System.Windows.Forms.DataGridView();
            this.BtnEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblAssignment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblMid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVStudents
            // 
            this.DGVStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStudents.Location = new System.Drawing.Point(12, 130);
            this.DGVStudents.Name = "DGVStudents";
            this.DGVStudents.Size = new System.Drawing.Size(743, 224);
            this.DGVStudents.TabIndex = 2;
            this.DGVStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStudents_CellClick);
            this.DGVStudents.Click += new System.EventHandler(this.DGVStudents_Click);
            // 
            // BtnEntry
            // 
            this.BtnEntry.Location = new System.Drawing.Point(339, 360);
            this.BtnEntry.Name = "BtnEntry";
            this.BtnEntry.Size = new System.Drawing.Size(104, 23);
            this.BtnEntry.TabIndex = 3;
            this.BtnEntry.Text = "ENTRY SCORE";
            this.BtnEntry.UseVisualStyleBackColor = true;
            this.BtnEntry.Click += new System.EventHandler(this.BtnEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject";
            // 
            // CbxSubject
            // 
            this.CbxSubject.FormattingEnabled = true;
            this.CbxSubject.Location = new System.Drawing.Point(215, 67);
            this.CbxSubject.Name = "CbxSubject";
            this.CbxSubject.Size = new System.Drawing.Size(148, 21);
            this.CbxSubject.TabIndex = 5;
            this.CbxSubject.SelectedIndexChanged += new System.EventHandler(this.CbxSubject_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class Name";
            // 
            // CbxClass
            // 
            this.CbxClass.FormattingEnabled = true;
            this.CbxClass.Location = new System.Drawing.Point(463, 67);
            this.CbxClass.Name = "CbxClass";
            this.CbxClass.Size = new System.Drawing.Size(146, 21);
            this.CbxClass.TabIndex = 5;
            this.CbxClass.SelectedIndexChanged += new System.EventHandler(this.CbxClass_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Form Input Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assignment :";
            // 
            // LblAssignment
            // 
            this.LblAssignment.AutoSize = true;
            this.LblAssignment.Location = new System.Drawing.Point(278, 100);
            this.LblAssignment.Name = "LblAssignment";
            this.LblAssignment.Size = new System.Drawing.Size(67, 13);
            this.LblAssignment.TabIndex = 7;
            this.LblAssignment.Text = "[Assignment]";
            this.LblAssignment.Visible = false;
            this.LblAssignment.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mid Exam :";
            // 
            // LblMid
            // 
            this.LblMid.AutoSize = true;
            this.LblMid.Location = new System.Drawing.Point(424, 100);
            this.LblMid.Name = "LblMid";
            this.LblMid.Size = new System.Drawing.Size(30, 13);
            this.LblMid.TabIndex = 7;
            this.LblMid.Text = "[Mid]";
            this.LblMid.Visible = false;
            this.LblMid.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Final Exam : ";
            // 
            // LblFinal
            // 
            this.LblFinal.AutoSize = true;
            this.LblFinal.Location = new System.Drawing.Point(547, 100);
            this.LblFinal.Name = "LblFinal";
            this.LblFinal.Size = new System.Drawing.Size(35, 13);
            this.LblFinal.TabIndex = 7;
            this.LblFinal.Text = "[Final]";
            this.LblFinal.Visible = false;
            this.LblFinal.Click += new System.EventHandler(this.label5_Click);
            // 
            // FrInputScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 408);
            this.Controls.Add(this.LblFinal);
            this.Controls.Add(this.LblMid);
            this.Controls.Add(this.LblAssignment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEntry);
            this.Controls.Add(this.DGVStudents);
            this.Name = "FrInputScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Score";
            this.Load += new System.EventHandler(this.FrInputScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVStudents;
        private System.Windows.Forms.Button BtnEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblAssignment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblMid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblFinal;
    }
}