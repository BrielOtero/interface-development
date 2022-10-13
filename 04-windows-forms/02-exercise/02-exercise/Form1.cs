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
     

        private void color_Click(object sender, EventArgs e)
        {
            changeColor();

        }

        private void closeForm()
        {
            if (MessageBox.Show("Are you sure you want exit?", "Mouse Tester", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void changeColor()
        {
            byte.TryParse(textBox1.Text, out byte red);
            byte.TryParse(textBox2.Text, out byte green);
            byte.TryParse(textBox3.Text, out byte blue);

            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void background_Click(object sender, EventArgs e)
        {
            label1.Image = new Bitmap(textBox4.Text);

              
        }
    }
}