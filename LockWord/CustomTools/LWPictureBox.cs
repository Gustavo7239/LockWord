using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockWord.CustomTools
{
    internal class LWPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crear un círculo para el clip
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));

            e.Graphics.SetClip(circlePath);

            // Dibujar la imagen
            if (this.Image != null)
            {
                e.Graphics.DrawImage(this.Image, 0, 0, this.Width, this.Height);
            }

            // Dibujar borde del círculo
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawEllipse(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Refresh(); // Redibujar el control al cambiar el tamaño
        }
    }
}
