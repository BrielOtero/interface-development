using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Chart
    {
        public string Name { set; get; }
        public string TextAxeX { set; get; }
        public string TextAxeY { set; get; }
        public List<float> BarChartData { set; get; }
    }
}
