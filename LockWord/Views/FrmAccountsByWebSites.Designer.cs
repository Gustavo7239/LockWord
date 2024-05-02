namespace LockWord.Views
{
    partial class FrmAccountsByWebSites
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
            this.PnlAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlAccounts
            // 
            this.PnlAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.PnlAccounts.Controls.Add(this.iconPictureBox1);
            this.PnlAccounts.Controls.Add(this.LblCardsMenu);
            this.PnlAccounts.Location = new System.Drawing.Point(92, 12);
            this.PnlAccounts.Name = "PnlAccounts";
            this.PnlAccounts.Size = new System.Drawing.Size(350, 70);
            this.PnlAccounts.TabIndex = 27;
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
            this.PnlBodyAccounts.ForeColor = System.Drawing.Color.White;
            this.PnlBodyAccounts.Location = new System.Drawing.Point(13, 63);
            this.PnlBodyAccounts.Name = "PnlBodyAccounts";
            this.PnlBodyAccounts.Size = new System.Drawing.Size(1286, 670);
            this.PnlBodyAccounts.TabIndex = 28;
            // 
            // FrmAccountsByWebSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1324, 745);
            this.Controls.Add(this.PnlAccounts);
            this.Controls.Add(this.PnlBodyAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAccountsByWebSites";
            this.Text = "Form1";
            this.PnlAccounts.ResumeLayout(false);
            this.PnlAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAccounts;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label LblCardsMenu;
        private LWPanel PnlBodyAccounts;
    }
}