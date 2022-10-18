using System.Collections;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace _04_exercise
{
    public partial class Form1 : Form
    {
        public delegate void Operate(double x, double y);
        private Timer timer = new Timer();
        private int timeSeconds = 0;

        Dictionary<String, Operate> operators;
        public Form1()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timerEventProcessor);
            timer.Interval = 1000;
            timer.Start();
            operators = new Dictionary<String, Operate>();
            operators.Add("+", (x, y) => label2.Text = (x + y) + "");
            operators.Add("-", (x, y) => label2.Text = (x - y) + "");
            operators.Add("x", (x, y) => label2.Text = (x * y) + "");
            operators.Add("/", (x, y) => label2.Text = (x / y) + "");


        }

        private void timerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            timeSeconds++;
            TimeSpan t = TimeSpan.FromSeconds(timeSeconds);
            this.Text = $"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}";
        }


        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                label1.Text = ((RadioButton)sender).Text.Substring(((RadioButton)sender).Text.IndexOf(' ') + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool correctX;
            bool correctY;

            correctX = double.TryParse(textBox1.Text, out double x);
            correctY = double.TryParse(textBox2.Text, out double y);


            if (!correctX || !correctY)
            {
                label2.Text = "Values not valid";
                label2.ForeColor = Color.Red;
                return;
            }

            if (y == 0 && label1.Text == "/")
            {
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }

            operators[label1.Text].Invoke(x, y);
        }

    }
}