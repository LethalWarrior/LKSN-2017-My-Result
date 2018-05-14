namespace SMK_Nusantara.Forms
{
    partial class FrManageClass
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
            this.CbxClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVStudent = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVParticipate = new System.Windows.Forms.DataGridView();
            this.BtnInclude = new System.Windows.Forms.Button();
            this.BtnExclude = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVParticipate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student List";
            // 
            // CbxClass
            // 
            this.CbxClass.FormattingEnabled = true;
            this.CbxClass.Location = new System.Drawing.Point(120, 77);
            this.CbxClass.Name = "CbxClass";
            this.CbxClass.Size = new System.Drawing.Size(212, 21);
            this.CbxClass.TabIndex = 1;
            this.CbxClass.SelectedIndexChanged += new System.EventHandler(this.CbxClass_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manage Class Form";
            // 
            // DGVStudent
            // 
            this.DGVStudent.AllowUserToAddRows = false;
            this.DGVStudent.AllowUserToDeleteRows = false;
            this.DGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName});
            this.DGVStudent.Location = new System.Drawing.Point(15, 145);
            this.DGVStudent.Name = "DGVStudent";
            this.DGVStudent.ReadOnly = true;
            this.DGVStudent.Size = new System.Drawing.Size(240, 325);
            this.DGVStudent.TabIndex = 3;
            this.DGVStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStudent_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Participate Student";
            // 
            // DGVParticipate
            // 
            this.DGVParticipate.AllowUserToAddRows = false;
            this.DGVParticipate.AllowUserToDeleteRows = false;
            this.DGVParticipate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVParticipate.Location = new System.Drawing.Point(393, 145);
            this.DGVParticipate.Name = "DGVParticipate";
            this.DGVParticipate.ReadOnly = true;
            this.DGVParticipate.Size = new System.Drawing.Size(240, 325);
            this.DGVParticipate.TabIndex = 3;
            this.DGVParticipate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVParticipate_CellClick);
            // 
            // BtnInclude
            // 
            this.BtnInclude.Location = new System.Drawing.Point(286, 254);
            this.BtnInclude.Name = "BtnInclude";
            this.BtnInclude.Size = new System.Drawing.Size(75, 23);
            this.BtnInclude.TabIndex = 4;
            this.BtnInclude.Text = ">>";
            this.BtnInclude.UseVisualStyleBackColor = true;
            this.BtnInclude.Click += new System.EventHandler(this.BtnInclude_Click);
            // 
            // BtnExclude
            // 
            this.BtnExclude.Location = new System.Drawing.Point(286, 283);
            this.BtnExclude.Name = "BtnExclude";
            this.BtnExclude.Size = new System.Drawing.Size(75, 23);
            this.BtnExclude.TabIndex = 4;
            this.BtnExclude.Text = "<<";
            this.BtnExclude.UseVisualStyleBackColor = true;
            this.BtnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // FrManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 482);
            this.Controls.Add(this.BtnExclude);
            this.Controls.Add(this.BtnInclude);
            this.Controls.Add(this.DGVParticipate);
            this.Controls.Add(this.DGVStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrManageClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrManageClass";
            this.Load += new System.EventHandler(this.FrManageClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVParticipate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVParticipate;
        private System.Windows.Forms.Button BtnInclude;
        private System.Windows.Forms.Button BtnExclude;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
    }
}