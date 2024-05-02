namespace LockWord.Views
{
    partial class UCWebSiteItem
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWebSiteItem));
            this.PctBodyWebSite = new System.Windows.Forms.PictureBox();
            this.TlTipWebSite = new System.Windows.Forms.ToolTip(this.components);
            this.PnlNameWebSite = new LockWord.LWPanel();
            this.LblNameWebSite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBodyWebSite)).BeginInit();
            this.PnlNameWebSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // PctBodyWebSite
            // 
            this.PctBodyWebSite.BackColor = System.Drawing.Color.Transparent;
            this.PctBodyWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PctBodyWebSite.Image = ((System.Drawing.Image)(resources.GetObject("PctBodyWebSite.Image")));
            this.PctBodyWebSite.Location = new System.Drawing.Point(0, 0);
            this.PctBodyWebSite.Name = "PctBodyWebSite";
            this.PctBodyWebSite.Size = new System.Drawing.Size(296, 191);
            this.PctBodyWebSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PctBodyWebSite.TabIndex = 0;
            this.PctBodyWebSite.TabStop = false;
            this.TlTipWebSite.SetToolTip(this.PctBodyWebSite, "Description of Web Site");
            // 
            // TlTipWebSite
            // 
            this.TlTipWebSite.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TlTipWebSite.ToolTipTitle = "Description";
            // 
            // PnlNameWebSite
            // 
            this.PnlNameWebSite.BackColor = System.Drawing.Color.Black;
            this.PnlNameWebSite.BackgroundColor = System.Drawing.Color.Black;
            this.PnlNameWebSite.BorderColor = System.Drawing.Color.Transparent;
            this.PnlNameWebSite.BorderRadius = 15;
            this.PnlNameWebSite.BorderSize = 0;
            this.PnlNameWebSite.Controls.Add(this.LblNameWebSite);
            this.PnlNameWebSite.ForeColor = System.Drawing.Color.White;
            this.PnlNameWebSite.Location = new System.Drawing.Point(68, 74);
            this.PnlNameWebSite.Name = "PnlNameWebSite";
            this.PnlNameWebSite.Size = new System.Drawing.Size(150, 47);
            this.PnlNameWebSite.TabIndex = 2;
            // 
            // LblNameWebSite
            // 
            this.LblNameWebSite.AutoSize = true;
            this.LblNameWebSite.BackColor = System.Drawing.Color.Black;
            this.LblNameWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameWebSite.ForeColor = System.Drawing.Color.White;
            this.LblNameWebSite.Location = new System.Drawing.Point(3, 8);
            this.LblNameWebSite.Name = "LblNameWebSite";
            this.LblNameWebSite.Size = new System.Drawing.Size(143, 32);
            this.LblNameWebSite.TabIndex = 1;
            this.LblNameWebSite.Text = "GOOGLE";
            // 
            // UCWebSiteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PnlNameWebSite);
            this.Controls.Add(this.PctBodyWebSite);
            this.Name = "UCWebSiteItem";
            this.Size = new System.Drawing.Size(296, 191);
            ((System.ComponentModel.ISupportInitialize)(this.PctBodyWebSite)).EndInit();
            this.PnlNameWebSite.ResumeLayout(false);
            this.PnlNameWebSite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBodyWebSite;
        private System.Windows.Forms.Label LblNameWebSite;
        private LWPanel PnlNameWebSite;
        private System.Windows.Forms.ToolTip TlTipWebSite;
    }
}
