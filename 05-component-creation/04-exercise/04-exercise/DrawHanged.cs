using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_exercise
{
    public partial class DrawHanged : UserControl
    {
        public event EventHandler MistakesChanged;
        public event EventHandler Hanged;

        public DrawHanged()
        {
            InitializeComponent();
        }

        [Category("The Property Change")]
        [Description("Fired when the Mistakes property change")]
        private int mistakes;

        public int Mistakes
        {
            set
            {
                if (value > 7)
                {
                    Hanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    mistakes = value;
                    MistakesChanged?.Invoke(this, EventArgs.Empty);
                }
                this.Refresh();
            }
            get { return mistakes; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int thickness = 2;
            int h = 20;
            int x = 0;
            int y = 200;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black, thickness);
            switch (Mistakes)
            {
                case 0:
                    g.DrawLine(pen, x, y, x + 100, y);
                    g.DrawLine(pen, x + 50, y, x + 50, y - 200);
                    g.DrawLine(pen, x + 50, y - 180, x + 75, y - 200);
                    g.DrawLine(pen, x + 50, y - 200, x + 150, y - 200);
                    break;
                case 1:
                    goto case 0;
                case 2:
                    goto case 1;
                case 3:
                    goto case 2;
                case 4:
                    goto case 3;
                case 5:
                    goto case 4;
                case 6:
                    goto case 5;
                case 7:
                    goto case 6;
            }
        }



    }
}
