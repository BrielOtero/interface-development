namespace _02_exercise
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


        private void exit_Click(object sender, EventArgs e)
        {
            closeForm();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                closeForm();
            }
        }
        private void closeForm()
        {
            if (MessageBox.Show("Are you sure you want exit?", "Mouse Tester", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                this.Dispose();
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            byte.TryParse(textBox1.Text, out byte red);
            byte.TryParse(textBox2.Text, out byte green);
            byte.TryParse(textBox3.Text, out byte blue);

        }
    }
}