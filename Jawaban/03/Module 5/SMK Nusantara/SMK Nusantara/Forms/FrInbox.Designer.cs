namespace SMK_Nusantara.Forms
{
    partial class FrInbox
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
            this.DGVMessage = new System.Windows.Forms.DataGridView();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMessage
            // 
            this.DGVMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGVMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMessage.Location = new System.Drawing.Point(13, 55);
            this.DGVMessage.Margin = new System.Windows.Forms.Padding(4);
            this.DGVMessage.Name = "DGVMessage";
            this.DGVMessage.Size = new System.Drawing.Size(802, 316);
            this.DGVMessage.TabIndex = 0;
            this.DGVMessage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMessage_CellClick);
            this.DGVMessage.SelectionChanged += new System.EventHandler(this.DGVMessage_SelectionChanged);
            // 
            // TbxSearch
            // 
            this.TbxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxSearch.Location = new System.Drawing.Point(314, 12);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(204, 23);
            this.TbxSearch.TabIndex = 2;
            this.TbxSearch.TextChanged += new System.EventHandler(this.TbxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(653, 378);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(162, 30);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.ForeColor = System.Drawing.Color.White;
            this.BtnView.Location = new System.Drawing.Point(13, 378);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(162, 30);
            this.BtnView.TabIndex = 4;
            this.BtnView.Text = "VIEW MESSAGE";
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // FrInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(835, 420);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxSearch);
            this.Controls.Add(this.DGVMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrInbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrInbox";
            this.Load += new System.EventHandler(this.FrInbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMessage;
        private System.Windows.Forms.TextBox TbxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnView;
    }
}