using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace LockWord
{
    internal class LWButtonActions : Control
    {
        // Fields
        private int borderRadius = 15;
        private Color borderColor = Color.Transparent;
        private Image hoverIcon = null;
        private string hoverText = "x";
        private Color hoverTextColor = Color.FromArgb(131, 0, 4);
        private bool isHovered = false;
        private Image icon = null;
        private string text = "";
        private Color textColor = Color.White;
        private float iconOpacity = 1.0f;
        private Color buttonColor = Color.FromArgb(255, 92, 92);
        private Font buttonFont = new Font("Arial", 10, FontStyle.Bold);
        private Color clickColor = Color.FromArgb(255, 141, 141); //30% light
        private float clickOpacity = 0.5f;
        private bool isClicked = false;

        // Properties
        [Category("LW Button Actions")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public Image HoverIcon
        {
            get { return hoverIcon; }
            set
            {
                hoverIcon = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public string HoverText
        {
            get { return hoverText; }
            set
            {
                hoverText = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public Color HoverTextColor
        {
            get { return hoverTextColor; }
            set
            {
                hoverTextColor = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public Image Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public string ButtonText
        {
            get { return text; }
            set
            {
                text = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public float IconOpacity
        {
            get { return iconOpacity; }
            set
            {
                iconOpacity = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public Color ButtonColor
        {
            get { return buttonColor; }
            set
            {
                buttonColor = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public Font ButtonFont
        {
            get { return buttonFont; }
            set
            {
                buttonFont = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public Color ClickColor
        {
            get { return clickColor; }
            set
            {
                clickColor = value;
                this.Invalidate();
            }
        }

        [Category("LW Button Actions")]
        public float ClickOpacity
        {
            get { return clickOpacity; }
            set
            {
                clickOpacity = value;
                this.Invalidate();
            }
        }

        // Constructor
        public LWButtonActions()
        {
            this.Size = new Size(13, 13);
            this.DoubleBuffered = true;
            this.Cursor = Cursors.Hand;
        }

        // Methods
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color displayColor = isClicked ? ControlPaint.Light(clickColor, clickOpacity) : buttonColor;

            // Fill background
            Brush brush = new SolidBrush(displayColor);
            e.Graphics.FillEllipse(brush, this.ClientRectangle);

            // Draw border
            Pen pen = new Pen(borderColor, 2);
            e.Graphics.DrawEllipse(pen, this.ClientRectangle);

            // Draw icon
            Image displayIcon = icon;
            if (displayIcon != null)
            {
                float opacity = iconOpacity < 0 ? 0 : (iconOpacity > 1 ? 1 : iconOpacity);
                ImageAttributes attr = new ImageAttributes();
                attr.SetColorMatrix(new ColorMatrix { Matrix33 = opacity });
                e.Graphics.DrawImage(displayIcon, this.ClientRectangle, 0, 0, displayIcon.Width, displayIcon.Height, GraphicsUnit.Pixel, attr);
            }

            // Draw text
            Color displayTextColor = isHovered ? hoverTextColor : textColor;
            string displayText = isHovered ? hoverText : text;
            if (!string.IsNullOrEmpty(displayText))
            {
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(displayText, buttonFont, new SolidBrush(displayTextColor), this.ClientRectangle, format);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isClicked = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isClicked = false;
            Invalidate();
        }
    }
}
