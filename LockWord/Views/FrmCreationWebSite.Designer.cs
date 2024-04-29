namespace LockWord.Views
{
    partial class FrmCreationWebSite
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
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.BtnClose = new LockWord.LWButtonActions();
            this.BtnMinimize = new LockWord.LWButtonActions();
            this.BtnMaximize = new LockWord.LWButtonActions();
            this.PnlFooter = new LockWord.LWPanel();
            this.BtnUndo = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BrnCreate = new FontAwesome.Sharp.IconButton();
            this.PnlConfiguration = new LockWord.LWPanel();
            this.BtnAddAccounts = new LockWord.LWButton();
            this.PnlHead = new LockWord.LWPanel();
            this.LblAddNewAccount = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.PnlHeader.SuspendLayout();
            this.PnlFooter.SuspendLayout();
            this.PnlConfiguration.SuspendLayout();
            this.PnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.Black;
            this.PnlHeader.Controls.Add(this.BtnClose);
            this.PnlHeader.Controls.Add(this.BtnMinimize);
            this.PnlHeader.Controls.Add(this.BtnMaximize);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(563, 29);
            this.PnlHeader.TabIndex = 6;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BorderColor = System.Drawing.Color.Transparent;
            this.BtnClose.BorderRadius = 15;
            this.BtnClose.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.BtnClose.ButtonFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ButtonText = "";
            this.BtnClose.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.ClickOpacity = 0.1F;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.HoverIcon = null;
            this.BtnClose.HoverText = "x";
            this.BtnClose.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.BtnClose.Icon = null;
            this.BtnClose.IconOpacity = 1F;
            this.BtnClose.Location = new System.Drawing.Point(538, 10);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(13, 13);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TextColor = System.Drawing.Color.White;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.BorderRadius = 15;
            this.BtnMinimize.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(77)))));
            this.BtnMinimize.ButtonFont = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.ButtonText = "";
            this.BtnMinimize.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(210)))), ((int)(((byte)(130)))));
            this.BtnMinimize.ClickOpacity = 0.1F;
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.HoverIcon = null;
            this.BtnMinimize.HoverText = "--";
            this.BtnMinimize.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(85)))), ((int)(((byte)(24)))));
            this.BtnMinimize.Icon = null;
            this.BtnMinimize.IconOpacity = 1F;
            this.BtnMinimize.Location = new System.Drawing.Point(519, 10);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(13, 13);
            this.BtnMinimize.TabIndex = 1;
            this.BtnMinimize.TextColor = System.Drawing.Color.White;
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BorderColor = System.Drawing.Color.Transparent;
            this.BtnMaximize.BorderRadius = 15;
            this.BtnMaximize.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.BtnMaximize.ButtonFont = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnMaximize.ButtonText = "";
            this.BtnMaximize.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(185)))), ((int)(((byte)(187)))));
            this.BtnMaximize.ClickOpacity = 0.1F;
            this.BtnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximize.HoverIcon = null;
            this.BtnMaximize.HoverText = "+";
            this.BtnMaximize.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.BtnMaximize.Icon = null;
            this.BtnMaximize.IconOpacity = 1F;
            this.BtnMaximize.Location = new System.Drawing.Point(500, 10);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(13, 13);
            this.BtnMaximize.TabIndex = 2;
            this.BtnMaximize.Text = "lwButtonActions6";
            this.BtnMaximize.TextColor = System.Drawing.Color.White;
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.PnlFooter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.PnlFooter.BorderColor = System.Drawing.Color.Transparent;
            this.PnlFooter.BorderRadius = 15;
            this.PnlFooter.BorderSize = 0;
            this.PnlFooter.Controls.Add(this.BtnUndo);
            this.PnlFooter.Controls.Add(this.BtnCancel);
            this.PnlFooter.Controls.Add(this.BrnCreate);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.ForeColor = System.Drawing.Color.White;
            this.PnlFooter.Location = new System.Drawing.Point(0, 637);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(563, 63);
            this.PnlFooter.TabIndex = 7;
            // 
            // BtnUndo
            // 
            this.BtnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BtnUndo.FlatAppearance.BorderSize = 0;
            this.BtnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUndo.ForeColor = System.Drawing.Color.White;
            this.BtnUndo.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.BtnUndo.IconColor = System.Drawing.Color.White;
            this.BtnUndo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUndo.IconSize = 20;
            this.BtnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUndo.Location = new System.Drawing.Point(415, 12);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnUndo.Size = new System.Drawing.Size(117, 39);
            this.BtnUndo.TabIndex = 15;
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.BtnCancel.IconColor = System.Drawing.Color.White;
            this.BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancel.IconSize = 20;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(226, 12);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnCancel.Size = new System.Drawing.Size(117, 39);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BrnCreate
            // 
            this.BrnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BrnCreate.FlatAppearance.BorderSize = 0;
            this.BrnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrnCreate.ForeColor = System.Drawing.Color.White;
            this.BrnCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BrnCreate.IconColor = System.Drawing.Color.White;
            this.BrnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BrnCreate.IconSize = 20;
            this.BrnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrnCreate.Location = new System.Drawing.Point(40, 12);
            this.BrnCreate.Name = "BrnCreate";
            this.BrnCreate.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BrnCreate.Size = new System.Drawing.Size(117, 39);
            this.BrnCreate.TabIndex = 13;
            this.BrnCreate.Text = "Create";
            this.BrnCreate.UseVisualStyleBackColor = false;
            // 
            // PnlConfiguration
            // 
            this.PnlConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.PnlConfiguration.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.PnlConfiguration.BorderColor = System.Drawing.Color.Transparent;
            this.PnlConfiguration.BorderRadius = 15;
            this.PnlConfiguration.BorderSize = 0;
            this.PnlConfiguration.Controls.Add(this.TxtUsername);
            this.PnlConfiguration.Controls.Add(this.LblUsername);
            this.PnlConfiguration.Controls.Add(this.BtnAddAccounts);
            this.PnlConfiguration.Controls.Add(this.PnlHead);
            this.PnlConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConfiguration.ForeColor = System.Drawing.Color.White;
            this.PnlConfiguration.Location = new System.Drawing.Point(0, 29);
            this.PnlConfiguration.Name = "PnlConfiguration";
            this.PnlConfiguration.Size = new System.Drawing.Size(563, 608);
            this.PnlConfiguration.TabIndex = 8;
            // 
            // BtnAddAccounts
            // 
            this.BtnAddAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.BtnAddAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.BtnAddAccounts.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAddAccounts.BorderRadius = 15;
            this.BtnAddAccounts.BorderSize = 0;
            this.BtnAddAccounts.FlatAppearance.BorderSize = 0;
            this.BtnAddAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAccounts.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.BtnAddAccounts.Location = new System.Drawing.Point(129, 391);
            this.BtnAddAccounts.Name = "BtnAddAccounts";
            this.BtnAddAccounts.Size = new System.Drawing.Size(296, 191);
            this.BtnAddAccounts.TabIndex = 20;
            this.BtnAddAccounts.Text = "+";
            this.BtnAddAccounts.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.BtnAddAccounts.UseVisualStyleBackColor = false;
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.PnlHead.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.PnlHead.BorderColor = System.Drawing.Color.Transparent;
            this.PnlHead.BorderRadius = 15;
            this.PnlHead.BorderSize = 0;
            this.PnlHead.Controls.Add(this.LblAddNewAccount);
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.ForeColor = System.Drawing.Color.White;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(563, 75);
            this.PnlHead.TabIndex = 1;
            // 
            // LblAddNewAccount
            // 
            this.LblAddNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddNewAccount.AutoSize = true;
            this.LblAddNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.LblAddNewAccount.Location = new System.Drawing.Point(134, 22);
            this.LblAddNewAccount.Name = "LblAddNewAccount";
            this.LblAddNewAccount.Size = new System.Drawing.Size(291, 33);
            this.LblAddNewAccount.TabIndex = 12;
            this.LblAddNewAccount.Text = "+ Add New WebSite";
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtUsername.Location = new System.Drawing.Point(40, 130);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(345, 28);
            this.TxtUsername.TabIndex = 40;
            this.TxtUsername.Text = "Kolya19";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.LblUsername.Location = new System.Drawing.Point(37, 114);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(58, 13);
            this.LblUsername.TabIndex = 39;
            this.LblUsername.Text = "Username";
            // 
            // FrmCreationWebSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 700);
            this.Controls.Add(this.PnlConfiguration);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreationWebSite";
            this.Text = "Form1";
            this.PnlHeader.ResumeLayout(false);
            this.PnlFooter.ResumeLayout(false);
            this.PnlConfiguration.ResumeLayout(false);
            this.PnlConfiguration.PerformLayout();
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private LWButtonActions BtnClose;
        private LWButtonActions BtnMinimize;
        private LWButtonActions BtnMaximize;
        private LWPanel PnlFooter;
        private FontAwesome.Sharp.IconButton BtnUndo;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BrnCreate;
        private LWPanel PnlConfiguration;
        private LWPanel PnlHead;
        private System.Windows.Forms.Label LblAddNewAccount;
        private LWButton BtnAddAccounts;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblUsername;
    }
}