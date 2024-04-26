namespace LockWord
{
    partial class FrmMainLobby
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainLobby));
            this.ImgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.panelTitleBar1 = new System.Windows.Forms.Panel();
            this.BtnMinimize = new LockWord.LWButtonActions();
            this.BtnClose = new LockWord.LWButtonActions();
            this.BtnMaximize = new LockWord.LWButtonActions();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lwPanel3 = new LockWord.LWPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnPasswordGen = new FontAwesome.Sharp.IconButton();
            this.BtnLwMessages = new FontAwesome.Sharp.IconButton();
            this.BtnCreditCards = new FontAwesome.Sharp.IconButton();
            this.BtnAccounts = new FontAwesome.Sharp.IconButton();
            this.BtnAnalytics = new FontAwesome.Sharp.IconButton();
            this.lwPanel1 = new LockWord.LWPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lwPanel2 = new LockWord.LWPanel();
            this.lwPanel4 = new LockWord.LWPanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lwPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.lwPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.lwPanel2.SuspendLayout();
            this.lwPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgLstIcons
            // 
            this.ImgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLstIcons.ImageStream")));
            this.ImgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLstIcons.Images.SetKeyName(0, "IconAnalitics.png");
            this.ImgLstIcons.Images.SetKeyName(1, "IconAllItems.png");
            this.ImgLstIcons.Images.SetKeyName(2, "IconCreditCards.png");
            this.ImgLstIcons.Images.SetKeyName(3, "IconNotes.png");
            // 
            // panelTitleBar1
            // 
            this.panelTitleBar1.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar1.Controls.Add(this.BtnMinimize);
            this.panelTitleBar1.Controls.Add(this.BtnClose);
            this.panelTitleBar1.Controls.Add(this.BtnMaximize);
            this.panelTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar1.Name = "panelTitleBar1";
            this.panelTitleBar1.Size = new System.Drawing.Size(1096, 29);
            this.panelTitleBar1.TabIndex = 3;
            this.panelTitleBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.BtnMinimize.Location = new System.Drawing.Point(1052, 10);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(13, 13);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.Text = "lwButtonActions5";
            this.BtnMinimize.TextColor = System.Drawing.Color.White;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnControlWindowAction_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(1071, 10);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(13, 13);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "lwButtonActions4";
            this.BtnClose.TextColor = System.Drawing.Color.White;
            this.BtnClose.Click += new System.EventHandler(this.BtnControlWindowAction_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BorderColor = System.Drawing.Color.Transparent;
            this.BtnMaximize.BorderRadius = 15;
            this.BtnMaximize.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(88)))));
            this.BtnMaximize.ButtonFont = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnMaximize.ButtonText = "";
            this.BtnMaximize.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(221)))), ((int)(((byte)(138)))));
            this.BtnMaximize.ClickOpacity = 0.1F;
            this.BtnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximize.HoverIcon = null;
            this.BtnMaximize.HoverText = "+";
            this.BtnMaximize.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(25)))));
            this.BtnMaximize.Icon = null;
            this.BtnMaximize.IconOpacity = 1F;
            this.BtnMaximize.Location = new System.Drawing.Point(1033, 10);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(13, 13);
            this.BtnMaximize.TabIndex = 2;
            this.BtnMaximize.Text = "lwButtonActions6";
            this.BtnMaximize.TextColor = System.Drawing.Color.White;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnControlWindowAction_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.lwPanel3);
            this.panel2.Controls.Add(this.lwPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 711);
            this.panel2.TabIndex = 4;
            // 
            // lwPanel3
            // 
            this.lwPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.lwPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.lwPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel3.BorderRadius = 15;
            this.lwPanel3.BorderSize = 0;
            this.lwPanel3.Controls.Add(this.panel5);
            this.lwPanel3.ForeColor = System.Drawing.Color.White;
            this.lwPanel3.Location = new System.Drawing.Point(12, 100);
            this.lwPanel3.Name = "lwPanel3";
            this.lwPanel3.Size = new System.Drawing.Size(317, 599);
            this.lwPanel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnPasswordGen);
            this.panel5.Controls.Add(this.BtnLwMessages);
            this.panel5.Controls.Add(this.BtnCreditCards);
            this.panel5.Controls.Add(this.BtnAccounts);
            this.panel5.Controls.Add(this.BtnAnalytics);
            this.panel5.Location = new System.Drawing.Point(21, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 500);
            this.panel5.TabIndex = 0;
            // 
            // BtnPasswordGen
            // 
            this.BtnPasswordGen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPasswordGen.FlatAppearance.BorderSize = 0;
            this.BtnPasswordGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPasswordGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPasswordGen.ForeColor = System.Drawing.Color.White;
            this.BtnPasswordGen.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.BtnPasswordGen.IconColor = System.Drawing.Color.White;
            this.BtnPasswordGen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPasswordGen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPasswordGen.Location = new System.Drawing.Point(0, 280);
            this.BtnPasswordGen.Name = "BtnPasswordGen";
            this.BtnPasswordGen.Size = new System.Drawing.Size(277, 70);
            this.BtnPasswordGen.TabIndex = 10;
            this.BtnPasswordGen.Text = "LW Generation";
            this.BtnPasswordGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPasswordGen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPasswordGen.UseVisualStyleBackColor = true;
            this.BtnPasswordGen.Click += new System.EventHandler(this.BtnPasswordGen_Click);
            // 
            // BtnLwMessages
            // 
            this.BtnLwMessages.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLwMessages.FlatAppearance.BorderSize = 0;
            this.BtnLwMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLwMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLwMessages.ForeColor = System.Drawing.Color.White;
            this.BtnLwMessages.IconChar = FontAwesome.Sharp.IconChar.EnvelopeSquare;
            this.BtnLwMessages.IconColor = System.Drawing.Color.White;
            this.BtnLwMessages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLwMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLwMessages.Location = new System.Drawing.Point(0, 210);
            this.BtnLwMessages.Name = "BtnLwMessages";
            this.BtnLwMessages.Size = new System.Drawing.Size(277, 70);
            this.BtnLwMessages.TabIndex = 9;
            this.BtnLwMessages.Text = "LW Messages";
            this.BtnLwMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLwMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLwMessages.UseVisualStyleBackColor = true;
            this.BtnLwMessages.Click += new System.EventHandler(this.BtnLwMessages_Click);
            // 
            // BtnCreditCards
            // 
            this.BtnCreditCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCreditCards.FlatAppearance.BorderSize = 0;
            this.BtnCreditCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreditCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreditCards.ForeColor = System.Drawing.Color.White;
            this.BtnCreditCards.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.BtnCreditCards.IconColor = System.Drawing.Color.White;
            this.BtnCreditCards.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCreditCards.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreditCards.Location = new System.Drawing.Point(0, 140);
            this.BtnCreditCards.Name = "BtnCreditCards";
            this.BtnCreditCards.Size = new System.Drawing.Size(277, 70);
            this.BtnCreditCards.TabIndex = 7;
            this.BtnCreditCards.Text = "Bank Accounts";
            this.BtnCreditCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreditCards.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreditCards.UseVisualStyleBackColor = true;
            this.BtnCreditCards.Click += new System.EventHandler(this.BtnCreditCards_Click);
            // 
            // BtnAccounts
            // 
            this.BtnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAccounts.FlatAppearance.BorderSize = 0;
            this.BtnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccounts.ForeColor = System.Drawing.Color.White;
            this.BtnAccounts.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.BtnAccounts.IconColor = System.Drawing.Color.White;
            this.BtnAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAccounts.Location = new System.Drawing.Point(0, 70);
            this.BtnAccounts.Name = "BtnAccounts";
            this.BtnAccounts.Size = new System.Drawing.Size(277, 70);
            this.BtnAccounts.TabIndex = 5;
            this.BtnAccounts.Text = "Accounts";
            this.BtnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAccounts.UseVisualStyleBackColor = true;
            this.BtnAccounts.Click += new System.EventHandler(this.BtnAccounts_Click);
            // 
            // BtnAnalytics
            // 
            this.BtnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAnalytics.FlatAppearance.BorderSize = 0;
            this.BtnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalytics.ForeColor = System.Drawing.Color.White;
            this.BtnAnalytics.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.BtnAnalytics.IconColor = System.Drawing.Color.White;
            this.BtnAnalytics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnalytics.Location = new System.Drawing.Point(0, 0);
            this.BtnAnalytics.Name = "BtnAnalytics";
            this.BtnAnalytics.Size = new System.Drawing.Size(277, 70);
            this.BtnAnalytics.TabIndex = 2;
            this.BtnAnalytics.Text = "Analytics";
            this.BtnAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnalytics.UseVisualStyleBackColor = true;
            this.BtnAnalytics.Click += new System.EventHandler(this.BtnAnalytics_Click);
            // 
            // lwPanel1
            // 
            this.lwPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.lwPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.lwPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel1.BorderRadius = 15;
            this.lwPanel1.BorderSize = 0;
            this.lwPanel1.Controls.Add(this.iconButton1);
            this.lwPanel1.Controls.Add(this.iconButton2);
            this.lwPanel1.Controls.Add(this.pictureBox3);
            this.lwPanel1.Controls.Add(this.label1);
            this.lwPanel1.Controls.Add(this.LblUserName);
            this.lwPanel1.ForeColor = System.Drawing.Color.White;
            this.lwPanel1.Location = new System.Drawing.Point(12, 11);
            this.lwPanel1.Name = "lwPanel1";
            this.lwPanel1.Size = new System.Drawing.Size(317, 83);
            this.lwPanel1.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(236, 28);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(272, 28);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(30, 30);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LockWord.Properties.Resources.ImgPerfilPrueba;
            this.pictureBox3.Location = new System.Drawing.Point(27, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(125)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(85, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Storage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.LblUserName.Location = new System.Drawing.Point(83, 24);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(126, 25);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "Gustavo Cruz";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.lwPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 94);
            this.panel3.TabIndex = 5;
            // 
            // lwPanel2
            // 
            this.lwPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lwPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lwPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lwPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel2.BorderRadius = 15;
            this.lwPanel2.BorderSize = 0;
            this.lwPanel2.Controls.Add(this.lwPanel4);
            this.lwPanel2.ForeColor = System.Drawing.Color.White;
            this.lwPanel2.Location = new System.Drawing.Point(16, 11);
            this.lwPanel2.Name = "lwPanel2";
            this.lwPanel2.Size = new System.Drawing.Size(724, 70);
            this.lwPanel2.TabIndex = 0;
            // 
            // lwPanel4
            // 
            this.lwPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.lwPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.lwPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel4.BorderRadius = 35;
            this.lwPanel4.BorderSize = 0;
            this.lwPanel4.Controls.Add(this.iconPictureBox1);
            this.lwPanel4.Controls.Add(this.textBox1);
            this.lwPanel4.ForeColor = System.Drawing.Color.White;
            this.lwPanel4.Location = new System.Drawing.Point(20, 15);
            this.lwPanel4.Name = "lwPanel4";
            this.lwPanel4.Size = new System.Drawing.Size(352, 40);
            this.lwPanel4.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(16, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.textBox1.Location = new System.Drawing.Point(52, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 19);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.PnlContainer);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(344, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 711);
            this.panel1.TabIndex = 6;
            // 
            // PnlContainer
            // 
            this.PnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.PnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContainer.Location = new System.Drawing.Point(0, 94);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(752, 617);
            this.PnlContainer.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::LockWord.Properties.Resources.ImgLupa;
            this.pictureBox2.Location = new System.Drawing.Point(19, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LockWord.Properties.Resources.ImgPerfilPrueba;
            this.pictureBox1.Location = new System.Drawing.Point(22, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMainLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1096, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainLobby";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockWord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FrmMainLobby_SizeChanged);
            this.panelTitleBar1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.lwPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.lwPanel1.ResumeLayout(false);
            this.lwPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.lwPanel2.ResumeLayout(false);
            this.lwPanel4.ResumeLayout(false);
            this.lwPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ImgLstIcons;
        private LWButtonActions BtnClose;
        private LWButtonActions BtnMaximize;
        private System.Windows.Forms.Panel panelTitleBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private LWPanel lwPanel1;
        private LWPanel lwPanel3;
        private System.Windows.Forms.Panel panel3;
        private LWPanel lwPanel2;
        private LWPanel lwPanel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton BtnAnalytics;
        private FontAwesome.Sharp.IconButton BtnAccounts;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnLwMessages;
        private FontAwesome.Sharp.IconButton BtnCreditCards;
        private FontAwesome.Sharp.IconButton BtnPasswordGen;
        private LWButtonActions BtnMinimize;
    }
}

