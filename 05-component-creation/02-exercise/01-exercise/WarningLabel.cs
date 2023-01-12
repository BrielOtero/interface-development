using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace _01_exercise
{
    public partial class WarningLabel : Control
    {
        private eMark mark = eMark.Nothing;
        private Color startGradientColor = Color.BlueViolet;
        private Color endGradientColor = Color.Yellow;
        private bool hasGradient = false;
        private Image markImage;

        [Category("Appearance")]
        [Description("Indicates the type of mark that appears next to the text")]
        public eMark Mark
        {
            set
            {
                mark = value;
                this.Refresh();
            }
            get { return mark; }
        }

        [Category("Appearance")]
        [Description("Indicates if " + nameof(WarningLabel) + " has gradient background")]
        public bool HasGradient
        {
            set
            {
                hasGradient = value;
                this.Refresh();
            }
            get { return hasGradient; }
        }

        [Category("Appearance")]
        [Description("Image property to set in the component mark")]
        public Image MarkImage
        {
            set
            {
                markImage = value;
            }
            get { return markImage; }
        }

        [Category("Action")]
        [Description("Occurs when mark is clicked")]
        public event EventHandler ClickOnMark;

        public WarningLabel()
        {
            InitializeComponent();
        }

        int h;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;

            int thickness = 0;
            int offsexX = 0;
            int offsetY = 0;

            h = this.Font.Height;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (hasGradient)
            {
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Point(this.Width / 2, 0), new Point(this.Width / 2, this.Height), startGradientColor, endGradientColor);
                g.FillRectangle(linearGradientBrush, 0, 0, this.Width, this.Height);
            }

            switch (Mark)
            {
                case eMark.Circle:
                    thickness = 20;
                    g.DrawEllipse(new Pen(Color.Green, thickness), thickness, thickness, h, h);
                    offsexX = h + thickness;
                    offsetY = thickness;
                    break;

                case eMark.Cross:
                    thickness = 3;
                    Pen pen = new Pen(Color.Red, thickness);
                    g.DrawLine(pen, thickness, thickness, h, h);
                    g.DrawLine(pen, h, thickness, thickness, h);
                    offsexX = h + thickness;
                    offsetY = thickness / 2;
                    pen.Dispose();
                    break;

                case eMark.Image:
                    try
                    {
                        thickness = h;
                        g.DrawImage(MarkImage, 0, 0, h, h);
                    }
                    catch (ArgumentNullException)
                    {
                        Debug.WriteLine("Image Mark not valid");
                    }
                    break;
            }


            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsexX + thickness, offsetY);
            Size size = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(size.Width + offsexX + thickness, size.Height + offsetY * 2);
            b.Dispose();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        private void WarningLabel_MouseClick(object sender, MouseEventArgs e)
        {

            if (mark != eMark.Nothing)
            {
                Debug.WriteLine($"{e.X} | {e.Y}");
                Debug.WriteLine(h);
                if (e.X <= h && e.Y <= h)
                {
                    ClickOnMark?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
