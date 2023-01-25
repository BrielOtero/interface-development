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
        private List<Chart> chartsData = null;
        private List<BarChart> charts = new List<BarChart>();
        private Config config = null;
        readonly string CONFIG_PATH = Path.Combine(Environment.GetEnvironmentVariable("APPDATA"), "BarChartConfig.json");
        public MainApp()
        {
            InitializeComponent();
            loadConfig();
        }

        private void loadConfig()
        {
            try
            {
                config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(CONFIG_PATH));
            }
            catch (Exception e)
            {
                config = new Config();
                Debug.WriteLine(e.Message);
            }
        }

        private void saveConfig()
        {
            try
            {
                string configFile = JsonConvert.SerializeObject(config);
                File.WriteAllText(CONFIG_PATH, configFile);
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                MessageBox.Show(this, "The program can't save the config", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void createCharts()
        {
            panel.Controls.Clear();
            Point position = new Point(0, 0);
            int i = 1;
            charts.ForEach(x =>
            {
                panel.Controls.Add(lblChartTitle(x.Name, position));
                position.Y += 10;
                x.Location = position;
                x.BarChartLineForecolor = config.LineColor;
                x.BarCharType = config.ViewType;
                x.Width = 300;
                x.Height = 150;
                if (i % config.Columns == 0)
                {
                    position.X = 0;
                    position.Y += x.Height;
                }
                else
                {
                    position.X += x.Width;
                }
                i++;
                panel.Controls.Add(x);
            });
        }

        private static Label lblChartTitle(string title, Point position)
        {
            Label label = new Label();
            label.Text = title;
            label.Location = position;
            label.Width = 100;
            label.Height = 50;
            return label;
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    chartsData = JsonConvert.DeserializeObject<List<Chart>>(File.ReadAllText(ofd.FileName));

                }
                catch (UnauthorizedAccessException ua)
                {
                    Console.WriteLine(ua.Message);
                    MessageBox.Show("File not compatible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("File not compatible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                charts = new List<BarChart>();

                chartsData.ForEach(x =>
                {
                    BarChart barChart = new BarChart();
                    barChart.Name = x.Name;
                    barChart.BarChartData = x.BarChartData;
                    barChart.TextAxisX = x.TextAxeX;
                    barChart.TextAxisY = x.TextAxeY;
                    charts.Add(barChart);
                });

                Debug.WriteLine(charts.Count);

                createCharts();
            }
        }

        private void tsmiConfigure_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration(config);
            if (configuration.ShowDialog() == DialogResult.Yes)
            {
                config = configuration.config;
                saveConfig();
                createCharts();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {

        }
    }
}
