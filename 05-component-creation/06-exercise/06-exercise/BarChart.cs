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
        List<Double> chartData = new List<Double>();

        private eBarChartMode barCharMode;

        public BarChart()
        {
            InitializeComponent();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color barColor;
            Graphics g = e.Graphics;
            int thinkness = 2;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen;


            double max = chartData.Max();

            int start_x = 5;
            int start_y = 5;
            int end_x = 5;
            int end_y = 5;



            switch (barCharMode)
            {
                case eBarChartMode.AUTOMATIC:
                    for (int i = 0; i < chartData.Count; i++)
                    {
                        pen = new Pen(Color.Black, thinkness);
                        g.DrawLine(pen, start_x, start_y, end_x, end_y);

                    }

                    break;

                case eBarChartMode.MANUAL:
                    break;
            }

        }
    }
}
