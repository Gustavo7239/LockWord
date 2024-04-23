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
            this.BtnAdd1 = new LockWord.LWButton();
            this.Pnl1 = new LockWord.LWPanel();
            this.Pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd1
            // 
            this.BtnAdd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.BtnAdd1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.BtnAdd1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAdd1.BorderRadius = 0;
            this.BtnAdd1.BorderSize = 0;
            this.BtnAdd1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnAdd1.FlatAppearance.BorderSize = 0;
            this.BtnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.BtnAdd1.Location = new System.Drawing.Point(19, 17);
            this.BtnAdd1.Name = "BtnAdd1";
            this.BtnAdd1.Size = new System.Drawing.Size(195, 130);
            this.BtnAdd1.TabIndex = 1;
            this.BtnAdd1.Text = "+";
            this.BtnAdd1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(56)))));
            this.BtnAdd1.UseVisualStyleBackColor = false;
            // 
            // Pnl1
            // 
            this.Pnl1.AutoSize = true;
            this.Pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.Pnl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.Pnl1.BorderColor = System.Drawing.Color.Transparent;
            this.Pnl1.BorderRadius = 15;
            this.Pnl1.BorderSize = 0;
            this.Pnl1.Controls.Add(this.BtnAdd1);
            this.Pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl1.ForeColor = System.Drawing.Color.White;
            this.Pnl1.Location = new System.Drawing.Point(0, 0);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(1111, 669);
            this.Pnl1.TabIndex = 3;
            // 
            // AcountsTreeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1111, 669);
            this.Controls.Add(this.Pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcountsTreeMenu";
            this.Text = "AcountsTreeMenu";
            this.Pnl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LWButton BtnAdd1;
        private LWPanel Pnl1;
    }
}