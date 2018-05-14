namespace SMK_Nusantara.Forms
{
    partial class FrFinalizeSchedule
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
            this.label3 = new System.Windows.Forms.Label();
            this.CbxClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFinalize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSchedule
            // 
            this.DGVSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSchedule.Location = new System.Drawing.Point(12, 96);
            this.DGVSchedule.Name = "DGVSchedule";
            this.DGVSchedule.Size = new System.Drawing.Size(695, 179);
            this.DGVSchedule.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Finalize Schedule Form";
            // 
            // CbxClass
            // 
            this.CbxClass.FormattingEnabled = true;
            this.CbxClass.Location = new System.Drawing.Point(216, 69);
            this.CbxClass.Name = "CbxClass";
            this.CbxClass.Size = new System.Drawing.Size(168, 21);
            this.CbxClass.TabIndex = 10;
            this.CbxClass.SelectedIndexChanged += new System.EventHandler(this.CbxClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ClassID";
            // 
            // BtnFinalize
            // 
            this.BtnFinalize.Location = new System.Drawing.Point(432, 67);
            this.BtnFinalize.Name = "BtnFinalize";
            this.BtnFinalize.Size = new System.Drawing.Size(75, 23);
            this.BtnFinalize.TabIndex = 11;
            this.BtnFinalize.Text = "FINALIZE";
            this.BtnFinalize.UseVisualStyleBackColor = true;
            this.BtnFinalize.Click += new System.EventHandler(this.BtnFinalize_Click);
            // 
            // FrFinalizeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 294);
            this.Controls.Add(this.BtnFinalize);
            this.Controls.Add(this.CbxClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVSchedule);
            this.Controls.Add(this.label3);
            this.Name = "FrFinalizeSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalize Schedule";
            this.Load += new System.EventHandler(this.FrFinalizeSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbxClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFinalize;
    }
}