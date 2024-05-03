namespace LockWord.Views
{
    partial class AcountsTreeMenu
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
            this.PnlAccounts = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.LblCardsMenu = new System.Windows.Forms.Label();
            this.PnlBodyAccounts = new LockWord.LWPanel();
            this.BtnAddAccounts = new LockWord.LWButton();
            this.FlowPnlWebsites = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.PnlBodyAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAccounts
            // 
            this.PnlAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlAccounts.Controls.Add(this.iconPictureBox1);
            this.PnlAccounts.Controls.Add(this.LblCardsMenu);
            this.PnlAccounts.Location = new System.Drawing.Point(27, 12);
            this.PnlAccounts.Name = "PnlAccounts";
            this.PnlAccounts.Size = new System.Drawing.Size(350, 70);
            this.PnlAccounts.TabIndex = 25;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 45;
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 13);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox1.TabIndex = 15;
            this.iconPictureBox1.TabStop = false;
            // 
            // LblCardsMenu
            // 
            this.LblCardsMenu.AutoSize = true;
            this.LblCardsMenu.BackColor = System.Drawing.Color.Transparent;
            this.LblCardsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.LblCardsMenu.Location = new System.Drawing.Point(65, 13);
            this.LblCardsMenu.Name = "LblCardsMenu";
            this.LblCardsMenu.Size = new System.Drawing.Size(183, 44);
            this.LblCardsMenu.TabIndex = 14;
            this.LblCardsMenu.Text = "Accounts";
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
            this.PnlBodyAccounts.Controls.Add(this.FlowPnlWebsites);
            this.PnlBodyAccounts.ForeColor = System.Drawing.Color.White;
            this.PnlBodyAccounts.Location = new System.Drawing.Point(13, 63);
            this.PnlBodyAccounts.Name = "PnlBodyAccounts";
            this.PnlBodyAccounts.Size = new System.Drawing.Size(1286, 670);
            this.PnlBodyAccounts.TabIndex = 26;
            // 
            // BtnAddAccounts
            // 
            this.BtnAddAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.BtnAddAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.BtnAddAccounts.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAddAccounts.BorderRadius = 15;
            this.BtnAddAccounts.BorderSize = 0;
            this.BtnAddAccounts.FlatAppearance.BorderSize = 0;
            this.BtnAddAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAccounts.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.BtnAddAccounts.Location = new System.Drawing.Point(1195, 12);
            this.BtnAddAccounts.Name = "BtnAddAccounts";
            this.BtnAddAccounts.Size = new System.Drawing.Size(81, 70);
            this.BtnAddAccounts.TabIndex = 19;
            this.BtnAddAccounts.Text = "+";
            this.BtnAddAccounts.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.BtnAddAccounts.UseVisualStyleBackColor = false;
            this.BtnAddAccounts.Click += new System.EventHandler(this.BtnAddAccounts_Click);
            // 
            // FlowPnlWebsites
            // 
            this.FlowPnlWebsites.Location = new System.Drawing.Point(28, 34);
            this.FlowPnlWebsites.Name = "FlowPnlWebsites";
            this.FlowPnlWebsites.Size = new System.Drawing.Size(1224, 613);
            this.FlowPnlWebsites.TabIndex = 0;
            // 
            // AcountsTreeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1324, 745);
            this.Controls.Add(this.BtnAddAccounts);
            this.Controls.Add(this.PnlAccounts);
            this.Controls.Add(this.PnlBodyAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcountsTreeMenu";
            this.Text = "AcountsTreeMenu";
            this.PnlAccounts.ResumeLayout(false);
            this.PnlAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.PnlBodyAccounts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlAccounts;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label LblCardsMenu;
        private LWPanel PnlBodyAccounts;
        private LWButton BtnAddAccounts;
        private System.Windows.Forms.FlowLayoutPanel FlowPnlWebsites;
    }
}