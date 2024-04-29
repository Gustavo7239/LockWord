namespace LockWord.Views
{
    partial class FrmCreationCards
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
            this.PnlBody = new System.Windows.Forms.Panel();
            this.PnlCreditCard = new System.Windows.Forms.Panel();
            this.PnlCreditCardView = new System.Windows.Forms.Panel();
            this.PnlForm = new System.Windows.Forms.Panel();
            this.BtnLeftRightSliderCredit1 = new FontAwesome.Sharp.IconButton();
            this.LblChangeColorCredit1 = new System.Windows.Forms.Label();
            this.BtnCrossCVCCredit1 = new FontAwesome.Sharp.IconButton();
            this.LblTypeOfCardCredit1 = new System.Windows.Forms.Label();
            this.BtnTypeOfCardCredit1 = new FontAwesome.Sharp.IconButton();
            this.LblCountryCredit1 = new System.Windows.Forms.Label();
            this.LblCVCCredit1 = new System.Windows.Forms.Label();
            this.LblMounthYearTxtCredit1 = new System.Windows.Forms.Label();
            this.LblBankNameCredit1 = new System.Windows.Forms.Label();
            this.LblBankAccountCredit1 = new System.Windows.Forms.Label();
            this.LblFullOwnerNameCredit1 = new System.Windows.Forms.Label();
            this.BtnChangeColorCredit1 = new FontAwesome.Sharp.IconButton();
            this.PctCreditCard = new FontAwesome.Sharp.IconPictureBox();
            this.PnlHead = new System.Windows.Forms.Panel();
            this.LblAddNewCard = new System.Windows.Forms.Label();
            this.BtnOptionDebitCard = new FontAwesome.Sharp.IconButton();
            this.BtnOptionCreditCard = new FontAwesome.Sharp.IconButton();
            this.PnlPreViewDesigneCreditCard1 = new LockWord.LWPanel();
            this.PctCreditCard1 = new FontAwesome.Sharp.IconPictureBox();
            this.LblCVCTxtCreditCard1 = new System.Windows.Forms.Label();
            this.LblMounthYearTxtCreditCard1 = new System.Windows.Forms.Label();
            this.LblCVCCreditCard1 = new System.Windows.Forms.Label();
            this.LblMounthYearCreditCard1 = new System.Windows.Forms.Label();
            this.PctTypeOfCardCreditCard1 = new FontAwesome.Sharp.IconPictureBox();
            this.LblFullOwnerNameCreditCard1 = new System.Windows.Forms.Label();
            this.LblCountryCreditCard1 = new System.Windows.Forms.Label();
            this.PctCountryCreditCard1 = new FontAwesome.Sharp.IconPictureBox();
            this.LblBankNameCreditCard1 = new System.Windows.Forms.Label();
            this.PctBankCreditCard1 = new FontAwesome.Sharp.IconPictureBox();
            this.LblBankAccountCreditCard1 = new System.Windows.Forms.Label();
            this.PctChipCreditCard1 = new FontAwesome.Sharp.IconPictureBox();
            this.lwPanel6 = new LockWord.LWPanel();
            this.TxtCountryCredit1 = new System.Windows.Forms.TextBox();
            this.lwPanel5 = new LockWord.LWPanel();
            this.TxtCVCCredit1 = new System.Windows.Forms.TextBox();
            this.lwPanel4 = new LockWord.LWPanel();
            this.TxtMounthYearCredit1 = new System.Windows.Forms.TextBox();
            this.lwPanel3 = new LockWord.LWPanel();
            this.TxtBankNameCredit1 = new System.Windows.Forms.TextBox();
            this.lwPanel2 = new LockWord.LWPanel();
            this.TxtBankAccountCredit1 = new System.Windows.Forms.TextBox();
            this.lwPanel1 = new LockWord.LWPanel();
            this.TxtFullOwnerNameCredit1 = new System.Windows.Forms.TextBox();
            this.BtnClose = new LockWord.LWButtonActions();
            this.BtnMinimize = new LockWord.LWButtonActions();
            this.BtnMaximize = new LockWord.LWButtonActions();
            this.PnlHeader.SuspendLayout();
            this.PnlBody.SuspendLayout();
            this.PnlCreditCard.SuspendLayout();
            this.PnlCreditCardView.SuspendLayout();
            this.PnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctCreditCard)).BeginInit();
            this.PnlHead.SuspendLayout();
            this.PnlPreViewDesigneCreditCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctCreditCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTypeOfCardCreditCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCountryCreditCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBankCreditCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctChipCreditCard1)).BeginInit();
            this.lwPanel6.SuspendLayout();
            this.lwPanel5.SuspendLayout();
            this.lwPanel4.SuspendLayout();
            this.lwPanel3.SuspendLayout();
            this.lwPanel2.SuspendLayout();
            this.lwPanel1.SuspendLayout();
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
            this.PnlHeader.Size = new System.Drawing.Size(959, 29);
            this.PnlHeader.TabIndex = 4;
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // PnlBody
            // 
            this.PnlBody.Controls.Add(this.PnlCreditCard);
            this.PnlBody.Controls.Add(this.PnlHead);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 29);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.Size = new System.Drawing.Size(959, 479);
            this.PnlBody.TabIndex = 5;
            // 
            // PnlCreditCard
            // 
            this.PnlCreditCard.Controls.Add(this.PnlCreditCardView);
            this.PnlCreditCard.Controls.Add(this.PnlForm);
            this.PnlCreditCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCreditCard.Location = new System.Drawing.Point(0, 120);
            this.PnlCreditCard.Name = "PnlCreditCard";
            this.PnlCreditCard.Size = new System.Drawing.Size(959, 359);
            this.PnlCreditCard.TabIndex = 1;
            // 
            // PnlCreditCardView
            // 
            this.PnlCreditCardView.Controls.Add(this.PnlPreViewDesigneCreditCard1);
            this.PnlCreditCardView.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlCreditCardView.Location = new System.Drawing.Point(493, 0);
            this.PnlCreditCardView.Name = "PnlCreditCardView";
            this.PnlCreditCardView.Size = new System.Drawing.Size(469, 359);
            this.PnlCreditCardView.TabIndex = 31;
            this.PnlCreditCardView.Visible = false;
            // 
            // PnlForm
            // 
            this.PnlForm.Controls.Add(this.BtnLeftRightSliderCredit1);
            this.PnlForm.Controls.Add(this.LblChangeColorCredit1);
            this.PnlForm.Controls.Add(this.BtnCrossCVCCredit1);
            this.PnlForm.Controls.Add(this.LblTypeOfCardCredit1);
            this.PnlForm.Controls.Add(this.BtnTypeOfCardCredit1);
            this.PnlForm.Controls.Add(this.lwPanel6);
            this.PnlForm.Controls.Add(this.LblCountryCredit1);
            this.PnlForm.Controls.Add(this.lwPanel5);
            this.PnlForm.Controls.Add(this.LblCVCCredit1);
            this.PnlForm.Controls.Add(this.lwPanel4);
            this.PnlForm.Controls.Add(this.LblMounthYearTxtCredit1);
            this.PnlForm.Controls.Add(this.lwPanel3);
            this.PnlForm.Controls.Add(this.LblBankNameCredit1);
            this.PnlForm.Controls.Add(this.lwPanel2);
            this.PnlForm.Controls.Add(this.LblBankAccountCredit1);
            this.PnlForm.Controls.Add(this.lwPanel1);
            this.PnlForm.Controls.Add(this.LblFullOwnerNameCredit1);
            this.PnlForm.Controls.Add(this.BtnChangeColorCredit1);
            this.PnlForm.Controls.Add(this.PctCreditCard);
            this.PnlForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlForm.Location = new System.Drawing.Point(0, 0);
            this.PnlForm.Name = "PnlForm";
            this.PnlForm.Size = new System.Drawing.Size(493, 359);
            this.PnlForm.TabIndex = 30;
            // 
            // BtnLeftRightSliderCredit1
            // 
            this.BtnLeftRightSliderCredit1.BackColor = System.Drawing.Color.Transparent;
            this.BtnLeftRightSliderCredit1.FlatAppearance.BorderSize = 0;
            this.BtnLeftRightSliderCredit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeftRightSliderCredit1.ForeColor = System.Drawing.Color.White;
            this.BtnLeftRightSliderCredit1.IconChar = FontAwesome.Sharp.IconChar.LeftRight;
            this.BtnLeftRightSliderCredit1.IconColor = System.Drawing.Color.White;
            this.BtnLeftRightSliderCredit1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLeftRightSliderCredit1.IconSize = 50;
            this.BtnLeftRightSliderCredit1.Location = new System.Drawing.Point(412, 146);
            this.BtnLeftRightSliderCredit1.Name = "BtnLeftRightSliderCredit1";
            this.BtnLeftRightSliderCredit1.Size = new System.Drawing.Size(50, 50);
            this.BtnLeftRightSliderCredit1.TabIndex = 49;
            this.BtnLeftRightSliderCredit1.UseVisualStyleBackColor = false;
            this.BtnLeftRightSliderCredit1.Click += new System.EventHandler(this.BtnLeftRightSliderCredit1_Click);
            // 
            // LblChangeColorCredit1
            // 
            this.LblChangeColorCredit1.AutoSize = true;
            this.LblChangeColorCredit1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangeColorCredit1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblChangeColorCredit1.Location = new System.Drawing.Point(397, 10);
            this.LblChangeColorCredit1.Name = "LblChangeColorCredit1";
            this.LblChangeColorCredit1.Size = new System.Drawing.Size(76, 13);
            this.LblChangeColorCredit1.TabIndex = 48;
            this.LblChangeColorCredit1.Text = "Change Color";
            // 
            // BtnCrossCVCCredit1
            // 
            this.BtnCrossCVCCredit1.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrossCVCCredit1.FlatAppearance.BorderSize = 0;
            this.BtnCrossCVCCredit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrossCVCCredit1.ForeColor = System.Drawing.Color.White;
            this.BtnCrossCVCCredit1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnCrossCVCCredit1.IconColor = System.Drawing.Color.White;
            this.BtnCrossCVCCredit1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCrossCVCCredit1.IconSize = 24;
            this.BtnCrossCVCCredit1.Location = new System.Drawing.Point(207, 208);
            this.BtnCrossCVCCredit1.Name = "BtnCrossCVCCredit1";
            this.BtnCrossCVCCredit1.Size = new System.Drawing.Size(24, 24);
            this.BtnCrossCVCCredit1.TabIndex = 47;
            this.BtnCrossCVCCredit1.Text = "iconButton1";
            this.BtnCrossCVCCredit1.UseVisualStyleBackColor = false;
            this.BtnCrossCVCCredit1.Click += new System.EventHandler(this.BtnCrossCVCCredit1_Click);
            // 
            // LblTypeOfCardCredit1
            // 
            this.LblTypeOfCardCredit1.AutoSize = true;
            this.LblTypeOfCardCredit1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTypeOfCardCredit1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTypeOfCardCredit1.Location = new System.Drawing.Point(328, 247);
            this.LblTypeOfCardCredit1.Name = "LblTypeOfCardCredit1";
            this.LblTypeOfCardCredit1.Size = new System.Drawing.Size(73, 13);
            this.LblTypeOfCardCredit1.TabIndex = 46;
            this.LblTypeOfCardCredit1.Text = "Type Of Card";
            // 
            // BtnTypeOfCardCredit1
            // 
            this.BtnTypeOfCardCredit1.BackColor = System.Drawing.Color.Transparent;
            this.BtnTypeOfCardCredit1.FlatAppearance.BorderSize = 0;
            this.BtnTypeOfCardCredit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTypeOfCardCredit1.ForeColor = System.Drawing.Color.White;
            this.BtnTypeOfCardCredit1.IconChar = FontAwesome.Sharp.IconChar.CcMastercard;
            this.BtnTypeOfCardCredit1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnTypeOfCardCredit1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTypeOfCardCredit1.IconSize = 70;
            this.BtnTypeOfCardCredit1.Location = new System.Drawing.Point(331, 263);
            this.BtnTypeOfCardCredit1.Name = "BtnTypeOfCardCredit1";
            this.BtnTypeOfCardCredit1.Size = new System.Drawing.Size(70, 70);
            this.BtnTypeOfCardCredit1.TabIndex = 45;
            this.BtnTypeOfCardCredit1.UseVisualStyleBackColor = false;
            // 
            // LblCountryCredit1
            // 
            this.LblCountryCredit1.AutoSize = true;
            this.LblCountryCredit1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCountryCredit1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblCountryCredit1.Location = new System.Drawing.Point(25, 263);
            this.LblCountryCredit1.Name = "LblCountryCredit1";
            this.LblCountryCredit1.Size = new System.Drawing.Size(47, 13);
            this.LblCountryCredit1.TabIndex = 41;
            this.LblCountryCredit1.Text = "Country";
            // 
            // LblCVCCredit1
            // 
            this.LblCVCCredit1.AutoSize = true;
            this.LblCVCCredit1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCVCCredit1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblCVCCredit1.Location = new System.Drawing.Point(128, 187);
            this.LblCVCCredit1.Name = "LblCVCCredit1";
            this.LblCVCCredit1.Size = new System.Drawing.Size(28, 13);
            this.LblCVCCredit1.TabIndex = 42;
            this.LblCVCCredit1.Text = "CVC";
            // 
            // LblMounthYearTxtCredit1
            // 
            this.LblMounthYearTxtCredit1.AutoSize = true;
            this.LblMounthYearTxtCredit1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMounthYearTxtCredit1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblMounthYearTxtCredit1.Location = new System.Drawing.Point(22, 187);
            this.LblMounthYearTxtCredit1.Name = "LblMounthYearTxtCredit1";
            this.LblMounthYearTxtCredit1.Size = new System.Drawing.Size(66, 13);
            this.LblMounthYearTxtCredit1.TabIndex = 39;
            this.LblMounthYearTxtCredit1.Text = "Month/Year";
            // 
            // LblBankNameCredit1
            // 
            this.LblBankNameCredit1.AutoSize = true;
            this.LblBankNameCredit1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBankNameCredit1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblBankNameCredit1.Location = new System.Drawing.Point(22, 10);
            this.LblBankNameCredit1.Name = "LblBankNameCredit1";
            this.LblBankNameCredit1.Size = new System.Drawing.Size(68, 13);
            this.LblBankNameCredit1.TabIndex = 36;
            this.LblBankNameCredit1.Text = "Bank Name ";
            // 
            // LblBankAccountCredit1
            // 
            this.LblBankAccountCredit1.AutoSize = true;
            this.LblBankAccountCredit1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBankAccountCredit1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblBankAccountCredit1.Location = new System.Drawing.Point(22, 127);
            this.LblBankAccountCredit1.Name = "LblBankAccountCredit1";
            this.LblBankAccountCredit1.Size = new System.Drawing.Size(75, 13);
            this.LblBankAccountCredit1.TabIndex = 35;
            this.LblBankAccountCredit1.Text = "Bank Account";
            // 
            // LblFullOwnerNameCredit1
            // 
            this.LblFullOwnerNameCredit1.AutoSize = true;
            this.LblFullOwnerNameCredit1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullOwnerNameCredit1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblFullOwnerNameCredit1.Location = new System.Drawing.Point(20, 74);
            this.LblFullOwnerNameCredit1.Name = "LblFullOwnerNameCredit1";
            this.LblFullOwnerNameCredit1.Size = new System.Drawing.Size(93, 13);
            this.LblFullOwnerNameCredit1.TabIndex = 33;
            this.LblFullOwnerNameCredit1.Text = "Full Owner Name";
            // 
            // BtnChangeColorCredit1
            // 
            this.BtnChangeColorCredit1.BackColor = System.Drawing.Color.Transparent;
            this.BtnChangeColorCredit1.FlatAppearance.BorderSize = 0;
            this.BtnChangeColorCredit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeColorCredit1.ForeColor = System.Drawing.Color.White;
            this.BtnChangeColorCredit1.IconChar = FontAwesome.Sharp.IconChar.Droplet;
            this.BtnChangeColorCredit1.IconColor = System.Drawing.Color.White;
            this.BtnChangeColorCredit1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnChangeColorCredit1.IconSize = 50;
            this.BtnChangeColorCredit1.Location = new System.Drawing.Point(412, 26);
            this.BtnChangeColorCredit1.Name = "BtnChangeColorCredit1";
            this.BtnChangeColorCredit1.Size = new System.Drawing.Size(50, 50);
            this.BtnChangeColorCredit1.TabIndex = 32;
            this.BtnChangeColorCredit1.UseVisualStyleBackColor = false;
            this.BtnChangeColorCredit1.Click += new System.EventHandler(this.BtnChangeColorCredit1_Click);
            // 
            // PctCreditCard
            // 
            this.PctCreditCard.BackColor = System.Drawing.Color.Transparent;
            this.PctCreditCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PctCreditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(16)))));
            this.PctCreditCard.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.PctCreditCard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(16)))));
            this.PctCreditCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PctCreditCard.IconSize = 319;
            this.PctCreditCard.Location = new System.Drawing.Point(69, 26);
            this.PctCreditCard.Name = "PctCreditCard";
            this.PctCreditCard.Size = new System.Drawing.Size(319, 322);
            this.PctCreditCard.TabIndex = 31;
            this.PctCreditCard.TabStop = false;
            // 
            // PnlHead
            // 
            this.PnlHead.Controls.Add(this.LblAddNewCard);
            this.PnlHead.Controls.Add(this.BtnOptionDebitCard);
            this.PnlHead.Controls.Add(this.BtnOptionCreditCard);
            this.PnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHead.Location = new System.Drawing.Point(0, 0);
            this.PnlHead.Name = "PnlHead";
            this.PnlHead.Size = new System.Drawing.Size(959, 120);
            this.PnlHead.TabIndex = 0;
            // 
            // LblAddNewCard
            // 
            this.LblAddNewCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAddNewCard.AutoSize = true;
            this.LblAddNewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNewCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.LblAddNewCard.Location = new System.Drawing.Point(365, 19);
            this.LblAddNewCard.Name = "LblAddNewCard";
            this.LblAddNewCard.Size = new System.Drawing.Size(242, 33);
            this.LblAddNewCard.TabIndex = 11;
            this.LblAddNewCard.Text = "+ Add New Card";
            // 
            // BtnOptionDebitCard
            // 
            this.BtnOptionDebitCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BtnOptionDebitCard.FlatAppearance.BorderSize = 0;
            this.BtnOptionDebitCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptionDebitCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOptionDebitCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.BtnOptionDebitCard.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.BtnOptionDebitCard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.BtnOptionDebitCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnOptionDebitCard.IconSize = 30;
            this.BtnOptionDebitCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOptionDebitCard.Location = new System.Drawing.Point(210, 74);
            this.BtnOptionDebitCard.Name = "BtnOptionDebitCard";
            this.BtnOptionDebitCard.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnOptionDebitCard.Size = new System.Drawing.Size(191, 31);
            this.BtnOptionDebitCard.TabIndex = 9;
            this.BtnOptionDebitCard.Text = "Debit Cards";
            this.BtnOptionDebitCard.UseVisualStyleBackColor = false;
            this.BtnOptionDebitCard.Click += new System.EventHandler(this.BtnOptionCardsType_Click);
            // 
            // BtnOptionCreditCard
            // 
            this.BtnOptionCreditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.BtnOptionCreditCard.FlatAppearance.BorderSize = 0;
            this.BtnOptionCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptionCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOptionCreditCard.ForeColor = System.Drawing.Color.White;
            this.BtnOptionCreditCard.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.BtnOptionCreditCard.IconColor = System.Drawing.Color.White;
            this.BtnOptionCreditCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnOptionCreditCard.IconSize = 30;
            this.BtnOptionCreditCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOptionCreditCard.Location = new System.Drawing.Point(549, 74);
            this.BtnOptionCreditCard.Name = "BtnOptionCreditCard";
            this.BtnOptionCreditCard.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BtnOptionCreditCard.Size = new System.Drawing.Size(178, 31);
            this.BtnOptionCreditCard.TabIndex = 8;
            this.BtnOptionCreditCard.Text = "Credit Cards";
            this.BtnOptionCreditCard.UseVisualStyleBackColor = false;
            this.BtnOptionCreditCard.Click += new System.EventHandler(this.BtnOptionCardsType_Click);
            // 
            // PnlPreViewDesigneCreditCard1
            // 
            this.PnlPreViewDesigneCreditCard1.BackColor = System.Drawing.Color.Crimson;
            this.PnlPreViewDesigneCreditCard1.BackgroundColor = System.Drawing.Color.Crimson;
            this.PnlPreViewDesigneCreditCard1.BorderColor = System.Drawing.Color.Transparent;
            this.PnlPreViewDesigneCreditCard1.BorderRadius = 15;
            this.PnlPreViewDesigneCreditCard1.BorderSize = 0;
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.PctCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.LblCVCTxtCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.LblMounthYearTxtCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.LblCVCCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.LblMounthYearCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.PctTypeOfCardCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.LblFullOwnerNameCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.LblCountryCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.PctCountryCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.LblBankNameCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.PctBankCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.LblBankAccountCreditCard1);
            this.PnlPreViewDesigneCreditCard1.Controls.Add(this.PctChipCreditCard1);
            this.PnlPreViewDesigneCreditCard1.ForeColor = System.Drawing.Color.White;
            this.PnlPreViewDesigneCreditCard1.Location = new System.Drawing.Point(40, 61);
            this.PnlPreViewDesigneCreditCard1.Name = "PnlPreViewDesigneCreditCard1";
            this.PnlPreViewDesigneCreditCard1.Size = new System.Drawing.Size(393, 237);
            this.PnlPreViewDesigneCreditCard1.TabIndex = 23;
            // 
            // PctCreditCard1
            // 
            this.PctCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.PctCreditCard1.IconChar = FontAwesome.Sharp.IconChar.C;
            this.PctCreditCard1.IconColor = System.Drawing.Color.White;
            this.PctCreditCard1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PctCreditCard1.IconSize = 44;
            this.PctCreditCard1.Location = new System.Drawing.Point(341, 135);
            this.PctCreditCard1.Name = "PctCreditCard1";
            this.PctCreditCard1.Size = new System.Drawing.Size(44, 44);
            this.PctCreditCard1.TabIndex = 27;
            this.PctCreditCard1.TabStop = false;
            // 
            // LblCVCTxtCreditCard1
            // 
            this.LblCVCTxtCreditCard1.AutoSize = true;
            this.LblCVCTxtCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.LblCVCTxtCreditCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCVCTxtCreditCard1.ForeColor = System.Drawing.Color.White;
            this.LblCVCTxtCreditCard1.Location = new System.Drawing.Point(230, 143);
            this.LblCVCTxtCreditCard1.Name = "LblCVCTxtCreditCard1";
            this.LblCVCTxtCreditCard1.Size = new System.Drawing.Size(22, 7);
            this.LblCVCTxtCreditCard1.TabIndex = 25;
            this.LblCVCTxtCreditCard1.Text = "CVC";
            // 
            // LblMounthYearTxtCreditCard1
            // 
            this.LblMounthYearTxtCreditCard1.AutoSize = true;
            this.LblMounthYearTxtCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.LblMounthYearTxtCreditCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMounthYearTxtCreditCard1.ForeColor = System.Drawing.Color.White;
            this.LblMounthYearTxtCreditCard1.Location = new System.Drawing.Point(19, 142);
            this.LblMounthYearTxtCreditCard1.Name = "LblMounthYearTxtCreditCard1";
            this.LblMounthYearTxtCreditCard1.Size = new System.Drawing.Size(67, 7);
            this.LblMounthYearTxtCreditCard1.TabIndex = 24;
            this.LblMounthYearTxtCreditCard1.Text = "MOUNTH/YEAR";
            // 
            // LblCVCCreditCard1
            // 
            this.LblCVCCreditCard1.AutoSize = true;
            this.LblCVCCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.LblCVCCreditCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCVCCreditCard1.ForeColor = System.Drawing.Color.White;
            this.LblCVCCreditCard1.Location = new System.Drawing.Point(218, 150);
            this.LblCVCCreditCard1.Name = "LblCVCCreditCard1";
            this.LblCVCCreditCard1.Size = new System.Drawing.Size(39, 25);
            this.LblCVCCreditCard1.TabIndex = 23;
            this.LblCVCCreditCard1.Text = "***";
            // 
            // LblMounthYearCreditCard1
            // 
            this.LblMounthYearCreditCard1.AutoSize = true;
            this.LblMounthYearCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.LblMounthYearCreditCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMounthYearCreditCard1.ForeColor = System.Drawing.Color.White;
            this.LblMounthYearCreditCard1.Location = new System.Drawing.Point(16, 149);
            this.LblMounthYearCreditCard1.Name = "LblMounthYearCreditCard1";
            this.LblMounthYearCreditCard1.Size = new System.Drawing.Size(71, 25);
            this.LblMounthYearCreditCard1.TabIndex = 21;
            this.LblMounthYearCreditCard1.Text = "12/29";
            // 
            // PctTypeOfCardCreditCard1
            // 
            this.PctTypeOfCardCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.PctTypeOfCardCreditCard1.IconChar = FontAwesome.Sharp.IconChar.CcMastercard;
            this.PctTypeOfCardCreditCard1.IconColor = System.Drawing.Color.White;
            this.PctTypeOfCardCreditCard1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PctTypeOfCardCreditCard1.IconSize = 54;
            this.PctTypeOfCardCreditCard1.Location = new System.Drawing.Point(331, 185);
            this.PctTypeOfCardCreditCard1.Name = "PctTypeOfCardCreditCard1";
            this.PctTypeOfCardCreditCard1.Size = new System.Drawing.Size(54, 55);
            this.PctTypeOfCardCreditCard1.TabIndex = 20;
            this.PctTypeOfCardCreditCard1.TabStop = false;
            // 
            // LblFullOwnerNameCreditCard1
            // 
            this.LblFullOwnerNameCreditCard1.AutoSize = true;
            this.LblFullOwnerNameCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.LblFullOwnerNameCreditCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullOwnerNameCreditCard1.ForeColor = System.Drawing.Color.White;
            this.LblFullOwnerNameCreditCard1.Location = new System.Drawing.Point(16, 100);
            this.LblFullOwnerNameCreditCard1.Name = "LblFullOwnerNameCreditCard1";
            this.LblFullOwnerNameCreditCard1.Size = new System.Drawing.Size(236, 20);
            this.LblFullOwnerNameCreditCard1.TabIndex = 19;
            this.LblFullOwnerNameCreditCard1.Text = "Mykola Melenchuk Bohutska";
            // 
            // LblCountryCreditCard1
            // 
            this.LblCountryCreditCard1.AutoSize = true;
            this.LblCountryCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.LblCountryCreditCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCountryCreditCard1.ForeColor = System.Drawing.Color.White;
            this.LblCountryCreditCard1.Location = new System.Drawing.Point(48, 203);
            this.LblCountryCreditCard1.Name = "LblCountryCreditCard1";
            this.LblCountryCreditCard1.Size = new System.Drawing.Size(67, 25);
            this.LblCountryCreditCard1.TabIndex = 17;
            this.LblCountryCreditCard1.Text = "Spain";
            // 
            // PctCountryCreditCard1
            // 
            this.PctCountryCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.PctCountryCreditCard1.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.PctCountryCreditCard1.IconColor = System.Drawing.Color.White;
            this.PctCountryCreditCard1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PctCountryCreditCard1.IconSize = 39;
            this.PctCountryCreditCard1.Location = new System.Drawing.Point(16, 196);
            this.PctCountryCreditCard1.Name = "PctCountryCreditCard1";
            this.PctCountryCreditCard1.Size = new System.Drawing.Size(39, 44);
            this.PctCountryCreditCard1.TabIndex = 16;
            this.PctCountryCreditCard1.TabStop = false;
            // 
            // LblBankNameCreditCard1
            // 
            this.LblBankNameCreditCard1.AutoSize = true;
            this.LblBankNameCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.LblBankNameCreditCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBankNameCreditCard1.ForeColor = System.Drawing.Color.White;
            this.LblBankNameCreditCard1.Location = new System.Drawing.Point(48, 20);
            this.LblBankNameCreditCard1.Name = "LblBankNameCreditCard1";
            this.LblBankNameCreditCard1.Size = new System.Drawing.Size(111, 25);
            this.LblBankNameCreditCard1.TabIndex = 15;
            this.LblBankNameCreditCard1.Text = "Santander";
            // 
            // PctBankCreditCard1
            // 
            this.PctBankCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.PctBankCreditCard1.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.PctBankCreditCard1.IconColor = System.Drawing.Color.White;
            this.PctBankCreditCard1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PctBankCreditCard1.Location = new System.Drawing.Point(16, 13);
            this.PctBankCreditCard1.Name = "PctBankCreditCard1";
            this.PctBankCreditCard1.Size = new System.Drawing.Size(32, 32);
            this.PctBankCreditCard1.TabIndex = 14;
            this.PctBankCreditCard1.TabStop = false;
            // 
            // LblBankAccountCreditCard1
            // 
            this.LblBankAccountCreditCard1.AutoSize = true;
            this.LblBankAccountCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.LblBankAccountCreditCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBankAccountCreditCard1.ForeColor = System.Drawing.Color.White;
            this.LblBankAccountCreditCard1.Location = new System.Drawing.Point(16, 67);
            this.LblBankAccountCreditCard1.Name = "LblBankAccountCreditCard1";
            this.LblBankAccountCreditCard1.Size = new System.Drawing.Size(322, 29);
            this.LblBankAccountCreditCard1.TabIndex = 13;
            this.LblBankAccountCreditCard1.Text = "XXXX XXXX XXXX XXXX";
            // 
            // PctChipCreditCard1
            // 
            this.PctChipCreditCard1.BackColor = System.Drawing.Color.Transparent;
            this.PctChipCreditCard1.IconChar = FontAwesome.Sharp.IconChar.SimCard;
            this.PctChipCreditCard1.IconColor = System.Drawing.Color.White;
            this.PctChipCreditCard1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PctChipCreditCard1.IconSize = 78;
            this.PctChipCreditCard1.Location = new System.Drawing.Point(331, 14);
            this.PctChipCreditCard1.Name = "PctChipCreditCard1";
            this.PctChipCreditCard1.Rotation = 90D;
            this.PctChipCreditCard1.Size = new System.Drawing.Size(83, 78);
            this.PctChipCreditCard1.TabIndex = 18;
            this.PctChipCreditCard1.TabStop = false;
            // 
            // lwPanel6
            // 
            this.lwPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel6.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel6.BorderRadius = 15;
            this.lwPanel6.BorderSize = 0;
            this.lwPanel6.Controls.Add(this.TxtCountryCredit1);
            this.lwPanel6.ForeColor = System.Drawing.SystemColors.Window;
            this.lwPanel6.Location = new System.Drawing.Point(28, 279);
            this.lwPanel6.Name = "lwPanel6";
            this.lwPanel6.Size = new System.Drawing.Size(157, 32);
            this.lwPanel6.TabIndex = 44;
            // 
            // TxtCountryCredit1
            // 
            this.TxtCountryCredit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtCountryCredit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCountryCredit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCountryCredit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtCountryCredit1.Location = new System.Drawing.Point(3, 1);
            this.TxtCountryCredit1.Name = "TxtCountryCredit1";
            this.TxtCountryCredit1.Size = new System.Drawing.Size(151, 28);
            this.TxtCountryCredit1.TabIndex = 12;
            this.TxtCountryCredit1.Text = "Spain";
            this.TxtCountryCredit1.TextChanged += new System.EventHandler(this.TxtCountryCredit1_TextChanged);
            // 
            // lwPanel5
            // 
            this.lwPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel5.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel5.BorderRadius = 15;
            this.lwPanel5.BorderSize = 0;
            this.lwPanel5.Controls.Add(this.TxtCVCCredit1);
            this.lwPanel5.ForeColor = System.Drawing.SystemColors.Window;
            this.lwPanel5.Location = new System.Drawing.Point(131, 203);
            this.lwPanel5.Name = "lwPanel5";
            this.lwPanel5.Size = new System.Drawing.Size(72, 32);
            this.lwPanel5.TabIndex = 43;
            // 
            // TxtCVCCredit1
            // 
            this.TxtCVCCredit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtCVCCredit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCVCCredit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCVCCredit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtCVCCredit1.Location = new System.Drawing.Point(3, 3);
            this.TxtCVCCredit1.MaxLength = 3;
            this.TxtCVCCredit1.Name = "TxtCVCCredit1";
            this.TxtCVCCredit1.Size = new System.Drawing.Size(67, 28);
            this.TxtCVCCredit1.TabIndex = 12;
            this.TxtCVCCredit1.Text = "088";
            this.TxtCVCCredit1.UseSystemPasswordChar = true;
            this.TxtCVCCredit1.TextChanged += new System.EventHandler(this.TxtCVCCredit1_TextChanged);
            // 
            // lwPanel4
            // 
            this.lwPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel4.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel4.BorderRadius = 15;
            this.lwPanel4.BorderSize = 0;
            this.lwPanel4.Controls.Add(this.TxtMounthYearCredit1);
            this.lwPanel4.ForeColor = System.Drawing.SystemColors.Window;
            this.lwPanel4.Location = new System.Drawing.Point(25, 203);
            this.lwPanel4.Name = "lwPanel4";
            this.lwPanel4.Size = new System.Drawing.Size(72, 32);
            this.lwPanel4.TabIndex = 40;
            // 
            // TxtMounthYearCredit1
            // 
            this.TxtMounthYearCredit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtMounthYearCredit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMounthYearCredit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMounthYearCredit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtMounthYearCredit1.Location = new System.Drawing.Point(3, 1);
            this.TxtMounthYearCredit1.Name = "TxtMounthYearCredit1";
            this.TxtMounthYearCredit1.Size = new System.Drawing.Size(67, 28);
            this.TxtMounthYearCredit1.TabIndex = 12;
            this.TxtMounthYearCredit1.Text = "12/29";
            this.TxtMounthYearCredit1.TextChanged += new System.EventHandler(this.TxtMounthYearCredit1_TextChanged);
            // 
            // lwPanel3
            // 
            this.lwPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel3.BorderRadius = 15;
            this.lwPanel3.BorderSize = 0;
            this.lwPanel3.Controls.Add(this.TxtBankNameCredit1);
            this.lwPanel3.ForeColor = System.Drawing.SystemColors.Window;
            this.lwPanel3.Location = new System.Drawing.Point(25, 26);
            this.lwPanel3.Name = "lwPanel3";
            this.lwPanel3.Size = new System.Drawing.Size(224, 32);
            this.lwPanel3.TabIndex = 38;
            // 
            // TxtBankNameCredit1
            // 
            this.TxtBankNameCredit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtBankNameCredit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBankNameCredit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBankNameCredit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtBankNameCredit1.Location = new System.Drawing.Point(-2, 1);
            this.TxtBankNameCredit1.Name = "TxtBankNameCredit1";
            this.TxtBankNameCredit1.Size = new System.Drawing.Size(227, 28);
            this.TxtBankNameCredit1.TabIndex = 12;
            this.TxtBankNameCredit1.Text = "Santander";
            this.TxtBankNameCredit1.TextChanged += new System.EventHandler(this.TxtBankNameCredit1_TextChanged);
            // 
            // lwPanel2
            // 
            this.lwPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel2.BorderRadius = 15;
            this.lwPanel2.BorderSize = 0;
            this.lwPanel2.Controls.Add(this.TxtBankAccountCredit1);
            this.lwPanel2.ForeColor = System.Drawing.SystemColors.Window;
            this.lwPanel2.Location = new System.Drawing.Point(25, 143);
            this.lwPanel2.Name = "lwPanel2";
            this.lwPanel2.Size = new System.Drawing.Size(363, 32);
            this.lwPanel2.TabIndex = 37;
            // 
            // TxtBankAccountCredit1
            // 
            this.TxtBankAccountCredit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtBankAccountCredit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBankAccountCredit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBankAccountCredit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtBankAccountCredit1.Location = new System.Drawing.Point(6, 4);
            this.TxtBankAccountCredit1.MaxLength = 19;
            this.TxtBankAccountCredit1.Name = "TxtBankAccountCredit1";
            this.TxtBankAccountCredit1.Size = new System.Drawing.Size(357, 28);
            this.TxtBankAccountCredit1.TabIndex = 12;
            this.TxtBankAccountCredit1.Text = "XXXX XXXX XXXX XXXX";
            this.TxtBankAccountCredit1.TextChanged += new System.EventHandler(this.TxtBankAccountCredit1_TextChanged);
            // 
            // lwPanel1
            // 
            this.lwPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.lwPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel1.BorderRadius = 15;
            this.lwPanel1.BorderSize = 0;
            this.lwPanel1.Controls.Add(this.TxtFullOwnerNameCredit1);
            this.lwPanel1.ForeColor = System.Drawing.SystemColors.Window;
            this.lwPanel1.Location = new System.Drawing.Point(23, 90);
            this.lwPanel1.Name = "lwPanel1";
            this.lwPanel1.Size = new System.Drawing.Size(365, 32);
            this.lwPanel1.TabIndex = 34;
            // 
            // TxtFullOwnerNameCredit1
            // 
            this.TxtFullOwnerNameCredit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.TxtFullOwnerNameCredit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFullOwnerNameCredit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFullOwnerNameCredit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.TxtFullOwnerNameCredit1.Location = new System.Drawing.Point(2, 3);
            this.TxtFullOwnerNameCredit1.Name = "TxtFullOwnerNameCredit1";
            this.TxtFullOwnerNameCredit1.Size = new System.Drawing.Size(363, 28);
            this.TxtFullOwnerNameCredit1.TabIndex = 12;
            this.TxtFullOwnerNameCredit1.Text = "Mykola Melenchuk Bohutska";
            this.TxtFullOwnerNameCredit1.TextChanged += new System.EventHandler(this.TxtFullOwnerNameCredit1_TextChanged);
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
            this.BtnClose.Location = new System.Drawing.Point(934, 10);
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
            this.BtnMinimize.Location = new System.Drawing.Point(915, 10);
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
            this.BtnMaximize.Location = new System.Drawing.Point(896, 10);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(13, 13);
            this.BtnMaximize.TabIndex = 2;
            this.BtnMaximize.Text = "lwButtonActions6";
            this.BtnMaximize.TextColor = System.Drawing.Color.White;
            // 
            // FrmCreationCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(959, 508);
            this.Controls.Add(this.PnlBody);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreationCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreationCards";
            this.PnlHeader.ResumeLayout(false);
            this.PnlBody.ResumeLayout(false);
            this.PnlCreditCard.ResumeLayout(false);
            this.PnlCreditCardView.ResumeLayout(false);
            this.PnlForm.ResumeLayout(false);
            this.PnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctCreditCard)).EndInit();
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            this.PnlPreViewDesigneCreditCard1.ResumeLayout(false);
            this.PnlPreViewDesigneCreditCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctCreditCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctTypeOfCardCreditCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCountryCreditCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBankCreditCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctChipCreditCard1)).EndInit();
            this.lwPanel6.ResumeLayout(false);
            this.lwPanel6.PerformLayout();
            this.lwPanel5.ResumeLayout(false);
            this.lwPanel5.PerformLayout();
            this.lwPanel4.ResumeLayout(false);
            this.lwPanel4.PerformLayout();
            this.lwPanel3.ResumeLayout(false);
            this.lwPanel3.PerformLayout();
            this.lwPanel2.ResumeLayout(false);
            this.lwPanel2.PerformLayout();
            this.lwPanel1.ResumeLayout(false);
            this.lwPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private LWButtonActions BtnClose;
        private LWButtonActions BtnMinimize;
        private LWButtonActions BtnMaximize;
        private System.Windows.Forms.Panel PnlBody;
        private System.Windows.Forms.Panel PnlHead;
        private FontAwesome.Sharp.IconButton BtnOptionCreditCard;
        private FontAwesome.Sharp.IconButton BtnOptionDebitCard;
        private System.Windows.Forms.Label LblAddNewCard;
        private System.Windows.Forms.Panel PnlCreditCard;
        private System.Windows.Forms.Panel PnlForm;
        private System.Windows.Forms.Panel PnlCreditCardView;
        private LWPanel PnlPreViewDesigneCreditCard1;
        private FontAwesome.Sharp.IconPictureBox PctCreditCard1;
        private System.Windows.Forms.Label LblCVCTxtCreditCard1;
        private System.Windows.Forms.Label LblMounthYearTxtCreditCard1;
        private System.Windows.Forms.Label LblCVCCreditCard1;
        private System.Windows.Forms.Label LblMounthYearCreditCard1;
        private FontAwesome.Sharp.IconPictureBox PctTypeOfCardCreditCard1;
        private System.Windows.Forms.Label LblFullOwnerNameCreditCard1;
        private System.Windows.Forms.Label LblCountryCreditCard1;
        private FontAwesome.Sharp.IconPictureBox PctCountryCreditCard1;
        private System.Windows.Forms.Label LblBankNameCreditCard1;
        private FontAwesome.Sharp.IconPictureBox PctBankCreditCard1;
        private System.Windows.Forms.Label LblBankAccountCreditCard1;
        private FontAwesome.Sharp.IconPictureBox PctChipCreditCard1;
        private FontAwesome.Sharp.IconButton BtnLeftRightSliderCredit1;
        private System.Windows.Forms.Label LblChangeColorCredit1;
        private FontAwesome.Sharp.IconButton BtnCrossCVCCredit1;
        private System.Windows.Forms.Label LblTypeOfCardCredit1;
        private FontAwesome.Sharp.IconButton BtnTypeOfCardCredit1;
        private LWPanel lwPanel6;
        private System.Windows.Forms.TextBox TxtCountryCredit1;
        private System.Windows.Forms.Label LblCountryCredit1;
        private LWPanel lwPanel5;
        private System.Windows.Forms.TextBox TxtCVCCredit1;
        private System.Windows.Forms.Label LblCVCCredit1;
        private LWPanel lwPanel4;
        private System.Windows.Forms.TextBox TxtMounthYearCredit1;
        private System.Windows.Forms.Label LblMounthYearTxtCredit1;
        private LWPanel lwPanel3;
        private System.Windows.Forms.TextBox TxtBankNameCredit1;
        private System.Windows.Forms.Label LblBankNameCredit1;
        private LWPanel lwPanel2;
        private System.Windows.Forms.TextBox TxtBankAccountCredit1;
        private System.Windows.Forms.Label LblBankAccountCredit1;
        private LWPanel lwPanel1;
        private System.Windows.Forms.TextBox TxtFullOwnerNameCredit1;
        private System.Windows.Forms.Label LblFullOwnerNameCredit1;
        private FontAwesome.Sharp.IconButton BtnChangeColorCredit1;
        private FontAwesome.Sharp.IconPictureBox PctCreditCard;
    }
}