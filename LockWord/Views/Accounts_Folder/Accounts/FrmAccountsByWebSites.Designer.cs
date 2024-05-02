namespace LockWord.Views
{
    partial class FrmAccountsWebSite
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
            this.PnlAccountsWebSite = new System.Windows.Forms.Panel();
            this.PctAccountsWebSite = new FontAwesome.Sharp.IconPictureBox();
            this.LblAccountsWebSite = new System.Windows.Forms.Label();
            this.PnlBodyAccounts = new LockWord.LWPanel();
            this.ListAccountsWebSite = new System.Windows.Forms.ListView();
            this.PnlHead = new System.Windows.Forms.Panel();
            this.PnlBack = new LockWord.LWPanel();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.PnlNameWebSite = new LockWord.LWPanel();
            this.LblNameWebSite = new System.Windows.Forms.Label();
            this.PnlAddUser = new LockWord.LWPanel();
            this.BtnAddUser = new FontAwesome.Sharp.IconButton();
            this.PnlAccountsWebSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctAccountsWebSite)).BeginInit();
            this.PnlBodyAccounts.SuspendLayout();
            this.PnlBack.SuspendLayout();
            this.PnlNameWebSite.SuspendLayout();
            this.PnlAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAccountsWebSite
            // 
            this.PnlAccountsWebSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlAccountsWebSite.Controls.Add(this.PnlAddUser);
            this.PnlAccountsWebSite.Controls.Add(this.PctAccountsWebSite);
            this.PnlAccountsWebSite.Controls.Add(this.LblAccountsWebSite);
            this.PnlAccountsWebSite.Location = new System.Drawing.Point(106, 12);
            this.PnlAccountsWebSite.Name = "PnlAccountsWebSite";
            this.PnlAccountsWebSite.Size = new System.Drawing.Size(350, 70);
            this.PnlAccountsWebSite.TabIndex = 27;
            // 
            // PctAccountsWebSite
            // 
            this.PctAccountsWebSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.PctAccountsWebSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.PctAccountsWebSite.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.PctAccountsWebSite.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.PctAccountsWebSite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PctAccountsWebSite.IconSize = 45;
            this.PctAccountsWebSite.Location = new System.Drawing.Point(14, 13);
            this.PctAccountsWebSite.Name = "PctAccountsWebSite";
            this.PctAccountsWebSite.Size = new System.Drawing.Size(45, 45);
            this.PctAccountsWebSite.TabIndex = 15;
            this.PctAccountsWebSite.TabStop = false;
            // 
            // LblAccountsWebSite
            // 
            this.LblAccountsWebSite.AutoSize = true;
            this.LblAccountsWebSite.BackColor = System.Drawing.Color.Transparent;
            this.LblAccountsWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccountsWebSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.LblAccountsWebSite.Location = new System.Drawing.Point(65, 13);
            this.LblAccountsWebSite.Name = "LblAccountsWebSite";
            this.LblAccountsWebSite.Size = new System.Drawing.Size(183, 44);
            this.LblAccountsWebSite.TabIndex = 14;
            this.LblAccountsWebSite.Text = "Accounts";
            // 
            // PnlBodyAccounts
            // 
            this.PnlBodyAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlBodyAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlBodyAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlBodyAccounts.BorderColor = System.Drawing.Color.Transparent;
            this.PnlBodyAccounts.BorderRadius = 30;
            this.PnlBodyAccounts.BorderSize = 0;
            this.PnlBodyAccounts.Controls.Add(this.ListAccountsWebSite);
            this.PnlBodyAccounts.Controls.Add(this.PnlHead);
            this.PnlBodyAccounts.ForeColor = System.Drawing.Color.White;
            this.PnlBodyAccounts.Location = new System.Drawing.Point(13, 63);
            this.PnlBodyAccounts.Name = "PnlBodyAccounts";
            this.PnlBodyAccounts.Size = new System.Drawing.Size(1286, 670);
            this.PnlBodyAccounts.TabIndex = 28;
            // 
            // ListAccountsWebSite
            // 
            this.ListAccountsWebSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ListAccountsWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListAccountsWebSite.HideSelection = false;
            this.ListAccountsWebSite.Location = new System.Drawing.Point(0, 30);
            this.ListAccountsWebSite.Name = "ListAccountsWebSite";
            this.ListAccountsWebSite.Size = new System.Drawing.Size(1286, 640);
            this.ListAccountsWebSite.TabIndex = 1;
            this.ListAccountsWebSite.UseCompatibleStateImageBehavior = false;
            // 
            // PnlHead
            // 
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(1286, 30);
            this.PnlHead.TabIndex = 0;
            // 
            // PnlBack
            // 
            this.PnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlBack.BorderColor = System.Drawing.Color.Transparent;
            this.PnlBack.BorderRadius = 30;
            this.PnlBack.BorderSize = 0;
            this.PnlBack.Controls.Add(this.BtnBack);
            this.PnlBack.ForeColor = System.Drawing.Color.White;
            this.PnlBack.Location = new System.Drawing.Point(26, 12);
            this.PnlBack.Name = "PnlBack";
            this.PnlBack.Size = new System.Drawing.Size(74, 70);
            this.PnlBack.TabIndex = 29;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.BtnBack.IconColor = System.Drawing.Color.White;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.IconSize = 50;
            this.BtnBack.Location = new System.Drawing.Point(4, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(67, 63);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.UseVisualStyleBackColor = false;
            // 
            // PnlNameWebSite
            // 
            this.PnlNameWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlNameWebSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlNameWebSite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlNameWebSite.BorderColor = System.Drawing.Color.Transparent;
            this.PnlNameWebSite.BorderRadius = 30;
            this.PnlNameWebSite.BorderSize = 0;
            this.PnlNameWebSite.Controls.Add(this.LblNameWebSite);
            this.PnlNameWebSite.ForeColor = System.Drawing.Color.White;
            this.PnlNameWebSite.Location = new System.Drawing.Point(1076, 12);
            this.PnlNameWebSite.Name = "PnlNameWebSite";
            this.PnlNameWebSite.Size = new System.Drawing.Size(194, 70);
            this.PnlNameWebSite.TabIndex = 30;
            // 
            // LblNameWebSite
            // 
            this.LblNameWebSite.AutoSize = true;
            this.LblNameWebSite.BackColor = System.Drawing.Color.Transparent;
            this.LblNameWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameWebSite.ForeColor = System.Drawing.Color.White;
            this.LblNameWebSite.Location = new System.Drawing.Point(23, 13);
            this.LblNameWebSite.Name = "LblNameWebSite";
            this.LblNameWebSite.Size = new System.Drawing.Size(148, 44);
            this.LblNameWebSite.TabIndex = 16;
            this.LblNameWebSite.Text = "Google";
            // 
            // PnlAddUser
            // 
            this.PnlAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlAddUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlAddUser.BorderColor = System.Drawing.Color.Transparent;
            this.PnlAddUser.BorderRadius = 30;
            this.PnlAddUser.BorderSize = 0;
            this.PnlAddUser.Controls.Add(this.BtnAddUser);
            this.PnlAddUser.ForeColor = System.Drawing.Color.White;
            this.PnlAddUser.Location = new System.Drawing.Point(263, 0);
            this.PnlAddUser.Name = "PnlAddUser";
            this.PnlAddUser.Size = new System.Drawing.Size(74, 70);
            this.PnlAddUser.TabIndex = 30;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddUser.FlatAppearance.BorderSize = 0;
            this.BtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.ForeColor = System.Drawing.Color.White;
            this.BtnAddUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnAddUser.IconColor = System.Drawing.Color.White;
            this.BtnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddUser.IconSize = 50;
            this.BtnAddUser.Location = new System.Drawing.Point(4, 4);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(67, 63);
            this.BtnAddUser.TabIndex = 6;
            this.BtnAddUser.UseVisualStyleBackColor = false;
            // 
            // FrmAccountsWebSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1324, 745);
            this.Controls.Add(this.PnlNameWebSite);
            this.Controls.Add(this.PnlBack);
            this.Controls.Add(this.PnlAccountsWebSite);
            this.Controls.Add(this.PnlBodyAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAccountsWebSite";
            this.Text = "Form1";
            this.PnlAccountsWebSite.ResumeLayout(false);
            this.PnlAccountsWebSite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctAccountsWebSite)).EndInit();
            this.PnlBodyAccounts.ResumeLayout(false);
            this.PnlBack.ResumeLayout(false);
            this.PnlNameWebSite.ResumeLayout(false);
            this.PnlNameWebSite.PerformLayout();
            this.PnlAddUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAccountsWebSite;
        private FontAwesome.Sharp.IconPictureBox PctAccountsWebSite;
        private System.Windows.Forms.Label LblAccountsWebSite;
        private LWPanel PnlBodyAccounts;
        private LWPanel PnlBack;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.ListView ListAccountsWebSite;
        private System.Windows.Forms.Panel PnlHead;
        private LWPanel PnlNameWebSite;
        private System.Windows.Forms.Label LblNameWebSite;
        private LWPanel PnlAddUser;
        private FontAwesome.Sharp.IconButton BtnAddUser;
    }
}