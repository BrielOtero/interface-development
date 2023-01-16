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
        private float UNIT_SCALE = 2f;


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
            float thickness = scale(2);
            float x = scale(0);
            float y = scale(200);
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
                 _____________ 1

            */

            float lineOneStartX = x;
            float lineOneStartY = y;
            float lineOneEndX = x + scale(100);
            float lineOneEndY = y;

            float lineTwoStartX = lineOneEndX / 2;
            float lineTwoStartY = y;
            float lineTwoEndX = lineTwoStartX;
            float lineTwoEndY = y - scale(200);

            float lineThreeStartX = lineTwoStartX;
            float lineThreeStartY = lineTwoEndY + scale(30);
            float lineThreeEndX = lineTwoStartX + scale(30);
            float lineThreeEndY = lineTwoEndY;

            float lineFourStartX = lineTwoStartX;
            float lineFourStartY = lineTwoEndY;
            float lineFourEndX = lineTwoStartX + scale(100);
            float lineFourEndY = lineTwoEndY;

            float lineFiveStartX = lineFourEndX;
            float lineFiveStartY = lineFourEndY;
            float lineFiveEndX = lineFiveStartX;
            float lineFiveEndY = y - scale(180);

            float headRadio = scale(30);
            float headStartX = x + scale(150) - (headRadio / 2);
            float headStartY = y - scale(180);

            float lineSixStartX = lineFiveEndX;
            float lineSixStartY = y - scale(180) + headRadio;
            float lineSixEndX = lineSixStartX;
            float lineSixEndY = headStartY + (headRadio / 2) + scale(100);

            float lineSevenStarX = lineSixEndX;
            float lineSevenStarY = lineSixStartY + scale(10);
            float lineSevenEndX = lineSevenStarX - scale(30);
            float lineSevenEndY = lineSevenStarY + scale(30);

            float lineEightStarX = lineSevenStarX;
            float lineEightStarY = lineSevenStarY;
            float lineEightEndX = lineSevenStarX + scale(30);
            float lineEightEndY = lineSevenStarY + scale(30);

            float lineNineStarX = lineEightStarX;
            float lineNineStarY = lineSixEndY - scale(1);
            float lineNineEndX = lineNineStarX - scale(30);
            float lineNineEndY = lineNineStarY + scale(30);

            float lineTenStarX = lineNineStarX;
            float lineTenStarY = lineNineStarY;
            float lineTenEndX = lineTenStarX + scale(30);
            float lineTenEndY = lineTenStarY + scale(30);


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

        private float scale(float value)
        {
            return value * UNIT_SCALE;
        }



    }
}
