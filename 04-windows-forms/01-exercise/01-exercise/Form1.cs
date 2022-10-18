#define KEY
using System.Diagnostics;

namespace _01_exercise
{
    public partial class Form1 : Form
    {
        Color defaultColor;
        public Form1()
        {
            InitializeComponent();
            defaultColor = button1.BackColor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;

            if (sender is Button)
            {
                x += ((Button)sender).Location.X;
                y += ((Button)sender).Location.Y;
            }

            this.Text = $"X:{x} | Y:{y}";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Color leftColor = Color.Red;
            Color rightColor = Color.Blue;

            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {

                if (e.Button == MouseButtons.Left)
                {
                    button1.BackColor = leftColor;

                }

                if (e.Button == MouseButtons.Right)
                {
                    button2.BackColor = rightColor;
                }

            }
            else
            {
                button1.BackColor = leftColor;
                button2.BackColor = rightColor;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {

                if (e.Button == MouseButtons.Left)
                {
                    button1.BackColor = defaultColor;

                }

                if (e.Button == MouseButtons.Right)
                {
                    button2.BackColor = defaultColor;
                }

            }
            else
            {
                button1.BackColor = defaultColor;
                button2.BackColor = defaultColor;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
#if KEY
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else
            {
                this.Text = e.KeyCode.ToString();
            }
#endif
        }




        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

#if !KEY
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else
            {
                this.Text = e.KeyChar.ToString();
            }

#endif
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want exit?", "Mouse Tester", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}