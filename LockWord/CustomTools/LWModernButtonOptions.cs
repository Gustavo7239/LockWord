using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LockWord.CustomTools
{
    internal class LWModernButtonOptions : Button
    {
        private Image _icon;
        private Color _iconColor = Color.Black;

        [Category("Custom")]
        [Description("Imagen del icono del botón.")]
        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Color del icono.")]
        public Color IconColor
        {
            get { return _iconColor; }
            set
            {
                _iconColor = value;
                Invalidate();
            }
        }

        public LWModernButtonOptions()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.TextAlign = ContentAlignment.MiddleLeft;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Dibujar el icono a la derecha
            if (Icon != null)
            {
                Bitmap bmpIcon = new Bitmap(Icon);

                // Calcular posición del icono
                int iconWidth = bmpIcon.Width;
                int iconHeight = bmpIcon.Height;
                int iconX = this.Width - iconWidth - 5; // 5 es el margen derecho
                int iconY = (this.Height - iconHeight) / 2;

                // Dibujar icono con el color especificado
                for (int i = 0; i < bmpIcon.Width; i++)
                {
                    for (int j = 0; j < bmpIcon.Height; j++)
                    {
                        Color originalColor = bmpIcon.GetPixel(i, j);
                        if (originalColor.A > 0) // Si el píxel no es transparente
                        {
                            bmpIcon.SetPixel(i, j, IconColor);
                        }
                    }
                }
                pevent.Graphics.DrawImage(bmpIcon, iconX, iconY, iconWidth, iconHeight);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Invalidate(); // Redibujar el control cuando cambia el texto
        }
    }
}
