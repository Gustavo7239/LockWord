using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LockWord.CustomTools
{
    public enum IconAlignment
    {
        Left,
        Right,
        Top,
        Bottom,
        Center
    }

    public enum IconSizeMode
    {
        Normal,
        Zoom
    }

    internal class LWModernButtonOptions : Button
    {
        private Image _icon;
        private Color _iconColor = Color.Black;
        private IconAlignment _iconAlignment = IconAlignment.Right;
        private IconSizeMode _iconSizeMode = IconSizeMode.Normal;

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

        [Category("Custom")]
        [Description("Alineación del icono.")]
        public IconAlignment IconAlignment
        {
            get { return _iconAlignment; }
            set
            {
                _iconAlignment = value;
                Invalidate();
            }
        }

        [Category("Custom")]
        [Description("Ajuste de tamaño de la imagen.")]
        public IconSizeMode IconSizeMode
        {
            get { return _iconSizeMode; }
            set
            {
                _iconSizeMode = value;
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

            if (Icon != null)
            {
                Bitmap bmpIcon = new Bitmap(Icon);
                int iconWidth = bmpIcon.Width;
                int iconHeight = bmpIcon.Height;
                int iconX = 0, iconY = 0;

                switch (IconAlignment)
                {
                    case IconAlignment.Left:
                        iconX = 5;
                        iconY = (this.Height - iconHeight) / 2;
                        break;
                    case IconAlignment.Right:
                        iconX = this.Width - iconWidth - 5;
                        iconY = (this.Height - iconHeight) / 2;
                        break;
                    case IconAlignment.Top:
                        iconX = (this.Width - iconWidth) / 2;
                        iconY = 5;
                        break;
                    case IconAlignment.Bottom:
                        iconX = (this.Width - iconWidth) / 2;
                        iconY = this.Height - iconHeight - 5;
                        break;
                    case IconAlignment.Center:
                        iconX = (this.Width - iconWidth) / 2;
                        iconY = (this.Height - iconHeight) / 2;
                        break;
                }

                if (_iconSizeMode == IconSizeMode.Zoom)
                {
                    // Ajustar tamaño del icono al alto del botón
                    float ratio = (float)this.Height / (float)bmpIcon.Height;
                    iconWidth = (int)(bmpIcon.Width * ratio);
                    iconHeight = (int)(bmpIcon.Height * ratio);
                }

                for (int i = 0; i < bmpIcon.Width; i++)
                {
                    for (int j = 0; j < bmpIcon.Height; j++)
                    {
                        Color originalColor = bmpIcon.GetPixel(i, j);
                        if (originalColor.A > 0)
                        {
                            bmpIcon.SetPixel(i, j, IconColor);
                        }
                    }
                }
                pevent.Graphics.DrawImage(bmpIcon, new Rectangle(iconX, iconY, iconWidth, iconHeight));
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Invalidate();
        }
    }
}
