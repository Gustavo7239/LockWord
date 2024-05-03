namespace LockWord.Views.LWMessages_Folder.SubForms
{
    partial class FrmInbox
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
            this.PnlHeadInbox = new System.Windows.Forms.Panel();
            this.IcnHeadInbox = new FontAwesome.Sharp.IconPictureBox();
            this.LblHeadInbox = new System.Windows.Forms.Label();
            this.PnlUsersInbox = new System.Windows.Forms.Panel();
            this.PnlBtnUsersInbox = new System.Windows.Forms.Panel();
            this.PnlMessageUserInbox = new System.Windows.Forms.Panel();
            this.ListAccountsInbox = new System.Windows.Forms.ListView();
            this.PnlHeadInbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcnHeadInbox)).BeginInit();
            this.PnlUsersInbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeadInbox
            // 
            this.PnlHeadInbox.Controls.Add(this.IcnHeadInbox);
            this.PnlHeadInbox.Controls.Add(this.LblHeadInbox);
            this.PnlHeadInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeadInbox.Location = new System.Drawing.Point(0, 0);
            this.PnlHeadInbox.Name = "PnlHeadInbox";
            this.PnlHeadInbox.Size = new System.Drawing.Size(1255, 65);
            this.PnlHeadInbox.TabIndex = 0;
            // 
            // IcnHeadInbox
            // 
            this.IcnHeadInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.IcnHeadInbox.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.IcnHeadInbox.IconColor = System.Drawing.Color.White;
            this.IcnHeadInbox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnHeadInbox.IconSize = 45;
            this.IcnHeadInbox.Location = new System.Drawing.Point(541, 12);
            this.IcnHeadInbox.Name = "IcnHeadInbox";
            this.IcnHeadInbox.Size = new System.Drawing.Size(45, 45);
            this.IcnHeadInbox.TabIndex = 16;
            this.IcnHeadInbox.TabStop = false;
            // 
            // LblHeadInbox
            // 
            this.LblHeadInbox.AutoSize = true;
            this.LblHeadInbox.BackColor = System.Drawing.Color.Transparent;
            this.LblHeadInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeadInbox.ForeColor = System.Drawing.Color.White;
            this.LblHeadInbox.Location = new System.Drawing.Point(592, 12);
            this.LblHeadInbox.Name = "LblHeadInbox";
            this.LblHeadInbox.Size = new System.Drawing.Size(116, 44);
            this.LblHeadInbox.TabIndex = 15;
            this.LblHeadInbox.Text = "Inbox";
            // 
            // PnlUsersInbox
            // 
            this.PnlUsersInbox.Controls.Add(this.ListAccountsInbox);
            this.PnlUsersInbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlUsersInbox.Location = new System.Drawing.Point(0, 65);
            this.PnlUsersInbox.Name = "PnlUsersInbox";
            this.PnlUsersInbox.Size = new System.Drawing.Size(379, 464);
            this.PnlUsersInbox.TabIndex = 1;
            // 
            // PnlBtnUsersInbox
            // 
            this.PnlBtnUsersInbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBtnUsersInbox.Location = new System.Drawing.Point(379, 449);
            this.PnlBtnUsersInbox.Name = "PnlBtnUsersInbox";
            this.PnlBtnUsersInbox.Size = new System.Drawing.Size(876, 80);
            this.PnlBtnUsersInbox.TabIndex = 0;
            // 
            // PnlMessageUserInbox
            // 
            this.PnlMessageUserInbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMessageUserInbox.Location = new System.Drawing.Point(379, 65);
            this.PnlMessageUserInbox.Name = "PnlMessageUserInbox";
            this.PnlMessageUserInbox.Size = new System.Drawing.Size(876, 384);
            this.PnlMessageUserInbox.TabIndex = 2;
            // 
            // ListAccountsInbox
            // 
            this.ListAccountsInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ListAccountsInbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListAccountsInbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListAccountsInbox.HideSelection = false;
            this.ListAccountsInbox.Location = new System.Drawing.Point(0, 0);
            this.ListAccountsInbox.Name = "ListAccountsInbox";
            this.ListAccountsInbox.Size = new System.Drawing.Size(379, 464);
            this.ListAccountsInbox.TabIndex = 0;
            this.ListAccountsInbox.UseCompatibleStateImageBehavior = false;
            // 
            // FrmInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1255, 529);
            this.Controls.Add(this.PnlMessageUserInbox);
            this.Controls.Add(this.PnlBtnUsersInbox);
            this.Controls.Add(this.PnlUsersInbox);
            this.Controls.Add(this.PnlHeadInbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInbox";
            this.Text = "FrmInbox";
            this.PnlHeadInbox.ResumeLayout(false);
            this.PnlHeadInbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcnHeadInbox)).EndInit();
            this.PnlUsersInbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeadInbox;
        private System.Windows.Forms.Label LblHeadInbox;
        private FontAwesome.Sharp.IconPictureBox IcnHeadInbox;
        private System.Windows.Forms.Panel PnlUsersInbox;
        private System.Windows.Forms.Panel PnlBtnUsersInbox;
        private System.Windows.Forms.Panel PnlMessageUserInbox;
        public System.Windows.Forms.ListView ListAccountsInbox;
    }
}