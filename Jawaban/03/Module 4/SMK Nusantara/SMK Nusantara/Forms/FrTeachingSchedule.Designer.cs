namespace SMK_Nusantara.Forms
{
    partial class FrTeachingSchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGVStudent = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSchedule
            // 
            this.DGVSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSchedule.Location = new System.Drawing.Point(45, 62);
            this.DGVSchedule.Name = "DGVSchedule";
            this.DGVSchedule.Size = new System.Drawing.Size(619, 150);
            this.DGVSchedule.TabIndex = 0;
            this.DGVSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSchedule_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teaching Schedule";
            // 
            // DGVStudent
            // 
            this.DGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStudent.Location = new System.Drawing.Point(168, 275);
            this.DGVStudent.Name = "DGVStudent";
            this.DGVStudent.Size = new System.Drawing.Size(383, 235);
            this.DGVStudent.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student List";
            // 
            // FrTeachingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVStudent);
            this.Controls.Add(this.DGVSchedule);
            this.Name = "FrTeachingSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teaching Schedule";
            this.Load += new System.EventHandler(this.FrTeachingSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVStudent;
        private System.Windows.Forms.Label label2;
    }
}