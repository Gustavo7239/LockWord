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
            this.lwPanel1 = new LockWord.LWPanel();
            this.SuspendLayout();
            // 
            // lwPanel1
            // 
            this.lwPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.lwPanel1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.lwPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel1.BorderRadius = 15;
            this.lwPanel1.BorderSize = 0;
            this.lwPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwPanel1.ForeColor = System.Drawing.Color.White;
            this.lwPanel1.Location = new System.Drawing.Point(0, 0);
            this.lwPanel1.Name = "lwPanel1";
            this.lwPanel1.Size = new System.Drawing.Size(982, 635);
            this.lwPanel1.TabIndex = 0;
            // 
            // AcountsTreeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(982, 635);
            this.Controls.Add(this.lwPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcountsTreeMenu";
            this.Text = "AcountsTreeMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private LWPanel lwPanel1;
    }
}