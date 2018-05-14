namespace SMK_Nusantara.Forms
{
    partial class FrManageSchedule
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxDay = new System.Windows.Forms.ComboBox();
            this.DGVSchedule = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxSubject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbxShift = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxTeacher = new System.Windows.Forms.ComboBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Manage Schedule Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ClassID";
            // 
            // CbxClass
            // 
            this.CbxClass.FormattingEnabled = true;
            this.CbxClass.Location = new System.Drawing.Point(215, 51);
            this.CbxClass.Name = "CbxClass";
            this.CbxClass.Size = new System.Drawing.Size(168, 21);
            this.CbxClass.TabIndex = 5;
            this.CbxClass.SelectedIndexChanged += new System.EventHandler(this.CbxClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Day";
            // 
            // CbxDay
            // 
            this.CbxDay.FormattingEnabled = true;
            this.CbxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.CbxDay.Location = new System.Drawing.Point(479, 51);
            this.CbxDay.Name = "CbxDay";
            this.CbxDay.Size = new System.Drawing.Size(168, 21);
            this.CbxDay.TabIndex = 5;
            this.CbxDay.SelectedIndexChanged += new System.EventHandler(this.CbxDay_SelectedIndexChanged);
            // 
            // DGVSchedule
            // 
            this.DGVSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSchedule.Location = new System.Drawing.Point(40, 89);
            this.DGVSchedule.Name = "DGVSchedule";
            this.DGVSchedule.Size = new System.Drawing.Size(695, 179);
            this.DGVSchedule.TabIndex = 6;
            this.DGVSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSchedule_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Subject";
            // 
            // CbxSubject
            // 
            this.CbxSubject.FormattingEnabled = true;
            this.CbxSubject.Location = new System.Drawing.Point(330, 280);
            this.CbxSubject.Name = "CbxSubject";
            this.CbxSubject.Size = new System.Drawing.Size(219, 21);
            this.CbxSubject.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Shift";
            // 
            // CbxShift
            // 
            this.CbxShift.FormattingEnabled = true;
            this.CbxShift.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CbxShift.Location = new System.Drawing.Point(330, 307);
            this.CbxShift.Name = "CbxShift";
            this.CbxShift.Size = new System.Drawing.Size(219, 21);
            this.CbxShift.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Teacher";
            // 
            // CbxTeacher
            // 
            this.CbxTeacher.FormattingEnabled = true;
            this.CbxTeacher.Location = new System.Drawing.Point(330, 334);
            this.CbxTeacher.Name = "CbxTeacher";
            this.CbxTeacher.Size = new System.Drawing.Size(219, 21);
            this.CbxTeacher.TabIndex = 8;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(215, 378);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 9;
            this.BtnInsert.Text = "INSERT";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(554, 378);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(389, 378);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(303, 409);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(474, 409);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(572, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "VIEW SUBJECT NEEDED";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FrManageSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 455);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.CbxTeacher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxShift);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGVSchedule);
            this.Controls.Add(this.CbxDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrManageSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrManageSchedule";
            this.Load += new System.EventHandler(this.FrManageSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxDay;
        private System.Windows.Forms.DataGridView DGVSchedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbxShift;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxTeacher;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button button6;
    }
}