using System.Diagnostics;

namespace _02_exercise
{
    public partial class Form1 : Form
    {
        private Color defaultColor;
        public Form1()
        {
            InitializeComponent();
            defaultColor = color.BackColor;
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

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Focused || textBox2.Focused || textBox3.Focused)
                {
                    color.PerformClick();
                }
                else if (textBox4.Focused)
                {
                    background.PerformClick();
                }
            }
        }


        private void color_Click(object sender, EventArgs e)
        {
            changeColor();

        }

        private void background_Click(object sender, EventArgs e)
        {
            changeBackground();
        }

        private void buttons_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Aquamarine;
        }

        private void buttons_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = defaultColor;

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

        private void changeBackground()
        {
            try
            {
                label1.Image = new Bitmap(textBox4.Text);
            }
            catch (ArgumentException)
            {
                Trace.WriteLine("error with background");
            }
        }


    }
}