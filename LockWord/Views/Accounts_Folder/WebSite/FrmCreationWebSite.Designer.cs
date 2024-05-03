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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreationWebSite));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlConfiguration = new LockWord.LWPanel();
            this.PnlPreview = new LockWord.LWPanel();
            this.PctPhotoWebSite = new System.Windows.Forms.PictureBox();
            this.PnlNameWebSite = new System.Windows.Forms.Panel();
            this.BtnChangeColorBackground = new FontAwesome.Sharp.IconButton();
            this.BtnChangeColorTxt = new FontAwesome.Sharp.IconButton();
            this.BtnAddAccount = new FontAwesome.Sharp.IconButton();
            this.LblNameWebSite = new System.Windows.Forms.Label();
            this.BtnPhotoWebSite = new FontAwesome.Sharp.IconButton();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.LblLink = new System.Windows.Forms.Label();
            this.TxtWebName = new System.Windows.Forms.TextBox();
            this.LblWebName = new System.Windows.Forms.Label();
            this.PnlHead = new LockWord.LWPanel();
            this.LblAddNewWebSite = new System.Windows.Forms.Label();
            this.PnlFooter = new LockWord.LWPanel();
            this.BtnUndo = new FontAwesome.Sharp.IconButton();
            this.BrnCreate = new FontAwesome.Sharp.IconButton();
            this.BtnCancel = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new LockWord.LWButtonActions();
            this.BtnMinimize = new LockWord.LWButtonActions();
            this.BtnMaximize = new LockWord.LWButtonActions();
            this.PnlHeader.SuspendLayout();
            this.PnlConfiguration.SuspendLayout();
            this.PnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctPhotoWebSite)).BeginInit();
            this.PnlNameWebSite.SuspendLayout();
            this.PnlHead.SuspendLayout();
            this.PnlFooter.SuspendLayout();
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
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // PnlConfiguration
            // 
            this.PnlConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.PnlConfiguration.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.PnlConfiguration.BorderColor = System.Drawing.Color.Transparent;
            this.PnlConfiguration.BorderRadius = 15;
            this.PnlConfiguration.BorderSize = 0;
            this.PnlConfiguration.Controls.Add(this.PnlPreview);
            this.PnlConfiguration.Controls.Add(this.BtnPhotoWebSite);
            this.PnlConfiguration.Controls.Add(this.TxtDescription);
            this.PnlConfiguration.Controls.Add(this.LblDescription);
            this.PnlConfiguration.Controls.Add(this.TxtLink);
            this.PnlConfiguration.Controls.Add(this.LblLink);
            this.PnlConfiguration.Controls.Add(this.TxtWebName);
            this.PnlConfiguration.Controls.Add(this.LblWebName);
            this.PnlConfiguration.Controls.Add(this.PnlHead);
            this.PnlConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConfiguration.ForeColor = System.Drawing.Color.White;
            this.PnlConfiguration.Location = new System.Drawing.Point(0, 29);
            this.PnlConfiguration.Name = "PnlConfiguration";
            this.PnlConfiguration.Size = new System.Drawing.Size(563, 558);
            this.PnlConfiguration.TabIndex = 8;
            // 
            // PnlPreview
            // 
            this.PnlPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.PnlPreview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.PnlPreview.BorderColor = System.Drawing.Color.Transparent;
            this.PnlPreview.BorderRadius = 15;
            this.PnlPreview.BorderSize = 0;
            this.PnlPreview.Controls.Add(this.PctPhotoWebSite);
            this.PnlPreview.Controls.Add(this.PnlNameWebSite);
            this.PnlPreview.ForeColor = System.Drawing.Color.White;
            this.PnlPreview.Location = new System.Drawing.Point(129, 344);
            this.PnlPreview.Name = "PnlPreview";
            this.PnlPreview.Size = new System.Drawing.Size(296, 191);
            this.PnlPreview.TabIndex = 46;
            // 
            // PctPhotoWebSite
            // 
            this.PctPhotoWebSite.BackColor = System.Drawing.Color.Transparent;
            this.PctPhotoWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PctPhotoWebSite.Image = ((System.Drawing.Image)(resources.GetObject("PctPhotoWebSite.Image")));
            this.PctPhotoWebSite.Location = new System.Drawing.Point(0, 36);
            this.PctPhotoWebSite.Name = "PctPhotoWebSite";
            this.PctPhotoWebSite.Size = new System.Drawing.Size(296, 155);
            this.PctPhotoWebSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctPhotoWebSite.TabIndex = 3;
            this.PctPhotoWebSite.TabStop = false;
            // 
            // PnlNameWebSite
            // 
            this.PnlNameWebSite.BackColor = System.Drawing.Color.Transparent;
            this.PnlNameWebSite.Controls.Add(this.BtnChangeColorBackground);
            this.PnlNameWebSite.Controls.Add(this.BtnChangeColorTxt);
            this.PnlNameWebSite.Controls.Add(this.BtnAddAccount);
            this.PnlNameWebSite.Controls.Add(this.LblNameWebSite);
            this.PnlNameWebSite.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNameWebSite.Location = new System.Drawing.Point(0, 0);
            this.PnlNameWebSite.Name = "PnlNameWebSite";
            this.PnlNameWebSite.Size = new System.Drawing.Size(296, 36);
            this.PnlNameWebSite.TabIndex = 2;
            // 
            // BtnChangeColorBackground
            // 
            this.BtnChangeColorBackground.BackColor = System.Drawing.Color.Transparent;
            this.BtnChangeColorBackground.FlatAppearance.BorderSize = 0;
            this.BtnChangeColorBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeColorBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeColorBackground.ForeColor = System.Drawing.Color.White;
            this.BtnChangeColorBackground.IconChar = FontAwesome.Sharp.IconChar.FillDrip;
            this.BtnChangeColorBackground.IconColor = System.Drawing.Color.White;
            this.BtnChangeColorBackground.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnChangeColorBackground.IconSize = 30;
            this.BtnChangeColorBackground.Location = new System.Drawing.Point(253, 3);
            this.BtnChangeColorBackground.Name = "BtnChangeColorBackground";
            this.BtnChangeColorBackground.Size = new System.Drawing.Size(30, 30);
            this.BtnChangeColorBackground.TabIndex = 9;
            this.BtnChangeColorBackground.UseVisualStyleBackColor = false;
            this.BtnChangeColorBackground.Click += new System.EventHandler(this.BtnChangeColorBackground_Click);
            // 
            // BtnChangeColorTxt
            // 
            this.BtnChangeColorTxt.BackColor = System.Drawing.Color.Transparent;
            this.BtnChangeColorTxt.FlatAppearance.BorderSize = 0;
            this.BtnChangeColorTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeColorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeColorTxt.ForeColor = System.Drawing.Color.White;
            this.BtnChangeColorTxt.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.BtnChangeColorTxt.IconColor = System.Drawing.Color.White;
            this.BtnChangeColorTxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnChangeColorTxt.IconSize = 30;
            this.BtnChangeColorTxt.Location = new System.Drawing.Point(217, 3);
            this.BtnChangeColorTxt.Name = "BtnChangeColorTxt";
            this.BtnChangeColorTxt.Size = new System.Drawing.Size(30, 30);
            this.BtnChangeColorTxt.TabIndex = 8;
            this.BtnChangeColorTxt.UseVisualStyleBackColor = false;
            this.BtnChangeColorTxt.Click += new System.EventHandler(this.BtnChangeColorTxt_Click);
            // 
            // BtnAddAccount
            // 
            this.BtnAddAccount.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddAccount.FlatAppearance.BorderSize = 0;
            this.BtnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAccount.ForeColor = System.Drawing.Color.White;
            this.BtnAddAccount.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnAddAccount.IconColor = System.Drawing.Color.White;
            this.BtnAddAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddAccount.IconSize = 30;
            this.BtnAddAccount.Location = new System.Drawing.Point(14, 3);
            this.BtnAddAccount.Name = "BtnAddAccount";
            this.BtnAddAccount.Size = new System.Drawing.Size(30, 30);
            this.BtnAddAccount.TabIndex = 7;
            this.BtnAddAccount.UseVisualStyleBackColor = false;
            // 
            // LblNameWebSite
            // 
            this.LblNameWebSite.AutoEllipsis = true;
            this.LblNameWebSite.AutoSize = true;
            this.LblNameWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameWebSite.ForeColor = System.Drawing.Color.White;
            this.LblNameWebSite.Location = new System.Drawing.Point(106, 7);
            this.LblNameWebSite.Name = "LblNameWebSite";
            this.LblNameWebSite.Size = new System.Drawing.Size(82, 26);
            this.LblNameWebSite.TabIndex = 1;
            this.LblNameWebSite.Text = "Google";
            this.LblNameWebSite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPhotoWebSite
            // 
            this.BtnPhotoWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPhotoWebSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BtnPhotoWebSite.FlatAppearance.BorderSize = 0;
            this.BtnPhotoWebSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPhotoWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPhotoWebSite.ForeColor = System.Drawing.Color.White;
            this.BtnPhotoWebSite.IconChar = FontAwesome.Sharp.IconChar.FolderBlank;
            this.BtnPhotoWebSite.IconColor = System.Drawing.Color.White;
            this.BtnPhotoWebSite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPhotoWebSite.IconSize = 30;
            this.BtnPhotoWebSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPhotoWebSite.Location = new System.Drawing.Point(97, 295);
            this.BtnPhotoWebSite.Name = "BtnPhotoWebSite";
            this.BtnPhotoWebSite.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnPhotoWebSite.Size = new System.Drawing.Size(363, 31);
            this.BtnPhotoWebSite.TabIndex = 45;
            this.BtnPhotoWebSite.Text = "Choose one foto for the WebSite";
            this.BtnPhotoWebSite.UseVisualStyleBackColor = false;
            this.BtnPhotoWebSite.Click += new System.EventHandler(this.BtnPhotoWebSite_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtDescription.Location = new System.Drawing.Point(40, 243);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(473, 28);
            this.TxtDescription.TabIndex = 44;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.LblDescription.Location = new System.Drawing.Point(37, 227);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(65, 13);
            this.LblDescription.TabIndex = 43;
            this.LblDescription.Text = "Description";
            // 
            // TxtLink
            // 
            this.TxtLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtLink.Location = new System.Drawing.Point(40, 186);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(473, 28);
            this.TxtLink.TabIndex = 42;
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLink.ForeColor = System.Drawing.SystemColors.Control;
            this.LblLink.Location = new System.Drawing.Point(37, 170);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(27, 13);
            this.LblLink.TabIndex = 41;
            this.LblLink.Text = "Link";
            // 
            // TxtWebName
            // 
            this.TxtWebName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtWebName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtWebName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtWebName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWebName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtWebName.Location = new System.Drawing.Point(40, 130);
            this.TxtWebName.Name = "TxtWebName";
            this.TxtWebName.Size = new System.Drawing.Size(473, 28);
            this.TxtWebName.TabIndex = 40;
            this.TxtWebName.TextChanged += new System.EventHandler(this.TxtWebName_TextChanged);
            // 
            // LblWebName
            // 
            this.LblWebName.AutoSize = true;
            this.LblWebName.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWebName.ForeColor = System.Drawing.SystemColors.Control;
            this.LblWebName.Location = new System.Drawing.Point(37, 114);
            this.LblWebName.Name = "LblWebName";
            this.LblWebName.Size = new System.Drawing.Size(64, 13);
            this.LblWebName.TabIndex = 39;
            this.LblWebName.Text = "Web Name";
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.PnlHead.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.PnlHead.BorderColor = System.Drawing.Color.Transparent;
            this.PnlHead.BorderRadius = 15;
            this.PnlHead.BorderSize = 0;
            this.PnlHead.Controls.Add(this.LblAddNewWebSite);
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.ForeColor = System.Drawing.Color.White;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(563, 75);
            this.PnlHead.TabIndex = 1;
            // 
            // LblAddNewWebSite
            // 
            this.LblAddNewWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddNewWebSite.AutoSize = true;
            this.LblAddNewWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNewWebSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.LblAddNewWebSite.Location = new System.Drawing.Point(134, 22);
            this.LblAddNewWebSite.Name = "LblAddNewWebSite";
            this.LblAddNewWebSite.Size = new System.Drawing.Size(291, 33);
            this.LblAddNewWebSite.TabIndex = 12;
            this.LblAddNewWebSite.Text = "+ Add New WebSite";
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.PnlFooter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.PnlFooter.BorderColor = System.Drawing.Color.Transparent;
            this.PnlFooter.BorderRadius = 15;
            this.PnlFooter.BorderSize = 0;
            this.PnlFooter.Controls.Add(this.BtnUndo);
            this.PnlFooter.Controls.Add(this.BrnCreate);
            this.PnlFooter.Controls.Add(this.BtnCancel);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.ForeColor = System.Drawing.Color.White;
            this.PnlFooter.Location = new System.Drawing.Point(0, 587);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(563, 62);
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
            this.BtnUndo.Location = new System.Drawing.Point(40, 11);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnUndo.Size = new System.Drawing.Size(117, 39);
            this.BtnUndo.TabIndex = 15;
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.UseVisualStyleBackColor = false;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BrnCreate
            // 
            this.BrnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.BrnCreate.FlatAppearance.BorderSize = 0;
            this.BrnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BrnCreate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BrnCreate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BrnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BrnCreate.IconSize = 20;
            this.BrnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrnCreate.Location = new System.Drawing.Point(220, 11);
            this.BrnCreate.Name = "BrnCreate";
            this.BrnCreate.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BrnCreate.Size = new System.Drawing.Size(117, 39);
            this.BrnCreate.TabIndex = 13;
            this.BrnCreate.Text = "Create";
            this.BrnCreate.UseVisualStyleBackColor = false;
            this.BrnCreate.Click += new System.EventHandler(this.BrnCreate_Click);
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
            this.BtnCancel.Location = new System.Drawing.Point(415, 11);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnCancel.Size = new System.Drawing.Size(117, 39);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.BtnClose.Click += new System.EventHandler(this.BtnControlWindowAction_Click);
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
            this.BtnMinimize.Click += new System.EventHandler(this.BtnControlWindowAction_Click);
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
            // FrmCreationWebSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(563, 649);
            this.Controls.Add(this.PnlConfiguration);
            this.Controls.Add(this.PnlFooter);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreationWebSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PnlHeader.ResumeLayout(false);
            this.PnlConfiguration.ResumeLayout(false);
            this.PnlConfiguration.PerformLayout();
            this.PnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctPhotoWebSite)).EndInit();
            this.PnlNameWebSite.ResumeLayout(false);
            this.PnlNameWebSite.PerformLayout();
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            this.PnlFooter.ResumeLayout(false);
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
        private System.Windows.Forms.Label LblAddNewWebSite;
        private System.Windows.Forms.TextBox TxtWebName;
        private System.Windows.Forms.Label LblWebName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.Label LblLink;
        private FontAwesome.Sharp.IconButton BtnPhotoWebSite;
        private LWPanel PnlPreview;
        private System.Windows.Forms.PictureBox PctPhotoWebSite;
        private System.Windows.Forms.Panel PnlNameWebSite;
        private FontAwesome.Sharp.IconButton BtnChangeColorBackground;
        private FontAwesome.Sharp.IconButton BtnChangeColorTxt;
        private FontAwesome.Sharp.IconButton BtnAddAccount;
        private System.Windows.Forms.Label LblNameWebSite;
    }
}