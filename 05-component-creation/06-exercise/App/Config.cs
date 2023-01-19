using _06_exercise;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Config
    {
        public Config()
        {
            Columns = 5;
            ViewType = eBarChartType.COLUMNS;
            LineColor = Color.Black;
        }

        public int Columns { set; get; }
        public eBarChartType ViewType { set; get; }
        public Color LineColor { set; get; }
    }
}
