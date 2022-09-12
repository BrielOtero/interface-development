namespace _01_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = String.Format("= {0}", Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
            }
            catch (Exception)
            {
                label2.Text = "= wrong value inserted";
                throw;
            }
        }
    }
}