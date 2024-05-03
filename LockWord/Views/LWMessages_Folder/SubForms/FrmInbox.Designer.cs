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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblLWMessages = new System.Windows.Forms.Label();
            this.IcnLWMessages = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcnLWMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IcnLWMessages);
            this.panel1.Controls.Add(this.LblLWMessages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 65);
            this.panel1.TabIndex = 0;
            // 
            // LblLWMessages
            // 
            this.LblLWMessages.AutoSize = true;
            this.LblLWMessages.BackColor = System.Drawing.Color.Transparent;
            this.LblLWMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLWMessages.ForeColor = System.Drawing.Color.White;
            this.LblLWMessages.Location = new System.Drawing.Point(592, 12);
            this.LblLWMessages.Name = "LblLWMessages";
            this.LblLWMessages.Size = new System.Drawing.Size(116, 44);
            this.LblLWMessages.TabIndex = 15;
            this.LblLWMessages.Text = "Inbox";
            // 
            // IcnLWMessages
            // 
            this.IcnLWMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.IcnLWMessages.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.IcnLWMessages.IconColor = System.Drawing.Color.White;
            this.IcnLWMessages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcnLWMessages.IconSize = 45;
            this.IcnLWMessages.Location = new System.Drawing.Point(541, 12);
            this.IcnLWMessages.Name = "IcnLWMessages";
            this.IcnLWMessages.Size = new System.Drawing.Size(45, 45);
            this.IcnLWMessages.TabIndex = 16;
            this.IcnLWMessages.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 464);
            this.panel2.TabIndex = 1;
            // 
            // FrmInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1255, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInbox";
            this.Text = "FrmInbox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcnLWMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblLWMessages;
        private FontAwesome.Sharp.IconPictureBox IcnLWMessages;
        private System.Windows.Forms.Panel panel2;
    }
}