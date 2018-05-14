namespace SMK_Nusantara.Forms
{
    partial class FrViewSchedule
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
            this.DGVSchedule = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxDay = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSchedule
            // 
            this.DGVSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSchedule.Location = new System.Drawing.Point(44, 96);
            this.DGVSchedule.Name = "DGVSchedule";
            this.DGVSchedule.Size = new System.Drawing.Size(619, 150);
            this.DGVSchedule.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "View Schedule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Day";
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
            this.CbxDay.Location = new System.Drawing.Point(185, 52);
            this.CbxDay.Name = "CbxDay";
            this.CbxDay.Size = new System.Drawing.Size(185, 21);
            this.CbxDay.TabIndex = 5;
            this.CbxDay.SelectedIndexChanged += new System.EventHandler(this.CbxDay_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class Name :";
            // 
            // LblClass
            // 
            this.LblClass.AutoSize = true;
            this.LblClass.Location = new System.Drawing.Point(492, 55);
            this.LblClass.Name = "LblClass";
            this.LblClass.Size = new System.Drawing.Size(38, 13);
            this.LblClass.TabIndex = 6;
            this.LblClass.Text = "[Class]";
            // 
            // FrViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 272);
            this.Controls.Add(this.LblClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbxDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVSchedule);
            this.Name = "FrViewSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Schedule";
            this.Load += new System.EventHandler(this.FrViewSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblClass;
    }
}