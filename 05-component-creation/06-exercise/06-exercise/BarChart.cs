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

namespace _06_exercise
{
    public partial class BarChart : UserControl
    {
        Color[] colors = new Color[] { Color.Green, Color.Blue, Color.Yellow };

        private List<float> barChartData = new List<float>() { 5, 2, 4, 5, 9, 3, 5, 6, 11, 1, 5, 5, 2, 4, 5, 9, 3, 5, 6, 11, 1, 5 };
        private eBarChartMode barChartMode = eBarChartMode.AUTOMATIC;
        private eBarChartType barChartType = eBarChartType.COLUMNS;
        private float barChartMaxY = 0;
        private Color barChartLineForecolor = Color.Black;
        private string textAxisX = "axis X";
        private string textAxisY = "axis Y";


        [Category("Property")]
        [Description("The that contains the data of the bars")]
        public List<float> BarChartData
        {
            set
            {
                barChartData = value;
                this.Refresh();
            }
            get { return barChartData; }
        }

        [Category("Property")]
        [Description("The property that change bar chart mode")]
        public eBarChartMode BarCharMode
        {
            set
            {
                barChartMode = value;
                this.Refresh();
            }
            get { return barChartMode; }
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
        public float BarChartMaxY
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
        public Color BarChartLineForecolor
        {
            set
            {
                this.barChartLineForecolor = value;
                this.Refresh();
            }
            get { return this.barChartLineForecolor; }
        }

        [Category("Property")]
        [Description("The property that shows as info in axe x")]
        public string TextAxisX
        {
            set
            {
                textAxisX = value;
                this.Refresh();
            }
            get { return textAxisX; }
        }

        [Category("Property")]
        [Description("The property that shows as info in axe y")]
        public string TextAxisY
        {
            set
            {
                textAxisY = value;
                this.Refresh();
            }
            get { return textAxisY; }
        }

        private float DEFAULT_UNIT_SCALE_X = 1f;
        private float DEFAULT_UNIT_SCALE_Y = 1f;

        private float DEFAULT_WIDTH;
        private float DEFAULT_HEIGHT;

        float UNIT_SCALE_X;
        float UNIT_SCALE_Y;

        public BarChart()
        {
            InitializeComponent();
            UNIT_SCALE_X = DEFAULT_UNIT_SCALE_X;
            UNIT_SCALE_Y = DEFAULT_UNIT_SCALE_Y;

            DEFAULT_WIDTH = (scaleX(barChartData.Count) * 2) + scaleX(5);
            DEFAULT_HEIGHT = scaleY(barChartData.Max()) + scaleY(3);

            this.Width = (int)DEFAULT_WIDTH;
            this.Height = (int)DEFAULT_HEIGHT;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (BarChartData.Count == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen;

            float margin = scaleX(2);
            float thickness = scaleX(2);

            float start_x = margin + scaleX(2);
            float start_y;

            float end_x = start_x;
            float end_y;

            float barY;
            float maxY = 0;
            float maxChartDataValue = scaleY(BarChartData.Max());

            Font font = new Font("Sans Serif", margin / 2);
            g.RotateTransform(90);
            g.DrawString(TextAxisY, font, new SolidBrush(Color.Black), maxChartDataValue / 2, -margin);
            g.ResetTransform();

            g.DrawString(TextAxisX, font, new SolidBrush(Color.Black), BarChartData.Count * margin / 2, maxChartDataValue);
            g.ResetTransform();


            switch (barChartType)
            {
                case eBarChartType.COLUMNS:

                    switch (barChartMode)
                    {
                        case eBarChartMode.AUTOMATIC:
                            maxY = maxChartDataValue + 1;
                            break;

                        case eBarChartMode.MANUAL:
                            maxY = scaleY(barChartMaxY);
                            break;
                    }

                    for (int i = 0; i < BarChartData.Count; i++)
                    {
                        barY = scaleY(BarChartData[i]);
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
                        end_x = start_x;
                    }
                    break;

                case eBarChartType.LINE:

                    end_x = start_x + margin;

                    for (int i = 0; i < BarChartData.Count - 1; i++)
                    {
                        start_y = maxChartDataValue - scaleY(BarChartData[i]);
                        end_y = maxChartDataValue - scaleY(BarChartData[i + 1]);

                        g.DrawLine(new Pen(new SolidBrush(BarChartLineForecolor)), start_x, start_y, end_x, end_y);

                        start_x += margin;
                        end_x = start_x + margin;
                    }
                    break;
            }
        }


        private float scaleX(float value) => UNIT_SCALE_X * value;
        private float scaleY(float value) => UNIT_SCALE_Y * value;

        private void barChart_SizeChanged(object sender, EventArgs e)
        {

            UNIT_SCALE_X = (this.Width * DEFAULT_UNIT_SCALE_X) / DEFAULT_WIDTH;
            UNIT_SCALE_Y = (this.Height * DEFAULT_UNIT_SCALE_Y) / DEFAULT_HEIGHT;
            this.Refresh();
        }
    }
}
