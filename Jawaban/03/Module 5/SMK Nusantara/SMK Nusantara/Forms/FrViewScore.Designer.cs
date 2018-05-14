namespace SMK_Nusantara.Forms
{
    partial class FrViewScore
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
            this.LblFinal = new System.Windows.Forms.Label();
            this.LblMid = new System.Windows.Forms.Label();
            this.LblAssignment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFinal
            // 
            this.LblFinal.AutoSize = true;
            this.LblFinal.Location = new System.Drawing.Point(547, 47);
            this.LblFinal.Name = "LblFinal";
            this.LblFinal.Size = new System.Drawing.Size(35, 13);
            this.LblFinal.TabIndex = 10;
            this.LblFinal.Text = "[Final]";
            this.LblFinal.Visible = false;
            // 
            // LblMid
            // 
            this.LblMid.AutoSize = true;
            this.LblMid.Location = new System.Drawing.Point(424, 47);
            this.LblMid.Name = "LblMid";
            this.LblMid.Size = new System.Drawing.Size(30, 13);
            this.LblMid.TabIndex = 11;
            this.LblMid.Text = "[Mid]";
            this.LblMid.Visible = false;
            // 
            // LblAssignment
            // 
            this.LblAssignment.AutoSize = true;
            this.LblAssignment.Location = new System.Drawing.Point(278, 47);
            this.LblAssignment.Name = "LblAssignment";
            this.LblAssignment.Size = new System.Drawing.Size(67, 13);
            this.LblAssignment.TabIndex = 12;
            this.LblAssignment.Text = "[Assignment]";
            this.LblAssignment.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Final Exam : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mid Exam :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Assignment :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "View Score";
            // 
            // DGVStudents
            // 
            this.DGVStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStudents.Location = new System.Drawing.Point(12, 77);
            this.DGVStudents.Name = "DGVStudents";
            this.DGVStudents.Size = new System.Drawing.Size(743, 224);
            this.DGVStudents.TabIndex = 8;
            this.DGVStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStudents_CellClick);
            // 
            // FrViewScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 320);
            this.Controls.Add(this.LblFinal);
            this.Controls.Add(this.LblMid);
            this.Controls.Add(this.LblAssignment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVStudents);
            this.Name = "FrViewScore";
            this.Text = "FrViewScore";
            this.Load += new System.EventHandler(this.FrViewScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFinal;
        private System.Windows.Forms.Label LblMid;
        private System.Windows.Forms.Label LblAssignment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVStudents;
    }
}