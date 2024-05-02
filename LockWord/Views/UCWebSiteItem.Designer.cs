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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWebSiteItem));
            this.PctBody = new System.Windows.Forms.PictureBox();
            this.LblNameWebSite = new System.Windows.Forms.Label();
            this.lwPanel1 = new LockWord.LWPanel();
            this.lwPanel2 = new LockWord.LWPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PctBody)).BeginInit();
            this.lwPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PctBody
            // 
            this.PctBody.BackColor = System.Drawing.Color.Transparent;
            this.PctBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PctBody.Image = ((System.Drawing.Image)(resources.GetObject("PctBody.Image")));
            this.PctBody.Location = new System.Drawing.Point(0, 0);
            this.PctBody.Name = "PctBody";
            this.PctBody.Size = new System.Drawing.Size(296, 191);
            this.PctBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PctBody.TabIndex = 0;
            this.PctBody.TabStop = false;
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
            // lwPanel1
            // 
            this.lwPanel1.BackColor = System.Drawing.Color.Black;
            this.lwPanel1.BackgroundColor = System.Drawing.Color.Black;
            this.lwPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel1.BorderRadius = 15;
            this.lwPanel1.BorderSize = 0;
            this.lwPanel1.Controls.Add(this.LblNameWebSite);
            this.lwPanel1.ForeColor = System.Drawing.Color.White;
            this.lwPanel1.Location = new System.Drawing.Point(68, 74);
            this.lwPanel1.Name = "lwPanel1";
            this.lwPanel1.Size = new System.Drawing.Size(150, 47);
            this.lwPanel1.TabIndex = 2;
            // 
            // lwPanel2
            // 
            this.lwPanel2.BackColor = System.Drawing.Color.Transparent;
            this.lwPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.lwPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.lwPanel2.BorderRadius = 15;
            this.lwPanel2.BorderSize = 0;
            this.lwPanel2.ForeColor = System.Drawing.Color.White;
            this.lwPanel2.Location = new System.Drawing.Point(31, 28);
            this.lwPanel2.Name = "lwPanel2";
            this.lwPanel2.Size = new System.Drawing.Size(150, 40);
            this.lwPanel2.TabIndex = 3;
            // 
            // UCWebSiteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lwPanel2);
            this.Controls.Add(this.lwPanel1);
            this.Controls.Add(this.PctBody);
            this.Name = "UCWebSiteItem";
            this.Size = new System.Drawing.Size(296, 191);
            ((System.ComponentModel.ISupportInitialize)(this.PctBody)).EndInit();
            this.lwPanel1.ResumeLayout(false);
            this.lwPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBody;
        private System.Windows.Forms.Label LblNameWebSite;
        private LWPanel lwPanel1;
        private LWPanel lwPanel2;
    }
}
