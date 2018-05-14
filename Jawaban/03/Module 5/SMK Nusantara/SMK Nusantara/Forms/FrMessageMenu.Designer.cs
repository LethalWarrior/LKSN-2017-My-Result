namespace SMK_Nusantara.Forms
{
    partial class FrMessageMenu
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
            this.BtnInbox = new System.Windows.Forms.Button();
            this.BtnSentItems = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInbox
            // 
            this.BtnInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnInbox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInbox.Location = new System.Drawing.Point(31, 95);
            this.BtnInbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnInbox.Name = "BtnInbox";
            this.BtnInbox.Size = new System.Drawing.Size(296, 65);
            this.BtnInbox.TabIndex = 0;
            this.BtnInbox.Text = "INBOX";
            this.BtnInbox.UseVisualStyleBackColor = false;
            this.BtnInbox.Click += new System.EventHandler(this.BtnInbox_Click);
            // 
            // BtnSentItems
            // 
            this.BtnSentItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnSentItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnSentItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSentItems.Location = new System.Drawing.Point(31, 168);
            this.BtnSentItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSentItems.Name = "BtnSentItems";
            this.BtnSentItems.Size = new System.Drawing.Size(296, 65);
            this.BtnSentItems.TabIndex = 0;
            this.BtnSentItems.Text = "SENT ITEMS";
            this.BtnSentItems.UseVisualStyleBackColor = false;
            this.BtnSentItems.Click += new System.EventHandler(this.BtnSentItems_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNew.Location = new System.Drawing.Point(31, 22);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(296, 65);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "NEW MESSAGE";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(168)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Location = new System.Drawing.Point(31, 240);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(296, 66);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "BACK";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrMessageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(355, 325);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSentItems);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnInbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrMessageMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Menu";
            this.Load += new System.EventHandler(this.FrMessageMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInbox;
        private System.Windows.Forms.Button BtnSentItems;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnBack;
    }
}