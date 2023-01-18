using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_exercise
{
    public partial class BarChart : UserControl
    {
        Color[] colors = new Color[] { Color.Green, Color.Blue, Color.Yellow };
        List<Double> chartData = new List<Double>() { 5, 2, 4, 5, 9, 3, 5, 6, 11, 1, 5 };

        private eBarChartMode barCharMode = eBarChartMode.AUTOMATIC;
        private eBarChartType barChartType = eBarChartType.COLUMNS;
        private double barChartMaxY = 0;
        private Color barChartForecolor = Color.Black;

        [Category("Property")]
        [Description("The property that change bar chart mode")]
        public eBarChartMode BarCharMode
        {
            set
            {
                barCharMode = value;
                this.Refresh();
            }
            get { return barCharMode; }
        }

        [Category("Property")]
        [Description("Type of bars to show")]
        public eBarChartType BarCharType
        {
            set
            {
                barChartType = value;
                this.Refresh();
            }
            get { return barChartType; }
        }

        [Category("Property")]
        [Description("The maximum property of Y in " + nameof(BarChart) + " with mode " + nameof(eBarChartMode.MANUAL))]
        public double BarChartMaxY
        {
            set
            {
                barChartMaxY = value;
                this.Refresh();
            }
            get { return barChartMaxY; }
        }

        [Category("Property")]
        [Description("Property color that changes the color of the line")]
        public Color BarChartForecolor
        {
            set
            {
                this.barChartForecolor = value;
                this.Refresh();
            }
            get { return this.barChartForecolor; }
        }

        private float DEFAULT_UNIT_SCALE_X = 1f;
        private float DEFAULT_UNIT_SCALE_Y = 1f;

        private int DEFAULT_WIDTH;
        private int DEFAULT_HEIGHT;

        float UNIT_SCALE_X;
        float UNIT_SCALE_Y;

        public BarChart()
        {
            InitializeComponent();
            UNIT_SCALE_X = DEFAULT_UNIT_SCALE_X;
            UNIT_SCALE_Y = DEFAULT_UNIT_SCALE_Y;

            DEFAULT_WIDTH = (int)((scaleX(chartData.Count) * 2) + scaleX(5));
            DEFAULT_HEIGHT = (int)(scaleY(chartData.Max()) + scaleY(3));

            this.Width = DEFAULT_WIDTH;
            this.Height = DEFAULT_HEIGHT;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen;

            float margin = scaleX(2);
            float thickness = scaleX(2);

            float start_x = margin;
            float start_y;

            float end_x = start_x + margin;
            float end_y;

            float barY;
            float maxY = 0;
            float maxChartDataValue = scaleY(chartData.Max());

            Font font = new Font("Sans Serif", margin / 2);
            g.RotateTransform(90);
            g.DrawString("eje Y", font, new SolidBrush(Color.Black), maxChartDataValue / 2, -margin);
            g.ResetTransform();

            g.DrawString("eje X", font, new SolidBrush(Color.Black), chartData.Count * margin / 2, maxChartDataValue);
            g.ResetTransform();


            switch (barCharMode)
            {
                case eBarChartMode.AUTOMATIC:
                    maxY = maxChartDataValue + 1;
                    break;

                case eBarChartMode.MANUAL:
                    maxY = scaleY(barChartMaxY);
                    break;
            }

            for (int i = 0; i < chartData.Count; i++)
            {
                barY = scaleY(chartData[i]);
                start_y = maxChartDataValue;
                end_y = maxChartDataValue - (barY > maxY ? maxY : barY);


                pen = new Pen(colors[i % 3], thickness);
                g.DrawLine(pen, start_x, start_y, end_x, end_y);

                if (end_y != barY)
                {
                    start_y = end_y;
                    end_y = maxChartDataValue - barY;
                    pen = new Pen(Color.Red, thickness);
                    g.DrawLine(pen, start_x, start_y, end_x, end_y);
                }

                start_x += margin;
                end_x += start_x + margin;
            }

            //for (int i = 0; i < chartData.Count - 1; i++)
            //{
            //    start_y = maxChartDataValue - scaleY(chartData[i]);
            //    end_y = maxChartDataValue - scaleY(chartData[i + 1]);

            //    g.DrawLine(new Pen(new SolidBrush(Color.Black)), start_x, start_y, end_x, end_y);

            //    start_x += margin;
            //    end_x += margin;
            //}





        }


        private float scaleX(double value) => UNIT_SCALE_X * (float)value;
        private float scaleY(double value) => UNIT_SCALE_Y * (float)value;

        private void BarChart_SizeChanged(object sender, EventArgs e)
        {

            UNIT_SCALE_X = (this.Width * DEFAULT_UNIT_SCALE_X) / DEFAULT_WIDTH;
            UNIT_SCALE_Y = (this.Height * DEFAULT_UNIT_SCALE_Y) / DEFAULT_HEIGHT;
            this.Refresh();
        }
    }
}
