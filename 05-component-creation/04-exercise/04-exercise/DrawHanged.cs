using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _04_exercise
{
    public partial class DrawHanged : UserControl
    {
        [Category("The Property Change")]
        [Description("Fired when the " + nameof(Mistakes) + " property change")]
        public event EventHandler MistakesChanged;

        [Category("The Property Change")]
        [Description("Fired when the " + nameof(Mistakes) + " is 7")]
        public event EventHandler Hanged;


        private int DEFAULT_WIDTH = 185;
        private int DEFAULT_HEIGHT = 205;

        private float DEFAULT_UNIT_SCALE_X = 1f;
        private float DEFAULT_UNIT_SCALE_Y = 1f;

        private float UNIT_SCALE_X;
        private float UNIT_SCALE_Y;


        public DrawHanged()
        {
            InitializeComponent();

            this.Width = DEFAULT_WIDTH;
            this.Height = DEFAULT_HEIGHT;

            UNIT_SCALE_X = DEFAULT_UNIT_SCALE_X;
            UNIT_SCALE_Y = DEFAULT_UNIT_SCALE_Y;

        }

        [Category("The Property Change")]
        [Description("Fired when the Mistakes property change")]
        private int mistakes;

        public int Mistakes
        {
            set
            {
                if (value >= 0)
                {
                    mistakes = value;
                    MistakesChanged?.Invoke(this, EventArgs.Empty);
                    this.Refresh();
                }

                if (value >= 7)
                {
                    Hanged?.Invoke(this, EventArgs.Empty);
                }
            }
            get { return mistakes; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            float thickness = scaleX(2);
            float x = scaleX(0);
            float y = scaleY(200);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black, thickness);

            /*
                           4
                        ________             
                       |/3    | 5
                       |      *  Head  
                       |    7/|\8
                     2 |      |6
                       |    9/ \10  
                       |     
                   ________ 1

            */

            float lineOneStartX = x;
            float lineOneStartY = y;
            float lineOneEndX = x + scaleX(100);
            float lineOneEndY = y;

            float lineTwoStartX = x + scaleX(100) / 2;
            float lineTwoStartY = y;
            float lineTwoEndX = lineTwoStartX;
            float lineTwoEndY = y - scaleY(200);

            float lineThreeStartX = x + scaleX(100) / 2;
            float lineThreeStartY = y - scaleY(200) + scaleY(30);
            float lineThreeEndX = lineThreeStartX + scaleX(30);
            float lineThreeEndY = y - scaleY(200);

            float lineFourStartX = x + scaleX(100) / 2;
            float lineFourStartY = y - scaleY(200);
            float lineFourEndX = lineFourStartX + scaleX(100);
            float lineFourEndY = lineFourStartY;

            float lineFiveStartX = x + (scaleX(100) / 2) + scaleX(100);
            float lineFiveStartY = y - scaleY(200);
            float lineFiveEndX = lineFiveStartX;
            float lineFiveEndY = y - scaleY(180);

            float headRadio = scaleX(30);
            float headStartX = x + scaleX(150) - (headRadio / 2);
            float headStartY = y - scaleY(180);

            float lineSixStartX = x + (scaleX(100) / 2) + scaleX(100);
            float lineSixStartY = y - scaleY(180) + headRadio;
            float lineSixEndX = lineSixStartX;
            float lineSixEndY = headStartY + (headRadio / 2) + scaleY(100);

            float lineSevenStarX = x + (scaleX(100) / 2) + scaleX(100);
            float lineSevenStarY = y - scaleY(180) + headRadio + scaleY(10);
            float lineSevenEndX = lineSevenStarX - scaleX(30);
            float lineSevenEndY = lineSevenStarY + scaleY(30);

            float lineEightStarX = x + (scaleX(100) / 2) + scaleX(100);
            float lineEightStarY = y - scaleY(180) + headRadio + scaleY(10);
            float lineEightEndX = lineEightStarX + scaleX(30);
            float lineEightEndY = lineEightStarY + scaleY(30);

            float lineNineStarX = x + (scaleX(100) / 2) + scaleX(100);
            float lineNineStarY = headStartY + (headRadio / 2) + scaleY(100) - scaleY(1);
            float lineNineEndX = lineNineStarX - scaleX(30);
            float lineNineEndY = lineNineStarY + scaleY(30);

            float lineTenStarX = x + (scaleX(100) / 2) + scaleX(100);
            float lineTenStarY = headStartY + (headRadio / 2) + scaleY(100) - scaleY(1);
            float lineTenEndX = lineTenStarX + scaleX(30);
            float lineTenEndY = lineTenStarY + scaleY(30);


            switch (Mistakes)
            {
                case 0:
                    g.DrawLine(pen, lineOneStartX, lineOneStartY, lineOneEndX, lineOneEndY);
                    g.DrawLine(pen, lineTwoStartX, lineTwoStartY, lineTwoEndX, lineTwoEndY);
                    g.DrawLine(pen, lineThreeStartX, lineThreeStartY, lineThreeEndX, lineThreeEndY);
                    g.DrawLine(pen, lineFourStartX, lineFourStartY, lineFourEndX, lineFourEndY);
                    break;
                case 1:
                    g.DrawLine(pen, lineFiveStartX, lineFiveStartY, lineFiveEndX, lineFiveEndY);
                    goto case 0;
                case 2:
                    g.DrawEllipse(pen, headStartX, headStartY, headRadio, headRadio);
                    goto case 1;
                case 3:
                    g.DrawLine(pen, lineSixStartX, lineSixStartY, lineSixEndX, lineSixEndY);
                    goto case 2;
                case 4:
                    g.DrawLine(pen, lineSevenStarX, lineSevenStarY, lineSevenEndX, lineSevenEndY);
                    goto case 3;
                case 5:
                    g.DrawLine(pen, lineEightStarX, lineEightStarY, lineEightEndX, lineEightEndY);
                    goto case 4;
                case 6:
                    g.DrawLine(pen, lineNineStarX, lineNineStarY, lineNineEndX, lineNineEndY);
                    goto case 5;
                case 7:
                    g.DrawLine(pen, lineTenStarX, lineTenStarY, lineTenEndX, lineTenEndY);
                    goto case 6;
            }
        }

        private float scaleX(float value) => value * UNIT_SCALE_X;

        private float scaleY(float value) => value * UNIT_SCALE_Y;


        private void DrawHanged_SizeChanged(object sender, EventArgs e)
        {
            UNIT_SCALE_X = (this.Width * DEFAULT_UNIT_SCALE_X) / DEFAULT_WIDTH;
            UNIT_SCALE_Y = (this.Height * DEFAULT_UNIT_SCALE_Y) / DEFAULT_HEIGHT;
            this.Refresh();
        }
    }
}
