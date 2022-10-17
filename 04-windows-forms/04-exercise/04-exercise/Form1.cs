using System.Collections;

namespace _04_exercise
{
    public partial class Form1 : Form
    {
        public delegate void Operate(double x, double y);
        Dictionary<String, Operate> operators;
        public Form1()
        {
            InitializeComponent();
            operators = new Dictionary<String, Operate>();
            operators.Add("+", (x, y) => label2.Text = "= " + (x + y));
            operators.Add("-", (x, y) => label2.Text = "= " + (x - y));
            operators.Add("x", (x, y) => label2.Text = "= " + (x * y));
            operators.Add("/", (x, y) => label2.Text = "= " + (x / y));


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
            double.TryParse(textBox1.Text, out double x);
            double.TryParse(textBox2.Text, out double y);

            operators[label1.Text].Invoke(x, y);
        }
    }
}