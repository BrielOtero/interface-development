using _06_exercise;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MainApp : Form
    {
        FileInfo file = null;
        List<Chart> chartsData = null;
        List<BarChart> charts = new List<BarChart>();
        Config config = null;
        public MainApp()
        {
            InitializeComponent();
            try
            {
                config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(Path.Combine(Environment.GetEnvironmentVariable("APPDATA"), "BarChartConfig.json")));
            }
            catch (Exception e)
            {
                config = new Config();
                Debug.WriteLine(e.Message);
            }

            loadConfig();

        }

        private void loadConfig()
        {
            Debug.WriteLine(config.LineColor);
            Debug.WriteLine(config.ViewType);
            charts.ForEach(x =>
            {
                x.BarChartLineForecolor = config.LineColor;
                x.BarCharType = config.ViewType;
            });

            panel.Controls.Clear();
            panel.Controls.AddRange(charts.ToArray());
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //try
            //{
            //file = new FileInfo(ofd.FileName);
            //chartsData = JsonConvert.DeserializeObject<List<Chart>>(File.ReadAllText(ofd.FileName));
            chartsData = JsonConvert.DeserializeObject<List<Chart>>(File.ReadAllText("C:\\Users\\ID\\git\\Class\\Interface-Development\\05-component-creation\\06-exercise\\charts.json"));

            //}
            //catch (UnauthorizedAccessException ua)
            //{
            //    Console.WriteLine(ua.Message);
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return;
            //}

            charts = new List<BarChart>();

            chartsData.ForEach(x =>
            {
                BarChart barChart = new BarChart();
                barChart.BarChartData = x.BarChartData;
                barChart.TextAxisX = x.TextAxeX;
                barChart.TextAxisY = x.TextAxeY;
                charts.Add(barChart);
            });

            Debug.WriteLine(charts.Count);

            Point position = new Point(0, 0);

            for (int i = 1; i <= charts.Count; i++)
            {
                charts[i-1].Location = position;
                charts[i-1].Width = 400;
                charts[i-1].Height = 300;

                if (i % config.Columns == 0)
                {
                    position.Y += charts[i-1].Height + 5;
                    position.X = 0;
                }
                else
                {
                    position.X += charts[i-1].Width;
                }

            }

            panel.Controls.AddRange(charts.ToArray());

            loadConfig();


            //}
        }

        private void tsmiConfigure_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration(config);
            if (configuration.ShowDialog() == DialogResult.Yes)
            {
                config = configuration.config;
                loadConfig();
                Debug.WriteLine("DialogResult Yes");
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {

        }
    }
}
